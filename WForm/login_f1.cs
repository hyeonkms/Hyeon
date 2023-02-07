using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WForm
{
    //상속 클래스 변경
    public partial class login_f1 : Form
    {
        public bool test = false;
        TextBox[] txtList;
        const string IdPlaceholder = "아이디";
        const string PwPlaceholder = "비밀번호";
        MainForm main = new MainForm();
        public login_f1()
        {
            InitializeComponent();

            //ID, Password TextBox Placeholder 설정
            txtList = new TextBox[] { f1_id, f1_pw };
            foreach (var txt in txtList)
            {
                //처음 공백 Placeholder 지정
                txt.ForeColor = Color.DarkGray;
                if (txt == f1_id) txt.Text = IdPlaceholder;
                else if (txt == f1_pw) txt.Text = PwPlaceholder;
                //텍스트박스 커서 Focus 여부에 따라 이벤트 지정
                txt.GotFocus += RemovePlaceholder;
                txt.LostFocus += SetPlaceholder;
            }

        }
        private void RemovePlaceholder(object sender, EventArgs e)
        #region(로그인 정보 입력값 설정)
        {
            TextBox txt = (TextBox)sender;
            if (txt.Text == IdPlaceholder | txt.Text == PwPlaceholder)
            { //텍스트박스 내용이 사용자가 입력한 값이 아닌 Placeholder일 경우에만, 커서 포커스일때 빈칸으로 만들기
                txt.ForeColor = Color.Black; //사용자 입력 진한 글씨
                txt.Text = string.Empty;
                if (txt == f1_pw) f1_pw.PasswordChar = '●';
            }
        }
        #endregion
        private void SetPlaceholder(object sender, EventArgs e)
        #region(로그인 정보 입력창 배경글씨)
        {
            TextBox txt = (TextBox)sender;
            if (string.IsNullOrWhiteSpace(txt.Text))
            {
                //사용자 입력값이 하나도 없는 경우에 포커스 잃으면 Placeholder 적용해주기
                txt.ForeColor = Color.DarkGray; //Placeholder 흐린 글씨
                if (txt == f1_id) txt.Text = IdPlaceholder;
                else if (txt == f1_pw) { txt.Text = PwPlaceholder; f1_pw.PasswordChar = default; }
            }
        }
        #endregion
        private void f1_login_button_Click(object sender, EventArgs e)
        #region(로그인 정보 확인)
        {
            //로그인 정보_추후 DB 적용해보기.
            string userID = f1_id.Text;
            string userPassword = f1_pw.Text;
            //로그인 데이터
            if (userID.Equals("admin") && userPassword.Equals("1234"))
            {
                //lofin_f1 숨김 및 MainForm 생성
                mainshow();
                //로그인 성공 메시지
                MessageBox.Show("환영합니다.");
                #region(예비)
                /*
                MainForm mainForm = new MainForm();
                mainForm.Show();
                this.Hide();
                 */
                ///로그인 폼 종료 및 메인폼 생성
                //실패
                /* Application.Run(new MainForm());
                 (new MainForm()).Show();
                 Application.Run();
                ->
                */
                #endregion
            }
            else
                //로그인 실패 메시지
                MessageBox.Show("ID 혹은 비밀번호를 확인하십시오.");
#endregion
        }
        #region(로그인 성공 시 폼 설정)
        private void mainshow()
        {   //로그인폼 숨긴 후 메인폼 생성, 로그인폼종료
            this.Hide();
            main = new MainForm();
            main.ShowDialog();
            this.Close();
        }
        #endregion
    }
}
