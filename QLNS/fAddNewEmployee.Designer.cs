using System.Drawing.Printing;
using System.Drawing;
using System.Windows.Forms;
namespace QLNS
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btAHuy = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tbACCCD = new System.Windows.Forms.TextBox();
            this.cbbAEChucVu = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cbbAEPhongBan = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbAHoTen = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.dtpANgayNhanLuong = new System.Windows.Forms.DateTimePicker();
            this.label9 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tbADiaChi = new System.Windows.Forms.TextBox();
            this.tbAMaNV = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dtpANgaySinh = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.cbAGioiTinh = new System.Windows.Forms.ComboBox();
            this.tbASDT = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.btAThem = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btAHuy);
            this.groupBox1.Controls.Add(this.tableLayoutPanel1);
            this.groupBox1.Controls.Add(this.btAThem);
            this.groupBox1.Location = new System.Drawing.Point(12, 10);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(776, 217);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin nhân viên sẽ thêm vào";
            // 
            // btAHuy
            // 
            this.btAHuy.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btAHuy.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btAHuy.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btAHuy.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btAHuy.Location = new System.Drawing.Point(638, 176);
            this.btAHuy.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btAHuy.Name = "btAHuy";
            this.btAHuy.Size = new System.Drawing.Size(99, 37);
            this.btAHuy.TabIndex = 12;
            this.btAHuy.Text = "Huỷ";
            this.btAHuy.UseVisualStyleBackColor = false;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.Controls.Add(this.tbACCCD, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.cbbAEChucVu, 3, 3);
            this.tableLayoutPanel1.Controls.Add(this.label5, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.cbbAEPhongBan, 3, 2);
            this.tableLayoutPanel1.Controls.Add(this.label4, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.tbAHoTen, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.label12, 2, 3);
            this.tableLayoutPanel1.Controls.Add(this.dtpANgayNhanLuong, 3, 4);
            this.tableLayoutPanel1.Controls.Add(this.label9, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.label7, 2, 4);
            this.tableLayoutPanel1.Controls.Add(this.label6, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.tbADiaChi, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.tbAMaNV, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.label3, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.dtpANgaySinh, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.cbAGioiTinh, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.tbASDT, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.label11, 2, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(6, 19);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(764, 141);
            this.tableLayoutPanel1.TabIndex = 13;
            // 
            // tbACCCD
            // 
            this.tbACCCD.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.tbACCCD.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.tbACCCD.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbACCCD.Location = new System.Drawing.Point(180, 85);
            this.tbACCCD.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbACCCD.Name = "tbACCCD";
            this.tbACCCD.Size = new System.Drawing.Size(138, 22);
            this.tbACCCD.TabIndex = 10;
            // 
            // cbbAEChucVu
            // 
            this.cbbAEChucVu.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.cbbAEChucVu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.cbbAEChucVu.FormattingEnabled = true;
            this.cbbAEChucVu.Location = new System.Drawing.Point(564, 84);
            this.cbbAEChucVu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbbAEChucVu.Name = "cbbAEChucVu";
            this.cbbAEChucVu.Size = new System.Drawing.Size(149, 24);
            this.cbbAEChucVu.TabIndex = 13;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(3, 86);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(171, 19);
            this.label5.TabIndex = 4;
            this.label5.Text = "Căn cước công dân:";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(3, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Họ và tên:";
            // 
            // cbbAEPhongBan
            // 
            this.cbbAEPhongBan.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.cbbAEPhongBan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.cbbAEPhongBan.FormattingEnabled = true;
            this.cbbAEPhongBan.Location = new System.Drawing.Point(564, 56);
            this.cbbAEPhongBan.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbbAEPhongBan.Name = "cbbAEPhongBan";
            this.cbbAEPhongBan.Size = new System.Drawing.Size(149, 24);
            this.cbbAEPhongBan.TabIndex = 12;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(3, 58);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(118, 19);
            this.label4.TabIndex = 3;
            this.label4.Text = "Số điện thoại:";
            // 
            // tbAHoTen
            // 
            this.tbAHoTen.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.tbAHoTen.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.tbAHoTen.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbAHoTen.Location = new System.Drawing.Point(180, 2);
            this.tbAHoTen.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbAHoTen.Name = "tbAHoTen";
            this.tbAHoTen.Size = new System.Drawing.Size(212, 22);
            this.tbAHoTen.TabIndex = 1;
            // 
            // label12
            // 
            this.label12.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold);
            this.label12.Location = new System.Drawing.Point(406, 86);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(82, 19);
            this.label12.TabIndex = 11;
            this.label12.Text = "Chức vụ:";
            // 
            // dtpANgayNhanLuong
            // 
            this.dtpANgayNhanLuong.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.dtpANgayNhanLuong.CustomFormat = "dd/MM/yyyy";
            this.dtpANgayNhanLuong.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpANgayNhanLuong.Location = new System.Drawing.Point(564, 114);
            this.dtpANgayNhanLuong.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtpANgayNhanLuong.Name = "dtpANgayNhanLuong";
            this.dtpANgayNhanLuong.Size = new System.Drawing.Size(108, 22);
            this.dtpANgayNhanLuong.TabIndex = 3;
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold);
            this.label9.Location = new System.Drawing.Point(406, 58);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(100, 19);
            this.label9.TabIndex = 8;
            this.label9.Text = "Phòng ban:";
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold);
            this.label7.Location = new System.Drawing.Point(406, 116);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(152, 19);
            this.label7.TabIndex = 6;
            this.label7.Text = "Ngày nhận lương:";
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold);
            this.label6.Location = new System.Drawing.Point(3, 116);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(68, 19);
            this.label6.TabIndex = 5;
            this.label6.Text = "Địa chỉ:";
            // 
            // tbADiaChi
            // 
            this.tbADiaChi.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.tbADiaChi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.tbADiaChi.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbADiaChi.Location = new System.Drawing.Point(180, 114);
            this.tbADiaChi.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbADiaChi.Name = "tbADiaChi";
            this.tbADiaChi.Size = new System.Drawing.Size(220, 22);
            this.tbADiaChi.TabIndex = 2;
            // 
            // tbAMaNV
            // 
            this.tbAMaNV.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.tbAMaNV.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.tbAMaNV.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbAMaNV.Location = new System.Drawing.Point(564, 2);
            this.tbAMaNV.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbAMaNV.Name = "tbAMaNV";
            this.tbAMaNV.Size = new System.Drawing.Size(108, 22);
            this.tbAMaNV.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(406, 30);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 19);
            this.label3.TabIndex = 2;
            this.label3.Text = "Ngày sinh:";
            // 
            // dtpANgaySinh
            // 
            this.dtpANgaySinh.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.dtpANgaySinh.CustomFormat = "dd/MM/yyyy";
            this.dtpANgaySinh.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpANgaySinh.Location = new System.Drawing.Point(564, 29);
            this.dtpANgaySinh.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtpANgaySinh.Name = "dtpANgaySinh";
            this.dtpANgaySinh.Size = new System.Drawing.Size(108, 22);
            this.dtpANgaySinh.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(3, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "Giới tính:";
            // 
            // cbAGioiTinh
            // 
            this.cbAGioiTinh.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.cbAGioiTinh.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.cbAGioiTinh.FormattingEnabled = true;
            this.cbAGioiTinh.Location = new System.Drawing.Point(180, 28);
            this.cbAGioiTinh.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbAGioiTinh.Name = "cbAGioiTinh";
            this.cbAGioiTinh.Size = new System.Drawing.Size(138, 24);
            this.cbAGioiTinh.TabIndex = 4;
            // 
            // tbASDT
            // 
            this.tbASDT.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.tbASDT.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.tbASDT.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbASDT.Location = new System.Drawing.Point(180, 57);
            this.tbASDT.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbASDT.Name = "tbASDT";
            this.tbASDT.Size = new System.Drawing.Size(138, 22);
            this.tbASDT.TabIndex = 8;
            // 
            // label11
            // 
            this.label11.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold);
            this.label11.Location = new System.Drawing.Point(406, 3);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(118, 19);
            this.label11.TabIndex = 10;
            this.label11.Text = "Mã nhân viên:";
            // 
            // btAThem
            // 
            this.btAThem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btAThem.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btAThem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btAThem.Location = new System.Drawing.Point(538, 176);
            this.btAThem.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btAThem.Name = "btAThem";
            this.btAThem.Size = new System.Drawing.Size(94, 37);
            this.btAThem.TabIndex = 11;
            this.btAThem.Text = "Thêm";
            this.btAThem.UseVisualStyleBackColor = false;
            // 
            // fAddNewEmployee
            // 
            this.AcceptButton = this.btAThem;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.CancelButton = this.btAHuy;
            this.ClientSize = new System.Drawing.Size(800, 234);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "fAddNewEmployee";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "fAddNewEmployee";
            this.groupBox1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

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