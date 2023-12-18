using System;
using System.Collections;
using System.Data;
using OutSystems.HubEdition.RuntimePlatform;

using OutSystems.HubEdition.RuntimePlatform.Db;
using System.Xml;
using System.Text;
using System.Xml.Linq;
using System.Linq;
using System.Text.RegularExpressions;

using OutSystems.RuntimeCommon;

namespace OutSystems.NssXmlRecords{

	public class CssXmlRecords: IssXmlRecords {

        /// <summary>
        /// Obtains the Xml Declaration to add befre the Xml serialization, based on the setting in the config
        /// </summary>
        private static string GetXmlDeclaration(RCDefaultXmlConfigRecord ssDefaultConfig)
        {
            STXmlDeclarationStructure config = ssDefaultConfig.ssSTDefaultXmlConfig.ssXmlDeclaration.ssSTXmlDeclaration;
            if (config.ssAddDeclaration)
            {
                return "<?xml version=\"" + config.ssVersion + "\" encoding=\"" + config.ssEncoding + "\"?>" + Environment.NewLine;
            }
            return string.Empty;
        }

        /// <summary>
        /// Exports a record list to an xml document that matches the hierarchy of the records underneath
        /// </summary>
        /// <param name="ssRecordList">The record to serialize to XML</param>
        /// <param name="ssXmlConfig">An hash of properties given to each record that allow configuring the exact format of export</param>
        /// <param name="ssDefaultConfig"></param>
        /// <param name="ssAddRootNode"></param>
        /// <param name="ssXml"></param>
        public void MssRecordListToXml(object ssRecordList, RLRecordXmlConfigRecordList ssXmlConfig, RCDefaultXmlConfigRecord ssDefaultConfig, bool ssAddRootNode, out string ssXml) {
            
            RecordList recordList = ssRecordList as RecordList;
            if (recordList == null)
                throw new ApplicationException("Parameter 'RecordList' must be a valid RecordList of Records of the type that you want to deserialize.");

            if (recordList.Empty)
                throw new ApplicationException("RecordList has no records.");

            RecordXmlSerializer serializer = new RecordXmlSerializer(new XmlSerializerConfig(ssXmlConfig, ssDefaultConfig));
            StringBuilder sb = new StringBuilder();

            if (ssAddRootNode) {
                sb.AppendLine("<RecordList>");
                serializer.IdentLevel++;
            }

            recordList.Reset();
            recordList.StartIteration();

            while (!recordList.Eof)
            {
                sb.Append(serializer.Serialize(recordList.Current as IRecord));

                recordList.Advance();
            }
            recordList.EndIteration();

            if (ssAddRootNode)
            {
                serializer.IdentLevel--;
                sb.AppendLine("</RecordList>");
            }
            ssXml = sb.ToString();

            //Remove all Empty Elements
            if (ssDefaultConfig.ssSTDefaultXmlConfig.ssExcludeIfNull)
            {
                string xmlOutput;
                xmlOutput = ClearXmlEmptyElements(ssXml);
                ssXml = xmlOutput;
            }

            ssXml = GetXmlDeclaration(ssDefaultConfig) + ssXml;
        } // MssRecordListToXml

        /// <summary>
        /// Exports a record to an xml document that matches the hierarchy of the structure
        /// </summary>
        /// <param name="ssRecord">The record to serialize to XML</param>
        /// <param name="ssXmlConfig">An hash of properties given to each record that allow configuring the exact format of export</param>
        /// <param name="ssDefaultConfig"></param>/
        /// <param name="ssXml"></param>
        public void MssRecordToXml(object ssRecord, RLRecordXmlConfigRecordList ssXmlConfig, RCDefaultXmlConfigRecord ssDefaultConfig, out string ssXml) {

            IRecord record = ssRecord as IRecord;
            if (record == null)
                throw new ApplicationException("Parameter 'Record' must be a valid IRecord.");

            RecordXmlSerializer serializer = new RecordXmlSerializer(new XmlSerializerConfig(ssXmlConfig, ssDefaultConfig.ssSTDefaultXmlConfig));
            StringBuilder sb = new StringBuilder();
            sb.Append(serializer.Serialize(record));
            ssXml = sb.ToString();

            //Remove all Empty Elements
            if (ssDefaultConfig.ssSTDefaultXmlConfig.ssExcludeIfNull)
            {
                string xmlOutput; 
                xmlOutput = ClearXmlEmptyElements(ssXml);
                ssXml = xmlOutput;
            }
            ssXml = GetXmlDeclaration(ssDefaultConfig) + ssXml;
        } // MssRecordToXml


