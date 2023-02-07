namespace WForm
{
    partial class ChangeForm
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
            this.label2 = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.txtChange = new System.Windows.Forms.TextBox();
            this.btnNextSearch = new System.Windows.Forms.Button();
            this.btnChange = new System.Windows.Forms.Button();
            this.btnAllChange = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.cbbUpLow = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "찾을 내용(&N):";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 12);
            this.label2.TabIndex = 0;
            this.label2.Text = "바꿀 내용(&P):";
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(107, 19);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(200, 21);
            this.txtSearch.TabIndex = 0;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // txtChange
            // 
            this.txtChange.Location = new System.Drawing.Point(108, 52);
            this.txtChange.Name = "txtChange";
            this.txtChange.Size = new System.Drawing.Size(199, 21);
            this.txtChange.TabIndex = 1;
            // 
            // btnNextSearch
            // 
            this.btnNextSearch.Enabled = false;
            this.btnNextSearch.Location = new System.Drawing.Point(316, 15);
            this.btnNextSearch.Name = "btnNextSearch";
            this.btnNextSearch.Size = new System.Drawing.Size(101, 25);
            this.btnNextSearch.TabIndex = 3;
            this.btnNextSearch.Text = "다음 찾기(&F)";
            this.btnNextSearch.UseVisualStyleBackColor = true;
            // 
            // btnChange
            // 
            this.btnChange.Location = new System.Drawing.Point(316, 46);
            this.btnChange.Name = "btnChange";
            this.btnChange.Size = new System.Drawing.Size(101, 25);
            this.btnChange.TabIndex = 4;
            this.btnChange.Text = "바꾸기(&R)";
            this.btnChange.UseVisualStyleBackColor = true;
            // 
            // btnAllChange
            // 
            this.btnAllChange.Location = new System.Drawing.Point(316, 79);
            this.btnAllChange.Name = "btnAllChange";
            this.btnAllChange.Size = new System.Drawing.Size(101, 25);
            this.btnAllChange.TabIndex = 5;
            this.btnAllChange.Text = "모두 바꾸기(&A)";
            this.btnAllChange.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(316, 112);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(101, 25);
            this.btnCancel.TabIndex = 6;
            this.btnCancel.Text = "취소";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // cbbUpLow
            // 
            this.cbbUpLow.AutoSize = true;
            this.cbbUpLow.Location = new System.Drawing.Point(13, 129);
            this.cbbUpLow.Name = "cbbUpLow";
            this.cbbUpLow.Size = new System.Drawing.Size(125, 16);
            this.cbbUpLow.TabIndex = 2;
            this.cbbUpLow.Text = "대/소문자 구분(&C)";
            this.cbbUpLow.UseVisualStyleBackColor = true;
            // 
            // ChangeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(426, 179);
            this.Controls.Add(this.cbbUpLow);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnAllChange);
            this.Controls.Add(this.btnChange);
            this.Controls.Add(this.btnNextSearch);
            this.Controls.Add(this.txtChange);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "ChangeForm";
            this.ShowIcon = false;
            this.Text = "바꾸기";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.CheckBox cbbUpLow;
        public System.Windows.Forms.Button btnNextSearch;
        public System.Windows.Forms.Button btnChange;
        public System.Windows.Forms.Button btnAllChange;
        public System.Windows.Forms.TextBox txtSearch;
        public System.Windows.Forms.TextBox txtChange;
    }
}