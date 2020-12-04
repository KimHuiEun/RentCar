
namespace Mypage
{
    partial class Manager_Mypage
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
            this.BtnCar = new System.Windows.Forms.Button();
            this.BtnCarCreate = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.BtnUserManagerment = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BtnCar
            // 
            this.BtnCar.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCar.Location = new System.Drawing.Point(27, 121);
            this.BtnCar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnCar.Name = "BtnCar";
            this.BtnCar.Size = new System.Drawing.Size(318, 80);
            this.BtnCar.TabIndex = 2;
            this.BtnCar.Text = "차량 예약 조회";
            this.BtnCar.UseVisualStyleBackColor = true;
            // 
            // BtnCarCreate
            // 
            this.BtnCarCreate.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCarCreate.Location = new System.Drawing.Point(27, 231);
            this.BtnCarCreate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnCarCreate.Name = "BtnCarCreate";
            this.BtnCarCreate.Size = new System.Drawing.Size(318, 80);
            this.BtnCarCreate.TabIndex = 3;
            this.BtnCarCreate.Text = "차량 예약 등록";
            this.BtnCarCreate.UseVisualStyleBackColor = true;
            //this.BtnCarCreate.Click += new System.EventHandler(this.BtnCarCreate_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Consolas", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(51, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(278, 38);
            this.label1.TabIndex = 6;
            this.label1.Text = "매니저님 안녕하세요";
            // 
            // BtnUserManagerment
            // 
            this.BtnUserManagerment.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnUserManagerment.Location = new System.Drawing.Point(27, 340);
            this.BtnUserManagerment.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnUserManagerment.Name = "BtnUserManagerment";
            this.BtnUserManagerment.Size = new System.Drawing.Size(318, 80);
            this.BtnUserManagerment.TabIndex = 7;
            this.BtnUserManagerment.Text = "회원 관리";
            this.BtnUserManagerment.UseVisualStyleBackColor = true;
            //this.BtnUserManagerment.Click += new System.EventHandler(this.BtnUserManagerment_Click);
            // 
            // Manager_Mypage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(379, 450);
            this.Controls.Add(this.BtnUserManagerment);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BtnCarCreate);
            this.Controls.Add(this.BtnCar);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Manager_Mypage";
            this.Text = "Manager_Mypage";
            this.Load += new System.EventHandler(this.Manager_Mypage_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnCar;
        private System.Windows.Forms.Button BtnCarCreate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BtnUserManagerment;
    }
}