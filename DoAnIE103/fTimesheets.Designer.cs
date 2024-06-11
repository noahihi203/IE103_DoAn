namespace DoAnIE103
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
            groupBox1 = new GroupBox();
            button1 = new Button();
            button2 = new Button();
            dtgvTimesheet = new DataGridView();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtgvTimesheet).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(dtgvTimesheet);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(534, 426);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Hiển thị danh sách nhân viên kèm số ngày đi làm, số ngày vắng";
            // 
            // button1
            // 
            button1.Location = new Point(569, 286);
            button1.Name = "button1";
            button1.Size = new Size(94, 68);
            button1.TabIndex = 2;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(569, 370);
            button2.Name = "button2";
            button2.Size = new Size(94, 68);
            button2.TabIndex = 3;
            button2.Text = "button2";
            button2.UseVisualStyleBackColor = true;
            // 
            // dtgvTimesheet
            // 
            dtgvTimesheet.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgvTimesheet.Location = new Point(6, 47);
            dtgvTimesheet.Name = "dtgvTimesheet";
            dtgvTimesheet.RowHeadersWidth = 51;
            dtgvTimesheet.Size = new Size(300, 188);
            dtgvTimesheet.TabIndex = 0;
            // 
            // fTimesheets
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(687, 450);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(groupBox1);
            Name = "fTimesheets";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Bảng công";
            groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dtgvTimesheet).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private GroupBox groupBox1;
        private Button button1;
        private Button button2;
        private DataGridView dtgvTimesheet;
    }
}