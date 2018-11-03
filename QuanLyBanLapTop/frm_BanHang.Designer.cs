namespace QuanLyBanLapTop
{
    partial class frm_BanHang
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lvwDanhSachSP = new System.Windows.Forms.ListView();
            this.dgvDanhSachChon = new System.Windows.Forms.DataGridView();
            this.MaSP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTenSP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSoLuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDonGia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnTaoHD = new System.Windows.Forms.Button();
            this.lblChon = new System.Windows.Forms.Label();
            this.lblDanhSachSanPham = new System.Windows.Forms.Label();
            this.txtTimKiem = new System.Windows.Forms.TextBox();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.tabDanhSach = new System.Windows.Forms.TabControl();
            this.tabXem = new System.Windows.Forms.TabPage();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.grbNSX = new System.Windows.Forms.GroupBox();
            this.chlNSX = new System.Windows.Forms.CheckedListBox();
            this.grbLoaiSP = new System.Windows.Forms.GroupBox();
            this.chlLoaiSP = new System.Windows.Forms.CheckedListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tabChon = new System.Windows.Forms.TabPage();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSachChon)).BeginInit();
            this.tabDanhSach.SuspendLayout();
            this.tabXem.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            this.grbNSX.SuspendLayout();
            this.grbLoaiSP.SuspendLayout();
            this.tabChon.SuspendLayout();
            this.SuspendLayout();
            // 
            // lvwDanhSachSP
            // 
            this.lvwDanhSachSP.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lvwDanhSachSP.Location = new System.Drawing.Point(185, 81);
            this.lvwDanhSachSP.Name = "lvwDanhSachSP";
            this.lvwDanhSachSP.Size = new System.Drawing.Size(917, 500);
            this.lvwDanhSachSP.TabIndex = 0;
            this.lvwDanhSachSP.UseCompatibleStateImageBehavior = false;
            this.lvwDanhSachSP.SelectedIndexChanged += new System.EventHandler(this.lvwDanhSachSP_SelectedIndexChanged);
            // 
            // dgvDanhSachChon
            // 
            this.dgvDanhSachChon.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvDanhSachChon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDanhSachChon.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaSP,
            this.colTenSP,
            this.colSoLuong,
            this.colDonGia});
            this.dgvDanhSachChon.Location = new System.Drawing.Point(6, 33);
            this.dgvDanhSachChon.Name = "dgvDanhSachChon";
            this.dgvDanhSachChon.RowHeadersVisible = false;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvDanhSachChon.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvDanhSachChon.Size = new System.Drawing.Size(1096, 482);
            this.dgvDanhSachChon.TabIndex = 1;
            // 
            // MaSP
            // 
            this.MaSP.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.MaSP.HeaderText = "Mã sản phẩm";
            this.MaSP.Name = "MaSP";
            this.MaSP.Width = 142;
            // 
            // colTenSP
            // 
            this.colTenSP.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colTenSP.HeaderText = "Tên sản phẩm";
            this.colTenSP.Name = "colTenSP";
            // 
            // colSoLuong
            // 
            this.colSoLuong.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.colSoLuong.HeaderText = "Số lượng";
            this.colSoLuong.Name = "colSoLuong";
            this.colSoLuong.Width = 106;
            // 
            // colDonGia
            // 
            this.colDonGia.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewCellStyle3.Format = "#, ##0";
            this.colDonGia.DefaultCellStyle = dataGridViewCellStyle3;
            this.colDonGia.HeaderText = "Đơn giá";
            this.colDonGia.Name = "colDonGia";
            this.colDonGia.Width = 97;
            // 
            // btnTaoHD
            // 
            this.btnTaoHD.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnTaoHD.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTaoHD.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTaoHD.Location = new System.Drawing.Point(665, 521);
            this.btnTaoHD.Name = "btnTaoHD";
            this.btnTaoHD.Size = new System.Drawing.Size(437, 60);
            this.btnTaoHD.TabIndex = 2;
            this.btnTaoHD.Text = "Lập Hóa Đơn";
            this.btnTaoHD.UseVisualStyleBackColor = true;
            this.btnTaoHD.Click += new System.EventHandler(this.btnTaoHD_Click);
            // 
            // lblChon
            // 
            this.lblChon.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblChon.AutoSize = true;
            this.lblChon.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChon.Location = new System.Drawing.Point(442, 5);
            this.lblChon.Name = "lblChon";
            this.lblChon.Size = new System.Drawing.Size(245, 25);
            this.lblChon.TabIndex = 3;
            this.lblChon.Text = "Danh sách sản phẩm chọn";
            // 
            // lblDanhSachSanPham
            // 
            this.lblDanhSachSanPham.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblDanhSachSanPham.AutoSize = true;
            this.lblDanhSachSanPham.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDanhSachSanPham.Location = new System.Drawing.Point(460, 14);
            this.lblDanhSachSanPham.Name = "lblDanhSachSanPham";
            this.lblDanhSachSanPham.Size = new System.Drawing.Size(197, 25);
            this.lblDanhSachSanPham.TabIndex = 4;
            this.lblDanhSachSanPham.Text = "Danh sách sản phẩm";
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTimKiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTimKiem.Location = new System.Drawing.Point(212, 42);
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Size = new System.Drawing.Size(728, 30);
            this.txtTimKiem.TabIndex = 6;
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnTimKiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTimKiem.Location = new System.Drawing.Point(946, 40);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(156, 32);
            this.btnTimKiem.TabIndex = 7;
            this.btnTimKiem.Text = "Tìm kiếm";
            this.btnTimKiem.UseVisualStyleBackColor = true;
            // 
            // tabDanhSach
            // 
            this.tabDanhSach.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabDanhSach.Controls.Add(this.tabXem);
            this.tabDanhSach.Controls.Add(this.tabChon);
            this.tabDanhSach.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabDanhSach.Location = new System.Drawing.Point(12, 13);
            this.tabDanhSach.Name = "tabDanhSach";
            this.tabDanhSach.SelectedIndex = 0;
            this.tabDanhSach.Size = new System.Drawing.Size(1116, 620);
            this.tabDanhSach.TabIndex = 8;
            // 
            // tabXem
            // 
            this.tabXem.Controls.Add(this.trackBar1);
            this.tabXem.Controls.Add(this.grbNSX);
            this.tabXem.Controls.Add(this.grbLoaiSP);
            this.tabXem.Controls.Add(this.label1);
            this.tabXem.Controls.Add(this.txtTimKiem);
            this.tabXem.Controls.Add(this.btnTimKiem);
            this.tabXem.Controls.Add(this.lblDanhSachSanPham);
            this.tabXem.Controls.Add(this.lvwDanhSachSP);
            this.tabXem.Location = new System.Drawing.Point(4, 29);
            this.tabXem.Name = "tabXem";
            this.tabXem.Padding = new System.Windows.Forms.Padding(3);
            this.tabXem.Size = new System.Drawing.Size(1108, 587);
            this.tabXem.TabIndex = 0;
            this.tabXem.Text = "Xem danh sách sản phẩm";
            this.tabXem.UseVisualStyleBackColor = true;
            // 
            // trackBar1
            // 
            this.trackBar1.LargeChange = 50;
            this.trackBar1.Location = new System.Drawing.Point(42, 453);
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(104, 45);
            this.trackBar1.TabIndex = 11;
            this.trackBar1.UseWaitCursor = true;
            // 
            // grbNSX
            // 
            this.grbNSX.Controls.Add(this.chlNSX);
            this.grbNSX.Location = new System.Drawing.Point(7, 219);
            this.grbNSX.Name = "grbNSX";
            this.grbNSX.Size = new System.Drawing.Size(172, 195);
            this.grbNSX.TabIndex = 10;
            this.grbNSX.TabStop = false;
            this.grbNSX.Text = "Nhà sản xuất";
            // 
            // chlNSX
            // 
            this.chlNSX.FormattingEnabled = true;
            this.chlNSX.Location = new System.Drawing.Point(13, 31);
            this.chlNSX.Name = "chlNSX";
            this.chlNSX.Size = new System.Drawing.Size(159, 158);
            this.chlNSX.TabIndex = 0;
            // 
            // grbLoaiSP
            // 
            this.grbLoaiSP.Controls.Add(this.chlLoaiSP);
            this.grbLoaiSP.Location = new System.Drawing.Point(7, 81);
            this.grbLoaiSP.Name = "grbLoaiSP";
            this.grbLoaiSP.Size = new System.Drawing.Size(172, 131);
            this.grbLoaiSP.TabIndex = 9;
            this.grbLoaiSP.TabStop = false;
            this.grbLoaiSP.Text = "Loại sản phẩm";
            // 
            // chlLoaiSP
            // 
            this.chlLoaiSP.FormattingEnabled = true;
            this.chlLoaiSP.Location = new System.Drawing.Point(7, 27);
            this.chlLoaiSP.Name = "chlLoaiSP";
            this.chlLoaiSP.Size = new System.Drawing.Size(159, 92);
            this.chlLoaiSP.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(203, 22);
            this.label1.TabIndex = 8;
            this.label1.Text = "Nhập sản phẩm cần tìm:";
            // 
            // tabChon
            // 
            this.tabChon.Controls.Add(this.lblChon);
            this.tabChon.Controls.Add(this.btnTaoHD);
            this.tabChon.Controls.Add(this.dgvDanhSachChon);
            this.tabChon.Location = new System.Drawing.Point(4, 29);
            this.tabChon.Name = "tabChon";
            this.tabChon.Padding = new System.Windows.Forms.Padding(3);
            this.tabChon.Size = new System.Drawing.Size(1108, 587);
            this.tabChon.TabIndex = 1;
            this.tabChon.Text = "Danh sách sản phẩm đã chọn";
            this.tabChon.UseVisualStyleBackColor = true;
            // 
            // frm_BanHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1140, 645);
            this.ControlBox = false;
            this.Controls.Add(this.tabDanhSach);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_BanHang";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "Bán hàng";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frm_BanHang_FormClosed);
            this.Load += new System.EventHandler(this.frm_BanHang_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSachChon)).EndInit();
            this.tabDanhSach.ResumeLayout(false);
            this.tabXem.ResumeLayout(false);
            this.tabXem.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            this.grbNSX.ResumeLayout(false);
            this.grbLoaiSP.ResumeLayout(false);
            this.tabChon.ResumeLayout(false);
            this.tabChon.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView lvwDanhSachSP;
        private System.Windows.Forms.DataGridView dgvDanhSachChon;
        private System.Windows.Forms.Button btnTaoHD;
        private System.Windows.Forms.Label lblChon;
        private System.Windows.Forms.Label lblDanhSachSanPham;
        private System.Windows.Forms.TextBox txtTimKiem;
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.TabControl tabDanhSach;
        private System.Windows.Forms.TabPage tabXem;
        private System.Windows.Forms.TabPage tabChon;
        private System.Windows.Forms.GroupBox grbLoaiSP;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox grbNSX;
        private System.Windows.Forms.CheckedListBox chlNSX;
        private System.Windows.Forms.CheckedListBox chlLoaiSP;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaSP;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTenSP;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSoLuong;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDonGia;
    }
}