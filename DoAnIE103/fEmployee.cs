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

        public void loadEmployeeList()
        {
            if (index < 0)
                return;
            //dtgvEmployee = null;
            DataTable data = DataProvider.Instance.executeQuery("SELECT * FROM NHANVIEN");
            emPloyeeList.DataSource = data;
            dtgvEmployee.DataSource = emPloyeeList;
            dtgvEmployee.Refresh();
        }


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
