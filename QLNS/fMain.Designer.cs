using System.Drawing.Printing;
using System.Drawing;
using System.Windows.Forms;
namespace QLNS
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
            this.gbTTNguoiDung = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label3 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.cbbMPhongBan = new System.Windows.Forms.TextBox();
            this.cbbMGioiTinh = new System.Windows.Forms.TextBox();
            this.cbbMSDT = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dtpMNgaySinh = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cbbMCCCD = new System.Windows.Forms.TextBox();
            this.cbbMHoTen = new System.Windows.Forms.TextBox();
            this.cbbMDiaChi = new System.Windows.Forms.TextBox();
            this.cbbMChucVu = new System.Windows.Forms.TextBox();
            this.gbTTLuongNguoiDung = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.cbbMLuongThang = new System.Windows.Forms.TextBox();
            this.dtpMNgayNhanLuong = new System.Windows.Forms.DateTimePicker();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.hệThốngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiUser = new System.Windows.Forms.ToolStripMenuItem();
            this.đăngXuấtToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.qltsmi = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiEmployee = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiPhongBan = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiChucVu = new System.Windows.Forms.ToolStripMenuItem();
            this.bảngChấmCôngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.báoCáoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.báoCáoDanhSáchNhânViênToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quảnLýBảoHiểmToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thốngKêToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.trợGiúpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.btCheckOut = new System.Windows.Forms.Button();
            this.btCheckIn = new System.Windows.Forms.Button();
            this.btExit = new System.Windows.Forms.Button();
            this.gbTTNguoiDung.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.gbTTLuongNguoiDung.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbTTNguoiDung
            // 
            this.gbTTNguoiDung.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.gbTTNguoiDung.Controls.Add(this.tableLayoutPanel1);
            this.gbTTNguoiDung.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbTTNguoiDung.Location = new System.Drawing.Point(9, 36);
            this.gbTTNguoiDung.Margin = new System.Windows.Forms.Padding(4);
            this.gbTTNguoiDung.Name = "gbTTNguoiDung";
            this.gbTTNguoiDung.Padding = new System.Windows.Forms.Padding(4);
            this.gbTTNguoiDung.Size = new System.Drawing.Size(565, 379);
            this.gbTTNguoiDung.TabIndex = 2;
            this.gbTTNguoiDung.TabStop = false;
            this.gbTTNguoiDung.Text = "Thông tin người dùng";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.label3, 1, 6);
            this.tableLayoutPanel1.Controls.Add(this.label9, 0, 6);
            this.tableLayoutPanel1.Controls.Add(this.label7, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.label8, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.cbbMPhongBan, 0, 7);
            this.tableLayoutPanel1.Controls.Add(this.cbbMGioiTinh, 1, 7);
            this.tableLayoutPanel1.Controls.Add(this.cbbMSDT, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.label6, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.label4, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.dtpMNgaySinh, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label5, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.cbbMCCCD, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.cbbMHoTen, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.cbbMDiaChi, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.cbbMChucVu, 1, 5);
            this.tableLayoutPanel1.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tableLayoutPanel1.Location = new System.Drawing.Point(11, 28);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 8;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(543, 340);
            this.tableLayoutPanel1.TabIndex = 38;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(275, 273);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 21);
            this.label3.TabIndex = 60;
            this.label3.Text = "Giới tính:";
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Bold);
            this.label9.Location = new System.Drawing.Point(4, 273);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(110, 21);
            this.label9.TabIndex = 59;
            this.label9.Text = "Phòng ban:";
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Bold);
            this.label7.Location = new System.Drawing.Point(4, 189);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(76, 21);
            this.label7.TabIndex = 54;
            this.label7.Text = "Địa chỉ:";
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Bold);
            this.label8.Location = new System.Drawing.Point(275, 189);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(91, 21);
            this.label8.TabIndex = 53;
            this.label8.Text = "Chức vụ:";
            // 
            // cbbMPhongBan
            // 
            this.cbbMPhongBan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.cbbMPhongBan.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cbbMPhongBan.Location = new System.Drawing.Point(3, 297);
            this.cbbMPhongBan.Name = "cbbMPhongBan";
            this.cbbMPhongBan.ReadOnly = true;
            this.cbbMPhongBan.Size = new System.Drawing.Size(167, 28);
            this.cbbMPhongBan.TabIndex = 57;
            // 
            // cbbMGioiTinh
            // 
            this.cbbMGioiTinh.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.cbbMGioiTinh.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cbbMGioiTinh.Location = new System.Drawing.Point(274, 297);
            this.cbbMGioiTinh.Name = "cbbMGioiTinh";
            this.cbbMGioiTinh.ReadOnly = true;
            this.cbbMGioiTinh.Size = new System.Drawing.Size(210, 28);
            this.cbbMGioiTinh.TabIndex = 58;
            // 
            // cbbMSDT
            // 
            this.cbbMSDT.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.cbbMSDT.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cbbMSDT.Location = new System.Drawing.Point(3, 129);
            this.cbbMSDT.Name = "cbbMSDT";
            this.cbbMSDT.ReadOnly = true;
            this.cbbMSDT.Size = new System.Drawing.Size(167, 28);
            this.cbbMSDT.TabIndex = 50;
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Bold);
            this.label6.Location = new System.Drawing.Point(275, 105);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(69, 21);
            this.label6.TabIndex = 42;
            this.label6.Text = "CCCD:";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(275, 21);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(104, 21);
            this.label4.TabIndex = 40;
            this.label4.Text = "Ngày sinh:";
            // 
            // dtpMNgaySinh
            // 
            this.dtpMNgaySinh.CalendarMonthBackground = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.dtpMNgaySinh.Checked = false;
            this.dtpMNgaySinh.CustomFormat = "dd-MM-yyyy";
            this.dtpMNgaySinh.Enabled = false;
            this.dtpMNgaySinh.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpMNgaySinh.Location = new System.Drawing.Point(275, 46);
            this.dtpMNgaySinh.Margin = new System.Windows.Forms.Padding(4);
            this.dtpMNgaySinh.Name = "dtpMNgaySinh";
            this.dtpMNgaySinh.Size = new System.Drawing.Size(209, 28);
            this.dtpMNgaySinh.TabIndex = 37;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(4, 21);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 21);
            this.label1.TabIndex = 5;
            this.label1.Text = "Họ và tên:";
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(4, 105);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(131, 21);
            this.label5.TabIndex = 11;
            this.label5.Text = "Số điện thoại:";
            // 
            // cbbMCCCD
            // 
            this.cbbMCCCD.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.cbbMCCCD.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cbbMCCCD.Location = new System.Drawing.Point(274, 129);
            this.cbbMCCCD.Name = "cbbMCCCD";
            this.cbbMCCCD.ReadOnly = true;
            this.cbbMCCCD.Size = new System.Drawing.Size(210, 28);
            this.cbbMCCCD.TabIndex = 48;
            // 
            // cbbMHoTen
            // 
            this.cbbMHoTen.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.cbbMHoTen.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cbbMHoTen.Location = new System.Drawing.Point(3, 45);
            this.cbbMHoTen.Name = "cbbMHoTen";
            this.cbbMHoTen.ReadOnly = true;
            this.cbbMHoTen.Size = new System.Drawing.Size(174, 28);
            this.cbbMHoTen.TabIndex = 49;
            this.cbbMHoTen.TextChanged += new System.EventHandler(this.cbbMHoTen_TextChanged);
            // 
            // cbbMDiaChi
            // 
            this.cbbMDiaChi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.cbbMDiaChi.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cbbMDiaChi.Location = new System.Drawing.Point(3, 213);
            this.cbbMDiaChi.Name = "cbbMDiaChi";
            this.cbbMDiaChi.ReadOnly = true;
            this.cbbMDiaChi.Size = new System.Drawing.Size(167, 28);
            this.cbbMDiaChi.TabIndex = 55;
            // 
            // cbbMChucVu
            // 
            this.cbbMChucVu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.cbbMChucVu.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cbbMChucVu.Location = new System.Drawing.Point(274, 213);
            this.cbbMChucVu.Name = "cbbMChucVu";
            this.cbbMChucVu.ReadOnly = true;
            this.cbbMChucVu.Size = new System.Drawing.Size(210, 28);
            this.cbbMChucVu.TabIndex = 56;
            // 
            // gbTTLuongNguoiDung
            // 
            this.gbTTLuongNguoiDung.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.gbTTLuongNguoiDung.Controls.Add(this.tableLayoutPanel2);
            this.gbTTLuongNguoiDung.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbTTLuongNguoiDung.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.gbTTLuongNguoiDung.Location = new System.Drawing.Point(9, 423);
            this.gbTTLuongNguoiDung.Margin = new System.Windows.Forms.Padding(4);
            this.gbTTLuongNguoiDung.Name = "gbTTLuongNguoiDung";
            this.gbTTLuongNguoiDung.Padding = new System.Windows.Forms.Padding(4);
            this.gbTTLuongNguoiDung.Size = new System.Drawing.Size(565, 120);
            this.gbTTLuongNguoiDung.TabIndex = 39;
            this.gbTTLuongNguoiDung.TabStop = false;
            this.gbTTLuongNguoiDung.Text = "Thông tin về lương của người dùng";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.cbbMLuongThang, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.dtpMNgayNhanLuong, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.label10, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.label11, 1, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(7, 28);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(547, 85);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // cbbMLuongThang
            // 
            this.cbbMLuongThang.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.cbbMLuongThang.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cbbMLuongThang.Location = new System.Drawing.Point(3, 45);
            this.cbbMLuongThang.Name = "cbbMLuongThang";
            this.cbbMLuongThang.ReadOnly = true;
            this.cbbMLuongThang.Size = new System.Drawing.Size(219, 28);
            this.cbbMLuongThang.TabIndex = 40;
            // 
            // dtpMNgayNhanLuong
            // 
            this.dtpMNgayNhanLuong.CalendarMonthBackground = System.Drawing.Color.Blue;
            this.dtpMNgayNhanLuong.CustomFormat = "dd-MM-yyyy";
            this.dtpMNgayNhanLuong.Enabled = false;
            this.dtpMNgayNhanLuong.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpMNgayNhanLuong.Location = new System.Drawing.Point(277, 46);
            this.dtpMNgayNhanLuong.Margin = new System.Windows.Forms.Padding(4);
            this.dtpMNgayNhanLuong.Name = "dtpMNgayNhanLuong";
            this.dtpMNgayNhanLuong.Size = new System.Drawing.Size(209, 28);
            this.dtpMNgayNhanLuong.TabIndex = 44;
            // 
            // label10
            // 
            this.label10.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Bold);
            this.label10.Location = new System.Drawing.Point(4, 21);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(130, 21);
            this.label10.TabIndex = 41;
            this.label10.Text = "Lương tháng:";
            // 
            // label11
            // 
            this.label11.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Bold);
            this.label11.Location = new System.Drawing.Point(277, 21);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(110, 21);
            this.label11.TabIndex = 45;
            this.label11.Text = "Ngày nhận:";
            // 
            // hệThốngToolStripMenuItem
            // 
            this.hệThốngToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiUser,
            this.đăngXuấtToolStripMenuItem});
            this.hệThốngToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("hệThốngToolStripMenuItem.Image")));
            this.hệThốngToolStripMenuItem.Name = "hệThốngToolStripMenuItem";
            this.hệThốngToolStripMenuItem.Size = new System.Drawing.Size(130, 28);
            this.hệThốngToolStripMenuItem.Text = "Hệ thống";
            // 
            // tsmiUser
            // 
            this.tsmiUser.Image = ((System.Drawing.Image)(resources.GetObject("tsmiUser.Image")));
            this.tsmiUser.Name = "tsmiUser";
            this.tsmiUser.Size = new System.Drawing.Size(260, 28);
            this.tsmiUser.Text = "Quản lý tài khoản";
            this.tsmiUser.Click += new System.EventHandler(this.tsmiUser_Click);
            // 
            // đăngXuấtToolStripMenuItem
            // 
            this.đăngXuấtToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("đăngXuấtToolStripMenuItem.Image")));
            this.đăngXuấtToolStripMenuItem.Name = "đăngXuấtToolStripMenuItem";
            this.đăngXuấtToolStripMenuItem.Size = new System.Drawing.Size(260, 28);
            this.đăngXuấtToolStripMenuItem.Text = "Đăng xuất";
            this.đăngXuấtToolStripMenuItem.Click += new System.EventHandler(this.đăngXuấtToolStripMenuItem_Click);
            // 
            // qltsmi
            // 
            this.qltsmi.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiEmployee,
            this.tsmiPhongBan,
            this.tsmiChucVu,
            this.bảngChấmCôngToolStripMenuItem,
            this.báoCáoToolStripMenuItem,
            this.quảnLýBảoHiểmToolStripMenuItem});
            this.qltsmi.Name = "qltsmi";
            this.qltsmi.Size = new System.Drawing.Size(97, 28);
            this.qltsmi.Text = "Quản lý";
            // 
            // tsmiEmployee
            // 
            this.tsmiEmployee.Name = "tsmiEmployee";
            this.tsmiEmployee.Size = new System.Drawing.Size(274, 28);
            this.tsmiEmployee.Text = "Quản lý nhân viên";
            this.tsmiEmployee.Click += new System.EventHandler(this.tsmiEmployee_Click);
            // 
            // tsmiPhongBan
            // 
            this.tsmiPhongBan.Name = "tsmiPhongBan";
            this.tsmiPhongBan.Size = new System.Drawing.Size(274, 28);
            this.tsmiPhongBan.Text = "Quản lý phòng ban";
            this.tsmiPhongBan.Click += new System.EventHandler(this.tsmiPhongBan_Click);
            // 
            // tsmiChucVu
            // 
            this.tsmiChucVu.Name = "tsmiChucVu";
            this.tsmiChucVu.Size = new System.Drawing.Size(274, 28);
            this.tsmiChucVu.Text = "Quản lý chức vụ";
            this.tsmiChucVu.Click += new System.EventHandler(this.tsmiChucVu_Click);
            // 
            // bảngChấmCôngToolStripMenuItem
            // 
            this.bảngChấmCôngToolStripMenuItem.Name = "bảngChấmCôngToolStripMenuItem";
            this.bảngChấmCôngToolStripMenuItem.Size = new System.Drawing.Size(274, 28);
            this.bảngChấmCôngToolStripMenuItem.Text = "Bảng chấm công";
            this.bảngChấmCôngToolStripMenuItem.Click += new System.EventHandler(this.bảngChấmCôngToolStripMenuItem_Click);
            // 
            // báoCáoToolStripMenuItem
            // 
            this.báoCáoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem2,
            this.báoCáoDanhSáchNhânViênToolStripMenuItem});
            this.báoCáoToolStripMenuItem.Name = "báoCáoToolStripMenuItem";
            this.báoCáoToolStripMenuItem.Size = new System.Drawing.Size(274, 28);
            this.báoCáoToolStripMenuItem.Text = "Báo Cáo";
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(373, 28);
            this.toolStripMenuItem2.Text = "Báo cáo lương";
            this.toolStripMenuItem2.Click += new System.EventHandler(this.toolStripMenuItem2_Click);
            // 
            // báoCáoDanhSáchNhânViênToolStripMenuItem
            // 
            this.báoCáoDanhSáchNhânViênToolStripMenuItem.Name = "báoCáoDanhSáchNhânViênToolStripMenuItem";
            this.báoCáoDanhSáchNhânViênToolStripMenuItem.Size = new System.Drawing.Size(373, 28);
            this.báoCáoDanhSáchNhânViênToolStripMenuItem.Text = "Báo cáo danh sách nhân viên";
            this.báoCáoDanhSáchNhânViênToolStripMenuItem.Click += new System.EventHandler(this.báoCáoDanhSáchNhânViênToolStripMenuItem_Click);
            // 
            // quảnLýBảoHiểmToolStripMenuItem
            // 
            this.quảnLýBảoHiểmToolStripMenuItem.Name = "quảnLýBảoHiểmToolStripMenuItem";
            this.quảnLýBảoHiểmToolStripMenuItem.Size = new System.Drawing.Size(274, 28);
            this.quảnLýBảoHiểmToolStripMenuItem.Text = "Quản lý bảo hiểm";
            this.quảnLýBảoHiểmToolStripMenuItem.Click += new System.EventHandler(this.quảnLýBảoHiểmToolStripMenuItem_Click);
            // 
            // thốngKêToolStripMenuItem
            // 
            this.thốngKêToolStripMenuItem.Name = "thốngKêToolStripMenuItem";
            this.thốngKêToolStripMenuItem.Size = new System.Drawing.Size(113, 28);
            this.thốngKêToolStripMenuItem.Text = "Thống kê";
            // 
            // trợGiúpToolStripMenuItem
            // 
            this.trợGiúpToolStripMenuItem.Name = "trợGiúpToolStripMenuItem";
            this.trợGiúpToolStripMenuItem.Size = new System.Drawing.Size(105, 28);
            this.trợGiúpToolStripMenuItem.Text = "Trợ giúp";
            this.trợGiúpToolStripMenuItem.Click += new System.EventHandler(this.trợGiúpToolStripMenuItem_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.menuStrip1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.hệThốngToolStripMenuItem,
            this.qltsmi,
            this.thốngKêToolStripMenuItem,
            this.trợGiúpToolStripMenuItem,
            this.toolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.menuStrip1.ShowItemToolTips = true;
            this.menuStrip1.Size = new System.Drawing.Size(587, 32);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(14, 28);
            // 
            // btCheckOut
            // 
            this.btCheckOut.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btCheckOut.AutoSize = true;
            this.btCheckOut.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btCheckOut.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btCheckOut.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btCheckOut.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btCheckOut.Location = new System.Drawing.Point(390, 562);
            this.btCheckOut.Name = "btCheckOut";
            this.btCheckOut.Size = new System.Drawing.Size(82, 26);
            this.btCheckOut.TabIndex = 43;
            this.btCheckOut.Text = "Check Out";
            this.btCheckOut.UseVisualStyleBackColor = false;
            this.btCheckOut.Click += new System.EventHandler(this.btCheckOut_Click);
            // 
            // btCheckIn
            // 
            this.btCheckIn.AutoSize = true;
            this.btCheckIn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btCheckIn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btCheckIn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btCheckIn.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btCheckIn.Location = new System.Drawing.Point(312, 562);
            this.btCheckIn.Name = "btCheckIn";
            this.btCheckIn.Size = new System.Drawing.Size(72, 26);
            this.btCheckIn.TabIndex = 42;
            this.btCheckIn.Text = "Check In";
            this.btCheckIn.UseVisualStyleBackColor = false;
            this.btCheckIn.Click += new System.EventHandler(this.btCheckIn_Click);
            // 
            // btExit
            // 
            this.btExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btExit.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btExit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btExit.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btExit.Location = new System.Drawing.Point(480, 559);
            this.btExit.Name = "btExit";
            this.btExit.Size = new System.Drawing.Size(89, 29);
            this.btExit.TabIndex = 44;
            this.btExit.Text = "Thoát";
            this.btExit.UseVisualStyleBackColor = false;
            this.btExit.Click += new System.EventHandler(this.btExit_Click);
            // 
            // fMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 27F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(587, 607);
            this.ControlBox = false;
            this.Controls.Add(this.btExit);
            this.Controls.Add(this.btCheckOut);
            this.Controls.Add(this.btCheckIn);
            this.Controls.Add(this.gbTTLuongNguoiDung);
            this.Controls.Add(this.gbTTNguoiDung);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "fMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "App quản lý nhân sự";
            this.Load += new System.EventHandler(this.fMain_Load_1);
            this.gbTTNguoiDung.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.gbTTLuongNguoiDung.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

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
        private ToolStripMenuItem qltsmi;
        private ToolStripMenuItem tsmiEmployee;
        private ToolStripMenuItem tsmiPhongBan;
        private ToolStripMenuItem tsmiChucVu;
        private ToolStripMenuItem thốngKêToolStripMenuItem;
        private ToolStripMenuItem trợGiúpToolStripMenuItem;
        private MenuStrip menuStrip1;
        private TextBox tbMaNV;
        private GroupBox gbTTLuongNguoiDung;
        private TableLayoutPanel tableLayoutPanel1;
        private Label label1;
        private DateTimePicker dtpMNgaySinh;
        private Label label5;
        private DateTimePicker dtpMNgayNhanLuong;
        private Label label10;
        private TableLayoutPanel tableLayoutPanel2;
        private Label label4;
        private Label label6;
        private TextBox cbbMSDT;
        private TextBox cbbMCCCD;
        private TextBox cbbMHoTen;
        private Label label7;
        private Label label8;
        private TextBox cbbMDiaChi;
        private TextBox cbbMChucVu;
        private TextBox cbbMPhongBan;
        private TextBox cbbMGioiTinh;
        private Label label3;
        private Label label9;
        private TextBox cbbMLuongThang;
        private Label label11;
        private ToolStripMenuItem bảngChấmCôngToolStripMenuItem;
        private ToolStripMenuItem toolStripMenuItem1;
        private Button btCheckOut;
        private Button btCheckIn;
        private Button btExit;
        private ToolStripMenuItem báoCáoToolStripMenuItem;
        private ToolStripMenuItem toolStripMenuItem2;
        private ToolStripMenuItem quảnLýBảoHiểmToolStripMenuItem;
        private ToolStripMenuItem báoCáoDanhSáchNhânViênToolStripMenuItem;
    }
}