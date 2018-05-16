namespace SMCL_MIS
{
    partial class ctr_whmenu
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
            this.receiptReturnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.receitpFromPOToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.returnByPOToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.issueReturnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.issueMaterialsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.returnMaterialsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.transferToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.adjustToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.frmTransaction = new System.Windows.Forms.ToolStripMenuItem();
            this.inventoryCheckToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.button1 = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.receiptReturnToolStripMenuItem,
            this.issueReturnToolStripMenuItem,
            this.transferToolStripMenuItem,
            this.adjustToolStripMenuItem,
            this.frmTransaction,
            this.inventoryCheckToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(734, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // receiptReturnToolStripMenuItem
            // 
            this.receiptReturnToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.receitpFromPOToolStripMenuItem,
            this.returnByPOToolStripMenuItem});
            this.receiptReturnToolStripMenuItem.Name = "receiptReturnToolStripMenuItem";
            this.receiptReturnToolStripMenuItem.Size = new System.Drawing.Size(98, 20);
            this.receiptReturnToolStripMenuItem.Text = "Receipt/Return";
            // 
            // receitpFromPOToolStripMenuItem
            // 
            this.receitpFromPOToolStripMenuItem.Name = "receitpFromPOToolStripMenuItem";
            this.receitpFromPOToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.receitpFromPOToolStripMenuItem.Text = "Receitp From PO";
            // 
            // returnByPOToolStripMenuItem
            // 
            this.returnByPOToolStripMenuItem.Name = "returnByPOToolStripMenuItem";
            this.returnByPOToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.returnByPOToolStripMenuItem.Text = "Return By PO";
            // 
            // issueReturnToolStripMenuItem
            // 
            this.issueReturnToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.issueMaterialsToolStripMenuItem,
            this.returnMaterialsToolStripMenuItem});
            this.issueReturnToolStripMenuItem.Name = "issueReturnToolStripMenuItem";
            this.issueReturnToolStripMenuItem.Size = new System.Drawing.Size(85, 20);
            this.issueReturnToolStripMenuItem.Text = "Issue/Return";
            // 
            // issueMaterialsToolStripMenuItem
            // 
            this.issueMaterialsToolStripMenuItem.Name = "issueMaterialsToolStripMenuItem";
            this.issueMaterialsToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.issueMaterialsToolStripMenuItem.Text = "Issue Materials";
            // 
            // returnMaterialsToolStripMenuItem
            // 
            this.returnMaterialsToolStripMenuItem.Name = "returnMaterialsToolStripMenuItem";
            this.returnMaterialsToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.returnMaterialsToolStripMenuItem.Text = "Return Materials";
            // 
            // transferToolStripMenuItem
            // 
            this.transferToolStripMenuItem.Name = "transferToolStripMenuItem";
            this.transferToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.transferToolStripMenuItem.Text = "Transfer";
            // 
            // adjustToolStripMenuItem
            // 
            this.adjustToolStripMenuItem.Name = "adjustToolStripMenuItem";
            this.adjustToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.adjustToolStripMenuItem.Text = "Adjust";
            // 
            // frmTransaction
            // 
            this.frmTransaction.Name = "frmTransaction";
            this.frmTransaction.Size = new System.Drawing.Size(121, 20);
            this.frmTransaction.Text = "Transaction History";
            //this.frmTransaction.Click += new System.EventHandler(this.frmTransaction_Click);
            // 
            // inventoryCheckToolStripMenuItem
            // 
            this.inventoryCheckToolStripMenuItem.Name = "inventoryCheckToolStripMenuItem";
            this.inventoryCheckToolStripMenuItem.Size = new System.Drawing.Size(105, 20);
            this.inventoryCheckToolStripMenuItem.Text = "Inventory Check";
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Location = new System.Drawing.Point(701, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(30, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "X";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ctr_whmenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.button1);
            this.Controls.Add(this.menuStrip1);
            this.Name = "ctr_whmenu";
            this.Size = new System.Drawing.Size(734, 26);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem receiptReturnToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem issueReturnToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem transferToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem adjustToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem frmTransaction;
        private System.Windows.Forms.ToolStripMenuItem inventoryCheckToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem receitpFromPOToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem returnByPOToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem issueMaterialsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem returnMaterialsToolStripMenuItem;
        private System.Windows.Forms.Button button1;
    }
}
