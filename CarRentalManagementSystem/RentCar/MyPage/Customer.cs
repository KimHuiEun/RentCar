using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RentCar;

namespace Mypage
{
    public partial class Customer : Form
    {
        public Customer()
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
