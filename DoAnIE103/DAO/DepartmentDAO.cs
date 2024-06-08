using DoAnIE103.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAnIE103.DAO
{
    internal class DepartmentDAO
    {
        private static DepartmentDAO instance;
        public static DepartmentDAO Instance
        {
            get { if (instance == null) instance = new DepartmentDAO(); return DepartmentDAO.instance; }
            private set => DepartmentDAO.instance = value;
        }

        private DepartmentDAO() { }

        public List<Department> getPositionList()
        {
            List<Department> list = new List<Department>();
            string query = "SELECT * FROM PHONGBAN";
            DataTable data = DataProvider.Instance.executeQuery(query);
            foreach (DataRow item in data.Rows)
            {
                Department dpm = new Department(item);
                list.Add(dpm);
            }
            return list;
        }
    }
}
