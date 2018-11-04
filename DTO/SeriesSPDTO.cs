using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace DTO
{
    public class SeriesSPDTO
    {
        private string maSeri;
        private string maSP;
        private string ngayMua;
        private int baoHanh;
        private bool trangThai;

        public string MaSeri { get => maSeri; set => maSeri = value; }
        public string MaSP { get => maSP; set => maSP = value; }
        public string NgayMua { get => ngayMua; set => ngayMua = value; }
        public int BaoHanh { get => baoHanh; set => baoHanh = value; }
        public bool TrangThai { get => trangThai; set => trangThai = value; }

        public SeriesSPDTO()
        {

        }

        public SeriesSPDTO(DataRow r)
        {
            MaSeri = r["MaSeri"].ToString();
            MaSP = r["MaSP"].ToString();
            BaoHanh = Convert.ToInt32(r["BaoHanh"]);
            TrangThai = Convert.ToBoolean(r["TrangThai"]);
            if (r["NgayMua"] != null)
            {
                this.NgayMua = r["NgayMua"].ToString();
            }
            else
                this.NgayMua = "2018/1/1";
        }
    }
}
