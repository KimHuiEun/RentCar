using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//using RentCar.Data;

namespace RentCar
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        public Login(string Id):this()
        {
            _Id = Id;
        }

        private string _Id;

        private void Login_Load(object sender, EventArgs e)
        {
            tbLoginId.Text = _Id;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (tbLoginId.Text != null && tbLoginPw.Text != null)
            {
                //User user = Dao.User.GetByName(tbLoginId.Text);

                //if (tbLoginId.Text != null)
                //{
                    if (tbLoginId.Text == "admin")
                    {
                        //if ()
                        //{
                            MessageBox.Show("관리자님, 안녕하세요!");
                            this.Close();
                       // }
                        //else
                            //MessageBox.Show("잘못된 비밀번호입니다.");
                    }

                    if (tbLoginId.Text == "manager")
                    {
                        //if (user.LoginPw == tbLoginPw.Text)
                        //{ 
                            MessageBox.Show("매니저님, 안녕하세요!");
                            this.Close();
                        //}
                        //else
                            //MessageBox.Show("잘못된 비밀번호입니다.");
                    }
                   
                    //if(tbLoginId.Text == user.LoginId)
                    //{
                        //if (user.LoginPw == tbLoginPw.Text)
                        else
                        {
                            MessageBox.Show(tbLoginId.Text + "님, 안녕하세요!");
                            this.Close();
                        }
                        //else
                            //MessageBox.Show("잘못된 비밀번호입니다.");
                    //}
                   
                //}
                //else
                    //MessageBox.Show("잘못된 아이디입니다.");  
            }
             else
                MessageBox.Show("아이디 혹은 비밀번호를 입력하세요.");   
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
    }
}
