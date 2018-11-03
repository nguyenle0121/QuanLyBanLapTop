using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using System.Data;
using System.Data.SqlClient;
namespace DAO
{
    public class SanPhamDAO
    {
        public static DataTable LayDSSanPham()
        {
            string query = "select * from sanpham";
            SqlParameter[] parameters = new SqlParameter[0];
            return DataProvider.ExecuteSelectQuery(query, parameters);

        }
    }
}
