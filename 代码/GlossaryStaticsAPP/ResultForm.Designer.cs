namespace GlossaryStaticsAPP
{
    partial class ResultForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.clearButton = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.glossaryLabel = new System.Windows.Forms.Label();
            this.addButton = new System.Windows.Forms.Button();
            this.ExcelButton = new System.Windows.Forms.Button();
            this.pictureButton = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.searchButton = new System.Windows.Forms.Button();
            this.saveExcelDialog = new System.Windows.Forms.SaveFileDialog();
            this.savePictureDialog = new System.Windows.Forms.SaveFileDialog();
            this.saveButton = new System.Windows.Forms.Button();
            this.pyButton = new System.Windows.Forms.Button();
            this.allButton = new System.Windows.Forms.Button();
            this.folderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.withDrawButton = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.withDrawButton);
            this.groupBox1.Controls.Add(this.clearButton);
            this.groupBox1.Controls.Add(this.button5);
            this.groupBox1.Controls.Add(this.glossaryLabel);
            this.groupBox1.Location = new System.Drawing.Point(20, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(280, 566);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "词表内容：";
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(9, 531);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(130, 29);
            this.clearButton.TabIndex = 2;
            this.clearButton.Text = "清除所有数据";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(182, 531);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(98, 29);
            this.button5.TabIndex = 1;
            this.button5.Text = "恢复原表";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // glossaryLabel
            // 
            this.glossaryLabel.AutoSize = true;
            this.glossaryLabel.Location = new System.Drawing.Point(6, 21);
            this.glossaryLabel.Name = "glossaryLabel";
            this.glossaryLabel.Size = new System.Drawing.Size(82, 15);
            this.glossaryLabel.TabIndex = 0;
            this.glossaryLabel.Text = "请读取文件";
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(345, 15);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(155, 50);
            this.addButton.TabIndex = 1;
            this.addButton.Text = "添加文件";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // ExcelButton
            // 
            this.ExcelButton.Location = new System.Drawing.Point(345, 185);
            this.ExcelButton.Name = "ExcelButton";
            this.ExcelButton.Size = new System.Drawing.Size(155, 50);
            this.ExcelButton.TabIndex = 2;
            this.ExcelButton.Text = "将当前表生成Excel";
            this.ExcelButton.UseVisualStyleBackColor = true;
            this.ExcelButton.Click += new System.EventHandler(this.button2_Click);
            // 
            // pictureButton
            // 
            this.pictureButton.Location = new System.Drawing.Point(595, 185);
            this.pictureButton.Name = "pictureButton";
            this.pictureButton.Size = new System.Drawing.Size(155, 50);
            this.pictureButton.TabIndex = 3;
            this.pictureButton.Text = "将当前表生成图片";
            this.pictureButton.UseVisualStyleBackColor = true;
            this.pictureButton.Click += new System.EventHandler(this.button3_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(323, 262);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(470, 285);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // searchButton
            // 
            this.searchButton.Location = new System.Drawing.Point(595, 105);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(155, 50);
            this.searchButton.TabIndex = 5;
            this.searchButton.Text = "查找";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.button4_Click);
            // 
            // saveExcelDialog
            // 
            this.saveExcelDialog.FileName = "未命名表格.xlsx";
            this.saveExcelDialog.Filter = "xlsx文件|*.xlsx";
            // 
            // savePictureDialog
            // 
            this.savePictureDialog.FileName = "未命名图片.png";
            this.savePictureDialog.Filter = "png文件|*.png";
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(673, 546);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(105, 32);
            this.saveButton.TabIndex = 6;
            this.saveButton.Text = "图片另存为";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // pyButton
            // 
            this.pyButton.Location = new System.Drawing.Point(345, 105);
            this.pyButton.Name = "pyButton";
            this.pyButton.Size = new System.Drawing.Size(155, 50);
            this.pyButton.TabIndex = 7;
            this.pyButton.Text = "重新配置Python";
            this.pyButton.UseVisualStyleBackColor = true;
            this.pyButton.Click += new System.EventHandler(this.pyButton_Click);
            // 
            // allButton
            // 
            this.allButton.Location = new System.Drawing.Point(595, 15);
            this.allButton.Name = "allButton";
            this.allButton.Size = new System.Drawing.Size(155, 50);
            this.allButton.TabIndex = 8;
            this.allButton.Text = "读取文件夹所有文件";
            this.allButton.UseVisualStyleBackColor = true;
            this.allButton.Click += new System.EventHandler(this.allButton_Click);
            // 
            // withDrawButton
            // 
            this.withDrawButton.Location = new System.Drawing.Point(209, 12);
            this.withDrawButton.Name = "withDrawButton";
            this.withDrawButton.Size = new System.Drawing.Size(65, 32);
            this.withDrawButton.TabIndex = 3;
            this.withDrawButton.Text = "撤销";
            this.withDrawButton.UseVisualStyleBackColor = true;
            this.withDrawButton.Click += new System.EventHandler(this.withDrawButton_Click);
            // 
            // ResultForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 590);
            this.Controls.Add(this.allButton);
            this.Controls.Add(this.pyButton);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pictureButton);
            this.Controls.Add(this.ExcelButton);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.groupBox1);
            this.Location = new System.Drawing.Point(960, 540);
            this.Name = "ResultForm";
            this.Text = "操作窗";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ResultForm_FormClosing);
            this.Load += new System.EventHandler(this.ResultForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label glossaryLabel;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Button ExcelButton;
        private System.Windows.Forms.Button pictureButton;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.SaveFileDialog saveExcelDialog;
        private System.Windows.Forms.SaveFileDialog savePictureDialog;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Button pyButton;
        private System.Windows.Forms.Button allButton;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog;
        private System.Windows.Forms.Button withDrawButton;
    }
}