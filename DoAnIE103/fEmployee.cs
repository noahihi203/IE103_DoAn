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
using System.Runtime.InteropServices;

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

        #region methods
        private void fEmployee_Load(object sender, EventArgs e)
        {
            dtgvEmployee.DataSource = emPloyeeList;
            loadEmployeeList();
        }

        void loadPhongBanIntoCBB(ComboBox cb)
        {
            cb.DataSource = DepartmentDAO.Instance.GetDepartmentsList();
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
            // CBBTENCV

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

            }
            app.Columns.AutoFit();
            app.ActiveWorkbook.SaveCopyAs(path);
            app.ActiveWorkbook.Saved = true;
            app.Quit();
            Marshal.ReleaseComObject(app);
        }
        private void ImportExcel(string path)
        {
            ExcelPackage.LicenseContext = OfficeOpenXml.LicenseContext.NonCommercial;
            using (ExcelPackage excelPackage = new ExcelPackage(new FileInfo(path)))
            {
                ExcelWorksheet excelWorksheet = excelPackage.Workbook.Worksheets[0];

                for (int i = excelWorksheet.Dimension.Start.Row + 1; i <= excelWorksheet.Dimension.End.Row; i++)
                {
                    List<string> listRows = new List<string>();
                    for (int j = excelWorksheet.Dimension.Start.Column; j <= excelWorksheet.Dimension.End.Column; j++)
                    {
                        listRows.Add(excelWorksheet.Cells[i, j].Value.ToString());
                    }
                    int maluong = Convert.ToInt32(listRows[9]);
                    int mapb = Convert.ToInt32(listRows[8]);
                    int macv = Convert.ToInt32(listRows[7]);
                    int manv = Convert.ToInt32(listRows[0]);

                    EmployeeDAO.Instance.InsertEmployee(manv, listRows[1], listRows[2], listRows[3], listRows[4], listRows[5], listRows[6], macv, mapb, maluong, listRows[10]);
                }
            }

        }

        #endregion
        #region events
        //add Employyee
        private void tsbAdd_Click(object sender, EventArgs e)
        {
            fAddNewEmployee f = new fAddNewEmployee();
            f.ShowDialog();
            loadEmployeeList();
        }

        //delete Employee
        int employeeID;
        public void dtgvEmployee_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            index = e.RowIndex;
            if (index < 0)
                return;
            employeeID = Convert.ToInt16(dtgvEmployee.Rows[index].Cells[0].Value);
        }
        private void tsbDelete_Click(object sender, EventArgs e)
        {
            int manv = employeeID;

            if (EmployeeDAO.Instance.DeleteEmployee(employeeID))
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
            /*fEditEmployee f = new fEditEmployee();
            f.ShowDialog();*/
        }

        private void dtgvEmployee_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            string newValue = dtgvEmployee.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString();

            int maNVinEdit = (int)dtgvEmployee.Rows[e.RowIndex].Cells["MANV"].Value;

            DataTable data = new DataTable();
            data = EmployeeDAO.Instance.getEmployeeByEmployeeID(maNVinEdit);
            DataRow dr = data.NewRow();
            dr = data.Rows[0];

            string query = string.Format("UPDATE NHANVIEN SET {0} = N'{1}' WHERE MANV = {2}", dtgvEmployee.Columns[e.ColumnIndex].DataPropertyName.ToString(), newValue, maNVinEdit);
            int result = DataProvider.Instance.executeNonQuery(query);
            if (result > 0)
            {
                MessageBox.Show("Sửa nhân viên thành công!");
                loadEmployeeList();
                return;
            }
            else
            {
                MessageBox.Show("Sửa nhân viên thất bại!");
                loadEmployeeList();
                return;
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
                    loadEmployeeList() ;
                }
            }
        }

        private void tsbImport_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Title = "Import Excel";
            openFileDialog.Filter = "Excel (*.xlsx)|*.xlsx|Excel 2003 (*.xls)|*.xls";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    ImportExcel(openFileDialog.FileName);
                    MessageBox.Show("Nhập file thành công!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Nhập file không thành công!\n" + ex.Message);
                }
            }
            loadEmployeeList();
        }
        #endregion



        private void dtgvEmployee_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            return;
        }

        private void dtgvEmployee_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            return;
        }

        private void dtgvEmployee_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            return;
        }

        private void dtgvEmployee_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void dtgvEmployee_Click(object sender, EventArgs e)
        {
            return;
        }

        private void btExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }

}
