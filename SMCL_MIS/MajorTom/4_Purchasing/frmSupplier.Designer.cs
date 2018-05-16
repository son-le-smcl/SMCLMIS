namespace SMCL_MIS
{
    partial class frmSupplier
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
            this.btnBrowse = new System.Windows.Forms.Button();
            this.chk_deactive = new System.Windows.Forms.CheckBox();
            this.cb_class = new System.Windows.Forms.ComboBox();
            this.label17 = new System.Windows.Forms.Label();
            this.txtSupname2 = new System.Windows.Forms.TextBox();
            this.txtSupadd2 = new System.Windows.Forms.RichTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtSupname = new System.Windows.Forms.TextBox();
            this.txtSupno = new System.Windows.Forms.TextBox();
            this.txtSupadd = new System.Windows.Forms.RichTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cb_buyer = new System.Windows.Forms.ComboBox();
            this.txtCreatedate = new System.Windows.Forms.TextBox();
            this.txtCreateuser = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtFax = new System.Windows.Forms.TextBox();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.txtContact = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtAccnumber = new System.Windows.Forms.TextBox();
            this.label21 = new System.Windows.Forms.Label();
            this.txtBankname = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.cb_pmterm = new System.Windows.Forms.ComboBox();
            this.cb_tax = new System.Windows.Forms.ComboBox();
            this.cb_Gltype = new System.Windows.Forms.ComboBox();
            this.cb_settlement = new System.Windows.Forms.ComboBox();
            this.cb_currency = new System.Windows.Forms.ComboBox();
            this.cb_deliverytype = new System.Windows.Forms.ComboBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.btn_save = new System.Windows.Forms.Button();
            this.btn_reset = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.exportToExcelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.btn_delete = new System.Windows.Forms.Button();
            this.ctr_Purchasemenu1 = new SMCL_MIS.ctr_Purchasemenu();
            this.txtbrand = new System.Windows.Forms.TextBox();
            this.label22 = new System.Windows.Forms.Label();
            this.txtVAT = new System.Windows.Forms.TextBox();
            this.label23 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnBrowse);
            this.groupBox1.Controls.Add(this.chk_deactive);
            this.groupBox1.Controls.Add(this.cb_class);
            this.groupBox1.Controls.Add(this.label17);
            this.groupBox1.Controls.Add(this.txtSupname2);
            this.groupBox1.Controls.Add(this.txtSupadd2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtSupname);
            this.groupBox1.Controls.Add(this.txtSupno);
            this.groupBox1.Controls.Add(this.txtSupadd);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 28);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(430, 206);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Supplier";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // btnBrowse
            // 
            this.btnBrowse.Location = new System.Drawing.Point(206, 19);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(25, 22);
            this.btnBrowse.TabIndex = 15;
            this.btnBrowse.Text = "...";
            this.btnBrowse.UseVisualStyleBackColor = true;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // chk_deactive
            // 
            this.chk_deactive.AutoSize = true;
            this.chk_deactive.Location = new System.Drawing.Point(326, 21);
            this.chk_deactive.Name = "chk_deactive";
            this.chk_deactive.Size = new System.Drawing.Size(78, 17);
            this.chk_deactive.TabIndex = 14;
            this.chk_deactive.Text = "Deactivate";
            this.chk_deactive.UseVisualStyleBackColor = true;
            // 
            // cb_class
            // 
            this.cb_class.FormattingEnabled = true;
            this.cb_class.Items.AddRange(new object[] {
            "A",
            "B",
            "C",
            "D"});
            this.cb_class.Location = new System.Drawing.Point(275, 19);
            this.cb_class.Name = "cb_class";
            this.cb_class.Size = new System.Drawing.Size(45, 21);
            this.cb_class.TabIndex = 13;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(237, 25);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(32, 13);
            this.label17.TabIndex = 12;
            this.label17.Text = "Class";
            // 
            // txtSupname2
            // 
            this.txtSupname2.Location = new System.Drawing.Point(96, 121);
            this.txtSupname2.Name = "txtSupname2";
            this.txtSupname2.Size = new System.Drawing.Size(328, 20);
            this.txtSupname2.TabIndex = 11;
            // 
            // txtSupadd2
            // 
            this.txtSupadd2.Location = new System.Drawing.Point(96, 147);
            this.txtSupadd2.Name = "txtSupadd2";
            this.txtSupadd2.Size = new System.Drawing.Size(328, 43);
            this.txtSupadd2.TabIndex = 10;
            this.txtSupadd2.Text = "";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 150);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Address2";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 124);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Suppiler Name2";
            // 
            // txtSupname
            // 
            this.txtSupname.Location = new System.Drawing.Point(96, 46);
            this.txtSupname.Name = "txtSupname";
            this.txtSupname.Size = new System.Drawing.Size(328, 20);
            this.txtSupname.TabIndex = 7;
            // 
            // txtSupno
            // 
            this.txtSupno.Location = new System.Drawing.Point(96, 20);
            this.txtSupno.Name = "txtSupno";
            this.txtSupno.Size = new System.Drawing.Size(126, 20);
            this.txtSupno.TabIndex = 6;
            this.txtSupno.TextChanged += new System.EventHandler(this.txtSupno_TextChanged);
            this.txtSupno.Leave += new System.EventHandler(this.txtSupno_Leave);
            // 
            // txtSupadd
            // 
            this.txtSupadd.Location = new System.Drawing.Point(96, 72);
            this.txtSupadd.Name = "txtSupadd";
            this.txtSupadd.Size = new System.Drawing.Size(328, 43);
            this.txtSupadd.TabIndex = 5;
            this.txtSupadd.Text = "";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 75);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Address";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Suppiler Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Suppiler No";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cb_buyer);
            this.groupBox2.Controls.Add(this.txtCreatedate);
            this.groupBox2.Controls.Add(this.txtCreateuser);
            this.groupBox2.Controls.Add(this.label19);
            this.groupBox2.Controls.Add(this.label18);
            this.groupBox2.Controls.Add(this.txtEmail);
            this.groupBox2.Controls.Add(this.txtFax);
            this.groupBox2.Controls.Add(this.txtPhone);
            this.groupBox2.Controls.Add(this.txtContact);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Location = new System.Drawing.Point(448, 28);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(265, 206);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Contact";
            // 
            // cb_buyer
            // 
            this.cb_buyer.FormattingEnabled = true;
            this.cb_buyer.Location = new System.Drawing.Point(82, 20);
            this.cb_buyer.Name = "cb_buyer";
            this.cb_buyer.Size = new System.Drawing.Size(135, 21);
            this.cb_buyer.TabIndex = 14;
            // 
            // txtCreatedate
            // 
            this.txtCreatedate.BackColor = System.Drawing.SystemColors.Control;
            this.txtCreatedate.Location = new System.Drawing.Point(82, 180);
            this.txtCreatedate.Name = "txtCreatedate";
            this.txtCreatedate.ReadOnly = true;
            this.txtCreatedate.Size = new System.Drawing.Size(135, 20);
            this.txtCreatedate.TabIndex = 13;
            // 
            // txtCreateuser
            // 
            this.txtCreateuser.BackColor = System.Drawing.SystemColors.Control;
            this.txtCreateuser.Location = new System.Drawing.Point(82, 154);
            this.txtCreateuser.Name = "txtCreateuser";
            this.txtCreateuser.ReadOnly = true;
            this.txtCreateuser.Size = new System.Drawing.Size(135, 20);
            this.txtCreateuser.TabIndex = 12;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(6, 183);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(70, 13);
            this.label19.TabIndex = 11;
            this.label19.Text = "Created Date";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(6, 157);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(58, 13);
            this.label18.TabIndex = 10;
            this.label18.Text = "Created by";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(82, 128);
            this.txtEmail.MaxLength = 50;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(135, 20);
            this.txtEmail.TabIndex = 9;
            // 
            // txtFax
            // 
            this.txtFax.Location = new System.Drawing.Point(82, 101);
            this.txtFax.MaxLength = 50;
            this.txtFax.Name = "txtFax";
            this.txtFax.Size = new System.Drawing.Size(135, 20);
            this.txtFax.TabIndex = 8;
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(82, 75);
            this.txtPhone.MaxLength = 50;
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(135, 20);
            this.txtPhone.TabIndex = 7;
            // 
            // txtContact
            // 
            this.txtContact.Location = new System.Drawing.Point(82, 49);
            this.txtContact.MaxLength = 50;
            this.txtContact.Name = "txtContact";
            this.txtContact.Size = new System.Drawing.Size(135, 20);
            this.txtContact.TabIndex = 6;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 131);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(32, 13);
            this.label10.TabIndex = 4;
            this.label10.Text = "Email";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 104);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(24, 13);
            this.label9.TabIndex = 3;
            this.label9.Text = "Fax";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 78);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(38, 13);
            this.label8.TabIndex = 2;
            this.label8.Text = "Phone";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 52);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(44, 13);
            this.label7.TabIndex = 1;
            this.label7.Text = "Contact";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 25);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(34, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "Buyer";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txtVAT);
            this.groupBox3.Controls.Add(this.label23);
            this.groupBox3.Controls.Add(this.txtbrand);
            this.groupBox3.Controls.Add(this.label22);
            this.groupBox3.Controls.Add(this.txtAccnumber);
            this.groupBox3.Controls.Add(this.label21);
            this.groupBox3.Controls.Add(this.txtBankname);
            this.groupBox3.Controls.Add(this.label20);
            this.groupBox3.Controls.Add(this.cb_pmterm);
            this.groupBox3.Controls.Add(this.cb_tax);
            this.groupBox3.Controls.Add(this.cb_Gltype);
            this.groupBox3.Controls.Add(this.cb_settlement);
            this.groupBox3.Controls.Add(this.cb_currency);
            this.groupBox3.Controls.Add(this.cb_deliverytype);
            this.groupBox3.Controls.Add(this.label16);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Controls.Add(this.label12);
            this.groupBox3.Controls.Add(this.label13);
            this.groupBox3.Controls.Add(this.label14);
            this.groupBox3.Controls.Add(this.label15);
            this.groupBox3.Location = new System.Drawing.Point(719, 28);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(464, 206);
            this.groupBox3.TabIndex = 10;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Payment";
            this.groupBox3.Enter += new System.EventHandler(this.groupBox3_Enter);
            // 
            // txtAccnumber
            // 
            this.txtAccnumber.Location = new System.Drawing.Point(309, 46);
            this.txtAccnumber.MaxLength = 100;
            this.txtAccnumber.Name = "txtAccnumber";
            this.txtAccnumber.Size = new System.Drawing.Size(135, 20);
            this.txtAccnumber.TabIndex = 19;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(221, 52);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(66, 13);
            this.label21.TabIndex = 18;
            this.label21.Text = "Acc Number";
            // 
            // txtBankname
            // 
            this.txtBankname.Location = new System.Drawing.Point(309, 16);
            this.txtBankname.MaxLength = 100;
            this.txtBankname.Name = "txtBankname";
            this.txtBankname.Size = new System.Drawing.Size(135, 20);
            this.txtBankname.TabIndex = 15;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(221, 21);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(63, 13);
            this.label20.TabIndex = 17;
            this.label20.Text = "Bank Name";
            // 
            // cb_pmterm
            // 
            this.cb_pmterm.FormattingEnabled = true;
            this.cb_pmterm.Location = new System.Drawing.Point(94, 158);
            this.cb_pmterm.Name = "cb_pmterm";
            this.cb_pmterm.Size = new System.Drawing.Size(121, 21);
            this.cb_pmterm.TabIndex = 16;
            // 
            // cb_tax
            // 
            this.cb_tax.FormattingEnabled = true;
            this.cb_tax.Location = new System.Drawing.Point(94, 131);
            this.cb_tax.Name = "cb_tax";
            this.cb_tax.Size = new System.Drawing.Size(121, 21);
            this.cb_tax.TabIndex = 15;
            // 
            // cb_Gltype
            // 
            this.cb_Gltype.FormattingEnabled = true;
            this.cb_Gltype.Location = new System.Drawing.Point(94, 105);
            this.cb_Gltype.Name = "cb_Gltype";
            this.cb_Gltype.Size = new System.Drawing.Size(121, 21);
            this.cb_Gltype.TabIndex = 14;
            // 
            // cb_settlement
            // 
            this.cb_settlement.FormattingEnabled = true;
            this.cb_settlement.Location = new System.Drawing.Point(94, 78);
            this.cb_settlement.Name = "cb_settlement";
            this.cb_settlement.Size = new System.Drawing.Size(121, 21);
            this.cb_settlement.TabIndex = 13;
            // 
            // cb_currency
            // 
            this.cb_currency.FormattingEnabled = true;
            this.cb_currency.Location = new System.Drawing.Point(94, 49);
            this.cb_currency.Name = "cb_currency";
            this.cb_currency.Size = new System.Drawing.Size(121, 21);
            this.cb_currency.TabIndex = 12;
            // 
            // cb_deliverytype
            // 
            this.cb_deliverytype.FormattingEnabled = true;
            this.cb_deliverytype.Location = new System.Drawing.Point(94, 22);
            this.cb_deliverytype.Name = "cb_deliverytype";
            this.cb_deliverytype.Size = new System.Drawing.Size(121, 21);
            this.cb_deliverytype.TabIndex = 11;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(6, 161);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(71, 13);
            this.label16.TabIndex = 10;
            this.label16.Text = "Payment term";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(6, 134);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(25, 13);
            this.label11.TabIndex = 4;
            this.label11.Text = "Tax";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(6, 108);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(48, 13);
            this.label12.TabIndex = 3;
            this.label12.Text = "GL Type";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(6, 81);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(57, 13);
            this.label13.TabIndex = 2;
            this.label13.Text = "Settlement";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(6, 52);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(49, 13);
            this.label14.TabIndex = 1;
            this.label14.Text = "Currency";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(6, 25);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(72, 13);
            this.label15.TabIndex = 0;
            this.label15.Text = "Delivery Type";
            // 
            // btn_save
            // 
            this.btn_save.Location = new System.Drawing.Point(12, 240);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(75, 23);
            this.btn_save.TabIndex = 11;
            this.btn_save.Text = "Save";
            this.btn_save.UseVisualStyleBackColor = true;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // btn_reset
            // 
            this.btn_reset.Location = new System.Drawing.Point(93, 240);
            this.btn_reset.Name = "btn_reset";
            this.btn_reset.Size = new System.Drawing.Size(75, 23);
            this.btn_reset.TabIndex = 12;
            this.btn_reset.Text = "Reset";
            this.btn_reset.UseVisualStyleBackColor = true;
            this.btn_reset.Click += new System.EventHandler(this.btn_reset_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.ContextMenuStrip = this.contextMenuStrip1;
            this.dataGridView1.Location = new System.Drawing.Point(12, 304);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1171, 177);
            this.dataGridView1.TabIndex = 13;
            this.dataGridView1.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.dataGridView1_RowPostPaint);
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
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(12, 275);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(130, 20);
            this.txtSearch.TabIndex = 16;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(148, 275);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 17;
            this.button1.Text = "Search";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_delete
            // 
            this.btn_delete.Location = new System.Drawing.Point(174, 240);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(75, 23);
            this.btn_delete.TabIndex = 18;
            this.btn_delete.Text = "Delete";
            this.btn_delete.UseVisualStyleBackColor = true;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // ctr_Purchasemenu1
            // 
            this.ctr_Purchasemenu1.Dock = System.Windows.Forms.DockStyle.Top;
            this.ctr_Purchasemenu1.Location = new System.Drawing.Point(0, 0);
            this.ctr_Purchasemenu1.Name = "ctr_Purchasemenu1";
            this.ctr_Purchasemenu1.Size = new System.Drawing.Size(1195, 22);
            this.ctr_Purchasemenu1.TabIndex = 0;
            // 
            // txtbrand
            // 
            this.txtbrand.Location = new System.Drawing.Point(309, 74);
            this.txtbrand.MaxLength = 100;
            this.txtbrand.Name = "txtbrand";
            this.txtbrand.Size = new System.Drawing.Size(135, 20);
            this.txtbrand.TabIndex = 21;
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(221, 80);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(35, 13);
            this.label22.TabIndex = 20;
            this.label22.Text = "Brand";
            // 
            // txtVAT
            // 
            this.txtVAT.Location = new System.Drawing.Point(309, 100);
            this.txtVAT.MaxLength = 100;
            this.txtVAT.Name = "txtVAT";
            this.txtVAT.Size = new System.Drawing.Size(135, 20);
            this.txtVAT.TabIndex = 23;
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(221, 106);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(56, 13);
            this.label23.TabIndex = 22;
            this.label23.Text = "VAT Code";
            // 
            // frmSupplier
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1195, 493);
            this.Controls.Add(this.btn_delete);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btn_reset);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.ctr_Purchasemenu1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmSupplier";
            this.Text = "SUPPLIERS";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmSupplier_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.frmSupplier_Paint);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ctr_Purchasemenu ctr_Purchasemenu1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RichTextBox txtSupadd;
        private System.Windows.Forms.TextBox txtSupname;
        private System.Windows.Forms.TextBox txtSupname2;
        private System.Windows.Forms.RichTextBox txtSupadd2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtFax;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.TextBox txtContact;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.ComboBox cb_pmterm;
        private System.Windows.Forms.ComboBox cb_tax;
        private System.Windows.Forms.ComboBox cb_Gltype;
        private System.Windows.Forms.ComboBox cb_settlement;
        private System.Windows.Forms.ComboBox cb_currency;
        private System.Windows.Forms.ComboBox cb_deliverytype;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.ComboBox cb_class;
        private System.Windows.Forms.CheckBox chk_deactive;
        private System.Windows.Forms.TextBox txtCreatedate;
        private System.Windows.Forms.TextBox txtCreateuser;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.Button btn_reset;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.ComboBox cb_buyer;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.TextBox txtBankname;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.TextBox txtAccnumber;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem exportToExcelToolStripMenuItem;
        private System.Windows.Forms.Button btnBrowse;
        private System.Windows.Forms.TextBox txtSupno;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtbrand;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.TextBox txtVAT;
        private System.Windows.Forms.Label label23;
    }
}