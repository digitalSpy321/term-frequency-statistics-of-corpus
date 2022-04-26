using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GlossaryStaticsAPP
{
    public partial class PyForm : Form
    {
        public bool sflag = false;//记录是否为进入时打开
        public string pyFilePath = "";
        public PyForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            pyFileDialog.ShowDialog();
            textBox1.Text = pyFileDialog.FileName;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(textBox1.Text=="")
            {
                if (sflag)
                {
                    sflag = false;
                    DialogResult result = MessageBox.Show("你确定要跳过python环境的配置？",
                        "提示", MessageBoxButtons.YesNoCancel);
                    if (result == DialogResult.Yes)
                    {
                        pyFilePath = textBox1.Text;
                        this.DialogResult = DialogResult.OK;
                        this.Close();
                    }
                    else return;
                }
            }
            pyFilePath = textBox1.Text;
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void PyForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (sflag)
            {
                sflag = false;
                if (this.DialogResult != DialogResult.OK)
                {
                    DialogResult result = MessageBox.Show("你确定要跳过python环境的配置？",
                        "提示", MessageBoxButtons.YesNoCancel);
                    if (result == DialogResult.Yes)
                    {
                        pyFilePath = textBox1.Text;
                        this.DialogResult = DialogResult.OK;
                        e.Cancel = false;
                    }
                    else e.Cancel = true;
                }
            }
        }

        private void PyForm_Load(object sender, EventArgs e)
        {
            textBox1.Text = pyFilePath;
        }
    }
}
