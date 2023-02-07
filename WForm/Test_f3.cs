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

namespace WForm
{
    public partial class Test_f3 : Form
    {
        MainScreen.Screen1 s1 = new MainScreen.Screen1();
        MainScreen.Screen2 s2 = new MainScreen.Screen2();
        #region(사이드바 크기)
        //슬라이딩 메뉴의 최대, 최소 폭 크기
        const int MAX_SLIDING_WIDTH = 210;
        const int MIN_SLIDING_WIDTH = 52;
        //슬라이팅 메뉴가 보이는/접히는 속도
        const int STEP_SLIDING = 10;
        //최초 슬라이딩 메뉴 크기
        int PosSliding = 52;
        #endregion

        public Test_f3()
        {
            InitializeComponent();
        }

        private void Test_f3_Load(object sender, EventArgs e)
        {
            mainpanel.Controls.Add(s1);
        }
        private void button_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;

            switch (btn.Name)
            {
                case "button1":
                    mainpanel.Controls.Clear();
                    mainpanel.Controls.Add(s1);
                    break;
                case "button2":
                    mainpanel.Controls.Clear();
                    mainpanel.Controls.Add(s2);
                    break;
                case "button7":
                    Application.Exit();
                    break;
                default:
                    break;
            }
        }
        private void 사이드바checkBox1_CheckedChanged(object sender, EventArgs e)
        #region(사이드바 애니메이션 시 버튼 표시)
        {
            if (checkBox1.Checked == true)
            {
                //슬라이딩 메뉴 접혔을 때, 메뉴 버튼의 표시
                button1.Text = "";
                button2.Text = "2";
                button3.Text = "3";
                button4.Text = "4";
                button5.Text = "5";
                button6.Text = "6";
                button7.Text = "7";
                checkBox1.Text = ">";
            }
            else
            {
                //슬라이딩 메뉴가 보였을 때, 메뉴 버튼의 표시
                button1.Text = "";
                button2.Text = "dkd";
                button3.Text = "dkdd";
                button4.Text = "버튼4";
                button5.Text = "버튼5";
                button6.Text = "버튼6";
                button7.Text = "버튼7";
                checkBox1.Text = "<";
            }
            //타미머 시작
            timer1.Start();
        }
        #endregion

        private void 사이드바Timer_Tick(object sender, EventArgs e)
        #region(사이드바 애니메이션 설정)
        {
            if (checkBox1.Checked == true)
            {
                //슬라이딩 메뉴를 숨기는 동작
                PosSliding -= STEP_SLIDING;
                if (PosSliding <= MIN_SLIDING_WIDTH)
                    timer1.Stop();
            }
            else
            {
                //슬라이딩 메뉴를 보이는 동작
                PosSliding += STEP_SLIDING;
                if (PosSliding >= MAX_SLIDING_WIDTH)
                   timer1.Stop();
            }
            tableLayoutPanel1.Width = PosSliding;
            tableLayoutPanel2.Width = PosSliding;
        }
        #endregion

    }
}
