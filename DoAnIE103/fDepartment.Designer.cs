namespace DoAnIE103
{
    partial class fDepartment
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fDepartment));
            groupBox1 = new GroupBox();
            toolStrip1 = new ToolStrip();
            tsbAddDepartment = new ToolStripButton();
            tsbDeleteDepartment = new ToolStripButton();
            tsbEditDepartment = new ToolStripButton();
            tsbExportDepartment = new ToolStripButton();
            tsbImportDepartment = new ToolStripButton();
            dtgvDepartment = new DataGridView();
            toolStripSeparator1 = new ToolStripSeparator();
            groupBox1.SuspendLayout();
            toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtgvDepartment).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(toolStrip1);
            groupBox1.Controls.Add(dtgvDepartment);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(410, 426);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "Quản lý phòng ban";
            // 
            // toolStrip1
            // 
            toolStrip1.Dock = DockStyle.Left;
            toolStrip1.ImageScalingSize = new Size(20, 20);
            toolStrip1.Items.AddRange(new ToolStripItem[] { tsbAddDepartment, tsbDeleteDepartment, tsbEditDepartment, tsbExportDepartment, tsbImportDepartment, toolStripSeparator1 });
            toolStrip1.Location = new Point(3, 23);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(79, 400);
            toolStrip1.TabIndex = 10;
            toolStrip1.Text = "toolStrip1";
            // 
            // tsbAddDepartment
            // 
            tsbAddDepartment.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tsbAddDepartment.Image = (Image)resources.GetObject("tsbAddDepartment.Image");
            tsbAddDepartment.ImageAlign = ContentAlignment.MiddleLeft;
            tsbAddDepartment.ImageTransparentColor = Color.Magenta;
            tsbAddDepartment.Name = "tsbAddDepartment";
            tsbAddDepartment.Size = new Size(76, 24);
            tsbAddDepartment.Text = "Thêm";
            // 
            // tsbDeleteDepartment
            // 
            tsbDeleteDepartment.Image = (Image)resources.GetObject("tsbDeleteDepartment.Image");
            tsbDeleteDepartment.ImageAlign = ContentAlignment.MiddleLeft;
            tsbDeleteDepartment.ImageTransparentColor = Color.Magenta;
            tsbDeleteDepartment.Name = "tsbDeleteDepartment";
            tsbDeleteDepartment.Size = new Size(76, 24);
            tsbDeleteDepartment.Text = "Xoá";
            // 
            // tsbEditDepartment
            // 
            tsbEditDepartment.Image = (Image)resources.GetObject("tsbEditDepartment.Image");
            tsbEditDepartment.ImageAlign = ContentAlignment.MiddleLeft;
            tsbEditDepartment.ImageTransparentColor = Color.Magenta;
            tsbEditDepartment.Name = "tsbEditDepartment";
            tsbEditDepartment.Size = new Size(76, 24);
            tsbEditDepartment.Text = "Sửa";
            // 
            // tsbExportDepartment
            // 
            tsbExportDepartment.Image = (Image)resources.GetObject("tsbExportDepartment.Image");
            tsbExportDepartment.ImageAlign = ContentAlignment.MiddleLeft;
            tsbExportDepartment.ImageTransparentColor = Color.Magenta;
            tsbExportDepartment.Name = "tsbExportDepartment";
            tsbExportDepartment.Size = new Size(76, 24);
            tsbExportDepartment.Text = "Export";
            // 
            // tsbImportDepartment
            // 
            tsbImportDepartment.Image = (Image)resources.GetObject("tsbImportDepartment.Image");
            tsbImportDepartment.ImageTransparentColor = Color.Magenta;
            tsbImportDepartment.Name = "tsbImportDepartment";
            tsbImportDepartment.Size = new Size(76, 24);
            tsbImportDepartment.Text = "Import";
            // 
            // dtgvDepartment
            // 
            dtgvDepartment.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgvDepartment.Location = new Point(85, 26);
            dtgvDepartment.Name = "dtgvDepartment";
            dtgvDepartment.RowHeadersWidth = 51;
            dtgvDepartment.Size = new Size(319, 394);
            dtgvDepartment.TabIndex = 9;
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(76, 6);
            // 
            // fDepartment
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(436, 450);
            Controls.Add(groupBox1);
            Name = "fDepartment";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "fDepartment";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dtgvDepartment).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private GroupBox groupBox1;
        private DataGridView dtgvDepartment;
        private ToolStrip toolStrip1;
        private ToolStripButton tsbAddDepartment;
        private ToolStripButton tsbDeleteDepartment;
        private ToolStripButton tsbEditDepartment;
        private ToolStripButton tsbExportDepartment;
        private ToolStripButton tsbImportDepartment;
        private ToolStripSeparator toolStripSeparator1;
    }
}