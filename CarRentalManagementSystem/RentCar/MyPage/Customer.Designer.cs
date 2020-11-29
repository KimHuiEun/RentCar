
namespace Mypage
{
    partial class Customer
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
            this.AccountInfo = new System.Windows.Forms.Button();
            this.lastReservForm = new System.Windows.Forms.Button();
            this.CName = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.BtnLgout = new System.Windows.Forms.Button();
            this.BtnWithdraw = new System.Windows.Forms.Button();
            this.SearchForCar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // AccountInfo
            // 
            this.AccountInfo.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AccountInfo.Location = new System.Drawing.Point(30, 68);
            this.AccountInfo.Name = "AccountInfo";
            this.AccountInfo.Size = new System.Drawing.Size(264, 66);
            this.AccountInfo.TabIndex = 2;
            this.AccountInfo.Text = "내 정보 수정";
            this.AccountInfo.UseVisualStyleBackColor = true;
            this.AccountInfo.Click += new System.EventHandler(this.AccountInfo_Click);
            // 
            // lastReservForm
            // 
            this.lastReservForm.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lastReservForm.Location = new System.Drawing.Point(17, 140);
            this.lastReservForm.Name = "lastReservForm";
            this.lastReservForm.Size = new System.Drawing.Size(277, 72);
            this.lastReservForm.TabIndex = 3;
            this.lastReservForm.Text = "예약 확인";
            this.lastReservForm.UseVisualStyleBackColor = true;
            this.lastReservForm.Click += new System.EventHandler(this.lastReservForm_Click);
            // 
            // CName
            // 
            this.CName.AutoSize = true;
            this.CName.Font = new System.Drawing.Font("Consolas", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CName.ForeColor = System.Drawing.SystemColors.ControlText;
            this.CName.Location = new System.Drawing.Point(15, 11);
            this.CName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.CName.Name = "CName";
            this.CName.Size = new System.Drawing.Size(0, 47);
            this.CName.TabIndex = 4;
            this.CName.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Consolas", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(139, 11);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(262, 47);
            this.label1.TabIndex = 5;
            this.label1.Text = "님의 My Page";
            // 
            // BtnLgout
            // 
            this.BtnLgout.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnLgout.Location = new System.Drawing.Point(17, 232);
            this.BtnLgout.Name = "BtnLgout";
            this.BtnLgout.Size = new System.Drawing.Size(277, 59);
            this.BtnLgout.TabIndex = 6;
            this.BtnLgout.Text = "로그아웃";
            this.BtnLgout.UseVisualStyleBackColor = true;
            // 
            // SearchForCar
            // 
            this.UserName.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserName.Location = new System.Drawing.Point(25, 13);
            this.UserName.Margin = new System.Windows.Forms.Padding(4);
            this.UserName.Name = "UserName";
            this.UserName.Size = new System.Drawing.Size(106, 48);
            this.UserName.TabIndex = 7;
            this.UserName.Paint += new System.Windows.Forms.PaintEventHandler(this.UserName_Paint);
            // 
            // BtnWithdraw
            // 
            this.BtnWithdraw.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnWithdraw.Location = new System.Drawing.Point(17, 309);
            this.BtnWithdraw.Name = "BtnWithdraw";
            this.BtnWithdraw.Size = new System.Drawing.Size(277, 56);
            this.BtnWithdraw.TabIndex = 8;
            this.BtnWithdraw.Text = "회원 탈퇴";
            this.BtnWithdraw.UseVisualStyleBackColor = true;
            this.BtnWithdraw.Click += new System.EventHandler(this.BtnWithdraw_Click);

            this.SearchForCar.Location = new System.Drawing.Point(24, 217);
            this.SearchForCar.Margin = new System.Windows.Forms.Padding(4);
            this.SearchForCar.Name = "SearchForCar";
            this.SearchForCar.Size = new System.Drawing.Size(396, 84);
            this.SearchForCar.TabIndex = 7;
            this.SearchForCar.Text = "예약하기(차량검색)";
            this.SearchForCar.UseVisualStyleBackColor = true;
            this.SearchForCar.Click += new System.EventHandler(this.SearchForCar_Click);
            // 
            // Customer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(448, 604);
            this.Controls.Add(this.SearchForCar);
            this.Controls.Add(this.BtnLgout);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CName);
            this.Controls.Add(this.lastReservForm);
            this.Controls.Add(this.AccountInfo);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Customer";
            this.Text = "Customer";
            this.Load += new System.EventHandler(this.Customer_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button AccountInfo;
        private System.Windows.Forms.Button lastReservForm;
        private System.Windows.Forms.Label CName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BtnLgout;
        private System.Windows.Forms.Button SearchForCar;
    }
}