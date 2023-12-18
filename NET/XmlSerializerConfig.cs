using System;
using System.Collections.Generic;
using System.Text;

namespace OutSystems.NssXmlRecords
{
    class XmlSerializerConfig
    {
        private Dictionary<string, XmlSerializerAttributeConfig> _config;
        private STDefaultXmlConfigStructure _defaultConfig;
        private TypeMapper _typeMapper;

        public XmlSerializerConfig(RLRecordXmlConfigRecordList ssXmlConfig, STDefaultXmlConfigStructure defaultConfig)
        {

            _defaultConfig = defaultConfig == null ? new STDefaultXmlConfigStructure() : defaultConfig;
            _config = new Dictionary<string, XmlSerializerAttributeConfig>();

            _typeMapper = new TypeMapper(defaultConfig);

            if ((object)ssXmlConfig == null)
                return;

            ssXmlConfig.Reset();
            ssXmlConfig.StartIteration();
            while (!ssXmlConfig.Eof)
            {

                
                STRecordXmlConfigStructure structRecConf = ssXmlConfig.CurrentRec.ssSTRecordXmlConfig;
                RLAttributeXmlConfigRecordList attributesConfig = structRecConf.ssAttributesConfig;

                _config.Add(
                   structRecConf.ssRecordName,
                   new XmlSerializerAttributeConfig(
                       structRecConf.ssAttributesConfig, 
                       _defaultConfig, 
                       structRecConf.ssNamespace,
                       structRecConf.ssEffectiveName));

                ssXmlConfig.Advance();
            }
            ssXmlConfig.EndIteration();

        }

        public XmlSerializerAttributeConfig GetConfig(string recordHierarchicalName)
        {
            return InternalGetConfig(recordHierarchicalName);
        }

        private XmlSerializerAttributeConfig InternalGetConfig(string recordHierarchicalName)
        {

            recordHierarchicalName = recordHierarchicalName.TrimStart('/');

            if (_config.ContainsKey(recordHierarchicalName))
                return _config[recordHierarchicalName];
            
            if (recordHierarchicalName.LastIndexOf('/') > 0)
            {
                string baseName = recordHierarchicalName.Substring(recordHierarchicalName.LastIndexOf('/') + 1);
                string[] parents = recordHierarchicalName.Split('/');
                string hierarchy = string.Join("/", parents, 0, parents.Length - 2) + "/" + baseName;
                return InternalGetConfig(hierarchy);
            }
            else
            {
                return new XmlSerializerAttributeConfig(new RLAttributeXmlConfigRecordList(), _defaultConfig);
            }
        }

        public TypeMapper TypeMapper
        {
            get
            {
                return this._typeMapper;
            }
        }
    }
}
