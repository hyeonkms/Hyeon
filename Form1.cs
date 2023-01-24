using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnOk_Click(object sender, EventArgs e)
        {
            if (txtid.Text == "admin" && txtPassword.Text == "1234")        //로그인 정답 + SQL 미사용
            {
                this.Hide();    //Form1 창 숨김

                MainForm mainForm = new MainForm();
                mainForm.Show();        // mainForm 보여줌

                MessageBox.Show("환영합니다.");  //로그인 성공 알림
            }
            else
                MessageBox.Show("ID 혹은 비밀번호를 확인하십시오.");     //로그인 실패 알림
        }
    }
}
