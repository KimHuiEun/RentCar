using RentCar;
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
    public partial class Admin : Form
    {
        public Admin()
        {
            InitializeComponent();
        }

        /*     private void btnshowSales_Click(object sender, EventArgs e)
             {
                 Sales show = new Sales();
                 show.ShowDialog();
             }*/

        public Admin(Admin admin) : this()
        {
            _admin = admin;
        }

        private Admin _admin;
/*
        protected override void PrepareReadingEntity()
        {
            bdsUser.DataSource = Dao.User.GetAll();
        }

        protected override void ReadFromEntity()
        {
            .Text = _album.AlbumId.ToString();
            txbName.Text = _album.Name;
            // cbbArtistId.SelectedItem <- Artist
            // cbbArtistId.SelectedValue <- ArtistId
            cbbArtistId.SelectedValue = _album.ArtistId;
        }
*/

    }
}
