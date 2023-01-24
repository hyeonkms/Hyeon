using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            label22.Text = DateTime.Now.ToString();     //윈도우 현재시간으로 보여줌
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            CultureInfo ciEn = new CultureInfo("en-US");    //요일 영어표기
            label22.Text = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss (dddd)", ciEn);   //24시간 표시 1초 단위로 변경
        }

        private void 글꼴설정ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 Form = new Form2();
            Form.Show();                //글꼴설정 시 팝업 창 보여줌
        }

        private void txttxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void 계산기ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form3 Form = new Form3();
            Form.Show();                //계산기 팝업 창 보여줌
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
         /*   if (MessageBox.Show("종료합니다.", "종료", MessageBoxButtons.YesNo)
    == DialogResult.Yes)
            {
                SeverClose(); //dd
                Dispose(true); //대기
            }
            else
            {
                e.Cancel = true;
                return;
            } */
        }
    }
}
