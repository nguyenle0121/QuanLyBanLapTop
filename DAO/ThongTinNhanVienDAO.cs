using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using DTO;

namespace DAO
{
    public class ThongTinNhanVienDAO
    {
        public static DataTable LayDSNhanVien()
        {
            string query = "select cmndnv,tennv from thongtinnhanvien";
            SqlParameter[] parameter = new SqlParameter[0];
            return DataProvider.ExecuteSelectQuery(query, parameter);
        }

        public static bool KTTT(string cmndnv, string matkhau)
        {
            string query = "select count(*) from thongtinnhanvien where cmndnv=@cmndnv and matkhau=@matkhau";
            SqlParameter[] parameter = new SqlParameter[2];
            parameter[0] = new SqlParameter("@cmndnv", cmndnv);
            parameter[1] = new SqlParameter("@matkhau", matkhau);
            return Convert.ToInt32(DataProvider.ExecuteSelectQuery(query, parameter).Rows[0][0])==1;
        }

        public static DataRow LayThongTinNhanVien(string cmndnv)
        {
            string query = "select * from thongtinnhanvien where  cmndnv=@cmndnv";
            SqlParameter[] parameter = new SqlParameter[1];
            parameter[0] = new SqlParameter("@cmndnv", cmndnv);
            return DataProvider.ExecuteSelectQuery(query, parameter).Rows[0];
        }
    }
}
