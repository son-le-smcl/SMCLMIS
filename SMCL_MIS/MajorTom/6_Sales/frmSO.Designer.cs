namespace SMCL_MIS
{
    partial class frmSO
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
            this.dSoDate = new System.Windows.Forms.DateTimePicker();
            this.btnSearchSO = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txtRemark = new System.Windows.Forms.TextBox();
            this.txtSoNo = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbSotype = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtStatus = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cbShipto = new System.Windows.Forms.ComboBox();
            this.cbShipFrom = new System.Windows.Forms.ComboBox();
            this.btnSearchCustomer = new System.Windows.Forms.Button();
            this.txtCurrency = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtCustomerId = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtPmterm = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtCustomername = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtTotalAmount = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.txtTotalQty = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.txtApproveDate = new System.Windows.Forms.TextBox();
            this.lbl_approvedate = new System.Windows.Forms.Label();
            this.txtApproveUser = new System.Windows.Forms.TextBox();
            this.lbl_approveuser = new System.Windows.Forms.Label();
            this.txtCreatedDate = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtCreateUser = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.btnApprove = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.dg_SoLine = new System.Windows.Forms.DataGridView();
            this.btn_reset = new System.Windows.Forms.Button();
            this.ctr_morebutton1 = new SMCL_MIS.ctr_morebutton();
            this.ctr_salemenu1 = new SMCL_MIS.ctr_salemenu();
            this.SoCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lineCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.partCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.partname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.modelCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CustPO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.oqtyCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.amountCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ShipdateCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.shippedCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.shiplocCol = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.dicusCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.remarkCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dg_SoLine)).BeginInit();
            this.SuspendLayout();
            // 
            // dSoDate
            // 
            this.dSoDate.CustomFormat = "yyyy-MM-dd HH:mm:ss";
            this.dSoDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dSoDate.Location = new System.Drawing.Point(77, 101);
            this.dSoDate.Name = "dSoDate";
            this.dSoDate.Size = new System.Drawing.Size(155, 20);
            this.dSoDate.TabIndex = 9;
            // 
            // btnSearchSO
            // 
            this.btnSearchSO.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSearchSO.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearchSO.Location = new System.Drawing.Point(231, 20);
            this.btnSearchSO.Name = "btnSearchSO";
            this.btnSearchSO.Size = new System.Drawing.Size(28, 20);
            this.btnSearchSO.TabIndex = 8;
            this.btnSearchSO.Text = "...";
            this.btnSearchSO.UseVisualStyleBackColor = true;
            this.btnSearchSO.Click += new System.EventHandler(this.btnSearchSO_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(2, 126);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Remark";
            // 
            // txtRemark
            // 
            this.txtRemark.Location = new System.Drawing.Point(77, 126);
            this.txtRemark.Name = "txtRemark";
            this.txtRemark.Size = new System.Drawing.Size(155, 20);
            this.txtRemark.TabIndex = 6;
            // 
            // txtSoNo
            // 
            this.txtSoNo.Location = new System.Drawing.Point(77, 20);
            this.txtSoNo.Name = "txtSoNo";
            this.txtSoNo.Size = new System.Drawing.Size(155, 20);
            this.txtSoNo.TabIndex = 3;
            this.txtSoNo.Leave += new System.EventHandler(this.txtSoNo_Leave);
            this.txtSoNo.MouseLeave += new System.EventHandler(this.txtSoNo_MouseLeave);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 100);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "So Date:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(2, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "So Type:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbSotype);
            this.groupBox1.Controls.Add(this.dSoDate);
            this.groupBox1.Controls.Add(this.btnSearchSO);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtRemark);
            this.groupBox1.Controls.Add(this.txtSoNo);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtStatus);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.groupBox1.Location = new System.Drawing.Point(12, 30);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(0);
            this.groupBox1.Size = new System.Drawing.Size(332, 158);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Sale Order";
            // 
            // cbSotype
            // 
            this.cbSotype.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSotype.FormattingEnabled = true;
            this.cbSotype.Location = new System.Drawing.Point(77, 72);
            this.cbSotype.Name = "cbSotype";
            this.cbSotype.Size = new System.Drawing.Size(155, 21);
            this.cbSotype.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(2, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "So Number:";
            // 
            // txtStatus
            // 
            this.txtStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStatus.Location = new System.Drawing.Point(77, 46);
            this.txtStatus.Name = "txtStatus";
            this.txtStatus.ReadOnly = true;
            this.txtStatus.Size = new System.Drawing.Size(113, 20);
            this.txtStatus.TabIndex = 19;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(2, 49);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(43, 13);
            this.label10.TabIndex = 0;
            this.label10.Text = "Status: ";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cbShipto);
            this.groupBox2.Controls.Add(this.cbShipFrom);
            this.groupBox2.Controls.Add(this.btnSearchCustomer);
            this.groupBox2.Controls.Add(this.txtCurrency);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.txtCustomerId);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.txtPmterm);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.txtCustomername);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Location = new System.Drawing.Point(350, 30);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(447, 158);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Customer";
            // 
            // cbShipto
            // 
            this.cbShipto.FormattingEnabled = true;
            this.cbShipto.Location = new System.Drawing.Point(250, 69);
            this.cbShipto.Name = "cbShipto";
            this.cbShipto.Size = new System.Drawing.Size(121, 21);
            this.cbShipto.TabIndex = 20;
            this.cbShipto.SelectedIndexChanged += new System.EventHandler(this.cbShipto_SelectedIndexChanged);
            // 
            // cbShipFrom
            // 
            this.cbShipFrom.FormattingEnabled = true;
            this.cbShipFrom.Location = new System.Drawing.Point(75, 69);
            this.cbShipFrom.Name = "cbShipFrom";
            this.cbShipFrom.Size = new System.Drawing.Size(121, 21);
            this.cbShipFrom.TabIndex = 19;
            // 
            // btnSearchCustomer
            // 
            this.btnSearchCustomer.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSearchCustomer.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearchCustomer.Location = new System.Drawing.Point(187, 17);
            this.btnSearchCustomer.Name = "btnSearchCustomer";
            this.btnSearchCustomer.Size = new System.Drawing.Size(28, 20);
            this.btnSearchCustomer.TabIndex = 9;
            this.btnSearchCustomer.Text = "...";
            this.btnSearchCustomer.UseVisualStyleBackColor = true;
            this.btnSearchCustomer.Click += new System.EventHandler(this.btnSearchCustomer_Click);
            // 
            // txtCurrency
            // 
            this.txtCurrency.Location = new System.Drawing.Point(279, 95);
            this.txtCurrency.Name = "txtCurrency";
            this.txtCurrency.ReadOnly = true;
            this.txtCurrency.Size = new System.Drawing.Size(92, 20);
            this.txtCurrency.TabIndex = 18;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(197, 98);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(49, 13);
            this.label12.TabIndex = 17;
            this.label12.Text = "Currency";
            // 
            // txtCustomerId
            // 
            this.txtCustomerId.Location = new System.Drawing.Point(75, 17);
            this.txtCustomerId.Name = "txtCustomerId";
            this.txtCustomerId.ReadOnly = true;
            this.txtCustomerId.Size = new System.Drawing.Size(113, 20);
            this.txtCustomerId.TabIndex = 16;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 20);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(62, 13);
            this.label9.TabIndex = 15;
            this.label9.Text = "Cutomer # :";
            // 
            // txtPmterm
            // 
            this.txtPmterm.Location = new System.Drawing.Point(75, 95);
            this.txtPmterm.Name = "txtPmterm";
            this.txtPmterm.ReadOnly = true;
            this.txtPmterm.Size = new System.Drawing.Size(121, 20);
            this.txtPmterm.TabIndex = 14;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 98);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(53, 13);
            this.label8.TabIndex = 13;
            this.label8.Text = "PM Term:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(197, 72);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(47, 13);
            this.label7.TabIndex = 11;
            this.label7.Text = "Ship To:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 72);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "Ship From:";
            // 
            // txtCustomername
            // 
            this.txtCustomername.Location = new System.Drawing.Point(75, 43);
            this.txtCustomername.Name = "txtCustomername";
            this.txtCustomername.ReadOnly = true;
            this.txtCustomername.Size = new System.Drawing.Size(296, 20);
            this.txtCustomername.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 46);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Cutomer :";
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.Controls.Add(this.txtTotalAmount);
            this.groupBox3.Controls.Add(this.label17);
            this.groupBox3.Controls.Add(this.txtTotalQty);
            this.groupBox3.Controls.Add(this.label16);
            this.groupBox3.Controls.Add(this.txtApproveDate);
            this.groupBox3.Controls.Add(this.lbl_approvedate);
            this.groupBox3.Controls.Add(this.txtApproveUser);
            this.groupBox3.Controls.Add(this.lbl_approveuser);
            this.groupBox3.Controls.Add(this.txtCreatedDate);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Controls.Add(this.txtCreateUser);
            this.groupBox3.Controls.Add(this.label14);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(803, 30);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(453, 158);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "General";
            // 
            // txtTotalAmount
            // 
            this.txtTotalAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotalAmount.Location = new System.Drawing.Point(93, 99);
            this.txtTotalAmount.Name = "txtTotalAmount";
            this.txtTotalAmount.ReadOnly = true;
            this.txtTotalAmount.Size = new System.Drawing.Size(113, 20);
            this.txtTotalAmount.TabIndex = 35;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(4, 102);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(73, 13);
            this.label17.TabIndex = 34;
            this.label17.Text = "Total Amount:";
            // 
            // txtTotalQty
            // 
            this.txtTotalQty.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotalQty.Location = new System.Drawing.Point(93, 73);
            this.txtTotalQty.Name = "txtTotalQty";
            this.txtTotalQty.ReadOnly = true;
            this.txtTotalQty.Size = new System.Drawing.Size(113, 20);
            this.txtTotalQty.TabIndex = 33;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(4, 76);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(53, 13);
            this.label16.TabIndex = 32;
            this.label16.Text = "Total Qty:";
            // 
            // txtApproveDate
            // 
            this.txtApproveDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtApproveDate.Location = new System.Drawing.Point(297, 42);
            this.txtApproveDate.Name = "txtApproveDate";
            this.txtApproveDate.ReadOnly = true;
            this.txtApproveDate.Size = new System.Drawing.Size(113, 20);
            this.txtApproveDate.TabIndex = 31;
            // 
            // lbl_approvedate
            // 
            this.lbl_approvedate.AutoSize = true;
            this.lbl_approvedate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_approvedate.Location = new System.Drawing.Point(212, 47);
            this.lbl_approvedate.Name = "lbl_approvedate";
            this.lbl_approvedate.Size = new System.Drawing.Size(82, 13);
            this.lbl_approvedate.TabIndex = 30;
            this.lbl_approvedate.Text = "Approved Date:";
            // 
            // txtApproveUser
            // 
            this.txtApproveUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtApproveUser.Location = new System.Drawing.Point(93, 47);
            this.txtApproveUser.Name = "txtApproveUser";
            this.txtApproveUser.ReadOnly = true;
            this.txtApproveUser.Size = new System.Drawing.Size(113, 20);
            this.txtApproveUser.TabIndex = 29;
            // 
            // lbl_approveuser
            // 
            this.lbl_approveuser.AutoSize = true;
            this.lbl_approveuser.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_approveuser.Location = new System.Drawing.Point(4, 53);
            this.lbl_approveuser.Name = "lbl_approveuser";
            this.lbl_approveuser.Size = new System.Drawing.Size(71, 13);
            this.lbl_approveuser.TabIndex = 28;
            this.lbl_approveuser.Text = "Approved By:";
            // 
            // txtCreatedDate
            // 
            this.txtCreatedDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCreatedDate.Location = new System.Drawing.Point(297, 17);
            this.txtCreatedDate.Name = "txtCreatedDate";
            this.txtCreatedDate.ReadOnly = true;
            this.txtCreatedDate.Size = new System.Drawing.Size(113, 20);
            this.txtCreatedDate.TabIndex = 27;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(212, 22);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(73, 13);
            this.label11.TabIndex = 26;
            this.label11.Text = "Created Date:";
            // 
            // txtCreateUser
            // 
            this.txtCreateUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCreateUser.Location = new System.Drawing.Point(93, 22);
            this.txtCreateUser.Name = "txtCreateUser";
            this.txtCreateUser.ReadOnly = true;
            this.txtCreateUser.Size = new System.Drawing.Size(113, 20);
            this.txtCreateUser.TabIndex = 25;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(4, 28);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(61, 13);
            this.label14.TabIndex = 24;
            this.label14.Text = "Created by:";
            // 
            // btnApprove
            // 
            this.btnApprove.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnApprove.Location = new System.Drawing.Point(109, 395);
            this.btnApprove.Name = "btnApprove";
            this.btnApprove.Size = new System.Drawing.Size(75, 23);
            this.btnApprove.TabIndex = 10;
            this.btnApprove.Text = "Approve";
            this.btnApprove.UseVisualStyleBackColor = true;
            this.btnApprove.Click += new System.EventHandler(this.btnApprove_Click);
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnSave.Location = new System.Drawing.Point(11, 395);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 7;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // dg_SoLine
            // 
            this.dg_SoLine.AllowUserToAddRows = false;
            this.dg_SoLine.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dg_SoLine.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dg_SoLine.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SoCol,
            this.lineCol,
            this.partCol,
            this.partname,
            this.modelCol,
            this.CustPO,
            this.oqtyCol,
            this.priceCol,
            this.amountCol,
            this.ShipdateCol,
            this.shippedCol,
            this.shiplocCol,
            this.dicusCol,
            this.remarkCol});
            this.dg_SoLine.Location = new System.Drawing.Point(12, 194);
            this.dg_SoLine.MultiSelect = false;
            this.dg_SoLine.Name = "dg_SoLine";
            this.dg_SoLine.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dg_SoLine.Size = new System.Drawing.Size(1244, 195);
            this.dg_SoLine.TabIndex = 5;
            this.dg_SoLine.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dg_SoLine_CellClick);
            this.dg_SoLine.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dg_SoLine_CellDoubleClick);
            this.dg_SoLine.CellLeave += new System.Windows.Forms.DataGridViewCellEventHandler(this.dg_SoLine_CellLeave);
            this.dg_SoLine.ColumnWidthChanged += new System.Windows.Forms.DataGridViewColumnEventHandler(this.dg_SoLine_ColumnWidthChanged);
            this.dg_SoLine.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.dg_SoLine_DataError);
            this.dg_SoLine.Scroll += new System.Windows.Forms.ScrollEventHandler(this.dg_SoLine_Scroll);
            this.dg_SoLine.UserDeletingRow += new System.Windows.Forms.DataGridViewRowCancelEventHandler(this.dg_SoLine_UserDeletingRow);
            // 
            // btn_reset
            // 
            this.btn_reset.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_reset.Location = new System.Drawing.Point(208, 396);
            this.btn_reset.Name = "btn_reset";
            this.btn_reset.Size = new System.Drawing.Size(75, 23);
            this.btn_reset.TabIndex = 12;
            this.btn_reset.Text = "Reset";
            this.btn_reset.UseVisualStyleBackColor = true;
            this.btn_reset.Click += new System.EventHandler(this.btn_reset_Click);
            // 
            // ctr_morebutton1
            // 
            this.ctr_morebutton1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ctr_morebutton1.Location = new System.Drawing.Point(1103, 395);
            this.ctr_morebutton1.Name = "ctr_morebutton1";
            this.ctr_morebutton1.Size = new System.Drawing.Size(153, 23);
            this.ctr_morebutton1.TabIndex = 11;
            // 
            // ctr_salemenu1
            // 
            this.ctr_salemenu1.AutoSize = true;
            this.ctr_salemenu1.Dock = System.Windows.Forms.DockStyle.Top;
            this.ctr_salemenu1.Location = new System.Drawing.Point(0, 0);
            this.ctr_salemenu1.Name = "ctr_salemenu1";
            this.ctr_salemenu1.Size = new System.Drawing.Size(1268, 26);
            this.ctr_salemenu1.TabIndex = 0;
            // 
            // SoCol
            // 
            this.SoCol.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.SoCol.HeaderText = "So Number";
            this.SoCol.Name = "SoCol";
            this.SoCol.ReadOnly = true;
            this.SoCol.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.SoCol.Visible = false;
            this.SoCol.Width = 66;
            // 
            // lineCol
            // 
            this.lineCol.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.lineCol.HeaderText = "Line";
            this.lineCol.Name = "lineCol";
            this.lineCol.ReadOnly = true;
            this.lineCol.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.lineCol.Width = 33;
            // 
            // partCol
            // 
            this.partCol.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.partCol.HeaderText = "Part Number";
            this.partCol.Name = "partCol";
            this.partCol.ReadOnly = true;
            this.partCol.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.partCol.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.partCol.Width = 72;
            // 
            // partname
            // 
            this.partname.HeaderText = "Description";
            this.partname.Name = "partname";
            this.partname.ReadOnly = true;
            this.partname.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // modelCol
            // 
            this.modelCol.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.modelCol.HeaderText = "Model";
            this.modelCol.Name = "modelCol";
            this.modelCol.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.modelCol.Width = 42;
            // 
            // CustPO
            // 
            this.CustPO.HeaderText = "Customer PO";
            this.CustPO.Name = "CustPO";
            // 
            // oqtyCol
            // 
            this.oqtyCol.HeaderText = "Ordered Qty";
            this.oqtyCol.Name = "oqtyCol";
            this.oqtyCol.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // priceCol
            // 
            this.priceCol.HeaderText = "Unit Price";
            this.priceCol.Name = "priceCol";
            this.priceCol.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // amountCol
            // 
            this.amountCol.HeaderText = "Amount";
            this.amountCol.Name = "amountCol";
            this.amountCol.ReadOnly = true;
            this.amountCol.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // ShipdateCol
            // 
            this.ShipdateCol.FillWeight = 150F;
            this.ShipdateCol.HeaderText = "Ship Date";
            this.ShipdateCol.MinimumWidth = 100;
            this.ShipdateCol.Name = "ShipdateCol";
            this.ShipdateCol.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // shippedCol
            // 
            this.shippedCol.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.shippedCol.HeaderText = "Shipped Qty";
            this.shippedCol.Name = "shippedCol";
            this.shippedCol.ReadOnly = true;
            this.shippedCol.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.shippedCol.Width = 71;
            // 
            // shiplocCol
            // 
            this.shiplocCol.DisplayStyleForCurrentCellOnly = true;
            this.shiplocCol.HeaderText = "Ship Location";
            this.shiplocCol.Name = "shiplocCol";
            // 
            // dicusCol
            // 
            this.dicusCol.HeaderText = "DI Customer";
            this.dicusCol.Name = "dicusCol";
            this.dicusCol.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // remarkCol
            // 
            this.remarkCol.HeaderText = "Remark";
            this.remarkCol.Name = "remarkCol";
            this.remarkCol.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // frmSO
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1268, 431);
            this.Controls.Add(this.btn_reset);
            this.Controls.Add(this.ctr_morebutton1);
            this.Controls.Add(this.btnApprove);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.dg_SoLine);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.ctr_salemenu1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmSO";
            this.Text = "SALES ORDERS";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmSO_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dg_SoLine)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ctr_salemenu ctr_salemenu1;
        private System.Windows.Forms.DateTimePicker dSoDate;
        private System.Windows.Forms.Button btnSearchSO;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtRemark;
        private System.Windows.Forms.TextBox txtSoNo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnSearchCustomer;
        private System.Windows.Forms.TextBox txtCurrency;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtCustomerId;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtPmterm;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtCustomername;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txtTotalAmount;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox txtTotalQty;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox txtApproveDate;
        private System.Windows.Forms.Label lbl_approvedate;
        private System.Windows.Forms.TextBox txtApproveUser;
        private System.Windows.Forms.Label lbl_approveuser;
        private System.Windows.Forms.TextBox txtCreatedDate;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtCreateUser;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtStatus;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnApprove;
        private System.Windows.Forms.Button btnSave;
        private ctr_morebutton ctr_morebutton1;
        private System.Windows.Forms.DataGridView dg_SoLine;
        private System.Windows.Forms.Button btn_reset;
        private System.Windows.Forms.ComboBox cbShipto;
        private System.Windows.Forms.ComboBox cbShipFrom;
        private System.Windows.Forms.ComboBox cbSotype;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn lineCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn partCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn partname;
        private System.Windows.Forms.DataGridViewTextBoxColumn modelCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn CustPO;
        private System.Windows.Forms.DataGridViewTextBoxColumn oqtyCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn amountCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn ShipdateCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn shippedCol;
        private System.Windows.Forms.DataGridViewComboBoxColumn shiplocCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn dicusCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn remarkCol;
    }
}