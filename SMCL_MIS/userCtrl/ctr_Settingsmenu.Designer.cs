namespace SMCL_MIS
{
    partial class crt_Settingsmenu
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
            this.Usersetting = new System.Windows.Forms.ToolStripMenuItem();
            this.userSettupToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.userListToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.userErrorLogToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.userFormSettingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sOToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pOToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.wHToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.iTEquipmentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addUpdateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listEquipmentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.button1 = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Usersetting,
            this.userFormSettingToolStripMenuItem,
            this.iTEquipmentToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(452, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // Usersetting
            // 
            this.Usersetting.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.userSettupToolStripMenuItem,
            this.userListToolStripMenuItem,
            this.userErrorLogToolStripMenuItem});
            this.Usersetting.Name = "Usersetting";
            this.Usersetting.Size = new System.Drawing.Size(87, 20);
            this.Usersetting.Text = "User Settings";
            // 
            // userSettupToolStripMenuItem
            // 
            this.userSettupToolStripMenuItem.Name = "userSettupToolStripMenuItem";
            this.userSettupToolStripMenuItem.Size = new System.Drawing.Size(207, 22);
            this.userSettupToolStripMenuItem.Text = "Add/Remove/Permission";
            this.userSettupToolStripMenuItem.Click += new System.EventHandler(this.userSettupToolStripMenuItem_Click);
            // 
            // userListToolStripMenuItem
            // 
            this.userListToolStripMenuItem.Name = "userListToolStripMenuItem";
            this.userListToolStripMenuItem.Size = new System.Drawing.Size(207, 22);
            this.userListToolStripMenuItem.Text = "User List";
            this.userListToolStripMenuItem.Click += new System.EventHandler(this.userListToolStripMenuItem_Click);
            // 
            // userErrorLogToolStripMenuItem
            // 
            this.userErrorLogToolStripMenuItem.Name = "userErrorLogToolStripMenuItem";
            this.userErrorLogToolStripMenuItem.Size = new System.Drawing.Size(207, 22);
            this.userErrorLogToolStripMenuItem.Text = "User Error Log";
            this.userErrorLogToolStripMenuItem.Click += new System.EventHandler(this.userErrorLogToolStripMenuItem_Click);
            // 
            // userFormSettingToolStripMenuItem
            // 
            this.userFormSettingToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sOToolStripMenuItem,
            this.pOToolStripMenuItem,
            this.wHToolStripMenuItem});
            this.userFormSettingToolStripMenuItem.Name = "userFormSettingToolStripMenuItem";
            this.userFormSettingToolStripMenuItem.Size = new System.Drawing.Size(107, 20);
            this.userFormSettingToolStripMenuItem.Text = "UserFormSetting";
            // 
            // sOToolStripMenuItem
            // 
            this.sOToolStripMenuItem.Name = "sOToolStripMenuItem";
            this.sOToolStripMenuItem.Size = new System.Drawing.Size(94, 22);
            this.sOToolStripMenuItem.Text = "SO";
            // 
            // pOToolStripMenuItem
            // 
            this.pOToolStripMenuItem.Name = "pOToolStripMenuItem";
            this.pOToolStripMenuItem.Size = new System.Drawing.Size(94, 22);
            this.pOToolStripMenuItem.Text = "PO";
            // 
            // wHToolStripMenuItem
            // 
            this.wHToolStripMenuItem.Name = "wHToolStripMenuItem";
            this.wHToolStripMenuItem.Size = new System.Drawing.Size(94, 22);
            this.wHToolStripMenuItem.Text = "WH";
            // 
            // iTEquipmentToolStripMenuItem
            // 
            this.iTEquipmentToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addUpdateToolStripMenuItem,
            this.listEquipmentToolStripMenuItem});
            this.iTEquipmentToolStripMenuItem.Name = "iTEquipmentToolStripMenuItem";
            this.iTEquipmentToolStripMenuItem.Size = new System.Drawing.Size(90, 20);
            this.iTEquipmentToolStripMenuItem.Text = "IT Equipment";
            // 
            // addUpdateToolStripMenuItem
            // 
            this.addUpdateToolStripMenuItem.Name = "addUpdateToolStripMenuItem";
            this.addUpdateToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.addUpdateToolStripMenuItem.Text = "Add/Update";
            this.addUpdateToolStripMenuItem.Click += new System.EventHandler(this.addUpdateToolStripMenuItem_Click);
            // 
            // listEquipmentToolStripMenuItem
            // 
            this.listEquipmentToolStripMenuItem.Name = "listEquipmentToolStripMenuItem";
            this.listEquipmentToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.listEquipmentToolStripMenuItem.Text = "Scan for Equipment";
            this.listEquipmentToolStripMenuItem.Click += new System.EventHandler(this.listEquipmentToolStripMenuItem_Click);
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Location = new System.Drawing.Point(419, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(30, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "X";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // crt_Settingsmenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.button1);
            this.Controls.Add(this.menuStrip1);
            this.Name = "crt_Settingsmenu";
            this.Size = new System.Drawing.Size(452, 23);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem Usersetting;
        private System.Windows.Forms.ToolStripMenuItem userSettupToolStripMenuItem;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ToolStripMenuItem userFormSettingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sOToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pOToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem wHToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem iTEquipmentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem userErrorLogToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem userListToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addUpdateToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listEquipmentToolStripMenuItem;
    }
}
