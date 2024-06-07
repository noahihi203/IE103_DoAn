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
            tsbEdit = new ToolStripButton();
            tsbPrint = new ToolStripButton();
            tsbExport = new ToolStripButton();
            tsbImport = new ToolStripButton();
            dtgvEmployee = new DataGridView();
            groupBox1 = new GroupBox();
            toolStrip2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtgvEmployee).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // toolStrip2
            // 
            toolStrip2.ImageScalingSize = new Size(20, 20);
            toolStrip2.Items.AddRange(new ToolStripItem[] { tsbAdd, tsbDelete, tsbEdit, tsbPrint, tsbExport, tsbImport });
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
            // tsbEdit
            // 
            tsbEdit.Image = (Image)resources.GetObject("tsbEdit.Image");
            tsbEdit.ImageTransparentColor = Color.Magenta;
            tsbEdit.Name = "tsbEdit";
            tsbEdit.Size = new Size(58, 24);
            tsbEdit.Text = "Sửa";
            tsbEdit.Click += tsbEdit_Click;
            // 
            // tsbPrint
            // 
            tsbPrint.Image = (Image)resources.GetObject("tsbPrint.Image");
            tsbPrint.ImageTransparentColor = Color.Magenta;
            tsbPrint.Name = "tsbPrint";
            tsbPrint.Size = new Size(45, 24);
            tsbPrint.Text = "In";
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
            // 
            // dtgvEmployee
            // 
            dtgvEmployee.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dtgvEmployee.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgvEmployee.Location = new Point(6, 29);
            dtgvEmployee.Name = "dtgvEmployee";
            dtgvEmployee.ReadOnly = true;
            dtgvEmployee.RowHeadersWidth = 51;
            dtgvEmployee.Size = new Size(1109, 616);
            dtgvEmployee.TabIndex = 7;
            dtgvEmployee.CellClick += dtgvEmployee_CellClick;
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
        private ToolStripButton tsbEdit;
        private ToolStripButton tsbPrint;
        private DataGridView dtgvEmployee;
        private GroupBox groupBox1;
        private ToolStripButton tsbExport;
        private ToolStripButton tsbImport;
    }
}