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

        public string getTenPBByMaPB(int mapb)
        {
            string query = string.Format("SELECT TENPB FROM PHONGBAN WHERE MAPB = {0}", mapb);
            DataTable dt = DataProvider.Instance.executeQuery(query);
            if (dt.Rows.Count == 0)
                return null;
            else
            {
                string tenpb = dt.Rows[0]["TENPB"].ToString();
                return tenpb;
            }
        }
        /*public Position getDepartment(int mapb)
        {
            Department department = null;

            string query = string.Format("SELECT * FROM PHONGBAN WHERE MAPB = {0}", mapb);
            DataTable data = DataProvider.Instance.executeQuery(query);

            foreach (DataRow item in data.Rows)
            {
                department = new Department(item);
                return department;
            }


            return department;
        }*/

        public List<Department> GetDepartmentsList()
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

        public bool insertDepartment(int mapb, string tenpb)
        {
            string query = string.Format("INSERT INTO PHONGBAN(MAPB, TENPB) VALUES({0}, N'{1}')", mapb, tenpb);
            int result = DataProvider.Instance.executeNonQuery(query);
            return result > 0;
        }


        public bool updateDepartment(int mapb, string tenpb)
        {
            //string tencv = getTenCVByMaCV(macv);
            string query = string.Format("UPDATE PHONGBAN SET TENPB = N'{0}' WHERE MAPB = {1}", mapb, tenpb);
            int result = DataProvider.Instance.executeNonQuery(query);
            return result > 0;
        }

        public bool deleteDepartment(int mapb)
        {
            string query = string.Format("DELETE PHONGBAN WHERE MAPB = {0}", mapb);
            int result = DataProvider.Instance.executeNonQuery(query);
            return result > 0;
        }
    }
}
