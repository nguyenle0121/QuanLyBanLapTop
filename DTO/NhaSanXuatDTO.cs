using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace DTO
{
    public class NhaSanXuatDTO
    {
        private string maNSX;
        private string tenNSX;
        private string quocGiaSX;

        public string MaNSX { get => maNSX; set => maNSX = value; }
        public string TenNSX { get => tenNSX; set => tenNSX = value; }
        public string QuocGiaSX { get => quocGiaSX; set => quocGiaSX = value; }

        public NhaSanXuatDTO()
        {

        }

        public NhaSanXuatDTO(DataRow r)
        {
            MaNSX = r["MaNSX"].ToString();
            TenNSX = r["TenNSX"].ToString();
            QuocGiaSX = r["QuocGiaSX"].ToString();
        }
    }
}
