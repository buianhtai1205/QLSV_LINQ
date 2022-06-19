namespace QLSV_LinQ
{
    partial class frmMain
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
            this.lblTitle = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.quảnLýToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.DangNhap = new System.Windows.Forms.ToolStripMenuItem();
            this.quanlyTK = new System.Windows.Forms.ToolStripMenuItem();
            this.DangXuat = new System.Windows.Forms.ToolStripMenuItem();
            this.TacVuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quanliMain = new System.Windows.Forms.ToolStripMenuItem();
            this.báoCáoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.xuatDSMH = new System.Windows.Forms.ToolStripMenuItem();
            this.xuatDSSV = new System.Windows.Forms.ToolStripMenuItem();
            this.xemDiem = new System.Windows.Forms.ToolStripMenuItem();
            this.thoat = new System.Windows.Forms.ToolStripMenuItem();
            this.grBoxLeftMenu = new System.Windows.Forms.GroupBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pan_MenuQLDIEM = new System.Windows.Forms.Panel();
            this.lnkXuatSV = new System.Windows.Forms.LinkLabel();
            this.lnkXuatDSMH = new System.Windows.Forms.LinkLabel();
            this.lnkXemDiem = new System.Windows.Forms.LinkLabel();
            this.btnQLDIEM_ex = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pan_MenuMH = new System.Windows.Forms.Panel();
            this.lnkNhapDiem = new System.Windows.Forms.LinkLabel();
            this.lnk_QuanlySv_lop_mh = new System.Windows.Forms.LinkLabel();
            this.btnQLMH_ex = new System.Windows.Forms.Button();
            this.thốngKêToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thongkeDiem = new System.Windows.Forms.ToolStripMenuItem();
            this.thongkeTiLe = new System.Windows.Forms.ToolStripMenuItem();
            this.pan_Main = new System.Windows.Forms.Panel();
            this.menuStrip1.SuspendLayout();
            this.grBoxLeftMenu.SuspendLayout();
            this.panel3.SuspendLayout();
            this.pan_MenuQLDIEM.SuspendLayout();
            this.panel2.SuspendLayout();
            this.pan_MenuMH.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.Red;
            this.lblTitle.Location = new System.Drawing.Point(472, -23);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(0, 26);
            this.lblTitle.TabIndex = 8;
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Transparent;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.quảnLýToolStripMenuItem1,
            this.TacVuToolStripMenuItem,
            this.báoCáoToolStripMenuItem,
            this.thốngKêToolStripMenuItem,
            this.thoat});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(964, 30);
            this.menuStrip1.TabIndex = 9;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // quảnLýToolStripMenuItem1
            // 
            this.quảnLýToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.DangNhap,
            this.quanlyTK,
            this.DangXuat});
            this.quảnLýToolStripMenuItem1.Name = "quảnLýToolStripMenuItem1";
            this.quảnLýToolStripMenuItem1.Size = new System.Drawing.Size(73, 26);
            this.quảnLýToolStripMenuItem1.Text = "Quản lý";
            // 
            // DangNhap
            // 
            this.DangNhap.Name = "DangNhap";
            this.DangNhap.Size = new System.Drawing.Size(207, 26);
            this.DangNhap.Text = "Đăng nhập";
            this.DangNhap.Click += new System.EventHandler(this.DangNhap_Click);
            // 
            // quanlyTK
            // 
            this.quanlyTK.Name = "quanlyTK";
            this.quanlyTK.Size = new System.Drawing.Size(207, 26);
            this.quanlyTK.Text = "Quản lý tài khoản";
            // 
            // DangXuat
            // 
            this.DangXuat.Name = "DangXuat";
            this.DangXuat.Size = new System.Drawing.Size(207, 26);
            this.DangXuat.Text = "Đăng Xuất";
            this.DangXuat.Click += new System.EventHandler(this.DangXuat_Click);
            // 
            // TacVuToolStripMenuItem
            // 
            this.TacVuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.quanliMain});
            this.TacVuToolStripMenuItem.Name = "TacVuToolStripMenuItem";
            this.TacVuToolStripMenuItem.Size = new System.Drawing.Size(63, 26);
            this.TacVuToolStripMenuItem.Text = "Tác vụ";
            // 
            // quanliMain
            // 
            this.quanliMain.Name = "quanliMain";
            this.quanliMain.Size = new System.Drawing.Size(139, 26);
            this.quanliMain.Text = "Quản lí";
            this.quanliMain.Click += new System.EventHandler(this.quanliMain_Click);
            // 
            // báoCáoToolStripMenuItem
            // 
            this.báoCáoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.xuatDSMH,
            this.xuatDSSV,
            this.xemDiem});
            this.báoCáoToolStripMenuItem.Name = "báoCáoToolStripMenuItem";
            this.báoCáoToolStripMenuItem.Size = new System.Drawing.Size(79, 26);
            this.báoCáoToolStripMenuItem.Text = "Báo Cáo";
            // 
            // xuatDSMH
            // 
            this.xuatDSMH.Name = "xuatDSMH";
            this.xuatDSMH.Size = new System.Drawing.Size(254, 26);
            this.xuatDSMH.Text = "Xuất danh sách môn học";
            this.xuatDSMH.Click += new System.EventHandler(this.xuatDSMH_Click);
            // 
            // xuatDSSV
            // 
            this.xuatDSSV.Name = "xuatDSSV";
            this.xuatDSSV.Size = new System.Drawing.Size(254, 26);
            this.xuatDSSV.Text = "Xuất danh sách sinh viên";
            this.xuatDSSV.Click += new System.EventHandler(this.xuatDSSV_Click);
            // 
            // xemDiem
            // 
            this.xemDiem.Name = "xemDiem";
            this.xemDiem.Size = new System.Drawing.Size(254, 26);
            this.xemDiem.Text = "Xem điểm";
            this.xemDiem.Click += new System.EventHandler(this.xemDiem_Click);
            // 
            // thoat
            // 
            this.thoat.Name = "thoat";
            this.thoat.Size = new System.Drawing.Size(61, 26);
            this.thoat.Text = "Thoát";
            this.thoat.Click += new System.EventHandler(this.thoat_Click);
            // 
            // grBoxLeftMenu
            // 
            this.grBoxLeftMenu.Controls.Add(this.panel3);
            this.grBoxLeftMenu.Controls.Add(this.panel2);
            this.grBoxLeftMenu.Location = new System.Drawing.Point(12, 37);
            this.grBoxLeftMenu.Name = "grBoxLeftMenu";
            this.grBoxLeftMenu.Size = new System.Drawing.Size(237, 443);
            this.grBoxLeftMenu.TabIndex = 10;
            this.grBoxLeftMenu.TabStop = false;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.pan_MenuQLDIEM);
            this.panel3.Controls.Add(this.btnQLDIEM_ex);
            this.panel3.Location = new System.Drawing.Point(8, 160);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(215, 148);
            this.panel3.TabIndex = 2;
            // 
            // pan_MenuQLDIEM
            // 
            this.pan_MenuQLDIEM.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pan_MenuQLDIEM.Controls.Add(this.lnkXuatSV);
            this.pan_MenuQLDIEM.Controls.Add(this.lnkXuatDSMH);
            this.pan_MenuQLDIEM.Controls.Add(this.lnkXemDiem);
            this.pan_MenuQLDIEM.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pan_MenuQLDIEM.Location = new System.Drawing.Point(3, 36);
            this.pan_MenuQLDIEM.Name = "pan_MenuQLDIEM";
            this.pan_MenuQLDIEM.Size = new System.Drawing.Size(212, 112);
            this.pan_MenuQLDIEM.TabIndex = 3;
            // 
            // lnkXuatSV
            // 
            this.lnkXuatSV.AutoSize = true;
            this.lnkXuatSV.Location = new System.Drawing.Point(16, 50);
            this.lnkXuatSV.Name = "lnkXuatSV";
            this.lnkXuatSV.Size = new System.Drawing.Size(180, 18);
            this.lnkXuatSV.TabIndex = 9;
            this.lnkXuatSV.TabStop = true;
            this.lnkXuatSV.Text = "Xuất Danh Sách Sinh Viên";
            // 
            // lnkXuatDSMH
            // 
            this.lnkXuatDSMH.AutoSize = true;
            this.lnkXuatDSMH.Location = new System.Drawing.Point(15, 19);
            this.lnkXuatDSMH.Name = "lnkXuatDSMH";
            this.lnkXuatDSMH.Size = new System.Drawing.Size(181, 18);
            this.lnkXuatDSMH.TabIndex = 8;
            this.lnkXuatDSMH.TabStop = true;
            this.lnkXuatDSMH.Text = "Xuất Danh Sách Môn Học";
            // 
            // lnkXemDiem
            // 
            this.lnkXemDiem.AutoSize = true;
            this.lnkXemDiem.Location = new System.Drawing.Point(16, 79);
            this.lnkXemDiem.Name = "lnkXemDiem";
            this.lnkXemDiem.Size = new System.Drawing.Size(78, 18);
            this.lnkXemDiem.TabIndex = 7;
            this.lnkXemDiem.TabStop = true;
            this.lnkXemDiem.Text = "Xem Điểm";
            // 
            // btnQLDIEM_ex
            // 
            this.btnQLDIEM_ex.Location = new System.Drawing.Point(3, 3);
            this.btnQLDIEM_ex.Name = "btnQLDIEM_ex";
            this.btnQLDIEM_ex.Size = new System.Drawing.Size(210, 35);
            this.btnQLDIEM_ex.TabIndex = 2;
            this.btnQLDIEM_ex.Text = "Báo Cáo";
            this.btnQLDIEM_ex.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.pan_MenuMH);
            this.panel2.Controls.Add(this.btnQLMH_ex);
            this.panel2.Location = new System.Drawing.Point(6, 17);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(225, 137);
            this.panel2.TabIndex = 1;
            // 
            // pan_MenuMH
            // 
            this.pan_MenuMH.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pan_MenuMH.Controls.Add(this.lnkNhapDiem);
            this.pan_MenuMH.Controls.Add(this.lnk_QuanlySv_lop_mh);
            this.pan_MenuMH.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pan_MenuMH.Location = new System.Drawing.Point(5, 39);
            this.pan_MenuMH.Name = "pan_MenuMH";
            this.pan_MenuMH.Size = new System.Drawing.Size(212, 95);
            this.pan_MenuMH.TabIndex = 5;
            // 
            // lnkNhapDiem
            // 
            this.lnkNhapDiem.AutoSize = true;
            this.lnkNhapDiem.Location = new System.Drawing.Point(16, 48);
            this.lnkNhapDiem.Name = "lnkNhapDiem";
            this.lnkNhapDiem.Size = new System.Drawing.Size(79, 18);
            this.lnkNhapDiem.TabIndex = 8;
            this.lnkNhapDiem.TabStop = true;
            this.lnkNhapDiem.Text = "Nhập điểm";
            // 
            // lnk_QuanlySv_lop_mh
            // 
            this.lnk_QuanlySv_lop_mh.AutoSize = true;
            this.lnk_QuanlySv_lop_mh.Location = new System.Drawing.Point(15, 13);
            this.lnk_QuanlySv_lop_mh.Name = "lnk_QuanlySv_lop_mh";
            this.lnk_QuanlySv_lop_mh.Size = new System.Drawing.Size(233, 18);
            this.lnk_QuanlySv_lop_mh.TabIndex = 0;
            this.lnk_QuanlySv_lop_mh.TabStop = true;
            this.lnk_QuanlySv_lop_mh.Text = "Sinh viên - Lớp - Môn học - Ngành";
            // 
            // btnQLMH_ex
            // 
            this.btnQLMH_ex.Location = new System.Drawing.Point(0, 3);
            this.btnQLMH_ex.Name = "btnQLMH_ex";
            this.btnQLMH_ex.Size = new System.Drawing.Size(217, 35);
            this.btnQLMH_ex.TabIndex = 4;
            this.btnQLMH_ex.Text = "Quản lý chung";
            this.btnQLMH_ex.UseVisualStyleBackColor = true;
            // 
            // thốngKêToolStripMenuItem
            // 
            this.thốngKêToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.thongkeDiem,
            this.thongkeTiLe});
            this.thốngKêToolStripMenuItem.Name = "thốngKêToolStripMenuItem";
            this.thốngKêToolStripMenuItem.Size = new System.Drawing.Size(84, 26);
            this.thốngKêToolStripMenuItem.Text = "Thống kê";
            // 
            // thongkeDiem
            // 
            this.thongkeDiem.Name = "thongkeDiem";
            this.thongkeDiem.Size = new System.Drawing.Size(224, 26);
            this.thongkeDiem.Text = "Điểm";
            this.thongkeDiem.Click += new System.EventHandler(this.thongkeDiem_Click);
            // 
            // thongkeTiLe
            // 
            this.thongkeTiLe.Name = "thongkeTiLe";
            this.thongkeTiLe.Size = new System.Drawing.Size(224, 26);
            this.thongkeTiLe.Text = "Tỉ lệ";
            this.thongkeTiLe.Click += new System.EventHandler(this.thongkeTiLe_Click);
            // 
            // pan_Main
            // 
            this.pan_Main.BackgroundImage = global::QLSV_LinQ.Properties.Resources.frmMainbg;
            this.pan_Main.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pan_Main.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pan_Main.Location = new System.Drawing.Point(255, 37);
            this.pan_Main.Name = "pan_Main";
            this.pan_Main.Size = new System.Drawing.Size(685, 443);
            this.pan_Main.TabIndex = 7;
            this.pan_Main.Paint += new System.Windows.Forms.PaintEventHandler(this.pan_Main_Paint);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Bisque;
            this.ClientSize = new System.Drawing.Size(964, 508);
            this.Controls.Add(this.grBoxLeftMenu);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.pan_Main);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "frmMain";
            this.Text = "frmMain";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.grBoxLeftMenu.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.pan_MenuQLDIEM.ResumeLayout(false);
            this.pan_MenuQLDIEM.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.pan_MenuMH.ResumeLayout(false);
            this.pan_MenuMH.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem quảnLýToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem DangNhap;
        private System.Windows.Forms.ToolStripMenuItem quanlyTK;
        private System.Windows.Forms.ToolStripMenuItem DangXuat;
        private System.Windows.Forms.ToolStripMenuItem TacVuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quanliMain;
        private System.Windows.Forms.ToolStripMenuItem báoCáoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem xuatDSMH;
        private System.Windows.Forms.ToolStripMenuItem xemDiem;
        private System.Windows.Forms.ToolStripMenuItem thoat;
        public System.Windows.Forms.Panel pan_Main;
        private System.Windows.Forms.ToolStripMenuItem xuatDSSV;
        private System.Windows.Forms.GroupBox grBoxLeftMenu;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel pan_MenuMH;
        private System.Windows.Forms.LinkLabel lnkNhapDiem;
        private System.Windows.Forms.LinkLabel lnk_QuanlySv_lop_mh;
        private System.Windows.Forms.Button btnQLMH_ex;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel pan_MenuQLDIEM;
        private System.Windows.Forms.LinkLabel lnkXuatSV;
        private System.Windows.Forms.LinkLabel lnkXuatDSMH;
        private System.Windows.Forms.LinkLabel lnkXemDiem;
        private System.Windows.Forms.Button btnQLDIEM_ex;
        private System.Windows.Forms.ToolStripMenuItem thốngKêToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thongkeDiem;
        private System.Windows.Forms.ToolStripMenuItem thongkeTiLe;
    }
}