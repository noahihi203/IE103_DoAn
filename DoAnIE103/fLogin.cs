using DoAnIE103.DAO;
using DoAnIE103.DTO;
using System.Data;

namespace DoAnIE103
{
    public partial class flogin : Form
    {
        public flogin()
        {
            InitializeComponent();
        }

        bool CheckLogin(string username, string password)
        {
            return UserDAO.Instance.login(username, password);
        }

        private void btDangNhap_Click(object sender, EventArgs e)
        {

            string username = tbTenDangNhap.Text;
            string password = tbMatKhau.Text;


            if (CheckLogin(username, password)) // Check if the entered password account is correct
            {
                if (UserDAO.Instance.checkRole(username) != 4) // decentralization
                    Const.userType = 1;
                else
                {
                    Const.userType = 0;
                }
                fMain f = new fMain();
                f.Show();
                this.Hide();
                f.Logout += F_Logout;
            }
            else
            {
                MessageBox.Show("Ban da nhap sai ten dang nhap hoac mat khau!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

        }

        private void F_Logout(object sender, EventArgs e)
        {
            (sender as fMain).isExit = false;
            (sender as fMain).Close();
            this.Show();
        }

        private void btThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void flogin_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
                tbMatKhau.UseSystemPasswordChar = false;

            if (!checkBox1.Checked)
                tbMatKhau.UseSystemPasswordChar = true;
        }

        private void flogin_Enter(object sender, EventArgs e)
        {
        }

        private void tbMatKhau_Enter(object sender, EventArgs e)
        {

        }
    }
}
