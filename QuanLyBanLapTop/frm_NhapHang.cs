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
    public partial class frm_NhapHang : Form
    {
        public frm_NhapHang()
        {
            InitializeComponent();
        }
        private static frm_NhapHang _Instance;
        public static frm_NhapHang Instance
        {
            get
            {
                if (_Instance == null)
                    _Instance = new frm_NhapHang();
                return _Instance;
            }
        }
        private void frm_NhapHang_Load(object sender, EventArgs e)
        {

        }

        private void frm_NhapHang_FormClosed(object sender, FormClosedEventArgs e)
        {
            _Instance = null;
        }
    }
}
