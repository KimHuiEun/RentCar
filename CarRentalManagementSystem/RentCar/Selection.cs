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
using RentCar.Data;

namespace RentCar
{
    public partial class CarRentform : Form
    {
        public CarRentform()
        {
            InitializeComponent();
        }

        private void CarRentform_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private static void pictureBox1_Click(object sender, EventArgs e)
        {
            //
            //MessageBox($"원하시는 차량의 사용 금액은 : {}")
        }


    }
}
