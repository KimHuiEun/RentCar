
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
            this.button3 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.BtnUserManagerment = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(17, 148);
            this.button3.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(397, 96);
            this.button3.TabIndex = 2;
            this.button3.Text = "차량 예약 조회";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(17, 280);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(397, 96);
            this.button1.TabIndex = 3;
            this.button1.Text = "차량 예약 등록";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(49, 271);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(439, 46);
            this.button2.TabIndex = 4;
            this.button2.Text = "차량 예약 삭제";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(49, 343);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(439, 46);
            this.button4.TabIndex = 5;
            this.button4.Text = "차량 이력 조회";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Consolas", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(51, 54);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(339, 47);
            this.label1.TabIndex = 6;
            this.label1.Text = "매니저님 안녕하세요";
            // 
            // BtnUserManagerment
            // 
            this.BtnUserManagerment.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnUserManagerment.Location = new System.Drawing.Point(17, 410);
            this.BtnUserManagerment.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.BtnUserManagerment.Name = "BtnUserManagerment";
            this.BtnUserManagerment.Size = new System.Drawing.Size(397, 96);
            this.BtnUserManagerment.TabIndex = 7;
            this.BtnUserManagerment.Text = "회원 관리";
            this.BtnUserManagerment.UseVisualStyleBackColor = true;
            this.BtnUserManagerment.Click += new System.EventHandler(this.BtnUserManagerment_Click);
            // 
            // Manager_Mypage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(440, 544);
            this.Controls.Add(this.BtnUserManagerment);
            this.Controls.Add(this.label1);
            this.ClientSize = new System.Drawing.Size(546, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button3);
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "Manager_Mypage";
            this.Text = "Manager_Mypage";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BtnUserManagerment;
    }
}