using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CarRent;

namespace Mypage
{
    public partial class Customer_Mypage : Form
    {
        public Customer_Mypage()
        {
            InitializeComponent();


        }

        private void callCarRent_Click(object sender, EventArgs e)
        {
            CarRentform showform = new CarRentform();
            showform.Show();
        }

        private void AccountInfo_Click(object sender, EventArgs e)
        {
            AccountInfo showform = new AccountInfo();
            showform.Show();
        }

        private void lastReservForm_Click(object sender, EventArgs e)
        {
            ReservedRestn showform = new ReservedRestn();
            showform.Show();
        }
    }
}
