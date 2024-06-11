using DoAnIE103.DAO;
using DoAnIE103.DTO;
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
    public partial class fMain : Form
    {
        List<string> gioiTinhList = new List<string>() { "Nam", "Nữ" };


        public bool isExit = true;

        public event EventHandler Logout;
        public fMain()
        {
            InitializeComponent();
        }


        #region Method
        void Decentralization()
        {
            if (Const.userType == 0)
            {
                tsmiUser.Enabled = tsmiEmployee.Enabled = tsmiPhongBan.Enabled = tsmiChucVu.Enabled = false;
            }

        }

        #endregion

        #region Event
        private void fMain_Load(object sender, EventArgs e)
        {
            //tsbAdd.Enabled = tsbDelete.Enabled = tsbEdit.Enabled = tsbPrint.Enabled = false;
            loadDataToForm();
            Decentralization();
        }

        private void loadDataToForm()
        {
            DataTable data = EmployeeDAO.Instance.getEmployeeByUserID(Const.userID);

            if (data == null)
            {
                MessageBox.Show("Không tìm thấy nhân vien!");
                return;
            }
            DataRow dt = data.Rows[0];

            cbbMHoTen.Text = dt["HOTEN"].ToString();
            cbbMDiaChi.Text = dt["DIACHI"].ToString();
            cbbMCCCD.Text = dt["CCCD"].ToString();
            dtpMNgaySinh.Text = dt["NGAYSINH"].ToString();
            cbbMSDT.Text = dt["SDT"].ToString();
            cbbMChucVu.Text = PositionDAO.Instance.getTenCVByMaCV((int)(dt["MACV"])).ToString();
            cbbMPhongBan.Text = DepartmentDAO.Instance.getTenPBByMaPB((int)(dt["MAPB"])).ToString();
            cbbMGioiTinh.Text = dt["GIOITINH"].ToString();
            dtpMNgayNhanLuong.Text = dt["NGAYNHANLUONG"].ToString();

            gbTTNguoiDung.Text = "Thông tin của người dùng " + dt["HOTEN"].ToString() + ", mã nhân viên: " + dt["MANV"].ToString();
            gbTTLuongNguoiDung.Text = "Thông tin về lương của người dùng " + dt["HOTEN"].ToString() + ", mã nhân viên: " + dt["MANV"].ToString();

        }

        private void fMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (isExit)
            {
                if (MessageBox.Show("Bạn có muốn thoát chương trình", "Cảnh báo", MessageBoxButtons.YesNo) != DialogResult.Yes)
                    e.Cancel = true;
            }
        }
        private void fMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (isExit)
                Application.Exit();
        }

        private void đăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Logout(this, new EventArgs());
        }


        private void tsmiEmployee_Click(object sender, EventArgs e)
        {
            fEmployee f = new fEmployee();
            f.ShowDialog();

        }

        private void quảnLýToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Const.userType == 0)
                MessageBox.Show("Bạn không phải admin!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void tsmiUser_Click(object sender, EventArgs e)
        {
            fUsers f = new fUsers();
            f.ShowDialog();
        }

        private void tsmiPhongBan_Click(object sender, EventArgs e)
        {
            fDepartment f = new fDepartment();
            f.ShowDialog();
        }

        private void tsmiChucVu_Click(object sender, EventArgs e)
        {
            fPosition f = new fPosition();
            f.ShowDialog();
        }

        private void thoátToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void thốngKêToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //fStatistical f = new fStatistical();
            //f.ShowDialog();
        }

        private void trợGiúpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //fHelp f = new fHelp();
            //f.ShowDialog();
        }
        #endregion



        private void lbMHoTen_Click(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void gbTTLuongNguoiDung_Enter(object sender, EventArgs e)
        {

        }

        private void gbTTLuongNguoiDung_Enter_1(object sender, EventArgs e)
        {

        }
    }

}
