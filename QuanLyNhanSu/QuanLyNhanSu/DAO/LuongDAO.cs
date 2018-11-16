using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyNhanSu.DAO
{
    public class LuongDAO
    {
        public static DataTable LoadcboLuong()
        {
            string query = "SELECT LUONGID FROM LUONG";

            DataTable data = SqlServerHelper.ExecuteQuery(query);

            return data;
        }
    }
}
