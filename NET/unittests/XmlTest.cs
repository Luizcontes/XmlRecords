using System;
using NUnit.Framework;
using OutSystems.HubEdition.RuntimePlatform.Db;
using OutSystems.HubEdition.RuntimePlatform;
using System.Collections.Generic;

using OutSystems.RuntimeCommon;

namespace OutSystems.NssXmlRecords.unittests
{
	/// <summary>
	/// Summary description for XmlTest.
	/// </summary>
	[TestFixture]
    public class XmlTest
	{
        [Test]
        public void TestRecordToXml() 
        {
            string text = null;

            RCTestHierarchicalRecord r = GetExampleXml();

            CssXmlRecords xml = new CssXmlRecords();

            RLRecordXmlConfigRecordList config = new RLRecordXmlConfigRecordList();
            RCRecordXmlConfigRecord cgf = new RCRecordXmlConfigRecord();
            cgf.ssSTRecordXmlConfig.ssRecordName = "TestHierarchical";
            cgf.ssSTRecordXmlConfig.ssAttributesConfig = new RLAttributeXmlConfigRecordList();
            cgf.ssSTRecordXmlConfig.ssNamespace = "http://blabla";
            config.Append(cgf);

            RCDefaultXmlConfigRecord defConfig = new RCDefaultXmlConfigRecord();
            defConfig.ssSTDefaultXmlConfig.ssXmlDeclaration.ssSTXmlDeclaration.ssAddDeclaration = true;
            defConfig.ssSTDefaultXmlConfig.ssXmlDeclaration.ssSTXmlDeclaration.ssVersion = "1.0";
            defConfig.ssSTDefaultXmlConfig.ssXmlDeclaration.ssSTXmlDeclaration.ssEncoding = "UTF-8";

            xml.MssRecordToXml(r, config, defConfig, out text);
            Console.WriteLine("Text: " + text);


            RLTestHierarchicalRecordList rl = new RLTestHierarchicalRecordList();
            xml.MssXmlToRecordList(text, rl, null, true, "Attr_", defConfig, true, false);

            RCTestHierarchicalRecord des = (RCTestHierarchicalRecord)rl.Current;
            if (AreRecordsDifferent(des, r))
                throw new Exception("Serialized record is different from desserialized after first serialization/deserialization.");

            defConfig = new RCDefaultXmlConfigRecord();
            defConfig.ssSTDefaultXmlConfig.ssXmlDeclaration.ssSTXmlDeclaration.ssAddDeclaration = false;
            defConfig.ssSTDefaultXmlConfig.ssRecordMode = "S";
            defConfig.ssSTDefaultXmlConfig.ssRecordListMode = "S";
            defConfig.ssSTDefaultXmlConfig.ssTypeDecimalCulture = "pt-PT";
            defConfig.ssSTDefaultXmlConfig.ssTypeDateFormat = "dd-MM-yyyy";
            defConfig.ssSTDefaultXmlConfig.ssTypeDateTimeFormat = "dd.MM.yyyy HH:mm:ss";

            config = new RLRecordXmlConfigRecordList();
            cgf = new RCRecordXmlConfigRecord();
            cgf.ssSTRecordXmlConfig.ssRecordName = "TestHierarchical";
            cgf.ssSTRecordXmlConfig.ssAttributesConfig = new RLAttributeXmlConfigRecordList();
            cgf.ssSTRecordXmlConfig.ssNamespace = "http://blabla";
            cgf.ssSTRecordXmlConfig.ssEffectiveName = "MyTestHierarch";
            config.Append(cgf);

            xml.MssRecordToXml(des,config,defConfig, out text);
            Console.WriteLine("Text: " + text);

            rl = new RLTestHierarchicalRecordList();
            xml.MssXmlToRecordList(text, rl,config , true, "Attr_", defConfig, true, false);

            des = (RCTestHierarchicalRecord)rl.Current;
            if (AreRecordsDifferent(des, r))
                throw new Exception("Serialized record is different from desserialized after second serialization/deserialization.");

        
        
        }

