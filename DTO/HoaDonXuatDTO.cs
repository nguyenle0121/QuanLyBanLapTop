using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace DTO
{
    public class HoaDonXuatDTO
    {
        private string maHDX;
        private string cMNDKH;
        private string cMNDNV;
        private string ngayXuat;
        private string ghiChu;
        private bool trangThai;

        public string MaHDX { get => maHDX; set => maHDX = value; }
        public string CMNDKH { get => cMNDKH; set => cMNDKH = value; }
        public string CMNDNV { get => cMNDNV; set => cMNDNV = value; }
        public string NgayXuat { get => ngayXuat; set => ngayXuat = value; }
        public string GhiChu { get => ghiChu; set => ghiChu = value; }
        public bool TrangThai { get => trangThai; set => trangThai = value; }

        public HoaDonXuatDTO()
        {

        }

        public HoaDonXuatDTO(DataRow r)
        {
            MaHDX = r["MaHDX"].ToString();
            CMNDKH = r["CMNDKH"].ToString();
            TrangThai = Convert.ToBoolean(r["TrangThai"]);
            CMNDNV = r["CMNDNV"].ToString();
            GhiChu = r["GhiChu"].ToString();
            if (r["NgayXuat"] != null)
            {
                this.NgayXuat = r["NgayXuat"].ToString();
            }
            else
                this.NgayXuat = "2018/1/1";

        }
    }
}
