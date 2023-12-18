using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OutSystems.NssXmlRecords
{
    class Test
    {
        static void Main(string[] args)
        {
            CssXmlRecords xr = new CssXmlRecords();
            RLRecordXmlConfigRecordList ssXmlConfig = new RLRecordXmlConfigRecordList();
            RCDefaultXmlConfigRecord ssDefaultConfig = new RCDefaultXmlConfigRecord();
            ssDefaultConfig.ssSTDefaultXmlConfig.ssExcludeIfNull = true;
            string ssXml;
            xr.MssRecordToXml(ssDefaultConfig, ssXmlConfig, ssDefaultConfig, out ssXml);
            Console.WriteLine(ssXml);
        }
    }
}
