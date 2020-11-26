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

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string val1 = tbLoginId.Text;
            string val2 = tbLoginPw.Text;

            Login showform = new Login();
            showform.Show();
           
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
