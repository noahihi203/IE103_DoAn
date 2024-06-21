using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLNS.DAO
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

        public DataTable getDanhSachBangCong(int manv) //ma nhan vien cua nguoi quan ly
        {
            DataTable dt = new DataTable();
            string query = string.Format("SELECT NHANVIEN.MANV, NHANVIEN.HOTEN, BANGCONG.MABC, BANGCONG.THANG, BANGCONG.SONGAYLAM, BANGCONG.SONGAYNGHI, BANGCONG.GHICHU FROM NHANVIEN, BANGCONG WHERE NHANVIEN.MANV = BANGCONG.MANV AND NHANVIEN.MAPB = (SELECT MAPB FROM NHANVIEN WHERE MANV = {0})", manv);
            dt = DataProvider.Instance.executeQuery(query);
            if (dt != null)
            {
                return dt;
            }
            return null;
        }

        public DataTable getRP(DateTime time)
        {
            int thang = time.Month;
            int year = time.Year;

            DataTable dt = new DataTable();
            string query = string.Format("SELECT DISTINCT NHANVIEN.MANV as 'Mã nhân viên', NHANVIEN.HOTEN as 'Họ và tên', PHONGBAN.TENPB 'Phòng ban', CHUCVU.TENCV as 'Chức vụ', NHANVIEN.NGAYSINH as 'Ngày sinh', BANGCONG.SONGAYLAM 'Số ngày làm', BANGCONG.SONGAYNGHI as 'Số ngày nghỉ',(((LUONG.LUONGBS + LUONG.LUONGCB - LUONG.PHUCAP)/(BANGCONG.SONGAYLAM + BANGCONG.SONGAYNGHI)) * BANGCONG.SONGAYLAM) AS 'Lương' , MONTH(GETDATE()) AS 'Tháng', YEAR(GETDATE()) AS 'Năm' FROM NHANVIEN, BANGCONG, LUONG, PHONGBAN, CHUCVU WHERE NHANVIEN.MANV = BANGCONG.MANV AND PHONGBAN.MAPB = NHANVIEN.MAPB AND NHANVIEN.MACV = CHUCVU.MACV AND CHUCVU.MACV = LUONG.MACV AND MABC = {0} AND THANG = {1}", year, thang);
            dt = DataProvider.Instance.executeQuery(query);
            if (dt != null)
            {
                return dt;
            }
            return null;
        }
        public bool insertBangCong(int mabc, int manv, int thang)
        {
            string query = string.Format("INSERT INTO BangCong (MaBC, SoNgayLam, SoNgayNghi, MaNV, THANG) VALUES ({0}, {1}, {2}, {3}, {4}),", mabc, 0, 24, manv, thang);
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
