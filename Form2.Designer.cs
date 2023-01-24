namespace WindowsFormsApp1
{
    partial class Form2
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
            this.gb1 = new System.Windows.Forms.GroupBox();
            this.txtSample = new System.Windows.Forms.TextBox();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.chk = new System.Windows.Forms.CheckBox();
            this.cb1 = new System.Windows.Forms.CheckBox();
            this.cboFont = new System.Windows.Forms.ComboBox();
            this.lbf = new System.Windows.Forms.Label();
            this.gb1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gb1
            // 
            this.gb1.Controls.Add(this.txtSample);
            this.gb1.Controls.Add(this.checkBox3);
            this.gb1.Controls.Add(this.chk);
            this.gb1.Controls.Add(this.cb1);
            this.gb1.Controls.Add(this.cboFont);
            this.gb1.Controls.Add(this.lbf);
            this.gb1.Location = new System.Drawing.Point(21, 35);
            this.gb1.Margin = new System.Windows.Forms.Padding(2);
            this.gb1.Name = "gb1";
            this.gb1.Padding = new System.Windows.Forms.Padding(2);
            this.gb1.Size = new System.Drawing.Size(402, 158);
            this.gb1.TabIndex = 0;
            this.gb1.TabStop = false;
            this.gb1.Text = "글꼴 설정";
            this.gb1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // txtSample
            // 
            this.txtSample.Location = new System.Drawing.Point(39, 106);
            this.txtSample.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtSample.Name = "txtSample";
            this.txtSample.Size = new System.Drawing.Size(226, 25);
            this.txtSample.TabIndex = 5;
            // 
            // checkBox3
            // 
            this.checkBox3.Location = new System.Drawing.Point(318, 112);
            this.checkBox3.Margin = new System.Windows.Forms.Padding(2);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(80, 20);
            this.checkBox3.TabIndex = 4;
            this.checkBox3.Text = "null";
            this.checkBox3.UseVisualStyleBackColor = true;
            // 
            // chk
            // 
            this.chk.Location = new System.Drawing.Point(318, 78);
            this.chk.Margin = new System.Windows.Forms.Padding(2);
            this.chk.Name = "chk";
            this.chk.Size = new System.Drawing.Size(80, 20);
            this.chk.TabIndex = 3;
            this.chk.Text = "이탤릭";
            this.chk.UseVisualStyleBackColor = true;
            this.chk.CheckedChanged += new System.EventHandler(this.chk_CheckedChanged);
            // 
            // cb1
            // 
            this.cb1.Location = new System.Drawing.Point(318, 44);
            this.cb1.Margin = new System.Windows.Forms.Padding(2);
            this.cb1.Name = "cb1";
            this.cb1.Size = new System.Drawing.Size(62, 20);
            this.cb1.TabIndex = 2;
            this.cb1.Text = "굵게";
            this.cb1.UseVisualStyleBackColor = true;
            this.cb1.CheckedChanged += new System.EventHandler(this.cb1_CheckedChanged);
            // 
            // cboFont
            // 
            this.cboFont.FormattingEnabled = true;
            this.cboFont.Location = new System.Drawing.Point(89, 40);
            this.cboFont.Margin = new System.Windows.Forms.Padding(2);
            this.cboFont.Name = "cboFont";
            this.cboFont.Size = new System.Drawing.Size(202, 23);
            this.cboFont.TabIndex = 1;
            this.cboFont.SelectedIndexChanged += new System.EventHandler(this.cboFont_SelectedIndexChanged);
            // 
            // lbf
            // 
            this.lbf.Location = new System.Drawing.Point(35, 40);
            this.lbf.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbf.Name = "lbf";
            this.lbf.Size = new System.Drawing.Size(50, 20);
            this.lbf.TabIndex = 0;
            this.lbf.Text = "Font";
            this.lbf.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(447, 220);
            this.Controls.Add(this.gb1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MinimizeBox = false;
            this.Name = "Form2";
            this.Text = "Font";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.gb1.ResumeLayout(false);
            this.gb1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gb1;
        private System.Windows.Forms.CheckBox cb1;
        private System.Windows.Forms.ComboBox cboFont;
        private System.Windows.Forms.Label lbf;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.CheckBox chk;
        private System.Windows.Forms.TextBox txtSample;
    }
}