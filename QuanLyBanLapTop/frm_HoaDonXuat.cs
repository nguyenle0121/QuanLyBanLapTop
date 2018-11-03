using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyBanLapTop
{
    public partial class frm_HoaDonXuat : Form
    {
        public frm_HoaDonXuat()
        {
            InitializeComponent();
        }
        private static frm_HoaDonXuat _Instance;
        public static frm_HoaDonXuat Instance
        {
            get
            {
                if (_Instance == null)
                    _Instance = new frm_HoaDonXuat();
                return _Instance;
            }
        }
        private void HoaDonXuat_Load(object sender, EventArgs e)
        {

        }

        private void btnLapHD_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Thông báo!!!", "Kiểm tra chính xác thông tin điền trước khi lưu và in", MessageBoxButtons.OK, MessageBoxIcon.Information);
            if (MessageBox.Show("Thông báo!!!","Bạn có muốn lưu và in hóa đơn?",MessageBoxButtons.YesNo,MessageBoxIcon.Question)== DialogResult.Yes)
            {

            }
        }

        private void frm_HoaDonXuat_FormClosed(object sender, FormClosedEventArgs e)
        {
            _Instance = null;
        }
    }
}
