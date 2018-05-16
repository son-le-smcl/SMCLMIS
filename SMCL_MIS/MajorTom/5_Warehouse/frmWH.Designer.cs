namespace SMCL_MIS
{
    partial class frmWH
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
            this.ctr_whmenu1 = new SMCL_MIS.ctr_whmenu();
            this.SuspendLayout();
            // 
            // ctr_whmenu1
            // 
            this.ctr_whmenu1.Dock = System.Windows.Forms.DockStyle.Top;
            this.ctr_whmenu1.Location = new System.Drawing.Point(0, 0);
            this.ctr_whmenu1.Name = "ctr_whmenu1";
            this.ctr_whmenu1.Size = new System.Drawing.Size(800, 26);
            this.ctr_whmenu1.TabIndex = 0;
            // 
            // frmWH
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ctr_whmenu1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmWH";
            this.Text = "frmWH";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);

        }

        #endregion

        private ctr_whmenu ctr_whmenu1;
    }
}