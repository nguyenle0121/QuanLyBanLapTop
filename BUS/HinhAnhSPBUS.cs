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
    public class HinhAnhSPBUS
    {
        public static List<HinhAnhSPDTO> LayDSHinhAnhSP()
        {
            DataTable dt = HinhAnhSPDAO.LayDSHinhAnhSP();
            List<HinhAnhSPDTO> lst = new List<HinhAnhSPDTO>();
            foreach (DataRow r in dt.Rows)
            {
                HinhAnhSPDTO hasp = new HinhAnhSPDTO(r);
                lst.Add(hasp);
            }
            return lst;
        }
    }
}
