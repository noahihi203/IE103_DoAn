using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAnIE103.DTO
{
    internal class Department
    {
        private int maPB;
        private string tenPB;

        public int MaPB { get => maPB; set => maPB = value; }
        public string TenPB { get => tenPB; set => tenPB = value; }
        
        public Department(int mapb, string tenpb) { maPB = mapb; tenPB = tenpb; }
        public Department(DataRow row)
        {
            maPB = (int)row["MAPB"];
            tenPB = row["TENPB"].ToString();
        }
    }

}
