using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//using System.Data;
using BUS;

namespace QuanLyBanLapTop
{
    public partial class frm_DangNhap : Form
    {
        private static frm_DangNhap _Instance = null;
        public frm_DangNhap()
        {
            InitializeComponent();
        }
        public static frm_DangNhap Instance
        {
            get
            {
                if (_Instance == null)
                {
                    _Instance = new frm_DangNhap();
                }
                return _Instance;
            }
        }
        private void frm_DangNhap_Load(object sender, EventArgs e)
        {
            cboNhanVien.DataSource = ThongTinNhanVienBUS.LayDSNhanVien();
            DataTable dt = ThongTinNhanVienBUS.LayDSNhanVien();
            cboNhanVien.DisplayMember = "TenNV";
            cboNhanVien.ValueMember = "CMNDNV";
            btnDangNhap.Click += BtnDangNhap_Click;
        }
        private void BtnDangNhap_Click(object sender, EventArgs e)
        {
            //throw new NotImplementedException();
            if (ThongTinNhanVienBUS.KTTT(cboNhanVien.SelectedValue.ToString(),txtMatKhau.Text))
            {
                ((frm_Main)this.ParentForm).XuLyDangNhap(cboNhanVien.SelectedValue.ToString());
                this.Close();
            }
            else
            {
                MessageBox.Show("Thông báo!!!", "Sai mật khẩu !!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void frm_DangNhap_FormClosed(object sender, FormClosedEventArgs e)
        {
            _Instance = null;
        }

        private void txtMatKhau_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar==(char)Keys.Enter)
            {
                btnDangNhap.PerformClick();
            }
        }
    }
}
