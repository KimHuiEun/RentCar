using RentCar.Data;
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
    public partial class CarManagement : Form
    {
        Car model = new Car();
        CarType model2 = new CarType();

        public CarManagement()
        {
            InitializeComponent();
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            Clear();
        }

        void Clear()
        {
            CbCarSize.Text = TbModel.Text = TbPrice.Text = CbIsRent.Text = "";
            BtnSave.Text = "Save";
            BtnDelete.Enabled = false;
            model.CarId = 0;
        }

        private void CarManagement_Load(object sender, EventArgs e)
        {
            Clear();
            PopulateDataGridView();
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            //model2.Size = CbCarSize.Text.Trim();
            //model2.Model = TbModel.Text.Trim();
            //model.Price = TbPrice.Text.Trim();
            //model.IsRent = CbIsRent.Text.Trim();

            using (RentCarEntities db = new RentCarEntities())
            {
                db.Cars.Add(model);
                db.CarTypes.Add(model2);
                db.SaveChanges();
                db.SaveChanges();
            }
            Clear();
            PopulateDataGridView();
            MessageBox.Show("추가되었습니다.");

        }

        void PopulateDataGridView()
        {
            using (RentCarEntities db = new RentCarEntities())
            {
                DgvCar.DataSource = db.Cars.ToList<Car>();
                DgvCar.DataSource = db.CarTypes.ToList<CarType>();

            }
        }

    }
}
