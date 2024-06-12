using CsvHelper;
using DoAnIE103.DAO;
using DoAnIE103.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;
using System.Collections.Generic;
using CsvHelper.Configuration;



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
        int manv;
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
            manv = Convert.ToInt32(dt["MANV"].ToString());
            Const.EmployeeId = manv;
            cbbMLuongThang = getLuong(Const.EmployeeId);

        }
        private double getLuong(int manv)
        {
            double luongDu = WageDAO.Instance.getLuongByMaNV(manv);
            DataTable data = new DataTable();
            data = TimesheetsDAO.Instance.getDanhSachBangCong(Const.EmployeeId);
            double songayLam;
            double songayNghi;
            foreach (DataRow dr in data.Rows)
            {
                if (Convert.ToInt32(dr["THANG"]) == Convert.ToInt32(DateTime.Now.Month)
                    && Convert.ToInt32(dr["MABC"]) == Convert.ToInt32(DateTime.Now.Year)
                    && Convert.ToInt32(dr["MANV"]) == manv)
                {
                    songayLam = Convert.ToDouble(dr["SONGAYLAM"]);
                    songayNghi = Convert.ToDouble(dr["SONGAYNGHI"]);
                }
            }
            double luong = (luongDu / 24) * songayLam;
            return luong;
            
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





        private void bảngChấmCôngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fTimesheets f = new fTimesheets();
            f.ShowDialog();
        }

        public bool verifyLocation() // Hàm để xác nhận vị trí
        {
            return true;
        }

        string filePath = "C:\\Users\\user\\OneDrive\\Máy tính\\DoAnIE103\\CheckInCheckOut.csv";

        private void btCheckIn_Click(object sender, EventArgs e)
        {
            btCheckOut.Enabled = true;

            bool hasCheckedIn = false;
            using (var reader = new StreamReader(filePath))
            using (var csv = new CsvReader(reader, new CsvConfiguration(CultureInfo.InvariantCulture)))
            {
                csv.Read();
                string i = null;
                try
                {
                    i = csv.GetField<string>(0);
                }
                catch
                {

                }
                if (i != null)
                {
                    btCheckIn.Enabled = false;
                    btCheckOut.Enabled = true;
                    MessageBox.Show("Đã check in rồi");
                    return;
                }

            }

            using (StreamWriter sw = new StreamWriter(filePath, false))
            using (CsvWriter csvWriter = new CsvWriter(sw, CultureInfo.InvariantCulture))
            {
                if (verifyLocation()) // Kiểm tra vị trí
                {

                    // Ghi thời gian check-in vào file
                    csvWriter.WriteField(DateTime.Now);
                    csvWriter.NextRecord();

                    MessageBox.Show("Đã Check in!");
                }
                else
                {
                    MessageBox.Show("Bạn đang không ở công ty đẻ check in");
                    btCheckIn.Enabled = false;
                }
            }
        }



        private void btCheckOut_Click(object sender, EventArgs e)
        {

            bool hasCheckedIn = false;
            using (var reader = new StreamReader(filePath))
            using (var csv = new CsvReader(reader, new CsvConfiguration(CultureInfo.InvariantCulture)))
            {
                csv.Read();
                string eww = null;
                try
                {
                    eww = csv.GetField<string>(0);
                }
                catch
                {

                }
                if (eww == null)
                {
                    btCheckOut.Enabled = false;
                    btCheckIn.Enabled = true;

                    MessageBox.Show("Chưa check in");
                    return;
                }

            }
            CheckInAndOutDate i = new CheckInAndOutDate();

            if (verifyLocation()) //Kiem tra vi tri
            {
                using (var reader = new StreamReader(filePath))
                using (var csv = new CsvReader(reader, new CsvConfiguration(CultureInfo.InvariantCulture)))
                {
                    csv.Read();
                    i.CheckInTime = csv.GetField<DateTime>(0);
                }
                i.CheckOutTime = DateTime.Now;
                i.WorkTime = i.CheckOutTime - i.CheckInTime;
                i.WorkTimeDay = i.WorkTime.TotalDays * 3;

                MessageBox.Show("Đã Check Out thành công!");
            }
            File.WriteAllText(filePath, string.Empty);


            if (TimesheetsDAO.Instance.updateBangCong(i.WorkTimeDay, DateTime.Now.Year, manv, DateTime.Now.Month))
            {
                return;
            }
            else
            {
                MessageBox.Show("Co loi khi them so ngay lam viec");
            }
        }

        private void btSaveProfile_Click(object sender, EventArgs e)
        {

        }
    }

}
