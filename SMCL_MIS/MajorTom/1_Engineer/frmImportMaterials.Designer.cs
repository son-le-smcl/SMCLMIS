namespace SMCL_MIS
{
    partial class frmImportMaterials
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
            this.components = new System.ComponentModel.Container();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Part_number = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Part_Description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Part_Description2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Category = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Reference_number = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Customer_number = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Bom_UOM = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Rate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Po_UOM = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LeadTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MinQty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Part_Rank = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BOM_type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MakeOrBuy = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ErpType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Part_Location = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.selectExcelFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.selectFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.downloadTeamplateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnSave = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.ctr_enginerrmenu1 = new SMCL_MIS.ctr_enginerrmenu();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.status,
            this.Part_number,
            this.Part_Description,
            this.Part_Description2,
            this.Category,
            this.Reference_number,
            this.Customer_number,
            this.Bom_UOM,
            this.Rate,
            this.Po_UOM,
            this.LeadTime,
            this.MinQty,
            this.Part_Rank,
            this.BOM_type,
            this.MakeOrBuy,
            this.ErpType,
            this.Part_Location});
            this.dataGridView1.ContextMenuStrip = this.contextMenuStrip1;
            this.dataGridView1.Location = new System.Drawing.Point(12, 32);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(776, 362);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.dataGridView1_DataError);
            this.dataGridView1.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.dataGridView1_RowPostPaint);
            // 
            // status
            // 
            this.status.DataPropertyName = "status";
            this.status.Frozen = true;
            this.status.HeaderText = "Status";
            this.status.Name = "status";
            this.status.ReadOnly = true;
            this.status.Width = 43;
            // 
            // Part_number
            // 
            this.Part_number.DataPropertyName = "Part_number";
            this.Part_number.HeaderText = "Part_number";
            this.Part_number.Name = "Part_number";
            this.Part_number.ReadOnly = true;
            this.Part_number.Width = 43;
            // 
            // Part_Description
            // 
            this.Part_Description.DataPropertyName = "Part_Description";
            this.Part_Description.HeaderText = "Part_Description";
            this.Part_Description.Name = "Part_Description";
            this.Part_Description.ReadOnly = true;
            this.Part_Description.Width = 44;
            // 
            // Part_Description2
            // 
            this.Part_Description2.DataPropertyName = "Part_Description2";
            this.Part_Description2.HeaderText = "Part_Description2";
            this.Part_Description2.Name = "Part_Description2";
            this.Part_Description2.ReadOnly = true;
            this.Part_Description2.Width = 43;
            // 
            // Category
            // 
            this.Category.DataPropertyName = "Category";
            this.Category.HeaderText = "Category";
            this.Category.Name = "Category";
            this.Category.ReadOnly = true;
            this.Category.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Category.Width = 43;
            // 
            // Reference_number
            // 
            this.Reference_number.DataPropertyName = "Reference_number";
            this.Reference_number.HeaderText = "Reference_number";
            this.Reference_number.Name = "Reference_number";
            this.Reference_number.ReadOnly = true;
            this.Reference_number.Width = 43;
            // 
            // Customer_number
            // 
            this.Customer_number.DataPropertyName = "Customer_number";
            this.Customer_number.HeaderText = "Customer_number";
            this.Customer_number.Name = "Customer_number";
            this.Customer_number.ReadOnly = true;
            this.Customer_number.Width = 44;
            // 
            // Bom_UOM
            // 
            this.Bom_UOM.DataPropertyName = "Bom_UOM";
            this.Bom_UOM.HeaderText = "Bom_UOM";
            this.Bom_UOM.Name = "Bom_UOM";
            this.Bom_UOM.ReadOnly = true;
            this.Bom_UOM.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Bom_UOM.Width = 43;
            // 
            // Rate
            // 
            this.Rate.DataPropertyName = "Rate";
            this.Rate.HeaderText = "Rate";
            this.Rate.Name = "Rate";
            this.Rate.ReadOnly = true;
            this.Rate.Width = 43;
            // 
            // Po_UOM
            // 
            this.Po_UOM.DataPropertyName = "Po_UOM";
            this.Po_UOM.HeaderText = "Po_UOM";
            this.Po_UOM.Name = "Po_UOM";
            this.Po_UOM.ReadOnly = true;
            this.Po_UOM.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Po_UOM.Width = 43;
            // 
            // LeadTime
            // 
            this.LeadTime.DataPropertyName = "LeadTime";
            this.LeadTime.HeaderText = "LeadTime";
            this.LeadTime.Name = "LeadTime";
            this.LeadTime.ReadOnly = true;
            this.LeadTime.Width = 44;
            // 
            // MinQty
            // 
            this.MinQty.DataPropertyName = "MinQty";
            this.MinQty.HeaderText = "MinQty";
            this.MinQty.Name = "MinQty";
            this.MinQty.ReadOnly = true;
            this.MinQty.Width = 43;
            // 
            // Part_Rank
            // 
            this.Part_Rank.DataPropertyName = "Part_Rank";
            this.Part_Rank.HeaderText = "Part_Rank";
            this.Part_Rank.Name = "Part_Rank";
            this.Part_Rank.ReadOnly = true;
            this.Part_Rank.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Part_Rank.Width = 43;
            // 
            // BOM_type
            // 
            this.BOM_type.DataPropertyName = "BOM_type";
            this.BOM_type.HeaderText = "BOM_type";
            this.BOM_type.Name = "BOM_type";
            this.BOM_type.ReadOnly = true;
            this.BOM_type.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.BOM_type.Width = 43;
            // 
            // MakeOrBuy
            // 
            this.MakeOrBuy.DataPropertyName = "MakeOrBuy";
            this.MakeOrBuy.HeaderText = "MakeOrBuy";
            this.MakeOrBuy.Name = "MakeOrBuy";
            this.MakeOrBuy.ReadOnly = true;
            this.MakeOrBuy.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.MakeOrBuy.Width = 44;
            // 
            // ErpType
            // 
            this.ErpType.DataPropertyName = "ErpType";
            this.ErpType.HeaderText = "ErpType";
            this.ErpType.Name = "ErpType";
            this.ErpType.ReadOnly = true;
            this.ErpType.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ErpType.Width = 43;
            // 
            // Part_Location
            // 
            this.Part_Location.DataPropertyName = "Part_Location";
            this.Part_Location.HeaderText = "Part_Location";
            this.Part_Location.Name = "Part_Location";
            this.Part_Location.ReadOnly = true;
            this.Part_Location.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Part_Location.Width = 43;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.selectExcelFileToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(171, 26);
            // 
            // selectExcelFileToolStripMenuItem
            // 
            this.selectExcelFileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.selectFileToolStripMenuItem,
            this.downloadTeamplateToolStripMenuItem});
            this.selectExcelFileToolStripMenuItem.Name = "selectExcelFileToolStripMenuItem";
            this.selectExcelFileToolStripMenuItem.Size = new System.Drawing.Size(170, 22);
            this.selectExcelFileToolStripMenuItem.Text = "Import From Excel";
            // 
            // selectFileToolStripMenuItem
            // 
            this.selectFileToolStripMenuItem.Name = "selectFileToolStripMenuItem";
            this.selectFileToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.selectFileToolStripMenuItem.Text = "Select File";
            this.selectFileToolStripMenuItem.Click += new System.EventHandler(this.selectFileToolStripMenuItem_Click);
            // 
            // downloadTeamplateToolStripMenuItem
            // 
            this.downloadTeamplateToolStripMenuItem.Name = "downloadTeamplateToolStripMenuItem";
            this.downloadTeamplateToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.downloadTeamplateToolStripMenuItem.Text = "Download Template";
            this.downloadTeamplateToolStripMenuItem.Click += new System.EventHandler(this.downloadTeamplateToolStripMenuItem_Click);
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnSave.Location = new System.Drawing.Point(12, 415);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 2;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button1.Location = new System.Drawing.Point(93, 415);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "Reset";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.CheckPathExists = false;
            this.saveFileDialog1.DefaultExt = "xlsx";
            this.saveFileDialog1.FileName = "Materials_import_template";
            this.saveFileDialog1.ValidateNames = false;
            // 
            // ctr_enginerrmenu1
            // 
            this.ctr_enginerrmenu1.Dock = System.Windows.Forms.DockStyle.Top;
            this.ctr_enginerrmenu1.Location = new System.Drawing.Point(0, 0);
            this.ctr_enginerrmenu1.Name = "ctr_enginerrmenu1";
            this.ctr_enginerrmenu1.Size = new System.Drawing.Size(800, 26);
            this.ctr_enginerrmenu1.TabIndex = 1;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.DefaultExt = "xlsx";
            this.openFileDialog1.FileName = "Materials_import_template";
            // 
            // frmImportMaterials
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.ctr_enginerrmenu1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmImportMaterials";
            this.Text = "frmImportMaterials";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Activated += new System.EventHandler(this.frmImportMaterials_Activated);
            this.Load += new System.EventHandler(this.frmImportMaterials_Load);
            this.Shown += new System.EventHandler(this.frmImportMaterials_Shown);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.frmImportMaterials_Paint);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private ctr_enginerrmenu ctr_enginerrmenu1;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem selectExcelFileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem selectFileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem downloadTeamplateToolStripMenuItem;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.DataGridViewTextBoxColumn status;
        private System.Windows.Forms.DataGridViewTextBoxColumn Part_number;
        private System.Windows.Forms.DataGridViewTextBoxColumn Part_Description;
        private System.Windows.Forms.DataGridViewTextBoxColumn Part_Description2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Category;
        private System.Windows.Forms.DataGridViewTextBoxColumn Reference_number;
        private System.Windows.Forms.DataGridViewTextBoxColumn Customer_number;
        private System.Windows.Forms.DataGridViewTextBoxColumn Bom_UOM;
        private System.Windows.Forms.DataGridViewTextBoxColumn Rate;
        private System.Windows.Forms.DataGridViewTextBoxColumn Po_UOM;
        private System.Windows.Forms.DataGridViewTextBoxColumn LeadTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn MinQty;
        private System.Windows.Forms.DataGridViewTextBoxColumn Part_Rank;
        private System.Windows.Forms.DataGridViewTextBoxColumn BOM_type;
        private System.Windows.Forms.DataGridViewTextBoxColumn MakeOrBuy;
        private System.Windows.Forms.DataGridViewTextBoxColumn ErpType;
        private System.Windows.Forms.DataGridViewTextBoxColumn Part_Location;
    }
}