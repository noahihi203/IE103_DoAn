namespace DoAnIE103
{
    partial class fAddNewEmployee
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
            groupBox1 = new GroupBox();
            btAHuy = new Button();
            tableLayoutPanel1 = new TableLayoutPanel();
            tbACCCD = new TextBox();
            cbbAEChucVu = new ComboBox();
            label5 = new Label();
            label1 = new Label();
            cbbAEPhongBan = new ComboBox();
            label4 = new Label();
            tbAHoTen = new TextBox();
            label12 = new Label();
            dtpANgayNhanLuong = new DateTimePicker();
            label9 = new Label();
            label7 = new Label();
            label6 = new Label();
            tbADiaChi = new TextBox();
            tbAMaNV = new TextBox();
            label3 = new Label();
            dtpANgaySinh = new DateTimePicker();
            label2 = new Label();
            cbAGioiTinh = new ComboBox();
            tbASDT = new TextBox();
            label11 = new Label();
            btAThem = new Button();
            groupBox1.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btAHuy);
            groupBox1.Controls.Add(tableLayoutPanel1);
            groupBox1.Controls.Add(btAThem);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(776, 271);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thông tin nhân viên sẽ thêm vào";
            // 
            // btAHuy
            // 
            btAHuy.Location = new Point(638, 220);
            btAHuy.Name = "btAHuy";
            btAHuy.Size = new Size(94, 29);
            btAHuy.TabIndex = 12;
            btAHuy.Text = "Huỷ";
            btAHuy.UseVisualStyleBackColor = true;
            btAHuy.Click += btAHuy_Click;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 4;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel1.Controls.Add(tbACCCD, 1, 3);
            tableLayoutPanel1.Controls.Add(cbbAEChucVu, 3, 3);
            tableLayoutPanel1.Controls.Add(label5, 0, 3);
            tableLayoutPanel1.Controls.Add(label1, 0, 0);
            tableLayoutPanel1.Controls.Add(cbbAEPhongBan, 3, 2);
            tableLayoutPanel1.Controls.Add(label4, 0, 2);
            tableLayoutPanel1.Controls.Add(tbAHoTen, 1, 0);
            tableLayoutPanel1.Controls.Add(label12, 2, 3);
            tableLayoutPanel1.Controls.Add(dtpANgayNhanLuong, 3, 4);
            tableLayoutPanel1.Controls.Add(label9, 2, 2);
            tableLayoutPanel1.Controls.Add(label7, 2, 4);
            tableLayoutPanel1.Controls.Add(label6, 0, 4);
            tableLayoutPanel1.Controls.Add(tbADiaChi, 1, 4);
            tableLayoutPanel1.Controls.Add(tbAMaNV, 3, 0);
            tableLayoutPanel1.Controls.Add(label3, 2, 1);
            tableLayoutPanel1.Controls.Add(dtpANgaySinh, 3, 1);
            tableLayoutPanel1.Controls.Add(label2, 0, 1);
            tableLayoutPanel1.Controls.Add(cbAGioiTinh, 1, 1);
            tableLayoutPanel1.Controls.Add(tbASDT, 1, 2);
            tableLayoutPanel1.Controls.Add(label11, 2, 0);
            tableLayoutPanel1.Location = new Point(6, 26);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 5;
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.Size = new Size(764, 171);
            tableLayoutPanel1.TabIndex = 13;
            // 
            // tbACCCD
            // 
            tbACCCD.Anchor = AnchorStyles.Left;
            tbACCCD.Location = new Point(180, 104);
            tbACCCD.Name = "tbACCCD";
            tbACCCD.Size = new Size(138, 27);
            tbACCCD.TabIndex = 10;
            // 
            // cbbAEChucVu
            // 
            cbbAEChucVu.Anchor = AnchorStyles.Left;
            cbbAEChucVu.FormattingEnabled = true;
            cbbAEChucVu.Location = new Point(564, 104);
            cbbAEChucVu.Name = "cbbAEChucVu";
            cbbAEChucVu.Size = new Size(149, 28);
            cbbAEChucVu.TabIndex = 13;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Left;
            label5.AutoSize = true;
            label5.Font = new Font("Arial", 10.2F, FontStyle.Bold);
            label5.Location = new Point(3, 108);
            label5.Name = "label5";
            label5.Size = new Size(171, 19);
            label5.TabIndex = 4;
            label5.Text = "Căn cước công dân:";
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Left;
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 10.2F, FontStyle.Bold);
            label1.Location = new Point(3, 7);
            label1.Name = "label1";
            label1.Size = new Size(90, 19);
            label1.TabIndex = 0;
            label1.Text = "Họ và tên:";
            // 
            // cbbAEPhongBan
            // 
            cbbAEPhongBan.Anchor = AnchorStyles.Left;
            cbbAEPhongBan.FormattingEnabled = true;
            cbbAEPhongBan.Location = new Point(564, 70);
            cbbAEPhongBan.Name = "cbbAEPhongBan";
            cbbAEPhongBan.Size = new Size(149, 28);
            cbbAEPhongBan.TabIndex = 12;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Left;
            label4.AutoSize = true;
            label4.Font = new Font("Arial", 10.2F, FontStyle.Bold);
            label4.Location = new Point(3, 74);
            label4.Name = "label4";
            label4.Size = new Size(118, 19);
            label4.TabIndex = 3;
            label4.Text = "Số điện thoại:";
            // 
            // tbAHoTen
            // 
            tbAHoTen.Anchor = AnchorStyles.Left;
            tbAHoTen.Location = new Point(180, 3);
            tbAHoTen.Name = "tbAHoTen";
            tbAHoTen.Size = new Size(212, 27);
            tbAHoTen.TabIndex = 1;
            // 
            // label12
            // 
            label12.Anchor = AnchorStyles.Left;
            label12.AutoSize = true;
            label12.Font = new Font("Arial", 10.2F, FontStyle.Bold);
            label12.Location = new Point(406, 108);
            label12.Name = "label12";
            label12.Size = new Size(82, 19);
            label12.TabIndex = 11;
            label12.Text = "Chức vụ:";
            // 
            // dtpANgayNhanLuong
            // 
            dtpANgayNhanLuong.Anchor = AnchorStyles.Left;
            dtpANgayNhanLuong.CustomFormat = "dd/MM/yyyy";
            dtpANgayNhanLuong.Format = DateTimePickerFormat.Custom;
            dtpANgayNhanLuong.Location = new Point(564, 139);
            dtpANgayNhanLuong.Name = "dtpANgayNhanLuong";
            dtpANgayNhanLuong.Size = new Size(108, 27);
            dtpANgayNhanLuong.TabIndex = 3;
            // 
            // label9
            // 
            label9.Anchor = AnchorStyles.Left;
            label9.AutoSize = true;
            label9.Font = new Font("Arial", 10.2F, FontStyle.Bold);
            label9.Location = new Point(406, 74);
            label9.Name = "label9";
            label9.Size = new Size(100, 19);
            label9.TabIndex = 8;
            label9.Text = "Phòng ban:";
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.Left;
            label7.AutoSize = true;
            label7.Font = new Font("Arial", 10.2F, FontStyle.Bold);
            label7.Location = new Point(406, 143);
            label7.Name = "label7";
            label7.Size = new Size(152, 19);
            label7.TabIndex = 6;
            label7.Text = "Ngày nhận lương:";
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.Left;
            label6.AutoSize = true;
            label6.Font = new Font("Arial", 10.2F, FontStyle.Bold);
            label6.Location = new Point(3, 143);
            label6.Name = "label6";
            label6.Size = new Size(68, 19);
            label6.TabIndex = 5;
            label6.Text = "Địa chỉ:";
            // 
            // tbADiaChi
            // 
            tbADiaChi.Anchor = AnchorStyles.Left;
            tbADiaChi.Location = new Point(180, 139);
            tbADiaChi.Name = "tbADiaChi";
            tbADiaChi.Size = new Size(220, 27);
            tbADiaChi.TabIndex = 2;
            // 
            // tbAMaNV
            // 
            tbAMaNV.Anchor = AnchorStyles.Left;
            tbAMaNV.Location = new Point(564, 3);
            tbAMaNV.Name = "tbAMaNV";
            tbAMaNV.Size = new Size(108, 27);
            tbAMaNV.TabIndex = 6;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Left;
            label3.AutoSize = true;
            label3.Font = new Font("Arial", 10.2F, FontStyle.Bold);
            label3.Location = new Point(406, 40);
            label3.Name = "label3";
            label3.Size = new Size(93, 19);
            label3.TabIndex = 2;
            label3.Text = "Ngày sinh:";
            // 
            // dtpANgaySinh
            // 
            dtpANgaySinh.Anchor = AnchorStyles.Left;
            dtpANgaySinh.CustomFormat = "dd/MM/yyyy";
            dtpANgaySinh.Format = DateTimePickerFormat.Custom;
            dtpANgaySinh.Location = new Point(564, 36);
            dtpANgaySinh.Name = "dtpANgaySinh";
            dtpANgaySinh.Size = new Size(108, 27);
            dtpANgaySinh.TabIndex = 3;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Left;
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 10.2F, FontStyle.Bold);
            label2.Location = new Point(3, 40);
            label2.Name = "label2";
            label2.Size = new Size(83, 19);
            label2.TabIndex = 1;
            label2.Text = "Giới tính:";
            // 
            // cbAGioiTinh
            // 
            cbAGioiTinh.Anchor = AnchorStyles.Left;
            cbAGioiTinh.FormattingEnabled = true;
            cbAGioiTinh.Location = new Point(180, 36);
            cbAGioiTinh.Name = "cbAGioiTinh";
            cbAGioiTinh.Size = new Size(138, 28);
            cbAGioiTinh.TabIndex = 4;
            // 
            // tbASDT
            // 
            tbASDT.Anchor = AnchorStyles.Left;
            tbASDT.Location = new Point(180, 70);
            tbASDT.Name = "tbASDT";
            tbASDT.Size = new Size(138, 27);
            tbASDT.TabIndex = 8;
            // 
            // label11
            // 
            label11.Anchor = AnchorStyles.Left;
            label11.AutoSize = true;
            label11.Font = new Font("Arial", 10.2F, FontStyle.Bold);
            label11.Location = new Point(406, 7);
            label11.Name = "label11";
            label11.Size = new Size(118, 19);
            label11.TabIndex = 10;
            label11.Text = "Mã nhân viên:";
            // 
            // btAThem
            // 
            btAThem.Location = new Point(538, 220);
            btAThem.Name = "btAThem";
            btAThem.Size = new Size(94, 29);
            btAThem.TabIndex = 11;
            btAThem.Text = "Thêm";
            btAThem.UseVisualStyleBackColor = true;
            btAThem.Click += btAThem_Click;
            // 
            // fAddNewEmployee
            // 
            AcceptButton = btAThem;
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = btAHuy;
            ClientSize = new Size(800, 293);
            Controls.Add(groupBox1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "fAddNewEmployee";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "fAddNewEmployee";
            FormClosed += fAddNewEmployee_FormClosed;
            //Enter += fAddNewEmployee_Enter;
            groupBox1.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Label label11;
        private Label label9;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox tbADiaChi;
        private TextBox tbACCCD;
        private TextBox tbAHoTen;
        private TextBox tbAMaNV;
        private Label label12;
        private ComboBox cbAGioiTinh;
        private DateTimePicker dtpANgaySinh;
        private DateTimePicker dtpANgayNhanLuong;
        private TextBox tbASDT;
        private Button btAThem;
        private Button btAHuy;
        private TableLayoutPanel tableLayoutPanel1;
        private ComboBox cbbAEChucVu;
        private ComboBox cbbAEPhongBan;
    }
}