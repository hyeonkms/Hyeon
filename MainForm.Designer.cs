namespace WindowsFormsApp1
{
    partial class MainForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.정보AToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ㅇㅇToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.메뉴MToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.글꼴설정ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.계산기ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.버튼ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.조사ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.홀수짝수구분ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.다른계산기DToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.종료EToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.를시작합니다ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label22 = new System.Windows.Forms.Label();
            this.txttxt = new System.Windows.Forms.TextBox();
            this.hScrollBar1 = new System.Windows.Forms.HScrollBar();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.정보AToolStripMenuItem,
            this.메뉴MToolStripMenuItem,
            this.종료EToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(3, 1, 0, 1);
            this.menuStrip1.Size = new System.Drawing.Size(659, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 정보AToolStripMenuItem
            // 
            this.정보AToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ㅇㅇToolStripMenuItem});
            this.정보AToolStripMenuItem.Name = "정보AToolStripMenuItem";
            this.정보AToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.A)));
            this.정보AToolStripMenuItem.Size = new System.Drawing.Size(59, 22);
            this.정보AToolStripMenuItem.Text = "정보(&A)";
            // 
            // ㅇㅇToolStripMenuItem
            // 
            this.ㅇㅇToolStripMenuItem.Name = "ㅇㅇToolStripMenuItem";
            this.ㅇㅇToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.ㅇㅇToolStripMenuItem.Text = "ㅇㅇ";
            // 
            // 메뉴MToolStripMenuItem
            // 
            this.메뉴MToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.글꼴설정ToolStripMenuItem,
            this.계산기ToolStripMenuItem,
            this.버튼ToolStripMenuItem,
            this.조사ToolStripMenuItem,
            this.홀수짝수구분ToolStripMenuItem,
            this.다른계산기DToolStripMenuItem});
            this.메뉴MToolStripMenuItem.Name = "메뉴MToolStripMenuItem";
            this.메뉴MToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.M)));
            this.메뉴MToolStripMenuItem.Size = new System.Drawing.Size(62, 22);
            this.메뉴MToolStripMenuItem.Text = "메뉴(&M)";
            // 
            // 글꼴설정ToolStripMenuItem
            // 
            this.글꼴설정ToolStripMenuItem.Name = "글꼴설정ToolStripMenuItem";
            this.글꼴설정ToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.P)));
            this.글꼴설정ToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
            this.글꼴설정ToolStripMenuItem.Text = "글꼴 설정(&P)";
            this.글꼴설정ToolStripMenuItem.Click += new System.EventHandler(this.글꼴설정ToolStripMenuItem_Click);
            // 
            // 계산기ToolStripMenuItem
            // 
            this.계산기ToolStripMenuItem.Name = "계산기ToolStripMenuItem";
            this.계산기ToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.E)));
            this.계산기ToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
            this.계산기ToolStripMenuItem.Text = "계산기(&E)";
            this.계산기ToolStripMenuItem.Click += new System.EventHandler(this.계산기ToolStripMenuItem_Click);
            // 
            // 버튼ToolStripMenuItem
            // 
            this.버튼ToolStripMenuItem.Name = "버튼ToolStripMenuItem";
            this.버튼ToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
            this.버튼ToolStripMenuItem.Text = "반복 버튼";
            // 
            // 조사ToolStripMenuItem
            // 
            this.조사ToolStripMenuItem.Name = "조사ToolStripMenuItem";
            this.조사ToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
            this.조사ToolStripMenuItem.Text = "조사";
            // 
            // 홀수짝수구분ToolStripMenuItem
            // 
            this.홀수짝수구분ToolStripMenuItem.Name = "홀수짝수구분ToolStripMenuItem";
            this.홀수짝수구분ToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
            this.홀수짝수구분ToolStripMenuItem.Text = "홀수 짝수 구분";
            // 
            // 다른계산기DToolStripMenuItem
            // 
            this.다른계산기DToolStripMenuItem.Name = "다른계산기DToolStripMenuItem";
            this.다른계산기DToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
            this.다른계산기DToolStripMenuItem.Text = "다른 계산기(&D)";
            // 
            // 종료EToolStripMenuItem
            // 
            this.종료EToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.를시작합니다ToolStripMenuItem});
            this.종료EToolStripMenuItem.Name = "종료EToolStripMenuItem";
            this.종료EToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.E)));
            this.종료EToolStripMenuItem.Size = new System.Drawing.Size(57, 22);
            this.종료EToolStripMenuItem.Text = "종료(&E)";
            // 
            // 를시작합니다ToolStripMenuItem
            // 
            this.를시작합니다ToolStripMenuItem.Name = "를시작합니다ToolStripMenuItem";
            this.를시작합니다ToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.를시작합니다ToolStripMenuItem.Text = "를 시작합니다.";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("굴림", 15F);
            this.label22.Location = new System.Drawing.Point(6, 20);
            this.label22.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(49, 20);
            this.label22.TabIndex = 2;
            this.label22.Text = "시간";
            // 
            // txttxt
            // 
            this.txttxt.Location = new System.Drawing.Point(11, 58);
            this.txttxt.Margin = new System.Windows.Forms.Padding(2);
            this.txttxt.Name = "txttxt";
            this.txttxt.Size = new System.Drawing.Size(626, 21);
            this.txttxt.TabIndex = 3;
            this.txttxt.Text = "Form2를 통해서 Text 변경 시도 중";
            this.txttxt.TextChanged += new System.EventHandler(this.txttxt_TextChanged);
            // 
            // hScrollBar1
            // 
            this.hScrollBar1.Location = new System.Drawing.Point(0, 512);
            this.hScrollBar1.Name = "hScrollBar1";
            this.hScrollBar1.Size = new System.Drawing.Size(993, 20);
            this.hScrollBar1.TabIndex = 4;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(659, 394);
            this.Controls.Add(this.txttxt);
            this.Controls.Add(this.hScrollBar1);
            this.Controls.Add(this.label22);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "MainForm";
            this.Text = "main";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 정보AToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 메뉴MToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 종료EToolStripMenuItem;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.ToolStripMenuItem 글꼴설정ToolStripMenuItem;
        private System.Windows.Forms.TextBox txttxt;
        private System.Windows.Forms.ToolStripMenuItem 계산기ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 버튼ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 조사ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ㅇㅇToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 를시작합니다ToolStripMenuItem;
        private System.Windows.Forms.HScrollBar hScrollBar1;
        private System.Windows.Forms.ToolStripMenuItem 홀수짝수구분ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 다른계산기DToolStripMenuItem;
    }
}