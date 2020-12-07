
namespace RentCar
{
    partial class UserList
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
            this.dgvUser = new System.Windows.Forms.DataGridView();
            this.userBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bdsAlbum = new System.Windows.Forms.BindingSource(this.components);
            this.userIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phoneNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.loginIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.loginPwDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.licenseDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.issueDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adminsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eventsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rentsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.searchesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUser)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsAlbum)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvUser
            // 
            this.dgvUser.AutoGenerateColumns = false;
            this.dgvUser.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUser.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.userIdDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.phoneNumberDataGridViewTextBoxColumn,
            this.emailDataGridViewTextBoxColumn,
            this.loginIdDataGridViewTextBoxColumn,
            this.loginPwDataGridViewTextBoxColumn,
            this.licenseDataGridViewTextBoxColumn,
            this.issueDateDataGridViewTextBoxColumn,
            this.adminsDataGridViewTextBoxColumn,
            this.eventsDataGridViewTextBoxColumn,
            this.rentsDataGridViewTextBoxColumn,
            this.searchesDataGridViewTextBoxColumn});
            this.dgvUser.DataSource = this.userBindingSource;
            this.dgvUser.Location = new System.Drawing.Point(2, 147);
            this.dgvUser.Name = "dgvUser";
            this.dgvUser.RowHeadersWidth = 51;
            this.dgvUser.RowTemplate.Height = 27;
            this.dgvUser.Size = new System.Drawing.Size(1053, 306);
            this.dgvUser.TabIndex = 0;


            // 
            // userIdDataGridViewTextBoxColumn
            // 
            this.userIdDataGridViewTextBoxColumn.DataPropertyName = "UserId";
            this.userIdDataGridViewTextBoxColumn.HeaderText = "UserId";
            this.userIdDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.userIdDataGridViewTextBoxColumn.Name = "userIdDataGridViewTextBoxColumn";
            this.userIdDataGridViewTextBoxColumn.ReadOnly = true;
            this.userIdDataGridViewTextBoxColumn.Width = 125;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.Width = 125;
            // 
            // phoneNumberDataGridViewTextBoxColumn
            // 
            this.phoneNumberDataGridViewTextBoxColumn.DataPropertyName = "PhoneNumber";
            this.phoneNumberDataGridViewTextBoxColumn.HeaderText = "PhoneNumber";
            this.phoneNumberDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.phoneNumberDataGridViewTextBoxColumn.Name = "phoneNumberDataGridViewTextBoxColumn";
            this.phoneNumberDataGridViewTextBoxColumn.Width = 125;
            // 
            // emailDataGridViewTextBoxColumn
            // 
            this.emailDataGridViewTextBoxColumn.DataPropertyName = "Email";
            this.emailDataGridViewTextBoxColumn.HeaderText = "Email";
            this.emailDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.emailDataGridViewTextBoxColumn.Name = "emailDataGridViewTextBoxColumn";
            this.emailDataGridViewTextBoxColumn.Width = 125;
            // 
            // loginIdDataGridViewTextBoxColumn
            // 
            this.loginIdDataGridViewTextBoxColumn.DataPropertyName = "LoginId";
            this.loginIdDataGridViewTextBoxColumn.HeaderText = "LoginId";
            this.loginIdDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.loginIdDataGridViewTextBoxColumn.Name = "loginIdDataGridViewTextBoxColumn";
            this.loginIdDataGridViewTextBoxColumn.Width = 125;
            // 
            // loginPwDataGridViewTextBoxColumn
            // 
            this.loginPwDataGridViewTextBoxColumn.DataPropertyName = "LoginPw";
            this.loginPwDataGridViewTextBoxColumn.HeaderText = "LoginPw";
            this.loginPwDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.loginPwDataGridViewTextBoxColumn.Name = "loginPwDataGridViewTextBoxColumn";
            this.loginPwDataGridViewTextBoxColumn.Width = 125;
            // 
            // licenseDataGridViewTextBoxColumn
            // 
            this.licenseDataGridViewTextBoxColumn.DataPropertyName = "License";
            this.licenseDataGridViewTextBoxColumn.HeaderText = "License";
            this.licenseDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.licenseDataGridViewTextBoxColumn.Name = "licenseDataGridViewTextBoxColumn";
            this.licenseDataGridViewTextBoxColumn.Width = 125;
            // 
            // issueDateDataGridViewTextBoxColumn
            // 
            this.issueDateDataGridViewTextBoxColumn.DataPropertyName = "IssueDate";
            this.issueDateDataGridViewTextBoxColumn.HeaderText = "IssueDate";
            this.issueDateDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.issueDateDataGridViewTextBoxColumn.Name = "issueDateDataGridViewTextBoxColumn";
            this.issueDateDataGridViewTextBoxColumn.Width = 125;
            // 
            // adminsDataGridViewTextBoxColumn
            // 
            this.adminsDataGridViewTextBoxColumn.DataPropertyName = "Admins";
            this.adminsDataGridViewTextBoxColumn.HeaderText = "Admins";
            this.adminsDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.adminsDataGridViewTextBoxColumn.Name = "adminsDataGridViewTextBoxColumn";
            this.adminsDataGridViewTextBoxColumn.Width = 125;
            // 
            // eventsDataGridViewTextBoxColumn
            // 
            this.eventsDataGridViewTextBoxColumn.DataPropertyName = "Events";
            this.eventsDataGridViewTextBoxColumn.HeaderText = "Events";
            this.eventsDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.eventsDataGridViewTextBoxColumn.Name = "eventsDataGridViewTextBoxColumn";
            this.eventsDataGridViewTextBoxColumn.Width = 125;
            // 
            // rentsDataGridViewTextBoxColumn
            // 
            this.rentsDataGridViewTextBoxColumn.DataPropertyName = "Rents";
            this.rentsDataGridViewTextBoxColumn.HeaderText = "Rents";
            this.rentsDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.rentsDataGridViewTextBoxColumn.Name = "rentsDataGridViewTextBoxColumn";
            this.rentsDataGridViewTextBoxColumn.Width = 125;
            // 
            // searchesDataGridViewTextBoxColumn
            // 
            this.searchesDataGridViewTextBoxColumn.DataPropertyName = "Searches";
            this.searchesDataGridViewTextBoxColumn.HeaderText = "Searches";
            this.searchesDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.searchesDataGridViewTextBoxColumn.Name = "searchesDataGridViewTextBoxColumn";
            this.searchesDataGridViewTextBoxColumn.Width = 125;
            // 
            // UserList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1054, 450);
            this.Controls.Add(this.dgvUser);
            this.Name = "UserList";
            this.Text = "UserList";
            ((System.ComponentModel.ISupportInitialize)(this.dgvUser)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsAlbum)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvUser;
        private System.Windows.Forms.BindingSource bdsAlbum;
        private System.Windows.Forms.BindingSource userBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn userIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn phoneNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn loginIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn loginPwDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn licenseDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn issueDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn adminsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn eventsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rentsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn searchesDataGridViewTextBoxColumn;
    }
}