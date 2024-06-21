using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLNS.DTO
{
    internal class User
    {
        private string tenDangNhap;

        private string matKhau;

        private int loaiTaiKhoan;
        public string TenDangNhap { get => tenDangNhap; set => tenDangNhap = value; }
        public string MatKhau { get => matKhau; set => matKhau = value; }
        public int LoaiTaiKhoan { get => loaiTaiKhoan; set => loaiTaiKhoan = value; }


        public User(string username, string password, int typeuser)
        {
            tenDangNhap = username;
            matKhau = password;
            loaiTaiKhoan = typeuser;
        }
    }
}
