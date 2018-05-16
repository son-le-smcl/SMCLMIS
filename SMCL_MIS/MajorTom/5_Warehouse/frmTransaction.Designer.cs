namespace SMCL_MIS
{
    partial class frmTransaction
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_search = new System.Windows.Forms.Button();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.exportToExcelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ctr_whmenu1 = new SMCL_MIS.ctr_whmenu();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dp_podate1 = new System.Windows.Forms.DateTimePicker();
            this.dp_podate2 = new System.Windows.Forms.DateTimePicker();
            this.txt_search = new System.Windows.Forms.TextBox();
            this.cb_loc = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cb_trntype = new System.Windows.Forms.ComboBox();
            this.Type = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Type);
            this.groupBox1.Controls.Add(this.cb_trntype);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.cb_loc);
            this.groupBox1.Controls.Add(this.txt_search);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.btn_search);
            this.groupBox1.Controls.Add(this.dp_podate2);
            this.groupBox1.Controls.Add(this.dp_podate1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 32);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(511, 105);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Transaction";
            // 
            // btn_search
            // 
            this.btn_search.Location = new System.Drawing.Point(430, 20);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(75, 23);
            this.btn_search.TabIndex = 24;
            this.btn_search.Text = "Search";
            this.btn_search.UseVisualStyleBackColor = true;
            this.btn_search.Click += new System.EventHandler(this.btn_search_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exportToExcelToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(153, 26);
            // 
            // exportToExcelToolStripMenuItem
            // 
            this.exportToExcelToolStripMenuItem.Name = "exportToExcelToolStripMenuItem";
            this.exportToExcelToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.exportToExcelToolStripMenuItem.Text = "Export To Excel";
            this.exportToExcelToolStripMenuItem.Click += new System.EventHandler(this.exportToExcelToolStripMenuItem_Click);
            // 
            // ctr_whmenu1
            // 
            this.ctr_whmenu1.Dock = System.Windows.Forms.DockStyle.Top;
            this.ctr_whmenu1.Location = new System.Drawing.Point(0, 0);
            this.ctr_whmenu1.Name = "ctr_whmenu1";
            this.ctr_whmenu1.Size = new System.Drawing.Size(800, 26);
            this.ctr_whmenu1.TabIndex = 0;
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.ContextMenuStrip = this.contextMenuStrip1;
            this.dataGridView1.Location = new System.Drawing.Point(12, 143);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(776, 295);
            this.dataGridView1.TabIndex = 4;
            this.dataGridView1.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.dataGridView1_RowPostPaint);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "From Date";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "To Date";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 75);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 13);
            this.label4.TabIndex = 27;
            this.label4.Text = "Search";
            // 
            // dp_podate1
            // 
            this.dp_podate1.CustomFormat = "yyyy-MM-01 HH:mm:ss";
            this.dp_podate1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dp_podate1.Location = new System.Drawing.Point(68, 20);
            this.dp_podate1.Name = "dp_podate1";
            this.dp_podate1.Size = new System.Drawing.Size(155, 20);
            this.dp_podate1.TabIndex = 22;
            // 
            // dp_podate2
            // 
            this.dp_podate2.CustomFormat = "yyyy-MM-dd HH:mm:ss";
            this.dp_podate2.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dp_podate2.Location = new System.Drawing.Point(68, 46);
            this.dp_podate2.Name = "dp_podate2";
            this.dp_podate2.Size = new System.Drawing.Size(155, 20);
            this.dp_podate2.TabIndex = 23;
            // 
            // txt_search
            // 
            this.txt_search.Location = new System.Drawing.Point(68, 72);
            this.txt_search.Name = "txt_search";
            this.txt_search.Size = new System.Drawing.Size(155, 20);
            this.txt_search.TabIndex = 28;
            // 
            // cb_loc
            // 
            this.cb_loc.FormattingEnabled = true;
            this.cb_loc.Location = new System.Drawing.Point(301, 20);
            this.cb_loc.Name = "cb_loc";
            this.cb_loc.Size = new System.Drawing.Size(85, 21);
            this.cb_loc.TabIndex = 29;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(247, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 13);
            this.label3.TabIndex = 30;
            this.label3.Text = "Location";
            // 
            // cb_trntype
            // 
            this.cb_trntype.FormattingEnabled = true;
            this.cb_trntype.Location = new System.Drawing.Point(301, 47);
            this.cb_trntype.Name = "cb_trntype";
            this.cb_trntype.Size = new System.Drawing.Size(85, 21);
            this.cb_trntype.TabIndex = 31;
            // 
            // Type
            // 
            this.Type.AutoSize = true;
            this.Type.Location = new System.Drawing.Point(247, 52);
            this.Type.Name = "Type";
            this.Type.Size = new System.Drawing.Size(31, 13);
            this.Type.TabIndex = 32;
            this.Type.Text = "Type";
            // 
            // frmTransaction
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.ctr_whmenu1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmTransaction";
            this.Text = "frmTransaction";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmTransaction_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private ctr_whmenu ctr_whmenu1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_search;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem exportToExcelToolStripMenuItem;
        private System.Windows.Forms.Label Type;
        private System.Windows.Forms.ComboBox cb_trntype;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cb_loc;
        private System.Windows.Forms.TextBox txt_search;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dp_podate2;
        private System.Windows.Forms.DateTimePicker dp_podate1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}