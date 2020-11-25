
namespace Mypage
{
    partial class Admin
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
            this.btnManage = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnshowSales
            // 
            this.btnshowSales.Location = new System.Drawing.Point(49, 132);
            this.btnshowSales.Name = "btnshowSales";
            this.btnshowSales.Size = new System.Drawing.Size(402, 61);
            this.btnshowSales.TabIndex = 0;
            this.btnshowSales.Text = "일별 매출 파일 저장";
            this.btnshowSales.UseVisualStyleBackColor = true;
            this.btnshowSales.Click += new System.EventHandler(this.btnshowSales_Click);
            // 
            // btnManage
            // 
            this.btnManage.Location = new System.Drawing.Point(49, 229);
            this.btnManage.Name = "btnManage";
            this.btnManage.Size = new System.Drawing.Size(402, 69);
            this.btnManage.TabIndex = 1;
            this.btnManage.Text = "주간 매출 파일 저장";
            this.btnManage.UseVisualStyleBackColor = true;
            this.btnManage.Click += new System.EventHandler(this.btnManage_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Consolas", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(87, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(307, 40);
            this.label1.TabIndex = 3;
            this.label1.Text = "강서구지점 매출 현황";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(49, 335);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(402, 66);
            this.button1.TabIndex = 4;
            this.button1.Text = "월별 매출 파일 저장";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(501, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnManage);
            this.Controls.Add(this.btnshowSales);
            this.Name = "Admin";
            this.Text = "Admin";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnshowSales;
        private System.Windows.Forms.Button btnManage;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
    }
}