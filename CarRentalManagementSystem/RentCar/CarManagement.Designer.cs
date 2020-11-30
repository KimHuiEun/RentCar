
namespace RentCar
{
    partial class CarManagement
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
            this.BtnSave = new System.Windows.Forms.Button();
            this.BtnDelete = new System.Windows.Forms.Button();
            this.BtnCancel = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.CbCarSize = new System.Windows.Forms.ComboBox();
            this.TbModel = new System.Windows.Forms.TextBox();
            this.TbPrice = new System.Windows.Forms.TextBox();
            this.CbIsRent = new System.Windows.Forms.ComboBox();
            this.DgvCar = new System.Windows.Forms.DataGridView();
            this.programBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.크기 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.모델명 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.가격 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.렌트여부 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.DgvCar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.programBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnSave
            // 
            this.BtnSave.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSave.Location = new System.Drawing.Point(26, 264);
            this.BtnSave.Margin = new System.Windows.Forms.Padding(2);
            this.BtnSave.Name = "BtnSave";
            this.BtnSave.Size = new System.Drawing.Size(60, 29);
            this.BtnSave.TabIndex = 0;
            this.BtnSave.Text = "등록";
            this.BtnSave.UseVisualStyleBackColor = true;
            this.BtnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // BtnDelete
            // 
            this.BtnDelete.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnDelete.Location = new System.Drawing.Point(102, 264);
            this.BtnDelete.Margin = new System.Windows.Forms.Padding(2);
            this.BtnDelete.Name = "BtnDelete";
            this.BtnDelete.Size = new System.Drawing.Size(60, 29);
            this.BtnDelete.TabIndex = 1;
            this.BtnDelete.Text = "삭제";
            this.BtnDelete.UseVisualStyleBackColor = true;
            // 
            // BtnCancel
            // 
            this.BtnCancel.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCancel.Location = new System.Drawing.Point(178, 263);
            this.BtnCancel.Margin = new System.Windows.Forms.Padding(2);
            this.BtnCancel.Name = "BtnCancel";
            this.BtnCancel.Size = new System.Drawing.Size(60, 30);
            this.BtnCancel.TabIndex = 2;
            this.BtnCancel.Text = "취소";
            this.BtnCancel.UseVisualStyleBackColor = true;
            this.BtnCancel.Click += new System.EventHandler(this.BtnCancel_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(26, 73);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 23);
            this.label1.TabIndex = 3;
            this.label1.Text = "차 크키";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(26, 114);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 23);
            this.label2.TabIndex = 4;
            this.label2.Text = "모델명";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(26, 154);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 23);
            this.label3.TabIndex = 5;
            this.label3.Text = "가격";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(26, 194);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 23);
            this.label4.TabIndex = 6;
            this.label4.Text = "렌트여부";
            // 
            // CbCarSize
            // 
            this.CbCarSize.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CbCarSize.FormattingEnabled = true;
            this.CbCarSize.Items.AddRange(new object[] {
            "경형",
            "소형",
            "준중형",
            "중형",
            "준대형",
            "대형"});
            this.CbCarSize.Location = new System.Drawing.Point(102, 73);
            this.CbCarSize.Margin = new System.Windows.Forms.Padding(2);
            this.CbCarSize.Name = "CbCarSize";
            this.CbCarSize.Size = new System.Drawing.Size(138, 31);
            this.CbCarSize.TabIndex = 7;
            // 
            // TbModel
            // 
            this.TbModel.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TbModel.Location = new System.Drawing.Point(102, 114);
            this.TbModel.Margin = new System.Windows.Forms.Padding(2);
            this.TbModel.Name = "TbModel";
            this.TbModel.Size = new System.Drawing.Size(138, 31);
            this.TbModel.TabIndex = 8;
            // 
            // TbPrice
            // 
            this.TbPrice.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TbPrice.Location = new System.Drawing.Point(102, 154);
            this.TbPrice.Margin = new System.Windows.Forms.Padding(2);
            this.TbPrice.Name = "TbPrice";
            this.TbPrice.Size = new System.Drawing.Size(138, 31);
            this.TbPrice.TabIndex = 9;
            // 
            // CbIsRent
            // 
            this.CbIsRent.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CbIsRent.FormattingEnabled = true;
            this.CbIsRent.Items.AddRange(new object[] {
            "유",
            "무"});
            this.CbIsRent.Location = new System.Drawing.Point(102, 194);
            this.CbIsRent.Margin = new System.Windows.Forms.Padding(2);
            this.CbIsRent.Name = "CbIsRent";
            this.CbIsRent.Size = new System.Drawing.Size(138, 31);
            this.CbIsRent.TabIndex = 10;
            // 
            // DgvCar
            // 
            this.DgvCar.AllowUserToOrderColumns = true;
            this.DgvCar.AutoGenerateColumns = false;
            this.DgvCar.BackgroundColor = System.Drawing.Color.White;
            this.DgvCar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvCar.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.크기,
            this.모델명,
            this.가격,
            this.렌트여부});
            this.DgvCar.DataSource = this.programBindingSource;
            this.DgvCar.Location = new System.Drawing.Point(255, 66);
            this.DgvCar.Margin = new System.Windows.Forms.Padding(2);
            this.DgvCar.Name = "DgvCar";
            this.DgvCar.RowHeadersWidth = 62;
            this.DgvCar.RowTemplate.Height = 30;
            this.DgvCar.Size = new System.Drawing.Size(702, 227);
            this.DgvCar.TabIndex = 11;
            // 
            // programBindingSource
            // 
            this.programBindingSource.DataSource = typeof(RentCar.Program);
            // 
            // 크기
            // 
            this.크기.HeaderText = "크기";
            this.크기.MinimumWidth = 6;
            this.크기.Name = "크기";
            this.크기.Width = 125;
            // 
            // 모델명
            // 
            this.모델명.HeaderText = "모델명";
            this.모델명.MinimumWidth = 6;
            this.모델명.Name = "모델명";
            this.모델명.Width = 125;
            // 
            // 가격
            // 
            this.가격.HeaderText = "가격";
            this.가격.MinimumWidth = 6;
            this.가격.Name = "가격";
            this.가격.Width = 125;
            // 
            // 렌트여부
            // 
            this.렌트여부.HeaderText = "렌트여부";
            this.렌트여부.MinimumWidth = 6;
            this.렌트여부.Name = "렌트여부";
            this.렌트여부.Width = 125;
            // 
            // CarManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(995, 374);
            this.Controls.Add(this.DgvCar);
            this.Controls.Add(this.CbIsRent);
            this.Controls.Add(this.TbPrice);
            this.Controls.Add(this.TbModel);
            this.Controls.Add(this.CbCarSize);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BtnCancel);
            this.Controls.Add(this.BtnDelete);
            this.Controls.Add(this.BtnSave);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "CarManagement";
            this.Text = "CarManagement";
            this.Load += new System.EventHandler(this.CarManagement_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DgvCar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.programBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnSave;
        private System.Windows.Forms.Button BtnDelete;
        private System.Windows.Forms.Button BtnCancel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox CbCarSize;
        private System.Windows.Forms.TextBox TbModel;
        private System.Windows.Forms.TextBox TbPrice;
        private System.Windows.Forms.ComboBox CbIsRent;
        private System.Windows.Forms.DataGridView DgvCar;
        private System.Windows.Forms.BindingSource programBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn 크기;
        private System.Windows.Forms.DataGridViewTextBoxColumn 모델명;
        private System.Windows.Forms.DataGridViewTextBoxColumn 가격;
        private System.Windows.Forms.DataGridViewTextBoxColumn 렌트여부;
    }
}