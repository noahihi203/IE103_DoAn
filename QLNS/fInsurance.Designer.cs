namespace QLNS
{
    partial class fInsurance
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fInsurance));
            this.dtgvInsurance = new System.Windows.Forms.DataGridView();
            this.gbInsuranceList = new System.Windows.Forms.GroupBox();
            this.toolStrip2 = new System.Windows.Forms.ToolStrip();
            this.tsbAdd = new System.Windows.Forms.ToolStripButton();
            this.tsbDelete = new System.Windows.Forms.ToolStripButton();
            this.tsbEdit = new System.Windows.Forms.ToolStripButton();
            this.tsbExport = new System.Windows.Forms.ToolStripButton();
            this.tsbImport = new System.Windows.Forms.ToolStripButton();
            this.btExit = new System.Windows.Forms.Button();
            this.MABH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SOBH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NGAYCAP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NOICAP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NOIKHAMBENH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MANV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvInsurance)).BeginInit();
            this.gbInsuranceList.SuspendLayout();
            this.toolStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dtgvInsurance
            // 
            this.dtgvInsurance.AllowUserToAddRows = false;
            this.dtgvInsurance.AllowUserToDeleteRows = false;
            this.dtgvInsurance.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgvInsurance.BackgroundColor = System.Drawing.Color.White;
            this.dtgvInsurance.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvInsurance.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MABH,
            this.SOBH,
            this.NGAYCAP,
            this.NOICAP,
            this.NOIKHAMBENH,
            this.MANV});
            this.dtgvInsurance.Location = new System.Drawing.Point(6, 27);
            this.dtgvInsurance.Name = "dtgvInsurance";
            this.dtgvInsurance.RowHeadersVisible = false;
            this.dtgvInsurance.RowHeadersWidth = 51;
            this.dtgvInsurance.RowTemplate.Height = 24;
            this.dtgvInsurance.Size = new System.Drawing.Size(892, 477);
            this.dtgvInsurance.TabIndex = 0;
            // 
            // gbInsuranceList
            // 
            this.gbInsuranceList.Controls.Add(this.dtgvInsurance);
            this.gbInsuranceList.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbInsuranceList.Location = new System.Drawing.Point(12, 34);
            this.gbInsuranceList.Name = "gbInsuranceList";
            this.gbInsuranceList.Size = new System.Drawing.Size(904, 510);
            this.gbInsuranceList.TabIndex = 1;
            this.gbInsuranceList.TabStop = false;
            this.gbInsuranceList.Text = "Danh sách bảo hiểm của nhân viên";
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
            this.toolStrip2.Size = new System.Drawing.Size(928, 27);
            this.toolStrip2.TabIndex = 7;
            this.toolStrip2.Text = "toolStrip2";
            // 
            // tsbAdd
            // 
            this.tsbAdd.Image = ((System.Drawing.Image)(resources.GetObject("tsbAdd.Image")));
            this.tsbAdd.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbAdd.Name = "tsbAdd";
            this.tsbAdd.Size = new System.Drawing.Size(70, 24);
            this.tsbAdd.Text = "Thêm";
            // 
            // tsbDelete
            // 
            this.tsbDelete.Image = ((System.Drawing.Image)(resources.GetObject("tsbDelete.Image")));
            this.tsbDelete.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbDelete.Name = "tsbDelete";
            this.tsbDelete.Size = new System.Drawing.Size(59, 28);
            this.tsbDelete.Text = "Xoá";
            // 
            // tsbEdit
            // 
            this.tsbEdit.Image = ((System.Drawing.Image)(resources.GetObject("tsbEdit.Image")));
            this.tsbEdit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbEdit.Name = "tsbEdit";
            this.tsbEdit.Size = new System.Drawing.Size(58, 28);
            this.tsbEdit.Text = "Sửa";
            // 
            // tsbExport
            // 
            this.tsbExport.Image = ((System.Drawing.Image)(resources.GetObject("tsbExport.Image")));
            this.tsbExport.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbExport.Name = "tsbExport";
            this.tsbExport.Size = new System.Drawing.Size(76, 28);
            this.tsbExport.Text = "Export";
            // 
            // tsbImport
            // 
            this.tsbImport.Image = ((System.Drawing.Image)(resources.GetObject("tsbImport.Image")));
            this.tsbImport.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbImport.Name = "tsbImport";
            this.tsbImport.Size = new System.Drawing.Size(78, 28);
            this.tsbImport.Text = "Import";
            // 
            // btExit
            // 
            this.btExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btExit.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btExit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btExit.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btExit.Location = new System.Drawing.Point(784, 549);
            this.btExit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btExit.Name = "btExit";
            this.btExit.Size = new System.Drawing.Size(89, 41);
            this.btExit.TabIndex = 46;
            this.btExit.Text = "Thoát";
            this.btExit.UseVisualStyleBackColor = false;
            this.btExit.Click += new System.EventHandler(this.btExit_Click);
            // 
            // MABH
            // 
            this.MABH.DataPropertyName = "MABH";
            this.MABH.HeaderText = "Mã bảo hiểm";
            this.MABH.MinimumWidth = 6;
            this.MABH.Name = "MABH";
            // 
            // SOBH
            // 
            this.SOBH.DataPropertyName = "SOBH";
            this.SOBH.HeaderText = "Số bảo hiểm";
            this.SOBH.MinimumWidth = 6;
            this.SOBH.Name = "SOBH";
            // 
            // NGAYCAP
            // 
            this.NGAYCAP.DataPropertyName = "NGAYCAP";
            this.NGAYCAP.HeaderText = "Ngày cấp";
            this.NGAYCAP.MinimumWidth = 6;
            this.NGAYCAP.Name = "NGAYCAP";
            // 
            // NOICAP
            // 
            this.NOICAP.DataPropertyName = "NOICAP";
            this.NOICAP.HeaderText = "Nơi cấp";
            this.NOICAP.MinimumWidth = 6;
            this.NOICAP.Name = "NOICAP";
            // 
            // NOIKHAMBENH
            // 
            this.NOIKHAMBENH.DataPropertyName = "NOIKHAMBENH";
            this.NOIKHAMBENH.HeaderText = "Nơi khám bệnh";
            this.NOIKHAMBENH.MinimumWidth = 6;
            this.NOIKHAMBENH.Name = "NOIKHAMBENH";
            // 
            // MANV
            // 
            this.MANV.DataPropertyName = "MANV";
            this.MANV.HeaderText = "Mã nhân viên";
            this.MANV.MinimumWidth = 6;
            this.MANV.Name = "MANV";
            // 
            // fInsurance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(928, 596);
            this.Controls.Add(this.btExit);
            this.Controls.Add(this.toolStrip2);
            this.Controls.Add(this.gbInsuranceList);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "fInsurance";
            this.Text = "Quản lý bảo hiểm";
            this.Load += new System.EventHandler(this.fInsurance_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvInsurance)).EndInit();
            this.gbInsuranceList.ResumeLayout(false);
            this.toolStrip2.ResumeLayout(false);
            this.toolStrip2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgvInsurance;
        private System.Windows.Forms.GroupBox gbInsuranceList;
        private System.Windows.Forms.ToolStrip toolStrip2;
        private System.Windows.Forms.ToolStripButton tsbAdd;
        private System.Windows.Forms.ToolStripButton tsbDelete;
        private System.Windows.Forms.ToolStripButton tsbEdit;
        private System.Windows.Forms.ToolStripButton tsbExport;
        private System.Windows.Forms.ToolStripButton tsbImport;
        private System.Windows.Forms.Button btExit;
        private System.Windows.Forms.DataGridViewTextBoxColumn MABH;
        private System.Windows.Forms.DataGridViewTextBoxColumn SOBH;
        private System.Windows.Forms.DataGridViewTextBoxColumn NGAYCAP;
        private System.Windows.Forms.DataGridViewTextBoxColumn NOICAP;
        private System.Windows.Forms.DataGridViewTextBoxColumn NOIKHAMBENH;
        private System.Windows.Forms.DataGridViewTextBoxColumn MANV;
    }
}