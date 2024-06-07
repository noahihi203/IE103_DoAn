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
            btDangNhap = new Button();
            btThoat = new Button();
            label1 = new Label();
            tbTenDangNhap = new TextBox();
            tbMatKhau = new TextBox();
            label2 = new Label();
            checkBox1 = new CheckBox();
            SuspendLayout();
            // 
            // btDangNhap
            // 
            btDangNhap.ImageAlign = ContentAlignment.MiddleLeft;
            btDangNhap.Location = new Point(170, 130);
            btDangNhap.Margin = new Padding(6, 4, 6, 4);
            btDangNhap.Name = "btDangNhap";
            btDangNhap.Size = new Size(116, 30);
            btDangNhap.TabIndex = 2;
            btDangNhap.Text = "Đăng nhập";
            btDangNhap.UseVisualStyleBackColor = true;
            btDangNhap.Click += btDangNhap_Click;
            // 
            // btThoat
            // 
            btThoat.Location = new Point(319, 130);
            btThoat.Margin = new Padding(6, 4, 6, 4);
            btThoat.Name = "btThoat";
            btThoat.Size = new Size(99, 30);
            btThoat.TabIndex = 3;
            btThoat.Text = "Thoát";
            btThoat.UseVisualStyleBackColor = true;
            btThoat.Click += btThoat_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(38, 16);
            label1.Margin = new Padding(6, 0, 6, 0);
            label1.Name = "label1";
            label1.Size = new Size(101, 21);
            label1.TabIndex = 2;
            label1.Text = "Tài khoản:";
            // 
            // tbTenDangNhap
            // 
            tbTenDangNhap.Location = new Point(148, 12);
            tbTenDangNhap.Margin = new Padding(6, 4, 6, 4);
            tbTenDangNhap.Name = "tbTenDangNhap";
            tbTenDangNhap.Size = new Size(274, 28);
            tbTenDangNhap.TabIndex = 0;
            // 
            // tbMatKhau
            // 
            tbMatKhau.Location = new Point(148, 58);
            tbMatKhau.Margin = new Padding(6, 4, 6, 4);
            tbMatKhau.Name = "tbMatKhau";
            tbMatKhau.Size = new Size(274, 28);
            tbMatKhau.TabIndex = 1;
            tbMatKhau.UseSystemPasswordChar = true;
            tbMatKhau.UseWaitCursor = true;
            tbMatKhau.Enter += tbMatKhau_Enter;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(44, 63);
            label2.Margin = new Padding(6, 0, 6, 0);
            label2.Name = "label2";
            label2.Size = new Size(95, 21);
            label2.TabIndex = 5;
            label2.Text = "Mật khẩu:";
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Font = new Font("Arial Narrow", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            checkBox1.Location = new Point(148, 93);
            checkBox1.Margin = new Padding(6, 4, 6, 4);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(114, 24);
            checkBox1.TabIndex = 4;
            checkBox1.Text = "Hiện mật khẩu";
            checkBox1.UseVisualStyleBackColor = true;
            checkBox1.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // flogin
            // 
            AcceptButton = btDangNhap;
            AutoScaleDimensions = new SizeF(11F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(486, 203);
            Controls.Add(checkBox1);
            Controls.Add(label2);
            Controls.Add(tbMatKhau);
            Controls.Add(tbTenDangNhap);
            Controls.Add(label1);
            Controls.Add(btThoat);
            Controls.Add(btDangNhap);
            Font = new Font("Arial", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Margin = new Padding(6, 4, 6, 4);
            Name = "flogin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            FormClosed += flogin_FormClosed;
            Enter += flogin_Enter;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btDangNhap;
        private Button btThoat;
        private Label label1;
        private TextBox tbTenDangNhap;
        private TextBox tbMatKhau;
        private Label label2;
        private CheckBox checkBox1;
    }
}
