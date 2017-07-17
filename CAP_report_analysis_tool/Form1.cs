using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace CAP_report_analysis_tool
{
    public partial class Form1 : Form
    {
        Work Worker = new Work();
        Report Report_obj = new Report();
        List<BaseReportLine> Ideal = new List<BaseReportLine>();
        List<BaseReportLine> Current = new List<BaseReportLine>();
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonLoadIdeal_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            FileStream ReadStream = new FileStream(openFileDialog1.FileName, FileMode.Open);
            StreamReader SR = new StreamReader(ReadStream);
            Ideal = Worker.FileParser(ReadStream);
            label1.Text = "ideal done";
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void buttonLoadCurrent_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            FileStream ReadStream = new FileStream(openFileDialog1.FileName, FileMode.Open);
            StreamReader SR = new StreamReader(ReadStream);
            Current = Worker.FileParser(ReadStream);
            SR.Close();
            label1.Text = "current done";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            saveFileDialog1.InitialDirectory = @"C:\Users\Artem Karugin\Work\Porsche\8. Development";
            saveFileDialog1.ShowDialog();
            FileStream FS = new FileStream(saveFileDialog1.FileName,FileMode.Truncate);
            StreamWriter SW = new StreamWriter(FS);
            foreach (string str in Worker.Analyse(Ideal, Current))
            {
                SW.WriteLine(str);
            }
            SW.Close();
            label1.Text = "analysis done";
        }
    }
}
