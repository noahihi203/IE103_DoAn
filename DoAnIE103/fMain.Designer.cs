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
            tbHoTen = new TextBox();
            groupBox1 = new GroupBox();
            btTimKiem = new Button();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            comboBox1 = new ComboBox();
            dateTimePicker1 = new DateTimePicker();
            tbMaNV = new TextBox();
            dtgvEmPloyee = new DataGridView();
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
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtgvEmPloyee).BeginInit();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // tbHoTen
            // 
            tbHoTen.Location = new Point(180, 44);
            tbHoTen.Name = "tbHoTen";
            tbHoTen.Size = new Size(210, 28);
            tbHoTen.TabIndex = 1;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btTimKiem);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(comboBox1);
            groupBox1.Controls.Add(dateTimePicker1);
            groupBox1.Controls.Add(tbMaNV);
            groupBox1.Controls.Add(tbHoTen);
            groupBox1.Location = new Point(12, 73);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1038, 228);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "Tìm kiếm";
            // 
            // btTimKiem
            // 
            btTimKiem.Location = new Point(835, 176);
            btTimKiem.Name = "btTimKiem";
            btTimKiem.Size = new Size(134, 29);
            btTimKiem.TabIndex = 9;
            btTimKiem.Text = "Tìm kiếm";
            btTimKiem.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(500, 114);
            label4.Name = "label4";
            label4.Size = new Size(104, 21);
            label4.TabIndex = 8;
            label4.Text = "Ngày sinh:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(512, 48);
            label3.Name = "label3";
            label3.Size = new Size(92, 21);
            label3.TabIndex = 7;
            label3.Text = "Giới tính:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(42, 111);
            label2.Name = "label2";
            label2.Size = new Size(132, 21);
            label2.TabIndex = 6;
            label2.Text = "Mã nhân viên:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(75, 47);
            label1.Name = "label1";
            label1.Size = new Size(99, 21);
            label1.TabIndex = 5;
            label1.Text = "Họ và tên:";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(610, 44);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(151, 29);
            comboBox1.TabIndex = 4;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(610, 111);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(335, 28);
            dateTimePicker1.TabIndex = 3;
            // 
            // tbMaNV
            // 
            tbMaNV.Location = new Point(180, 111);
            tbMaNV.Name = "tbMaNV";
            tbMaNV.Size = new Size(210, 28);
            tbMaNV.TabIndex = 2;
            // 
            // dtgvEmPloyee
            // 
            dtgvEmPloyee.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgvEmPloyee.Location = new Point(12, 307);
            dtgvEmPloyee.Name = "dtgvEmPloyee";
            dtgvEmPloyee.RowHeadersWidth = 51;
            dtgvEmPloyee.Size = new Size(1038, 341);
            dtgvEmPloyee.TabIndex = 3;
            // 
            // hệThốngToolStripMenuItem
            // 
            hệThốngToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { tsmiUser, đăngXuấtToolStripMenuItem });
            hệThốngToolStripMenuItem.Image = (Image)resources.GetObject("hệThốngToolStripMenuItem.Image");
            hệThốngToolStripMenuItem.Name = "hệThốngToolStripMenuItem";
            hệThốngToolStripMenuItem.Size = new Size(105, 24);
            hệThốngToolStripMenuItem.Text = "Hệ thống";
            // 
            // tsmiUser
            // 
            tsmiUser.Image = (Image)resources.GetObject("tsmiUser.Image");
            tsmiUser.Name = "tsmiUser";
            tsmiUser.Size = new Size(207, 26);
            tsmiUser.Text = "Quản lý tài khoản";
            tsmiUser.Click += tsmiUser_Click;
            // 
            // đăngXuấtToolStripMenuItem
            // 
            đăngXuấtToolStripMenuItem.Image = (Image)resources.GetObject("đăngXuấtToolStripMenuItem.Image");
            đăngXuấtToolStripMenuItem.Name = "đăngXuấtToolStripMenuItem";
            đăngXuấtToolStripMenuItem.Size = new Size(207, 26);
            đăngXuấtToolStripMenuItem.Text = "Đăng xuất";
            đăngXuấtToolStripMenuItem.Click += đăngXuấtToolStripMenuItem_Click;
            // 
            // quảnLýToolStripMenuItem
            // 
            quảnLýToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { tsmiEmployee, tsmiPhongBan, tsmiChucVu });
            quảnLýToolStripMenuItem.Name = "quảnLýToolStripMenuItem";
            quảnLýToolStripMenuItem.Size = new Size(73, 24);
            quảnLýToolStripMenuItem.Text = "Quản lý";
            quảnLýToolStripMenuItem.Click += quảnLýToolStripMenuItem_Click;
            // 
            // tsmiEmployee
            // 
            tsmiEmployee.Name = "tsmiEmployee";
            tsmiEmployee.Size = new Size(224, 26);
            tsmiEmployee.Text = "Quản lý nhân viên";
            tsmiEmployee.Click += tsmiEmployee_Click;
            // 
            // tsmiPhongBan
            // 
            tsmiPhongBan.Name = "tsmiPhongBan";
            tsmiPhongBan.Size = new Size(224, 26);
            tsmiPhongBan.Text = "Quản lý phòng ban";
            tsmiPhongBan.Click += tsmiPhongBan_Click;
            // 
            // tsmiChucVu
            // 
            tsmiChucVu.Name = "tsmiChucVu";
            tsmiChucVu.Size = new Size(224, 26);
            tsmiChucVu.Text = "Quản lý chức vụ";
            tsmiChucVu.Click += tsmiChucVu_Click;
            // 
            // thốngKêToolStripMenuItem
            // 
            thốngKêToolStripMenuItem.Name = "thốngKêToolStripMenuItem";
            thốngKêToolStripMenuItem.Size = new Size(84, 24);
            thốngKêToolStripMenuItem.Text = "Thống kê";
            // 
            // trợGiúpToolStripMenuItem
            // 
            trợGiúpToolStripMenuItem.Name = "trợGiúpToolStripMenuItem";
            trợGiúpToolStripMenuItem.Size = new Size(78, 24);
            trợGiúpToolStripMenuItem.Text = "Trợ giúp";
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { hệThốngToolStripMenuItem, quảnLýToolStripMenuItem, thốngKêToolStripMenuItem, trợGiúpToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1062, 28);
            menuStrip1.TabIndex = 4;
            menuStrip1.Text = "menuStrip1";
            // 
            // fMain
            // 
            AutoScaleDimensions = new SizeF(11F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1062, 660);
            Controls.Add(dtgvEmPloyee);
            Controls.Add(groupBox1);
            Controls.Add(menuStrip1);
            Font = new Font("Arial", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Margin = new Padding(4, 3, 4, 3);
            Name = "fMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Main";
            FormClosing += fMain_FormClosing;
            FormClosed += fMain_FormClosed;
            Load += fMain_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dtgvEmPloyee).EndInit();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox tbHoTen;
        private GroupBox groupBox1;
        private DateTimePicker dateTimePicker1;
        private TextBox tbMaNV;
        private ComboBox comboBox1;
        private Label label2;
        private Label label1;
        private Button btTimKiem;
        private Label label4;
        private Label label3;
        private DataGridView dtgvEmPloyee;
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
    }
}