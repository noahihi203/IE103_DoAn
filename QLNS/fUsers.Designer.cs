using System.Drawing.Printing;
using System.Drawing;
using System.Windows.Forms;
namespace QLNS
{
    partial class fUsers
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            tbTenDangNhap = new TextBox();
            tbMatKhau = new TextBox();
            cbbLoaiTaiKhoan = new ComboBox();
            btSua = new Button();
            btThoat = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(21, 32);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(133, 21);
            label1.TabIndex = 0;
            label1.Text = "Tên tài khoản:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(21, 91);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(95, 21);
            label2.TabIndex = 1;
            label2.Text = "Mật khẩu:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(21, 153);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(138, 21);
            label3.TabIndex = 2;
            label3.Text = "Loại tài khoản:";
            // 
            // tbTenDangNhap
            // 
            tbTenDangNhap.BackColor = Color.FromArgb(255, 224, 192);
            tbTenDangNhap.Location = new Point(178, 32);
            tbTenDangNhap.Name = "tbTenDangNhap";
            tbTenDangNhap.ReadOnly = true;
            tbTenDangNhap.Size = new Size(216, 28);
            tbTenDangNhap.TabIndex = 3;
           // tbTenDangNhap.TextChanged += tbTenDangNhap_TextChanged;
            // 
            // tbMatKhau
            // 
            tbMatKhau.BackColor = Color.FromArgb(255, 224, 192);
            tbMatKhau.Location = new Point(178, 91);
            tbMatKhau.Name = "tbMatKhau";
            tbMatKhau.Size = new Size(216, 28);
            tbMatKhau.TabIndex = 4;
            // 
            // cbbLoaiTaiKhoan
            // 
            cbbLoaiTaiKhoan.BackColor = Color.FromArgb(255, 224, 192);
            cbbLoaiTaiKhoan.Font = new Font("Arial", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cbbLoaiTaiKhoan.FormattingEnabled = true;
            cbbLoaiTaiKhoan.Location = new Point(178, 153);
            cbbLoaiTaiKhoan.Name = "cbbLoaiTaiKhoan";
            cbbLoaiTaiKhoan.Size = new Size(216, 29);
            cbbLoaiTaiKhoan.TabIndex = 5;
            // 
            // btSua
            // 
            btSua.BackColor = Color.FromArgb(255, 255, 192);
            btSua.FlatStyle = FlatStyle.Popup;
            btSua.Location = new Point(217, 237);
            btSua.Name = "btSua";
            btSua.Size = new Size(74, 38);
            btSua.TabIndex = 9;
            btSua.Text = "Sửa";
            btSua.UseVisualStyleBackColor = false;
            btSua.Click += btSua_Click;
            // 
            // btThoat
            // 
            btThoat.BackColor = Color.FromArgb(255, 255, 192);
            btThoat.FlatStyle = FlatStyle.Popup;
            btThoat.Location = new Point(297, 237);
            btThoat.Name = "btThoat";
            btThoat.Size = new Size(83, 38);
            btThoat.TabIndex = 10;
            btThoat.Text = "Thoát";
            btThoat.UseVisualStyleBackColor = false;
            btThoat.Click += btThoat_Click;
            // 
            // fUsers
            // 
            AutoScaleDimensions = new SizeF(11F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(192, 255, 192);
            ClientSize = new Size(425, 319);
            Controls.Add(btThoat);
            Controls.Add(btSua);
            Controls.Add(cbbLoaiTaiKhoan);
            Controls.Add(tbMatKhau);
            Controls.Add(tbTenDangNhap);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("Arial", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4, 3, 4, 3);
            Name = "fUsers";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "User";
            Load += fUsers_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox tbTenDangNhap;
        private TextBox tbMatKhau;
        private ComboBox cbbLoaiTaiKhoan;
        private Button btSua;
        private Button btThoat;
    }
}