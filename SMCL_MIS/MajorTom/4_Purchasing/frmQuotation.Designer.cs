namespace SMCL_MIS
{
    partial class frmQuotation
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
            this.g1 = new System.Windows.Forms.GroupBox();
            this.dp_quotedate = new System.Windows.Forms.DateTimePicker();
            this.btn_search_quote = new System.Windows.Forms.Button();
            this.txtStatus = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtquoteno = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.g2 = new System.Windows.Forms.GroupBox();
            this.btn_search_sup = new System.Windows.Forms.Button();
            this.txtClass = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtTax = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtCurrendcy = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtsupname = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtSupno = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.g3 = new System.Windows.Forms.GroupBox();
            this.txtApproveDate = new System.Windows.Forms.TextBox();
            this.lbl_approvedate = new System.Windows.Forms.Label();
            this.txtApproveUser = new System.Windows.Forms.TextBox();
            this.lbl_approveuser = new System.Windows.Forms.Label();
            this.txtCreateDate = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtCreateUser = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.DG_Quote = new System.Windows.Forms.DataGridView();
            this.BJID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PartNO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Lead = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Maxsup = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Remark = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Filed1 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.btn_save = new System.Windows.Forms.Button();
            this.btn_approve = new System.Windows.Forms.Button();
            this.btn_reset = new System.Windows.Forms.Button();
            this.ctr_morebutton1 = new SMCL_MIS.ctr_morebutton();
            this.ctr_Purchasemenu1 = new SMCL_MIS.ctr_Purchasemenu();
            this.g1.SuspendLayout();
            this.g2.SuspendLayout();
            this.g3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DG_Quote)).BeginInit();
            this.SuspendLayout();
            // 
            // g1
            // 
            this.g1.Controls.Add(this.dp_quotedate);
            this.g1.Controls.Add(this.btn_search_quote);
            this.g1.Controls.Add(this.txtStatus);
            this.g1.Controls.Add(this.label3);
            this.g1.Controls.Add(this.label2);
            this.g1.Controls.Add(this.txtquoteno);
            this.g1.Controls.Add(this.label1);
            this.g1.Location = new System.Drawing.Point(12, 28);
            this.g1.Name = "g1";
            this.g1.Size = new System.Drawing.Size(241, 127);
            this.g1.TabIndex = 1;
            this.g1.TabStop = false;
            this.g1.Text = "Quote";
            // 
            // dp_quotedate
            // 
            this.dp_quotedate.CustomFormat = "yyyy-MM-dd HH:mm:ss";
            this.dp_quotedate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dp_quotedate.Location = new System.Drawing.Point(82, 50);
            this.dp_quotedate.Name = "dp_quotedate";
            this.dp_quotedate.Size = new System.Drawing.Size(147, 20);
            this.dp_quotedate.TabIndex = 10;
            // 
            // btn_search_quote
            // 
            this.btn_search_quote.Location = new System.Drawing.Point(200, 22);
            this.btn_search_quote.Name = "btn_search_quote";
            this.btn_search_quote.Size = new System.Drawing.Size(29, 22);
            this.btn_search_quote.TabIndex = 6;
            this.btn_search_quote.Text = "...";
            this.btn_search_quote.UseVisualStyleBackColor = true;
            this.btn_search_quote.Click += new System.EventHandler(this.btn_search_quote_Click);
            // 
            // txtStatus
            // 
            this.txtStatus.Location = new System.Drawing.Point(82, 75);
            this.txtStatus.Name = "txtStatus";
            this.txtStatus.ReadOnly = true;
            this.txtStatus.Size = new System.Drawing.Size(119, 20);
            this.txtStatus.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 78);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Status";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Date";
            // 
            // txtquoteno
            // 
            this.txtquoteno.Location = new System.Drawing.Point(82, 23);
            this.txtquoteno.Name = "txtquoteno";
            this.txtquoteno.ReadOnly = true;
            this.txtquoteno.Size = new System.Drawing.Size(128, 20);
            this.txtquoteno.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Quotation No";
            // 
            // g2
            // 
            this.g2.Controls.Add(this.btn_search_sup);
            this.g2.Controls.Add(this.txtClass);
            this.g2.Controls.Add(this.label8);
            this.g2.Controls.Add(this.txtTax);
            this.g2.Controls.Add(this.label7);
            this.g2.Controls.Add(this.txtCurrendcy);
            this.g2.Controls.Add(this.label4);
            this.g2.Controls.Add(this.txtsupname);
            this.g2.Controls.Add(this.label5);
            this.g2.Controls.Add(this.txtSupno);
            this.g2.Controls.Add(this.label6);
            this.g2.Location = new System.Drawing.Point(259, 28);
            this.g2.Name = "g2";
            this.g2.Size = new System.Drawing.Size(407, 127);
            this.g2.TabIndex = 6;
            this.g2.TabStop = false;
            this.g2.Text = "Supplier";
            // 
            // btn_search_sup
            // 
            this.btn_search_sup.Location = new System.Drawing.Point(200, 22);
            this.btn_search_sup.Name = "btn_search_sup";
            this.btn_search_sup.Size = new System.Drawing.Size(29, 22);
            this.btn_search_sup.TabIndex = 7;
            this.btn_search_sup.Text = "...";
            this.btn_search_sup.UseVisualStyleBackColor = true;
            this.btn_search_sup.Click += new System.EventHandler(this.btn_search_sup_Click);
            // 
            // txtClass
            // 
            this.txtClass.Location = new System.Drawing.Point(273, 23);
            this.txtClass.Name = "txtClass";
            this.txtClass.ReadOnly = true;
            this.txtClass.Size = new System.Drawing.Size(51, 20);
            this.txtClass.TabIndex = 9;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(235, 26);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(32, 13);
            this.label8.TabIndex = 8;
            this.label8.Text = "Class";
            // 
            // txtTax
            // 
            this.txtTax.Location = new System.Drawing.Point(82, 101);
            this.txtTax.Name = "txtTax";
            this.txtTax.ReadOnly = true;
            this.txtTax.Size = new System.Drawing.Size(119, 20);
            this.txtTax.TabIndex = 7;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 104);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(25, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Tax";
            // 
            // txtCurrendcy
            // 
            this.txtCurrendcy.Location = new System.Drawing.Point(82, 75);
            this.txtCurrendcy.Name = "txtCurrendcy";
            this.txtCurrendcy.ReadOnly = true;
            this.txtCurrendcy.Size = new System.Drawing.Size(119, 20);
            this.txtCurrendcy.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 78);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Currency";
            // 
            // txtsupname
            // 
            this.txtsupname.Location = new System.Drawing.Point(82, 49);
            this.txtsupname.Name = "txtsupname";
            this.txtsupname.ReadOnly = true;
            this.txtsupname.Size = new System.Drawing.Size(319, 20);
            this.txtsupname.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 52);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "Name";
            // 
            // txtSupno
            // 
            this.txtSupno.Location = new System.Drawing.Point(82, 23);
            this.txtSupno.Name = "txtSupno";
            this.txtSupno.ReadOnly = true;
            this.txtSupno.Size = new System.Drawing.Size(126, 20);
            this.txtSupno.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 26);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(62, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "Supplier No";
            // 
            // g3
            // 
            this.g3.Controls.Add(this.txtApproveDate);
            this.g3.Controls.Add(this.lbl_approvedate);
            this.g3.Controls.Add(this.txtApproveUser);
            this.g3.Controls.Add(this.lbl_approveuser);
            this.g3.Controls.Add(this.txtCreateDate);
            this.g3.Controls.Add(this.label10);
            this.g3.Controls.Add(this.txtCreateUser);
            this.g3.Controls.Add(this.label11);
            this.g3.Location = new System.Drawing.Point(672, 28);
            this.g3.Name = "g3";
            this.g3.Size = new System.Drawing.Size(248, 127);
            this.g3.TabIndex = 6;
            this.g3.TabStop = false;
            this.g3.Text = "User";
            // 
            // txtApproveDate
            // 
            this.txtApproveDate.Location = new System.Drawing.Point(103, 101);
            this.txtApproveDate.Name = "txtApproveDate";
            this.txtApproveDate.ReadOnly = true;
            this.txtApproveDate.Size = new System.Drawing.Size(119, 20);
            this.txtApproveDate.TabIndex = 7;
            // 
            // lbl_approvedate
            // 
            this.lbl_approvedate.AutoSize = true;
            this.lbl_approvedate.Location = new System.Drawing.Point(6, 104);
            this.lbl_approvedate.Name = "lbl_approvedate";
            this.lbl_approvedate.Size = new System.Drawing.Size(73, 13);
            this.lbl_approvedate.TabIndex = 6;
            this.lbl_approvedate.Text = "Approve Date";
            // 
            // txtApproveUser
            // 
            this.txtApproveUser.Location = new System.Drawing.Point(103, 75);
            this.txtApproveUser.Name = "txtApproveUser";
            this.txtApproveUser.ReadOnly = true;
            this.txtApproveUser.Size = new System.Drawing.Size(119, 20);
            this.txtApproveUser.TabIndex = 5;
            // 
            // lbl_approveuser
            // 
            this.lbl_approveuser.AutoSize = true;
            this.lbl_approveuser.Location = new System.Drawing.Point(6, 78);
            this.lbl_approveuser.Name = "lbl_approveuser";
            this.lbl_approveuser.Size = new System.Drawing.Size(62, 13);
            this.lbl_approveuser.TabIndex = 4;
            this.lbl_approveuser.Text = "Approve By";
            // 
            // txtCreateDate
            // 
            this.txtCreateDate.Location = new System.Drawing.Point(103, 49);
            this.txtCreateDate.Name = "txtCreateDate";
            this.txtCreateDate.ReadOnly = true;
            this.txtCreateDate.Size = new System.Drawing.Size(119, 20);
            this.txtCreateDate.TabIndex = 3;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 52);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(64, 13);
            this.label10.TabIndex = 2;
            this.label10.Text = "Create Date";
            // 
            // txtCreateUser
            // 
            this.txtCreateUser.Location = new System.Drawing.Point(103, 23);
            this.txtCreateUser.Name = "txtCreateUser";
            this.txtCreateUser.ReadOnly = true;
            this.txtCreateUser.Size = new System.Drawing.Size(119, 20);
            this.txtCreateUser.TabIndex = 1;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(6, 26);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(53, 13);
            this.label11.TabIndex = 0;
            this.label11.Text = "Create By";
            // 
            // DG_Quote
            // 
            this.DG_Quote.AllowUserToAddRows = false;
            this.DG_Quote.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DG_Quote.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DG_Quote.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.BJID,
            this.PartNO,
            this.Price,
            this.Lead,
            this.Maxsup,
            this.Remark,
            this.Filed1});
            this.DG_Quote.Location = new System.Drawing.Point(13, 161);
            this.DG_Quote.MultiSelect = false;
            this.DG_Quote.Name = "DG_Quote";
            this.DG_Quote.Size = new System.Drawing.Size(965, 270);
            this.DG_Quote.TabIndex = 7;
            this.DG_Quote.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DG_Quote_Click);
            this.DG_Quote.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DG_Quote_CellDoubleClick);
            this.DG_Quote.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.DG_Quote_DataError);
            this.DG_Quote.RowLeave += new System.Windows.Forms.DataGridViewCellEventHandler(this.DG_Quote_RowLeave);
            this.DG_Quote.UserDeletingRow += new System.Windows.Forms.DataGridViewRowCancelEventHandler(this.DG_Quote_UserDeletingRow);
            // 
            // BJID
            // 
            this.BJID.HeaderText = "Quote ID";
            this.BJID.Name = "BJID";
            this.BJID.ReadOnly = true;
            // 
            // PartNO
            // 
            this.PartNO.HeaderText = "Part Number";
            this.PartNO.MinimumWidth = 150;
            this.PartNO.Name = "PartNO";
            this.PartNO.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.PartNO.Width = 150;
            // 
            // Price
            // 
            this.Price.HeaderText = "Price";
            this.Price.Name = "Price";
            this.Price.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Lead
            // 
            this.Lead.HeaderText = "Lead Time";
            this.Lead.Name = "Lead";
            this.Lead.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Maxsup
            // 
            this.Maxsup.HeaderText = "Capacity";
            this.Maxsup.Name = "Maxsup";
            this.Maxsup.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Remark
            // 
            this.Remark.HeaderText = "Remark";
            this.Remark.Name = "Remark";
            this.Remark.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Filed1
            // 
            this.Filed1.DisplayStyleForCurrentCellOnly = true;
            this.Filed1.HeaderText = "Quote Type";
            this.Filed1.Name = "Filed1";
            this.Filed1.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // btn_save
            // 
            this.btn_save.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_save.Location = new System.Drawing.Point(13, 437);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(75, 23);
            this.btn_save.TabIndex = 8;
            this.btn_save.Text = "Save";
            this.btn_save.UseVisualStyleBackColor = true;
            this.btn_save.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_approve
            // 
            this.btn_approve.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_approve.Location = new System.Drawing.Point(94, 437);
            this.btn_approve.Name = "btn_approve";
            this.btn_approve.Size = new System.Drawing.Size(75, 23);
            this.btn_approve.TabIndex = 9;
            this.btn_approve.Text = "Approve";
            this.btn_approve.UseVisualStyleBackColor = true;
            this.btn_approve.Click += new System.EventHandler(this.btn_approve_Click);
            // 
            // btn_reset
            // 
            this.btn_reset.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_reset.Location = new System.Drawing.Point(175, 437);
            this.btn_reset.Name = "btn_reset";
            this.btn_reset.Size = new System.Drawing.Size(75, 23);
            this.btn_reset.TabIndex = 10;
            this.btn_reset.Text = "Reset";
            this.btn_reset.UseVisualStyleBackColor = true;
            this.btn_reset.Click += new System.EventHandler(this.btn_reset_Click);
            // 
            // ctr_morebutton1
            // 
            this.ctr_morebutton1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ctr_morebutton1.Location = new System.Drawing.Point(825, 437);
            this.ctr_morebutton1.Name = "ctr_morebutton1";
            this.ctr_morebutton1.Size = new System.Drawing.Size(153, 23);
            this.ctr_morebutton1.TabIndex = 11;
            // 
            // ctr_Purchasemenu1
            // 
            this.ctr_Purchasemenu1.Dock = System.Windows.Forms.DockStyle.Top;
            this.ctr_Purchasemenu1.Location = new System.Drawing.Point(0, 0);
            this.ctr_Purchasemenu1.Name = "ctr_Purchasemenu1";
            this.ctr_Purchasemenu1.Size = new System.Drawing.Size(990, 22);
            this.ctr_Purchasemenu1.TabIndex = 0;
            // 
            // frmQuotation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(990, 472);
            this.Controls.Add(this.ctr_morebutton1);
            this.Controls.Add(this.btn_reset);
            this.Controls.Add(this.btn_approve);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.DG_Quote);
            this.Controls.Add(this.g3);
            this.Controls.Add(this.g2);
            this.Controls.Add(this.g1);
            this.Controls.Add(this.ctr_Purchasemenu1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmQuotation";
            this.Text = "QUOTATION";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmQuotation_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.frmQuotation_Paint);
            this.g1.ResumeLayout(false);
            this.g1.PerformLayout();
            this.g2.ResumeLayout(false);
            this.g2.PerformLayout();
            this.g3.ResumeLayout(false);
            this.g3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DG_Quote)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private ctr_Purchasemenu ctr_Purchasemenu1;
        private System.Windows.Forms.GroupBox g1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtquoteno;
        private System.Windows.Forms.TextBox txtStatus;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox g2;
        private System.Windows.Forms.TextBox txtCurrendcy;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtsupname;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtSupno;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtTax;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtClass;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox g3;
        private System.Windows.Forms.TextBox txtApproveUser;
        private System.Windows.Forms.Label lbl_approveuser;
        private System.Windows.Forms.TextBox txtCreateDate;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtCreateUser;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtApproveDate;
        private System.Windows.Forms.Label lbl_approvedate;
        private System.Windows.Forms.Button btn_search_quote;
        private System.Windows.Forms.Button btn_search_sup;
        private System.Windows.Forms.DataGridView DG_Quote;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.Button btn_approve;
        private System.Windows.Forms.Button btn_reset;
        private ctr_morebutton ctr_morebutton1;
        private System.Windows.Forms.DateTimePicker dp_quotedate;
        private System.Windows.Forms.DataGridViewTextBoxColumn BJID;
        private System.Windows.Forms.DataGridViewTextBoxColumn PartNO;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price;
        private System.Windows.Forms.DataGridViewTextBoxColumn Lead;
        private System.Windows.Forms.DataGridViewTextBoxColumn Maxsup;
        private System.Windows.Forms.DataGridViewTextBoxColumn Remark;
        private System.Windows.Forms.DataGridViewComboBoxColumn Filed1;
    }
}