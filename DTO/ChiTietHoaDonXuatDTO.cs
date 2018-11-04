using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace DTO
{
    public class ChiTietHoaDonXuatDTO
    {
        private string maHDX;
        private string maSeri;
        private int soLuongXuat;
        private double donGiaXuat;

        public string MaHDX { get => maHDX; set => maHDX = value; }
        public string MaSeri { get => maSeri; set => maSeri = value; }
        public int SoLuongXuat { get => soLuongXuat; set => soLuongXuat = value; }
        public double DonGiaXuat { get => donGiaXuat; set => donGiaXuat = value; }

        public ChiTietHoaDonXuatDTO()
        {

        }

        public ChiTietHoaDonXuatDTO(DataRow r)
        {
            MaHDX = r["MaHDX"].ToString();
            MaSeri = r["MaSeri"].ToString();
            SoLuongXuat = Convert.ToInt32(r["SoLuongXuat"]);
            DonGiaXuat = Convert.ToDouble(r["DonGiaXuat"]);
        }
    }
}
