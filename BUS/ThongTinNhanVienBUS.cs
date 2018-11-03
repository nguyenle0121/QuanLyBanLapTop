using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DTO;
using DAO;

namespace BUS
{
    public class ThongTinNhanVienBUS
    {
        public static DataTable LayDSNhanVien()
        {
            return ThongTinNhanVienDAO.LayDSNhanVien();
        }

        public static bool KTTT(string cmndnv, string matkhau)
        {
            return ThongTinNhanVienDAO.KTTT(cmndnv, matkhau);
        }

        public static DataRow LayThongTinNhanVien(string cmndnv)
        {
            return ThongTinNhanVienDAO.LayThongTinNhanVien(cmndnv);
        }
    }
}
