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

        public void getTENDANGNHAPbyMaNV(int manv)
        {
            string query = string.Format("SELECT TENDANGNHAP FROM NHANVIEN WHERE MANV = {0}", manv);
            string tendangnhap = DataProvider.Instance.executeQuery(query).ToString();
        }
        public bool DeleteEmployee(int manv)
        {
            // Xóa nhân viên
            string query = string.Format("DELETE NHANVIEN WHERE MANV = {0}", manv);
            int result = DataProvider.Instance.executeNonQuery(query);
            return result > 0;
        }

        

    }
}
