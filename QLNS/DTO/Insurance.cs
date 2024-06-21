using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLNS.DTO
{
    internal class Insurance
    {
        private int maBH;
        private string soBH;
        private DateTime ngayCap;
        private string noiCap;
        private string noiKhamBenh;
        private int maNV;

        public int MaBH { get => maBH; set => maBH = value; }
        public string SoBH { get => soBH; set => soBH = value; }
        public DateTime NgayCap { get => ngayCap; set => ngayCap = value; }
        public string NoiCap { get => noiCap; set => noiCap = value; }
        public string NoiKhamBenh { get => noiKhamBenh; set => noiKhamBenh = value; }
        public int MaNV { get => maNV; set => maNV = value; }

        public Insurance (int mabh, string sobh, DateTime ngaycap, string noicap, string noikhambenh, int manv)
        {
            maBH = mabh;
            soBH = sobh;
            ngayCap = ngaycap;
            noiCap = noicap;
            noiKhamBenh = noikhambenh;
            maNV = manv;
        }
    }
}
