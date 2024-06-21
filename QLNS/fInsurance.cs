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
    public partial class fInsurance : Form
    {
        public fInsurance()
        {
            InitializeComponent();
        }

        private void fInsurance_Load(object sender, EventArgs e)
        {
            dtgvInsurance.DataSource = InsuranceDAO.Instance.getInsuranceList();
        }

        private void btExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
