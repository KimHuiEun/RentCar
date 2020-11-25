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

namespace RentCar
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void tbLogin_Click(object sender, EventArgs e)
        {
            string val1 = tbLoginId.Text;
            string val2 = tbLoginPw.Text;

            if (val1 == "manager")
            {
                if (val2 == "password123")
                {
                    MessageBox.Show("매니저님, 안녕하세요!");
                    Manager_Mypage showform = new Manager_Mypage();
                    showform.Show();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("아이디 혹은 비밀번호를 다시 입력해주세요!");
                }
            }
            if (val1 == "admin")
            {
                if (val2 == "password123")
                {
                    MessageBox.Show("관리자님, 안녕하세요!");
                    Admin showform = new Admin();
                    showform.Show();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("아이디 혹은 비밀번호를 다시 입력해주세요!");
                }
            }

            else
            {
                MessageBox.Show(val1 + "님, 안녕하세요!");
                Customer showform = new Customer();
                showform.Show();
                this.Close();
            }
        }

        private void tbLoginId_MouseHover(object sender, EventArgs e)
        {
            this.toolTip1.IsBalloon = true;
            this.toolTip1.SetToolTip(this.tbLoginId, "영문자와 숫자로 되어있는 ID 입력");
        }

        private void tbLoginPw_MouseHover(object sender, EventArgs e)
        {
            this.toolTip2.IsBalloon = true;
            this.toolTip2.SetToolTip(this.tbLoginPw, "영문자와 숫자로 되어있는 Pw 입력");
        }

        private void tbCreateId_Click(object sender, EventArgs e)
        {
            Account showform = new Account();
            showform.Show();
        }
    }
}
