
namespace RentCar
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cbLocation = new System.Windows.Forms.ComboBox();
            this.cbSize = new System.Windows.Forms.ComboBox();
            this.cbYear1 = new System.Windows.Forms.ComboBox();
            this.tbCarName = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.CarA = new System.Windows.Forms.Label();
            this.btnCar1 = new System.Windows.Forms.Button();
            this.Car2 = new System.Windows.Forms.Label();
            this.Car3 = new System.Windows.Forms.Label();
            this.Car4 = new System.Windows.Forms.Label();
            this.Car5 = new System.Windows.Forms.Label();
            this.Car6 = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnOK = new System.Windows.Forms.Button();
            this.label14 = new System.Windows.Forms.Label();
            this.btnCar2 = new System.Windows.Forms.Button();
            this.btnCar3 = new System.Windows.Forms.Button();
            this.btnCar4 = new System.Windows.Forms.Button();
            this.btnCar5 = new System.Windows.Forms.Button();
            this.btnCar6 = new System.Windows.Forms.Button();
            this.cbMonth1 = new System.Windows.Forms.ComboBox();
            this.cbDay1 = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cbDay2 = new System.Windows.Forms.ComboBox();
            this.cbMonth2 = new System.Windows.Forms.ComboBox();
            this.cbYear2 = new System.Windows.Forms.ComboBox();
            this.radioCar1 = new System.Windows.Forms.RadioButton();
            this.radioCar2 = new System.Windows.Forms.RadioButton();
            this.radioCar3 = new System.Windows.Forms.RadioButton();
            this.radioCar4 = new System.Windows.Forms.RadioButton();
            this.radioCar5 = new System.Windows.Forms.RadioButton();
            this.radioCar6 = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Location = new System.Drawing.Point(277, 1);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(2, 800);
            this.label1.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(10, 155);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 23);
            this.label2.TabIndex = 1;
            this.label2.Text = "지점";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(10, 216);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 23);
            this.label3.TabIndex = 2;
            this.label3.Text = "차 크기";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(10, 279);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 23);
            this.label4.TabIndex = 3;
            this.label4.Text = "대여일자";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(10, 344);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 23);
            this.label5.TabIndex = 4;
            this.label5.Text = "반납일자";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(10, 524);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(85, 23);
            this.label6.TabIndex = 5;
            this.label6.Text = "차량명검색";
            // 
            // cbLocation
            // 
            this.cbLocation.FormattingEnabled = true;
            this.cbLocation.Items.AddRange(new object[] {
            "서울",
            "인천",
            "부산"});
            this.cbLocation.Location = new System.Drawing.Point(96, 158);
            this.cbLocation.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbLocation.Name = "cbLocation";
            this.cbLocation.Size = new System.Drawing.Size(155, 23);
            this.cbLocation.TabIndex = 6;
            // 
            // cbSize
            // 
            this.cbSize.FormattingEnabled = true;
            this.cbSize.Items.AddRange(new object[] {
            "경형",
            "소형",
            "준중형",
            "중형",
            "준대형",
            "대형"});
            this.cbSize.Location = new System.Drawing.Point(96, 219);
            this.cbSize.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbSize.Name = "cbSize";
            this.cbSize.Size = new System.Drawing.Size(155, 23);
            this.cbSize.TabIndex = 7;
            // 
            // cbYear1
            // 
            this.cbYear1.FormattingEnabled = true;
            this.cbYear1.Items.AddRange(new object[] {
            "2020",
            "2021",
            "2022"});
            this.cbYear1.Location = new System.Drawing.Point(96, 281);
            this.cbYear1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbYear1.Name = "cbYear1";
            this.cbYear1.Size = new System.Drawing.Size(59, 23);
            this.cbYear1.TabIndex = 8;
            // 
            // tbCarName
            // 
            this.tbCarName.Location = new System.Drawing.Point(96, 521);
            this.tbCarName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbCarName.Name = "tbCarName";
            this.tbCarName.Size = new System.Drawing.Size(121, 25);
            this.tbCarName.TabIndex = 10;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(224, 521);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(27, 22);
            this.btnSearch.TabIndex = 11;
            this.btnSearch.Text = "🔍";
            this.btnSearch.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(312, 4);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(321, 269);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(661, 4);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(326, 269);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 13;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(1016, 4);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(322, 269);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 14;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(312, 348);
            this.pictureBox4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(321, 272);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 12;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox5.Image")));
            this.pictureBox5.Location = new System.Drawing.Point(661, 348);
            this.pictureBox5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(326, 272);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox5.TabIndex = 13;
            this.pictureBox5.TabStop = false;
            // 
            // pictureBox6
            // 
            this.pictureBox6.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox6.Image")));
            this.pictureBox6.Location = new System.Drawing.Point(1016, 348);
            this.pictureBox6.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(322, 272);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox6.TabIndex = 14;
            this.pictureBox6.TabStop = false;
            // 
            // CarA
            // 
            this.CarA.AutoSize = true;
            this.CarA.Location = new System.Drawing.Point(422, 281);
            this.CarA.Name = "CarA";
            this.CarA.Size = new System.Drawing.Size(86, 15);
            this.CarA.TabIndex = 16;
            this.CarA.Text = "A, 20,000원";
            // 
            // btnCar1
            // 
            this.btnCar1.Location = new System.Drawing.Point(410, 306);
            this.btnCar1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCar1.Name = "btnCar1";
            this.btnCar1.Size = new System.Drawing.Size(98, 35);
            this.btnCar1.TabIndex = 17;
            this.btnCar1.Text = "정보";
            this.btnCar1.UseVisualStyleBackColor = true;
            // 
            // Car2
            // 
            this.Car2.AutoSize = true;
            this.Car2.Location = new System.Drawing.Point(784, 281);
            this.Car2.Name = "Car2";
            this.Car2.Size = new System.Drawing.Size(87, 15);
            this.Car2.TabIndex = 19;
            this.Car2.Text = "B, 30,000원";
            // 
            // Car3
            // 
            this.Car3.AutoSize = true;
            this.Car3.Location = new System.Drawing.Point(1144, 281);
            this.Car3.Name = "Car3";
            this.Car3.Size = new System.Drawing.Size(87, 15);
            this.Car3.TabIndex = 22;
            this.Car3.Text = "C, 40,000원";
            // 
            // Car4
            // 
            this.Car4.AutoSize = true;
            this.Car4.Location = new System.Drawing.Point(422, 632);
            this.Car4.Name = "Car4";
            this.Car4.Size = new System.Drawing.Size(87, 15);
            this.Car4.TabIndex = 25;
            this.Car4.Text = "D, 50,000원";
            // 
            // Car5
            // 
            this.Car5.AutoSize = true;
            this.Car5.Location = new System.Drawing.Point(784, 632);
            this.Car5.Name = "Car5";
            this.Car5.Size = new System.Drawing.Size(86, 15);
            this.Car5.TabIndex = 28;
            this.Car5.Text = "E, 60,000원";
            // 
            // Car6
            // 
            this.Car6.AutoSize = true;
            this.Car6.Location = new System.Drawing.Point(1144, 632);
            this.Car6.Name = "Car6";
            this.Car6.Size = new System.Drawing.Size(85, 15);
            this.Car6.TabIndex = 31;
            this.Car6.Text = "F, 70,000원";
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(1095, 731);
            this.btnBack.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(118, 38);
            this.btnBack.TabIndex = 34;
            this.btnBack.Text = "이전";
            this.btnBack.UseVisualStyleBackColor = true;
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(1224, 731);
            this.btnOK.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(118, 38);
            this.btnOK.TabIndex = 35;
            this.btnOK.Text = "확인";
            this.btnOK.UseVisualStyleBackColor = true;
            // 
            // label14
            // 
            this.label14.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label14.Location = new System.Drawing.Point(278, 705);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(1063, 2);
            this.label14.TabIndex = 36;
            // 
            // btnCar2
            // 
            this.btnCar2.Location = new System.Drawing.Point(760, 306);
            this.btnCar2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCar2.Name = "btnCar2";
            this.btnCar2.Size = new System.Drawing.Size(98, 35);
            this.btnCar2.TabIndex = 43;
            this.btnCar2.Text = "정보";
            this.btnCar2.UseVisualStyleBackColor = true;
            // 
            // btnCar3
            // 
            this.btnCar3.Location = new System.Drawing.Point(1120, 306);
            this.btnCar3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCar3.Name = "btnCar3";
            this.btnCar3.Size = new System.Drawing.Size(98, 35);
            this.btnCar3.TabIndex = 44;
            this.btnCar3.Text = "정보";
            this.btnCar3.UseVisualStyleBackColor = true;
            // 
            // btnCar4
            // 
            this.btnCar4.Location = new System.Drawing.Point(410, 655);
            this.btnCar4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCar4.Name = "btnCar4";
            this.btnCar4.Size = new System.Drawing.Size(98, 35);
            this.btnCar4.TabIndex = 45;
            this.btnCar4.Text = "정보";
            this.btnCar4.UseVisualStyleBackColor = true;
            // 
            // btnCar5
            // 
            this.btnCar5.Location = new System.Drawing.Point(760, 655);
            this.btnCar5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCar5.Name = "btnCar5";
            this.btnCar5.Size = new System.Drawing.Size(98, 35);
            this.btnCar5.TabIndex = 46;
            this.btnCar5.Text = "정보";
            this.btnCar5.UseVisualStyleBackColor = true;
            // 
            // btnCar6
            // 
            this.btnCar6.Location = new System.Drawing.Point(1120, 655);
            this.btnCar6.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCar6.Name = "btnCar6";
            this.btnCar6.Size = new System.Drawing.Size(98, 35);
            this.btnCar6.TabIndex = 47;
            this.btnCar6.Text = "정보";
            this.btnCar6.UseVisualStyleBackColor = true;
            // 
            // cbMonth1
            // 
            this.cbMonth1.FormattingEnabled = true;
            this.cbMonth1.Items.AddRange(new object[] {
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
            this.cbMonth1.Location = new System.Drawing.Point(162, 281);
            this.cbMonth1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbMonth1.Name = "cbMonth1";
            this.cbMonth1.Size = new System.Drawing.Size(41, 23);
            this.cbMonth1.TabIndex = 48;
            // 
            // cbDay1
            // 
            this.cbDay1.FormattingEnabled = true;
            this.cbDay1.Items.AddRange(new object[] {
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
            this.cbDay1.Location = new System.Drawing.Point(210, 281);
            this.cbDay1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbDay1.Name = "cbDay1";
            this.cbDay1.Size = new System.Drawing.Size(41, 23);
            this.cbDay1.TabIndex = 49;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(14, 40);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(103, 32);
            this.label7.TabIndex = 53;
            this.label7.Text = "차량예약";
            // 
            // cbDay2
            // 
            this.cbDay2.FormattingEnabled = true;
            this.cbDay2.Items.AddRange(new object[] {
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
            this.cbDay2.Location = new System.Drawing.Point(210, 346);
            this.cbDay2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbDay2.Name = "cbDay2";
            this.cbDay2.Size = new System.Drawing.Size(41, 23);
            this.cbDay2.TabIndex = 56;
            // 
            // cbMonth2
            // 
            this.cbMonth2.FormattingEnabled = true;
            this.cbMonth2.Items.AddRange(new object[] {
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
            this.cbMonth2.Location = new System.Drawing.Point(162, 346);
            this.cbMonth2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbMonth2.Name = "cbMonth2";
            this.cbMonth2.Size = new System.Drawing.Size(41, 23);
            this.cbMonth2.TabIndex = 55;
            // 
            // cbYear2
            // 
            this.cbYear2.FormattingEnabled = true;
            this.cbYear2.Items.AddRange(new object[] {
            "2020",
            "2021",
            "2022"});
            this.cbYear2.Location = new System.Drawing.Point(96, 346);
            this.cbYear2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbYear2.Name = "cbYear2";
            this.cbYear2.Size = new System.Drawing.Size(59, 23);
            this.cbYear2.TabIndex = 54;
            // 
            // radioCar1
            // 
            this.radioCar1.AutoSize = true;
            this.radioCar1.Location = new System.Drawing.Point(399, 281);
            this.radioCar1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.radioCar1.Name = "radioCar1";
            this.radioCar1.Size = new System.Drawing.Size(17, 16);
            this.radioCar1.TabIndex = 57;
            this.radioCar1.TabStop = true;
            this.radioCar1.UseVisualStyleBackColor = true;
            this.radioCar1.ControlAdded += new System.Windows.Forms.ControlEventHandler(this.CarA);
            // 
            // radioCar2
            // 
            this.radioCar2.AutoSize = true;
            this.radioCar2.Location = new System.Drawing.Point(761, 281);
            this.radioCar2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.radioCar2.Name = "radioCar2";
            this.radioCar2.Size = new System.Drawing.Size(17, 16);
            this.radioCar2.TabIndex = 58;
            this.radioCar2.TabStop = true;
            this.radioCar2.UseVisualStyleBackColor = true;
            // 
            // radioCar3
            // 
            this.radioCar3.AutoSize = true;
            this.radioCar3.Location = new System.Drawing.Point(1121, 280);
            this.radioCar3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.radioCar3.Name = "radioCar3";
            this.radioCar3.Size = new System.Drawing.Size(17, 16);
            this.radioCar3.TabIndex = 59;
            this.radioCar3.TabStop = true;
            this.radioCar3.UseVisualStyleBackColor = true;
            // 
            // radioCar4
            // 
            this.radioCar4.AutoSize = true;
            this.radioCar4.Location = new System.Drawing.Point(399, 631);
            this.radioCar4.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.radioCar4.Name = "radioCar4";
            this.radioCar4.Size = new System.Drawing.Size(17, 16);
            this.radioCar4.TabIndex = 60;
            this.radioCar4.TabStop = true;
            this.radioCar4.UseVisualStyleBackColor = true;
            // 
            // radioCar5
            // 
            this.radioCar5.AutoSize = true;
            this.radioCar5.Location = new System.Drawing.Point(761, 631);
            this.radioCar5.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.radioCar5.Name = "radioCar5";
            this.radioCar5.Size = new System.Drawing.Size(17, 16);
            this.radioCar5.TabIndex = 61;
            this.radioCar5.TabStop = true;
            this.radioCar5.UseVisualStyleBackColor = true;
            // 
            // radioCar6
            // 
            this.radioCar6.AutoSize = true;
            this.radioCar6.Location = new System.Drawing.Point(1121, 631);
            this.radioCar6.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.radioCar6.Name = "radioCar6";
            this.radioCar6.Size = new System.Drawing.Size(17, 16);
            this.radioCar6.TabIndex = 62;
            this.radioCar6.TabStop = true;
            this.radioCar6.UseVisualStyleBackColor = true;
            // 
            // CarRentform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1361, 804);
            this.Controls.Add(this.radioCar6);
            this.Controls.Add(this.radioCar5);
            this.Controls.Add(this.radioCar4);
            this.Controls.Add(this.radioCar3);
            this.Controls.Add(this.radioCar2);
            this.Controls.Add(this.radioCar1);
            this.Controls.Add(this.cbDay2);
            this.Controls.Add(this.cbMonth2);
            this.Controls.Add(this.cbYear2);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.cbDay1);
            this.Controls.Add(this.cbMonth1);
            this.Controls.Add(this.btnCar6);
            this.Controls.Add(this.btnCar5);
            this.Controls.Add(this.btnCar4);
            this.Controls.Add(this.btnCar3);
            this.Controls.Add(this.btnCar2);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.Car6);
            this.Controls.Add(this.Car5);
            this.Controls.Add(this.Car4);
            this.Controls.Add(this.Car3);
            this.Controls.Add(this.Car2);
            this.Controls.Add(this.btnCar1);
            this.Controls.Add(this.CarA);
            this.Controls.Add(this.pictureBox6);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.tbCarName);
            this.Controls.Add(this.cbYear1);
            this.Controls.Add(this.cbSize);
            this.Controls.Add(this.cbLocation);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "CarRentform";
            this.Text = "Selection";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbLocation;
        private System.Windows.Forms.ComboBox cbSize;
        private System.Windows.Forms.ComboBox cbYear1;
        private System.Windows.Forms.TextBox tbCarName;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.Label CarA;
        private System.Windows.Forms.Button btnCar1;
        private System.Windows.Forms.Label Car2;
        private System.Windows.Forms.Label Car3;
        private System.Windows.Forms.Label Car4;
        private System.Windows.Forms.Label Car5;
        private System.Windows.Forms.Label Car6;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button btnCar2;
        private System.Windows.Forms.Button btnCar3;
        private System.Windows.Forms.Button btnCar4;
        private System.Windows.Forms.Button btnCar5;
        private System.Windows.Forms.Button btnCar6;
        private System.Windows.Forms.ComboBox cbMonth1;
        private System.Windows.Forms.ComboBox cbDay1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cbDay2;
        private System.Windows.Forms.ComboBox cbMonth2;
        private System.Windows.Forms.ComboBox cbYear2;
        private System.Windows.Forms.RadioButton radioCar1;
        private System.Windows.Forms.RadioButton radioCar2;
        private System.Windows.Forms.RadioButton radioCar3;
        private System.Windows.Forms.RadioButton radioCar4;
        private System.Windows.Forms.RadioButton radioCar5;
        private System.Windows.Forms.RadioButton radioCar6;
    }
}