        [Test]
        public void TestRecordListToXml()
        {
            string text = null;

            RLTestHierarchicalRecordList rl = new RLTestHierarchicalRecordList();
            List<RCTestHierarchicalRecord> rList = new List<RCTestHierarchicalRecord>();
            for (int i = 0; i < 3; i++)
            {
                RCTestHierarchicalRecord r = GetExampleXml();
                r.ssSTTestHierarchical.ssaString = "My string " + i;
                r.ssSTTestHierarchical.ssaRecordList.Reset();
                r.ssSTTestHierarchical.ssaRecordList.StartIteration();
                r.ssSTTestHierarchical.ssaRecordList.CurrentRec.ssSTTest.ssAttribute1 = "Att1_" + i + "_1";
                r.ssSTTestHierarchical.ssaRecordList.Advance();
                r.ssSTTestHierarchical.ssaRecordList.CurrentRec.ssSTTest.ssAttribute1 = "Att1_" + i + "_2";
                r.ssSTTestHierarchical.ssaRecordList.EndIteration();
                rList.Add(r);
                rl.Append(r);
            }
            
            CssXmlRecords xml = new CssXmlRecords();

            RLRecordXmlConfigRecordList config = new RLRecordXmlConfigRecordList();
            RCRecordXmlConfigRecord cgf = new RCRecordXmlConfigRecord();
            cgf.ssSTRecordXmlConfig.ssRecordName = "TestHierarchical";
            cgf.ssSTRecordXmlConfig.ssAttributesConfig = new RLAttributeXmlConfigRecordList();
            cgf.ssSTRecordXmlConfig.ssNamespace = "http://blabla";
            config.Append(cgf);

            RCDefaultXmlConfigRecord defConfig = new RCDefaultXmlConfigRecord();
            defConfig.ssSTDefaultXmlConfig.ssXmlDeclaration.ssSTXmlDeclaration.ssAddDeclaration = true;
            defConfig.ssSTDefaultXmlConfig.ssXmlDeclaration.ssSTXmlDeclaration.ssVersion = "1.0";
            defConfig.ssSTDefaultXmlConfig.ssXmlDeclaration.ssSTXmlDeclaration.ssEncoding = "UTF-8";

            xml.MssRecordListToXml(rl, config, defConfig, true, out text);
            Console.WriteLine("Text: " + text);


            rl = new RLTestHierarchicalRecordList();
            xml.MssXmlToRecordList(text, rl, null, true, "Attr_", defConfig, true, false);

            for (int i = 0; i < 3; i++)
            {
                RCTestHierarchicalRecord des = (RCTestHierarchicalRecord)rl[i];
                if (AreRecordsDifferent(des, rList[i]))
                    throw new Exception("Serialized record " + i + " is different from desserialized after first serialization/deserialization.");
            }
            
            defConfig = new RCDefaultXmlConfigRecord();
            defConfig.ssSTDefaultXmlConfig.ssXmlDeclaration.ssSTXmlDeclaration.ssAddDeclaration = false;
            defConfig.ssSTDefaultXmlConfig.ssRecordMode = "S";
            defConfig.ssSTDefaultXmlConfig.ssRecordListMode = "S";
            defConfig.ssSTDefaultXmlConfig.ssTypeDecimalCulture = "pt-PT";
            defConfig.ssSTDefaultXmlConfig.ssTypeDateFormat = "dd-MM-yyyy";
            defConfig.ssSTDefaultXmlConfig.ssTypeDateTimeFormat = "dd.MM.yyyy HH:mm:ss";

            config = new RLRecordXmlConfigRecordList();
            cgf = new RCRecordXmlConfigRecord();
            cgf.ssSTRecordXmlConfig.ssRecordName = "TestHierarchical";
            cgf.ssSTRecordXmlConfig.ssAttributesConfig = new RLAttributeXmlConfigRecordList();
            cgf.ssSTRecordXmlConfig.ssNamespace = "http://blabla";
            cgf.ssSTRecordXmlConfig.ssEffectiveName = "MyTestHierarch";
            config.Append(cgf);

            xml.MssRecordListToXml(rl, config, defConfig, true, out text);
            Console.WriteLine("Text: " + text);

            rl = new RLTestHierarchicalRecordList();
            xml.MssXmlToRecordList(text, rl, config, true, "Attr_", defConfig, true, false);

            for (int i = 0; i < 3; i++)
            {
                RCTestHierarchicalRecord des = (RCTestHierarchicalRecord)rl[i];
                if (AreRecordsDifferent(des, rList[i]))
                    throw new Exception("Serialized record " + i + " is different from desserialized after second serialization/deserialization.");
            }

        }

