using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace DTO
{
    public class NhaCungCapDTO
    {
        private string maNhaCC;
        private string tenNhaCC;
        private string diaChi;
        private string sDT;
        private string email;

        public string MaNhaCC { get => maNhaCC; set => maNhaCC = value; }
        public string TenNhaCC { get => tenNhaCC; set => tenNhaCC = value; }
        public string DiaChi { get => diaChi; set => diaChi = value; }
        public string SDT { get => sDT; set => sDT = value; }
        public string Email { get => email; set => email = value; }

        public NhaCungCapDTO()
        {

        }

        public NhaCungCapDTO(DataRow r)
        {
            MaNhaCC = r["MaNhaCC"].ToString();
            TenNhaCC = r["TenNhaCC"].ToString();
            DiaChi = r["DiaChi"].ToString();
            SDT = r["SDT"].ToString();
            Email = r["Email"].ToString();
        }
    }
}
