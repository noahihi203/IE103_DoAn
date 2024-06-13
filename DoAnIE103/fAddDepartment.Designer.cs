namespace DoAnIE103
{
    partial class fAddDepartment
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
            tbTenPBInFA = new TextBox();
            tbMaPBInFA = new TextBox();
            label2 = new Label();
            label1 = new Label();
            btCancelInFA = new Button();
            btAddPositionInFA = new Button();
            SuspendLayout();
            // 
            // tbTenPBInFA
            // 
            tbTenPBInFA.BackColor = Color.FromArgb(255, 224, 192);
            tbTenPBInFA.BorderStyle = BorderStyle.FixedSingle;
            tbTenPBInFA.Location = new Point(126, 62);
            tbTenPBInFA.Name = "tbTenPBInFA";
            tbTenPBInFA.Size = new Size(209, 27);
            tbTenPBInFA.TabIndex = 5;
            // 
            // tbMaPBInFA
            // 
            tbMaPBInFA.BackColor = Color.FromArgb(255, 224, 192);
            tbMaPBInFA.BorderStyle = BorderStyle.FixedSingle;
            tbMaPBInFA.Location = new Point(124, 9);
            tbMaPBInFA.Name = "tbMaPBInFA";
            tbMaPBInFA.Size = new Size(209, 27);
            tbMaPBInFA.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 62);
            label2.Name = "label2";
            label2.Size = new Size(108, 20);
            label2.TabIndex = 9;
            label2.Text = "Tên phòng ban";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(106, 20);
            label1.TabIndex = 7;
            label1.Text = "Mã phòng ban";
            // 
            // btCancelInFA
            // 
            btCancelInFA.BackColor = Color.FromArgb(255, 255, 192);
            btCancelInFA.FlatStyle = FlatStyle.Popup;
            btCancelInFA.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btCancelInFA.Location = new Point(230, 116);
            btCancelInFA.Name = "btCancelInFA";
            btCancelInFA.Size = new Size(94, 29);
            btCancelInFA.TabIndex = 6;
            btCancelInFA.Text = "Hủy";
            btCancelInFA.UseVisualStyleBackColor = false;
            btCancelInFA.Click += btCancelInFA_Click_1;
            // 
            // btAddPositionInFA
            // 
            btAddPositionInFA.BackColor = Color.FromArgb(255, 255, 192);
            btAddPositionInFA.FlatStyle = FlatStyle.Popup;
            btAddPositionInFA.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btAddPositionInFA.ForeColor = SystemColors.ActiveCaptionText;
            btAddPositionInFA.Location = new Point(130, 116);
            btAddPositionInFA.Name = "btAddPositionInFA";
            btAddPositionInFA.Size = new Size(94, 29);
            btAddPositionInFA.TabIndex = 8;
            btAddPositionInFA.Text = "Thêm";
            btAddPositionInFA.UseVisualStyleBackColor = false;
            btAddPositionInFA.Click += btAddPositionInFA_Click_1;
            // 
            // fAddDepartment
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(192, 255, 192);
            ClientSize = new Size(352, 165);
            Controls.Add(tbTenPBInFA);
            Controls.Add(tbMaPBInFA);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btCancelInFA);
            Controls.Add(btAddPositionInFA);
            FormBorderStyle = FormBorderStyle.None;
            Name = "fAddDepartment";
            Text = "Thêm phòng ban";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox tbTenPBInFA;
        private TextBox tbMaPBInFA;
        private Label label2;
        private Label label1;
        private Button btCancelInFA;
        private Button btAddPositionInFA;
    }
}