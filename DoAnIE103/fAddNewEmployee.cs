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
using static OfficeOpenXml.ExcelErrorValue;

namespace DoAnIE103
{
    public partial class fAddNewEmployee : Form
    {
        public fAddNewEmployee()
        {
            InitializeComponent();
        }

        void addEmployeeFromHeretoFEmployee()
        {

        }

        private void btAHuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void fAddNewEmployee_Enter(object sender, EventArgs e)
        {

        }

        private void btAThem_Click(object sender, EventArgs e)
        {
            int manv = Convert.ToInt32(tbAMaNV.Text);
            string hoten = tbAHoTen.Text;
            string gioitinh = cbAGioiTinh.Text;
            string ngaysinh = dtpANgaySinh.Value.Date.ToString("yyyy-MM-dd");
            string sdt = tbASDT.Text;
            string cccd = tbACCCD.Text;
            string diachi = tbADiaChi.Text;
            int macv = Convert.ToInt32(tbAMaCV.Text);
            int mapb = Convert.ToInt32(tbAMaPB.Text);
            int maluong = Convert.ToInt32(tbAMaLuong.Text);
            string ngaynhanluong = dtpANgayNhanLuong.Value.Date.ToString("yyyy-MM-dd");

            if (EmployeeDAO.Instance.InsertEmployee(manv, hoten, gioitinh, ngaysinh, sdt, cccd, diachi, macv, mapb, maluong, ngaynhanluong))
            {
                MessageBox.Show("Thêm nhân viên thành công!");
            }
            else
            {
                MessageBox.Show("Có lỗi khi thêm nhân viên, thêm nhân viên thất bại!");
                return;
            }
        }

        private void fAddNewEmployee_FormClosed(object sender, FormClosedEventArgs e)
        {
        }
    }
}
