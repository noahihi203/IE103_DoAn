using DoAnIE103.DTO;
using OfficeOpenXml.FormulaParsing.LexicalAnalysis;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAnIE103.DAO
{
    internal class EmployeeDAO
    {
        private static EmployeeDAO instance;
        public static EmployeeDAO Instance
        {
            get { if (instance == null) instance = new EmployeeDAO(); return EmployeeDAO.instance; }
            private set => EmployeeDAO.instance = value;
        }

        private EmployeeDAO() { }

        public List<Employee> getEmployeeList()
        {
            List<Employee> l = new List<Employee>();
            string query = "SELECT * FROM NHANVIEN";
            DataTable data = DataProvider.Instance.executeQuery(query);
            foreach (DataRow item in data.Rows)
            {
                Employee epl = new Employee(item);
                l.Add(epl);
            }
            return l;
        }
        public void getTENDANGNHAPbyMaNV(int manv)
        {
            string query = string.Format("SELECT TENDANGNHAP FROM NHANVIEN WHERE MANV = {0}", manv);
            string tendangnhap = DataProvider.Instance.executeQuery(query).ToString();
        }
        public DataTable getEmployeeByUserID(string userID)
        {
            string query = string.Format("SELECT * FROM NHANVIEN WHERE TENDANGNHAP = N'{0}'", userID);
            DataTable dt = DataProvider.Instance.executeQuery(query);
            if (dt.Rows.Count > 0)
            {
                return dt;
            }

            return null;
        }
        public DataTable getEmployeeByEmployeeID(int EmployeeID)
        {
            string query = string.Format("SELECT * FROM NHANVIEN WHERE MANV = N'{0}'", EmployeeID);
            DataTable dt = DataProvider.Instance.executeQuery(query);
            if (dt.Rows.Count > 0)
            {
                return dt;
            }

            return null;
        }

        public bool InsertEmployee(int manv, string hoten, string gioitinh, string ngaysinh, string sdt, string cccd, string diachi, int macv, int mapb, int maluong, string ngaynhanluong)
        {
            string query = string.Format("EXEC InsertEmployee @MaNV = {0}, @HoTen = N'{1}', @GioiTinh = N'{2}', @NgaySinh = '{3}', @SDT = N'{4}', @CCCD = N'{5}', @DiaChi = N'{6}', @MaCV = {7}, @MaPB = {8}, @MaLuong = {9}, @NgayNhanLuong = '{10}'",
                                         manv, hoten, gioitinh, ngaysinh, sdt, cccd, diachi, macv, mapb, maluong, ngaynhanluong);
            int result = DataProvider.Instance.executeNonQuery(query);
            return result > 0;
        }


        public bool UpdateEmployee(int manv, string hoten, string gioitinh, string ngaysinh, string sdt, string cccd, string diachi, int macv, int mapb, int maluong, string ngaynhanluong)
        {
            string query = string.Format("UPDATE NHANVIEN SET HOTEN = N'{1}', GIOITINH = N'{2}', NGAYSINH = '{3}', SDT = N'{4}', CCCD = N'{5}', DIACHI = N'{6}', MACV = N'{7}', MAPB = N'{8}', MALUONG = N'{9}', NGAYNHANLUONG = '{10}' WHERE MANV = N'{0}'",
                manv, hoten, gioitinh, ngaysinh, sdt, cccd, diachi, macv, mapb, maluong, ngaynhanluong);
            int result = DataProvider.Instance.executeNonQuery(query);
            return result > 0;
        }

       
        public bool DeleteEmployee(int manv)
        {
            // Xóa nhân viên
            string query = string.Format("DELETE NHANVIEN WHERE MANV = {0}", manv);
            int result = DataProvider.Instance.executeNonQuery(query);
            return result > 0;
        }

        //update in main

        //update one
        public bool updateEmployeeNameByMaNV(int manv, string ten)
        {
            string query = string.Format("UPDATE NHANVIEN SET HOTEN = N'{0}' WHERE MANV = {1}", ten, manv);
            return DataProvider.Instance.executeNonQuery(query) > 0;
        }

        public bool updateEmployeeGioiTinhByMaNV(int manv, string gioitinh)
        {
            string query = string.Format("UPDATE NHANVIEN SET GIOITINH = N'{0}' WHERE MANV = {1}", gioitinh, manv);
            return DataProvider.Instance.executeNonQuery(query) > 0;
        }

        public bool updateEmployeeNgaySinhByMaNV(int manv, DateTime ngaysinh)
        {
            string query = string.Format("UPDATE NHANVIEN SET NGAYSINH = '{0}' WHERE MANV = {1}", ngaysinh.ToString("yyyy-MM-dd"), manv);
            return DataProvider.Instance.executeNonQuery(query) > 0;
        }

        public bool updateEmployeeSDTByMaNV(int manv, string sdt)
        {
            string query = string.Format("UPDATE NHANVIEN SET SDT = '{0}' WHERE MANV = {1}", sdt, manv);
            return DataProvider.Instance.executeNonQuery(query) > 0;
        }

        public bool updateEmployeeCCCDByMaNV(int manv, string cccd)
        {
            string query = string.Format("UPDATE NHANVIEN SET CCCD = '{0}' WHERE MANV = {1}", cccd, manv);
            return DataProvider.Instance.executeNonQuery(query) > 0;
        }

        public bool updateEmployeeDiaChiByMaNV(int manv, string diachi)
        {
            string query = string.Format("UPDATE NHANVIEN SET DIACHI = N'{0}' WHERE MANV = {1}", diachi, manv);
            return DataProvider.Instance.executeNonQuery(query) > 0;
        }

        public bool updateEmployeeChucVuByMaNV(int manv, int chucvu)
        {
            string query = string.Format("UPDATE NHANVIEN SET CHUCVU = {0} WHERE MANV = {1}", chucvu, manv);
            return DataProvider.Instance.executeNonQuery(query) > 0;
        }

        public bool updateEmployeePhongBanByMaNV(int manv, int phongban)
        {
            string query = string.Format("UPDATE NHANVIEN SET PHONGBAN = {0} WHERE MANV = {1}", phongban, manv);
            return DataProvider.Instance.executeNonQuery(query) > 0;
        }

    }
}
