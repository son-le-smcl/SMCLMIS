namespace SMCL_MIS
{
    partial class frmPOinfo
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
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.exportToExcelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButton_all = new System.Windows.Forms.RadioButton();
            this.radioButton_finished = new System.Windows.Forms.RadioButton();
            this.radioButton_late = new System.Windows.Forms.RadioButton();
            this.radioButton_ontheway = new System.Windows.Forms.RadioButton();
            this.txt_search = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_search = new System.Windows.Forms.Button();
            this.dp_podate2 = new System.Windows.Forms.DateTimePicker();
            this.dp_podate1 = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ctr_Purchasemenu1 = new SMCL_MIS.ctr_Purchasemenu();
            this.contextMenuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
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
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButton_all);
            this.groupBox1.Controls.Add(this.radioButton_finished);
            this.groupBox1.Controls.Add(this.radioButton_late);
            this.groupBox1.Controls.Add(this.radioButton_ontheway);
            this.groupBox1.Controls.Add(this.txt_search);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.btn_search);
            this.groupBox1.Controls.Add(this.dp_podate2);
            this.groupBox1.Controls.Add(this.dp_podate1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 28);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(474, 105);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Purchase Order";
            // 
            // radioButton_all
            // 
            this.radioButton_all.AutoSize = true;
            this.radioButton_all.Location = new System.Drawing.Point(242, 12);
            this.radioButton_all.Name = "radioButton_all";
            this.radioButton_all.Size = new System.Drawing.Size(36, 17);
            this.radioButton_all.TabIndex = 32;
            this.radioButton_all.TabStop = true;
            this.radioButton_all.Text = "All";
            this.radioButton_all.UseVisualStyleBackColor = true;
            // 
            // radioButton_finished
            // 
            this.radioButton_finished.AutoSize = true;
            this.radioButton_finished.Location = new System.Drawing.Point(242, 81);
            this.radioButton_finished.Name = "radioButton_finished";
            this.radioButton_finished.Size = new System.Drawing.Size(64, 17);
            this.radioButton_finished.TabIndex = 31;
            this.radioButton_finished.TabStop = true;
            this.radioButton_finished.Text = "Finished";
            this.radioButton_finished.UseVisualStyleBackColor = true;
            // 
            // radioButton_late
            // 
            this.radioButton_late.AutoSize = true;
            this.radioButton_late.Location = new System.Drawing.Point(242, 58);
            this.radioButton_late.Name = "radioButton_late";
            this.radioButton_late.Size = new System.Drawing.Size(46, 17);
            this.radioButton_late.TabIndex = 30;
            this.radioButton_late.TabStop = true;
            this.radioButton_late.Text = "Late";
            this.radioButton_late.UseVisualStyleBackColor = true;
            // 
            // radioButton_ontheway
            // 
            this.radioButton_ontheway.AutoSize = true;
            this.radioButton_ontheway.Location = new System.Drawing.Point(242, 35);
            this.radioButton_ontheway.Name = "radioButton_ontheway";
            this.radioButton_ontheway.Size = new System.Drawing.Size(86, 17);
            this.radioButton_ontheway.TabIndex = 29;
            this.radioButton_ontheway.TabStop = true;
            this.radioButton_ontheway.Text = "On The Way";
            this.radioButton_ontheway.UseVisualStyleBackColor = true;
            // 
            // txt_search
            // 
            this.txt_search.Location = new System.Drawing.Point(68, 72);
            this.txt_search.Name = "txt_search";
            this.txt_search.Size = new System.Drawing.Size(155, 20);
            this.txt_search.TabIndex = 28;
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
            // btn_search
            // 
            this.btn_search.Location = new System.Drawing.Point(393, 12);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(75, 23);
            this.btn_search.TabIndex = 24;
            this.btn_search.Text = "Search";
            this.btn_search.UseVisualStyleBackColor = true;
            this.btn_search.Click += new System.EventHandler(this.btn_search_Click);
            // 
            // dp_podate2
            // 
            this.dp_podate2.CustomFormat = "yyyy-MM-dd";
            this.dp_podate2.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dp_podate2.Location = new System.Drawing.Point(68, 46);
            this.dp_podate2.Name = "dp_podate2";
            this.dp_podate2.Size = new System.Drawing.Size(155, 20);
            this.dp_podate2.TabIndex = 23;
            // 
            // dp_podate1
            // 
            this.dp_podate1.CustomFormat = "yyyy-MM-dd";
            this.dp_podate1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dp_podate1.Location = new System.Drawing.Point(68, 20);
            this.dp_podate1.Name = "dp_podate1";
            this.dp_podate1.Size = new System.Drawing.Size(155, 20);
            this.dp_podate1.TabIndex = 22;
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "From Date";
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.ContextMenuStrip = this.contextMenuStrip1;
            this.dataGridView1.Location = new System.Drawing.Point(12, 139);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(944, 299);
            this.dataGridView1.TabIndex = 3;
            this.dataGridView1.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.dataGridView1_RowPostPaint);
            // 
            // ctr_Purchasemenu1
            // 
            this.ctr_Purchasemenu1.Dock = System.Windows.Forms.DockStyle.Top;
            this.ctr_Purchasemenu1.Location = new System.Drawing.Point(0, 0);
            this.ctr_Purchasemenu1.Name = "ctr_Purchasemenu1";
            this.ctr_Purchasemenu1.Size = new System.Drawing.Size(968, 22);
            this.ctr_Purchasemenu1.TabIndex = 0;
            // 
            // frmPOinfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(968, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.ctr_Purchasemenu1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmPOinfo";
            this.Text = "PURCHASE ORDER INFOMATION";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmPOinfo_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.frmPOinfo_Paint);
            this.contextMenuStrip1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private ctr_Purchasemenu ctr_Purchasemenu1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dp_podate2;
        private System.Windows.Forms.DateTimePicker dp_podate1;
        private System.Windows.Forms.Button btn_search;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem exportToExcelToolStripMenuItem;
        private System.Windows.Forms.TextBox txt_search;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RadioButton radioButton_finished;
        private System.Windows.Forms.RadioButton radioButton_late;
        private System.Windows.Forms.RadioButton radioButton_ontheway;
        private System.Windows.Forms.RadioButton radioButton_all;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}