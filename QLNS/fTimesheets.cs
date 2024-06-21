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
    public partial class fTimesheets : Form
    {
        public fTimesheets()
        {
            InitializeComponent();
        }

        private void fTimesheets_Load(object sender, EventArgs e)
        {
            dtgvTimesheet.DataSource = TimesheetsDAO.Instance.getDanhSachBangCong(Const.EmployeeId);
        }

        private void btExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btExit_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
