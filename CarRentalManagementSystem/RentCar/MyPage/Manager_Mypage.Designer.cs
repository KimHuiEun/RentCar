
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("erp 형 데이터 찾아보기");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("노드1");
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("노드2");
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("노드3");
            System.Windows.Forms.TreeNode treeNode5 = new System.Windows.Forms.TreeNode("노드4");
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripProgressBar1 = new System.Windows.Forms.ToolStripProgressBar();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.managerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.저장SToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.종료CToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.고객관리ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.고객조회ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.고객수정ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.고객삭제ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.차량관리ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.차량등록ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.차량삭제ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.차량데이터입력ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.차량데이터수정ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.차량데이터삭제ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.예약관리ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.등록ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.확인ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.삭제ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.보고ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.일별보고서ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.월별보고서ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.연말정산ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.statusStrip1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.Text = "notifyIcon1";
            this.notifyIcon1.Visible = true;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.statusStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripProgressBar1,
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(531, 425);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(271, 26);
            this.statusStrip1.TabIndex = 0;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripProgressBar1
            // 
            this.toolStripProgressBar1.Name = "toolStripProgressBar1";
            this.toolStripProgressBar1.Size = new System.Drawing.Size(100, 18);
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(152, 20);
            this.toolStripStatusLabel1.Text = "toolStripStatusLabel1";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.managerToolStripMenuItem,
            this.고객관리ToolStripMenuItem,
            this.차량관리ToolStripMenuItem,
            this.예약관리ToolStripMenuItem,
            this.보고ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 28);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // managerToolStripMenuItem
            // 
            this.managerToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.저장SToolStripMenuItem,
            this.toolStripSeparator1,
            this.종료CToolStripMenuItem});
            this.managerToolStripMenuItem.Name = "managerToolStripMenuItem";
            this.managerToolStripMenuItem.Size = new System.Drawing.Size(84, 24);
            this.managerToolStripMenuItem.Text = "Manager";
            // 
            // 저장SToolStripMenuItem
            // 
            this.저장SToolStripMenuItem.Name = "저장SToolStripMenuItem";
            this.저장SToolStripMenuItem.Size = new System.Drawing.Size(142, 26);
            this.저장SToolStripMenuItem.Text = "저장(&S)";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(139, 6);
            // 
            // 종료CToolStripMenuItem
            // 
            this.종료CToolStripMenuItem.Name = "종료CToolStripMenuItem";
            this.종료CToolStripMenuItem.Size = new System.Drawing.Size(142, 26);
            this.종료CToolStripMenuItem.Text = "종료(&C)";
            // 
            // 고객관리ToolStripMenuItem
            // 
            this.고객관리ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.고객조회ToolStripMenuItem,
            this.고객수정ToolStripMenuItem,
            this.고객삭제ToolStripMenuItem});
            this.고객관리ToolStripMenuItem.Name = "고객관리ToolStripMenuItem";
            this.고객관리ToolStripMenuItem.Size = new System.Drawing.Size(88, 24);
            this.고객관리ToolStripMenuItem.Text = "고객 관리";
            // 
            // 고객조회ToolStripMenuItem
            // 
            this.고객조회ToolStripMenuItem.Name = "고객조회ToolStripMenuItem";
            this.고객조회ToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.고객조회ToolStripMenuItem.Text = "고객 조회";
            // 
            // 고객수정ToolStripMenuItem
            // 
            this.고객수정ToolStripMenuItem.Name = "고객수정ToolStripMenuItem";
            this.고객수정ToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.고객수정ToolStripMenuItem.Text = "고객 수정";
            // 
            // 고객삭제ToolStripMenuItem
            // 
            this.고객삭제ToolStripMenuItem.Name = "고객삭제ToolStripMenuItem";
            this.고객삭제ToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.고객삭제ToolStripMenuItem.Text = "고객 삭제";
            // 
            // 차량관리ToolStripMenuItem
            // 
            this.차량관리ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.차량등록ToolStripMenuItem,
            this.차량삭제ToolStripMenuItem,
            this.차량데이터입력ToolStripMenuItem,
            this.차량데이터수정ToolStripMenuItem,
            this.차량데이터삭제ToolStripMenuItem});
            this.차량관리ToolStripMenuItem.Name = "차량관리ToolStripMenuItem";
            this.차량관리ToolStripMenuItem.Size = new System.Drawing.Size(88, 24);
            this.차량관리ToolStripMenuItem.Text = "차량 관리";
            // 
            // 차량등록ToolStripMenuItem
            // 
            this.차량등록ToolStripMenuItem.Name = "차량등록ToolStripMenuItem";
            this.차량등록ToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.차량등록ToolStripMenuItem.Text = "차량 등록";
            // 
            // 차량삭제ToolStripMenuItem
            // 
            this.차량삭제ToolStripMenuItem.Name = "차량삭제ToolStripMenuItem";
            this.차량삭제ToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.차량삭제ToolStripMenuItem.Text = "차량 삭제";
            // 
            // 차량데이터입력ToolStripMenuItem
            // 
            this.차량데이터입력ToolStripMenuItem.Name = "차량데이터입력ToolStripMenuItem";
            this.차량데이터입력ToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.차량데이터입력ToolStripMenuItem.Text = "차량 데이터 입력";
            // 
            // 차량데이터수정ToolStripMenuItem
            // 
            this.차량데이터수정ToolStripMenuItem.Name = "차량데이터수정ToolStripMenuItem";
            this.차량데이터수정ToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.차량데이터수정ToolStripMenuItem.Text = "차량 데이터 수정";
            // 
            // 차량데이터삭제ToolStripMenuItem
            // 
            this.차량데이터삭제ToolStripMenuItem.Name = "차량데이터삭제ToolStripMenuItem";
            this.차량데이터삭제ToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.차량데이터삭제ToolStripMenuItem.Text = "차량 데이터 삭제";
            // 
            // 예약관리ToolStripMenuItem
            // 
            this.예약관리ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.등록ToolStripMenuItem,
            this.확인ToolStripMenuItem,
            this.삭제ToolStripMenuItem});
            this.예약관리ToolStripMenuItem.Name = "예약관리ToolStripMenuItem";
            this.예약관리ToolStripMenuItem.Size = new System.Drawing.Size(88, 24);
            this.예약관리ToolStripMenuItem.Text = "예약 관리";
            // 
            // 등록ToolStripMenuItem
            // 
            this.등록ToolStripMenuItem.Name = "등록ToolStripMenuItem";
            this.등록ToolStripMenuItem.Size = new System.Drawing.Size(122, 26);
            this.등록ToolStripMenuItem.Text = "등록";
            // 
            // 확인ToolStripMenuItem
            // 
            this.확인ToolStripMenuItem.Name = "확인ToolStripMenuItem";
            this.확인ToolStripMenuItem.Size = new System.Drawing.Size(122, 26);
            this.확인ToolStripMenuItem.Text = "확인";
            // 
            // 삭제ToolStripMenuItem
            // 
            this.삭제ToolStripMenuItem.Name = "삭제ToolStripMenuItem";
            this.삭제ToolStripMenuItem.Size = new System.Drawing.Size(122, 26);
            this.삭제ToolStripMenuItem.Text = "삭제";
            // 
            // 보고ToolStripMenuItem
            // 
            this.보고ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.일별보고서ToolStripMenuItem,
            this.월별보고서ToolStripMenuItem,
            this.연말정산ToolStripMenuItem});
            this.보고ToolStripMenuItem.Name = "보고ToolStripMenuItem";
            this.보고ToolStripMenuItem.Size = new System.Drawing.Size(53, 24);
            this.보고ToolStripMenuItem.Text = "보고";
            // 
            // 일별보고서ToolStripMenuItem
            // 
            this.일별보고서ToolStripMenuItem.Name = "일별보고서ToolStripMenuItem";
            this.일별보고서ToolStripMenuItem.Size = new System.Drawing.Size(172, 26);
            this.일별보고서ToolStripMenuItem.Text = "일별 보고서";
            // 
            // 월별보고서ToolStripMenuItem
            // 
            this.월별보고서ToolStripMenuItem.Name = "월별보고서ToolStripMenuItem";
            this.월별보고서ToolStripMenuItem.Size = new System.Drawing.Size(172, 26);
            this.월별보고서ToolStripMenuItem.Text = "월별 보고서";
            // 
            // 연말정산ToolStripMenuItem
            // 
            this.연말정산ToolStripMenuItem.Name = "연말정산ToolStripMenuItem";
            this.연말정산ToolStripMenuItem.Size = new System.Drawing.Size(172, 26);
            this.연말정산ToolStripMenuItem.Text = "연말 정산";
            // 
            // treeView1
            // 
            this.treeView1.Location = new System.Drawing.Point(26, 89);
            this.treeView1.Name = "treeView1";
            treeNode1.Name = "노드0";
            treeNode1.Text = "erp 형 데이터 찾아보기";
            treeNode2.Name = "노드1";
            treeNode2.Text = "노드1";
            treeNode3.Name = "노드2";
            treeNode3.Text = "노드2";
            treeNode4.Name = "노드3";
            treeNode4.Text = "노드3";
            treeNode5.Name = "노드4";
            treeNode5.Text = "노드4";
            this.treeView1.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode2,
            treeNode3,
            treeNode4,
            treeNode5});
            this.treeView1.Size = new System.Drawing.Size(235, 235);
            this.treeView1.TabIndex = 3;
            this.treeView1.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView1_AfterSelect);
            // 
            // Manager_Mypage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.treeView1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Manager_Mypage";
            this.Text = "Manager_Mypage";
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripProgressBar toolStripProgressBar1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem managerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 저장SToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem 종료CToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 고객관리ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 고객조회ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 고객수정ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 고객삭제ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 차량관리ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 차량등록ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 차량삭제ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 차량데이터입력ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 차량데이터수정ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 차량데이터삭제ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 예약관리ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 등록ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 확인ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 삭제ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 보고ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 일별보고서ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 월별보고서ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 연말정산ToolStripMenuItem;
        private System.Windows.Forms.TreeView treeView1;
    }
}