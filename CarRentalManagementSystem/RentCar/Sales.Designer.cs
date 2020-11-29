
namespace RentCar
{
    partial class Sales
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
            this.label1 = new System.Windows.Forms.Label();
            this.BtnDailySales = new System.Windows.Forms.Button();
            this.BtnWeeklySales = new System.Windows.Forms.Button();
            this.BtnMonthlySales = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Consolas", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(140, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "매출현황";
            // 
            // BtnDailySales
            // 
            this.BtnDailySales.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnDailySales.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BtnDailySales.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnDailySales.Location = new System.Drawing.Point(18, 121);
            this.BtnDailySales.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnDailySales.Name = "BtnDailySales";
            this.BtnDailySales.Size = new System.Drawing.Size(333, 58);
            this.BtnDailySales.TabIndex = 1;
            this.BtnDailySales.Text = "일간 매출 엑셀";
            this.BtnDailySales.UseVisualStyleBackColor = true;
            // 
            // BtnWeeklySales
            // 
            this.BtnWeeklySales.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnWeeklySales.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BtnWeeklySales.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnWeeklySales.Location = new System.Drawing.Point(18, 197);
            this.BtnWeeklySales.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnWeeklySales.Name = "BtnWeeklySales";
            this.BtnWeeklySales.Size = new System.Drawing.Size(333, 58);
            this.BtnWeeklySales.TabIndex = 2;
            this.BtnWeeklySales.Text = "주간 매출 엑셀";
            this.BtnWeeklySales.UseVisualStyleBackColor = true;
            // 
            // BtnMonthlySales
            // 
            this.BtnMonthlySales.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnMonthlySales.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BtnMonthlySales.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnMonthlySales.Location = new System.Drawing.Point(18, 273);
            this.BtnMonthlySales.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnMonthlySales.Name = "BtnMonthlySales";
            this.BtnMonthlySales.Size = new System.Drawing.Size(333, 58);
            this.BtnMonthlySales.TabIndex = 3;
            this.BtnMonthlySales.Text = "월간 매출 엑셀";
            this.BtnMonthlySales.UseVisualStyleBackColor = true;
            // 
            // Sales
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(365, 358);
            this.Controls.Add(this.BtnMonthlySales);
            this.Controls.Add(this.BtnWeeklySales);
            this.Controls.Add(this.BtnDailySales);
            this.Controls.Add(this.label1);
            this.Name = "Sales";
            this.Text = "Sales";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BtnDailySales;
        private System.Windows.Forms.Button BtnWeeklySales;
        private System.Windows.Forms.Button BtnMonthlySales;
    }
}