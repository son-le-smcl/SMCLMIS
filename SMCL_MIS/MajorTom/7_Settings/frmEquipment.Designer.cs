namespace SMCL_MIS
{
    partial class frmEquipment
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
            this.button3 = new System.Windows.Forms.Button();
            this.txtEId = new System.Windows.Forms.TextBox();
            this.ID = new System.Windows.Forms.Label();
            this.cb_eStatus = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.cbEcategory = new System.Windows.Forms.ComboBox();
            this.txtEremark = new System.Windows.Forms.RichTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txteMac = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtEsn = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtEcreatedate = new System.Windows.Forms.DateTimePicker();
            this.txtWarranty = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dp_eBuydate = new System.Windows.Forms.DateTimePicker();
            this.txtEname = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.label16 = new System.Windows.Forms.Label();
            this.txteRark = new System.Windows.Forms.RichTextBox();
            this.txteLocation = new System.Windows.Forms.ComboBox();
            this.label15 = new System.Windows.Forms.Label();
            this.txteInstalldate = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.txteUser = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txteTxt = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txteli = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txteIp = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.Equipment = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.Gv_EquipList = new System.Windows.Forms.DataGridView();
            this.equipment_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ping_ = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.equipment_description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.equipment_mac = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.config_ip = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.equipment_warranty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.equipment_category = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.config_install_location = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.config_user = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.equipment_date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.equiptment_status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.exportToExcelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.crt_Settingsmenu1 = new SMCL_MIS.crt_Settingsmenu();
            this.crt_Settingsmenu2 = new SMCL_MIS.crt_Settingsmenu();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.Equipment.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Gv_EquipList)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button3);
            this.groupBox1.Controls.Add(this.txtEId);
            this.groupBox1.Controls.Add(this.ID);
            this.groupBox1.Controls.Add(this.cb_eStatus);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.cbEcategory);
            this.groupBox1.Controls.Add(this.txtEremark);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.txteMac);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txtEsn);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtEcreatedate);
            this.groupBox1.Controls.Add(this.txtWarranty);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.dp_eBuydate);
            this.groupBox1.Controls.Add(this.txtEname);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 29);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(298, 323);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Info";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(208, 17);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(27, 23);
            this.button3.TabIndex = 20;
            this.button3.Text = "...";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // txtEId
            // 
            this.txtEId.Location = new System.Drawing.Point(88, 19);
            this.txtEId.MaxLength = 50;
            this.txtEId.Name = "txtEId";
            this.txtEId.ReadOnly = true;
            this.txtEId.Size = new System.Drawing.Size(121, 20);
            this.txtEId.TabIndex = 19;
            // 
            // ID
            // 
            this.ID.AutoSize = true;
            this.ID.Location = new System.Drawing.Point(4, 22);
            this.ID.Name = "ID";
            this.ID.Size = new System.Drawing.Size(18, 13);
            this.ID.TabIndex = 18;
            this.ID.Text = "ID";
            // 
            // cb_eStatus
            // 
            this.cb_eStatus.FormattingEnabled = true;
            this.cb_eStatus.Items.AddRange(new object[] {
            "Inuse",
            "Broken",
            "Resell"});
            this.cb_eStatus.Location = new System.Drawing.Point(88, 46);
            this.cb_eStatus.Name = "cb_eStatus";
            this.cb_eStatus.Size = new System.Drawing.Size(121, 21);
            this.cb_eStatus.TabIndex = 17;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(4, 50);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(37, 13);
            this.label9.TabIndex = 16;
            this.label9.Text = "Status";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(4, 181);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(49, 13);
            this.label8.TabIndex = 15;
            this.label8.Text = "Category";
            // 
            // cbEcategory
            // 
            this.cbEcategory.FormattingEnabled = true;
            this.cbEcategory.Items.AddRange(new object[] {
            "Desktop",
            "Laptop",
            "Printer",
            "Camera",
            "Router",
            "Switch",
            "Firewall",
            "Server",
            "Tivi",
            "Fingerprint"});
            this.cbEcategory.Location = new System.Drawing.Point(88, 177);
            this.cbEcategory.Name = "cbEcategory";
            this.cbEcategory.Size = new System.Drawing.Size(121, 21);
            this.cbEcategory.TabIndex = 14;
            // 
            // txtEremark
            // 
            this.txtEremark.Location = new System.Drawing.Point(88, 260);
            this.txtEremark.Name = "txtEremark";
            this.txtEremark.Size = new System.Drawing.Size(202, 48);
            this.txtEremark.TabIndex = 13;
            this.txtEremark.Text = "";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(4, 260);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(44, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "Remark";
            // 
            // txteMac
            // 
            this.txteMac.Location = new System.Drawing.Point(88, 231);
            this.txteMac.Name = "txteMac";
            this.txteMac.Size = new System.Drawing.Size(121, 20);
            this.txteMac.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(4, 234);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(30, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "MAC";
            // 
            // txtEsn
            // 
            this.txtEsn.Location = new System.Drawing.Point(88, 205);
            this.txtEsn.Name = "txtEsn";
            this.txtEsn.Size = new System.Drawing.Size(121, 20);
            this.txtEsn.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(4, 208);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(22, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "SN";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(4, 131);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Created Date";
            // 
            // txtEcreatedate
            // 
            this.txtEcreatedate.Enabled = false;
            this.txtEcreatedate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.txtEcreatedate.Location = new System.Drawing.Point(88, 125);
            this.txtEcreatedate.Name = "txtEcreatedate";
            this.txtEcreatedate.Size = new System.Drawing.Size(81, 20);
            this.txtEcreatedate.TabIndex = 6;
            // 
            // txtWarranty
            // 
            this.txtWarranty.Location = new System.Drawing.Point(88, 151);
            this.txtWarranty.MaxLength = 3;
            this.txtWarranty.Name = "txtWarranty";
            this.txtWarranty.Size = new System.Drawing.Size(29, 20);
            this.txtWarranty.TabIndex = 5;
            this.txtWarranty.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(4, 154);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Warranty(month)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(4, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Purchase Date";
            // 
            // dp_eBuydate
            // 
            this.dp_eBuydate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dp_eBuydate.Location = new System.Drawing.Point(88, 99);
            this.dp_eBuydate.Name = "dp_eBuydate";
            this.dp_eBuydate.Size = new System.Drawing.Size(81, 20);
            this.dp_eBuydate.TabIndex = 2;
            // 
            // txtEname
            // 
            this.txtEname.Location = new System.Drawing.Point(88, 73);
            this.txtEname.MaxLength = 50;
            this.txtEname.Name = "txtEname";
            this.txtEname.Size = new System.Drawing.Size(164, 20);
            this.txtEname.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name";
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox2.Controls.Add(this.btnReset);
            this.groupBox2.Controls.Add(this.btnSave);
            this.groupBox2.Controls.Add(this.label16);
            this.groupBox2.Controls.Add(this.txteRark);
            this.groupBox2.Controls.Add(this.txteLocation);
            this.groupBox2.Controls.Add(this.label15);
            this.groupBox2.Controls.Add(this.txteInstalldate);
            this.groupBox2.Controls.Add(this.label14);
            this.groupBox2.Controls.Add(this.txteUser);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.txteTxt);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.txteli);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.txteIp);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Location = new System.Drawing.Point(12, 358);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(298, 270);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Config";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(169, 238);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(75, 23);
            this.btnReset.TabIndex = 29;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(88, 238);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 28;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(4, 153);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(48, 13);
            this.label16.TabIndex = 19;
            this.label16.Text = "Location";
            // 
            // txteRark
            // 
            this.txteRark.Location = new System.Drawing.Point(88, 179);
            this.txteRark.Name = "txteRark";
            this.txteRark.Size = new System.Drawing.Size(202, 48);
            this.txteRark.TabIndex = 19;
            this.txteRark.Text = "";
            // 
            // txteLocation
            // 
            this.txteLocation.FormattingEnabled = true;
            this.txteLocation.Items.AddRange(new object[] {
            "Main Office F1",
            "Main Office F2",
            "Main Office F3",
            "Ware House Office",
            "Production Line"});
            this.txteLocation.Location = new System.Drawing.Point(88, 149);
            this.txteLocation.Name = "txteLocation";
            this.txteLocation.Size = new System.Drawing.Size(121, 21);
            this.txteLocation.TabIndex = 18;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(4, 179);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(44, 13);
            this.label15.TabIndex = 18;
            this.label15.Text = "Remark";
            // 
            // txteInstalldate
            // 
            this.txteInstalldate.Location = new System.Drawing.Point(88, 123);
            this.txteInstalldate.Name = "txteInstalldate";
            this.txteInstalldate.Size = new System.Drawing.Size(121, 20);
            this.txteInstalldate.TabIndex = 27;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(4, 126);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(70, 13);
            this.label14.TabIndex = 26;
            this.label14.Text = "Installed date";
            // 
            // txteUser
            // 
            this.txteUser.Location = new System.Drawing.Point(88, 97);
            this.txteUser.Name = "txteUser";
            this.txteUser.Size = new System.Drawing.Size(121, 20);
            this.txteUser.TabIndex = 25;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(4, 100);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(64, 13);
            this.label13.TabIndex = 24;
            this.label13.Text = "Current user";
            // 
            // txteTxt
            // 
            this.txteTxt.Location = new System.Drawing.Point(88, 71);
            this.txteTxt.Name = "txteTxt";
            this.txteTxt.Size = new System.Drawing.Size(121, 20);
            this.txteTxt.TabIndex = 23;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(4, 74);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(28, 13);
            this.label12.TabIndex = 22;
            this.label12.Text = "Pwd";
            // 
            // txteli
            // 
            this.txteli.Location = new System.Drawing.Point(88, 45);
            this.txteli.Name = "txteli";
            this.txteli.Size = new System.Drawing.Size(121, 20);
            this.txteli.TabIndex = 21;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(4, 48);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(55, 13);
            this.label11.TabIndex = 20;
            this.label11.Text = "Username";
            // 
            // txteIp
            // 
            this.txteIp.Location = new System.Drawing.Point(88, 19);
            this.txteIp.Name = "txteIp";
            this.txteIp.Size = new System.Drawing.Size(121, 20);
            this.txteIp.TabIndex = 19;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(4, 22);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(57, 13);
            this.label10.TabIndex = 18;
            this.label10.Text = "IP address";
            // 
            // Equipment
            // 
            this.Equipment.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Equipment.Controls.Add(this.button2);
            this.Equipment.Controls.Add(this.button1);
            this.Equipment.Controls.Add(this.txtSearch);
            this.Equipment.Controls.Add(this.Gv_EquipList);
            this.Equipment.Location = new System.Drawing.Point(316, 29);
            this.Equipment.Name = "Equipment";
            this.Equipment.Size = new System.Drawing.Size(698, 323);
            this.Equipment.TabIndex = 4;
            this.Equipment.TabStop = false;
            this.Equipment.Text = "Equipment";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(198, 16);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(60, 23);
            this.button2.TabIndex = 24;
            this.button2.Text = "Update";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(132, 16);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(60, 23);
            this.button1.TabIndex = 23;
            this.button1.Text = "Ping";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(5, 19);
            this.txtSearch.MaxLength = 50;
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(121, 20);
            this.txtSearch.TabIndex = 21;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // Gv_EquipList
            // 
            this.Gv_EquipList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Gv_EquipList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.Gv_EquipList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Gv_EquipList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.equipment_id,
            this.Ping_,
            this.equipment_description,
            this.equipment_mac,
            this.config_ip,
            this.equipment_warranty,
            this.equipment_category,
            this.config_install_location,
            this.config_user,
            this.equipment_date,
            this.equiptment_status});
            this.Gv_EquipList.ContextMenuStrip = this.contextMenuStrip1;
            this.Gv_EquipList.Location = new System.Drawing.Point(6, 45);
            this.Gv_EquipList.Name = "Gv_EquipList";
            this.Gv_EquipList.Size = new System.Drawing.Size(686, 265);
            this.Gv_EquipList.TabIndex = 5;
            this.Gv_EquipList.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Gv_EquipList_CellClick);
            this.Gv_EquipList.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.Gv_EquipList_RowPostPaint);
            // 
            // equipment_id
            // 
            this.equipment_id.DataPropertyName = "equipment_id";
            this.equipment_id.HeaderText = "ID";
            this.equipment_id.Name = "equipment_id";
            this.equipment_id.ReadOnly = true;
            // 
            // Ping_
            // 
            this.Ping_.HeaderText = "PING";
            this.Ping_.Name = "Ping_";
            this.Ping_.ReadOnly = true;
            // 
            // equipment_description
            // 
            this.equipment_description.DataPropertyName = "equipment_description";
            this.equipment_description.HeaderText = "Name";
            this.equipment_description.Name = "equipment_description";
            this.equipment_description.ReadOnly = true;
            // 
            // equipment_mac
            // 
            this.equipment_mac.DataPropertyName = "equipment_mac";
            this.equipment_mac.HeaderText = "Mac Address";
            this.equipment_mac.Name = "equipment_mac";
            this.equipment_mac.ReadOnly = true;
            // 
            // config_ip
            // 
            this.config_ip.DataPropertyName = "config_ip";
            this.config_ip.HeaderText = "Ip Address";
            this.config_ip.Name = "config_ip";
            this.config_ip.ReadOnly = true;
            // 
            // equipment_warranty
            // 
            this.equipment_warranty.DataPropertyName = "equipment_warranty";
            this.equipment_warranty.HeaderText = "Warranty";
            this.equipment_warranty.Name = "equipment_warranty";
            this.equipment_warranty.ReadOnly = true;
            // 
            // equipment_category
            // 
            this.equipment_category.DataPropertyName = "equipment_category";
            this.equipment_category.HeaderText = "Category";
            this.equipment_category.Name = "equipment_category";
            this.equipment_category.ReadOnly = true;
            // 
            // config_install_location
            // 
            this.config_install_location.DataPropertyName = "config_install_location";
            this.config_install_location.HeaderText = "Location";
            this.config_install_location.Name = "config_install_location";
            this.config_install_location.ReadOnly = true;
            // 
            // config_user
            // 
            this.config_user.DataPropertyName = "config_user";
            this.config_user.HeaderText = "Current User";
            this.config_user.Name = "config_user";
            this.config_user.ReadOnly = true;
            // 
            // equipment_date
            // 
            this.equipment_date.DataPropertyName = "equipment_date";
            this.equipment_date.HeaderText = "Purchase Date";
            this.equipment_date.Name = "equipment_date";
            this.equipment_date.ReadOnly = true;
            // 
            // equiptment_status
            // 
            this.equiptment_status.DataPropertyName = "equiptment_status";
            this.equiptment_status.HeaderText = "Status";
            this.equiptment_status.Name = "equiptment_status";
            this.equiptment_status.ReadOnly = true;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exportToExcelToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(151, 26);
            // 
            // exportToExcelToolStripMenuItem
            // 
            this.exportToExcelToolStripMenuItem.Name = "exportToExcelToolStripMenuItem";
            this.exportToExcelToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
            this.exportToExcelToolStripMenuItem.Text = "Export to Excel";
            this.exportToExcelToolStripMenuItem.Click += new System.EventHandler(this.exportToExcelToolStripMenuItem_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox4.Controls.Add(this.pictureBox1);
            this.groupBox4.Location = new System.Drawing.Point(316, 358);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(698, 270);
            this.groupBox4.TabIndex = 5;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "\\\\192.168.84.2\\it\\06_Documents\\Equipmentphoto\\";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.BackColor = System.Drawing.SystemColors.Window;
            this.pictureBox1.Location = new System.Drawing.Point(6, 22);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(686, 239);
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // crt_Settingsmenu1
            // 
            this.crt_Settingsmenu1.Dock = System.Windows.Forms.DockStyle.Top;
            this.crt_Settingsmenu1.Location = new System.Drawing.Point(0, 0);
            this.crt_Settingsmenu1.Name = "crt_Settingsmenu1";
            this.crt_Settingsmenu1.Size = new System.Drawing.Size(1026, 23);
            this.crt_Settingsmenu1.TabIndex = 0;
            // 
            // crt_Settingsmenu2
            // 
            this.crt_Settingsmenu2.Dock = System.Windows.Forms.DockStyle.Top;
            this.crt_Settingsmenu2.Location = new System.Drawing.Point(0, 0);
            this.crt_Settingsmenu2.Name = "crt_Settingsmenu2";
            this.crt_Settingsmenu2.Size = new System.Drawing.Size(1026, 23);
            this.crt_Settingsmenu2.TabIndex = 6;
            // 
            // frmEquipment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1026, 640);
            this.Controls.Add(this.crt_Settingsmenu2);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.Equipment);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmEquipment";
            this.Text = "frmEquipment";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmEquipment_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.Equipment.ResumeLayout(false);
            this.Equipment.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Gv_EquipList)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private crt_Settingsmenu crt_Settingsmenu1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtEname;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dp_eBuydate;
        private System.Windows.Forms.TextBox txtWarranty;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker txtEcreatedate;
        private System.Windows.Forms.TextBox txtEsn;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txteMac;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.RichTextBox txtEremark;
        private System.Windows.Forms.ComboBox cbEcategory;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cb_eStatus;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txteInstalldate;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txteUser;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txteTxt;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txteli;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txteIp;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.RichTextBox txteRark;
        private System.Windows.Forms.ComboBox txteLocation;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.GroupBox Equipment;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox txtEId;
        private System.Windows.Forms.Label ID;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView Gv_EquipList;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridViewTextBoxColumn equipment_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ping_;
        private System.Windows.Forms.DataGridViewTextBoxColumn equipment_description;
        private System.Windows.Forms.DataGridViewTextBoxColumn equipment_mac;
        private System.Windows.Forms.DataGridViewTextBoxColumn config_ip;
        private System.Windows.Forms.DataGridViewTextBoxColumn equipment_warranty;
        private System.Windows.Forms.DataGridViewTextBoxColumn equipment_category;
        private System.Windows.Forms.DataGridViewTextBoxColumn config_install_location;
        private System.Windows.Forms.DataGridViewTextBoxColumn config_user;
        private System.Windows.Forms.DataGridViewTextBoxColumn equipment_date;
        private System.Windows.Forms.DataGridViewTextBoxColumn equiptment_status;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem exportToExcelToolStripMenuItem;
        private crt_Settingsmenu crt_Settingsmenu2;
    }
}