using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS;
//using System.Data;

namespace QuanLyBanLapTop
{
    public partial class frm_Main : Form
    {
        public frm_Main()
        {
            InitializeComponent();
        }

        private void frm_Main_Load(object sender, EventArgs e)
        {
            // Trạng thái chưa đăng nhập
            TrangThaiChuaDangNhap();

            // Mở form Đăng nhập
            MoFormDangNhap();
        }
        private void TrangThaiChuaDangNhap()
        {
            mnubarMain.Enabled = false;
            btnDangXuat.Enabled = false;
            //picHinhAnh.Image = GUI.Properties.Resources.UserBlock;
            lblTenTaiKhoan.Text = @"Bạn chưa đăng nhập";
        }

        public void XuLyDangNhap(string cmndnv)
        {
            mnubarMain.Enabled = true;
            btnDangXuat.Enabled = true;
            //picHinhAnh.Image = GUI.Properties.Resources.UserBlock;
            DataRow r = ThongTinNhanVienBUS.LayThongTinNhanVien(cmndnv);
            lblTenTaiKhoan.Text = r["TenNV"].ToString();
            //frm_TrangChu frmTrangChu = frm_TrangChu.Instance;
            //frmTrangChu.MdiParent = this;
            //frmTrangChu.Dock = DockStyle.Fill;
            //frmTrangChu.Show();
        }
        private void MoFormDangNhap()
        {
            frm_DangNhap m_frmDangNhap = frm_DangNhap.Instance;
            m_frmDangNhap.MdiParent = this;
            m_frmDangNhap.Dock = DockStyle.Fill;
            m_frmDangNhap.Show();
        }

        private void frm_Main_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn thoát?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                e.Cancel = true;
        }

        private void btnDangXuat_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn đăng xuất?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                TrangThaiChuaDangNhap();
                MoFormDangNhap();
            }
        }

        private void mnuBanHang_Click(object sender, EventArgs e)
        {
            frm_BanHang frmBanHang = frm_BanHang.Instance;
            frmBanHang.MdiParent = this;
            frmBanHang.Dock = DockStyle.Fill;
            frmBanHang.Show();
        }
    }
}