        private RCTestHierarchicalRecord GetExampleXml()
        {
            RCTestHierarchicalRecord r = new RCTestHierarchicalRecord(null);
            r.ssSTTestHierarchical.ssaString = "My string attribute";
            r.ssSTTestHierarchical.ssaInt = 123123;
            r.ssSTTestHierarchical.ssaDecimal = Convert.ToDecimal(-123123.213);
            r.ssSTTestHierarchical.ssaBoolean = true;
            r.ssSTTestHierarchical.ssaDate = BuiltInFunction.CurrDate();
            r.ssSTTestHierarchical.ssaDateTime = BuiltInFunction.CurrDateTime();
            r.ssSTTestHierarchical.ssaTime = BuiltInFunction.CurrTime();
            r.ssSTTestHierarchical.ssaRecordList = new RLTestRecordList();

            RCTestRecord rec = new RCTestRecord("");
            rec.ssSTTest.ssAttribute1 = "Att 1";
            rec.ssSTTest.ssAttribute2 = "Att 2";
            r.ssSTTestHierarchical.ssaRecordList.Append(rec);

            RCTestRecord rec2 = new RCTestRecord("");
            rec2.ssSTTest.ssAttribute3 = "Att 3";
            rec2.ssSTTest.ssAttribute4 = "Att 4";
            r.ssSTTestHierarchical.ssaRecordList.Append(rec2);

            r.ssSTTestHierarchical.ssaRecord.ssSTTest.ssAttribute1 = "Sub Att 1";
            r.ssSTTestHierarchical.ssaRecord.ssSTTest.ssAttribute2 = "Sub Att 2";
            r.ssSTTestHierarchical.ssaRecord.ssSTTest.ssAttribute3 = "Sub Att 3";
            r.ssSTTestHierarchical.ssaRecord.ssSTTest.ssAttribute4 = "Sub Att 4";

            return r;
        }
        private bool AreRecordsDifferent(RCTestHierarchicalRecord rec1, RCTestHierarchicalRecord rec2)
        {
            return rec1.ssSTTestHierarchical.ssaString != rec2.ssSTTestHierarchical.ssaString
               || rec1.ssSTTestHierarchical.ssaInt != rec2.ssSTTestHierarchical.ssaInt
               || rec1.ssSTTestHierarchical.ssaDecimal != rec2.ssSTTestHierarchical.ssaDecimal
               || rec1.ssSTTestHierarchical.ssaDate != rec2.ssSTTestHierarchical.ssaDate
               || rec1.ssSTTestHierarchical.ssaDateTime != rec2.ssSTTestHierarchical.ssaDateTime
               || rec1.ssSTTestHierarchical.ssaTime != rec2.ssSTTestHierarchical.ssaTime
               || rec1.ssSTTestHierarchical.ssaBoolean != rec2.ssSTTestHierarchical.ssaBoolean
               || rec1.ssSTTestHierarchical.ssaRecord != rec2.ssSTTestHierarchical.ssaRecord
               || rec1.ssSTTestHierarchical.ssaRecordList.Length != rec2.ssSTTestHierarchical.ssaRecordList.Length
               || rec1.ssSTTestHierarchical.ssaRecordList[0] != rec2.ssSTTestHierarchical.ssaRecordList[0]
               || rec1.ssSTTestHierarchical.ssaRecordList[1] != rec2.ssSTTestHierarchical.ssaRecordList[1];
        }
        
	}
}
