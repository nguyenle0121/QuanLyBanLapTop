using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class ThongTinNhanVienDTO
    {
        private string cMNDNV;
        private string tenNV;
        private DateTime ngaySinh;
        private bool gioiTinh;
        private string sDT;
        private string diaChi;
        private string matKhau;
        private string maLoaiTK;
        private bool trangThai;

        public string CMNDNV { get => cMNDNV; set => cMNDNV = value; }
        public string TenNV { get => tenNV; set => tenNV = value; }
        public DateTime NgaySinh { get => ngaySinh; set => ngaySinh = value; }
        public bool GioiTinh { get => gioiTinh; set => gioiTinh = value; }
        public string SDT { get => sDT; set => sDT = value; }
        public string DiaChi { get => diaChi; set => diaChi = value; }
        public string MatKhau { get => matKhau; set => matKhau = value; }
        public string MaLoaiTK { get => maLoaiTK; set => maLoaiTK = value; }
        public bool TrangThai { get => trangThai; set => trangThai = value; }
    }
}
