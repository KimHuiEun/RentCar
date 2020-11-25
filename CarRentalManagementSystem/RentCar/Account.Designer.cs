
namespace RentCar
{
    partial class Account
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Account));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbName = new System.Windows.Forms.TextBox();
            this.tbEmail = new System.Windows.Forms.TextBox();
            this.tbPhoneNumber = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.tbLicense = new System.Windows.Forms.TextBox();
            this.Year = new System.Windows.Forms.ComboBox();
            this.Month = new System.Windows.Forms.ComboBox();
            this.Day = new System.Windows.Forms.ComboBox();
            this.back = new System.Windows.Forms.Button();
            this.OK = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.tbId = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.tbPassword = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.tbPasswordConfirm = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Consolas", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(204, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 33);
            this.label1.TabIndex = 0;
            this.label1.Text = "회원가입";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Consolas", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(683, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(130, 33);
            this.label2.TabIndex = 1;
            this.label2.Text = "면허증등록";
            // 
            // tbName
            // 
            this.tbName.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbName.Location = new System.Drawing.Point(144, 117);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(329, 31);
            this.tbName.TabIndex = 2;
            this.tbName.Text = "이름을 입력하세요";
            // 
            // tbEmail
            // 
            this.tbEmail.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbEmail.Location = new System.Drawing.Point(144, 190);
            this.tbEmail.Name = "tbEmail";
            this.tbEmail.Size = new System.Drawing.Size(329, 31);
            this.tbEmail.TabIndex = 3;
            this.tbEmail.Text = "이메일을 입력하세요";
            // 
            // tbPhoneNumber
            // 
            this.tbPhoneNumber.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbPhoneNumber.Location = new System.Drawing.Point(144, 258);
            this.tbPhoneNumber.Name = "tbPhoneNumber";
            this.tbPhoneNumber.Size = new System.Drawing.Size(329, 31);
            this.tbPhoneNumber.TabIndex = 4;
            this.tbPhoneNumber.Text = "전화번호를 입력하세요";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(17, 120);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 23);
            this.label3.TabIndex = 5;
            this.label3.Text = "이름";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(17, 193);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 23);
            this.label4.TabIndex = 6;
            this.label4.Text = "이메일";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(17, 261);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 23);
            this.label5.TabIndex = 7;
            this.label5.Text = "전화번호";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(502, 86);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(472, 283);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(576, 398);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 23);
            this.label6.TabIndex = 9;
            this.label6.Text = "면허번호";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(576, 446);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(70, 23);
            this.label7.TabIndex = 10;
            this.label7.Text = "발급일자";
            // 
            // tbLicense
            // 
            this.tbLicense.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbLicense.Location = new System.Drawing.Point(704, 395);
            this.tbLicense.Name = "tbLicense";
            this.tbLicense.Size = new System.Drawing.Size(270, 31);
            this.tbLicense.TabIndex = 11;
            this.tbLicense.Text = "이름을 입력하세요";
            // 
            // Year
            // 
            this.Year.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Year.FormattingEnabled = true;
            this.Year.Items.AddRange(new object[] {
            "2020",
            "2019",
            "2018",
            "2017",
            "2016",
            "2015",
            "2014",
            "2013",
            "2012",
            "2011",
            "2010",
            "...."});
            this.Year.Location = new System.Drawing.Point(704, 443);
            this.Year.Name = "Year";
            this.Year.Size = new System.Drawing.Size(88, 31);
            this.Year.TabIndex = 12;
            // 
            // Month
            // 
            this.Month.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Month.FormattingEnabled = true;
            this.Month.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12"});
            this.Month.Location = new System.Drawing.Point(798, 443);
            this.Month.Name = "Month";
            this.Month.Size = new System.Drawing.Size(88, 31);
            this.Month.TabIndex = 13;
            // 
            // Day
            // 
            this.Day.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Day.FormattingEnabled = true;
            this.Day.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25",
            "26",
            "27",
            "28",
            "29",
            "30",
            "31"});
            this.Day.Location = new System.Drawing.Point(892, 443);
            this.Day.Name = "Day";
            this.Day.Size = new System.Drawing.Size(82, 31);
            this.Day.TabIndex = 14;
            // 
            // back
            // 
            this.back.Font = new System.Drawing.Font("Consolas", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.back.Location = new System.Drawing.Point(742, 506);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(107, 52);
            this.back.TabIndex = 15;
            this.back.Text = "이전";
            this.back.UseVisualStyleBackColor = true;
            this.back.Click += new System.EventHandler(this.back_Click);
            // 
            // OK
            // 
            this.OK.Font = new System.Drawing.Font("Consolas", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OK.Location = new System.Drawing.Point(864, 506);
            this.OK.Name = "OK";
            this.OK.Size = new System.Drawing.Size(110, 52);
            this.OK.TabIndex = 16;
            this.OK.Text = "확인";
            this.OK.UseVisualStyleBackColor = true;
            this.OK.Click += new System.EventHandler(this.OK_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(17, 330);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(32, 23);
            this.label8.TabIndex = 18;
            this.label8.Text = "ID";
            // 
            // tbId
            // 
            this.tbId.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbId.Location = new System.Drawing.Point(144, 327);
            this.tbId.Name = "tbId";
            this.tbId.Size = new System.Drawing.Size(329, 31);
            this.tbId.TabIndex = 17;
            this.tbId.Text = "ID를 입력하세요";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(17, 395);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(98, 23);
            this.label9.TabIndex = 20;
            this.label9.Text = "Password";
            // 
            // tbPassword
            // 
            this.tbPassword.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbPassword.Location = new System.Drawing.Point(144, 395);
            this.tbPassword.Name = "tbPassword";
            this.tbPassword.Size = new System.Drawing.Size(329, 31);
            this.tbPassword.TabIndex = 19;
            this.tbPassword.Text = "Password를 입력하세요";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(17, 448);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(98, 46);
            this.label10.TabIndex = 22;
            this.label10.Text = "Password\r\nConfirm";
            // 
            // tbPasswordConfirm
            // 
            this.tbPasswordConfirm.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbPasswordConfirm.Location = new System.Drawing.Point(144, 463);
            this.tbPasswordConfirm.Name = "tbPasswordConfirm";
            this.tbPasswordConfirm.Size = new System.Drawing.Size(329, 31);
            this.tbPasswordConfirm.TabIndex = 21;
            this.tbPasswordConfirm.Text = "Password를 한 번 더 입력하세요";
            // 
            // NewAccount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1011, 578);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.tbPasswordConfirm);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.tbPassword);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.tbId);
            this.Controls.Add(this.OK);
            this.Controls.Add(this.back);
            this.Controls.Add(this.Day);
            this.Controls.Add(this.Month);
            this.Controls.Add(this.Year);
            this.Controls.Add(this.tbLicense);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbPhoneNumber);
            this.Controls.Add(this.tbEmail);
            this.Controls.Add(this.tbName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "NewAccount";
            this.Text = "NewAccount";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.TextBox tbEmail;
        private System.Windows.Forms.TextBox tbPhoneNumber;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbLicense;
        private System.Windows.Forms.ComboBox Year;
        private System.Windows.Forms.ComboBox Month;
        private System.Windows.Forms.ComboBox Day;
        private System.Windows.Forms.Button back;
        private System.Windows.Forms.Button OK;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tbId;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox tbPassword;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox tbPasswordConfirm;
    }
}

