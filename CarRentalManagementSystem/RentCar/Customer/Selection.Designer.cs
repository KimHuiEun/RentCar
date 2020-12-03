
namespace Customer
{
    partial class CarRentform
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CarRentform));
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.btnBack = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.gpresultbox = new System.Windows.Forms.GroupBox();
            this.RentDate = new System.Windows.Forms.DateTimePicker();
            this.ReturnDate = new System.Windows.Forms.DateTimePicker();
            this.btnSearch = new System.Windows.Forms.Button();
            this.tbCarName = new System.Windows.Forms.TextBox();
            this.CbSize = new System.Windows.Forms.ComboBox();
            this.CbLocation = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            this.gpresultbox.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Location = new System.Drawing.Point(22, 223);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(904, 10);
            this.label1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.AccessibleName = "carinfodata";
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(38, 257);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(401, 323);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.AccessibleName = "carinfodata";
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(39, 610);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(408, 323);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 13;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.AccessibleName = "carinfodata";
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(510, 606);
            this.pictureBox4.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(401, 326);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 12;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.AccessibleName = "carinfodata";
            this.pictureBox5.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox5.Image")));
            this.pictureBox5.Location = new System.Drawing.Point(509, 257);
            this.pictureBox5.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(408, 326);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox5.TabIndex = 13;
            this.pictureBox5.TabStop = false;
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(770, 24);
            this.btnBack.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(148, 46);
            this.btnBack.TabIndex = 34;
            this.btnBack.Text = "이전";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(15, 31);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(253, 37);
            this.label7.TabIndex = 53;
            this.label7.Text = "차량을 검색하세요.";
            // 
            // gpresultbox
            // 
            this.gpresultbox.Controls.Add(this.RentDate);
            this.gpresultbox.Controls.Add(this.ReturnDate);
            this.gpresultbox.Controls.Add(this.btnSearch);
            this.gpresultbox.Controls.Add(this.tbCarName);
            this.gpresultbox.Controls.Add(this.CbSize);
            this.gpresultbox.Controls.Add(this.CbLocation);
            this.gpresultbox.Controls.Add(this.label6);
            this.gpresultbox.Controls.Add(this.label5);
            this.gpresultbox.Controls.Add(this.label4);
            this.gpresultbox.Controls.Add(this.label3);
            this.gpresultbox.Controls.Add(this.label2);
            this.gpresultbox.Location = new System.Drawing.Point(22, 88);
            this.gpresultbox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gpresultbox.Name = "gpresultbox";
            this.gpresultbox.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gpresultbox.Size = new System.Drawing.Size(901, 122);
            this.gpresultbox.TabIndex = 54;
            this.gpresultbox.TabStop = false;
            this.gpresultbox.Text = "검색 내역";
            // 
            // RentDate
            // 
            this.RentDate.CustomFormat = "yyyy-MM-dd";
            this.RentDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.RentDate.Location = new System.Drawing.Point(106, 82);
            this.RentDate.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.RentDate.Name = "RentDate";
            this.RentDate.Size = new System.Drawing.Size(336, 28);
            this.RentDate.TabIndex = 70;
            // 
            // ReturnDate
            // 
            this.ReturnDate.CustomFormat = "yyyy-MM-dd";
            this.ReturnDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.ReturnDate.Location = new System.Drawing.Point(550, 79);
            this.ReturnDate.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ReturnDate.Name = "ReturnDate";
            this.ReturnDate.Size = new System.Drawing.Size(336, 28);
            this.ReturnDate.TabIndex = 69;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(290, 30);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(34, 26);
            this.btnSearch.TabIndex = 66;
            this.btnSearch.Text = "🔍";
            this.btnSearch.UseVisualStyleBackColor = true;
            // 
            // tbCarName
            // 
            this.tbCarName.Location = new System.Drawing.Point(121, 30);
            this.tbCarName.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.tbCarName.Name = "tbCarName";
            this.tbCarName.Size = new System.Drawing.Size(150, 28);
            this.tbCarName.TabIndex = 65;
            // 
            // CbSize
            // 
            this.CbSize.FormattingEnabled = true;
            this.CbSize.Items.AddRange(new object[] {
            "경형",
            "소형",
            "준중형",
            "중형",
            "준대형",
            "대형"});
            this.CbSize.Location = new System.Drawing.Point(689, 30);
            this.CbSize.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.CbSize.Name = "CbSize";
            this.CbSize.Size = new System.Drawing.Size(198, 26);
            this.CbSize.TabIndex = 63;
            // 
            // CbLocation
            // 
            this.CbLocation.FormattingEnabled = true;
            this.CbLocation.Items.AddRange(new object[] {
            "서울",
            "인천",
            "부산"});
            this.CbLocation.Location = new System.Drawing.Point(389, 30);
            this.CbLocation.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.CbLocation.Name = "CbLocation";
            this.CbLocation.Size = new System.Drawing.Size(182, 26);
            this.CbLocation.TabIndex = 62;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(8, 32);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(107, 28);
            this.label6.TabIndex = 61;
            this.label6.Text = "차량명검색";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(455, 79);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(88, 28);
            this.label5.TabIndex = 60;
            this.label5.Text = "반납일자";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 82);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 28);
            this.label4.TabIndex = 59;
            this.label4.Text = "대여일자";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(599, 30);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 28);
            this.label3.TabIndex = 58;
            this.label3.Text = "차 크기";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(331, 32);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 28);
            this.label2.TabIndex = 57;
            this.label2.Text = "지점";
            // 
            // CarRentform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(956, 1038);
            this.Controls.Add(this.gpresultbox);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.Name = "CarRentform";
            this.Text = "Selection";
            this.Load += new System.EventHandler(this.CarRentform_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            this.gpresultbox.ResumeLayout(false);
            this.gpresultbox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox gpresultbox;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox tbCarName;
        private System.Windows.Forms.ComboBox CbSize;
        private System.Windows.Forms.ComboBox CbLocation;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker RentDate;
        private System.Windows.Forms.DateTimePicker ReturnDate;
    }
}

