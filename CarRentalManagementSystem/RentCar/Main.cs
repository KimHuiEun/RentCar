using Mypage;
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
    public partial class Main : Form
    {
        public string ReturnValue { get; set; }

        public Main()
        {
            InitializeComponent(); //화면에 UI랑 같게 만듦.
        }


        //
        //로그인버튼 눌렀을때
        //
        private void BtnLogin_Click(object sender, EventArgs e)
        {
            ////중복 창이 띄어져있는지 체크
            //if (Application.OpenForms["Login"] is Login login)
            //{
            //    //Login 폼이 열려 있을 경우
            //    login.Focus();
            //    return;
            //}
            ////Login 폼이 열려 있지 않은 경우
            ////Login창 Form의 new 생성
            Login showform = new Login();
            //login.MdiParent = this;   //ToDoList : 부모폼 설정 (창을 안 벗어나도록)
            showform.ShowDialog(); // 로그인 창이 뜰 때 메인 폼이 선택 되지 않도록 함.

            // Set the new form's desktop location so it  
            // appears below and to the right of the current form.

            // Keep the current form active by calling the Activate
            // method.
            this.Activate();
            label1.Visible = true;
            label2.Visible = true;
            label3.Visible = true;
            label4.Visible = true;
            CbLocation.Visible = true;
            Cbsize.Visible = true;
            ReturnDate.Visible = true;
            RentDate.Visible = true;
            btnSrchData.Visible = true;
            BtnLogin.Visible = false;
            BtnCreate.Visible = false;
            BtnMyinfo.Visible = true;
            BtnLogout.Visible = true;
        }

        //
        //회원가입버튼 눌렀을때
        //
        private void BtnCreate_Click(object sender, EventArgs e)
        {
            Account showform = new Account();
            showform.ShowDialog(); // 회원 가입 창 눌렀을 때 메인 폼 선택 안되게 변경.
        }

        private void BtnAdminLogin_Click(object sender, EventArgs e)
        {
            Login showform = new Login();
            showform.ShowDialog(); // 메인 폼을 클릭되지 않도록 변경
        }

        private void btnSrchData_Click(object sender, EventArgs e)
        {
            CarRentform showform = new CarRentform();
            showform.ShowDialog();
        }

        private void Main_Load(object sender, EventArgs e)
        {

        }

        private void BtnLogout_Click(object sender, EventArgs e)
        {
            MessageBox.Show("로그아웃 되었습니다.");
            this.Activate();
            BtnLogin.Visible = true;
            BtnCreate.Visible = true;
            BtnMyinfo.Visible = false;
            BtnLogout.Visible = false;
            label1.Visible = false;
            label2.Visible = false;
            label3.Visible = false;
            label4.Visible = false;
            CbLocation.Visible = false;
            Cbsize.Visible = false;
            ReturnDate.Visible = false;
            RentDate.Visible = false;
            btnSrchData.Visible = false;

            DialogResult dialogResult = MessageBox.Show("프로그램을 종료하시겠습니까?", "종료확인메세지박스", MessageBoxButtons.YesNo);

            if (dialogResult == DialogResult.Yes)
            {
                Close();
            }
            else if (dialogResult == DialogResult.No)
            {
                Activate();
            }
        }

        private void BtnMyinfo_Click(object sender, EventArgs e)
        {
            AccountInfo showform = new AccountInfo();
            showform.ShowDialog();
        }
    }
}
