using DoAnIE103.DAO;
using DoAnIE103.DTO;
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
    public partial class fUsers : Form
    {
        BindingSource taiKhoanList = new BindingSource();

        int index = -1;
        public fUsers()
        {
            InitializeComponent();
        }

        #region method

        private void fUsers_Load(object sender, EventArgs e)
        {
            dtgvUsers.DataSource = taiKhoanList;
            loadListUser();
            loadLoaiTaiKhoanIntoCBB(cbbLoaiTaiKhoan);
            addUserBinding();
        }
        void loadListUser()
        {
            dtgvUsers.DataSource = null;
            DataTable data = DataProvider.Instance.executeQuery("SELECT * FROM TAIKHOAN");
            taiKhoanList.DataSource = data;

            dtgvUsers.DataSource = taiKhoanList;
            dtgvUsers.Columns["MACV"].Visible = false;
            
            dtgvUsers.Refresh();
        }

        void loadLoaiTaiKhoanIntoCBB(ComboBox cb)
        {
            cb.DataSource = PositionDAO.Instance.getPositionList();
            cb.DisplayMember = "TENCV";
            cb.ValueMember = "MACV";
            //DoAnIE103.DTO.LoaiTaiKhoan
        }

        void addUserBinding()
        {
            tbTenDangNhap.DataBindings.Add(new Binding("Text", dtgvUsers.DataSource, "TENDANGNHAP", true, DataSourceUpdateMode.Never));
            tbMatKhau.DataBindings.Add(new Binding("Text", dtgvUsers.DataSource, "MATKHAU", true, DataSourceUpdateMode.Never));

        }
        #endregion

        #region event
        private void btThem_Click(object sender, EventArgs e) // bt Thêm nhân viên
        {
            string tenDangNhap = tbTenDangNhap.Text;
            string matKhau = tbMatKhau.Text;
            int maloaiTaiKhoan = (int)(cbbLoaiTaiKhoan.SelectedItem as Position).MaCV;


            if (tenDangNhap == "" || matKhau == "")
            {
                MessageBox.Show("Bạn phải nhập tài khoản và mật khẩu trước khi thêm!", "Cảnh báo", MessageBoxButtons.OK);
                return;
            }

            if (UserDAO.Instance.InsertUser(tenDangNhap, matKhau, maloaiTaiKhoan))
            {
                MessageBox.Show("Thêm tài khoản thành công!");
                loadListUser();
            }
            else
            {
                MessageBox.Show("Có lỗi khi thêm tài khoản!");
                return;
            }
        }

        private void btSua_Click(object sender, EventArgs e) // bt Sửa nhân viên
        {
            string tenDangNhap = tbTenDangNhap.Text;
            string matKhau = tbMatKhau.Text;
            int maloaiTaiKhoan = (int)(cbbLoaiTaiKhoan.SelectedItem as Position).MaCV;


            if (UserDAO.Instance.UpdateUser(tenDangNhap, matKhau, maloaiTaiKhoan))
            {
                MessageBox.Show("Sửa tài khoản thành công!");
                loadListUser();
            }
            else
            {
                MessageBox.Show("Có lỗi khi sửa tài khoản!");
                return;
            }
        }
        private void btXoa_Click(object sender, EventArgs e)
        {
            string tenDangNhap = tbTenDangNhap.Text;



            if (UserDAO.Instance.DeleteUser(tenDangNhap))
            {
                MessageBox.Show("Xoá tài khoản thành công!");
                loadListUser();
            }
            else
            {
                MessageBox.Show("Có lỗi khi xoá tài khoản!");
                return;
            }
        }

        private void tbTenDangNhap_TextChanged(object sender, EventArgs e)
        {
            if (dtgvUsers.SelectedCells.Count > 0)
            {
                int id = (int)dtgvUsers.SelectedCells[0].OwningRow.Cells["MACV"].Value;

                Position loaitk = PositionDAO.Instance.getPositionByMaCV(id);

                cbbLoaiTaiKhoan.SelectedItem = loaitk;

                int index = -1;
                int i = 0;
                foreach (Position item in cbbLoaiTaiKhoan.Items)
                {
                    if (item.MaCV == loaitk.MaCV)
                    {
                        index = i;
                        break;
                    }
                    i++;
                }

                cbbLoaiTaiKhoan.SelectedIndex = index;
            }
        }



        private void btThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void dtgvUsers_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            /*            if (index < 0)
                            return;

                        index = e.RowIndex;

                        tbTenDangNhap.Text = dtgvUsers.Rows[index].Cells[0].Value.ToString();
                        tbMatKhau.Text = dtgvUsers.Rows[index].Cells[1].Value.ToString();
                        if (dtgvUsers.Rows[index].Cells[0].ColumnIndex == 1)
                            cbbLoaiTaiKhoan.Text = "Quản lý";
                        else
                            cbbLoaiTaiKhoan.Text = "Nhân viên";*/
        }
        #endregion



    }
}
