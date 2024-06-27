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
            tsbDelete.Visible = false;
            tsbEdit.Visible = false;
        }

        private void btExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tsbAdd_Click(object sender, EventArgs e)
        {
            fAddInsurance f = new fAddInsurance();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }

        private void tsbDelete_Click(object sender, EventArgs e)
        {

        }

        private void tsbEdit_Click(object sender, EventArgs e)
        {

        }

    }
}
