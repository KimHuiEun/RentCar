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
    public partial class CustomerManagement : Form
    {
        User model = new User();

        public CustomerManagement()
        {
            InitializeComponent();
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            Clear();
        }

        void Clear()
        {
            TbUserId.Text = TbUserName .Text= TbUserNumber.Text = TbUserPassword.Text = "";
            BtnSave.Text = "Save";
            BtnDelete.Enabled = false;
            model.UserId = 0;
        }

        private void CustomerManagement_Load(object sender, EventArgs e)
        {
            // TODO: 이 코드는 데이터를 '_RentCarDataSet1.User' 테이블에 로드합니다. 필요 시 이 코드를 이동하거나 제거할 수 있습니다.
            this.userTableAdapter1.Fill(this._RentCarDataSet1.User);
            // TODO: 이 코드는 데이터를 '_RentCarDataSet.User' 테이블에 로드합니다. 필요 시 이 코드를 이동하거나 제거할 수 있습니다.
            this.userTableAdapter.Fill(this._RentCarDataSet.User);
            Clear();
            PopulateDataGridView();
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            model.Name = TbUserName.Text.Trim();
            model.PhoneNumber = TbUserNumber.Text.Trim();
            model.LoginId = TbUserId.Text.Trim();
            model.LoginPw = TbUserPassword.Text.Trim();
            using (RentCarEntities db = new RentCarEntities())
            {
                db.Users.Add(model);
                db.SaveChanges();
            }
            Clear();
            PopulateDataGridView();
            MessageBox.Show("추가되었습니다.");

        }

        void PopulateDataGridView()
        {
            using(RentCarEntities db = new RentCarEntities())
            {
                DgvUser.DataSource = db.Users.ToList<User>();
            }
        }
     
    }
}
