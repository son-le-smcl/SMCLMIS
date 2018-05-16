namespace SMCL_MIS
{
    partial class ReportViewer
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
            this.rpViewer1 = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // rpViewer1
            // 
            this.rpViewer1.ActiveViewIndex = -1;
            this.rpViewer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rpViewer1.Cursor = System.Windows.Forms.Cursors.Default;
            this.rpViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rpViewer1.Location = new System.Drawing.Point(0, 0);
            this.rpViewer1.Name = "rpViewer1";
            this.rpViewer1.Size = new System.Drawing.Size(800, 450);
            this.rpViewer1.TabIndex = 0;
            // 
            // ReportViewer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.rpViewer1);
            this.Name = "ReportViewer";
            this.Text = "ReportViewer";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.ReportViewer_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer rpViewer1;
    }
}