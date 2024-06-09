namespace DoAnIE103
{
    partial class fEmployee
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fEmployee));
            toolStrip2 = new ToolStrip();
            tsbAdd = new ToolStripButton();
            tsbDelete = new ToolStripButton();
            tsbExport = new ToolStripButton();
            tsbImport = new ToolStripButton();
            dtgvEmployee = new DataGridView();
            MANV = new DataGridViewTextBoxColumn();
            HOTEN = new DataGridViewTextBoxColumn();
            GIOITINH = new DataGridViewTextBoxColumn();
            NGAYSINH = new DataGridViewTextBoxColumn();
            SDT = new DataGridViewTextBoxColumn();
            CCCD = new DataGridViewTextBoxColumn();
            DIACHI = new DataGridViewTextBoxColumn();
            CBBTENCV = new DataGridViewComboBoxColumn();
            CBBTENPB = new DataGridViewComboBoxColumn();
            MALUONG = new DataGridViewTextBoxColumn();
            NGAYNHANLUONG = new DataGridViewTextBoxColumn();
            TENDANGNHAP = new DataGridViewTextBoxColumn();
            groupBox1 = new GroupBox();
            tsbEdit = new ToolStripButton();
            toolStrip2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtgvEmployee).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // toolStrip2
            // 
            toolStrip2.ImageScalingSize = new Size(20, 20);
            toolStrip2.Items.AddRange(new ToolStripItem[] { tsbAdd, tsbDelete, tsbEdit, tsbExport, tsbImport });
            toolStrip2.Location = new Point(0, 0);
            toolStrip2.Name = "toolStrip2";
            toolStrip2.Size = new Size(1145, 27);
            toolStrip2.TabIndex = 6;
            toolStrip2.Text = "toolStrip2";
            toolStrip2.ItemClicked += toolStrip2_ItemClicked;
            // 
            // tsbAdd
            // 
            tsbAdd.Image = (Image)resources.GetObject("tsbAdd.Image");
            tsbAdd.ImageTransparentColor = Color.Magenta;
            tsbAdd.Name = "tsbAdd";
            tsbAdd.Size = new Size(70, 24);
            tsbAdd.Text = "Thêm";
            tsbAdd.Click += tsbAdd_Click;
            // 
            // tsbDelete
            // 
            tsbDelete.Image = (Image)resources.GetObject("tsbDelete.Image");
            tsbDelete.ImageTransparentColor = Color.Magenta;
            tsbDelete.Name = "tsbDelete";
            tsbDelete.Size = new Size(59, 24);
            tsbDelete.Text = "Xoá";
            tsbDelete.Click += tsbDelete_Click;
            // 
            // tsbExport
            // 
            tsbExport.Image = (Image)resources.GetObject("tsbExport.Image");
            tsbExport.ImageTransparentColor = Color.Magenta;
            tsbExport.Name = "tsbExport";
            tsbExport.Size = new Size(76, 24);
            tsbExport.Text = "Export";
            tsbExport.Click += tsbExport_Click;
            // 
            // tsbImport
            // 
            tsbImport.Image = (Image)resources.GetObject("tsbImport.Image");
            tsbImport.ImageTransparentColor = Color.Magenta;
            tsbImport.Name = "tsbImport";
            tsbImport.Size = new Size(78, 24);
            tsbImport.Text = "Import";
            tsbImport.Click += tsbImport_Click;
            // 
            // dtgvEmployee
            // 
            dtgvEmployee.AllowUserToAddRows = false;
            dtgvEmployee.AllowUserToDeleteRows = false;
            dtgvEmployee.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dtgvEmployee.BackgroundColor = SystemColors.ButtonHighlight;
            dtgvEmployee.ColumnHeadersHeight = 29;
            dtgvEmployee.Columns.AddRange(new DataGridViewColumn[] { MANV, HOTEN, GIOITINH, NGAYSINH, SDT, CCCD, DIACHI, CBBTENCV, CBBTENPB, MALUONG, NGAYNHANLUONG, TENDANGNHAP });
            dtgvEmployee.GridColor = Color.Black;
            dtgvEmployee.Location = new Point(6, 29);
            dtgvEmployee.Name = "dtgvEmployee";
            dtgvEmployee.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders;
            dtgvEmployee.Size = new Size(1109, 616);
            dtgvEmployee.TabIndex = 7;
            dtgvEmployee.CellClick += dtgvEmployee_CellClick;
            // 
            // MANV
            // 
            MANV.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            MANV.DataPropertyName = "MANV";
            MANV.FillWeight = 20F;
            MANV.HeaderText = "Mã NV";
            MANV.MinimumWidth = 6;
            MANV.Name = "MANV";
            MANV.ReadOnly = true;
            MANV.Resizable = DataGridViewTriState.True;
            // 
            // HOTEN
            // 
            HOTEN.DataPropertyName = "HOTEN";
            HOTEN.FillWeight = 44.3364143F;
            HOTEN.HeaderText = "Họ và tên";
            HOTEN.MinimumWidth = 6;
            HOTEN.Name = "HOTEN";
            HOTEN.ReadOnly = true;
            // 
            // GIOITINH
            // 
            GIOITINH.DataPropertyName = "GIOITINH";
            GIOITINH.FillWeight = 44.3364143F;
            GIOITINH.HeaderText = "Giới tính";
            GIOITINH.MinimumWidth = 6;
            GIOITINH.Name = "GIOITINH";
            GIOITINH.ReadOnly = true;
            // 
            // NGAYSINH
            // 
            NGAYSINH.DataPropertyName = "NGAYSINH";
            NGAYSINH.FillWeight = 44.3364143F;
            NGAYSINH.HeaderText = "Ngày sinh";
            NGAYSINH.MinimumWidth = 6;
            NGAYSINH.Name = "NGAYSINH";
            NGAYSINH.ReadOnly = true;
            // 
            // SDT
            // 
            SDT.DataPropertyName = "SDT";
            SDT.FillWeight = 44.3364143F;
            SDT.HeaderText = "Số điện thoại";
            SDT.MinimumWidth = 6;
            SDT.Name = "SDT";
            SDT.ReadOnly = true;
            // 
            // CCCD
            // 
            CCCD.DataPropertyName = "CCCD";
            CCCD.FillWeight = 44.3364143F;
            CCCD.HeaderText = "Căn cước";
            CCCD.MinimumWidth = 6;
            CCCD.Name = "CCCD";
            CCCD.ReadOnly = true;
            // 
            // DIACHI
            // 
            DIACHI.DataPropertyName = "DIACHI";
            DIACHI.FillWeight = 44.3364143F;
            DIACHI.HeaderText = "Địa chỉ";
            DIACHI.MinimumWidth = 6;
            DIACHI.Name = "DIACHI";
            DIACHI.ReadOnly = true;
            // 
            // CBBTENCV
            // 
            CBBTENCV.DataPropertyName = "MACV";
            CBBTENCV.FillWeight = 44.3364143F;
            CBBTENCV.HeaderText = "Chức vụ";
            CBBTENCV.MinimumWidth = 6;
            CBBTENCV.Name = "CBBTENCV";
            CBBTENCV.ReadOnly = true;
            CBBTENCV.Resizable = DataGridViewTriState.True;
            CBBTENCV.SortMode = DataGridViewColumnSortMode.Automatic;
            // 
            // CBBTENPB
            // 
            CBBTENPB.DataPropertyName = "MAPB";
            CBBTENPB.FillWeight = 44.3364143F;
            CBBTENPB.HeaderText = "Phòng ban";
            CBBTENPB.MinimumWidth = 6;
            CBBTENPB.Name = "CBBTENPB";
            CBBTENPB.ReadOnly = true;
            CBBTENPB.Resizable = DataGridViewTriState.True;
            CBBTENPB.SortMode = DataGridViewColumnSortMode.Automatic;
            // 
            // MALUONG
            // 
            MALUONG.DataPropertyName = "MALUONG";
            MALUONG.FillWeight = 44.3364143F;
            MALUONG.HeaderText = "Mã lương";
            MALUONG.MinimumWidth = 6;
            MALUONG.Name = "MALUONG";
            MALUONG.ReadOnly = true;
            // 
            // NGAYNHANLUONG
            // 
            NGAYNHANLUONG.DataPropertyName = "NGAYNHANLUONG";
            NGAYNHANLUONG.FillWeight = 44.3364143F;
            NGAYNHANLUONG.HeaderText = "Ngày nhận lương";
            NGAYNHANLUONG.MinimumWidth = 6;
            NGAYNHANLUONG.Name = "NGAYNHANLUONG";
            NGAYNHANLUONG.ReadOnly = true;
            // 
            // TENDANGNHAP
            // 
            TENDANGNHAP.DataPropertyName = "TENDANGNHAP";
            TENDANGNHAP.FillWeight = 44.3364143F;
            TENDANGNHAP.HeaderText = "Tên đăng nhập";
            TENDANGNHAP.MinimumWidth = 6;
            TENDANGNHAP.Name = "TENDANGNHAP";
            TENDANGNHAP.ReadOnly = true;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(dtgvEmployee);
            groupBox1.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(12, 47);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1121, 634);
            groupBox1.TabIndex = 8;
            groupBox1.TabStop = false;
            groupBox1.Text = "Danh sách nhân viên";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // tsbEdit
            // 
            tsbEdit.Image = (Image)resources.GetObject("tsbEdit.Image");
            tsbEdit.ImageTransparentColor = Color.Magenta;
            tsbEdit.Name = "tsbEdit";
            tsbEdit.Size = new Size(58, 24);
            tsbEdit.Text = "Sửa";
            tsbEdit.Click += tsbEdit_Click;
            // 
            // fEmployee
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1145, 693);
            Controls.Add(groupBox1);
            Controls.Add(toolStrip2);
            Name = "fEmployee";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "fEmployee";
            Load += fEmployee_Load;
            toolStrip2.ResumeLayout(false);
            toolStrip2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dtgvEmployee).EndInit();
            groupBox1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ToolStrip toolStrip2;
        private ToolStripButton tsbAdd;
        private ToolStripButton tsbDelete;
        private DataGridView dtgvEmployee;
        private GroupBox groupBox1;
        private ToolStripButton tsbExport;
        private ToolStripButton tsbImport;
        private DataGridViewTextBoxColumn MANV;
        private DataGridViewTextBoxColumn HOTEN;
        private DataGridViewTextBoxColumn GIOITINH;
        private DataGridViewTextBoxColumn NGAYSINH;
        private DataGridViewTextBoxColumn SDT;
        private DataGridViewTextBoxColumn CCCD;
        private DataGridViewTextBoxColumn DIACHI;
        private DataGridViewComboBoxColumn CBBTENCV;
        private DataGridViewComboBoxColumn CBBTENPB;
        private DataGridViewTextBoxColumn MALUONG;
        private DataGridViewTextBoxColumn NGAYNHANLUONG;
        private DataGridViewTextBoxColumn TENDANGNHAP;
        private ToolStripButton tsbEdit;
    }
}