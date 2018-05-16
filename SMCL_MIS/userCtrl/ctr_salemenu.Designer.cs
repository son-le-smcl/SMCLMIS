namespace SMCL_MIS
{
    partial class ctr_salemenu
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.frmSales = new System.Windows.Forms.ToolStripMenuItem();
            this.frmSO = new System.Windows.Forms.ToolStripMenuItem();
            this.frmSosummary = new System.Windows.Forms.ToolStripMenuItem();
            this.Customer = new System.Windows.Forms.ToolStripMenuItem();
            this.frmCustomer = new System.Windows.Forms.ToolStripMenuItem();
            this.button1 = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.frmSales,
            this.Customer});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(493, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // frmSales
            // 
            this.frmSales.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.frmSO,
            this.frmSosummary});
            this.frmSales.Name = "frmSales";
            this.frmSales.Size = new System.Drawing.Size(73, 20);
            this.frmSales.Text = "Sale Order";
            // 
            // frmSO
            // 
            this.frmSO.Name = "frmSO";
            this.frmSO.Size = new System.Drawing.Size(187, 22);
            this.frmSO.Text = "Sale Order";
            // 
            // frmSosummary
            // 
            this.frmSosummary.Name = "frmSosummary";
            this.frmSosummary.Size = new System.Drawing.Size(187, 22);
            this.frmSosummary.Text = "Sales Order Summary";
            // 
            // Customer
            // 
            this.Customer.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.frmCustomer});
            this.Customer.Name = "Customer";
            this.Customer.Size = new System.Drawing.Size(71, 20);
            this.Customer.Text = "Customer";
            // 
            // frmCustomer
            // 
            this.frmCustomer.Name = "frmCustomer";
            this.frmCustomer.Size = new System.Drawing.Size(126, 22);
            this.frmCustomer.Text = "Customer";
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Location = new System.Drawing.Point(460, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(30, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "X";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ctr_salemenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.Controls.Add(this.button1);
            this.Controls.Add(this.menuStrip1);
            this.Name = "ctr_salemenu";
            this.Size = new System.Drawing.Size(493, 26);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem frmSales;
        private System.Windows.Forms.ToolStripMenuItem frmSO;
        private System.Windows.Forms.ToolStripMenuItem frmSosummary;
        private System.Windows.Forms.ToolStripMenuItem Customer;
        private System.Windows.Forms.ToolStripMenuItem frmCustomer;
        private System.Windows.Forms.Button button1;
    }
}
