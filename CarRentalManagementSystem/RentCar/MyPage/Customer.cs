using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mypage
{
    public partial class Customer : Form
    {
        public Customer()
        {
            InitializeComponent();
        }
/*
        private void AccountInfo_Click(object sender, EventArgs e)
        {
            //회원 가입 창이 뜰 때 모달로 떠서 메인폼이 활성화 되지 않도록 함.
            AccountInfo showform = new AccountInfo();
            showform.ShowDialog();
        }

        private void lastReservForm_Click(object sender, EventArgs e)
        {
            ReservedRestn showform = new ReservedRestn();
            showform.ShowDialog();
        }

        public Customer(string userId)
        {
            _userId = userId;
        }

        private string _userId;

        
        private void UserName_Paint(object sender, PaintEventArgs e)
        {
            //User user = Login.tbLoginId.Text;//User user = Dao.User.Login;


            //RentCar.Login.tbLoginId.Text
        }

        private void TbUserName_TextChanged(object sender, EventArgs e)
        {
            //Login form = new Login(tbloginId.Text);
            //form.ShowDialog();
        }

        private void BtnWithdraw_Click(object sender, EventArgs e)
        {
            if (WinformUtility.AskSureToDelete() == false)
                    return;

                Album album = bdsAlbum.Current as Album;

                if (album == null)
                    return;

                Dao.Album.DeleteByPK(album.AlbumId);
            
        }*/

        /*private void SearchForCar_Click(object sender, EventArgs e)
        {
            //검색된 데이터 조회 창 띄우는 것 
            CarRentform showform = new CarRentform();
            showform.ShowDialog();
        }*/

    }
}
