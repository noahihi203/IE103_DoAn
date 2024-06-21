using System.Drawing.Printing;
using System.Drawing;
using System.Windows.Forms;
namespace QLNS
{
    partial class fTimesheets
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
            dtgvTimesheet = new DataGridView();
            HOTEN = new DataGridViewTextBoxColumn();
            MABC = new DataGridViewTextBoxColumn();
            THANG = new DataGridViewTextBoxColumn();
            SONGAYLAM = new DataGridViewTextBoxColumn();
            SONGAYNGHI = new DataGridViewTextBoxColumn();
            GHICHU = new DataGridViewTextBoxColumn();
            groupBox1 = new GroupBox();
            btExit = new Button();
            ((System.ComponentModel.ISupportInitialize)dtgvTimesheet).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // dtgvTimesheet
            // 
            dtgvTimesheet.AllowUserToAddRows = false;
            dtgvTimesheet.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dtgvTimesheet.BackgroundColor = Color.White;
            dtgvTimesheet.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgvTimesheet.Columns.AddRange(new DataGridViewColumn[] { HOTEN, MABC, THANG, SONGAYLAM, SONGAYNGHI, GHICHU });
            dtgvTimesheet.Location = new Point(6, 26);
            dtgvTimesheet.Name = "dtgvTimesheet";
            dtgvTimesheet.RowHeadersVisible = false;
            dtgvTimesheet.RowHeadersWidth = 51;
            dtgvTimesheet.Size = new Size(690, 393);
            dtgvTimesheet.TabIndex = 0;
            // 
            // HOTEN
            // 
            HOTEN.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            HOTEN.DataPropertyName = "HOTEN";
            HOTEN.HeaderText = "Họ và tên";
            HOTEN.MinimumWidth = 6;
            HOTEN.Name = "HOTEN";
            HOTEN.ReadOnly = true;
            HOTEN.Width = 115;
            // 
            // MABC
            // 
            MABC.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            MABC.DataPropertyName = "MABC";
            MABC.HeaderText = "Mã bảng công";
            MABC.MinimumWidth = 6;
            MABC.Name = "MABC";
            MABC.ReadOnly = true;
            // 
            // THANG
            // 
            THANG.DataPropertyName = "THANG";
            THANG.HeaderText = "Tháng";
            THANG.MinimumWidth = 6;
            THANG.Name = "THANG";
            THANG.ReadOnly = true;
            // 
            // SONGAYLAM
            // 
            SONGAYLAM.DataPropertyName = "SONGAYLAM";
            SONGAYLAM.HeaderText = "Số ngày làm";
            SONGAYLAM.MinimumWidth = 6;
            SONGAYLAM.Name = "SONGAYLAM";
            SONGAYLAM.ReadOnly = true;
            // 
            // SONGAYNGHI
            // 
            SONGAYNGHI.DataPropertyName = "SONGAYNGHI";
            SONGAYNGHI.HeaderText = "Số ngày nghỉ";
            SONGAYNGHI.MinimumWidth = 6;
            SONGAYNGHI.Name = "SONGAYNGHI";
            SONGAYNGHI.ReadOnly = true;
            // 
            // GHICHU
            // 
            GHICHU.DataPropertyName = "GHICHU";
            GHICHU.HeaderText = "Ghi chú";
            GHICHU.MinimumWidth = 6;
            GHICHU.Name = "GHICHU";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(dtgvTimesheet);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(702, 405);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Danh sách bảng công";
            // 
            // btExit
            // 
            btExit.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btExit.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btExit.BackColor = Color.FromArgb(255, 255, 192);
            btExit.FlatStyle = FlatStyle.Popup;
            btExit.Location = new Point(618, 437);
            btExit.Name = "btExit";
            btExit.Size = new Size(89, 29);
            btExit.TabIndex = 3;
            btExit.Text = "Thoát";
            btExit.UseVisualStyleBackColor = false;
            btExit.Click += btExit_Click_1;
            // 
            // fTimesheets
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(192, 255, 192);
            ClientSize = new Size(719, 478);
            ControlBox = false;
            Controls.Add(btExit);
            Controls.Add(groupBox1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "fTimesheets";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Bảng công";
            Load += fTimesheets_Load;
            ((System.ComponentModel.ISupportInitialize)dtgvTimesheet).EndInit();
            groupBox1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private DataGridView dtgvTimesheet;
        private GroupBox groupBox1;
        private DataGridViewTextBoxColumn HOTEN;
        private DataGridViewTextBoxColumn MABC;
        private DataGridViewTextBoxColumn THANG;
        private DataGridViewTextBoxColumn SONGAYLAM;
        private DataGridViewTextBoxColumn SONGAYNGHI;
        private DataGridViewTextBoxColumn GHICHU;
        private Button btExit;
    }
}