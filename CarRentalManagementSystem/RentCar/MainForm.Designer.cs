
namespace RentCar
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.label5 = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.label3 = new System.Windows.Forms.Label();
            this.gbLogin = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnLogin = new System.Windows.Forms.Button();
            this.tbLoginPw = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tbLoginId = new System.Windows.Forms.TextBox();
            this.btnManagerList = new System.Windows.Forms.Button();
            this.btnUserList = new System.Windows.Forms.Button();
            this.btnStats = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();
            this.btnCarList = new System.Windows.Forms.Button();
            this.btnMyinfo = new System.Windows.Forms.Button();
            this.btnAccount = new System.Windows.Forms.Button();
            this.sptAdmin = new System.Windows.Forms.Splitter();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.gbLogin.SuspendLayout();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Consolas", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.GreenYellow;
            this.label5.Location = new System.Drawing.Point(10, 24);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(341, 38);
            this.label5.TabIndex = 20;
            this.label5.Text = "Three RentCar Page";
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(12, 413);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(643, 23);
            this.progressBar1.TabIndex = 25;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.BackColor = System.Drawing.SystemColors.Control;
            this.splitContainer1.Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.splitContainer1.Panel1.Controls.Add(this.label3);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.BackColor = System.Drawing.SystemColors.Control;
            this.splitContainer1.Panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.splitContainer1.Panel2.Controls.Add(this.gbLogin);
            this.splitContainer1.Panel2.Controls.Add(this.btnManagerList);
            this.splitContainer1.Panel2.Controls.Add(this.btnUserList);
            this.splitContainer1.Panel2.Controls.Add(this.btnStats);
            this.splitContainer1.Panel2.Controls.Add(this.btnLogout);
            this.splitContainer1.Panel2.Controls.Add(this.btnCarList);
            this.splitContainer1.Panel2.Controls.Add(this.btnMyinfo);
            this.splitContainer1.Panel2.Controls.Add(this.btnAccount);
            this.splitContainer1.Panel2.Controls.Add(this.sptAdmin);
            this.splitContainer1.Size = new System.Drawing.Size(746, 495);
            this.splitContainer1.SplitterDistance = 55;
            this.splitContainer1.TabIndex = 26;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Consolas", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(70, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(269, 38);
            this.label3.TabIndex = 0;
            this.label3.Text = "Three Rent Car";
            // 
            // gbLogin
            // 
            this.gbLogin.BackColor = System.Drawing.Color.Transparent;
            this.gbLogin.Controls.Add(this.label4);
            this.gbLogin.Controls.Add(this.btnLogin);
            this.gbLogin.Controls.Add(this.tbLoginPw);
            this.gbLogin.Controls.Add(this.label6);
            this.gbLogin.Controls.Add(this.tbLoginId);
            this.gbLogin.Location = new System.Drawing.Point(66, 77);
            this.gbLogin.Name = "gbLogin";
            this.gbLogin.Size = new System.Drawing.Size(366, 121);
            this.gbLogin.TabIndex = 34;
            this.gbLogin.TabStop = false;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.label4.Font = new System.Drawing.Font("Consolas", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(17, 21);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 25);
            this.label4.TabIndex = 21;
            this.label4.Text = "아이디";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btnLogin.Font = new System.Drawing.Font("Consolas", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogin.ForeColor = System.Drawing.Color.Black;
            this.btnLogin.Location = new System.Drawing.Point(318, 15);
            this.btnLogin.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(40, 95);
            this.btnLogin.TabIndex = 3;
            this.btnLogin.Text = "로그인";
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // tbLoginPw
            // 
            this.tbLoginPw.ForeColor = System.Drawing.Color.Black;
            this.tbLoginPw.Location = new System.Drawing.Point(121, 82);
            this.tbLoginPw.Name = "tbLoginPw";
            this.tbLoginPw.Size = new System.Drawing.Size(191, 25);
            this.tbLoginPw.TabIndex = 2;
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.label6.Font = new System.Drawing.Font("Consolas", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(17, 82);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(90, 25);
            this.label6.TabIndex = 22;
            this.label6.Text = "비밀번호";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tbLoginId
            // 
            this.tbLoginId.ForeColor = System.Drawing.Color.Black;
            this.tbLoginId.Location = new System.Drawing.Point(121, 21);
            this.tbLoginId.Name = "tbLoginId";
            this.tbLoginId.Size = new System.Drawing.Size(191, 25);
            this.tbLoginId.TabIndex = 1;
            // 
            // btnManagerList
            // 
            this.btnManagerList.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btnManagerList.Font = new System.Drawing.Font("Consolas", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnManagerList.ForeColor = System.Drawing.Color.Black;
            this.btnManagerList.Location = new System.Drawing.Point(582, 282);
            this.btnManagerList.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnManagerList.Name = "btnManagerList";
            this.btnManagerList.Size = new System.Drawing.Size(105, 95);
            this.btnManagerList.TabIndex = 32;
            this.btnManagerList.Text = "직원관리";
            this.btnManagerList.UseVisualStyleBackColor = false;
            this.btnManagerList.Visible = false;
            // 
            // btnUserList
            // 
            this.btnUserList.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btnUserList.Font = new System.Drawing.Font("Consolas", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUserList.ForeColor = System.Drawing.Color.Black;
            this.btnUserList.Location = new System.Drawing.Point(265, 282);
            this.btnUserList.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnUserList.Name = "btnUserList";
            this.btnUserList.Size = new System.Drawing.Size(105, 95);
            this.btnUserList.TabIndex = 30;
            this.btnUserList.Text = "회원관리";
            this.btnUserList.UseVisualStyleBackColor = false;
            this.btnUserList.Visible = false;
            // 
            // btnStats
            // 
            this.btnStats.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btnStats.Font = new System.Drawing.Font("Consolas", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStats.ForeColor = System.Drawing.Color.Black;
            this.btnStats.Location = new System.Drawing.Point(427, 282);
            this.btnStats.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnStats.Name = "btnStats";
            this.btnStats.Size = new System.Drawing.Size(105, 95);
            this.btnStats.TabIndex = 31;
            this.btnStats.Text = "렌트통계";
            this.btnStats.UseVisualStyleBackColor = false;
            this.btnStats.Visible = false;
            // 
            // btnLogout
            // 
            this.btnLogout.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btnLogout.Font = new System.Drawing.Font("Consolas", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogout.ForeColor = System.Drawing.Color.Black;
            this.btnLogout.Location = new System.Drawing.Point(582, 98);
            this.btnLogout.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(105, 95);
            this.btnLogout.TabIndex = 28;
            this.btnLogout.Text = "로그아웃";
            this.btnLogout.UseVisualStyleBackColor = false;
            this.btnLogout.Visible = false;
            // 
            // btnCarList
            // 
            this.btnCarList.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btnCarList.Font = new System.Drawing.Font("Consolas", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCarList.ForeColor = System.Drawing.Color.Black;
            this.btnCarList.Location = new System.Drawing.Point(107, 282);
            this.btnCarList.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnCarList.Name = "btnCarList";
            this.btnCarList.Size = new System.Drawing.Size(105, 95);
            this.btnCarList.TabIndex = 29;
            this.btnCarList.Text = "차량조회";
            this.btnCarList.UseVisualStyleBackColor = false;
            this.btnCarList.Visible = false;
            // 
            // btnMyinfo
            // 
            this.btnMyinfo.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btnMyinfo.Font = new System.Drawing.Font("Consolas", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMyinfo.ForeColor = System.Drawing.Color.Black;
            this.btnMyinfo.Location = new System.Drawing.Point(448, 98);
            this.btnMyinfo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnMyinfo.Name = "btnMyinfo";
            this.btnMyinfo.Size = new System.Drawing.Size(105, 95);
            this.btnMyinfo.TabIndex = 27;
            this.btnMyinfo.Text = "내 정보";
            this.btnMyinfo.UseVisualStyleBackColor = false;
            this.btnMyinfo.Visible = false;
            // 
            // btnAccount
            // 
            this.btnAccount.Font = new System.Drawing.Font("Consolas", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAccount.Location = new System.Drawing.Point(600, 21);
            this.btnAccount.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnAccount.Name = "btnAccount";
            this.btnAccount.Size = new System.Drawing.Size(105, 36);
            this.btnAccount.TabIndex = 26;
            this.btnAccount.Text = "회원가입";
            this.btnAccount.UseVisualStyleBackColor = true;
            this.btnAccount.Click += new System.EventHandler(this.btnAccount_Click);
            // 
            // sptAdmin
            // 
            this.sptAdmin.BackColor = System.Drawing.SystemColors.Control;
            this.sptAdmin.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.sptAdmin.Location = new System.Drawing.Point(0, 249);
            this.sptAdmin.Name = "sptAdmin";
            this.sptAdmin.Size = new System.Drawing.Size(746, 187);
            this.sptAdmin.TabIndex = 0;
            this.sptAdmin.TabStop = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(746, 495);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.label5);
            this.DoubleBuffered = true;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "MainForm";
            this.Text = "RentCar";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.gbLogin.ResumeLayout(false);
            this.gbLogin.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Splitter sptAdmin;
        private System.Windows.Forms.GroupBox gbLogin;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.TextBox tbLoginPw;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbLoginId;
        private System.Windows.Forms.Button btnManagerList;
        private System.Windows.Forms.Button btnUserList;
        private System.Windows.Forms.Button btnStats;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Button btnCarList;
        private System.Windows.Forms.Button btnMyinfo;
        private System.Windows.Forms.Button btnAccount;
    }
}