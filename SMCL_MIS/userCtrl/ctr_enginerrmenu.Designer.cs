namespace SMCL_MIS
{
    partial class ctr_enginerrmenu
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
            this.Materials = new System.Windows.Forms.ToolStripMenuItem();
            this.frmMaterials = new System.Windows.Forms.ToolStripMenuItem();
            this.frmImportMaterials = new System.Windows.Forms.ToolStripMenuItem();
            this.BOM = new System.Windows.Forms.ToolStripMenuItem();
            this.frmBOM = new System.Windows.Forms.ToolStripMenuItem();
            this.button1 = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Materials,
            this.BOM});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(514, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1"; 
            // 
            // Materials
            // 
            this.Materials.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.frmMaterials,
            this.frmImportMaterials});
            this.Materials.Name = "Materials";
            this.Materials.Size = new System.Drawing.Size(67, 20);
            this.Materials.Text = "Materials";
            // 
            // frmMaterials
            // 
            this.frmMaterials.Name = "frmMaterials";
            this.frmMaterials.Size = new System.Drawing.Size(180, 22);
            this.frmMaterials.Text = "Materials";
            // 
            // frmImportMaterials
            // 
            this.frmImportMaterials.Name = "frmImportMaterials";
            this.frmImportMaterials.Size = new System.Drawing.Size(180, 22);
            this.frmImportMaterials.Text = "Import Materials";
            // 
            // BOM
            // 
            this.BOM.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.frmBOM});
            this.BOM.Name = "BOM";
            this.BOM.Size = new System.Drawing.Size(46, 20);
            this.BOM.Text = "BOM";
            // 
            // frmBOM
            // 
            this.frmBOM.Name = "frmBOM";
            this.frmBOM.Size = new System.Drawing.Size(101, 22);
            this.frmBOM.Text = "BOM";
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Location = new System.Drawing.Point(484, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(30, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "X";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ctr_enginerrmenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.button1);
            this.Controls.Add(this.menuStrip1);
            this.Name = "ctr_enginerrmenu";
            this.Size = new System.Drawing.Size(514, 26);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem Materials;
        private System.Windows.Forms.ToolStripMenuItem BOM;
        private System.Windows.Forms.ToolStripMenuItem frmMaterials;
        private System.Windows.Forms.ToolStripMenuItem frmBOM;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ToolStripMenuItem frmImportMaterials;
    }
}
