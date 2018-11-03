namespace QuanLyBanLapTop
{
    partial class frm_Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Main));
            this.mnubarMain = new System.Windows.Forms.MenuStrip();
            this.lblTenTaiKhoan = new System.Windows.Forms.Label();
            this.btnDangXuat = new System.Windows.Forms.Button();
            this.picHinh = new System.Windows.Forms.PictureBox();
            this.mnuNhapHang = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuBanHang = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuHoaDon = new System.Windows.Forms.ToolStripMenuItem();
            this.hÓAĐƠNNHẬPToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hÓAĐƠNBÁNToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnubarMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picHinh)).BeginInit();
            this.SuspendLayout();
            // 
            // mnubarMain
            // 
            this.mnubarMain.AutoSize = false;
            this.mnubarMain.Dock = System.Windows.Forms.DockStyle.Left;
            this.mnubarMain.Font = new System.Drawing.Font("Segoe UI", 13F);
            this.mnubarMain.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.mnubarMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuBanHang,
            this.mnuNhapHang,
            this.mnuHoaDon});
            this.mnubarMain.Location = new System.Drawing.Point(0, 0);
            this.mnubarMain.Name = "mnubarMain";
            this.mnubarMain.Padding = new System.Windows.Forms.Padding(4, 10, 4, 10);
            this.mnubarMain.Size = new System.Drawing.Size(184, 519);
            this.mnubarMain.TabIndex = 0;
            this.mnubarMain.Text = "mnubarMain";
            // 
            // lblTenTaiKhoan
            // 
            this.lblTenTaiKhoan.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblTenTaiKhoan.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTenTaiKhoan.ForeColor = System.Drawing.Color.BlueViolet;
            this.lblTenTaiKhoan.Location = new System.Drawing.Point(8, 406);
            this.lblTenTaiKhoan.Name = "lblTenTaiKhoan";
            this.lblTenTaiKhoan.Size = new System.Drawing.Size(176, 50);
            this.lblTenTaiKhoan.TabIndex = 3;
            this.lblTenTaiKhoan.Text = "Bạn chưa đăng nhập";
            this.lblTenTaiKhoan.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnDangXuat
            // 
            this.btnDangXuat.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnDangXuat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDangXuat.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDangXuat.ForeColor = System.Drawing.Color.Red;
            this.btnDangXuat.Image = global::QuanLyBanLapTop.Properties.Resources.DangXuat;
            this.btnDangXuat.Location = new System.Drawing.Point(13, 462);
            this.btnDangXuat.Name = "btnDangXuat";
            this.btnDangXuat.Size = new System.Drawing.Size(159, 45);
            this.btnDangXuat.TabIndex = 5;
            this.btnDangXuat.Text = "Đăng Xuất";
            this.btnDangXuat.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnDangXuat.UseVisualStyleBackColor = true;
            this.btnDangXuat.Click += new System.EventHandler(this.btnDangXuat_Click);
            // 
            // picHinh
            // 
            this.picHinh.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.picHinh.Image = global::QuanLyBanLapTop.Properties.Resources.UserBlock;
            this.picHinh.Location = new System.Drawing.Point(12, 293);
            this.picHinh.Name = "picHinh";
            this.picHinh.Size = new System.Drawing.Size(160, 110);
            this.picHinh.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picHinh.TabIndex = 2;
            this.picHinh.TabStop = false;
            // 
            // mnuNhapHang
            // 
            this.mnuNhapHang.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold);
            this.mnuNhapHang.Image = global::QuanLyBanLapTop.Properties.Resources.NhapHang;
            this.mnuNhapHang.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.mnuNhapHang.Name = "mnuNhapHang";
            this.mnuNhapHang.Padding = new System.Windows.Forms.Padding(4, 10, 4, 10);
            this.mnuNhapHang.Size = new System.Drawing.Size(175, 56);
            this.mnuNhapHang.Text = "NHẬP HÀNG";
            this.mnuNhapHang.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // mnuBanHang
            // 
            this.mnuBanHang.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold);
            this.mnuBanHang.Image = global::QuanLyBanLapTop.Properties.Resources.BanHang;
            this.mnuBanHang.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.mnuBanHang.Name = "mnuBanHang";
            this.mnuBanHang.Padding = new System.Windows.Forms.Padding(4, 10, 4, 10);
            this.mnuBanHang.Size = new System.Drawing.Size(175, 56);
            this.mnuBanHang.Text = "BÁN HÀNG";
            this.mnuBanHang.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.mnuBanHang.Click += new System.EventHandler(this.mnuBanHang_Click);
            // 
            // mnuHoaDon
            // 
            this.mnuHoaDon.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.hÓAĐƠNNHẬPToolStripMenuItem,
            this.hÓAĐƠNBÁNToolStripMenuItem});
            this.mnuHoaDon.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold);
            this.mnuHoaDon.Image = global::QuanLyBanLapTop.Properties.Resources.Management;
            this.mnuHoaDon.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.mnuHoaDon.Name = "mnuHoaDon";
            this.mnuHoaDon.Padding = new System.Windows.Forms.Padding(4, 10, 4, 10);
            this.mnuHoaDon.Size = new System.Drawing.Size(175, 56);
            this.mnuHoaDon.Text = "QUẢN LÝ";
            this.mnuHoaDon.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // hÓAĐƠNNHẬPToolStripMenuItem
            // 
            this.hÓAĐƠNNHẬPToolStripMenuItem.Image = global::QuanLyBanLapTop.Properties.Resources.HDNhap;
            this.hÓAĐƠNNHẬPToolStripMenuItem.Name = "hÓAĐƠNNHẬPToolStripMenuItem";
            this.hÓAĐƠNNHẬPToolStripMenuItem.Size = new System.Drawing.Size(260, 38);
            this.hÓAĐƠNNHẬPToolStripMenuItem.Text = "HÓA ĐƠN NHẬP";
            // 
            // hÓAĐƠNBÁNToolStripMenuItem
            // 
            this.hÓAĐƠNBÁNToolStripMenuItem.Image = global::QuanLyBanLapTop.Properties.Resources.HDBan;
            this.hÓAĐƠNBÁNToolStripMenuItem.Name = "hÓAĐƠNBÁNToolStripMenuItem";
            this.hÓAĐƠNBÁNToolStripMenuItem.Size = new System.Drawing.Size(260, 38);
            this.hÓAĐƠNBÁNToolStripMenuItem.Text = "HÓA ĐƠN BÁN";
            // 
            // frm_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(968, 519);
            this.Controls.Add(this.btnDangXuat);
            this.Controls.Add(this.lblTenTaiKhoan);
            this.Controls.Add(this.picHinh);
            this.Controls.Add(this.mnubarMain);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.mnubarMain;
            this.Name = "frm_Main";
            this.Text = "Phần mềm quản lý cửa hàng bán Laptop";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frm_Main_FormClosing);
            this.Load += new System.EventHandler(this.frm_Main_Load);
            this.mnubarMain.ResumeLayout(false);
            this.mnubarMain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picHinh)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.MenuStrip mnubarMain;
        private System.Windows.Forms.ToolStripMenuItem mnuNhapHang;
        private System.Windows.Forms.ToolStripMenuItem mnuBanHang;
        private System.Windows.Forms.ToolStripMenuItem mnuHoaDon;
        private System.Windows.Forms.PictureBox picHinh;
        private System.Windows.Forms.Label lblTenTaiKhoan;
        private System.Windows.Forms.Button btnDangXuat;
        private System.Windows.Forms.ToolStripMenuItem hÓAĐƠNNHẬPToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hÓAĐƠNBÁNToolStripMenuItem;
    }
}