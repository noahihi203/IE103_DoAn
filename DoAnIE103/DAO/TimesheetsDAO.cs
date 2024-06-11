using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAnIE103.DAO
{
    internal class TimesheetsDAO
    {
        private static TimesheetsDAO instance;
        public static TimesheetsDAO Instance
        {
            get { if (instance == null) instance = new TimesheetsDAO(); return TimesheetsDAO.instance; }
            private set => TimesheetsDAO.instance = value;
        }

        private TimesheetsDAO() { }
        public bool insertBangCong(int mabc, int manv, int thang)
        {
            string query = string.Format("INSERT INTO BangCong (MaBC, SoNgayLam, SoNgayNghi, MaNV, THANG) VALUES ({0}, {1}, {2}, {3}, {4}),", mabc, 0, 0, manv, thang);
            int result = DataProvider.Instance.executeNonQuery(query);
            if (result > 0)
                return true;
            return false;
        }
        public bool updateBangCong(double day,int mabc, int manv, int thang)
        {
            string query = string.Format("UPDATE BANGCONG SET SONGAYLAM += {0}, SONGAYNGHI -= {0} WHERE MANV = {1} AND MABC = {2} AND BANGCONG.THANG = {3}", day, manv, mabc, thang);
            int result = DataProvider.Instance.executeNonQuery(query);
            if (result > 0) 
                return true;
            return false;
        }
    }
}
