namespace DoAnIE103
{
    partial class fAddPosition
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
            btAddPositionInFA = new Button();
            btCancelInFA = new Button();
            label1 = new Label();
            label2 = new Label();
            tbMaCVInFA = new TextBox();
            tbTenCVInFA = new TextBox();
            SuspendLayout();
            // 
            // btAddPositionInFA
            // 
            btAddPositionInFA.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btAddPositionInFA.ForeColor = SystemColors.ActiveCaptionText;
            btAddPositionInFA.Location = new Point(156, 140);
            btAddPositionInFA.Name = "btAddPositionInFA";
            btAddPositionInFA.Size = new Size(94, 29);
            btAddPositionInFA.TabIndex = 2;
            btAddPositionInFA.Text = "Thêm";
            btAddPositionInFA.UseVisualStyleBackColor = true;
            btAddPositionInFA.Click += btAddPositionInFA_Click;
            // 
            // btCancelInFA
            // 
            btCancelInFA.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btCancelInFA.Location = new Point(256, 140);
            btCancelInFA.Name = "btCancelInFA";
            btCancelInFA.Size = new Size(94, 29);
            btCancelInFA.TabIndex = 1;
            btCancelInFA.Text = "Hủy";
            btCancelInFA.UseVisualStyleBackColor = true;
            btCancelInFA.Click += btCancelInFA_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(38, 33);
            label1.Name = "label1";
            label1.Size = new Size(84, 20);
            label1.TabIndex = 2;
            label1.Text = "Mã chức vụ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(38, 86);
            label2.Name = "label2";
            label2.Size = new Size(86, 20);
            label2.TabIndex = 3;
            label2.Text = "Tên chức vụ";
            // 
            // tbMaCVInFA
            // 
            tbMaCVInFA.Location = new Point(143, 33);
            tbMaCVInFA.Name = "tbMaCVInFA";
            tbMaCVInFA.Size = new Size(209, 27);
            tbMaCVInFA.TabIndex = 0;
            // 
            // tbTenCVInFA
            // 
            tbTenCVInFA.Location = new Point(143, 86);
            tbTenCVInFA.Name = "tbTenCVInFA";
            tbTenCVInFA.Size = new Size(209, 27);
            tbTenCVInFA.TabIndex = 1;
            // 
            // fAddPosition
            // 
            AcceptButton = btAddPositionInFA;
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = btCancelInFA;
            ClientSize = new Size(383, 194);
            Controls.Add(tbTenCVInFA);
            Controls.Add(tbMaCVInFA);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btCancelInFA);
            Controls.Add(btAddPositionInFA);
            FormBorderStyle = FormBorderStyle.None;
            Name = "fAddPosition";
            Text = "fAddPosition";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btAddPositionInFA;
        private Button btCancelInFA;
        private Label label1;
        private Label label2;
        private TextBox tbMaCVInFA;
        private TextBox tbTenCVInFA;
    }
}