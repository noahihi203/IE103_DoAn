using DoAnIE103.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAnIE103.DAO
{
    internal class PositionDAO
    {
        private static PositionDAO instance;
        public static PositionDAO Instance
        {
            get { if (instance == null) instance = new PositionDAO(); return PositionDAO.instance; }
            private set => PositionDAO.instance = value;
        }

        private PositionDAO() { }

        public List<Position> getPositionList()
        {
            List<Position> list = new List<Position>();
            string query = "SELECT * FROM CHUCVU";
            DataTable data = DataProvider.Instance.executeQuery(query);
            foreach (DataRow item in data.Rows)
            {
                Position positionList = new Position(item);
                list.Add(positionList);
            }
            return list;
        }

        public Position getPositionByMaCV(int macv)
        { 
            Position position = null;

            string query = string.Format("SELECT * FROM CHUCVU WHERE MACV = {0}", macv);
            DataTable data = DataProvider.Instance.executeQuery(query);

            foreach (DataRow item in data.Rows)
            {
                position = new Position(item);
                return position;
            }


            return position;
        }

        public bool insertPosition(int macv, string tencv)
        {
            string query = string.Format("INSERT INTO CHUCVU(MACV, TENCV) VALUES({0}, N'{1}')", macv, tencv);
            int result = DataProvider.Instance.executeNonQuery(query);
            return result > 0;
        }

        public string getTenCVByMaCV(int macv)
        {
            string query = string.Format("SELECT * FROM CHUCVU WHERE MACV = {0}", macv);
            DataTable dt = DataProvider.Instance.executeQuery(query);
            if (dt.Rows.Count > 0)
            {
                DataRow dr = dt.Rows[0];
                string tencv = dr["MACV"].ToString();
                return tencv;
            }
            else
                return null;
        }
        public bool updatePosition(int macv, string tencv)
        {
            //string tencv = getTenCVByMaCV(macv);
            string query = string.Format("UPDATE CHUCVU SET TENCV = N'{0}' WHERE MACV = {1}", tencv, macv);
            int result = DataProvider.Instance.executeNonQuery(query);
            return result > 0;
        }

        public bool deletePosition(int macv)
        {
            string query = string.Format("DELETE CHUCVU WHERE MACV = {0}", macv);
            int result = DataProvider.Instance.executeNonQuery(query);
            return result > 0;
        }
        
    }
}
