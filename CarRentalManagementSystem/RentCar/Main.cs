using Customer;
using System;
using System.Windows.Forms;

namespace RentCar
{
    public partial class Main : Form
    {
        //public string ReturnValue { get; set; }

        public Main()
        {
            InitializeComponent();
        }

        //
        //로그인버튼 눌렀을때
        //
        private void BtnLogin_Click(object sender, EventArgs e)
        {
            Login showform = new Login();
            showform.ShowDialog(); 
            this.Activate();
            //if ()
            {
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
                pictureBox1.Visible = false;
            }

            //else if(loginer is adminder)
            {
                BtnLogout.Visible = true;
                BtnLogout.Visible = true;
                btnCtlMenu.Visible = true;
                pictureBox1.Visible = false;
            }
        }

        //
        //회원가입버튼 눌렀을때
        //
        private void BtnCreate_Click(object sender, EventArgs e)
        {
            Account showform = new Account();
            showform.ShowDialog();
        }

        private void BtnAdminLogin_Click(object sender, EventArgs e)
        {
            Login showform = new Login();
            showform.ShowDialog();
        }

        private void btnSrchData_Click(object sender, EventArgs e)
        {
            Panel panel1 = new Panel();
            panel1.Show();

            if (panel1.Visible == true)
            {
                panel1.Dock = DockStyle.Fill;
                label1.Visible = false;
                label2.Visible = false;
                label3.Visible = false;
                label4.Visible = false;
                CbLocation.Visible = false;
                Cbsize.Visible = false;
                ReturnDate.Visible = false;
                RentDate.Visible = false;
                btnSrchData.Visible = false;
                pictureBox1.Visible = false;

                CarRentform showform = new CarRentform();
                showform.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
                showform.TopLevel = false;
                panel1.Controls.Add(showform);
                showform.Show();
                showform.Dock = DockStyle.Fill;
            }
            //CarRentform showform = new CarRentform();
            //showform.ShowDialog();
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

        private void toolStripContainer1_LeftToolStripPanel_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
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
            pictureBox1.Visible = false;
        }
    }
}
