namespace GlossaryStaticsAPP
{
    partial class SearchForm
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
            this.vocButton = new System.Windows.Forms.Button();
            this.vocBox = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.freButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.highBox = new System.Windows.Forms.TextBox();
            this.lowBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.popBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.rareBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.vocButton);
            this.groupBox1.Controls.Add(this.vocBox);
            this.groupBox1.Location = new System.Drawing.Point(39, 30);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(275, 210);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "查找词汇";
            // 
            // vocButton
            // 
            this.vocButton.Location = new System.Drawing.Point(81, 125);
            this.vocButton.Name = "vocButton";
            this.vocButton.Size = new System.Drawing.Size(75, 30);
            this.vocButton.TabIndex = 1;
            this.vocButton.Text = "确认";
            this.vocButton.UseVisualStyleBackColor = true;
            this.vocButton.Click += new System.EventHandler(this.vocButton_Click);
            // 
            // vocBox
            // 
            this.vocBox.Location = new System.Drawing.Point(39, 70);
            this.vocBox.Name = "vocBox";
            this.vocBox.Size = new System.Drawing.Size(171, 25);
            this.vocBox.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.freButton);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.highBox);
            this.groupBox2.Controls.Add(this.lowBox);
            this.groupBox2.Location = new System.Drawing.Point(335, 30);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(278, 210);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "根据词频范围生成表";
            // 
            // freButton
            // 
            this.freButton.Location = new System.Drawing.Point(103, 125);
            this.freButton.Name = "freButton";
            this.freButton.Size = new System.Drawing.Size(75, 30);
            this.freButton.TabIndex = 6;
            this.freButton.Text = "生成";
            this.freButton.UseVisualStyleBackColor = true;
            this.freButton.Click += new System.EventHandler(this.freButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(135, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(22, 15);
            this.label2.TabIndex = 5;
            this.label2.Text = "到";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(22, 15);
            this.label1.TabIndex = 4;
            this.label1.Text = "从";
            // 
            // highBox
            // 
            this.highBox.Location = new System.Drawing.Point(163, 70);
            this.highBox.Name = "highBox";
            this.highBox.Size = new System.Drawing.Size(69, 25);
            this.highBox.TabIndex = 3;
            // 
            // lowBox
            // 
            this.lowBox.Location = new System.Drawing.Point(60, 70);
            this.lowBox.Name = "lowBox";
            this.lowBox.Size = new System.Drawing.Size(69, 25);
            this.lowBox.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(36, 288);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(274, 15);
            this.label3.TabIndex = 8;
            this.label3.Text = "生成当前表词频排名前         词汇表";
            // 
            // popBox
            // 
            this.popBox.Location = new System.Drawing.Point(199, 282);
            this.popBox.Name = "popBox";
            this.popBox.Size = new System.Drawing.Size(60, 25);
            this.popBox.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(332, 288);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(259, 15);
            this.label4.TabIndex = 9;
            this.label4.Text = "生成当前词频排名后         词汇表";
            // 
            // rareBox
            // 
            this.rareBox.Location = new System.Drawing.Point(484, 282);
            this.rareBox.Name = "rareBox";
            this.rareBox.Size = new System.Drawing.Size(51, 25);
            this.rareBox.TabIndex = 10;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(120, 334);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 29);
            this.button1.TabIndex = 7;
            this.button1.Text = "生成";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(438, 334);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 29);
            this.button2.TabIndex = 11;
            this.button2.Text = "生成";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // SearchForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(640, 385);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.rareBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.popBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "SearchForm";
            this.Text = "查找框";
            this.Load += new System.EventHandler(this.SearchForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button vocButton;
        private System.Windows.Forms.TextBox vocBox;
        private System.Windows.Forms.Button freButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox highBox;
        private System.Windows.Forms.TextBox lowBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox popBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox rareBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}