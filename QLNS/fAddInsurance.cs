using QLNS.DAO;
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
    public partial class fAddInsurance : Form
    {
        public fAddInsurance()
        {
            InitializeComponent();
        }

        private void btHUY_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btTHEM_Click(object sender, EventArgs e)
        {
            int mabh = Convert.ToInt32(tbMABH.Text);
            string sobh = tbSOBH.Text.ToString();
            string ngaycap = dtpNGAYCAP.Value.Date.ToString("yyyy-MM-dd");
            string noicap = tbNOICAP.Text.ToString();
            string noikhambenh = tbNOIKHAMBENH.Text.ToString();
            int manv = Convert.ToInt32(tbMANV.Text);

            if (InsuranceDAO.Instance.InsertInsurance(mabh, sobh, ngaycap, noicap, noikhambenh, manv))
            {
                MessageBox.Show("Thêm bảo hiểm thành công!", "Thông báo");
                tbMABH.Text = string.Empty;
                tbSOBH.Text = string.Empty;
                tbNOIKHAMBENH.Text = string.Empty;
                tbNOICAP.Text = string.Empty;
                tbMANV.Text = string.Empty;
                dtpNGAYCAP.Text = string.Empty;
            }    
            else
            {
                MessageBox.Show("Thêm bảo hiểm thất bại!", "Thông báo");
                return;

            }
        }
    }
}
