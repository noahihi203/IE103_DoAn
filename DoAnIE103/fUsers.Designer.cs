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
            TENDANGNHAP = new DataGridViewTextBoxColumn();
            MATKHAU = new DataGridViewTextBoxColumn();
            btSua = new Button();
            btThoat = new Button();
            ((System.ComponentModel.ISupportInitialize)dtgvUsers).BeginInit();
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
            tbTenDangNhap.Location = new Point(178, 32);
            tbTenDangNhap.Name = "tbTenDangNhap";
            tbTenDangNhap.ReadOnly = true;
            tbTenDangNhap.Size = new Size(216, 28);
            tbTenDangNhap.TabIndex = 3;
            tbTenDangNhap.TextChanged += tbTenDangNhap_TextChanged;
            // 
            // tbMatKhau
            // 
            tbMatKhau.Location = new Point(178, 91);
            tbMatKhau.Name = "tbMatKhau";
            tbMatKhau.Size = new Size(216, 28);
            tbMatKhau.TabIndex = 4;
            // 
            // cbbLoaiTaiKhoan
            // 
            cbbLoaiTaiKhoan.Font = new Font("Arial", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cbbLoaiTaiKhoan.FormattingEnabled = true;
            cbbLoaiTaiKhoan.Location = new Point(178, 153);
            cbbLoaiTaiKhoan.Name = "cbbLoaiTaiKhoan";
            cbbLoaiTaiKhoan.Size = new Size(216, 29);
            cbbLoaiTaiKhoan.TabIndex = 5;
            // 
            // dtgvUsers
            // 
            dtgvUsers.AllowUserToAddRows = false;
            dtgvUsers.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dtgvUsers.BackgroundColor = SystemColors.ButtonFace;
            dtgvUsers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgvUsers.Columns.AddRange(new DataGridViewColumn[] { TENDANGNHAP, MATKHAU });
            dtgvUsers.Location = new Point(21, 205);
            dtgvUsers.MultiSelect = false;
            dtgvUsers.Name = "dtgvUsers";
            dtgvUsers.ReadOnly = true;
            dtgvUsers.RowHeadersVisible = false;
            dtgvUsers.RowHeadersWidth = 51;
            dtgvUsers.SelectionMode = DataGridViewSelectionMode.CellSelect;
            dtgvUsers.Size = new Size(383, 77);
            dtgvUsers.TabIndex = 6;
            dtgvUsers.CellClick += dtgvUsers_CellClick;
            // 
            // TENDANGNHAP
            // 
            TENDANGNHAP.DataPropertyName = "TENDANGNHAP";
            TENDANGNHAP.HeaderText = "Tên đăng nhập";
            TENDANGNHAP.MinimumWidth = 6;
            TENDANGNHAP.Name = "TENDANGNHAP";
            TENDANGNHAP.ReadOnly = true;
            // 
            // MATKHAU
            // 
            MATKHAU.DataPropertyName = "MATKHAU";
            MATKHAU.HeaderText = "Mật khẩu";
            MATKHAU.MinimumWidth = 6;
            MATKHAU.Name = "MATKHAU";
            MATKHAU.ReadOnly = true;
            // 
            // btSua
            // 
            btSua.Location = new Point(214, 302);
            btSua.Name = "btSua";
            btSua.Size = new Size(74, 38);
            btSua.TabIndex = 9;
            btSua.Text = "Sửa";
            btSua.UseVisualStyleBackColor = true;
            btSua.Click += btSua_Click;
            // 
            // btThoat
            // 
            btThoat.Location = new Point(294, 302);
            btThoat.Name = "btThoat";
            btThoat.Size = new Size(83, 38);
            btThoat.TabIndex = 10;
            btThoat.Text = "Thoát";
            btThoat.UseVisualStyleBackColor = true;
            btThoat.Click += btThoat_Click;
            // 
            // fUsers
            // 
            AutoScaleDimensions = new SizeF(11F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(425, 365);
            Controls.Add(btThoat);
            Controls.Add(btSua);
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
        private Button btSua;
        private Button btThoat;
        private DataGridViewTextBoxColumn TENDANGNHAP;
        private DataGridViewTextBoxColumn MATKHAU;
    }
}