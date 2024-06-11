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
    public partial class fAddDepartment : Form
    {
        public fAddDepartment()
        {
            InitializeComponent();
        }
        #region methods
        public bool IsPBExists(int mapb, string tenpb)
        {
            List<Department> dpm = DepartmentDAO.Instance.GetDepartmentsList();
            for (int i = 0; i < dpm.Count; i++)
            {
                if (dpm[i].MaPB == mapb || dpm[i].TenPB == tenpb)
                {
                    return true;
                }
            }
            return false;
        }
        #endregion

        #region events


        private void btAddPositionInFA_Click_1(object sender, EventArgs e)
        {
            if (IsPBExists(Convert.ToInt32(tbMaPBInFA.Text), tbTenPBInFA.Text))
            {
                MessageBox.Show("Phòng ban đã tồn tại, Vui lòng nhập mã khác!");
                tbTenPBInFA.Text = null;
                tbMaPBInFA.Text = null;
                return;
            }
            else
            {
                if (String.IsNullOrWhiteSpace(tbMaPBInFA.Text))
                {
                    MessageBox.Show("Bạn cần nhập mã phòng ban trước khi thêm!", "Thông báo", MessageBoxButtons.OK);
                    return;
                }
                if (String.IsNullOrWhiteSpace(tbTenPBInFA.Text))
                {
                    MessageBox.Show("Bạn cần nhập tên phòng ban trước khi thêm!", "Thông báo", MessageBoxButtons.OK);
                    return;
                }
            }

            int mapb = Convert.ToInt16(tbMaPBInFA.Text);
            string tenpb = tbTenPBInFA.Text;


            if (DepartmentDAO.Instance.insertDepartment(mapb, tenpb))
                MessageBox.Show("Thêm phòng ban thành công!", "Thông báo", MessageBoxButtons.OK);
            else
            {
                MessageBox.Show("Thêm phòng ban thất bại!", "Thông báo", MessageBoxButtons.OK);
                return;
            }
            this.Close();
        }

        private void btCancelInFA_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion


    }
}
