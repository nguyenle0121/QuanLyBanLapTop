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
using DTO;


namespace QuanLyBanLapTop
{
    public partial class frm_BanHang : Form
    {
        public frm_BanHang()
        {
            InitializeComponent();
        }
        private static frm_BanHang _Instance;
        public static frm_BanHang Instance
        {
            get
            {
                if (_Instance == null)
                    _Instance = new frm_BanHang();
                return _Instance;
            }
        }
        List<SanPhamDTO> lstsp;
        List<HinhAnhSPDTO> lstha;
        ImageList AnhLon;
        private void frm_BanHang_Load(object sender, EventArgs e)
        {
            AnhLon = new ImageList();
            lvwDanhSachSP.LargeImageList = AnhLon;
            AnhLon.ColorDepth = ColorDepth.Depth32Bit;
            AnhLon.ImageSize = new Size(200, 200);

            lvwDanhSachSP.View = View.LargeIcon;
            lstha = HinhAnhSPBUS.LayDSHinhAnhSP();
            lstsp = SanPhamBUS.LayDSSanPham();


            LoadSP(lstsp, lstha);
        }
        private void LoadSP(List<SanPhamDTO> lstsp, List<HinhAnhSPDTO> lstha)
        {
            lvwDanhSachSP.Items.Clear();
            lvwDanhSachSP.LargeImageList.Images.Clear();
            foreach (var item in lstha)
            {
                if (item.MaHinhAnh == item.MaSP + "_1")
                    AnhLon.Images.Add(item.MaHinhAnh, Image.FromFile(item.DiaChiHinhAnh));
            }
            foreach (var item in lstsp)
            {
                ThemItem(item);
            }
        }

        private void ThemItem(SanPhamDTO item)
        {
            ListViewItem lvi = new ListViewItem(item.TenSP);
            lvi.Text = item.TenSP + " \n " + item.GiaTien.ToString("#,##0 VNĐ");
            lvi.SubItems.Add(item.MaSP);
            lvi.ImageKey = item.MaSP + "_1";
            //lvi.ToolTipText = item.GiaTien.ToString("#,##0 VNĐ");
            //lvi.SubItems.Add(item.SoLuong.ToString());
            //lvi.SubItems.Add(item.GiaTien.ToString());
            //lvi.SubItems.Add(item.CPU);
            //lvi.SubItems.Add(item.RAM);
            //lvi.SubItems.Add(item.OCung);
            //lvi.SubItems.Add(item.CDDVD);
            //lvi.SubItems.Add(item.VGA);
            //lvi.SubItems.Add(item.ManHinh);
            //lvi.SubItems.Add(item.KetNoi);
            //lvi.SubItems.Add(item.BanPhim);
            //lvi.SubItems.Add(item.TanNhiet);
            //lvi.SubItems.Add(item.TichHop);
            //lvi.SubItems.Add(item.TrongLuong);
            //lvi.SubItems.Add(item.Pin);
            //lvi.SubItems.Add(item.MaLoaiSP);
            //lvi.SubItems.Add(item.MaNSX);
            //lvi.SubItems.Add(item.MaNCC);
            //lvi.SubItems.Add(item.NgayRaMat.ToString());
            //lvi.SubItems.Add(item.TrangThai.ToString());
            lvwDanhSachSP.Items.Add(lvi);
        }
        private void frm_BanHang_FormClosed(object sender, FormClosedEventArgs e)
        {
            _Instance = null;
        }

        private void lvwDanhSachSP_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnTaoHD_Click(object sender, EventArgs e)
        {
            frm_HoaDonXuat frmHoaDonXuat = frm_HoaDonXuat.Instance;
            frmHoaDonXuat.Dock = DockStyle.Fill;
            frmHoaDonXuat.ShowDialog();
        }
    }
}
