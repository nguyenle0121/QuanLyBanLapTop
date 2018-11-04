using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace DTO
{
    public class ChiTietHoaDonNhapDTO
    {
        private string maHDN;
        private string maSP;
        private int soLuongNhap;
        private double donGiaNhap;

        public string MaHDN { get => maHDN; set => maHDN = value; }
        public string MaSP { get => maSP; set => maSP = value; }
        public int SoLuongNhap { get => soLuongNhap; set => soLuongNhap = value; }
        public double DonGiaNhap { get => donGiaNhap; set => donGiaNhap = value; }

        public ChiTietHoaDonNhapDTO()
        {

        }

        public ChiTietHoaDonNhapDTO(DataRow r)
        {
            MaHDN = r["MaHDN"].ToString();
            MaSP = r["MaSP"].ToString();
            SoLuongNhap = Convert.ToInt32(r["SoLuongNhap"]);
            DonGiaNhap = Convert.ToDouble(r["DonGiaNhap"]);
        }
    }
}
