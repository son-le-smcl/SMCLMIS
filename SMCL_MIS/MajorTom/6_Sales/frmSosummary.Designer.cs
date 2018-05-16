namespace SMCL_MIS
{
    partial class frmSosummary
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
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButton_ongoing = new System.Windows.Forms.RadioButton();
            this.radioButton_Finished = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_search = new System.Windows.Forms.Button();
            this.dp_to = new System.Windows.Forms.DateTimePicker();
            this.txt_search = new System.Windows.Forms.TextBox();
            this.dp_from = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.frmSosumm_contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.exportToExcelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ctr_salemenu1 = new SMCL_MIS.ctr_salemenu();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.frmSosumm_contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButton3);
            this.groupBox1.Controls.Add(this.radioButton_ongoing);
            this.groupBox1.Controls.Add(this.radioButton_Finished);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.btn_search);
            this.groupBox1.Controls.Add(this.dp_to);
            this.groupBox1.Controls.Add(this.txt_search);
            this.groupBox1.Controls.Add(this.dp_from);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 30);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(387, 99);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Order Date";
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(194, 22);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(36, 17);
            this.radioButton3.TabIndex = 7;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "All";
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // radioButton_ongoing
            // 
            this.radioButton_ongoing.AutoSize = true;
            this.radioButton_ongoing.Location = new System.Drawing.Point(194, 68);
            this.radioButton_ongoing.Name = "radioButton_ongoing";
            this.radioButton_ongoing.Size = new System.Drawing.Size(70, 17);
            this.radioButton_ongoing.TabIndex = 6;
            this.radioButton_ongoing.TabStop = true;
            this.radioButton_ongoing.Text = "On Going";
            this.radioButton_ongoing.UseVisualStyleBackColor = true;
            // 
            // radioButton_Finished
            // 
            this.radioButton_Finished.AutoSize = true;
            this.radioButton_Finished.Location = new System.Drawing.Point(194, 45);
            this.radioButton_Finished.Name = "radioButton_Finished";
            this.radioButton_Finished.Size = new System.Drawing.Size(64, 17);
            this.radioButton_Finished.TabIndex = 5;
            this.radioButton_Finished.TabStop = true;
            this.radioButton_Finished.Text = "Finished";
            this.radioButton_Finished.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 72);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Search";
            // 
            // btn_search
            // 
            this.btn_search.Location = new System.Drawing.Point(306, 15);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(75, 23);
            this.btn_search.TabIndex = 3;
            this.btn_search.Text = "Search";
            this.btn_search.UseVisualStyleBackColor = true;
            this.btn_search.Click += new System.EventHandler(this.btn_search_Click);
            // 
            // dp_to
            // 
            this.dp_to.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dp_to.Location = new System.Drawing.Point(57, 45);
            this.dp_to.Name = "dp_to";
            this.dp_to.Size = new System.Drawing.Size(131, 20);
            this.dp_to.TabIndex = 3;
            // 
            // txt_search
            // 
            this.txt_search.Location = new System.Drawing.Point(57, 69);
            this.txt_search.Name = "txt_search";
            this.txt_search.Size = new System.Drawing.Size(131, 20);
            this.txt_search.TabIndex = 0;
            this.txt_search.TextChanged += new System.EventHandler(this.txt_search_TextChanged);
            // 
            // dp_from
            // 
            this.dp_from.CustomFormat = "yyyy-01-01";
            this.dp_from.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dp_from.Location = new System.Drawing.Point(57, 19);
            this.dp_from.Name = "dp_from";
            this.dp_from.Size = new System.Drawing.Size(131, 20);
            this.dp_from.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(20, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "To";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "From";
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 160);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(979, 278);
            this.dataGridView1.TabIndex = 5;
            this.dataGridView1.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.dataGridView1_RowPostPaint);
            // 
            // frmSosumm_contextMenuStrip1
            // 
            this.frmSosumm_contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exportToExcelToolStripMenuItem});
            this.frmSosumm_contextMenuStrip1.Name = "frmSosumm_contextMenuStrip1";
            this.frmSosumm_contextMenuStrip1.Size = new System.Drawing.Size(153, 26);
            // 
            // exportToExcelToolStripMenuItem
            // 
            this.exportToExcelToolStripMenuItem.Name = "exportToExcelToolStripMenuItem";
            this.exportToExcelToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.exportToExcelToolStripMenuItem.Text = "Export To Excel";
            this.exportToExcelToolStripMenuItem.Click += new System.EventHandler(this.exportToExcelToolStripMenuItem_Click);
            // 
            // ctr_salemenu1
            // 
            this.ctr_salemenu1.AutoSize = true;
            this.ctr_salemenu1.Dock = System.Windows.Forms.DockStyle.Top;
            this.ctr_salemenu1.Location = new System.Drawing.Point(0, 0);
            this.ctr_salemenu1.Name = "ctr_salemenu1";
            this.ctr_salemenu1.Size = new System.Drawing.Size(1003, 26);
            this.ctr_salemenu1.TabIndex = 1;
            // 
            // frmSosummary
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1003, 450);
            this.ContextMenuStrip = this.frmSosumm_contextMenuStrip1;
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.ctr_salemenu1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmSosummary";
            this.Text = "SALES ORDER INFOMATION";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmSosummary_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.frmSosummary_Paint);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.frmSosumm_contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ctr_salemenu ctr_salemenu1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DateTimePicker dp_to;
        private System.Windows.Forms.DateTimePicker dp_from;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ContextMenuStrip frmSosumm_contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem exportToExcelToolStripMenuItem;
        private System.Windows.Forms.TextBox txt_search;
        private System.Windows.Forms.Button btn_search;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton radioButton_ongoing;
        private System.Windows.Forms.RadioButton radioButton_Finished;
        private System.Windows.Forms.RadioButton radioButton3;
    }
}