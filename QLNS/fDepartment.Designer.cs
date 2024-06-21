using System.Drawing.Printing;
using System.Drawing;
using System.Windows.Forms;
namespace QLNS
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
            toolStripSeparator3 = new ToolStripSeparator();
            toolStripLabel1 = new ToolStripLabel();
            toolStripSeparator2 = new ToolStripSeparator();
            tsbAddDepartment = new ToolStripButton();
            tsbDeleteDepartment = new ToolStripButton();
            toolStripSeparator1 = new ToolStripSeparator();
            tsbExitDepartment = new ToolStripButton();
            dtgvDepartment = new DataGridView();
            MAPB = new DataGridViewTextBoxColumn();
            TENPB = new DataGridViewTextBoxColumn();
            groupBox1.SuspendLayout();
            toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtgvDepartment).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.FromArgb(192, 255, 192);
            groupBox1.Controls.Add(toolStrip1);
            groupBox1.Controls.Add(dtgvDepartment);
            groupBox1.Location = new Point(12, 13);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(413, 425);
            groupBox1.TabIndex = 4;
            groupBox1.TabStop = false;
            groupBox1.Text = "Quản lý phòng ban";
            // 
            // toolStrip1
            // 
            toolStrip1.BackColor = Color.FromArgb(255, 224, 192);
            toolStrip1.Dock = DockStyle.Left;
            toolStrip1.GripStyle = ToolStripGripStyle.Hidden;
            toolStrip1.ImageScalingSize = new Size(20, 20);
            toolStrip1.Items.AddRange(new ToolStripItem[] { toolStripSeparator3, toolStripLabel1, toolStripSeparator2, tsbAddDepartment, tsbDeleteDepartment, toolStripSeparator1, tsbExitDepartment });
            toolStrip1.Location = new Point(3, 23);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(84, 399);
            toolStrip1.TabIndex = 10;
            toolStrip1.Text = "toolStrip1";
            // 
            // toolStripSeparator3
            // 
            toolStripSeparator3.Name = "toolStripSeparator3";
            toolStripSeparator3.Size = new Size(81, 6);
            // 
            // toolStripLabel1
            // 
            toolStripLabel1.DisplayStyle = ToolStripItemDisplayStyle.Text;
            toolStripLabel1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            toolStripLabel1.ImageAlign = ContentAlignment.MiddleLeft;
            toolStripLabel1.Name = "toolStripLabel1";
            toolStripLabel1.Size = new Size(81, 20);
            toolStripLabel1.Text = "Chức năng";
            // 
            // toolStripSeparator2
            // 
            toolStripSeparator2.Name = "toolStripSeparator2";
            toolStripSeparator2.Size = new Size(81, 6);
            // 
            // tsbAddDepartment
            // 
            tsbAddDepartment.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tsbAddDepartment.Image = (Image)resources.GetObject("tsbAddDepartment.Image");
            tsbAddDepartment.ImageAlign = ContentAlignment.MiddleLeft;
            tsbAddDepartment.ImageTransparentColor = Color.Magenta;
            tsbAddDepartment.Name = "tsbAddDepartment";
            tsbAddDepartment.Size = new Size(81, 24);
            tsbAddDepartment.Text = "Thêm";
            tsbAddDepartment.Click += tsbAddDepartment_Click;
            // 
            // tsbDeleteDepartment
            // 
            tsbDeleteDepartment.Image = (Image)resources.GetObject("tsbDeleteDepartment.Image");
            tsbDeleteDepartment.ImageAlign = ContentAlignment.MiddleLeft;
            tsbDeleteDepartment.ImageTransparentColor = Color.Magenta;
            tsbDeleteDepartment.Name = "tsbDeleteDepartment";
            tsbDeleteDepartment.Size = new Size(81, 24);
            tsbDeleteDepartment.Text = "Xoá";
            tsbDeleteDepartment.Click += tsbDeleteDepartment_Click;
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(81, 6);
            // 
            // tsbExitDepartment
            // 
            tsbExitDepartment.Image = (Image)resources.GetObject("tsbExitDepartment.Image");
            tsbExitDepartment.ImageAlign = ContentAlignment.MiddleLeft;
            tsbExitDepartment.ImageTransparentColor = Color.Magenta;
            tsbExitDepartment.Name = "tsbExitDepartment";
            tsbExitDepartment.Size = new Size(81, 24);
            tsbExitDepartment.Text = "Thoát";
            tsbExitDepartment.Click += tsbExitDepartment_Click;
            // 
            // dtgvDepartment
            // 
            dtgvDepartment.AllowUserToAddRows = false;
            dtgvDepartment.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dtgvDepartment.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dtgvDepartment.BackgroundColor = Color.White;
            dtgvDepartment.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgvDepartment.Columns.AddRange(new DataGridViewColumn[] { MAPB, TENPB });
            dtgvDepartment.Location = new Point(90, 26);
            dtgvDepartment.MultiSelect = false;
            dtgvDepartment.Name = "dtgvDepartment";
            dtgvDepartment.RowHeadersVisible = false;
            dtgvDepartment.RowHeadersWidth = 51;
            dtgvDepartment.Size = new Size(317, 393);
            dtgvDepartment.TabIndex = 9;
            dtgvDepartment.CellClick += dtgvDepartment_CellClick;
            dtgvDepartment.CellEndEdit += dtgvDepartment_CellEndEdit;
            // 
            // MAPB
            // 
            MAPB.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            MAPB.DataPropertyName = "MAPB";
            MAPB.FillWeight = 65.82974F;
            MAPB.HeaderText = "Mã phòng ban";
            MAPB.MinimumWidth = 6;
            MAPB.Name = "MAPB";
            MAPB.Resizable = DataGridViewTriState.True;
            MAPB.SortMode = DataGridViewColumnSortMode.Programmatic;
            // 
            // TENPB
            // 
            TENPB.DataPropertyName = "TENPB";
            TENPB.FillWeight = 57.27187F;
            TENPB.HeaderText = "Tên phòng ban";
            TENPB.MinimumWidth = 6;
            TENPB.Name = "TENPB";
            TENPB.Resizable = DataGridViewTriState.True;
            TENPB.SortMode = DataGridViewColumnSortMode.NotSortable;
            // 
            // fDepartment
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(192, 255, 192);
            ClientSize = new Size(436, 450);
            Controls.Add(groupBox1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "fDepartment";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Phòng ban";
            Load += fDepartment_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dtgvDepartment).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private ToolStrip toolStrip1;
        private ToolStripSeparator toolStripSeparator3;
        private ToolStripLabel toolStripLabel1;
        private ToolStripSeparator toolStripSeparator2;
        private ToolStripButton tsbAddDepartment;
        private ToolStripButton tsbDeleteDepartment;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripButton tsbExitDepartment;
        private DataGridView dtgvDepartment;
        private DataGridViewTextBoxColumn MAPB;
        private DataGridViewTextBoxColumn TENPB;
    }
}