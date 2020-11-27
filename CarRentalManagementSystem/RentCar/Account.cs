﻿using System;
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
            this.Close();
            Login showform = new Login();
            showform.Show();
        }
        
        private void OK_Click(object sender, EventArgs e)
        {

            if (tbName.Text != "" || tbEmail.Text != "" || tbPhoneNumber.Text != "" || tbId.Text != "" || tbPassword.Text != "" || tbPasswordConfirm.Text != "" || tbLicense.Text != "")
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
                    user.LoginPwConfirm = tbPasswordConfirm.Text;
                    Dao.User.Insert(user);

                    MessageBox.Show("회원가입이 완료되었습니다.");
                    this.Clear();
                }

            }
            else
            {
                MessageBox.Show("모든 칸에 입력해주세요");
            }
            
        }

        private void Clear()
        {
            tbName.Text = tbEmail.Text = tbPhoneNumber.Text = tbId.Text = tbPassword.Text = tbPasswordConfirm.Text = tbLicense.Text = "";
        }

        //this.Hide();
    }

}
    
