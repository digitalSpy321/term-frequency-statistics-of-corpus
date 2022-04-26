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
    public partial class ResultForm : Form
    {
        int flag = 0;
        string gram = "0";
        string exceptText = "";
        string markSeg = "1";//用于记录本批文件的分词规则
        string pyFilePath;
        public ResultForm()
        {
            InitializeComponent();
        }

        private void ResultForm_Load(object sender, EventArgs e)
        {
            flag = 1;
            FunLib.DelectDir(@"tmp");
            
            PyForm pyForm1 = new PyForm();
            pyForm1.sflag = true;
            DialogResult result1 = pyForm1.ShowDialog();
            if (result1 == DialogResult.OK)
            {
                pyFilePath = pyForm1.pyFilePath;
                flag = 0;
            }
            else
            {
                this.Close();
            };

        }

        private void button1_Click(object sender, EventArgs e)
        {
            PyRun.gloFlag = true;
            ReadForm readForm2 = new ReadForm();
            readForm2.gram = gram;
            readForm2.exceptText = exceptText;
            readForm2.markSeg = markSeg;
            readForm2.pyFilePath = pyFilePath;
            DialogResult result = readForm2.ShowDialog();
            gram = readForm2.gram;
            exceptText = readForm2.exceptText;
            markSeg = readForm2.markSeg;
            PyRun.gloFlag = false;
            if (result == DialogResult.OK)
            {
                if (PyRun.gloText != null)
                    glossaryLabel.Text = PyRun.gloText;
            }
            else return;


        }

        private void button2_Click(object sender, EventArgs e)
        {
            string[] strArr = new string[3];
            strArr[0] = "6";
            string localFilePath = "";
            DialogResult result= saveExcelDialog.ShowDialog();

            if (result == DialogResult.OK)
            {
                localFilePath = saveExcelDialog.FileName;
            }
            else return;
            strArr[1] = localFilePath;
            strArr[2] = gram;
            PyRun.RunPythonScript(pyFilePath, "mainScript.py", "-u", strArr);
            MessageBox.Show("已生成"+PyRun.scriptReturn, "提示", MessageBoxButtons.OK);

        }


        private void button5_Click(object sender, EventArgs e)
        {
            string[] strArr = new string[1];
            strArr[0] = "8";
            PyRun.RunPythonScript(pyFilePath, "mainScript.py", "-u", strArr);
            this.glossaryLabel.Text = PyRun.scriptReturn;

        }

        private void button3_Click(object sender, EventArgs e)
        {
            string[] strArr = new string[2];
            strArr[0] = "7";
            strArr[1] = @"tmp\tmp.png";
            PyRun.RunPythonScript(pyFilePath, "mainScript.py", "-u", strArr);
            if (File.Exists(@"tmp\tmp.png"))
            {
                System.Drawing.Image img = System.Drawing.Image.FromFile(@"tmp\tmp.png");
                System.Drawing.Image bmp = new System.Drawing.Bitmap(img);
                pictureBox1.Image = bmp;
                img.Dispose();
                MessageBox.Show("已生成" + PyRun.scriptReturn, "提示", MessageBoxButtons.OK);
            }
            else
            {
                MessageBox.Show("当前为空表，暂无生成图", "提示", MessageBoxButtons.OK);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            SearchForm searchForm1 = new SearchForm();
            searchForm1.pyFilePath = pyFilePath;
            DialogResult result = searchForm1.ShowDialog();
            if (result==DialogResult.OK && searchForm1.scriptReturn != null)
                glossaryLabel.Text = searchForm1.scriptReturn;
        }

        private void ResultForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (flag == 0)
            {
                DialogResult result = MessageBox.Show("你确认要关闭吗？", "提示", MessageBoxButtons.YesNoCancel);
                if (result == DialogResult.Yes)
                {
                    pictureBox1.Image = null;
                    FunLib.DelectDir(@"tmp");
                    e.Cancel = false;
                }
                else e.Cancel = true;
            }
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            string localFilePath = "";
            DialogResult result = savePictureDialog.ShowDialog();

            if (result == DialogResult.OK)
            {
                localFilePath = savePictureDialog.FileName;
            }
            else return;
            if (Directory.Exists(@"tmp\tmp.png") && Directory.Exists(localFilePath)) 
                File.Copy(@"tmp\tmp.png", localFilePath, true);
            else
            {
                string[] strArr = new string[2];
                strArr[0] = "7";
                strArr[1] = @"tmp\tmp.png";
                PyRun.RunPythonScript(pyFilePath, "mainScript.py", "-u", strArr);
                if (File.Exists(@"tmp\tmp.png"))
                {
                    System.Drawing.Image img = System.Drawing.Image.FromFile(@"tmp\tmp.png");
                    System.Drawing.Image bmp = new System.Drawing.Bitmap(img);
                    pictureBox1.Image = bmp;
                    img.Dispose();
                    File.Copy(@"tmp\tmp.png", localFilePath, true);
                    MessageBox.Show("已保存" + PyRun.scriptReturn, "提示", MessageBoxButtons.OK);
                }
                else
                {
                    MessageBox.Show("当前为空表，暂无生成图", "提示", MessageBoxButtons.OK);
                }
            }
        }

        private void pyButton_Click(object sender, EventArgs e)
        {
            PyForm pyForm1 = new PyForm();
            pyForm1.pyFilePath = pyFilePath;
            DialogResult result = pyForm1.ShowDialog();
            if (result == DialogResult.OK)
            {
                if(pyForm1.pyFilePath!="")
                pyFilePath = pyForm1.pyFilePath;

            }
            else
            {
                return;
            };
 

        }

        private void allButton_Click(object sender, EventArgs e)
        {
            DialogResult result1 = folderBrowserDialog.ShowDialog();
            if (result1 != DialogResult.OK) return;
            string dirPath = folderBrowserDialog.SelectedPath;
            GramForm gramForm1 = new GramForm();
            if (gram == "0")
            {
                DialogResult result2 = gramForm1.ShowDialog();
                if (result2 != DialogResult.OK) return;
                gram = gramForm1.arg;
            }
            foreach (string filename in Directory.GetFiles(dirPath, "*.txt", 
                SearchOption.AllDirectories))
            {
                string[] strArr = new string[3];
                strArr[0] = "1";
                strArr[1] = filename;
                strArr[2] = gram;
                PyRun.RunPythonScript(pyFilePath, "mainScript.py", "-u", strArr);
            }
            glossaryLabel.Text = PyRun.scriptReturn;

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            pictureBox1.Image = null;
            FunLib.DelectDir(@"tmp");
            glossaryLabel.Text = "数据已清除，请读取文件！";
            gram = "0";
        }

        private void withDrawButton_Click(object sender, EventArgs e)
        {
            string[] strArr = new string[1];
            strArr[0] = "9";
            PyRun.RunPythonScript(pyFilePath, "mainScript.py", "-u", strArr);
            this.glossaryLabel.Text = PyRun.scriptReturn;
        }
    }

}
