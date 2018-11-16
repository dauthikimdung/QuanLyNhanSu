using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyNhanSu.DAO
{
    public class HopDongLaoDongDAO
    {
        public static DataTable LoadHopDongLaoDong()
        {
            string query = "SELECT HOTEN, NGAYKY, HOPDONGLAODONGID, LOAIHOPDONG, LUONGID, H.NHANVIENID FROM HOPDONGLAODONG H, NHANVIEN N WHERE N.NHANVIENID = H.NHANVIENID";

            DataTable data = SqlServerHelper.ExecuteQuery(query);

            return data;
        }

        public static int InserthopDonglaoDong(int idnv, string loaihd, int idluong, DateTime ngayky)
        {
            string query = "INSERTHOPDONGLAODONG @IDNV , @LOAIHOPDONG , @LOAILUONG , @NGAYKY ";

            return SqlServerHelper.ExecuteNonQuery(query, new object[] { idnv, loaihd, idluong, ngayky });
        }
        public static int UpdateHopDongLaoDong(int idhd, int idnv, string loaihd, int idluong, DateTime ngayky)
        {
            string query = "UPDATEHOPDONGLAODONG @IDHOPDONG , @IDNV , @LOAIHOPDONG , @LOAILUONG , @NGAYKY ";

            return SqlServerHelper.ExecuteNonQuery(query, new object[] { idhd, idnv, loaihd, idluong, ngayky });

        }
        public static int DeleteHopDongLaoDong(int idhd)
        {
            string query = "DELETEHOPDONGLAODONG @IDHOPDONG ";
            try
            {
                return SqlServerHelper.ExecuteNonQuery(query, new object[]{idhd});
            }
            catch
            {
                return 0;
            }
        }
    }
}
