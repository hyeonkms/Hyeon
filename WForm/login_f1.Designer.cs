
namespace WForm
{
    partial class login_f1
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(login_f1));
            this.f1_id = new System.Windows.Forms.TextBox();
            this.f1_pw = new System.Windows.Forms.TextBox();
            this.f1_login_button = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // f1_id
            // 
            this.f1_id.Font = new System.Drawing.Font("돋움", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.f1_id.Location = new System.Drawing.Point(14, 85);
            this.f1_id.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.f1_id.Name = "f1_id";
            this.f1_id.Size = new System.Drawing.Size(298, 41);
            this.f1_id.TabIndex = 2;
            // 
            // f1_pw
            // 
            this.f1_pw.Font = new System.Drawing.Font("돋움", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.f1_pw.Location = new System.Drawing.Point(14, 131);
            this.f1_pw.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.f1_pw.MaxLength = 20;
            this.f1_pw.Name = "f1_pw";
            this.f1_pw.Size = new System.Drawing.Size(298, 41);
            this.f1_pw.TabIndex = 4;
            // 
            // f1_login_button
            // 
            this.f1_login_button.BackColor = System.Drawing.Color.SteelBlue;
            this.f1_login_button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.f1_login_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.f1_login_button.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.f1_login_button.FlatAppearance.BorderSize = 0;
            this.f1_login_button.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.f1_login_button.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.f1_login_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.f1_login_button.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.f1_login_button.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.f1_login_button.Location = new System.Drawing.Point(14, 194);
            this.f1_login_button.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.f1_login_button.Name = "f1_login_button";
            this.f1_login_button.Size = new System.Drawing.Size(298, 64);
            this.f1_login_button.TabIndex = 5;
            this.f1_login_button.Text = "로그인";
            this.f1_login_button.UseVisualStyleBackColor = false;
            this.f1_login_button.Click += new System.EventHandler(this.f1_login_button_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(46, 10);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(214, 56);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // login_f1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(325, 268);
            this.Controls.Add(this.f1_login_button);
            this.Controls.Add(this.f1_pw);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.f1_id);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "login_f1";
            this.Text = "Login";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox f1_id;
        private System.Windows.Forms.TextBox f1_pw;
        private System.Windows.Forms.Button f1_login_button;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

