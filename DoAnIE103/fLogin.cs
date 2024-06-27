using DoAnIE103.DAO;
using DoAnIE103.DTO;
using System.Data;
using System.Security.Cryptography;
using System.Text;

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
            if (UserDAO.Instance.checkUserName(username))
            {
                if (ValidatePassword(username, password))
                    return true;
            }

            return false;
        }

        public bool ValidatePassword(string username, string inputPassword)
        {
            // 
            string storedHashPassword = UserDAO.Instance.GetStoredHashPassword(username);

            if (storedHashPassword == null)
            {
                return false; // 
            }

            //
            string hashedInputPassword = GetHash(inputPassword);

            // 
            return hashedInputPassword.Equals(storedHashPassword);
        }

        public static string GetHash(string input)
        {

            string query = string.Format("SELECT CONVERT(VARCHAR(40), HASHBYTES('SHA1', CAST('{0}' AS NVARCHAR(4000))), 2) AS MATKHAUSAUHASH", input);
            DataTable dataTable = new DataTable();
            dataTable = DataProvider.Instance.executeQuery(query);

            DataRow dataRow = dataTable.Rows[0];
            string hash = dataRow["MATKHAUSAUHASH"].ToString();
            return hash;
        }

        private void btDangNhap_Click_1(object sender, EventArgs e)
        {

            string username = tbTenDangNhap.Text;
            string password = tbMatKhau.Text;
            Const.userID = tbTenDangNhap.Text; //ten dang nhap
            Const.passWord = tbMatKhau.Text; //mat khau
            //Const.PositionId = UserDAO.Instance.checkRole(tbTenDangNhap.Text); //ma chuc vu

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

        private void btThoat_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void flogin_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void checkBox1_CheckedChanged_1(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
                tbMatKhau.UseSystemPasswordChar = false;

            if (!checkBox1.Checked)
                tbMatKhau.UseSystemPasswordChar = true;
        }


    }
}
