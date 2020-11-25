
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
            this.callCarRent = new System.Windows.Forms.Button();
            this.AccountInfo = new System.Windows.Forms.Button();
            this.lastReservForm = new System.Windows.Forms.Button();
            this.CName = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // callCarRent
            // 
            this.callCarRent.Location = new System.Drawing.Point(48, 232);
            this.callCarRent.Name = "callCarRent";
            this.callCarRent.Size = new System.Drawing.Size(150, 70);
            this.callCarRent.TabIndex = 1;
            this.callCarRent.Text = "예약 가능 차량 조회";
            this.callCarRent.UseVisualStyleBackColor = true;
            this.callCarRent.Click += new System.EventHandler(this.callCarRent_Click);
            // 
            // AccountInfo
            // 
            this.AccountInfo.Location = new System.Drawing.Point(48, 143);
            this.AccountInfo.Name = "AccountInfo";
            this.AccountInfo.Size = new System.Drawing.Size(150, 70);
            this.AccountInfo.TabIndex = 2;
            this.AccountInfo.Text = "내 정보 수정";
            this.AccountInfo.UseVisualStyleBackColor = true;
            this.AccountInfo.Click += new System.EventHandler(this.AccountInfo_Click);
            // 
            // lastReservForm
            // 
            this.lastReservForm.Location = new System.Drawing.Point(48, 317);
            this.lastReservForm.Name = "lastReservForm";
            this.lastReservForm.Size = new System.Drawing.Size(150, 70);
            this.lastReservForm.TabIndex = 3;
            this.lastReservForm.Text = "예약 확인";
            this.lastReservForm.UseVisualStyleBackColor = true;
            this.lastReservForm.Click += new System.EventHandler(this.lastReservForm_Click);
            // 
            // CName
            // 
            this.CName.AutoSize = true;
            this.CName.Font = new System.Drawing.Font("Consolas", 25.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CName.ForeColor = System.Drawing.SystemColors.ControlText;
            this.CName.Location = new System.Drawing.Point(94, 45);
            this.CName.Name = "CName";
            this.CName.Size = new System.Drawing.Size(118, 51);
            this.CName.TabIndex = 4;
            this.CName.Text = "Name";
            this.CName.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Consolas", 25.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(218, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(529, 51);
            this.label1.TabIndex = 5;
            this.label1.Text = "님 안녕하세요 JoCar입니다~";
            // 
            // Customer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CName);
            this.Controls.Add(this.lastReservForm);
            this.Controls.Add(this.AccountInfo);
            this.Controls.Add(this.callCarRent);
            this.Name = "Customer";
            this.Text = "Customer";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button callCarRent;
        private System.Windows.Forms.Button AccountInfo;
        private System.Windows.Forms.Button lastReservForm;
        private System.Windows.Forms.Label CName;
        private System.Windows.Forms.Label label1;
    }
}