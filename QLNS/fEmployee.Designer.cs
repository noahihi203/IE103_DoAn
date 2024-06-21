using System.Drawing.Printing;
using System.Drawing;
using System.Windows.Forms;
namespace QLNS
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
            this.toolStrip2 = new System.Windows.Forms.ToolStrip();
            this.tsbAdd = new System.Windows.Forms.ToolStripButton();
            this.tsbDelete = new System.Windows.Forms.ToolStripButton();
            this.tsbEdit = new System.Windows.Forms.ToolStripButton();
            this.tsbExport = new System.Windows.Forms.ToolStripButton();
            this.tsbImport = new System.Windows.Forms.ToolStripButton();
            this.dtgvEmployee = new System.Windows.Forms.DataGridView();
            this.MANV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HOTEN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GIOITINH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NGAYSINH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SDT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CCCD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DIACHI = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CBBTENCV = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.CBBTENPB = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.gbEmployeeList = new System.Windows.Forms.GroupBox();
            this.btExit = new System.Windows.Forms.Button();
            this.toolStrip2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvEmployee)).BeginInit();
            this.gbEmployeeList.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip2
            // 
            this.toolStrip2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.toolStrip2.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbAdd,
            this.tsbDelete,
            this.tsbEdit,
            this.tsbExport,
            this.tsbImport});
            this.toolStrip2.Location = new System.Drawing.Point(0, 0);
            this.toolStrip2.Name = "toolStrip2";
            this.toolStrip2.Size = new System.Drawing.Size(1145, 27);
            this.toolStrip2.TabIndex = 6;
            this.toolStrip2.Text = "toolStrip2";
            this.toolStrip2.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.toolStrip2_ItemClicked);
            // 
            // tsbAdd
            // 
            this.tsbAdd.Image = ((System.Drawing.Image)(resources.GetObject("tsbAdd.Image")));
            this.tsbAdd.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbAdd.Name = "tsbAdd";
            this.tsbAdd.Size = new System.Drawing.Size(70, 24);
            this.tsbAdd.Text = "Thêm";
            this.tsbAdd.Click += new System.EventHandler(this.tsbAdd_Click);
            // 
            // tsbDelete
            // 
            this.tsbDelete.Image = ((System.Drawing.Image)(resources.GetObject("tsbDelete.Image")));
            this.tsbDelete.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbDelete.Name = "tsbDelete";
            this.tsbDelete.Size = new System.Drawing.Size(59, 24);
            this.tsbDelete.Text = "Xoá";
            this.tsbDelete.Click += new System.EventHandler(this.tsbDelete_Click);
            // 
            // tsbEdit
            // 
            this.tsbEdit.Image = ((System.Drawing.Image)(resources.GetObject("tsbEdit.Image")));
            this.tsbEdit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbEdit.Name = "tsbEdit";
            this.tsbEdit.Size = new System.Drawing.Size(58, 24);
            this.tsbEdit.Text = "Sửa";
            this.tsbEdit.Click += new System.EventHandler(this.tsbEdit_Click);
            // 
            // tsbExport
            // 
            this.tsbExport.Image = ((System.Drawing.Image)(resources.GetObject("tsbExport.Image")));
            this.tsbExport.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbExport.Name = "tsbExport";
            this.tsbExport.Size = new System.Drawing.Size(76, 24);
            this.tsbExport.Text = "Export";
            this.tsbExport.Click += new System.EventHandler(this.tsbExport_Click);
            // 
            // tsbImport
            // 
            this.tsbImport.Image = ((System.Drawing.Image)(resources.GetObject("tsbImport.Image")));
            this.tsbImport.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbImport.Name = "tsbImport";
            this.tsbImport.Size = new System.Drawing.Size(78, 24);
            this.tsbImport.Text = "Import";
            this.tsbImport.Click += new System.EventHandler(this.tsbImport_Click);
            // 
            // dtgvEmployee
            // 
            this.dtgvEmployee.AllowUserToAddRows = false;
            this.dtgvEmployee.AllowUserToDeleteRows = false;
            this.dtgvEmployee.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgvEmployee.BackgroundColor = System.Drawing.Color.White;
            this.dtgvEmployee.ColumnHeadersHeight = 29;
            this.dtgvEmployee.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MANV,
            this.HOTEN,
            this.GIOITINH,
            this.NGAYSINH,
            this.SDT,
            this.CCCD,
            this.DIACHI,
            this.CBBTENCV,
            this.CBBTENPB});
            this.dtgvEmployee.GridColor = System.Drawing.Color.Black;
            this.dtgvEmployee.Location = new System.Drawing.Point(6, 27);
            this.dtgvEmployee.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtgvEmployee.Name = "dtgvEmployee";
            this.dtgvEmployee.RowHeadersVisible = false;
            this.dtgvEmployee.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders;
            this.dtgvEmployee.Size = new System.Drawing.Size(1109, 489);
            this.dtgvEmployee.TabIndex = 7;
            this.dtgvEmployee.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgvEmployee_CellContentClick);
            // 
            // MANV
            // 
            this.MANV.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.MANV.DataPropertyName = "MANV";
            this.MANV.FillWeight = 20F;
            this.MANV.HeaderText = "Mã NV";
            this.MANV.MinimumWidth = 6;
            this.MANV.Name = "MANV";
            this.MANV.ReadOnly = true;
            this.MANV.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // HOTEN
            // 
            this.HOTEN.DataPropertyName = "HOTEN";
            this.HOTEN.FillWeight = 44.33641F;
            this.HOTEN.HeaderText = "Họ và tên";
            this.HOTEN.MinimumWidth = 6;
            this.HOTEN.Name = "HOTEN";
            // 
            // GIOITINH
            // 
            this.GIOITINH.DataPropertyName = "GIOITINH";
            this.GIOITINH.FillWeight = 44.33641F;
            this.GIOITINH.HeaderText = "Giới tính";
            this.GIOITINH.MinimumWidth = 6;
            this.GIOITINH.Name = "GIOITINH";
            // 
            // NGAYSINH
            // 
            this.NGAYSINH.DataPropertyName = "NGAYSINH";
            this.NGAYSINH.FillWeight = 44.33641F;
            this.NGAYSINH.HeaderText = "Ngày sinh";
            this.NGAYSINH.MinimumWidth = 6;
            this.NGAYSINH.Name = "NGAYSINH";
            // 
            // SDT
            // 
            this.SDT.DataPropertyName = "SDT";
            this.SDT.FillWeight = 44.33641F;
            this.SDT.HeaderText = "Số điện thoại";
            this.SDT.MinimumWidth = 6;
            this.SDT.Name = "SDT";
            // 
            // CCCD
            // 
            this.CCCD.DataPropertyName = "CCCD";
            this.CCCD.FillWeight = 44.33641F;
            this.CCCD.HeaderText = "Căn cước";
            this.CCCD.MinimumWidth = 6;
            this.CCCD.Name = "CCCD";
            // 
            // DIACHI
            // 
            this.DIACHI.DataPropertyName = "DIACHI";
            this.DIACHI.FillWeight = 44.33641F;
            this.DIACHI.HeaderText = "Địa chỉ";
            this.DIACHI.MinimumWidth = 6;
            this.DIACHI.Name = "DIACHI";
            // 
            // CBBTENCV
            // 
            this.CBBTENCV.DataPropertyName = "MACV";
            this.CBBTENCV.FillWeight = 44.33641F;
            this.CBBTENCV.HeaderText = "Chức vụ";
            this.CBBTENCV.MinimumWidth = 6;
            this.CBBTENCV.Name = "CBBTENCV";
            this.CBBTENCV.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.CBBTENCV.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // CBBTENPB
            // 
            this.CBBTENPB.DataPropertyName = "MAPB";
            this.CBBTENPB.FillWeight = 44.33641F;
            this.CBBTENPB.HeaderText = "Phòng ban";
            this.CBBTENPB.MinimumWidth = 6;
            this.CBBTENPB.Name = "CBBTENPB";
            this.CBBTENPB.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.CBBTENPB.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // gbEmployeeList
            // 
            this.gbEmployeeList.Controls.Add(this.dtgvEmployee);
            this.gbEmployeeList.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbEmployeeList.Location = new System.Drawing.Point(12, 29);
            this.gbEmployeeList.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gbEmployeeList.Name = "gbEmployeeList";
            this.gbEmployeeList.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gbEmployeeList.Size = new System.Drawing.Size(1121, 529);
            this.gbEmployeeList.TabIndex = 8;
            this.gbEmployeeList.TabStop = false;
            this.gbEmployeeList.Text = "Danh sách nhân viên";
            // 
            // btExit
            // 
            this.btExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btExit.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btExit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btExit.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btExit.Location = new System.Drawing.Point(1015, 562);
            this.btExit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btExit.Name = "btExit";
            this.btExit.Size = new System.Drawing.Size(89, 41);
            this.btExit.TabIndex = 45;
            this.btExit.Text = "Thoát";
            this.btExit.UseVisualStyleBackColor = false;
            this.btExit.Click += new System.EventHandler(this.btExit_Click);
            // 
            // fEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(1145, 620);
            this.ControlBox = false;
            this.Controls.Add(this.btExit);
            this.Controls.Add(this.gbEmployeeList);
            this.Controls.Add(this.toolStrip2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "fEmployee";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "fEmployee";
            this.Load += new System.EventHandler(this.fEmployee_Load);
            this.toolStrip2.ResumeLayout(false);
            this.toolStrip2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvEmployee)).EndInit();
            this.gbEmployeeList.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ToolStrip toolStrip2;
        private ToolStripButton tsbAdd;
        private ToolStripButton tsbDelete;
        private DataGridView dtgvEmployee;
        private GroupBox gbEmployeeList;
        private ToolStripButton tsbExport;
        private ToolStripButton tsbImport;
        private ToolStripButton tsbEdit;
        private DataGridViewTextBoxColumn MANV;
        private DataGridViewTextBoxColumn HOTEN;
        private DataGridViewTextBoxColumn GIOITINH;
        private DataGridViewTextBoxColumn NGAYSINH;
        private DataGridViewTextBoxColumn SDT;
        private DataGridViewTextBoxColumn CCCD;
        private DataGridViewTextBoxColumn DIACHI;
        private DataGridViewComboBoxColumn CBBTENCV;
        private DataGridViewComboBoxColumn CBBTENPB;
        private Button btExit;
    }
}