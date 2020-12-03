
namespace RentCar
{
    partial class Main
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.BtnLogin = new System.Windows.Forms.Button();
            this.BtnCreate = new System.Windows.Forms.Button();
            this.CbLocation = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Cbsize = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.RentDate = new System.Windows.Forms.DateTimePicker();
            this.ReturnDate = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.btnSrchData = new System.Windows.Forms.Button();
            this.BtnMyinfo = new System.Windows.Forms.Button();
            this.BtnLogout = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnCtlMenu = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // BtnLogin
            // 
            this.BtnLogin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnLogin.Font = new System.Drawing.Font("Consolas", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnLogin.Location = new System.Drawing.Point(972, 20);
            this.BtnLogin.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.BtnLogin.Name = "BtnLogin";
            this.BtnLogin.Size = new System.Drawing.Size(96, 35);
            this.BtnLogin.TabIndex = 0;
            this.BtnLogin.Text = "로그인";
            this.BtnLogin.UseVisualStyleBackColor = true;
            this.BtnLogin.Click += new System.EventHandler(this.BtnLogin_Click);
            // 
            // BtnCreate
            // 
            this.BtnCreate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnCreate.Font = new System.Drawing.Font("Consolas", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCreate.Location = new System.Drawing.Point(1074, 20);
            this.BtnCreate.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.BtnCreate.Name = "BtnCreate";
            this.BtnCreate.Size = new System.Drawing.Size(96, 35);
            this.BtnCreate.TabIndex = 1;
            this.BtnCreate.Text = "회원가입";
            this.BtnCreate.UseVisualStyleBackColor = true;
            this.BtnCreate.Click += new System.EventHandler(this.BtnCreate_Click);
            // 
            // CbLocation
            // 
            this.CbLocation.Font = new System.Drawing.Font("Consolas", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CbLocation.FormattingEnabled = true;
            this.CbLocation.Items.AddRange(new object[] {
            "지점1",
            "지점2",
            "지점3"});
            this.CbLocation.Location = new System.Drawing.Point(123, 112);
            this.CbLocation.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.CbLocation.Name = "CbLocation";
            this.CbLocation.Size = new System.Drawing.Size(199, 35);
            this.CbLocation.TabIndex = 3;
            this.CbLocation.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Consolas", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(18, 114);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 28);
            this.label1.TabIndex = 4;
            this.label1.Text = "지점";
            this.label1.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Consolas", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(18, 169);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 28);
            this.label2.TabIndex = 6;
            this.label2.Text = "차 크기";
            this.label2.Visible = false;
            // 
            // Cbsize
            // 
            this.Cbsize.Font = new System.Drawing.Font("Consolas", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cbsize.FormattingEnabled = true;
            this.Cbsize.Items.AddRange(new object[] {
            "경형",
            "소형",
            "준중형",
            "중형",
            "준대형",
            "대형"});
            this.Cbsize.Location = new System.Drawing.Point(123, 167);
            this.Cbsize.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Cbsize.Name = "Cbsize";
            this.Cbsize.Size = new System.Drawing.Size(199, 35);
            this.Cbsize.TabIndex = 5;
            this.Cbsize.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Consolas", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(18, 218);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 28);
            this.label3.TabIndex = 7;
            this.label3.Text = "대여일자";
            this.label3.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Consolas", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(18, 262);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 28);
            this.label4.TabIndex = 13;
            this.label4.Text = "반납일자";
            this.label4.Visible = false;
            // 
            // RentDate
            // 
            this.RentDate.CalendarFont = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RentDate.Location = new System.Drawing.Point(123, 220);
            this.RentDate.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.RentDate.Name = "RentDate";
            this.RentDate.Size = new System.Drawing.Size(199, 25);
            this.RentDate.TabIndex = 18;
            this.RentDate.Visible = false;
            // 
            // ReturnDate
            // 
            this.ReturnDate.Location = new System.Drawing.Point(123, 264);
            this.ReturnDate.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ReturnDate.Name = "ReturnDate";
            this.ReturnDate.Size = new System.Drawing.Size(199, 25);
            this.ReturnDate.TabIndex = 19;
            this.ReturnDate.Visible = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Consolas", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 16);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(310, 51);
            this.label5.TabIndex = 20;
            this.label5.Text = "RentCar Page";
            // 
            // btnSrchData
            // 
            this.btnSrchData.Location = new System.Drawing.Point(226, 310);
            this.btnSrchData.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSrchData.Name = "btnSrchData";
            this.btnSrchData.Size = new System.Drawing.Size(96, 35);
            this.btnSrchData.TabIndex = 21;
            this.btnSrchData.Text = "검색";
            this.btnSrchData.UseVisualStyleBackColor = true;
            this.btnSrchData.Visible = false;
            this.btnSrchData.Click += new System.EventHandler(this.btnSrchData_Click);
            // 
            // BtnMyinfo
            // 
            this.BtnMyinfo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnMyinfo.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnMyinfo.Location = new System.Drawing.Point(972, 20);
            this.BtnMyinfo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.BtnMyinfo.Name = "BtnMyinfo";
            this.BtnMyinfo.Size = new System.Drawing.Size(96, 35);
            this.BtnMyinfo.TabIndex = 22;
            this.BtnMyinfo.Text = "내 정보";
            this.BtnMyinfo.UseVisualStyleBackColor = true;
            this.BtnMyinfo.Visible = false;
            this.BtnMyinfo.Click += new System.EventHandler(this.BtnMyinfo_Click);
            // 
            // BtnLogout
            // 
            this.BtnLogout.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnLogout.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnLogout.Location = new System.Drawing.Point(1074, 20);
            this.BtnLogout.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.BtnLogout.Name = "BtnLogout";
            this.BtnLogout.Size = new System.Drawing.Size(96, 35);
            this.BtnLogout.TabIndex = 23;
            this.BtnLogout.Text = "로그아웃";
            this.BtnLogout.UseVisualStyleBackColor = true;
            this.BtnLogout.Visible = false;
            this.BtnLogout.Click += new System.EventHandler(this.BtnLogout_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 76);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1158, 585);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 24;
            this.pictureBox1.TabStop = false;
            // 
            // btnCtlMenu
            // 
            this.btnCtlMenu.Font = new System.Drawing.Font("Consolas", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCtlMenu.Location = new System.Drawing.Point(972, 20);
            this.btnCtlMenu.Name = "btnCtlMenu";
            this.btnCtlMenu.Size = new System.Drawing.Size(96, 35);
            this.btnCtlMenu.TabIndex = 25;
            this.btnCtlMenu.Text = "관리자";
            this.btnCtlMenu.UseVisualStyleBackColor = true;
            this.btnCtlMenu.Visible = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1182, 673);
            this.panel1.TabIndex = 26;
            this.panel1.Visible = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1074, 626);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(96, 35);
            this.button1.TabIndex = 0;
            this.button1.Text = "돌아가기";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Visible = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1182, 673);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnSrchData);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.ReturnDate);
            this.Controls.Add(this.RentDate);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Cbsize);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CbLocation);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnCtlMenu);
            this.Controls.Add(this.BtnMyinfo);
            this.Controls.Add(this.BtnCreate);
            this.Controls.Add(this.BtnLogout);
            this.Controls.Add(this.BtnLogin);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Main";
            this.Text = "RentCar";
            this.Load += new System.EventHandler(this.Main_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnLogin;
        private System.Windows.Forms.Button BtnCreate;
        private System.Windows.Forms.ComboBox CbLocation;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox Cbsize;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker RentDate;
        private System.Windows.Forms.DateTimePicker ReturnDate;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnSrchData;
        private System.Windows.Forms.Button BtnMyinfo;
        private System.Windows.Forms.Button BtnLogout;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnCtlMenu;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
    }
}