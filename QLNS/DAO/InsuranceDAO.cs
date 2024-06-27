using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLNS.DAO
{
    internal class InsuranceDAO
    {
        private static InsuranceDAO instance;
        public static InsuranceDAO Instance
        {
            get { if (instance == null) instance = new InsuranceDAO(); return InsuranceDAO.instance; }
            private set => InsuranceDAO.instance = value;
        }

        private InsuranceDAO() { }

        public DataTable getInsuranceList()
        {
            DataTable dt = DataProvider.Instance.executeQuery("SELECT * FROM BAOHIEM");
            return dt;
        }
        public bool InsertInsurance(int mabh, string sobh, string ngaycap, string noicap, string noikhambenh, int manv)
        {
            string query = string.Format("INSERT INTO BaoHiem (MaBH, SoBH, NgayCap, NoiCap, NoiKhamBenh, MaNV) VALUES({0}, '{1}', '{2}', N'{3}', N'{4}', {5})", mabh, sobh, ngaycap, noicap, noikhambenh, manv);
            return DataProvider.Instance.executeNonQuery(query) > 0;
        }
        public bool UpdateInsurance(int mabh, string sobh, string ngaycap, string noicap, string noikhambenh, int manv)
        {
            string query = string.Format("UPDATE BAOHIEM SET SOBH = '{1}', NGAYCAP = '{2}', NOICAP = N'{3}', NOIKHAMBENH = N'{4}', MANV = {5} WHERE MABH = N'{0}'",
                mabh, sobh, ngaycap, noicap, noikhambenh, manv);
            int result = DataProvider.Instance.executeNonQuery(query);
            return result > 0;
        }


        public bool DeleteInsurance(int mabh)
        {
            // Xóa bao hiem
            string query = string.Format("DELETE BAOHIEM WHERE SOBH = {0}", mabh);
            return DataProvider.Instance.executeNonQuery(query) > 0;
           
        }
    }
}
