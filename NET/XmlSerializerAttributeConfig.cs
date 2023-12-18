using System;
using System.Collections.Generic;
using System.Text;

namespace OutSystems.NssXmlRecords
{
    public enum eRecordListMode
    {
        Child,
        Sequence
    }
    public enum eRecordMode
    {
        Child,
        Sequence
    }

    class XmlSerializerAttributeConfig
    {
        private Dictionary<string, STAttributeXmlConfigStructure> _config = new Dictionary<string, STAttributeXmlConfigStructure>();
        private STDefaultXmlConfigStructure _defaultConfig;
        private string _namespace = null;
        private string _effectiveName = null;

        public XmlSerializerAttributeConfig(RLAttributeXmlConfigRecordList attributesConfig, STDefaultXmlConfigStructure defaultConfig) : this(attributesConfig, defaultConfig, null, null) { }
        public XmlSerializerAttributeConfig(RLAttributeXmlConfigRecordList attributesConfig, STDefaultXmlConfigStructure defaultConfig, string namespaceXmlns, string effectiveName)
        {
            _defaultConfig = defaultConfig;
            attributesConfig.Reset();
            attributesConfig.StartIteration();

            while (!attributesConfig.Eof)
            {
                _config.Add(
                      attributesConfig.CurrentRec.ssSTAttributeXmlConfig.ssName,
                      attributesConfig.CurrentRec.ssSTAttributeXmlConfig);

                attributesConfig.Advance();
            }
            attributesConfig.EndIteration();

            this._namespace = namespaceXmlns;
            this._effectiveName = effectiveName;
        }

        public bool ExcludeIfNull(string attribute)
        {
            if(!_config.ContainsKey(attribute)) 
                return _defaultConfig.ssExcludeIfNull;

            return _config[attribute].ssExcludeIfNull;
        }

        public eRecordListMode RecordListMode(string attribute)
        {
            if (!_config.ContainsKey(attribute))
                return _defaultConfig.ssRecordListMode == "S" ? eRecordListMode.Sequence : eRecordListMode.Child;

            return _config[attribute].ssRecordListMode == "S" ? eRecordListMode.Sequence : eRecordListMode.Child;
        }

        public eRecordMode RecordMode(string attribute)
        {
            if (!_config.ContainsKey(attribute))
                return _defaultConfig.ssRecordMode == "S" ? eRecordMode.Sequence : eRecordMode.Child;

            return _config[attribute].ssRecordMode == "S" ? eRecordMode.Sequence : eRecordMode.Child;
        }

        public string NullValue(string attribute)
        {
            if (!_config.ContainsKey(attribute))
                return string.Empty;

            return _config[attribute].ssNullableValue;
        }

        public string AttributeName(string attribute)
        {
            if (!_config.ContainsKey(attribute))
                return attribute;

            return string.IsNullOrEmpty(_config[attribute].ssAttributeName) ? attribute : _config[attribute].ssAttributeName;
        }

        public string Namespace
        {
            get
            {
                return this._namespace;
            }
        }
        public string EffectiveName
        {
            get
            {
                return this._effectiveName;
            }
        }

        public string AttributePrefix
        {
            get
            {
                return _defaultConfig.ssAttributePrefix;
            }
        }

        public string ContentPrefix
        {
            get
            {
                return _defaultConfig.ssContentPrefix;
            }
        }
    }
}
