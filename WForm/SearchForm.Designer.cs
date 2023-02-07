namespace WForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnNextSearch = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.cbbUpLow = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbtnDown = new System.Windows.Forms.RadioButton();
            this.rbtnUp = new System.Windows.Forms.RadioButton();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "찾을 내용";
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(84, 15);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(235, 21);
            this.txtSearch.TabIndex = 0;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // btnNextSearch
            // 
            this.btnNextSearch.Enabled = false;
            this.btnNextSearch.Location = new System.Drawing.Point(325, 13);
            this.btnNextSearch.Name = "btnNextSearch";
            this.btnNextSearch.Size = new System.Drawing.Size(75, 23);
            this.btnNextSearch.TabIndex = 2;
            this.btnNextSearch.Text = "다음 찾기";
            this.btnNextSearch.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(325, 52);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 3;
            this.btnCancel.Text = "취소";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // cbbUpLow
            // 
            this.cbbUpLow.AutoSize = true;
            this.cbbUpLow.Location = new System.Drawing.Point(23, 59);
            this.cbbUpLow.Name = "cbbUpLow";
            this.cbbUpLow.Size = new System.Drawing.Size(106, 16);
            this.cbbUpLow.TabIndex = 1;
            this.cbbUpLow.Text = "대/소문자 구분";
            this.cbbUpLow.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbtnDown);
            this.groupBox1.Controls.Add(this.rbtnUp);
            this.groupBox1.Location = new System.Drawing.Point(135, 42);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(184, 45);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "방향";
            // 
            // rbtnDown
            // 
            this.rbtnDown.AutoSize = true;
            this.rbtnDown.Location = new System.Drawing.Point(86, 20);
            this.rbtnDown.Name = "rbtnDown";
            this.rbtnDown.Size = new System.Drawing.Size(59, 16);
            this.rbtnDown.TabIndex = 1;
            this.rbtnDown.TabStop = true;
            this.rbtnDown.Text = "아래로";
            this.rbtnDown.UseVisualStyleBackColor = true;
            // 
            // rbtnUp
            // 
            this.rbtnUp.AutoSize = true;
            this.rbtnUp.Location = new System.Drawing.Point(17, 20);
            this.rbtnUp.Name = "rbtnUp";
            this.rbtnUp.Size = new System.Drawing.Size(47, 16);
            this.rbtnUp.TabIndex = 0;
            this.rbtnUp.TabStop = true;
            this.rbtnUp.Text = "위로";
            this.rbtnUp.UseVisualStyleBackColor = true;
            // 
            // SearchForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(424, 99);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.cbbUpLow);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnNextSearch);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SearchForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "찾기";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.GroupBox groupBox1;
        public System.Windows.Forms.Button btnNextSearch;
        public System.Windows.Forms.TextBox txtSearch;
        public System.Windows.Forms.CheckBox cbbUpLow;
        public System.Windows.Forms.RadioButton rbtnDown;
        public System.Windows.Forms.RadioButton rbtnUp;
    }
}