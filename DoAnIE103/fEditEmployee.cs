using DoAnIE103.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoAnIE103
{
    public partial class fEditEmployee : Form
    {
        public fEditEmployee()
        {
            InitializeComponent();
        }

        private void btELuu_Click(object sender, EventArgs e)
        {
            int manv = Convert.ToInt32(tbEMaNV.Text);
            string hoten = tbEHoTen.Text;
            string gioitinh = cbEGioiTinh.Text;
            string ngaysinh = dtpENgaySinh.Value.Date.ToString("yyyy-MM-dd");
            string sdt = tbESDT.Text;
            string cccd = tbECCCD.Text;
            string diachi = tbEDiaChi.Text;
            int macv = Convert.ToInt32(tbEMaCV.Text);
            int mapb = Convert.ToInt32(tbEMaPB.Text);
            int maluong = Convert.ToInt32(tbEMaLuong.Text);
            string ngaynhanluong = dtpENgayNhanLuong.Value.Date.ToString("yyyy-MM-dd");

            if (EmployeeDAO.Instance.InsertEmployee(manv, hoten, gioitinh, ngaysinh, sdt, cccd, diachi, macv, mapb, maluong, ngaynhanluong))
            {
                MessageBox.Show("Sửa nhân viên thành công!");
            }
            else
            {
                MessageBox.Show("Có lỗi khi sửa nhân viên, sửa nhân viên thất bại!");
                return;
            }
        }
    }
}
