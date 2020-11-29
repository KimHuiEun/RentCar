
namespace Mypage
{
    partial class Admin_Mypage
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
            this.btnshowSales = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.BtnStaffManagement = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnshowSales
            // 
            this.btnshowSales.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnshowSales.Location = new System.Drawing.Point(12, 109);
            this.btnshowSales.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnshowSales.Name = "btnshowSales";
            this.btnshowSales.Size = new System.Drawing.Size(267, 49);
            this.btnshowSales.TabIndex = 0;
            this.btnshowSales.Text = "매출 현황";
            this.btnshowSales.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Consolas", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(33, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(228, 32);
            this.label1.TabIndex = 3;
            this.label1.Text = "관리자님 안녕하세요";
            // 
            // BtnStaffManagement
            // 
            this.BtnStaffManagement.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnStaffManagement.Location = new System.Drawing.Point(12, 185);
            this.BtnStaffManagement.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnStaffManagement.Name = "BtnStaffManagement";
            this.BtnStaffManagement.Size = new System.Drawing.Size(267, 49);
            this.BtnStaffManagement.TabIndex = 4;
            this.BtnStaffManagement.Text = "직원 관리";
            this.BtnStaffManagement.UseVisualStyleBackColor = true;
            // 
            // Admin_Mypage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(299, 268);
            this.Controls.Add(this.BtnStaffManagement);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnshowSales);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Admin_Mypage";
            this.Text = "Admin";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnshowSales;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BtnStaffManagement;
    }
}