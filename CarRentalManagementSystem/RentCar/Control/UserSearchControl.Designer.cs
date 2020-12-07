
namespace RentCar
{
    partial class UserSearchControl
    {
        /// <summary> 
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region 구성 요소 디자이너에서 생성한 코드

        /// <summary> 
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.gbUserControl = new System.Windows.Forms.GroupBox();
            this.tbUserPhoneNumber = new System.Windows.Forms.MaskedTextBox();
            this.tbLoginId = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbUserName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbUserId = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnUserSearch = new System.Windows.Forms.Button();
            this.gbUserControl.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbUserControl
            // 
            this.gbUserControl.Controls.Add(this.tbUserPhoneNumber);
            this.gbUserControl.Controls.Add(this.tbLoginId);
            this.gbUserControl.Controls.Add(this.label4);
            this.gbUserControl.Controls.Add(this.label3);
            this.gbUserControl.Controls.Add(this.tbUserName);
            this.gbUserControl.Controls.Add(this.label2);
            this.gbUserControl.Controls.Add(this.tbUserId);
            this.gbUserControl.Controls.Add(this.label1);
            this.gbUserControl.Location = new System.Drawing.Point(10, 3);
            this.gbUserControl.Name = "gbUserControl";
            this.gbUserControl.Size = new System.Drawing.Size(645, 56);
            this.gbUserControl.TabIndex = 0;
            this.gbUserControl.TabStop = false;
            // 
            // tbUserPhoneNumber
            // 
            this.tbUserPhoneNumber.Location = new System.Drawing.Point(378, 21);
            this.tbUserPhoneNumber.Mask = "000-9000-0000";
            this.tbUserPhoneNumber.Name = "tbUserPhoneNumber";
            this.tbUserPhoneNumber.Size = new System.Drawing.Size(121, 25);
            this.tbUserPhoneNumber.TabIndex = 14;
            // 
            // tbLoginId
            // 
            this.tbLoginId.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbLoginId.Location = new System.Drawing.Point(535, 18);
            this.tbLoginId.Name = "tbLoginId";
            this.tbLoginId.Size = new System.Drawing.Size(100, 27);
            this.tbLoginId.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(509, 21);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(27, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "ID";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(319, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "전화번호";
            // 
            // tbUserName
            // 
            this.tbUserName.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbUserName.Location = new System.Drawing.Point(211, 18);
            this.tbUserName.Name = "tbUserName";
            this.tbUserName.Size = new System.Drawing.Size(100, 27);
            this.tbUserName.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(173, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "이름";
            // 
            // tbUserId
            // 
            this.tbUserId.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbUserId.Location = new System.Drawing.Point(65, 18);
            this.tbUserId.Name = "tbUserId";
            this.tbUserId.Size = new System.Drawing.Size(100, 27);
            this.tbUserId.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "고유번호";
            // 
            // btnUserSearch
            // 
            this.btnUserSearch.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUserSearch.Location = new System.Drawing.Point(563, 65);
            this.btnUserSearch.Name = "btnUserSearch";
            this.btnUserSearch.Size = new System.Drawing.Size(92, 39);
            this.btnUserSearch.TabIndex = 1;
            this.btnUserSearch.Text = "검색(&S)";
            this.btnUserSearch.UseVisualStyleBackColor = true;
            this.btnUserSearch.Click += new System.EventHandler(this.btnUserSearch_Click);
            // 
            // UserSearchControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnUserSearch);
            this.Controls.Add(this.gbUserControl);
            this.Name = "UserSearchControl";
            this.Size = new System.Drawing.Size(666, 114);
            this.gbUserControl.ResumeLayout(false);
            this.gbUserControl.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbUserControl;
        private System.Windows.Forms.TextBox tbLoginId;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbUserName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbUserId;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox tbUserPhoneNumber;
        private System.Windows.Forms.Button btnUserSearch;
    }
}
