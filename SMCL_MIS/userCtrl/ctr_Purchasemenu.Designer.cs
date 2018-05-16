namespace SMCL_MIS
{
    partial class ctr_Purchasemenu
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
            this.m_PO = new System.Windows.Forms.ToolStripMenuItem();
            this.frmPO = new System.Windows.Forms.ToolStripMenuItem();
            this.frmPOinfo = new System.Windows.Forms.ToolStripMenuItem();
            this.Supplier = new System.Windows.Forms.ToolStripMenuItem();
            this.frmSupplier = new System.Windows.Forms.ToolStripMenuItem();
            this.frmSupplierInfo = new System.Windows.Forms.ToolStripMenuItem();
            this.Quotation = new System.Windows.Forms.ToolStripMenuItem();
            this.frmQuotation = new System.Windows.Forms.ToolStripMenuItem();
            this.frm_Quoteinfo = new System.Windows.Forms.ToolStripMenuItem();
            this.button1 = new System.Windows.Forms.Button();
            this.frmUpdate_po_mat = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.m_PO,
            this.Supplier,
            this.Quotation,
            this.frmUpdate_po_mat});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(470, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // m_PO
            // 
            this.m_PO.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.frmPO,
            this.frmPOinfo});
            this.m_PO.Name = "m_PO";
            this.m_PO.Size = new System.Drawing.Size(100, 20);
            this.m_PO.Text = "Purchase Order";
            // 
            // frmPO
            // 
            this.frmPO.Name = "frmPO";
            this.frmPO.Size = new System.Drawing.Size(179, 22);
            this.frmPO.Text = "Purchase Order";
            // 
            // frmPOinfo
            // 
            this.frmPOinfo.Name = "frmPOinfo";
            this.frmPOinfo.Size = new System.Drawing.Size(179, 22);
            this.frmPOinfo.Text = "Purchase Order Info";
            // 
            // Supplier
            // 
            this.Supplier.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.frmSupplier,
            this.frmSupplierInfo});
            this.Supplier.Name = "Supplier";
            this.Supplier.Size = new System.Drawing.Size(62, 20);
            this.Supplier.Text = "Supplier";
            // 
            // frmSupplier
            // 
            this.frmSupplier.Name = "frmSupplier";
            this.frmSupplier.Size = new System.Drawing.Size(134, 22);
            this.frmSupplier.Text = "Suplier";
            // 
            // frmSupplierInfo
            // 
            this.frmSupplierInfo.Name = "frmSupplierInfo";
            this.frmSupplierInfo.Size = new System.Drawing.Size(134, 22);
            this.frmSupplierInfo.Text = "Suplier Info";
            // 
            // Quotation
            // 
            this.Quotation.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.frmQuotation,
            this.frm_Quoteinfo});
            this.Quotation.Name = "Quotation";
            this.Quotation.Size = new System.Drawing.Size(73, 20);
            this.Quotation.Text = "Quotation";
            // 
            // frmQuotation
            // 
            this.frmQuotation.Name = "frmQuotation";
            this.frmQuotation.Size = new System.Drawing.Size(152, 22);
            this.frmQuotation.Text = "Quotation";
            // 
            // frm_Quoteinfo
            // 
            this.frm_Quoteinfo.Name = "frm_Quoteinfo";
            this.frm_Quoteinfo.Size = new System.Drawing.Size(152, 22);
            this.frm_Quoteinfo.Text = "Quotation Info";
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Location = new System.Drawing.Point(440, -1);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(30, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "X";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // frmUpdate_po_mat
            // 
            this.frmUpdate_po_mat.Name = "frmUpdate_po_mat";
            this.frmUpdate_po_mat.Size = new System.Drawing.Size(103, 20);
            this.frmUpdate_po_mat.Text = "Update Material";
            // 
            // ctr_Purchasemenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.button1);
            this.Controls.Add(this.menuStrip1);
            this.Name = "ctr_Purchasemenu";
            this.Size = new System.Drawing.Size(470, 22);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem m_PO;
        private System.Windows.Forms.ToolStripMenuItem Supplier;
        private System.Windows.Forms.ToolStripMenuItem Quotation;
        private System.Windows.Forms.ToolStripMenuItem frmPO;
        private System.Windows.Forms.ToolStripMenuItem frmPOinfo;
        private System.Windows.Forms.ToolStripMenuItem frmSupplier;
        private System.Windows.Forms.ToolStripMenuItem frmSupplierInfo;
        private System.Windows.Forms.ToolStripMenuItem frmQuotation;
        private System.Windows.Forms.ToolStripMenuItem frm_Quoteinfo;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ToolStripMenuItem frmUpdate_po_mat;
    }
}
