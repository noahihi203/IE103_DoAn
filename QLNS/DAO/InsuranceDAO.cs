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
    }
}