        /// <summary>
        /// Load an XML and fill the RecordList given as argument with Records deserialized data.
        /// </summary>
        /// <param name="ssXml">The XML to deserialize. The top set of nodes must match the definition of the RecordList records</param>
        /// <param name="ssRecordList">RecordList of objects with the expected structure to load from the XML</param>
        /// <param name="ssXmlConfig"></param>
        /// <param name="ssIgnoreXMLDeclarationAndNS"></param>
        /// <param name="ssAttributePrefix"></param>
        /// <param name="ssDefaultConfig"></param>
        /// <param name="ssBypassRootRecordListNode"></param>
        public void MssXmlToRecordList(string ssXml, object ssRecordList, RLRecordXmlConfigRecordList ssXmlConfig, bool ssIgnoreXMLDeclarationAndNS, string ssAttributePrefix, RCDefaultXmlConfigRecord ssDefaultConfig, bool ssBypassRootRecordListNode, bool ssBypassComments) {
            
            RecordList recordList = ssRecordList as RecordList;
            if ((object)recordList == null)
                throw new ApplicationException("Parameter 'RecordList' must be a valid RecordList of Records of the type that you want to deserialize.");

            XmlDocument doc = null;
            try
            {
                doc = new XmlDocument();
                if (ssIgnoreXMLDeclarationAndNS)
                {
                    int declarationEnd = ssXml.IndexOf("?>");
                    if (declarationEnd > 0)
                    {
                        ssXml = ssXml.Substring(declarationEnd + 2);
                    }
                    ssXml = ClearXmlNamespaces(ssXml);
                }
                doc.LoadXml(ssXml);

                if (ssBypassComments)
                {
                    XmlNodeList allComments = doc.SelectNodes("//comment()");
                    foreach (XmlNode n in allComments)
                    {
                        n.ParentNode.RemoveChild(n);
                    }
                }
            }
            catch (Exception ex)
            {
                throw new ApplicationException("Unable to load xml document: " + ssXml, ex);
            }

            if (!doc.HasChildNodes)
                throw new ApplicationException("The XML does not have a list of records (child nodes)");

            XmlNodeList nodes = doc.ChildNodes;
            if (nodes[0].Name == "RecordList" && ssBypassRootRecordListNode)
                nodes = nodes[0].ChildNodes;

            if (string.IsNullOrEmpty(ssDefaultConfig.ssSTDefaultXmlConfig.ssAttributePrefix))
                ssDefaultConfig.ssSTDefaultXmlConfig.ssAttributePrefix = ssAttributePrefix;

            RecordXmlDeserializer serializer = new RecordXmlDeserializer(recordList, new XmlSerializerConfig(ssXmlConfig, ssDefaultConfig));
            serializer.Deserialize(nodes);

		} // MssXmlToRecordList

        private static string ClearXmlNamespaces(string xml)
        {
     
            Regex vobjRegex = new Regex("<[^>]*((xmlns(:\\w+)?)|(xsi(:\\w+)?))\\s*=\\s*(\"[^\"]*\")[^>]*>");
            Regex vobjRegexReplace = new Regex("((xmlns(:\\w+)?)|(xsi(:\\w+)?))\\s*=\\s*(\"[^\"]*\")");

            Match vobjMatch = vobjRegex.Match(xml);

            while (vobjMatch.Success)
            {
                xml = xml.Replace(vobjMatch.Value, vobjRegexReplace.Replace(vobjMatch.Value, ""));

                vobjMatch = vobjRegex.Match(xml);
            }
            return xml;
        }

        private static string ClearXmlEmptyElements(string xml)
        {

            var document = XDocument.Parse(xml);
            document
                    .Descendants()
                    .Where(e => ( e.IsEmpty || IsNullOrWhiteSpace(e.Value) ) && e.Attributes().Count() == 0)
                    .Remove();

            xml = document.ToString();

            return xml;
        }

        //Check for Null or WhiteSpaces  
        private static bool IsNullOrWhiteSpace(String value)
        {
            if (value == null) return true;

            for (int i = 0; i < value.Length; i++)
            {
                if (!Char.IsWhiteSpace(value[i])) return false;
            }

            return true;
        }

        internal void MssRecordToXml(RCTestRecord tr)
        {
            throw new NotImplementedException();
        }
    } // CssXmlRecords

} // OutSystems.NssXmlRecords

