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
    public partial class frm_TrangChu : Form
    {
        private static frm_TrangChu _Instance = null;
        public frm_TrangChu()
        {
            InitializeComponent();
        }
        public static frm_TrangChu Instance
        {
            get
            {
                if (_Instance == null)
                {
                    _Instance = new frm_TrangChu();
                }
                return _Instance;
            }
        }
        private void frm_TrangChu_Load(object sender, EventArgs e)
        {

        }

        private void frm_TrangChu_FormClosed(object sender, FormClosedEventArgs e)
        {
            _Instance = null;
        }
    }
}
