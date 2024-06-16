using DoAnIE103.DAO;
using DoAnIE103.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoAnIE103
{
    public partial class fUsers : Form
    {
        BindingSource taiKhoanList = new BindingSource();

        int index = -1;
        public fUsers()
        {
            InitializeComponent();
            //loadListUser();
        }

        #region method

        private void fUsers_Load(object sender, EventArgs e)
        {
            loadListUser();
        }
        void loadListUser()
        {
            DataRow data = UserDAO.Instance.getTenCVvaMaCVbyTenDangNhap(Const.userID);

            tbTenDangNhap.Text = (data["TENDANGNHAP"].ToString());
            tbMatKhau.Text = Const.passWord;
            
            cbbLoaiTaiKhoan.DisplayMember = "TENCV";
            cbbLoaiTaiKhoan.ValueMember = "MACV";
            cbbLoaiTaiKhoan.DataSource = data.Table;
            cbbLoaiTaiKhoan.Enabled = false;
        }

        #endregion

        #region event
        public static string GetHash(string input)
        {
            string query = string.Format("SELECT CONVERT(VARCHAR(40), HASHBYTES('SHA1', CAST('{0}' AS NVARCHAR(4000))), 2) AS MATKHAUSAUHASH", input);
            DataTable dataTable = new DataTable();
            dataTable = DataProvider.Instance.executeQuery(query);

            DataRow dataRow = dataTable.Rows[0];
            string hash = dataRow["MATKHAUSAUHASH"].ToString();
            return hash;
        }

        private void btSua_Click(object sender, EventArgs e) // bt Sửa nhân viên
        {
            string tenDangNhap = tbTenDangNhap.Text;
            string matKhau = GetHash(tbMatKhau.Text.ToString());
            //int maloaiTaiKhoan = Convert.ToInt32(cbbLoaiTaiKhoan.ValueMember[0]);


            if (UserDAO.Instance.UpdateUser(tenDangNhap, matKhau))
            {
                MessageBox.Show("Sửa tài khoản thành công!");
                Const.passWord = tbMatKhau.Text.ToString();
            }
            else
            {
                MessageBox.Show("Có lỗi khi sửa tài khoản!");
                return;
            }
            loadListUser();
        }

        private void btThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        #endregion
    }
}
