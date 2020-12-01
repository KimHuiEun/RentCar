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
using EFLibrary;
using RentCar;

namespace Mypage
{
    public partial class AccountInfo : Form
    {
        public AccountInfo()
        {
            InitializeComponent();
        }

        private void OKtochange_Click(object sender, EventArgs e)
        {
            MessageBox.Show("변경하신 정보로 수정하시겠습니까?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
        }

        private void back_Click(object sender, EventArgs e)
        {
            MessageBox.Show("창을 나가면 입력하신 정보는 저장되지 않습니다.", "Message", MessageBoxButtons.YesNo);
        }

        private void AccountInfo_Load(object sender, EventArgs e)
        {
            //다른 폼의 버튼 이벤트 가져와서 변수에 할당하기.
            string click = Login.Button.ToString(btnLogin);
            Console.WriteLine(click);
            //User user = Dao.User.GetByName(loginId);
            //string strUserID = user.UserId.ToString();

            //string userid = Dao.User.GetByName["id"].ToString();
            
            //tbShowUserId.Text = dao.LoginId.ToString();
        }
    }
}
