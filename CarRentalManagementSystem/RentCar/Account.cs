using System;
using System.Windows.Forms;
using RentCar.Data;

namespace RentCar
{
    public partial class Account : Form
    {

        public Account()
        {
            InitializeComponent();
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

        private void tbName_TextChanged(object sender, EventArgs e)
        {
            User user = Dao.User.GetByName(tbName.Text);

            if (tbName.Text != string.Empty && tbName.Text != User.)
            {
                MessageBox.Show("이름을 입력해주세요.");

            }

        }

        if (tbLoginId.Text != string.Empty && tbLoginPw.Text != string.Empty)
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
                            Hide();   //창이 전부 숨겨짐.
        Admin_Mypage show = new Admin_Mypage();
        show.ShowDialog();
                            //Close();
                        }
                        else
                            MessageBox.Show("잘못된 비밀번호입니다.");
                    }

if (tbLoginId.Text == "manager")
{
    if (user.LoginPw == tbLoginPw.Text)
    {
        MessageBox.Show("매니저님, 안녕하세요!");
        Hide();   //창이 전부 숨겨짐.
        Manager_Mypage show = new Manager_Mypage();
        show.ShowDialog();
    }
    else
        MessageBox.Show("잘못된 비밀번호입니다.");
}

if (tbLoginId.Text != "admin" && tbLoginId.Text != "manager")
{
    if (user.LoginPw == tbLoginPw.Text)
    {
        MessageBox.Show(tbLoginId.Text + "님, 안녕하세요!");
        //Hide();   //창이 전부 숨겨짐.
        //Customer showform = new Customer();
        this.Close();
        //showform.ShowDialog();
    }
    else
        MessageBox.Show("잘못된 비밀번호입니다.");
}

else
    MessageBox.Show("아이디 혹은 비밀번호를 입력하세요.");
                }
            }

                if (user.LoginId == tbLoginId.Text && user.LoginPw == tbLoginPw.Text)
                {
                    if (tbLoginId.Text == "admin")
                    {
                        if (user.LoginPw == tbLoginPw.Text)
                        {   
                            MessageBox.Show("관리자님, 안녕하세요!");
                            Hide();   //창이 전부 숨겨짐.
        Admin_Mypage show = new Admin_Mypage();
        show.ShowDialog();
                            //Close();
                        }
                        else
                            MessageBox.Show("잘못된 비밀번호입니다.");
                    }

if (tbLoginId.Text == "manager")
{
    if (user.LoginPw == tbLoginPw.Text)
    {
        MessageBox.Show("매니저님, 안녕하세요!");
        Hide();   //창이 전부 숨겨짐.
        Manager_Mypage show = new Manager_Mypage();
        show.ShowDialog();
    }
    else
        MessageBox.Show("잘못된 비밀번호입니다.");
}

if (tbLoginId.Text != "admin" && tbLoginId.Text != "manager")
{
    if (user.LoginPw == tbLoginPw.Text)
    {
        MessageBox.Show(tbLoginId.Text + "님, 안녕하세요!");
        //Hide();   //창이 전부 숨겨짐.
        //Customer showform = new Customer();
        this.Close();
        //showform.ShowDialog();
    }
    else
        MessageBox.Show("잘못된 비밀번호입니다.");
}

else
    MessageBox.Show("아이디 혹은 비밀번호를 입력하세요.");
                }
            }








        /*
       private void OK_Click(object sender, EventArgs e)
       {
           if (tbName.Text != "" || tbPhoneNumber.Text != "" || tbId.Text != "" || tbPassword.Text != "" || tbPasswordConfirm.Text != "" || tbLicense.Text != "")
           {
               if (tbPassword.Text != tbPasswordConfirm.Text)
                   MessageBox.Show("비밀번호를 다시 확인해주세요");
               else
               {
                   //DB에 넣는 소스
                   User user = new User();
                   user.LoginId = tbId.Text;
                   user.LoginPw = tbPassword.Text;
                   user.Name = tbName.Text;
                   user.PhoneNumber = tbPhoneNumber.Text;
                   user.License = tbLicense.Text;
                   user.IssueDate = IssuedDate.Text;
                   //user.Email = Email.Text;
                   //Dao.User.Insert(user);


                   MessageBox.Show("회원가입이 완료되었습니다.");
                   Close();
               }
           }
           else
           {
               MessageBox.Show("모든 칸에 입력해주세요");
               this.Show();
           }



       }*/

    }


}