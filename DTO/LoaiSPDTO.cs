using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace DTO
{
    public class LoaiSPDTO
    {
        private string maLoaiSP;
        private string tenLoaiSP;
        private bool trangThai;

        public string MaLoaiSP { get => maLoaiSP; set => maLoaiSP = value; }
        public string TenLoaiSP { get => tenLoaiSP; set => tenLoaiSP = value; }
        public bool TrangThai { get => trangThai; set => trangThai = value; }

        public LoaiSPDTO()
        {

        }

        public LoaiSPDTO(DataRow r)
        {
            MaLoaiSP = r["MaLoaiSP"].ToString();
            TenLoaiSP = r["TenLoaiSP"].ToString();
            TrangThai = Convert.ToBoolean(r["TrangThai"]);

        }
    }
}
