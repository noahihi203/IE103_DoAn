using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAnIE103.DTO
{
    internal class Employee
    {
        private int maNV;
        private string hoTen;
        private string gioiTinh;
        private DateTime ngaySinh;
        private string sDT;
        private string cCCD;
        private string diaChi;
        private int maChucVu;
        private int maPhongBan;
        private int maLuong;
        private DateTime ngayNhanLuong;
        private string tenDangNhap;

        public int MaNV { get => maNV; set => maNV = value; }
        public string HoTen { get => hoTen; set => hoTen = value; }
        public string GioiTinh { get => gioiTinh; set => gioiTinh = value; }
        public DateTime NgaySinh { get => ngaySinh; set => ngaySinh = value; }
        public string SDT { get => sDT; set => sDT = value; }
        public string CCCD { get => cCCD; set => cCCD = value; }
        public string DiaChi { get => diaChi; set => diaChi = value; }
        public int ChucVu { get => maChucVu; set => maChucVu = value; }
        public int MaPhongBan { get => maPhongBan; set => maPhongBan = value; }
        public int MaLuong { get => maLuong; set => maLuong = value; }
        public DateTime NgayNhanLuong { get => ngayNhanLuong; set => ngayNhanLuong = value; }
        public string TenDangNhap { get => tenDangNhap; set => tenDangNhap = value; }

        public Employee (int manv, string hoten, string gioitinh, DateTime ngaysinh, string sdt, string cccd, string diachi, int macv, int mapb, int maluong, DateTime ngaynhanluong, string tendangnhap)
        {
            maNV = manv;
            hoTen = hoten;
            gioiTinh = gioitinh;
            ngaySinh = ngaysinh;
            sDT = sdt;
            cCCD = cccd;
            diaChi = diachi;
            maChucVu = macv;
            maPhongBan = mapb;
            maLuong = maluong;
            ngayNhanLuong = ngaynhanluong;
            tenDangNhap = tendangnhap;
        }

        public Employee(DataRow row)
        {
            maNV = (int)(row["MANV"]);
            hoTen = row["HOTEN"].ToString();
            gioiTinh = row["GIOITINH"].ToString();
            ngaySinh = Convert.ToDateTime(row["NGAYSINH"]);
            sDT = row["SDT"].ToString();
            cCCD = row["CCCD"].ToString();
            diaChi = row["DIACHI"].ToString();
            maChucVu = (int)row["MACV"];
            maPhongBan = (int)row["MAPB"];
            maLuong = (int)row["MALUONG"];
            ngayNhanLuong = Convert.ToDateTime(row["NGAYNHANLUONG"]);
            tenDangNhap = row["TENDANGNHAP"].ToString();

        }

    }
}
