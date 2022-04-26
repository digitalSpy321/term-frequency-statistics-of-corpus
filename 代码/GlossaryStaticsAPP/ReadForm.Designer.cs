namespace GlossaryStaticsAPP
{
    partial class ReadForm
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.chooseFile = new System.Windows.Forms.Button();
            this.readFileBox = new System.Windows.Forms.TextBox();
            this.readFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // chooseFile
            // 
            this.chooseFile.Location = new System.Drawing.Point(462, 68);
            this.chooseFile.Name = "chooseFile";
            this.chooseFile.Size = new System.Drawing.Size(137, 46);
            this.chooseFile.TabIndex = 0;
            this.chooseFile.Text = "选择文件";
            this.chooseFile.UseVisualStyleBackColor = true;
            this.chooseFile.Click += new System.EventHandler(this.button1_Click);
            // 
            // readFileBox
            // 
            this.readFileBox.Location = new System.Drawing.Point(28, 81);
            this.readFileBox.Name = "readFileBox";
            this.readFileBox.Size = new System.Drawing.Size(415, 25);
            this.readFileBox.TabIndex = 1;
            // 
            // readFileDialog
            // 
            this.readFileDialog.Filter = "TextDocument(*.txt)|*.txt|TextDocument(*.ini)|*.ini";
            this.readFileDialog.Title = "请选择您要读取的txt文件";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(67, 150);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(280, 49);
            this.button2.TabIndex = 2;
            this.button2.Text = "确认";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // ReadForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(640, 235);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.readFileBox);
            this.Controls.Add(this.chooseFile);
            this.Name = "ReadForm";
            this.Text = "读取文件";
            this.Load += new System.EventHandler(this.ReadForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button chooseFile;
        private System.Windows.Forms.TextBox readFileBox;
        private System.Windows.Forms.OpenFileDialog readFileDialog;
        private System.Windows.Forms.Button button2;
    }
}

