using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace DTO
{
    public class KhachHangDTO
    {
        private string cMNDKH;
        private string tenKH;
        private string ngaySinhKH;
        private string sDTKH;
        private string diaChiKH;
        private bool gioiTinhKH;

        public string CMNDKH { get => cMNDKH; set => cMNDKH = value; }
        public string TenKH { get => tenKH; set => tenKH = value; }
        public string NgaySinhKH { get => ngaySinhKH; set => ngaySinhKH = value; }
        public string SDTKH { get => sDTKH; set => sDTKH = value; }
        public string DiaChiKH { get => diaChiKH; set => diaChiKH = value; }
        public bool GioiTinhKH { get => gioiTinhKH; set => gioiTinhKH = value; }

        public KhachHangDTO()
        {

        }

        public KhachHangDTO(DataRow r)
        {
            CMNDKH = r["CMNDKH"].ToString();
            TenKH = r["TenKH"].ToString();
            GioiTinhKH = Convert.ToBoolean(r["GioiTinhKH"]);
            SDTKH = r["SDTKH"].ToString();
            DiaChiKH = r["DiaChiKH"].ToString();
            if (r["NgaySinhKH"] != null)
            {
                this.NgaySinhKH = r["NgaySinhKH"].ToString();
            }
            else
                this.NgaySinhKH = "2018/1/1";

        }
    }
}
