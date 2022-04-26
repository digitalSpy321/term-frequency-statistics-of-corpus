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
    public partial class SearchForm : Form
    {
        public string scriptReturn;
        public string pyFilePath;
        public SearchForm()
        {
            InitializeComponent();
        }

        private void vocButton_Click(object sender, EventArgs e)
        {
            string[] strArr = new string[2];
            strArr[0] = "5";
            if (vocBox.Text != null)
            {
                strArr[1] = vocBox.Text;
                PyRun.RunPythonScript(pyFilePath, "mainScript.py", "-u", strArr);
                MessageBox.Show(scriptReturn, "结果", MessageBoxButtons.OK);
            }
            else
                MessageBox.Show("请输入查找词汇！", "提示", MessageBoxButtons.OK);
        }

        private void freButton_Click(object sender, EventArgs e)
        {
            string[] strArr = new string[3];
            strArr[0] = "4";
            if (lowBox.Text != null && highBox.Text!=null)
            {
                strArr[1] = lowBox.Text;
                strArr[2] = highBox.Text;
                PyRun.RunPythonScript(pyFilePath, "mainScript.py", "-u", strArr);
                this.DialogResult = DialogResult.OK;
                this.Close();

            }
            else
                MessageBox.Show("请输入词频！", "提示", MessageBoxButtons.OK);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string[] strArr = new string[2];
            strArr[0] = "2";
            if (popBox.Text != null)
            {
                strArr[1] = popBox.Text;
                PyRun.RunPythonScript(pyFilePath, "mainScript.py", "-u", strArr);
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
                MessageBox.Show("请输入词频！", "提示", MessageBoxButtons.OK);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string[] strArr = new string[2];
            strArr[0] = "3";
            if (rareBox.Text != null)
            {
                strArr[1] = rareBox.Text;
                PyRun.RunPythonScript(pyFilePath, "mainScript.py", "-u", strArr);
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
                MessageBox.Show("请输入词频！", "提示", MessageBoxButtons.OK);
        }

        private void SearchForm_Load(object sender, EventArgs e)
        {

        }
    }
}
