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
            //if (Application.OpenForms["Login"] is Login login)
            //{
            //    login.Focus();
            //    return;
            //}

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
    }
}
