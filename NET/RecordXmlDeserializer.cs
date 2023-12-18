using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using OutSystems.HubEdition.RuntimePlatform.Db;
using System.Reflection;
using System.Xml;

using OutSystems.RuntimeCommon;
using OutSystems.HubEdition.RuntimePlatform;

namespace OutSystems.NssXmlRecords
{
    class RecordXmlDeserializer
    {
        XmlSerializerConfig _config = null;
        private RecordList _rl;


        public RecordXmlDeserializer(RecordList rl, XmlSerializerConfig config)
        {
            this._rl = rl;
            this._config = config;
        }

        public void Deserialize(XmlNodeList nodes)
        {
            this.Deserialize(nodes, _rl, string.Empty, true);
        }

        private void Deserialize(XmlNodeList nodes, RecordList rl, string parentHierarchy, bool validateRecordName)
        {
            if (!(rl.Current is IRecord)) {
                throw new NotImplementedException("Lists of basic types are not supported. Use lists of structures instead.");
            }

            string recName;
            ISimpleRecord dummyStructure;
            _config.TypeMapper.GetSimpleRecordInfo((IRecord)rl.Current, out recName, out dummyStructure);


            foreach (XmlNode node in nodes)
            {
                if (validateRecordName)
                {
                    string effectiveName = _config.GetConfig(parentHierarchy + "/" + recName).EffectiveName;
                    if (string.IsNullOrEmpty(effectiveName)) effectiveName = recName;
                    if (node.Name != effectiveName)
                        throw new ApplicationException("The current node (" + node.Name + ") does not match the record definition (" + recName + ")");
                }
                IRecord rec = _config.TypeMapper.GetEmptyRecord(rl);
                LoadRecord(rec, node, parentHierarchy);
                rl.Append(rec);

            }

        }

        internal void LoadRecord(IRecord rec, XmlNode node, string parentHierarchy)
        {

            string recName;
            ISimpleRecord structValue;
            FieldInfo recordTypeSubfield;
            _config.TypeMapper.GetSimpleRecordInfo(rec, out recName, out structValue, out recordTypeSubfield);
            
            FieldInfo[] attributes = structValue.GetType().GetFields(BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic);


            XmlSerializerAttributeConfig config = _config.GetConfig(parentHierarchy + "/" + recName);

            foreach (FieldInfo curField in attributes)
            {
                if (!curField.FieldType.IsSerializable || !curField.Name.TrimStart('_').StartsWith("ss"))
                    continue;

                bool isRecordList = typeof(RecordList).IsAssignableFrom(curField.FieldType);
                bool isRecord = curField.FieldType.GetInterface("IRecord") != null;

                // Remove platform ss prefix
                string attName = curField.Name.TrimStart('_');
                if (attName.StartsWith("ss"))
                    attName = attName.Substring(2);

                string tagName = config.AttributeName(attName);

                XmlNode elem;
                bool useContent = false;

                if (!string.IsNullOrEmpty(config.ContentPrefix) && tagName.StartsWith(config.ContentPrefix))
                {
                    elem = node != null ? node.SelectSingleNode("./text()") : node;
                    if (elem != null && elem.Value != null && elem.Value.Trim().Length > 0)
                        useContent = true;
                } 
                else if (!string.IsNullOrEmpty(config.AttributePrefix) && tagName.StartsWith(config.AttributePrefix))
                {
                    //remove attribute prefix
                    tagName = tagName.Substring(config.AttributePrefix.Length);

                    elem = node.Attributes[tagName];
                }
                else if (node.ChildNodes.Count > 1 || (node.ChildNodes.Count == 1 && node.ChildNodes[0].NodeType != XmlNodeType.Text))
                {
                    elem = node[tagName];
                    if (elem == null && isRecordList) 
                    {   // allow searching in sequence mode for recordlists
                        elem = node;
                    }
                }
                else
                {   //if node does not contain any child elements or just contains text, this means that we are not searching for
                    //a child but for the value of the element itself, this condition allow us to do this
                    elem = node;

                    if (node.Attributes[tagName] != null && !string.IsNullOrEmpty(node.Attributes[tagName].InnerXml))
                    {
                        elem = node.Attributes[tagName];
                    }
                }

                // Check for node not found or empty
                if (!useContent)
                {
                    if (elem == null || string.IsNullOrEmpty(elem.InnerXml))
                    {
                        if (isRecord || isRecordList)
                        {
                            if (elem == null || elem.Attributes.Count == 0)
                                continue;
                        }
                        else
                        {
                            //Try to look into the attributes, if there is no node
                            if (node.Attributes[tagName] != null && !string.IsNullOrEmpty(node.Attributes[tagName].InnerXml))
                            {
                                elem = node.Attributes[tagName];
                            }
                            else
                            {
                                continue;
                            }
                        }
                    }
                }

                if (isRecord)
                {
                    string childRecName;
                    ISimpleRecord childActualRecordType;
                    _config.TypeMapper.GetSimpleRecordInfo(curField.GetValue(structValue) as IRecord, out childRecName, out childActualRecordType);

                    XmlSerializerAttributeConfig childConfig = _config.GetConfig(parentHierarchy + "/" + childRecName);
                    childRecName = string.IsNullOrEmpty(childConfig.EffectiveName) ? childRecName : childConfig.EffectiveName;

                    if (elem.ChildNodes.Count == 1 && elem.ChildNodes[0].Name == childRecName)
                        elem = elem.ChildNodes[0];

                    IRecord curRec = _config.TypeMapper.GetEmptyRecord(curField.FieldType);
                    LoadRecord(curRec, elem, parentHierarchy + "/" + recName);
                    curField.SetValue(structValue, curRec);
                }
                else if (isRecordList)
                {
                    object rlValue = curField.GetValue(structValue);

                    IRecord childEmptyRec = _config.TypeMapper.GetEmptyRecord((RecordList)rlValue);

                    string childRecName;
                    ISimpleRecord childActualRecordType;
                    _config.TypeMapper.GetSimpleRecordInfo(childEmptyRec, out childRecName, out childActualRecordType);


                    XmlSerializerAttributeConfig childConfig = _config.GetConfig(parentHierarchy + "/" + childRecName);
                    childRecName = string.IsNullOrEmpty(childConfig.EffectiveName) ? childRecName : childConfig.EffectiveName;

                    this.Deserialize(elem.SelectNodes("./" + childRecName), rlValue as RecordList, parentHierarchy + "/" + recName, true);
                    RecordList resultList = (RecordList)rlValue;
                    if (resultList.Empty) //if the resultList is empty maybe the records are in sequence, lets try to retreive them by tagName
                    {                     //like the case of records, therefore we cannot validate record the name
                        this.Deserialize(elem.ParentNode.SelectNodes("./" + tagName), rlValue as RecordList, parentHierarchy, false);
                    }
                }
                else
                {
                    object val = null;
                    string textVal = useContent ? elem.Value.Trim() : elem.InnerText;
                    try {
                        val = _config.TypeMapper.StringToType(textVal, curField.FieldType) ;
                    } catch (Exception ex) {
                        throw new ApplicationException("Unable to convert xml value to structure type. Element: " + attName + "; Value: " + textVal + "; Error:" + ex.Message, ex);
                    }

                    curField.SetValue(structValue, val);
                }
            }

            if (recordTypeSubfield != null) {
                recordTypeSubfield.SetValue(rec, structValue);
            }
        }



    }
}
