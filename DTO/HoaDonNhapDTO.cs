using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace DTO
{
    public class HoaDonNhapDTO
    {
        private string maHDN;
        private string maNhaCC;
        private string cMNDNV;
        private string ngayNhap;
        private string ghiChu;
        private bool trangThai;

        public string MaHDN { get => maHDN; set => maHDN = value; }
        public string MaNhaCC { get => maNhaCC; set => maNhaCC = value; }
        public string CMNDNV { get => cMNDNV; set => cMNDNV = value; }
        public string NgayNhap { get => ngayNhap; set => ngayNhap = value; }
        public string GhiChu { get => ghiChu; set => ghiChu = value; }
        public bool TrangThai { get => trangThai; set => trangThai = value; }

        public HoaDonNhapDTO()
        {

        }

        public HoaDonNhapDTO(DataRow r)
        {
            MaHDN = r["MaHDN"].ToString();
            MaNhaCC = r["MaNhaCC"].ToString();
            TrangThai = Convert.ToBoolean(r["TrangThai"]);
            CMNDNV = r["CMNDNV"].ToString();
            GhiChu = r["GhiChu"].ToString();
            if (r["NgayNhap"] != null)
            {
                this.NgayNhap = r["NgayNhap"].ToString();
            }
            else
                this.NgayNhap = "2018/1/1";

        }
    }
}
