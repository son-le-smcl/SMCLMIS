namespace SMCL_MIS
{
    partial class frmSales
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
            SMCL_MIS.ctr_salemenu ctr_salemenu1;
            ctr_salemenu1 = new SMCL_MIS.ctr_salemenu();
            this.SuspendLayout();
            // 
            // ctr_salemenu1
            // 
            ctr_salemenu1.AutoSize = true;
            ctr_salemenu1.Dock = System.Windows.Forms.DockStyle.Top;
            ctr_salemenu1.Location = new System.Drawing.Point(0, 0);
            ctr_salemenu1.Name = "ctr_salemenu1";
            ctr_salemenu1.Size = new System.Drawing.Size(800, 26);
            ctr_salemenu1.TabIndex = 0;
            ctr_salemenu1.Load += new System.EventHandler(this.ctr_salemenu1_Load);
            // 
            // frmSales
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(ctr_salemenu1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmSales";
            this.Text = "SALES ORDER";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
    }
}