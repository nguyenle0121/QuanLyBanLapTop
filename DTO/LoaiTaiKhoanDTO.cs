using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace DTO
{
    public class LoaiTaiKhoanDTO
    {
        private string maLoaiTK;
        private string tenLoaiTK;

        public string MaLoaiTK { get => maLoaiTK; set => maLoaiTK = value; }
        public string TenLoaiTK { get => tenLoaiTK; set => tenLoaiTK = value; }

        public LoaiTaiKhoanDTO()
        {

        }

        public LoaiTaiKhoanDTO(DataRow r)
        {
            MaLoaiTK = r["MaLoaiTK"].ToString();
            TenLoaiTK = r["TenLoaiTK"].ToString();

        }
    }
}
