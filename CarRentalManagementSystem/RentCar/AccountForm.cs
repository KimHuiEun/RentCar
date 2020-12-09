using RentCar.Data;
using System;
using System.Windows.Forms;

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
            if (tbName.Text != "" || tbPhoneNumber.Text != "" || tbEmail.Text != "" || tbId.Text != "" || tbPassword.Text != "" || tbPasswordConfirm.Text != "" || tbLicense.Text != "")
            {

                if (tbPassword.Text != tbPasswordConfirm.Text)
                    MessageBox.Show("비밀번호를 다시 확인해주세요");
                else
                {
                    //DB에 넣는 소스
                    User user = new User();
                    user.Name = tbName.Text;
                    user.Phone = tbPhoneNumber.Text;
                    user.Email = tbEmail.Text;
                    user.LoginId = tbId.Text;
                    user.LoginPw = tbPassword.Text;
                    user.License = tbLicense.Text;
                    user.IssueDate = IssuedDate.Text;
                    Dao.User.Insert(user);

                    MessageBox.Show("회원가입이 완료되었습니다.");
                    Close();
                }
            }

            else
            {
                MessageBox.Show("모든 칸에 입력해주세요");
                this.Show();
            }
        }

        private void BtnBack_Click(object sender, EventArgs e)
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

        private void tbPasswordConfirm_TextChanged(object sender, EventArgs e)
        {
           /* if (tbPassword.Text != tbPasswordConfirm.Text)
                MessageBox.Show("비밀번호가 서로 다릅니다.");*/
        }
    }
}
