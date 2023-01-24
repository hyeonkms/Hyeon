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
    public partial class Form2 : Form
    {

        public Form2()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            var Fonts = FontFamily.Families;
            foreach (FontFamily Font in Fonts)
                cboFont.Items.Add(Font.Name);
        }       // 운영체제에 있는 폰트를 'cboFint' 컨트롤에 각 폰트 이름 추가

        void ChangeFont()
        {
            if (cboFont.SelectedIndex < 0)      //conFont에서 선택한 항목이 없으면 메소드 종료
                return;

            FontStyle style = FontStyle.Regular; // FontStyle 객체를 초기화

            if (cb1.Checked)
                style |= FontStyle.Bold;

            if (chk.Checked)
                style |= FontStyle.Italic;

            txtSample.Font =
                 new Font((string)cboFont.SelectedItem, 10, style); // 이녀석을 어떻해 변형할 것인가?
        }

        private void cb1_CheckedChanged(object sender, EventArgs e)
        {
            ChangeFont();       //이벤트 설정 55번 ~ 68번까지
        }

        private void chk_CheckedChanged(object sender, EventArgs e)
        {
            ChangeFont();
        }

        private void cboFont_SelectedIndexChanged(object sender, EventArgs e)
        {
            ChangeFont();
        }
    }
}
