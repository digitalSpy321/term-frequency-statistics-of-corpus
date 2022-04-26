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
    public partial class GramForm : Form
    {
        public string arg;
        public string exceptText="";//记录去除文字
        public string markSeg = "1";
        public GramForm()
        {
            InitializeComponent();
        }

        private void oneGramChosen_Click(object sender, EventArgs e)
        {
            arg = "1";
            exceptText = textBox1.Text;
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void twoGramChosen_Click(object sender, EventArgs e)
        {
            arg = "2";
            exceptText = textBox1.Text;
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void threeGramChosen_Click(object sender, EventArgs e)
        {
            arg = "3";
            exceptText = textBox1.Text;
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void markButton_Click(object sender, EventArgs e)
        {
            arg = "4";//标识按分词
            exceptText = textBox1.Text;
            if(exceptText=="")
            {
                MessageBox.Show("分词符号不能为空", "提示", MessageBoxButtons.OK);
                return;
            }
            markSeg = "0";
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void GramForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (this.DialogResult == DialogResult.OK)
            {
                DialogResult result = MessageBox.Show("您是否确定选择？", "提示", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                    e.Cancel = false;
                else
                    e.Cancel = true;
            }
        }

        private void GramForm_Load(object sender, EventArgs e)
        {

        }

    }
}
