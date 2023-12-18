using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using OutSystems.HubEdition.RuntimePlatform.Db;
using System.Reflection;
using System.Security;
using System.Globalization;

using OutSystems.RuntimeCommon;
using OutSystems.HubEdition.RuntimePlatform;

namespace OutSystems.NssXmlRecords
{
    
    class TypeMapper
    {

        private static readonly DateTime MinDate = new DateTime(1900, 1, 1);
        public string _decimalCulture = "en-US";
        public string _dateTimeFormat = null;
        public string _dateFormat = null;
        public string _timeFormat = null;

        public TypeMapper(STDefaultXmlConfigStructure defaultConfig)
        {
            if (!string.IsNullOrEmpty(defaultConfig.ssTypeDecimalCulture))
                this._decimalCulture = defaultConfig.ssTypeDecimalCulture;

            if (!string.IsNullOrEmpty(defaultConfig.ssTypeDateTimeFormat))
                this._dateTimeFormat = defaultConfig.ssTypeDateTimeFormat;

            if (!string.IsNullOrEmpty(defaultConfig.ssTypeDateFormat))
                this._dateFormat = defaultConfig.ssTypeDateFormat;

            if (!string.IsNullOrEmpty(defaultConfig.ssTypeTimeFormat))
                this._timeFormat = defaultConfig.ssTypeTimeFormat;

        }
        public string TypeToString(object value)
        {
            if (value is DateTime)
            {
                DateTime dVal = (DateTime)value;
                if (dVal <= MinDate)
                    return string.Empty;

                if (dVal.TimeOfDay == new TimeSpan(0))
                {
                    if (string.IsNullOrEmpty(_dateFormat))
                    {
                        return dVal.ToString("yyyy-MM-dd");
                    }
                    else
                    {
                        return dVal.ToString(_dateFormat);
                    }
                }
                else
                {
                    if (dVal.Date == MinDate)
                    {
                        if (string.IsNullOrEmpty(_timeFormat))
                        {
                            return dVal.ToString("HH:mm:ss");
                        }
                        else
                        {
                            return dVal.ToString(_timeFormat);
                        }
                    }
                    else
                    {
                        if (string.IsNullOrEmpty(_dateTimeFormat))
                        {
                            return dVal.ToString("s");
                        }
                        else
                        {
                            return dVal.ToString(_dateTimeFormat);
                        }
                    }
                }
            }
            else if (value is Decimal)
            {
                return SecurityElement.Escape(((Decimal)value).ToString(new CultureInfo(_decimalCulture)));
            }
            else
            {
                return SecurityElement.Escape(value.ToString());
            }
        }

        public object StringToType(string value, Type t)
        {
            if (t == typeof(String))
            {
                return value;
            }
            else if (t == typeof(Int32))
            {
                return Int32.Parse(value);
            }
            else if (t == typeof(Decimal))
            {
                return Decimal.Parse(value, new CultureInfo(_decimalCulture));
            }
            else if (t == typeof(Boolean))
            {
                value = value.Replace("1", "True").Replace("0", "False");
                return Boolean.Parse(value);
            }
            else if (t == typeof(Int64))
            {
                return Int64.Parse(value);
            }
            else if (t == typeof(DateTime))
            {
                if (value.Length > 10)
                {
                    if (string.IsNullOrEmpty(_dateTimeFormat))
                    {
                        return DateTime.ParseExact(value, "s", null);
                    }
                    else
                    {
                        return DateTime.ParseExact(value, _dateTimeFormat, null);
                    }
                }
                else
                {
                    if (value.Contains(":"))    // Not the best way, but since we do not have the XSD this is the way to detect times that cover most cultures
                    {
                        if (string.IsNullOrEmpty(_timeFormat))
                        {
                            DateTime dtAux = DateTime.ParseExact(value, "HH:mm:ss", null);
                            return MinDate.Add(dtAux.TimeOfDay);
                        }
                        else
                        {
                            return DateTime.ParseExact(value, _timeFormat, null);
                        }
                    }
                    else
                    {
                        if (string.IsNullOrEmpty(_dateFormat))
                        {
                            return DateTime.ParseExact(value, "yyyy-MM-dd", null);
                        }
                        else
                        {
                            return DateTime.ParseExact(value, _dateFormat, CultureInfo.InvariantCulture);
                        }
                    }
                }
            }
            else
            {
                throw new NotSupportedException("Not able to deserialize type " + t.ToString());
            }
        }

        public IRecord GetEmptyRecord(RecordList rl)
        {
            return GetEmptyRecord(rl.Current.GetType());
        }
        public IRecord GetEmptyRecord(Type recordType)
        {
            ConstructorInfo ci = recordType.GetConstructor(new Type[] { typeof(string[]) });
            string[] argString = new string[] { "" };
            return ci.Invoke(new object[] { argString }) as IRecord;
        }

        public void GetSimpleRecordInfo(IRecord rec, out String recName, out ISimpleRecord structValue) {
            FieldInfo dummy;
            GetSimpleRecordInfo(rec, out recName, out structValue, out dummy);
        }

        public void GetSimpleRecordInfo(IRecord rec, out String recName, out ISimpleRecord structValue, out FieldInfo recordTypeSubfield) {
            recordTypeSubfield = null;

            if (rec is ISimpleRecord) {

                // Try to fix the type names to what they would be without prefixes and suffixes ... but still very dependent of internals
                recName = rec.GetType().Name;
                if (recName.StartsWith("ST")) {
                    recName = recName.LeftCut("ST".Length);
                    if (recName.EndsWith("Structure")) {
                        recName = recName.RightCut("Structure".Length);
                    }
                } else if (recName.StartsWith("EN")) {
                    recName = recName.LeftCut("EN".Length);
                    if (recName.EndsWith("Entity")) {
                        recName = recName.RightCut("Entity".Length);
                    }
                }

                structValue = (ISimpleRecord)rec;

            } else {
                recordTypeSubfield = rec.GetType().GetFields().First(f => typeof(ISimpleRecord).IsAssignableFrom(f.FieldType));
                structValue = (ISimpleRecord)recordTypeSubfield.GetValue(rec);

                // Get name and remove platform ssST prefix
                recName = recordTypeSubfield.Name.RemoveIfStartsWith("ssST").RemoveIfStartsWith("ssEN");
            }
        }
    }
}
