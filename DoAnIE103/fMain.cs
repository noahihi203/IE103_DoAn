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

            lbMMaNV.Text = dt["MANV"].ToString();
            lbMHoTen.Text = dt["HOTEN"].ToString();
            lbMDiaChi.Text = dt["DIACHI"].ToString();
            lbMCCCD.Text = dt["CCCD"].ToString();
            dtpMNgaySinh.Text = dt["NGAYSINH"].ToString();
            lbMSDT.Text = dt["SDT"].ToString();
            lbMChucVu.Text = PositionDAO.Instance.getTenCVByMaCV((int)(dt["MACV"])).ToString();
            lbMPhongBan.Text = DepartmentDAO.Instance.getTenPBByMaPB((int)(dt["MAPB"])).ToString();
            lbMGioiTinh.Text = dt["GIOITINH"].ToString();
            dtpMNgayNhanLuong.Text = dt["NGAYNHANLUONG"].ToString();
            
            gbTTNguoiDung.Text = "Thông tin của người dùng " + dt["HOTEN"].ToString();
            gbTTLuongNguoiDung.Text = "Thông tin về lương của người dùng " + dt["HOTEN"].ToString();
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
        #endregion

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }
    }

}
