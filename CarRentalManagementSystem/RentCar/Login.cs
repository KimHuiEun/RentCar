using Mypage;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EFLibrary;

namespace RentCar
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (tbLoginId.Text != string.Empty && tbLoginPw.Text != string.Empty)
            {
                User user = Dao.User.GetByName(tbLoginId.Text);

                if (user != null)
                {
                    if (user.LoginPw == tbLoginPw.Text)
                    {
                        MessageBox.Show(tbLoginId + "님, 안녕하세요!");
                        Customer showform = new Customer();
                        showform.Show();
                        this.Hide();
                    }
                    else
                        MessageBox.Show("잘못된 비밀번호입니다.");
                }
                else
                    MessageBox.Show("잘못된 아이디입니다.");
            }
            else
                MessageBox.Show("아이디 혹은 비밀번호를 입력하세요.");

            

            //if()
            this.Close();
           
        }

        private void tbLoginId_MouseHover(object sender, EventArgs e)
        {

            this.toolTip1.IsBalloon = true;
            this.toolTip1.SetToolTip(this.tbLoginId, "영문자와 숫자로 되어있는 ID 입력");

            //ToDoList : 한글 못 쓰도록.
        }

        private void tbLoginPw_MouseHover(object sender, EventArgs e)
        {
            this.toolTip2.IsBalloon = true;
            this.toolTip2.SetToolTip(this.tbLoginPw, "영문자와 숫자로 되어있는 Pw 입력");
        }

    }
}
