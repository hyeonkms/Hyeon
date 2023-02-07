using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Drawing.Printing;

namespace WForm
{
    public partial class NotePad : Form
    {
        #region (선언)
        StreamWriter m_sw;
        StreamReader m_sr;
        FileInfo m_fInfo;
        SearchForm m_Search = new SearchForm();
        ChangeForm m_Change = new ChangeForm();
        PrintDocument pd = new PrintDocument();

        bool m_isTxtChanged = false;
        string m_searchWord = string.Empty;
        #endregion

        #region (Form 생성자)
        public NotePad()
        {
            InitializeComponent();
        }
        #endregion

        #region (Event)
        private void txtNote_TextChanged(object sender, EventArgs e)
        {
            m_isTxtChanged = true;
        }

        private void 새로만들기NToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fn_NewMake();
        }

        private void 열기OToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fn_Open();
        }

        private void NotePadForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            fn_FormClosing(sender, e);
        }

        private void 저장SToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fn_TextSave();
        }

        private void 다른이름으로저장AToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fn_differentSave();
        }

        private void 페이지설정UToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fn_setUpPage();
        }

        private void 인쇄PToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (prdDialog.ShowDialog() == DialogResult.OK)//인쇄하기를 선택할 경우
            {
                pd.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(pd_PrintPage);
                pd.Print();//printDocument를 프린트 시작
            }
        }

        private void 끝내기XToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void 실행취소UToolStripMenuItem_Click(object sender, EventArgs e)
        {
            txtNote.Undo();
        }

        private void 잘라내기TToolStripMenuItem_Click(object sender, EventArgs e)
        {
            txtNote.Cut();
        }

        private void 복사CToolStripMenuItem_Click(object sender, EventArgs e)
        {
            txtNote.Copy();
        }

        private void 붙여넣기PToolStripMenuItem_Click(object sender, EventArgs e)
        {
            txtNote.Paste();
        }

        private void 삭제LToolStripMenuItem_Click(object sender, EventArgs e)
        {
            txtNote.SelectedText = string.Empty;
        }

        private void 찾기LToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fn_Search();
        }

        private void btnSearch_Click(object sender, EventArgs e) //'찾기' 의 다음찾기 버튼
        {
            fn_nextSearch();
        }

        private void 다음찾기NToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fn_nextSearch_this();
        }

        private void 바꾸기ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fn_Change();
        }

        private void btnChangeSearch_Click(object sender, EventArgs e) //'바꾸기' 의 다음찾기 버튼 이벤트
        {
            fn_nextChangeSearch();
        }

        private void btnChange_Click(object sender, EventArgs e) //'바꾸기'의 바꾸기 버튼 이벤트
        {
            fn_btnChange();
        }

        private void btnAllChange_Click(object sender, EventArgs e) //'바꾸기'의 모두 바꾸기 버튼 이벤트
        {
            fn_btnAllChange();
        }

        private void 모두선택AToolStripMenuItem_Click(object sender, EventArgs e)
        {
            txtNote.SelectAll();
        }

        private void 시간날짜DToolStripMenuItem_Click(object sender, EventArgs e)
        {
            txtNote.Text = DateTime.Now.ToString();
        }

        private void 자동줄바꿈WToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fn_wordWrap();
        }

        private void 글꼴FToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fn_Font();
        }
        //뭐 없음
        private void 메모장정보AToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }
        #endregion

        #region (Function)

        #region (저장 Function)
        private void fn_TextSave()
        {
            try
            {
                if (Text == "제목 없음")
                {
                    DialogResult sfd = sfdFile.ShowDialog();
                    if (sfd != DialogResult.Cancel)
                    {
                        fn_differentSave();
                    }
                }
                else
                {
                    m_sw = new StreamWriter(Text, false, Encoding.Default);
                    m_sw.Write(txtNote.Text);
                    m_sw.Flush();
                    m_sw.Close();
                }
                m_isTxtChanged = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        #endregion

        #region (열기 Function)
        private void fn_TextOpen()
        {
            try
            {
                DialogResult ofd = ofdFile.ShowDialog();
                if (ofd != DialogResult.Cancel)
                {
                    m_sr = new StreamReader(ofdFile.FileName, Encoding.Default);
                    txtNote.Text = m_sr.ReadToEnd();
                    m_sr.Close();
                    m_fInfo = new FileInfo(ofdFile.FileName);
                    Text = m_fInfo.Name;
                    m_isTxtChanged = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        #endregion

        #region (새로 만들기 Function)
        private void fn_NewMake()
        {
            try
            {
                if (m_isTxtChanged)
                {
                    DialogResult isYesNoCancel = MessageBox.Show(this.Text + "파일의 내용이 변경되었습니다.\r\n변경된 내용을 저장하시겠습니까?", "알림",
                                                 MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information);

                    switch (isYesNoCancel)
                    {
                        case DialogResult.Yes:
                            fn_TextSave();
                            txtNote.ResetText();
                            this.Text = "제목 없음";
                            break;
                        case DialogResult.No:
                            txtNote.ResetText();
                            Text = "제목 없음";
                            break;
                        case DialogResult.Cancel:
                            return;
                        default:
                            break;
                    }
                    m_isTxtChanged = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        #endregion

        #region (열기 Function)
        private void fn_Open()
        {
            try
            {
                if (m_isTxtChanged)
                {
                    DialogResult isYesNoCancel = MessageBox.Show(this.Text + "파일의 내용이 변경되었습니다.\r\n변경된 내용을 저장하시겠습니까?", "알림",
                                                MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information);

                    switch (isYesNoCancel)
                    {
                        case DialogResult.Yes:
                            fn_TextSave();
                            fn_TextOpen();
                            break;
                        case DialogResult.No:
                            fn_TextOpen();
                            break;
                        case DialogResult.Cancel:
                            return;
                        default:
                            break;
                    }
                }
                else
                    fn_TextOpen();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        #endregion

        #region (FormClosing Function)
        private void fn_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                e.Cancel = true; //Form의 종료를 막는다.
                if (m_isTxtChanged)
                {
                    DialogResult isYesNoCancel = MessageBox.Show(this.Text + "파일의 내용이 변경되었습니다.\r\n변경된 내용을 저장하시겠습니까?", "알림",
                                               MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information);

                    switch (isYesNoCancel)
                    {
                        case DialogResult.Yes:
                            if (Text == "제목 없음")
                            {
                                DialogResult sfd = sfdFile.ShowDialog();
                                if (sfd != DialogResult.Cancel)
                                {
                                    m_sw = new StreamWriter(sfdFile.FileName, false, Encoding.Default);
                                    m_sw.Write(txtNote.Text);
                                    m_sw.Flush();
                                    m_sw.Close();
                                }
                            }
                            else
                            {
                                m_sw = new StreamWriter(Text, false, Encoding.Default);
                                m_sw.Write(txtNote.Text);
                                m_sw.Flush();
                                m_sw.Close();
                            }
                            m_isTxtChanged = false;
                            Dispose();
                            break;
                        case DialogResult.No:
                            Dispose();
                            break;
                        case DialogResult.Cancel:
                            return;
                        default:
                            Dispose();
                            break;
                    }

                }
                else
                    Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        #endregion

        #region (다른이름으로 저장 Function)
        private void fn_differentSave()
        {
            try
            {
                DialogResult sfd = sfdFile.ShowDialog();
                if (sfd != DialogResult.Cancel)
                {
                    m_sw = new StreamWriter(sfdFile.FileName, false, Encoding.Default);
                    m_sw.Write(txtNote.Text);
                    m_sw.Flush();
                    m_sw.Close();
                    m_fInfo = new FileInfo(sfdFile.FileName);
                    Text = m_fInfo.Name;
                    m_isTxtChanged = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        #endregion

        #region (찾기 Function)
        private void fn_Search()
        {
            try
            {
                m_Search = new SearchForm();  //이거 없으면 Form 닫아다가 켜면 오류.
                m_Search.btnNextSearch.Click += new EventHandler(this.btnSearch_Click);
                m_Search.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        #endregion

        #region (SearchForm의 다음찾기 Function)
        private void fn_nextSearch()
        {
            try
            {
                int index = -1; //C계열에서 index는 0부터 시작하므로, -1로 초기화하면 아무것도 선택 안된 것임..
                string allText = this.txtNote.Text;
                string findWord = m_Search.txtSearch.Text;

                if (!m_Search.cbbUpLow.Checked)
                {
                    allText = allText.ToUpper();
                    findWord = findWord.ToUpper();
                }

                if (m_Search.rbtnUp.Checked)
                {
                    if (txtNote.SelectionStart != 0)
                        index = allText.LastIndexOf(findWord, this.txtNote.SelectionStart -1);//SelectionStart는 마우스 커서위치, -1은 위로 거기부터 찾아라.
                }
                else
                    index = allText.IndexOf(findWord, this.txtNote.SelectionStart + this.txtNote.SelectionLength);

                if (index == -1)
                {
                    MessageBox.Show("더 이상 찾는 문자열이 없습니다.");
                    return;
                }
                txtNote.Select(index, findWord.Length);
                m_searchWord = m_Search.txtSearch.Text;
                txtNote.Focus();
                txtNote.ScrollToCaret();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        #endregion

        #region (다음 찾기 Function)
        private void fn_nextSearch_this()
        {
            try
            {
                if (!(m_Search == null || !m_Search.Visible))
                {
                    m_Search.txtSearch.Text = this.m_searchWord;
                    this.btnSearch_Click(this, null);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        #endregion

        #region (바꾸기 Function)
        private void fn_Change()
        {
            try
            {
                m_Change = new ChangeForm();
                m_Change.btnNextSearch.Click += new EventHandler(this.btnChangeSearch_Click);
                m_Change.btnChange.Click += new EventHandler(this.btnChange_Click);
                m_Change.btnAllChange.Click += new EventHandler(this.btnAllChange_Click);
                m_Change.Show();
            }catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        #endregion

        #region ('바꾸기'의 다음 찾기 버튼 Function)
        private void fn_nextChangeSearch()
        {
            try
            {
                int index = -1; //C계열에서 index는 0부터 시작하므로, -1로 초기화하면 아무것도 선택 안된 것임..
                string allText = this.txtNote.Text;
                string findWord = m_Change.txtSearch.Text;

                index = allText.IndexOf(findWord, this.txtNote.SelectionStart + this.txtNote.SelectionLength);

                if (index == -1)
                {
                    MessageBox.Show("더 이상 찾는 문자열이 없습니다.");
                    return;
                }
                txtNote.Select(index, findWord.Length);
                m_searchWord = m_Change.txtSearch.Text;
                txtNote.Focus();
                txtNote.ScrollToCaret();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        #endregion

        #region ('바꾸기'의 바꾸기 버튼 Function)
        private void fn_btnChange()
        {
            try
            {
                txtNote.SelectedText = m_Change.txtChange.Text;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        #endregion

        #region ('바꾸기'의 모두 바꾸기 Function)
        private void fn_btnAllChange()
        {
            try
            {
                txtNote.Text = txtNote.Text.Replace(m_Change.txtSearch.Text.Trim(), m_Change.txtChange.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        #endregion

        #region (자동 줄바꿈 Function)
        private void fn_wordWrap()
        {
            try
            {
                this.txtNote.WordWrap = !(this.txtNote.WordWrap);
                자동줄바꿈WToolStripMenuItem.Checked = !(자동줄바꿈WToolStripMenuItem.Checked);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        #endregion

        #region (글꼴 Function)
        private void fn_Font()
        {
            try
            {
                if (this.fdText.ShowDialog() != DialogResult.Cancel)
                {
                    this.txtNote.Font = this.fdText.Font;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        #endregion

        #region (페이지 설정 Function)
        private void fn_setUpPage()
        {
            try
            {
                pd.DocumentName = txtNote.Text;
                psdDialog.Document = pd;
                psdDialog.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        #endregion

        #region (인쇄 Function)
        private void pd_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            try
            {
                String textPrint = txtNote.Text;
                Font printFont = new Font(txtNote.Font.Name, txtNote.Font.Size);//폰트 정보
                int leftMargin = e.MarginBounds.Left;//pagesetup이벤트 정보를 받아옴
                int topMargin = e.MarginBounds.Top;
                e.Graphics.DrawString(textPrint, printFont, Brushes.Black, leftMargin, topMargin);
                //그래픽스 개체의 드로우스트링 메소드를 사용해서 실제 텍스트를 그려줌
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        #endregion

        #endregion

    }
}

