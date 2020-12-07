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
    public partial class EntityForm : Form
    {
        protected EntityForm()
        {
            InitializeComponent();
        }

        protected virtual void PrepareReadingEntity()
        {
        }

        
        protected override void OnLoad(EventArgs e)
        {
            if (DesignMode)
                return;

            base.OnLoad(e);

            PrepareReadingEntity();

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            /*WriteToEntity();

            InsertOrUpdate();*/

            DialogResult = DialogResult.OK;
            Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
