namespace DoAnIE103
{
    partial class flogin
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            label4 = new Label();
            label3 = new Label();
            panel2 = new Panel();
            checkBox1 = new CheckBox();
            label2 = new Label();
            tbMatKhau = new TextBox();
            tbTenDangNhap = new TextBox();
            label1 = new Label();
            panel3 = new Panel();
            btThoat = new Button();
            btDangNhap = new Button();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(255, 192, 192);
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(486, 86);
            panel1.TabIndex = 6;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(12, 50);
            label4.Name = "label4";
            label4.Size = new Size(109, 27);
            label4.TabIndex = 9;
            label4.Text = "Nhóm 10";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(3, 10);
            label3.Name = "label3";
            label3.Size = new Size(456, 40);
            label3.TabIndex = 8;
            label3.Text = "Phần mềm quản lý nhân sự";
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(192, 255, 192);
            panel2.Controls.Add(checkBox1);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(tbMatKhau);
            panel2.Controls.Add(tbTenDangNhap);
            panel2.Controls.Add(label1);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 86);
            panel2.Name = "panel2";
            panel2.Size = new Size(486, 196);
            panel2.TabIndex = 7;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.BackColor = Color.FromArgb(192, 255, 192);
            checkBox1.Font = new Font("Arial Narrow", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            checkBox1.Location = new Point(116, 86);
            checkBox1.Margin = new Padding(6, 4, 6, 4);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(114, 24);
            checkBox1.TabIndex = 9;
            checkBox1.Text = "Hiện mật khẩu";
            checkBox1.UseVisualStyleBackColor = false;
            checkBox1.CheckedChanged += checkBox1_CheckedChanged_1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 56);
            label2.Margin = new Padding(6, 0, 6, 0);
            label2.Name = "label2";
            label2.Size = new Size(95, 21);
            label2.TabIndex = 10;
            label2.Text = "Mật khẩu:";
            // 
            // tbMatKhau
            // 
            tbMatKhau.BackColor = Color.FromArgb(255, 224, 192);
            tbMatKhau.BorderStyle = BorderStyle.FixedSingle;
            tbMatKhau.Location = new Point(116, 51);
            tbMatKhau.Margin = new Padding(6, 4, 6, 4);
            tbMatKhau.Name = "tbMatKhau";
            tbMatKhau.Size = new Size(195, 28);
            tbMatKhau.TabIndex = 7;
            tbMatKhau.UseSystemPasswordChar = true;
            tbMatKhau.UseWaitCursor = true;
            // 
            // tbTenDangNhap
            // 
            tbTenDangNhap.BackColor = Color.FromArgb(255, 224, 192);
            tbTenDangNhap.BorderStyle = BorderStyle.FixedSingle;
            tbTenDangNhap.Location = new Point(116, 5);
            tbTenDangNhap.Margin = new Padding(6, 4, 6, 4);
            tbTenDangNhap.Name = "tbTenDangNhap";
            tbTenDangNhap.Size = new Size(195, 28);
            tbTenDangNhap.TabIndex = 6;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 9);
            label1.Margin = new Padding(6, 0, 6, 0);
            label1.Name = "label1";
            label1.Size = new Size(101, 21);
            label1.TabIndex = 8;
            label1.Text = "Tài khoản:";
            // 
            // panel3
            // 
            panel3.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            panel3.BackColor = Color.FromArgb(192, 255, 192);
            panel3.Controls.Add(btThoat);
            panel3.Controls.Add(btDangNhap);
            panel3.Location = new Point(229, 222);
            panel3.Name = "panel3";
            panel3.Size = new Size(245, 48);
            panel3.TabIndex = 8;
            // 
            // btThoat
            // 
            btThoat.BackColor = Color.FromArgb(255, 255, 192);
            btThoat.FlatStyle = FlatStyle.Popup;
            btThoat.Location = new Point(140, 14);
            btThoat.Margin = new Padding(6, 4, 6, 4);
            btThoat.Name = "btThoat";
            btThoat.Size = new Size(99, 30);
            btThoat.TabIndex = 5;
            btThoat.Text = "Thoát";
            btThoat.UseVisualStyleBackColor = false;
            btThoat.Click += btThoat_Click_1;
            // 
            // btDangNhap
            // 
            btDangNhap.BackColor = Color.FromArgb(255, 255, 192);
            btDangNhap.FlatStyle = FlatStyle.Popup;
            btDangNhap.ImageAlign = ContentAlignment.MiddleLeft;
            btDangNhap.Location = new Point(12, 14);
            btDangNhap.Margin = new Padding(6, 4, 6, 4);
            btDangNhap.Name = "btDangNhap";
            btDangNhap.Size = new Size(116, 30);
            btDangNhap.TabIndex = 4;
            btDangNhap.Text = "Đăng nhập";
            btDangNhap.UseVisualStyleBackColor = false;
            btDangNhap.Click += btDangNhap_Click_1;
            // 
            // flogin
            // 
            AutoScaleDimensions = new SizeF(11F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(192, 255, 192);
            ClientSize = new Size(486, 282);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Font = new Font("Arial", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(6, 4, 6, 4);
            Name = "flogin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            FormClosed += flogin_FormClosed;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private Panel panel1;
        private Label label4;
        private Label label3;
        private Panel panel2;
        private CheckBox checkBox1;
        private Label label2;
        private TextBox tbMatKhau;
        private TextBox tbTenDangNhap;
        private Label label1;
        private Panel panel3;
        private Button btThoat;
        private Button btDangNhap;
    }
}
