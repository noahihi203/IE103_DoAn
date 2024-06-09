namespace DoAnIE103
{
    partial class fPosition
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fPosition));
            groupBox1 = new GroupBox();
            toolStrip1 = new ToolStrip();
            toolStripSeparator3 = new ToolStripSeparator();
            toolStripLabel1 = new ToolStripLabel();
            toolStripSeparator2 = new ToolStripSeparator();
            tsbAddPosition = new ToolStripButton();
            tsbDeletePosition = new ToolStripButton();
            toolStripSeparator1 = new ToolStripSeparator();
            tsbExitPosition = new ToolStripButton();
            dtgvPosition = new DataGridView();
            MACV = new DataGridViewTextBoxColumn();
            TENCV = new DataGridViewTextBoxColumn();
            groupBox1.SuspendLayout();
            toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtgvPosition).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.White;
            groupBox1.Controls.Add(toolStrip1);
            groupBox1.Controls.Add(dtgvPosition);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(413, 425);
            groupBox1.TabIndex = 3;
            groupBox1.TabStop = false;
            groupBox1.Text = "Quản lý chức vụ";
            // 
            // toolStrip1
            // 
            toolStrip1.BackColor = Color.White;
            toolStrip1.Dock = DockStyle.Left;
            toolStrip1.GripStyle = ToolStripGripStyle.Hidden;
            toolStrip1.ImageScalingSize = new Size(20, 20);
            toolStrip1.Items.AddRange(new ToolStripItem[] { toolStripSeparator3, toolStripLabel1, toolStripSeparator2, tsbAddPosition, tsbDeletePosition, toolStripSeparator1, tsbExitPosition });
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
            // tsbAddPosition
            // 
            tsbAddPosition.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tsbAddPosition.Image = (Image)resources.GetObject("tsbAddPosition.Image");
            tsbAddPosition.ImageAlign = ContentAlignment.MiddleLeft;
            tsbAddPosition.ImageTransparentColor = Color.Magenta;
            tsbAddPosition.Name = "tsbAddPosition";
            tsbAddPosition.Size = new Size(81, 24);
            tsbAddPosition.Text = "Thêm";
            tsbAddPosition.Click += tsbAddPosition_Click;
            // 
            // tsbDeletePosition
            // 
            tsbDeletePosition.Image = (Image)resources.GetObject("tsbDeletePosition.Image");
            tsbDeletePosition.ImageAlign = ContentAlignment.MiddleLeft;
            tsbDeletePosition.ImageTransparentColor = Color.Magenta;
            tsbDeletePosition.Name = "tsbDeletePosition";
            tsbDeletePosition.Size = new Size(81, 24);
            tsbDeletePosition.Text = "Xoá";
            tsbDeletePosition.Click += tsbDeletePosition_Click;
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(81, 6);
            // 
            // tsbExitPosition
            // 
            tsbExitPosition.Image = (Image)resources.GetObject("tsbExitPosition.Image");
            tsbExitPosition.ImageAlign = ContentAlignment.MiddleLeft;
            tsbExitPosition.ImageTransparentColor = Color.Magenta;
            tsbExitPosition.Name = "tsbExitPosition";
            tsbExitPosition.Size = new Size(81, 24);
            tsbExitPosition.Text = "Thoát";
            tsbExitPosition.Click += tsbExitPosition_Click;
            // 
            // dtgvPosition
            // 
            dtgvPosition.AllowUserToAddRows = false;
            dtgvPosition.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dtgvPosition.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dtgvPosition.BackgroundColor = Color.White;
            dtgvPosition.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgvPosition.Columns.AddRange(new DataGridViewColumn[] { MACV, TENCV });
            dtgvPosition.Location = new Point(90, 26);
            dtgvPosition.MultiSelect = false;
            dtgvPosition.Name = "dtgvPosition";
            dtgvPosition.RowHeadersWidth = 51;
            dtgvPosition.Size = new Size(317, 393);
            dtgvPosition.TabIndex = 9;
            dtgvPosition.CellClick += dtgvPosition_CellClick;
            dtgvPosition.CellEndEdit += dtgvPosition_CellEndEdit;
            // 
            // MACV
            // 
            MACV.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            MACV.DataPropertyName = "MACV";
            MACV.HeaderText = "Mã chức vụ";
            MACV.MinimumWidth = 6;
            MACV.Name = "MACV";
            MACV.SortMode = DataGridViewColumnSortMode.Programmatic;
            // 
            // TENCV
            // 
            TENCV.DataPropertyName = "TENCV";
            TENCV.HeaderText = "Tên chức vụ";
            TENCV.MinimumWidth = 6;
            TENCV.Name = "TENCV";
            TENCV.SortMode = DataGridViewColumnSortMode.NotSortable;
            // 
            // fPosition
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Green;
            ClientSize = new Size(437, 449);
            Controls.Add(groupBox1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "fPosition";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Position";
            Load += fPosition_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dtgvPosition).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private ToolStrip toolStrip1;
        private ToolStripButton tsbAddPosition;
        private ToolStripSeparator toolStripSeparator1;
        private DataGridView dtgvPosition;
        private ToolStripLabel toolStripLabel1;
        private ToolStripSeparator toolStripSeparator2;
        private ToolStripSeparator toolStripSeparator3;
        private ToolStripButton tsbExitPosition;
        private ToolStripButton tsbDeletePosition;
        private DataGridViewTextBoxColumn MACV;
        private DataGridViewTextBoxColumn TENCV;
    }
}