using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAnIE103.DAO
{
    internal class WageDAO
    {
        private static WageDAO instance;
        public static WageDAO Instance
        {
            get { if (instance == null) instance = new WageDAO(); return WageDAO.instance; }
            private set => WageDAO.instance = value;
        }

        private WageDAO() { }

        public DataTable getLuongByMaCV(int macv)
        {
            string query = string.Format("SELECT * FROM LUONG WHERE MACV = {0}", macv);
            DataTable dt = DataProvider.Instance.executeQuery(query);
            if (dt.Rows.Count > 0)
                return dt;
            return null;
        }
    }
}
