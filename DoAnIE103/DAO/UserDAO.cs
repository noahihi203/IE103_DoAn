using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAnIE103.DAO
{
    internal class UserDAO
    {

        private static UserDAO instance;
        public static UserDAO Instance
        {
            get { if (instance == null) instance = new UserDAO(); return UserDAO.instance; }
            private set => UserDAO.instance = value;
        }

        private UserDAO() { }

        public int checkRole(string userName)
        {
            string query = string.Format("SELECT * FROM TAIKHOAN WHERE TENDANGNHAP = N'{0}'", userName);
           
            DataTable dt = DataProvider.Instance.executeQuery(query);

            if (dt.Rows.Count > 0)
            {
                return (int)dt.Rows[0]["MACV"];
            }
            else
            {
                return 0;
            }
        }
        public bool checkUserName(string userName)
        {
            string query = string.Format("SELECT * FROM TAIKHOAN WHERE TENDANGNHAP = N'{0}'" , userName);

            DataTable result = DataProvider.Instance.executeQuery(query);

            return result.Rows.Count > 0;
        }
        public string GetStoredHashPassword(string username)
        {
            string query = string.Format("SELECT MATKHAU FROM TAIKHOAN WHERE TENDANGNHAP = N'{0}'", username);
            DataTable dt = DataProvider.Instance.executeQuery(query);

            if (dt.Rows.Count > 0)
            {
                return dt.Rows[0]["MATKHAU"].ToString();
            }

            return null; // Trường hợp không tìm thấy tên đăng nhập
        }

        public bool InsertUser(string tendangnhap, string matkhau, int macv)
        {
            string query = string.Format("INSERT dbo.TAIKHOAN ( TENDANGNHAP, MATKHAU, MACV ) VALUES ( N'{0}', N'{1}', {2} )", tendangnhap, matkhau, macv);
            int result = DataProvider.Instance.executeNonQuery(query);
            return result > 0;
        }
        public bool UpdateUser(string tendangnhap, string matkhau, int macv)
        {
            string query = string.Format("UPDATE dbo.TAIKHOAN SET MATKHAU = N'{1}', MACV = {2} WHERE TENDANGNHAP = N'{0}'", tendangnhap, matkhau, macv);
            int result = DataProvider.Instance.executeNonQuery(query);
            return result > 0;
        }

        public bool DeleteUser(string tendangnhap)
        {
            string query = string.Format("DELETE TAIKHOAN WHERE TENDANGNHAP = N'{0}'", tendangnhap);
            int result = DataProvider.Instance.executeNonQuery(query);
            return result > 0;
        }
    }
}
