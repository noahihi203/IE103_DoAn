namespace DoAnIE103
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
            dtgvUsers = new DataGridView();
            btThem = new Button();
            btXoa = new Button();
            btSua = new Button();
            btThoat = new Button();
            ((System.ComponentModel.ISupportInitialize)dtgvUsers).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(16, 49);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(133, 21);
            label1.TabIndex = 0;
            label1.Text = "Tên tài khoản:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(16, 113);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(95, 21);
            label2.TabIndex = 1;
            label2.Text = "Mật khẩu:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(16, 175);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(138, 21);
            label3.TabIndex = 2;
            label3.Text = "Loại tài khoản:";
            // 
            // tbTenDangNhap
            // 
            tbTenDangNhap.Location = new Point(173, 49);
            tbTenDangNhap.Name = "tbTenDangNhap";
            tbTenDangNhap.Size = new Size(216, 28);
            tbTenDangNhap.TabIndex = 3;
            tbTenDangNhap.TextChanged += tbTenDangNhap_TextChanged;
            // 
            // tbMatKhau
            // 
            tbMatKhau.Location = new Point(173, 113);
            tbMatKhau.Name = "tbMatKhau";
            tbMatKhau.Size = new Size(216, 28);
            tbMatKhau.TabIndex = 4;
            // 
            // cbbLoaiTaiKhoan
            // 
            cbbLoaiTaiKhoan.Font = new Font("Arial", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cbbLoaiTaiKhoan.FormattingEnabled = true;
            cbbLoaiTaiKhoan.Location = new Point(173, 175);
            cbbLoaiTaiKhoan.Name = "cbbLoaiTaiKhoan";
            cbbLoaiTaiKhoan.Size = new Size(216, 29);
            cbbLoaiTaiKhoan.TabIndex = 5;
            // 
            // dtgvUsers
            // 
            dtgvUsers.BackgroundColor = SystemColors.ButtonFace;
            dtgvUsers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgvUsers.Location = new Point(418, 49);
            dtgvUsers.MultiSelect = false;
            dtgvUsers.Name = "dtgvUsers";
            dtgvUsers.ReadOnly = true;
            dtgvUsers.RowHeadersWidth = 51;
            dtgvUsers.SelectionMode = DataGridViewSelectionMode.CellSelect;
            dtgvUsers.Size = new Size(398, 398);
            dtgvUsers.TabIndex = 6;
            dtgvUsers.CellClick += dtgvUsers_CellClick;
            // 
            // btThem
            // 
            btThem.Location = new Point(64, 236);
            btThem.Name = "btThem";
            btThem.Size = new Size(74, 65);
            btThem.TabIndex = 7;
            btThem.Text = "Thêm";
            btThem.UseVisualStyleBackColor = true;
            btThem.Click += btThem_Click;
            // 
            // btXoa
            // 
            btXoa.Location = new Point(173, 236);
            btXoa.Name = "btXoa";
            btXoa.Size = new Size(74, 65);
            btXoa.TabIndex = 8;
            btXoa.Text = "Xoá";
            btXoa.UseVisualStyleBackColor = true;
            btXoa.Click += btXoa_Click;
            // 
            // btSua
            // 
            btSua.Location = new Point(279, 236);
            btSua.Name = "btSua";
            btSua.Size = new Size(74, 65);
            btSua.TabIndex = 9;
            btSua.Text = "Sửa";
            btSua.UseVisualStyleBackColor = true;
            btSua.Click += btSua_Click;
            // 
            // btThoat
            // 
            btThoat.Location = new Point(279, 382);
            btThoat.Name = "btThoat";
            btThoat.Size = new Size(83, 65);
            btThoat.TabIndex = 10;
            btThoat.Text = "Thoát";
            btThoat.UseVisualStyleBackColor = true;
            btThoat.Click += btThoat_Click;
            // 
            // fUsers
            // 
            AutoScaleDimensions = new SizeF(11F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(828, 472);
            Controls.Add(btThoat);
            Controls.Add(btSua);
            Controls.Add(btXoa);
            Controls.Add(btThem);
            Controls.Add(dtgvUsers);
            Controls.Add(cbbLoaiTaiKhoan);
            Controls.Add(tbMatKhau);
            Controls.Add(tbTenDangNhap);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("Arial", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Margin = new Padding(4, 3, 4, 3);
            Name = "fUsers";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "User";
            Load += fUsers_Load;
            ((System.ComponentModel.ISupportInitialize)dtgvUsers).EndInit();
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
        private DataGridView dtgvUsers;
        private Button btThem;
        private Button btXoa;
        private Button btSua;
        private Button btThoat;
    }
}