using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using EFLibrary;

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
            this.Close();
            Login showform = new Login();
            showform.Show();
        }
        
        private void OK_Click(object sender, EventArgs e)
        {
                       //DB연결(오픈)

            if (tbName.Text != "" || tbEmail.Text != "" || tbPhoneNumber.Text != "" || tbId.Text != "" || tbPassword.Text != "" || tbPasswordConfirm.Text != "" || tbLicense.Text != "")
            {
               

                if (tbPassword.Text != tbPasswordConfirm.Text)
                    MessageBox.Show("비밀번호를 다시 확인해주세요");
            }
            else
            {
                MessageBox.Show("모든 칸에 입력해주세요");
            }
            /*
             SqlCommand sqlCmd = new SqlCommand("UserAdd", connection);
             sqlCmd.CommandType = CommandType.StoredProcedure;
             sqlCmd.Parameters.AddWithValue("@Name.Text", tbName.Text.Trim());
             sqlCmd.Parameters.AddWithValue("@Email.Text", tbEmail.Text.Trim());
             sqlCmd.Parameters.AddWithValue("@PhoneNumber.Text", tbPhoneNumber.Text.Trim());
             sqlCmd.Parameters.AddWithValue("@Id.Text", tbId.Text.Trim());
             sqlCmd.Parameters.AddWithValue("@Password.Text", tbPassword.Text.Trim());
             sqlCmd.Parameters.AddWithValue("@license.Text", tbLicense.Text.Trim());
             sqlCmd.Parameters.AddWithValue("@Year.Text", Year.Text.Trim());
             sqlCmd.Parameters.AddWithValue("@Month.Text", Month.Text.Trim());
             sqlCmd.Parameters.AddWithValue("@Day.Text", Day.Text.Trim());
             sqlCmd.ExecuteNonQuery();*/
             MessageBox.Show("회원가입이 완료되었습니다.");
             Clear();
            }

        private void Clear()
        {
            tbName.Text = tbEmail.Text = tbPhoneNumber.Text = tbId.Text = tbPassword.Text = tbPasswordConfirm.Text = tbLicense.Text = "";
        }

        //this.Hide();
    }

}
    
