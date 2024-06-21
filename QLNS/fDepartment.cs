using QLNS.DAO;
using QLNS.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLNS
{
    public partial class fDepartment : Form
    {
        int departmentID;
        public fDepartment()
        {
            InitializeComponent();
        }
        int index = -1;

        BindingSource departmentSitionList = new BindingSource();


        private void fDepartment_Load(object sender, EventArgs e)
        {
            dtgvDepartment.DataSource = departmentSitionList;
            loadDepartment();
        }


        void loadDepartment()
        {
            DataTable dt = DataProvider.Instance.executeQuery("SELECT * FROM PHONGBAN");
            departmentSitionList.DataSource = dt;
            dtgvDepartment.DataSource = departmentSitionList;
            dtgvDepartment.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dtgvDepartment.Refresh();
        }

        public bool IsTenPBExists(string tenpb)
        {
            List<Department> departments = DepartmentDAO.Instance.GetDepartmentsList(); //Dùng hàm getPositionList để trả về list chức vụ
            for (int i = 0; i < departments.Count; i++)
            {
                if (departments[i].TenPB == tenpb)
                {
                    return true; //Nếu tồn tại thì trả về true
                }
            }
            return false; //Không tồn tại trả về false

        }

        #region events

        private void tsbAddDepartment_Click(object sender, EventArgs e)
        {
            fAddDepartment f = new fAddDepartment();
            f.ShowDialog();
            loadDepartment();
        }

        private void dtgvDepartment_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            index = e.RowIndex;
            if (index < 0 || index > dtgvDepartment.Rows.Count - 1)
                return;
            else
                departmentID = Convert.ToInt16(dtgvDepartment.Rows[index].Cells[0].Value);
        }

        private void dtgvDepartment_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            string newValue = dtgvDepartment.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString();
            int maPBinEdit = (int)dtgvDepartment.Rows[e.RowIndex].Cells["MAPB"].Value;

            if (DepartmentDAO.Instance.getTenPBByMaPB(maPBinEdit) == newValue)
            {
                return;
            }
            else
            {
                if (!IsTenPBExists(newValue))
                {
                    DepartmentDAO.Instance.updateDepartment(maPBinEdit, newValue);
                    loadDepartment();
                    MessageBox.Show("Thay đổi của bạn đã được thực thi!");
                    return;
                }
                else
                {
                    MessageBox.Show("Thay đổi của bạn đã thất bại, có thể là tên phòng ban hoặc mã phòng ban đã tồn tại!");
                    return;
                }
            }
        }
        private void tsbDeleteDepartment_Click(object sender, EventArgs e)
        {
            if (DepartmentDAO.Instance.deleteDepartment(departmentID))
            {
                MessageBox.Show("Xóa thành công!", "Thông báo", MessageBoxButtons.OK);
                loadDepartment();
                return;
            }
            else
            {
                MessageBox.Show("Xóa thất bại!", "Thông báo", MessageBoxButtons.OK);
                return;
            }
        }
        private void tsbExitDepartment_Click(object sender, EventArgs e)
        {
            this.Close();

        }
        #endregion






    }
}
