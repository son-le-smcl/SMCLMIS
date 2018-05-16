namespace SMCL_MIS
{
    partial class frm_Settings
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
            this.crt_Settingsmenu1 = new SMCL_MIS.crt_Settingsmenu();
            this.SuspendLayout();
            // 
            // crt_Settingsmenu1
            // 
            this.crt_Settingsmenu1.Dock = System.Windows.Forms.DockStyle.Top;
            this.crt_Settingsmenu1.Location = new System.Drawing.Point(0, 0);
            this.crt_Settingsmenu1.Name = "crt_Settingsmenu1";
            this.crt_Settingsmenu1.Size = new System.Drawing.Size(800, 23);
            this.crt_Settingsmenu1.TabIndex = 0;
            // 
            // frm_Settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.crt_Settingsmenu1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_Settings";
            this.Text = "frm_Settings";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);

        }

        #endregion

        private crt_Settingsmenu crt_Settingsmenu1;
    }
}