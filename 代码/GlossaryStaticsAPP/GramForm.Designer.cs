namespace GlossaryStaticsAPP
{
    partial class GramForm
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
            this.GramLabel = new System.Windows.Forms.Label();
            this.oneGramChosen = new System.Windows.Forms.Button();
            this.twoGramChosen = new System.Windows.Forms.Button();
            this.threeGramChosen = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.markButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // GramLabel
            // 
            this.GramLabel.AutoSize = true;
            this.GramLabel.Font = new System.Drawing.Font("宋体", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.GramLabel.Location = new System.Drawing.Point(113, 19);
            this.GramLabel.Name = "GramLabel";
            this.GramLabel.Size = new System.Drawing.Size(298, 24);
            this.GramLabel.TabIndex = 0;
            this.GramLabel.Text = "请选择您要统计的分词类型";
            // 
            // oneGramChosen
            // 
            this.oneGramChosen.Location = new System.Drawing.Point(25, 83);
            this.oneGramChosen.Name = "oneGramChosen";
            this.oneGramChosen.Size = new System.Drawing.Size(131, 36);
            this.oneGramChosen.TabIndex = 1;
            this.oneGramChosen.Text = "一元分词";
            this.oneGramChosen.UseVisualStyleBackColor = true;
            this.oneGramChosen.Click += new System.EventHandler(this.oneGramChosen_Click);
            // 
            // twoGramChosen
            // 
            this.twoGramChosen.Location = new System.Drawing.Point(209, 83);
            this.twoGramChosen.Name = "twoGramChosen";
            this.twoGramChosen.Size = new System.Drawing.Size(131, 36);
            this.twoGramChosen.TabIndex = 2;
            this.twoGramChosen.Text = "二元分词";
            this.twoGramChosen.UseVisualStyleBackColor = true;
            this.twoGramChosen.Click += new System.EventHandler(this.twoGramChosen_Click);
            // 
            // threeGramChosen
            // 
            this.threeGramChosen.Location = new System.Drawing.Point(388, 83);
            this.threeGramChosen.Name = "threeGramChosen";
            this.threeGramChosen.Size = new System.Drawing.Size(131, 36);
            this.threeGramChosen.TabIndex = 3;
            this.threeGramChosen.Text = "三元分词";
            this.threeGramChosen.UseVisualStyleBackColor = true;
            this.threeGramChosen.Click += new System.EventHandler(this.threeGramChosen_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(56, 155);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 15);
            this.label1.TabIndex = 4;
            this.label1.Text = "分词符号（可选）:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(197, 152);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 25);
            this.textBox1.TabIndex = 5;
            // 
            // markButton
            // 
            this.markButton.Location = new System.Drawing.Point(379, 146);
            this.markButton.Name = "markButton";
            this.markButton.Size = new System.Drawing.Size(149, 36);
            this.markButton.TabIndex = 6;
            this.markButton.Text = "按分词符号分词";
            this.markButton.UseVisualStyleBackColor = true;
            this.markButton.Click += new System.EventHandler(this.markButton_Click);
            // 
            // GramForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(549, 194);
            this.Controls.Add(this.markButton);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.threeGramChosen);
            this.Controls.Add(this.twoGramChosen);
            this.Controls.Add(this.oneGramChosen);
            this.Controls.Add(this.GramLabel);
            this.Name = "GramForm";
            this.Text = "提示";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.GramForm_FormClosing);
            this.Load += new System.EventHandler(this.GramForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label GramLabel;
        private System.Windows.Forms.Button oneGramChosen;
        private System.Windows.Forms.Button twoGramChosen;
        private System.Windows.Forms.Button threeGramChosen;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button markButton;
    }
}