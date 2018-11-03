using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
namespace DTO
{
    public class SanPhamDTO
    {
        private string maSP;
        private string tenSP;
        private int soLuong;
        private double giaTien;
        private string cPU;
        private string rAM;
        private string oCung;
        private string cDDVD;
        private string vGA;
        private string manHinh;
        private string ketNoi;
        private string banPhim;
        private string tanNhiet;
        private string tichHop;
        private string trongLuong;
        private string pin;
        private string maLoaiSP;
        private string maNSX;
        private string maNCC;
        private string ngayRaMat;
        private bool trangThai;

        public string MaSP { get => maSP; set => maSP = value; }
        public string TenSP { get => tenSP; set => tenSP = value; }
        public int SoLuong { get => soLuong; set => soLuong = value; }
        public double GiaTien { get => giaTien; set => giaTien = value; }
        public string CPU { get => cPU; set => cPU = value; }
        public string RAM { get => rAM; set => rAM = value; }
        public string CDDVD { get => cDDVD; set => cDDVD = value; }
        public string VGA { get => vGA; set => vGA = value; }
        public string ManHinh { get => manHinh; set => manHinh = value; }
        public string KetNoi { get => ketNoi; set => ketNoi = value; }
        public string BanPhim { get => banPhim; set => banPhim = value; }
        public string TanNhiet { get => tanNhiet; set => tanNhiet = value; }
        public string TichHop { get => tichHop; set => tichHop = value; }
        public string TrongLuong { get => trongLuong; set => trongLuong = value; }
        public string Pin { get => pin; set => pin = value; }
        public string MaLoaiSP { get => maLoaiSP; set => maLoaiSP = value; }
        public string MaNSX { get => maNSX; set => maNSX = value; }
        public string MaNCC { get => maNCC; set => maNCC = value; }
        public string NgayRaMat { get => ngayRaMat; set => ngayRaMat = value; }
        public bool TrangThai { get => trangThai; set => trangThai = value; }
        public string OCung { get => oCung; set => oCung = value; }
        public SanPhamDTO()
        {
            
        }
        public SanPhamDTO(DataRow r)
        {
            this.MaSP = r["MaSP"].ToString();
            this.TenSP = r["TenSP"].ToString();
            this.SoLuong = Convert.ToInt32(r["SoLuong"]);
            this.GiaTien = Convert.ToDouble(r["GiaTien"]);
            this.CPU = r["CPU"].ToString();
            this.RAM = r["RAM"].ToString();
            this.OCung = r["OCung"].ToString();
            this.CDDVD = r["CDDVD"].ToString();
            this.VGA = r["VGA"].ToString();
            this.ManHinh = r["ManHinh"].ToString();
            this.KetNoi = r["KetNoi"].ToString();
            this.BanPhim = r["BanPhim"].ToString();
            this.TanNhiet = r["TanNhiet"].ToString();
            this.TichHop = r["TichHop"].ToString();
            this.TrongLuong = r["TrongLuong"].ToString();
            this.Pin = r["Pin"].ToString();
            this.TrangThai = Convert.ToBoolean(r["TrangThai"]);
            this.MaLoaiSP = r["MaLoaiSP"].ToString();
            this.MaNSX = r["MaNSX"].ToString();
            this.MaNCC = r["MaNCC"].ToString();
            if (r["NgayRaMat"] != null)
            {
                this.NgayRaMat = r["NgayRaMat"].ToString();
            }
            else
                this.NgayRaMat = "2018/1/1";
        }
    }
}
