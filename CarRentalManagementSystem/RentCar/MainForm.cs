using RentCar.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//using Exceptions.FakeVirtualMemberException    TODO : 말러에서 소스찾기.

namespace RentCar
{
    public partial class MainForm : Form
    { 
        public MainForm()
        {
            InitializeComponent();
        }    

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Activate();
            label4.Visible = true;
            label6.Visible = true;
            tbLoginId.Visible = true;
            tbLoginPw.Visible = true;
            btnLogin.Visible = true;
            btnAccount.Visible = true;
            btnMyinfo.Visible = false;
            btnLogout.Visible = false;

            MessageBox.Show("로그아웃 되었습니다.");
        }


        protected override void OnLoad(EventArgs e)
        {
            if (DesignMode)
                return;

            base.OnLoad(e);

            //LoginButton.Click += LoginButton_Click;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                if (tbLoginId.Text != string.Empty && tbLoginPw.Text != string.Empty)
                {
                    User user = Dao.User.GetByName(tbLoginId.Text);

                    if (user.LoginId == tbLoginId.Text && user.LoginPw == tbLoginPw.Text)
                    {
                        if (tbLoginId.Text == "admin")
                        {
                            if (user.LoginPw == tbLoginPw.Text)
                            {

                                MessageBox.Show("관리자님, 안녕하세요!");
                                label4.Visible = false;
                                label6.Visible = false;
                                tbLoginId.Visible = false;
                                tbLoginPw.Visible = false;
                                tbLoginId.Text = tbLoginPw.Text = "";
                            }
                            else
                                MessageBox.Show("잘못된 비밀번호입니다.");
                        }

                        if (tbLoginId.Text == "manager")
                        {
                            if (user.LoginPw == tbLoginPw.Text)
                            {
                                MessageBox.Show("매니저님, 안녕하세요!");
                                label4.Visible = false;
                                label6.Visible = false;
                                tbLoginId.Visible = false;
                                tbLoginPw.Visible = false;
                                tbLoginId.Text = tbLoginPw.Text = "";
                            }
                            else
                                MessageBox.Show("잘못된 비밀번호입니다.");
                        }

                        if (tbLoginId.Text != "admin" && tbLoginId.Text != "manager")
                        {
                            if (user.LoginPw == tbLoginPw.Text)
                            {
                                MessageBox.Show(tbLoginId.Text + "님, 안녕하세요!");
                                label4.Visible = false;
                                label6.Visible = false;
                                tbLoginId.Visible = false;
                                tbLoginPw.Visible = false;
                                btnLogin.Visible = false;
                                btnAccount.Visible = false;
                                btnMyinfo.Visible = true;
                                btnLogout.Visible = true;
                                tbLoginId.Text = tbLoginPw.Text = "";
                            }
                            else
                                MessageBox.Show("잘못된 비밀번호입니다.");
                        }
                    }
                }
            }
            catch
            {
                MessageBox.Show("아이디 혹은 비밀번호를 입력하세요.");

            }
        }

        private void btnAccount_Click(object sender, EventArgs e)
        {
            AccountForm showform = new AccountForm();
            showform.ShowDialog(); // 회원 가입 창 눌렀을 때 메인 폼 선택 안되게 변경.
        }
    }
}
