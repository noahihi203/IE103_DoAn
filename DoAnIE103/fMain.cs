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
    public partial class fMain : Form
    {
        public bool isExit = true;

        public event EventHandler Logout;
        public fMain()
        {
            InitializeComponent();
        }


        #region Method
        void Decentralization()
        {
            if (Const.userType == 0)
            {
                tsmiUser.Enabled = tsmiEmployee.Enabled = tsmiPhongBan.Enabled = tsmiChucVu.Enabled = false;
            }

        }

        #endregion

        #region Event
        private void fMain_Load(object sender, EventArgs e)
        {
            //tsbAdd.Enabled = tsbDelete.Enabled = tsbEdit.Enabled = tsbPrint.Enabled = false;
            Decentralization();
        }
        private void fMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (isExit)
            {
                if (MessageBox.Show("Bạn có muốn thoát chương trình", "Cảnh báo", MessageBoxButtons.YesNo) != DialogResult.Yes)
                    e.Cancel = true;
            }
        }
        private void fMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (isExit)
                Application.Exit();
        }

        private void đăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Logout(this, new EventArgs());
        }


        private void tsmiEmployee_Click(object sender, EventArgs e)
        {
            fEmployee f = new fEmployee();
            f.ShowDialog();

        }

        private void quảnLýToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Const.userType == 0)
                MessageBox.Show("Bạn không phải admin!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void tsmiUser_Click(object sender, EventArgs e)
        {
            fUsers f = new fUsers();
            f.ShowDialog();
        }

        private void tsmiPhongBan_Click(object sender, EventArgs e)
        {
            fDepartment f = new fDepartment();
            f.ShowDialog();
        }

        #endregion




        private void toolStripButton1_Click(object sender, EventArgs e)
        {

        }

        private void tsmiChucVu_Click(object sender, EventArgs e)
        {
            fPosition f = new fPosition();
            f.ShowDialog();
        }
    }

}
