using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLNS.DTO
{
    internal class Timesheets
    {
        private int maBC;
        private float soNgayLam;
        private float soNgayNghi;
        private string ghiChu;
        private int maPB;
        private int maNV;
        private int thang;

        public int MaBC { get => maBC; set => maBC = value; }
        public float SoNgayLam { get => soNgayLam; set => soNgayLam = value; }
        public float SoNgayNghi { get => soNgayNghi; set => soNgayNghi = value; }
        public string GhiChu { get => ghiChu; set => ghiChu = value; }
        public int MaPB { get => maPB; set => maPB = value; }
        public int MaNV { get => maNV; set => maNV = value; }
        public int Thang { get => thang; set => thang = value; }

        public Timesheets() { }
        public Timesheets(int maBC, float soNgayLam, float soNgayNghi, string ghiChu, int maPB, int maNV, int thang)
        {
            MaBC = maBC;
            SoNgayLam = soNgayLam;
            SoNgayNghi = soNgayNghi;
            GhiChu = ghiChu;
            MaPB = maPB;
            MaNV = maNV;
            Thang = thang;
        }
    }
}
