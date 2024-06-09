namespace DoAnIE103
{
    partial class fMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fMain));
            gbTTNguoiDung = new GroupBox();
            tableLayoutPanel1 = new TableLayoutPanel();
            lbMDiaChi = new Label();
            dtpMNgaySinh = new DateTimePicker();
            label7 = new Label();
            lbMPhongBan = new Label();
            lbMCCCD = new Label();
            label9 = new Label();
            lbMChucVu = new Label();
            label1 = new Label();
            lbMGioiTinh = new Label();
            label8 = new Label();
            lbMSDT = new Label();
            label4 = new Label();
            label6 = new Label();
            label5 = new Label();
            label3 = new Label();
            lbMHoTen = new Label();
            hệThốngToolStripMenuItem = new ToolStripMenuItem();
            tsmiUser = new ToolStripMenuItem();
            đăngXuấtToolStripMenuItem = new ToolStripMenuItem();
            quảnLýToolStripMenuItem = new ToolStripMenuItem();
            tsmiEmployee = new ToolStripMenuItem();
            tsmiPhongBan = new ToolStripMenuItem();
            tsmiChucVu = new ToolStripMenuItem();
            thốngKêToolStripMenuItem = new ToolStripMenuItem();
            trợGiúpToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1 = new MenuStrip();
            gbTTLuongNguoiDung = new GroupBox();
            tableLayoutPanel2 = new TableLayoutPanel();
            dtpMNgayNhanLuong = new DateTimePicker();
            label10 = new Label();
            label11 = new Label();
            lbMLuongThang = new Label();
            gbTTNguoiDung.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            menuStrip1.SuspendLayout();
            gbTTLuongNguoiDung.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            SuspendLayout();
            // 
            // gbTTNguoiDung
            // 
            gbTTNguoiDung.BackColor = Color.White;
            gbTTNguoiDung.Controls.Add(tableLayoutPanel1);
            gbTTNguoiDung.Location = new Point(13, 39);
            gbTTNguoiDung.Margin = new Padding(4);
            gbTTNguoiDung.Name = "gbTTNguoiDung";
            gbTTNguoiDung.Padding = new Padding(4);
            gbTTNguoiDung.Size = new Size(922, 401);
            gbTTNguoiDung.TabIndex = 2;
            gbTTNguoiDung.TabStop = false;
            gbTTNguoiDung.Text = "Thông tin người dùng";
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 4;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel1.Controls.Add(lbMDiaChi, 3, 3);
            tableLayoutPanel1.Controls.Add(dtpMNgaySinh, 1, 1);
            tableLayoutPanel1.Controls.Add(label7, 2, 3);
            tableLayoutPanel1.Controls.Add(lbMPhongBan, 3, 2);
            tableLayoutPanel1.Controls.Add(lbMCCCD, 1, 3);
            tableLayoutPanel1.Controls.Add(label9, 2, 2);
            tableLayoutPanel1.Controls.Add(lbMChucVu, 3, 1);
            tableLayoutPanel1.Controls.Add(label1, 0, 0);
            tableLayoutPanel1.Controls.Add(lbMGioiTinh, 3, 0);
            tableLayoutPanel1.Controls.Add(label8, 2, 1);
            tableLayoutPanel1.Controls.Add(lbMSDT, 1, 2);
            tableLayoutPanel1.Controls.Add(label4, 0, 1);
            tableLayoutPanel1.Controls.Add(label6, 0, 3);
            tableLayoutPanel1.Controls.Add(label5, 0, 2);
            tableLayoutPanel1.Controls.Add(label3, 2, 0);
            tableLayoutPanel1.Controls.Add(lbMHoTen, 1, 0);
            tableLayoutPanel1.Location = new Point(7, 34);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 4;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.Size = new Size(908, 360);
            tableLayoutPanel1.TabIndex = 38;
            // 
            // lbMDiaChi
            // 
            lbMDiaChi.Anchor = AnchorStyles.Left;
            lbMDiaChi.AutoSize = true;
            lbMDiaChi.Location = new Point(549, 301);
            lbMDiaChi.Margin = new Padding(4, 0, 4, 0);
            lbMDiaChi.Name = "lbMDiaChi";
            lbMDiaChi.Size = new Size(215, 27);
            lbMDiaChi.TabIndex = 36;
            lbMDiaChi.Text = "Chưa có thông tin";
            // 
            // dtpMNgaySinh
            // 
            dtpMNgaySinh.Anchor = AnchorStyles.Left;
            dtpMNgaySinh.CalendarMonthBackground = Color.Cornsilk;
            dtpMNgaySinh.Checked = false;
            dtpMNgaySinh.CustomFormat = "dd-MM-yyyy";
            dtpMNgaySinh.Enabled = false;
            dtpMNgaySinh.Format = DateTimePickerFormat.Custom;
            dtpMNgaySinh.Location = new Point(178, 118);
            dtpMNgaySinh.Margin = new Padding(4);
            dtpMNgaySinh.Name = "dtpMNgaySinh";
            dtpMNgaySinh.Size = new Size(209, 34);
            dtpMNgaySinh.TabIndex = 37;
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.Left;
            label7.AutoSize = true;
            label7.Location = new Point(401, 301);
            label7.Margin = new Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.Size = new Size(97, 27);
            label7.TabIndex = 15;
            label7.Text = "Địa chỉ:";
            // 
            // lbMPhongBan
            // 
            lbMPhongBan.Anchor = AnchorStyles.Left;
            lbMPhongBan.AutoSize = true;
            lbMPhongBan.Location = new Point(549, 211);
            lbMPhongBan.Margin = new Padding(4, 0, 4, 0);
            lbMPhongBan.Name = "lbMPhongBan";
            lbMPhongBan.Size = new Size(215, 27);
            lbMPhongBan.TabIndex = 34;
            lbMPhongBan.Text = "Chưa có thông tin";
            // 
            // lbMCCCD
            // 
            lbMCCCD.Anchor = AnchorStyles.Left;
            lbMCCCD.AutoSize = true;
            lbMCCCD.Location = new Point(178, 301);
            lbMCCCD.Margin = new Padding(4, 0, 4, 0);
            lbMCCCD.Name = "lbMCCCD";
            lbMCCCD.Size = new Size(215, 27);
            lbMCCCD.TabIndex = 35;
            lbMCCCD.Text = "Chưa có thông tin";
            // 
            // label9
            // 
            label9.Anchor = AnchorStyles.Left;
            label9.AutoSize = true;
            label9.Location = new Point(401, 211);
            label9.Margin = new Padding(4, 0, 4, 0);
            label9.Name = "label9";
            label9.Size = new Size(140, 27);
            label9.TabIndex = 18;
            label9.Text = "Phòng ban:";
            // 
            // lbMChucVu
            // 
            lbMChucVu.Anchor = AnchorStyles.Left;
            lbMChucVu.AutoSize = true;
            lbMChucVu.Location = new Point(549, 121);
            lbMChucVu.Margin = new Padding(4, 0, 4, 0);
            lbMChucVu.Name = "lbMChucVu";
            lbMChucVu.Size = new Size(215, 27);
            lbMChucVu.TabIndex = 32;
            lbMChucVu.Text = "Chưa có thông tin";
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Left;
            label1.AutoSize = true;
            label1.Location = new Point(4, 31);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(124, 27);
            label1.TabIndex = 5;
            label1.Text = "Họ và tên:";
            // 
            // lbMGioiTinh
            // 
            lbMGioiTinh.Anchor = AnchorStyles.Left;
            lbMGioiTinh.AutoSize = true;
            lbMGioiTinh.Location = new Point(549, 31);
            lbMGioiTinh.Margin = new Padding(4, 0, 4, 0);
            lbMGioiTinh.Name = "lbMGioiTinh";
            lbMGioiTinh.Size = new Size(215, 27);
            lbMGioiTinh.TabIndex = 30;
            lbMGioiTinh.Text = "Chưa có thông tin";
            // 
            // label8
            // 
            label8.Anchor = AnchorStyles.Left;
            label8.AutoSize = true;
            label8.Location = new Point(401, 121);
            label8.Margin = new Padding(4, 0, 4, 0);
            label8.Name = "label8";
            label8.Size = new Size(115, 27);
            label8.TabIndex = 17;
            label8.Text = "Chức vụ:";
            // 
            // lbMSDT
            // 
            lbMSDT.Anchor = AnchorStyles.Left;
            lbMSDT.AutoSize = true;
            lbMSDT.Location = new Point(178, 211);
            lbMSDT.Margin = new Padding(4, 0, 4, 0);
            lbMSDT.Name = "lbMSDT";
            lbMSDT.Size = new Size(215, 27);
            lbMSDT.TabIndex = 33;
            lbMSDT.Text = "Chưa có thông tin";
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Left;
            label4.AutoSize = true;
            label4.Location = new Point(4, 121);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(130, 27);
            label4.TabIndex = 8;
            label4.Text = "Ngày sinh:";
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.Left;
            label6.AutoSize = true;
            label6.Location = new Point(4, 301);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(87, 27);
            label6.TabIndex = 28;
            label6.Text = "CCCD:";
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Left;
            label5.AutoSize = true;
            label5.Location = new Point(4, 211);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(166, 27);
            label5.TabIndex = 11;
            label5.Text = "Số điện thoại:";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Left;
            label3.AutoSize = true;
            label3.Location = new Point(401, 31);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(117, 27);
            label3.TabIndex = 7;
            label3.Text = "Giới tính:";
            // 
            // lbMHoTen
            // 
            lbMHoTen.Anchor = AnchorStyles.Left;
            lbMHoTen.AutoSize = true;
            lbMHoTen.Location = new Point(178, 31);
            lbMHoTen.Margin = new Padding(4, 0, 4, 0);
            lbMHoTen.Name = "lbMHoTen";
            lbMHoTen.Size = new Size(215, 27);
            lbMHoTen.TabIndex = 29;
            lbMHoTen.Text = "Chưa có thông tin";
            lbMHoTen.Click += lbMHoTen_Click;
            // 
            // hệThốngToolStripMenuItem
            // 
            hệThốngToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { tsmiUser, đăngXuấtToolStripMenuItem });
            hệThốngToolStripMenuItem.Image = (Image)resources.GetObject("hệThốngToolStripMenuItem.Image");
            hệThốngToolStripMenuItem.Name = "hệThốngToolStripMenuItem";
            hệThốngToolStripMenuItem.Size = new Size(130, 28);
            hệThốngToolStripMenuItem.Text = "Hệ thống";
            // 
            // tsmiUser
            // 
            tsmiUser.Image = (Image)resources.GetObject("tsmiUser.Image");
            tsmiUser.Name = "tsmiUser";
            tsmiUser.Size = new Size(260, 28);
            tsmiUser.Text = "Quản lý tài khoản";
            tsmiUser.Click += tsmiUser_Click;
            // 
            // đăngXuấtToolStripMenuItem
            // 
            đăngXuấtToolStripMenuItem.Image = (Image)resources.GetObject("đăngXuấtToolStripMenuItem.Image");
            đăngXuấtToolStripMenuItem.Name = "đăngXuấtToolStripMenuItem";
            đăngXuấtToolStripMenuItem.Size = new Size(260, 28);
            đăngXuấtToolStripMenuItem.Text = "Đăng xuất";
            đăngXuấtToolStripMenuItem.Click += đăngXuấtToolStripMenuItem_Click;
            // 
            // quảnLýToolStripMenuItem
            // 
            quảnLýToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { tsmiEmployee, tsmiPhongBan, tsmiChucVu });
            quảnLýToolStripMenuItem.Name = "quảnLýToolStripMenuItem";
            quảnLýToolStripMenuItem.Size = new Size(97, 28);
            quảnLýToolStripMenuItem.Text = "Quản lý";
            quảnLýToolStripMenuItem.Click += quảnLýToolStripMenuItem_Click;
            // 
            // tsmiEmployee
            // 
            tsmiEmployee.Name = "tsmiEmployee";
            tsmiEmployee.Size = new Size(274, 28);
            tsmiEmployee.Text = "Quản lý nhân viên";
            tsmiEmployee.Click += tsmiEmployee_Click;
            // 
            // tsmiPhongBan
            // 
            tsmiPhongBan.Name = "tsmiPhongBan";
            tsmiPhongBan.Size = new Size(274, 28);
            tsmiPhongBan.Text = "Quản lý phòng ban";
            tsmiPhongBan.Click += tsmiPhongBan_Click;
            // 
            // tsmiChucVu
            // 
            tsmiChucVu.Name = "tsmiChucVu";
            tsmiChucVu.Size = new Size(274, 28);
            tsmiChucVu.Text = "Quản lý chức vụ";
            tsmiChucVu.Click += tsmiChucVu_Click;
            // 
            // thốngKêToolStripMenuItem
            // 
            thốngKêToolStripMenuItem.Name = "thốngKêToolStripMenuItem";
            thốngKêToolStripMenuItem.Size = new Size(113, 28);
            thốngKêToolStripMenuItem.Text = "Thống kê";
            thốngKêToolStripMenuItem.Click += thốngKêToolStripMenuItem_Click;
            // 
            // trợGiúpToolStripMenuItem
            // 
            trợGiúpToolStripMenuItem.Name = "trợGiúpToolStripMenuItem";
            trợGiúpToolStripMenuItem.Size = new Size(105, 28);
            trợGiúpToolStripMenuItem.Text = "Trợ giúp";
            trợGiúpToolStripMenuItem.Click += trợGiúpToolStripMenuItem_Click;
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = Color.DarkCyan;
            menuStrip1.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            menuStrip1.GripStyle = ToolStripGripStyle.Visible;
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { hệThốngToolStripMenuItem, quảnLýToolStripMenuItem, thốngKêToolStripMenuItem, trợGiúpToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(4, 2, 0, 2);
            menuStrip1.RenderMode = ToolStripRenderMode.System;
            menuStrip1.Size = new Size(948, 32);
            menuStrip1.TabIndex = 4;
            menuStrip1.Text = "menuStrip1";
            // 
            // gbTTLuongNguoiDung
            // 
            gbTTLuongNguoiDung.BackColor = Color.White;
            gbTTLuongNguoiDung.Controls.Add(tableLayoutPanel2);
            gbTTLuongNguoiDung.ForeColor = SystemColors.ActiveCaptionText;
            gbTTLuongNguoiDung.Location = new Point(13, 448);
            gbTTLuongNguoiDung.Margin = new Padding(4);
            gbTTLuongNguoiDung.Name = "gbTTLuongNguoiDung";
            gbTTLuongNguoiDung.Padding = new Padding(4);
            gbTTLuongNguoiDung.Size = new Size(922, 149);
            gbTTLuongNguoiDung.TabIndex = 39;
            gbTTLuongNguoiDung.TabStop = false;
            gbTTLuongNguoiDung.Text = "Thông tin về lương của người dùng";
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 2;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel2.Controls.Add(dtpMNgayNhanLuong, 1, 1);
            tableLayoutPanel2.Controls.Add(label10, 0, 0);
            tableLayoutPanel2.Controls.Add(label11, 0, 1);
            tableLayoutPanel2.Controls.Add(lbMLuongThang, 1, 0);
            tableLayoutPanel2.Location = new Point(7, 34);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 2;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Size = new Size(908, 108);
            tableLayoutPanel2.TabIndex = 0;
            // 
            // dtpMNgayNhanLuong
            // 
            dtpMNgayNhanLuong.Anchor = AnchorStyles.Left;
            dtpMNgayNhanLuong.CalendarMonthBackground = Color.Blue;
            dtpMNgayNhanLuong.CustomFormat = "dd-MM-yyyy";
            dtpMNgayNhanLuong.Enabled = false;
            dtpMNgayNhanLuong.Format = DateTimePickerFormat.Custom;
            dtpMNgayNhanLuong.Location = new Point(178, 64);
            dtpMNgayNhanLuong.Margin = new Padding(4);
            dtpMNgayNhanLuong.Name = "dtpMNgayNhanLuong";
            dtpMNgayNhanLuong.Size = new Size(215, 34);
            dtpMNgayNhanLuong.TabIndex = 44;
            // 
            // label10
            // 
            label10.Anchor = AnchorStyles.Left;
            label10.AutoSize = true;
            label10.Font = new Font("Arial", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label10.Location = new Point(4, 13);
            label10.Margin = new Padding(4, 0, 4, 0);
            label10.Name = "label10";
            label10.Size = new Size(166, 27);
            label10.TabIndex = 41;
            label10.Text = "Lương tháng:";
            // 
            // label11
            // 
            label11.Anchor = AnchorStyles.Left;
            label11.AutoSize = true;
            label11.Location = new Point(4, 67);
            label11.Margin = new Padding(4, 0, 4, 0);
            label11.Name = "label11";
            label11.Size = new Size(138, 27);
            label11.TabIndex = 42;
            label11.Text = "Ngày nhận:";
            // 
            // lbMLuongThang
            // 
            lbMLuongThang.Anchor = AnchorStyles.Left;
            lbMLuongThang.AutoSize = true;
            lbMLuongThang.Location = new Point(178, 13);
            lbMLuongThang.Margin = new Padding(4, 0, 4, 0);
            lbMLuongThang.Name = "lbMLuongThang";
            lbMLuongThang.Size = new Size(215, 27);
            lbMLuongThang.TabIndex = 43;
            lbMLuongThang.Text = "Chưa có thông tin";
            // 
            // fMain
            // 
            AutoScaleDimensions = new SizeF(14F, 27F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(948, 610);
            Controls.Add(gbTTLuongNguoiDung);
            Controls.Add(gbTTNguoiDung);
            Controls.Add(menuStrip1);
            Font = new Font("Arial", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(5, 4, 5, 4);
            Name = "fMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "App quản lý nhân sự";
            FormClosing += fMain_FormClosing;
            FormClosed += fMain_FormClosed;
            Load += fMain_Load;
            gbTTNguoiDung.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            gbTTLuongNguoiDung.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private GroupBox gbTTNguoiDung;
        private TextBox tbMMaNV;
        private ToolStrip toolStrip1;
        private ToolStripLabel toolStripLabel1;
        private ToolStripLabel toolStripLabel2;
        private ToolStripMenuItem hệThốngToolStripMenuItem;
        private ToolStripMenuItem tsmiUser;
        private ToolStripMenuItem đăngXuấtToolStripMenuItem;
        private ToolStripMenuItem quảnLýToolStripMenuItem;
        private ToolStripMenuItem tsmiEmployee;
        private ToolStripMenuItem tsmiPhongBan;
        private ToolStripMenuItem tsmiChucVu;
        private ToolStripMenuItem thốngKêToolStripMenuItem;
        private ToolStripMenuItem trợGiúpToolStripMenuItem;
        private MenuStrip menuStrip1;
        private TextBox tbMaNV;
        private TextBox textBox1;
        private GroupBox gbTTLuongNguoiDung;
        private TableLayoutPanel tableLayoutPanel1;
        private Label label1;
        private DateTimePicker dtpMNgaySinh;
        private Label lbMDiaChi;
        private Label lbMCCCD;
        private Label lbMPhongBan;
        private Label lbMSDT;
        private Label lbMChucVu;
        private Label lbMGioiTinh;
        private Label label6;
        private Label label9;
        private Label label8;
        private Label label7;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label lbMHoTen;
        private DateTimePicker dtpMNgayNhanLuong;
        private Label label10;
        private Label label11;
        private Label lbMLuongThang;
        private TableLayoutPanel tableLayoutPanel2;
    }
}