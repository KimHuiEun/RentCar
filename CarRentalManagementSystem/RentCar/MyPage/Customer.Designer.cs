﻿
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
            this.label1 = new System.Windows.Forms.Label();
            this.BtnLgout = new System.Windows.Forms.Button();
            this.UserName = new System.Windows.Forms.Panel();
            this.BtnWithdraw = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // AccountInfo
            // 
            this.AccountInfo.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AccountInfo.Location = new System.Drawing.Point(17, 61);
            this.AccountInfo.Name = "AccountInfo";
            this.AccountInfo.Size = new System.Drawing.Size(277, 56);
            this.AccountInfo.TabIndex = 2;
            this.AccountInfo.Text = "내 정보 수정";
            this.AccountInfo.UseVisualStyleBackColor = true;
            this.AccountInfo.Click += new System.EventHandler(this.AccountInfo_Click);
            // 
            // lastReservForm
            // 
            this.lastReservForm.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lastReservForm.Location = new System.Drawing.Point(17, 144);
            this.lastReservForm.Name = "lastReservForm";
            this.lastReservForm.Size = new System.Drawing.Size(277, 56);
            this.lastReservForm.TabIndex = 3;
            this.lastReservForm.Text = "예약 확인";
            this.lastReservForm.UseVisualStyleBackColor = true;
            this.lastReservForm.Click += new System.EventHandler(this.lastReservForm_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Consolas", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(97, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(179, 32);
            this.label1.TabIndex = 5;
            this.label1.Text = "님의 My Page";
            // 
            // BtnLgout
            // 
            this.BtnLgout.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnLgout.Location = new System.Drawing.Point(17, 228);
            this.BtnLgout.Name = "BtnLgout";
            this.BtnLgout.Size = new System.Drawing.Size(277, 56);
            this.BtnLgout.TabIndex = 6;
            this.BtnLgout.Text = "로그아웃";
            this.BtnLgout.UseVisualStyleBackColor = true;
            // 
            // UserName
            // 
            this.UserName.Location = new System.Drawing.Point(17, 7);
            this.UserName.Name = "UserName";
            this.UserName.Size = new System.Drawing.Size(74, 32);
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
            // 
            // Customer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(309, 386);
            this.Controls.Add(this.BtnWithdraw);
            this.Controls.Add(this.UserName);
            this.Controls.Add(this.BtnLgout);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lastReservForm);
            this.Controls.Add(this.AccountInfo);
            this.Name = "Customer";
            this.Text = "Customer";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button AccountInfo;
        private System.Windows.Forms.Button lastReservForm;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BtnLgout;
        private System.Windows.Forms.Panel UserName;
        private System.Windows.Forms.Button BtnWithdraw;
    }
}