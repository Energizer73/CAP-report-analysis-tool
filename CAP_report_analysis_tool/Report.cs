using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CAP_report_analysis_tool
{
    class Report
    {
       // public Dictionary<string,string>;  
    }
   public class BaseReportLine
    {
       public string CAP_id;
       public DateTime LastChangeDate;
       public string FullStringOfValues;

        public BaseReportLine(string ID, DateTime ChangeDate, string FullValue)
        {
            CAP_id = ID;
            LastChangeDate = ChangeDate;
            FullStringOfValues = FullValue;
        }
        public BaseReportLine()
        { }
    }
}
