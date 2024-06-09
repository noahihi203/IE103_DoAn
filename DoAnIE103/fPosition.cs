using DoAnIE103.DAO;
using DoAnIE103.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoAnIE103
{
    public partial class fPosition : Form
    {
        int index = -1;

        BindingSource poSitionList = new BindingSource();
        public fPosition()
        {
            InitializeComponent();
        }

        private void fPosition_Load(object sender, EventArgs e)
        {
            dtgvPosition.DataSource = poSitionList;
            loadPosition();
        }

        void loadPosition()
        {
            DataTable dt = DataProvider.Instance.executeQuery("SELECT * FROM CHUCVU");
            poSitionList.DataSource = dt;
            dtgvPosition.DataSource = poSitionList;
            dtgvPosition.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dtgvPosition.Refresh();
        }

        public bool IsTenCVExists(string tencv)
        {
            List<Position> positions = PositionDAO.Instance.getPositionList(); //Dùng hàm getPositionList để trả về list chức vụ
            for (int i = 0; i < positions.Count; i++)
            {
                if (positions[i].TenCV == tencv)
                {
                    return true; //Nếu tồn tại thì trả về true
                }
            }
            return false; //Không tồn tại trả về false

        }

        #region events
        private void tsbExitPosition_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tsbAddPosition_Click(object sender, EventArgs e)
        {
            fAddPosition f = new fAddPosition();
            f.ShowDialog();
            loadPosition();
        }

        private void dtgvPosition_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            index = e.RowIndex;
            if (index < 0 || index > dtgvPosition.Rows.Count - 1)
                return;
            else
                Const.PositionId = Convert.ToInt16(dtgvPosition.Rows[index].Cells[0].Value);
        }

        private void dtgvPosition_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            string newValue = dtgvPosition.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString();
            int maCVinEdit = (int)dtgvPosition.Rows[e.RowIndex].Cells["MACV"].Value;

            if (PositionDAO.Instance.getTenCVByMaCV(maCVinEdit) == newValue)
            {
                return;
            }
            else
            {
                if (!IsTenCVExists(newValue))
                {
                    PositionDAO.Instance.updatePosition(maCVinEdit, newValue);
                    loadPosition();
                    MessageBox.Show("Thay đổi của bạn đã được thực thi!");
                    return;
                }
                else
                {
                    MessageBox.Show("Thay đổi của bạn đã thất bại, có thể là tên chức vụ hoặc mã chức vụ đã tồn tại!");
                    return;
                }
            }

        }
        private void tsbDeletePosition_Click(object sender, EventArgs e)
        {
            if (PositionDAO.Instance.deletePosition(Const.PositionId))
            {
                MessageBox.Show("Xóa chức vụ thành công!", "Thông báo", MessageBoxButtons.OK);
                loadPosition();
                return;
            }
            else
            {
                MessageBox.Show("Xóa chức vụ thất bại!", "Thông báo", MessageBoxButtons.OK);
                return;
            }
        }


        #endregion
    }
}
