namespace SMCL_MIS
{
    partial class frmUserError
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
            this.crt_Settingsmenu1 = new SMCL_MIS.crt_Settingsmenu();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.Gv_log = new System.Windows.Forms.DataGridView();
            this.btn_load = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtminutes = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.Gv_mosterr = new System.Windows.Forms.DataGridView();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.Gv_warning = new System.Windows.Forms.DataGridView();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.Gv_log)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Gv_mosterr)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Gv_warning)).BeginInit();
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
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(12, 29);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 1;
            // 
            // Gv_log
            // 
            this.Gv_log.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Gv_log.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Gv_log.Location = new System.Drawing.Point(6, 19);
            this.Gv_log.Name = "Gv_log";
            this.Gv_log.Size = new System.Drawing.Size(412, 349);
            this.Gv_log.TabIndex = 2;
            this.Gv_log.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.Gv_log_RowPostPaint);
            // 
            // btn_load
            // 
            this.btn_load.Location = new System.Drawing.Point(218, 28);
            this.btn_load.Name = "btn_load";
            this.btn_load.Size = new System.Drawing.Size(75, 23);
            this.btn_load.TabIndex = 3;
            this.btn_load.Text = "Load";
            this.btn_load.UseVisualStyleBackColor = true;
            this.btn_load.Click += new System.EventHandler(this.btn_load_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(355, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Reload affter";
            // 
            // txtminutes
            // 
            this.txtminutes.Location = new System.Drawing.Point(430, 30);
            this.txtminutes.MaxLength = 3;
            this.txtminutes.Name = "txtminutes";
            this.txtminutes.Size = new System.Drawing.Size(35, 20);
            this.txtminutes.TabIndex = 5;
            this.txtminutes.Text = "0";
            this.txtminutes.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(471, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "minutes";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.Gv_log);
            this.groupBox1.Location = new System.Drawing.Point(12, 64);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(424, 374);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Error Log";
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.Gv_mosterr);
            this.groupBox2.Location = new System.Drawing.Point(442, 64);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(346, 166);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Got the most Error";
            // 
            // Gv_mosterr
            // 
            this.Gv_mosterr.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Gv_mosterr.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Gv_mosterr.Location = new System.Drawing.Point(6, 19);
            this.Gv_mosterr.Name = "Gv_mosterr";
            this.Gv_mosterr.Size = new System.Drawing.Size(334, 141);
            this.Gv_mosterr.TabIndex = 2;
            this.Gv_mosterr.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.Gv_log_RowPostPaint);
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.Controls.Add(this.Gv_warning);
            this.groupBox3.Location = new System.Drawing.Point(442, 236);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(346, 202);
            this.groupBox3.TabIndex = 10;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Warning";
            // 
            // Gv_warning
            // 
            this.Gv_warning.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Gv_warning.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Gv_warning.Location = new System.Drawing.Point(6, 19);
            this.Gv_warning.Name = "Gv_warning";
            this.Gv_warning.Size = new System.Drawing.Size(334, 177);
            this.Gv_warning.TabIndex = 2;
            this.Gv_warning.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.Gv_log_RowPostPaint);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 6000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // frmUserError
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtminutes);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_load);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.crt_Settingsmenu1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmUserError";
            this.Text = "frmUserError";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmUserError_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Gv_log)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Gv_mosterr)).EndInit();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Gv_warning)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private crt_Settingsmenu crt_Settingsmenu1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DataGridView Gv_log;
        private System.Windows.Forms.Button btn_load;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtminutes;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView Gv_mosterr;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView Gv_warning;
        private System.Windows.Forms.Timer timer1;
    }
}