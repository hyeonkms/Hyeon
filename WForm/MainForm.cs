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
    public partial class MainForm : Form
    #region(UI변경코드)
            //public partial class MainForm : MetroFramework.Forms.MetroForm
    #endregion
    {
    #region(사이드바 크기)
        //슬라이딩 메뉴의 최대, 최소 폭 크기
        const int MAX_SLIDING_WIDTH = 210;
        const int MIN_SLIDING_WIDTH = 52;
        //슬라이팅 메뉴가 보이는/접히는 속도
        const int STEP_SLIDING = 10;
        //최초 슬라이딩 메뉴 크기
        int PosSliding = 52;
        #endregion
    NotePad textform = new NotePad();
    Bu_f2 buttonForm = new Bu_f2();
    TestForm 텍스트폰트테스트 = new TestForm();
    Test_f3 테스트스크린 = new Test_f3();

    public MainForm()
        {
            InitializeComponent();
            //윈도우 현재시간
            toolStripStatusLabel1.Text = DateTime.Now.ToString();
        }
        private void MainForm_Load(object sender, EventArgs e)
        #region(상태표시 시간 불러오기)
        {//시간 불러오기
            timer1.Start();
        }
        #endregion
        private void timer1_Tick(object sender, EventArgs e)
        #region(상태표시 시간)
        {
            CultureInfo culture = CultureInfo.CreateSpecificCulture("ko-KR");
            toolStripStatusLabel1.Text = DateTime.Now.ToString(string.Format("yyyy-MM-dd HH:mm:ss (dddd)", culture));
        }
        #endregion
        private void 사이드바checkBox1_CheckedChanged(object sender, EventArgs e)
        #region(사이드바 애니메이션 시 버튼 표시)
        {
            if (사이드바checkBox1.Checked == true)
            {
                //슬라이딩 메뉴가 보였을 때, 메뉴 버튼의 표시
                사이드바button1.Text = "TextForm";
                사이드바button2.Text = "버튼애니메이션";
                사이드바button3.Text = "텍스트변환테스트";
                사이드바button4.Text = "버튼4";
                사이드바button5.Text = "버튼5";
                사이드바button6.Text = "버튼6";
                사이드바button7.Text = "버튼7";
                사이드바button8.Text = "8";
                사이드바button9.Text = "9";
                사이드바checkBox1.Text = "<";
            }
            else
            {
                //슬라이딩 메뉴 접혔을 때, 메뉴 버튼의 표시
                사이드바button1.Text = "";
                사이드바button2.Text = "2";
                사이드바button3.Text = "3";
                사이드바button4.Text = "4";
                사이드바button5.Text = "5";
                사이드바button6.Text = "6";
                사이드바button7.Text = "7";
                사이드바button8.Text = "8";
                사이드바button9.Text = "9";
                사이드바checkBox1.Text = ">";
            }
            //타미머 시작
            사이드바Timer.Start();
        }
        #endregion

        private void 사이드바Timer_Tick(object sender, EventArgs e)
        #region(사이드바 애니메이션 설정)
        {
            if (사이드바checkBox1.Checked == true)
            {
                //슬라이딩 메뉴를 보이는 동작
                PosSliding += STEP_SLIDING;
                if (PosSliding >= MAX_SLIDING_WIDTH)
                    사이드바Timer.Stop();
            }
            else
            {
                //슬라이딩 메뉴를 숨기는 동작
                PosSliding -= STEP_SLIDING;
                if (PosSliding <= MIN_SLIDING_WIDTH)
                    사이드바Timer.Stop();
            }

            사이드바panel1.Width = PosSliding;
        }
        #endregion

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        #region(폼 종료)
        {
            //폼 종료 결정
            DialogResult exit = MessageBox.Show("종료하시겠습니까?",
            "종료확인",
            MessageBoxButtons.YesNo,
            MessageBoxIcon.Information);
            //종료 취소
            if(exit == DialogResult.No)
            {
                e.Cancel = true;
            }
        }
        #endregion

        private void 사이드바button1_Click(object sender, EventArgs e)
        {
            textform = new NotePad();
            textform.Show();
        }

        private void 사이드바button2_Click(object sender, EventArgs e)
        {
            buttonForm = new Bu_f2();
            buttonForm.Show();

        }

        private void 사이드바button3_Click(object sender, EventArgs e)
        {
            텍스트폰트테스트 = new TestForm();
            텍스트폰트테스트.Show();
        }

        private void 사이드바button4_Click(object sender, EventArgs e)
        {
            테스트스크린 = new Test_f3();
            테스트스크린.Show();
        }
    }
}
