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
using System.IO;
using OfficeOpenXml;
using Excel = Microsoft.Office.Interop.Excel;
using DoAnIE103.DTO;

namespace DoAnIE103
{
    public partial class fEmployee : Form
    {
        int index;
        BindingSource emPloyeeList = new BindingSource();
        public fEmployee()
        {
            InitializeComponent();
        }

        private void toolStrip2_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            //return;
        }

        private void fEmployee_Load(object sender, EventArgs e)
        {
            dtgvEmployee.DataSource = emPloyeeList;
            loadEmployeeList();
        }

        void loadPhongBanIntoCBB(ComboBox cb)
        {
            cb.DataSource = DepartmentDAO.Instance.getPositionList();
            cb.DisplayMember = "TENPB";
            cb.ValueMember = "MAPB";
            //DoAnIE103.DTO.LoaiTaiKhoan
        }

        private void LoadDataIntoComboBoxColumn()
        {
            // Lấy dữ liệu từ bảng 
            DataTable dataPB = DataProvider.Instance.executeQuery("SELECT * FROM PHONGBAN");
            DataTable dataCV = DataProvider.Instance.executeQuery("SELECT * FROM CHUCVU");

            // Lấy cột ComboBox vừa tạo
            DataGridViewComboBoxColumn comboBoxColumnPB = (DataGridViewComboBoxColumn)dtgvEmployee.Columns["CBBTENPB"];
            comboBoxColumnPB.DataSource = dataPB;
            comboBoxColumnPB.ValueMember = "MAPB";
            comboBoxColumnPB.DisplayMember = "TENPB";



            DataGridViewComboBoxColumn comboBoxColumnCV = (DataGridViewComboBoxColumn)dtgvEmployee.Columns["CBBTENCV"];
            comboBoxColumnCV.DataSource = dataCV;
            comboBoxColumnCV.ValueMember = "MACV";
            comboBoxColumnCV.DisplayMember = "TENCV";

        }

        public void loadEmployeeList()
        {
            if (index < 0)
                return;
            //dtgvEmployee = null;
            DataTable data = DataProvider.Instance.executeQuery("SELECT * FROM NHANVIEN");
            emPloyeeList.DataSource = data;
            LoadDataIntoComboBoxColumn();
           

            

            dtgvEmployee.Columns["MALUONG"].Visible = false;
            dtgvEmployee.Columns["NGAYNHANLUONG"].Visible = false;
            dtgvEmployee.Columns["TENDANGNHAP"].Visible = false;

            dtgvEmployee.DataSource = emPloyeeList;

            dtgvEmployee.DefaultCellStyle.Font = new Font("Arial", 10);
            dtgvEmployee.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 8, FontStyle.Bold);
            dtgvEmployee.RowHeadersDefaultCellStyle.Font = new Font("Arial", 12);

            dtgvEmployee.Refresh();
        }
        /*void addUserBinding()
        {
            tbTenDangNhap.DataBindings.Add(new Binding("Text", dtgvUsers.DataSource, "TENDANGNHAP", true, DataSourceUpdateMode.Never));
            tbMatKhau.DataBindings.Add(new Binding("Text", dtgvUsers.DataSource, "MATKHAU", true, DataSourceUpdateMode.Never));
        }*/

        #region events
        private void tsbAdd_Click(object sender, EventArgs e)
        {
            fAddNewEmployee f = new fAddNewEmployee();
            f.ShowDialog();
            this.Refresh();
        }

        public void dtgvEmployee_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            index = e.RowIndex;
            if (index < 0)
                return;
            Const.EmployeeId = Convert.ToInt16(dtgvEmployee.Rows[index].Cells[0].Value);
        }
        private void tsbDelete_Click(object sender, EventArgs e)
        {
            int manv = Const.EmployeeId;

            if (EmployeeDAO.Instance.DeleteEmployee(Const.EmployeeId))
            {
                MessageBox.Show("Xoá tài khoản nhân viên!");
                loadEmployeeList();
            }
            else
            {
                MessageBox.Show("Có lỗi khi xoá nhân viên!");
                return;
            }
        }

         private int getMaNV(Employee nhanvien)
        {
            int manv = Convert.ToInt32(nhanvien.MaNV);
            return manv;
        }

        private void tsbEdit_Click(object sender, EventArgs e)
        {
            fEditEmployee f = new fEditEmployee();
            f.ShowDialog();
        }

        #endregion


        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void ExportExcel(string path)
        {
            Excel.Application app = new Excel.Application();
            app.Application.Workbooks.Add(Type.Missing);
            for (int i = 0; i < dtgvEmployee.Columns.Count; i++)
            {
                app.Cells[1, i + 1] = dtgvEmployee.Columns[i].HeaderText;
            }
            for (int i = 0; i < dtgvEmployee.Rows.Count; i++)
            {
                for (int j = 0; j < dtgvEmployee.Columns.Count; j++)
                {
                    app.Cells[i + 2, j + 1] = dtgvEmployee.Rows[i].Cells[j].Value;
                }
                app.Columns.AutoFit();
                app.ActiveWorkbook.SaveCopyAs(path);
                app.ActiveWorkbook.Saved = true;
            }
        }

        private void tsbExport_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Title = "Export Excel";
            saveFileDialog.Filter = "Excel (*.xlsx)|*.xlsx|Excel 2003 (*.xls)|*.xls";
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    ExportExcel(saveFileDialog.FileName);
                    MessageBox.Show("Xuất file thành công!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Xuất file không thành công!\n" + ex.Message);
                }
            }
        }
        private void ImportExcel(string path)
        {

        }


    }
}
