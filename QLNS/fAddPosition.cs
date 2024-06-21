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
    public partial class fAddPosition : Form
    {
        public fAddPosition()
        {
            
            InitializeComponent();
        }
        #region methods
        public bool IsCVExists(int macv, string tencv) //Kiểm tra xem chức vụ đã có chưa thông qua mã chức vụ và tên chức vụ
        {
            List<Position> positions = PositionDAO.Instance.getPositionList(); //Dùng hàm getPositionList để trả về list chức vụ
            for (int i = 0; i < positions.Count; i++)
            {
                if (positions[i].MaCV == macv || positions[i].TenCV == tencv)
                {
                    return true; //Nếu tồn tại thì trả về true
                }
            }
            return false; //Không tồn tại trả về false
        }
        #endregion

        #region events
        private void btCancelInFA_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btAddPositionInFA_Click(object sender, EventArgs e)
        {
            if (IsCVExists(Convert.ToInt32(tbMaCVInFA.Text), tbTenCVInFA.Text))
            {
                MessageBox.Show("Chức vụ đã tồn tại, Vui lòng nhập mã khác!");
                tbTenCVInFA.Text = null;
                tbMaCVInFA.Text = null;
                return;
            }
            else
            {
                if (String.IsNullOrWhiteSpace(tbMaCVInFA.Text))
                {
                    MessageBox.Show("Bạn cần nhập mã chức vụ trước khi thêm!", "Thông báo", MessageBoxButtons.OK);
                    return;
                }
                if (String.IsNullOrWhiteSpace(tbTenCVInFA.Text))
                {
                    MessageBox.Show("Bạn cần nhập tên chức vụ trước khi thêm!", "Thông báo", MessageBoxButtons.OK);
                    return;
                }
            }

            int macv = Convert.ToInt16(tbMaCVInFA.Text);
            string tencv = tbTenCVInFA.Text;


            if(PositionDAO.Instance.insertPosition(macv, tencv))
                MessageBox.Show("Thêm chức vụ thành công!", "Thông báo" ,MessageBoxButtons.OK);
            else
            {
                MessageBox.Show("Thêm chức vụ thất bại!", "Thông báo", MessageBoxButtons.OK);
                return;
            }
            this.Close();
        }
        #endregion
    }
}
