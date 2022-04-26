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
using System.Diagnostics;

namespace GlossaryStaticsAPP
{
    public partial class ReadForm : Form
    {
        public string markSeg = "1";//0表示按分词符号分，1表示n-gram分
        public string gram;
        public string exceptText="";
        public string pyFilePath;
        
        public ReadForm()
        {
            InitializeComponent();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            readFileDialog.ShowDialog();
            readFileBox.Text = readFileDialog.FileName;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string[] strArr = new string[4];
            if (gram == "0")
            {
                GramForm gramForm1 = new GramForm();
                DialogResult result = gramForm1.ShowDialog();
                if (result != DialogResult.OK) return;
                markSeg = gramForm1.markSeg;
                gram = gramForm1.arg;
                exceptText = gramForm1.exceptText;
                strArr[0] = markSeg;//选择的分词类型
                strArr[1] = readFileDialog.FileName;
                strArr[2] = gramForm1.arg;
                strArr[3] = gramForm1.exceptText;
            }
            else
            {
                strArr[2] = gram;
                strArr[3] = exceptText;
            }
            

            PyRun.RunPythonScript(pyFilePath, "mainScript.py", "-u", strArr);
            this.DialogResult = DialogResult.OK;
            this.Close();
            
        }

        private void ReadForm_Load(object sender, EventArgs e)
        {

        }
    }
        
}
