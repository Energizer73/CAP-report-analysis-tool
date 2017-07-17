using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace CAP_report_analysis_tool
{
    class Work
    {
        public List<BaseReportLine> FileParser(FileStream FS)
        {
            //BaseReportLine tempLine = new BaseReportLine();
            List<BaseReportLine> Result = new List<BaseReportLine>();
            StreamReader SR = new StreamReader(FS);
            List<string> templist = new List<string>();

            while (!SR.EndOfStream)
            {
                string temp = "";
                string tempvalue = "";
                DateTime tempDate = new DateTime();
                tempDate = DateTime.Now;
                string tempID = "";
                temp = SR.ReadLine();
                templist = temp.Split('\t').ToList();
                tempID = templist[0];
                DateTime.TryParse(templist[16].ToString(),out tempDate);
                foreach (string st in templist)
                {
                    tempvalue += st + ";";
                }
                
                //for (int i = 1; i < templist.Count; i++)
                //{
                //    value += templist[i] + ";";
                //}

                BaseReportLine tempLine = new BaseReportLine(tempID, tempDate, tempvalue);
                Result.Add(tempLine);
            }

            return Result;
        }



        public List<string> Analyse(List<BaseReportLine> Ideal_in, List<BaseReportLine> Current_in)
        {
            List<string> Result = new List<string>();
            DateTime IdealDate = new DateTime(2017, 01, 31);

            int i = 0;
            foreach (BaseReportLine CurrentLine in Current_in)
            {
                if (Ideal_in.Count(n => n.CAP_id == CurrentLine.CAP_id) == 1)
                {
                   BaseReportLine OutputLine = Ideal_in.Single(n => n.CAP_id == CurrentLine.CAP_id);
                   if (IdealDate < CurrentLine.LastChangeDate)
                   {
                       Result.Add(CurrentLine.FullStringOfValues);
                   }
                    //BaseReportLine OutputLine = Ideal_in.Single(n => n.CAP_id == CurrentLine.CAP_id && n.LastChangeDate <= CurrentLine.LastChangeDate);
                    
                    i++;
                }
                else
                {
                    //Result.Add(CurrentLine.FullStringOfValues);
                    //i++;
                }
            }
            return Result;
        }

        

    }
}
