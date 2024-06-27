namespace QLNS
{
    partial class showRP
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
            this.cRPV = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // cRPV
            // 
            this.cRPV.ActiveViewIndex = -1;
            this.cRPV.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cRPV.Cursor = System.Windows.Forms.Cursors.Default;
            this.cRPV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cRPV.Location = new System.Drawing.Point(0, 0);
            this.cRPV.Name = "cRPV";
            this.cRPV.Size = new System.Drawing.Size(800, 450);
            this.cRPV.TabIndex = 0;
            // 
            // showRP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cRPV);
            this.Name = "showRP";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "showRP";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.showRP_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer cRPV;
    }
}