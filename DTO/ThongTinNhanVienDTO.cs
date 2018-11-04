using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace DTO
{
    public class ThongTinNhanVienDTO
    {
        private string cMNDNV;
        private string tenNV;
        private string ngaySinh;
        private bool gioiTinh;
        private string sDT;
        private string diaChi;
        private string matKhau;
        private string maLoaiTK;
        private bool trangThai;

        public string CMNDNV { get => cMNDNV; set => cMNDNV = value; }
        public string TenNV { get => tenNV; set => tenNV = value; }
        public string NgaySinh { get => ngaySinh; set => ngaySinh = value; }
        public bool GioiTinh { get => gioiTinh; set => gioiTinh = value; }
        public string SDT { get => sDT; set => sDT = value; }
        public string DiaChi { get => diaChi; set => diaChi = value; }
        public string MatKhau { get => matKhau; set => matKhau = value; }
        public string MaLoaiTK { get => maLoaiTK; set => maLoaiTK = value; }
        public bool TrangThai { get => trangThai; set => trangThai = value; }

        public ThongTinNhanVienDTO()
        {

        }
        public ThongTinNhanVienDTO(DataRow r)
        {
            CMNDNV = r["CMNDNV"].ToString();
            TenNV = r["TenNV"].ToString();
            GioiTinh = Convert.ToBoolean(r["GioiTinh"]);
            SDT = r["SDT"].ToString();
            DiaChi = r["DiaChi"].ToString();
            MatKhau = r["MatKhau"].ToString();
            MaLoaiTK = r["MaLoaiTK"].ToString();
            TrangThai = Convert.ToBoolean(r["TrangThai"]);
            if (r["NgaySinh"] != null)
            {
                this.NgaySinh = r["NgaySinh"].ToString();
            }
            else
                this.NgaySinh = "2018/1/1";
        }
    }
}
