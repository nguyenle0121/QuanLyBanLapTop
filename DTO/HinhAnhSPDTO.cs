using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace DTO
{
    public class HinhAnhSPDTO
    {
        string maHinhAnh;
        string maSP;
        string diaChiHinhAnh;

        public string MaHinhAnh { get => maHinhAnh; set => maHinhAnh = value; }
        public string MaSP { get => maSP; set => maSP = value; }
        public string DiaChiHinhAnh { get => diaChiHinhAnh; set => diaChiHinhAnh = value; }

        public HinhAnhSPDTO()
        {
      
        }

        public HinhAnhSPDTO(DataRow r)
        {
            MaHinhAnh = r["MaHinhAnh"].ToString();
            MaSP = r["MaSP"].ToString();
            DiaChiHinhAnh = r["DiaChiHinhAnh"].ToString();
        }
    }
}
