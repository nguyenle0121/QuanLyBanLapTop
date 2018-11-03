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
    public class HinhAnhSPDAO
    {
        public static DataTable LayDSHinhAnhSP()
        {
            string query = "select * from hinhanhsp";
            SqlParameter[] parameters = new SqlParameter[0];
            return DataProvider.ExecuteSelectQuery(query, parameters);

        }
    }
}
