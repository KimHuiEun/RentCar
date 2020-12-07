
namespace RentCar
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
            this.components = new System.ComponentModel.Container();
            this.btnshowSales = new System.Windows.Forms.Button();
            this.btnManage = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.cbbUserId = new System.Windows.Forms.ComboBox();
            this.userBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bdsUser = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.userBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsUser)).BeginInit();
            this.SuspendLayout();
            // 
            // btnshowSales
            // 
            this.btnshowSales.Font = new System.Drawing.Font("Consolas", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnshowSales.Location = new System.Drawing.Point(49, 132);
            this.btnshowSales.Name = "btnshowSales";
            this.btnshowSales.Size = new System.Drawing.Size(402, 61);
            this.btnshowSales.TabIndex = 0;
            this.btnshowSales.Text = "매출현황";
            this.btnshowSales.UseVisualStyleBackColor = true;
            // 
            // btnManage
            // 
            this.btnManage.Font = new System.Drawing.Font("Consolas", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnManage.Location = new System.Drawing.Point(49, 229);
            this.btnManage.Name = "btnManage";
            this.btnManage.Size = new System.Drawing.Size(402, 69);
            this.btnManage.TabIndex = 1;
            this.btnManage.Text = "직원관리";
            this.btnManage.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Consolas", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(85, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(278, 38);
            this.label1.TabIndex = 3;
            this.label1.Text = "관리자님 안녕하세요";
            // 
            // cbbUserId
            // 
            this.cbbUserId.DataSource = this.userBindingSource;
            this.cbbUserId.FormattingEnabled = true;
            this.cbbUserId.Location = new System.Drawing.Point(135, 316);
            this.cbbUserId.Name = "cbbUserId";
            this.cbbUserId.Size = new System.Drawing.Size(121, 23);
            this.cbbUserId.TabIndex = 4;

            // 
            // Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(501, 351);
            this.Controls.Add(this.cbbUserId);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnManage);
            this.Controls.Add(this.btnshowSales);
            this.Name = "Admin";
            this.Text = "Admin";
            ((System.ComponentModel.ISupportInitialize)(this.userBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsUser)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnshowSales;
        private System.Windows.Forms.Button btnManage;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbbUserId;
        private System.Windows.Forms.BindingSource userBindingSource;
        private System.Windows.Forms.BindingSource bdsUser;
    }
}