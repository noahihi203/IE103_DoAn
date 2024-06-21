using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLNS.DTO
{
    internal class Position
    {
        private int maCV;
        private string tenCV;

        public int MaCV { get => maCV; set => maCV = value; }
        public string TenCV { get => tenCV; set => tenCV = value; }

        public Position(int macv, string tencv)
        {
            maCV = macv;
            tenCV = tencv;
        }
        public Position(DataRow row)
        {
            maCV = (int)row["MACV"];
            tenCV = row["TENCV"].ToString();
        }
    }
}
