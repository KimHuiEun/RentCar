using System;
using System.Windows.Forms;
using RentCar.Data;

namespace RentCar
{
    public partial class AccountForm : Form
    {

        public AccountForm()
        {
            InitializeComponent();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            //try
            //{
                if (tbName.Text != "" || tbPhoneNumber.Text != "" || tbId.Text != "" || tbPassword.Text != "" || tbPasswordConfirm.Text != "" || tbLicense.Text != "")
                {
                    if (tbPassword.Text != tbPasswordConfirm.Text)
                        MessageBox.Show("비밀번호를 다시 확인해주세요");
                    else
                    {
                        //DB에 넣는 소스
                        User user = new User();
                        user.Name = tbName.Text;
                        user.Phone = tbPhoneNumber.Mask;
                        user.Email = tbEmail.Text;
                        user.LoginId = tbId.Text;
                        user.LoginPw = tbPassword.Text;
                        user.LoginPwConfirm = tbPasswordConfirm.Text;
                        user.License = tbLicense.Mask;
                        user.IssueDate = IssuedDate.CustomFormat;
                        Dao.User.Insert(user);


                        MessageBox.Show("회원가입이 완료되었습니다.");
                        Close();
                    }
                }
            
            
            //catch
            else
            {
                MessageBox.Show("모든 칸에 입력해주세요");
            }
        }



        private void back_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("회원가입을 취소하시겠습니까?", "회원가입취소", MessageBoxButtons.YesNo);

            if (dialogResult == DialogResult.Yes)
            {
                this.Close();
            }
            else if (dialogResult == DialogResult.No)
            {
                this.Show();
            }
        }
    }

}