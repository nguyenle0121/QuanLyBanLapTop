using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAO;
using System.Data;
namespace BUS
{
    public class SanPhamBUS
    {
        public static List<SanPhamDTO> LayDSSanPham()
        {
            DataTable dt = SanPhamDAO.LayDSSanPham();
            List<SanPhamDTO> lst = new List<SanPhamDTO>();
            foreach (DataRow r in dt.Rows)
            {
                SanPhamDTO sp = new SanPhamDTO(r);
                lst.Add(sp);
            }
            return lst;
        }
    }
}
