namespace SMCL_MIS
{
    partial class frmBOM
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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtbomUpdatedate = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtbomRemark = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtbomType = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtbomUpdateby = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtbomCreateDate = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtbomCreateby = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_searchbom = new System.Windows.Forms.Button();
            this.txtbomname = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtBom = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label21 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.txtUpdateDate = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.txtUpateBy = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.txtCreateDate = new System.Windows.Forms.TextBox();
            this.label24 = new System.Windows.Forms.Label();
            this.txtLeadTime = new System.Windows.Forms.TextBox();
            this.txtCreateBy = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.txtLossrate = new System.Windows.Forms.TextBox();
            this.txtlabor = new System.Windows.Forms.TextBox();
            this.txtweight = new System.Windows.Forms.TextBox();
            this.txtQty = new System.Windows.Forms.TextBox();
            this.BOM_pictureBox = new System.Windows.Forms.PictureBox();
            this.txtMOQ = new System.Windows.Forms.TextBox();
            this.txtWorkShop = new System.Windows.Forms.TextBox();
            this.txtMakeBuy = new System.Windows.Forms.TextBox();
            this.txtErpType = new System.Windows.Forms.TextBox();
            this.txtUom = new System.Windows.Forms.TextBox();
            this.txtClass = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtMatType = new System.Windows.Forms.TextBox();
            this.chk_enable = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Partnumber = new System.Windows.Forms.Label();
            this.txtPartname = new System.Windows.Forms.RichTextBox();
            this.txtpartno = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.bom_add = new System.Windows.Forms.ToolStripMenuItem();
            this.bom_delete = new System.Windows.Forms.ToolStripMenuItem();
            this.ctr_enginerrmenu1 = new SMCL_MIS.ctr_enginerrmenu();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BOM_pictureBox)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 26);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.treeView1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.button4);
            this.splitContainer1.Panel2.Controls.Add(this.button3);
            this.splitContainer1.Panel2.Controls.Add(this.button2);
            this.splitContainer1.Panel2.Controls.Add(this.groupBox4);
            this.splitContainer1.Panel2.Controls.Add(this.groupBox1);
            this.splitContainer1.Size = new System.Drawing.Size(995, 552);
            this.splitContainer1.SplitterDistance = 196;
            this.splitContainer1.TabIndex = 3;
            // 
            // treeView1
            // 
            this.treeView1.ContextMenuStrip = this.contextMenuStrip1;
            this.treeView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeView1.Location = new System.Drawing.Point(0, 0);
            this.treeView1.Name = "treeView1";
            this.treeView1.Size = new System.Drawing.Size(196, 552);
            this.treeView1.TabIndex = 0;
            this.treeView1.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView1_AfterSelect);
            this.treeView1.Click += new System.EventHandler(this.treeView1_Click);
            // 
            // button4
            // 
            this.button4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button4.Location = new System.Drawing.Point(180, 521);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 5;
            this.button4.Text = "button4";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button3.Location = new System.Drawing.Point(97, 521);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 4;
            this.button3.Text = "button3";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button2.Location = new System.Drawing.Point(14, 521);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 3;
            this.button2.Text = "Save";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            this.groupBox4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox4.Controls.Add(this.label10);
            this.groupBox4.Controls.Add(this.txtbomUpdatedate);
            this.groupBox4.Controls.Add(this.label9);
            this.groupBox4.Controls.Add(this.txtbomRemark);
            this.groupBox4.Controls.Add(this.label8);
            this.groupBox4.Controls.Add(this.txtbomType);
            this.groupBox4.Controls.Add(this.label7);
            this.groupBox4.Controls.Add(this.txtbomUpdateby);
            this.groupBox4.Controls.Add(this.label6);
            this.groupBox4.Controls.Add(this.txtbomCreateDate);
            this.groupBox4.Controls.Add(this.label5);
            this.groupBox4.Controls.Add(this.txtbomCreateby);
            this.groupBox4.Controls.Add(this.label4);
            this.groupBox4.Controls.Add(this.btn_searchbom);
            this.groupBox4.Controls.Add(this.txtbomname);
            this.groupBox4.Controls.Add(this.label1);
            this.groupBox4.Controls.Add(this.txtBom);
            this.groupBox4.Location = new System.Drawing.Point(2, 6);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(780, 136);
            this.groupBox4.TabIndex = 2;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "BOM Usage";
            this.groupBox4.Enter += new System.EventHandler(this.groupBox4_Enter);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(425, 95);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(68, 13);
            this.label10.TabIndex = 21;
            this.label10.Text = "Update Date";
            // 
            // txtbomUpdatedate
            // 
            this.txtbomUpdatedate.Location = new System.Drawing.Point(502, 92);
            this.txtbomUpdatedate.Name = "txtbomUpdatedate";
            this.txtbomUpdatedate.ReadOnly = true;
            this.txtbomUpdatedate.Size = new System.Drawing.Size(153, 20);
            this.txtbomUpdatedate.TabIndex = 20;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(7, 99);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(44, 13);
            this.label9.TabIndex = 19;
            this.label9.Text = "Remark";
            // 
            // txtbomRemark
            // 
            this.txtbomRemark.Location = new System.Drawing.Point(84, 96);
            this.txtbomRemark.Name = "txtbomRemark";
            this.txtbomRemark.ReadOnly = true;
            this.txtbomRemark.Size = new System.Drawing.Size(326, 20);
            this.txtbomRemark.TabIndex = 18;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(276, 21);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(31, 13);
            this.label8.TabIndex = 17;
            this.label8.Text = "Type";
            // 
            // txtbomType
            // 
            this.txtbomType.Location = new System.Drawing.Point(313, 19);
            this.txtbomType.Name = "txtbomType";
            this.txtbomType.ReadOnly = true;
            this.txtbomType.Size = new System.Drawing.Size(98, 20);
            this.txtbomType.TabIndex = 16;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(425, 69);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(57, 13);
            this.label7.TabIndex = 15;
            this.label7.Text = "Update By";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // txtbomUpdateby
            // 
            this.txtbomUpdateby.Location = new System.Drawing.Point(502, 66);
            this.txtbomUpdateby.Name = "txtbomUpdateby";
            this.txtbomUpdateby.ReadOnly = true;
            this.txtbomUpdateby.Size = new System.Drawing.Size(153, 20);
            this.txtbomUpdateby.TabIndex = 14;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(425, 43);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Create Date";
            // 
            // txtbomCreateDate
            // 
            this.txtbomCreateDate.Location = new System.Drawing.Point(502, 40);
            this.txtbomCreateDate.Name = "txtbomCreateDate";
            this.txtbomCreateDate.ReadOnly = true;
            this.txtbomCreateDate.Size = new System.Drawing.Size(153, 20);
            this.txtbomCreateDate.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(425, 18);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Create By";
            // 
            // txtbomCreateby
            // 
            this.txtbomCreateby.Location = new System.Drawing.Point(502, 15);
            this.txtbomCreateby.Name = "txtbomCreateby";
            this.txtbomCreateby.ReadOnly = true;
            this.txtbomCreateby.Size = new System.Drawing.Size(153, 20);
            this.txtbomCreateby.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 47);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Name";
            // 
            // btn_searchbom
            // 
            this.btn_searchbom.Location = new System.Drawing.Point(241, 17);
            this.btn_searchbom.Name = "btn_searchbom";
            this.btn_searchbom.Size = new System.Drawing.Size(31, 23);
            this.btn_searchbom.TabIndex = 9;
            this.btn_searchbom.Text = "...";
            this.btn_searchbom.UseVisualStyleBackColor = true;
            this.btn_searchbom.Click += new System.EventHandler(this.btn_searchbom_Click);
            // 
            // txtbomname
            // 
            this.txtbomname.Location = new System.Drawing.Point(84, 44);
            this.txtbomname.Name = "txtbomname";
            this.txtbomname.ReadOnly = true;
            this.txtbomname.Size = new System.Drawing.Size(327, 46);
            this.txtbomname.TabIndex = 7;
            this.txtbomname.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Part Number";
            // 
            // txtBom
            // 
            this.txtBom.Location = new System.Drawing.Point(84, 19);
            this.txtBom.Name = "txtBom";
            this.txtBom.Size = new System.Drawing.Size(158, 20);
            this.txtBom.TabIndex = 7;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.label21);
            this.groupBox1.Controls.Add(this.label20);
            this.groupBox1.Controls.Add(this.txtUpdateDate);
            this.groupBox1.Controls.Add(this.label19);
            this.groupBox1.Controls.Add(this.label22);
            this.groupBox1.Controls.Add(this.label18);
            this.groupBox1.Controls.Add(this.txtUpateBy);
            this.groupBox1.Controls.Add(this.label17);
            this.groupBox1.Controls.Add(this.label23);
            this.groupBox1.Controls.Add(this.label16);
            this.groupBox1.Controls.Add(this.txtCreateDate);
            this.groupBox1.Controls.Add(this.label24);
            this.groupBox1.Controls.Add(this.txtLeadTime);
            this.groupBox1.Controls.Add(this.txtCreateBy);
            this.groupBox1.Controls.Add(this.label15);
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.txtLossrate);
            this.groupBox1.Controls.Add(this.txtlabor);
            this.groupBox1.Controls.Add(this.txtweight);
            this.groupBox1.Controls.Add(this.txtQty);
            this.groupBox1.Controls.Add(this.BOM_pictureBox);
            this.groupBox1.Controls.Add(this.txtMOQ);
            this.groupBox1.Controls.Add(this.txtWorkShop);
            this.groupBox1.Controls.Add(this.txtMakeBuy);
            this.groupBox1.Controls.Add(this.txtErpType);
            this.groupBox1.Controls.Add(this.txtUom);
            this.groupBox1.Controls.Add(this.txtClass);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtMatType);
            this.groupBox1.Controls.Add(this.chk_enable);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.Partnumber);
            this.groupBox1.Controls.Add(this.txtPartname);
            this.groupBox1.Controls.Add(this.txtpartno);
            this.groupBox1.Location = new System.Drawing.Point(2, 148);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(780, 367);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Materials Infomation";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(7, 328);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(68, 13);
            this.label21.TabIndex = 29;
            this.label21.Text = "Update Date";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(209, 201);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(67, 13);
            this.label20.TabIndex = 28;
            this.label20.Text = "LOSS RATE";
            // 
            // txtUpdateDate
            // 
            this.txtUpdateDate.Location = new System.Drawing.Point(83, 329);
            this.txtUpdateDate.Name = "txtUpdateDate";
            this.txtUpdateDate.ReadOnly = true;
            this.txtUpdateDate.Size = new System.Drawing.Size(120, 20);
            this.txtUpdateDate.TabIndex = 28;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(209, 178);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(78, 13);
            this.label19.TabIndex = 27;
            this.label19.Text = "LABOR HOUR";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(7, 300);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(57, 13);
            this.label22.TabIndex = 27;
            this.label22.Text = "Update By";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(224, 149);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(41, 13);
            this.label18.TabIndex = 26;
            this.label18.Text = "Weight";
            // 
            // txtUpateBy
            // 
            this.txtUpateBy.Location = new System.Drawing.Point(83, 303);
            this.txtUpateBy.Name = "txtUpateBy";
            this.txtUpateBy.ReadOnly = true;
            this.txtUpateBy.Size = new System.Drawing.Size(120, 20);
            this.txtUpateBy.TabIndex = 26;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(224, 123);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(29, 13);
            this.label17.TabIndex = 25;
            this.label17.Text = "QTY";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(7, 276);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(64, 13);
            this.label23.TabIndex = 25;
            this.label23.Text = "Create Date";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(7, 226);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(57, 13);
            this.label16.TabIndex = 24;
            this.label16.Text = "Lead Time";
            // 
            // txtCreateDate
            // 
            this.txtCreateDate.Location = new System.Drawing.Point(83, 277);
            this.txtCreateDate.Name = "txtCreateDate";
            this.txtCreateDate.ReadOnly = true;
            this.txtCreateDate.Size = new System.Drawing.Size(120, 20);
            this.txtCreateDate.TabIndex = 24;
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(7, 251);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(53, 13);
            this.label24.TabIndex = 23;
            this.label24.Text = "Create By";
            // 
            // txtLeadTime
            // 
            this.txtLeadTime.Location = new System.Drawing.Point(83, 226);
            this.txtLeadTime.Name = "txtLeadTime";
            this.txtLeadTime.ReadOnly = true;
            this.txtLeadTime.Size = new System.Drawing.Size(120, 20);
            this.txtLeadTime.TabIndex = 23;
            // 
            // txtCreateBy
            // 
            this.txtCreateBy.Location = new System.Drawing.Point(83, 252);
            this.txtCreateBy.Name = "txtCreateBy";
            this.txtCreateBy.ReadOnly = true;
            this.txtCreateBy.Size = new System.Drawing.Size(120, 20);
            this.txtCreateBy.TabIndex = 22;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(224, 97);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(59, 13);
            this.label15.TabIndex = 22;
            this.label15.Text = "BOM UOM";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(7, 201);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(32, 13);
            this.label14.TabIndex = 21;
            this.label14.Text = "MOQ";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(7, 175);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(58, 13);
            this.label13.TabIndex = 20;
            this.label13.Text = "WorkShop";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(7, 149);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(57, 13);
            this.label12.TabIndex = 19;
            this.label12.Text = "Make/Buy";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(7, 123);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(56, 13);
            this.label11.TabIndex = 18;
            this.label11.Text = "ERP Type";
            // 
            // txtLossrate
            // 
            this.txtLossrate.Location = new System.Drawing.Point(291, 201);
            this.txtLossrate.Name = "txtLossrate";
            this.txtLossrate.ReadOnly = true;
            this.txtLossrate.Size = new System.Drawing.Size(120, 20);
            this.txtLossrate.TabIndex = 17;
            // 
            // txtlabor
            // 
            this.txtlabor.Location = new System.Drawing.Point(291, 175);
            this.txtlabor.Name = "txtlabor";
            this.txtlabor.ReadOnly = true;
            this.txtlabor.Size = new System.Drawing.Size(120, 20);
            this.txtlabor.TabIndex = 16;
            // 
            // txtweight
            // 
            this.txtweight.Location = new System.Drawing.Point(291, 149);
            this.txtweight.Name = "txtweight";
            this.txtweight.ReadOnly = true;
            this.txtweight.Size = new System.Drawing.Size(120, 20);
            this.txtweight.TabIndex = 15;
            // 
            // txtQty
            // 
            this.txtQty.Location = new System.Drawing.Point(291, 123);
            this.txtQty.Name = "txtQty";
            this.txtQty.Size = new System.Drawing.Size(120, 20);
            this.txtQty.TabIndex = 14;
            // 
            // BOM_pictureBox
            // 
            this.BOM_pictureBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BOM_pictureBox.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.BOM_pictureBox.Location = new System.Drawing.Point(428, 19);
            this.BOM_pictureBox.Name = "BOM_pictureBox";
            this.BOM_pictureBox.Size = new System.Drawing.Size(346, 330);
            this.BOM_pictureBox.TabIndex = 13;
            this.BOM_pictureBox.TabStop = false;
            this.BOM_pictureBox.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // txtMOQ
            // 
            this.txtMOQ.Location = new System.Drawing.Point(83, 201);
            this.txtMOQ.Name = "txtMOQ";
            this.txtMOQ.ReadOnly = true;
            this.txtMOQ.Size = new System.Drawing.Size(120, 20);
            this.txtMOQ.TabIndex = 12;
            // 
            // txtWorkShop
            // 
            this.txtWorkShop.Location = new System.Drawing.Point(83, 175);
            this.txtWorkShop.Name = "txtWorkShop";
            this.txtWorkShop.ReadOnly = true;
            this.txtWorkShop.Size = new System.Drawing.Size(120, 20);
            this.txtWorkShop.TabIndex = 11;
            // 
            // txtMakeBuy
            // 
            this.txtMakeBuy.Location = new System.Drawing.Point(83, 149);
            this.txtMakeBuy.Name = "txtMakeBuy";
            this.txtMakeBuy.ReadOnly = true;
            this.txtMakeBuy.Size = new System.Drawing.Size(120, 20);
            this.txtMakeBuy.TabIndex = 10;
            // 
            // txtErpType
            // 
            this.txtErpType.Location = new System.Drawing.Point(83, 123);
            this.txtErpType.Name = "txtErpType";
            this.txtErpType.ReadOnly = true;
            this.txtErpType.Size = new System.Drawing.Size(120, 20);
            this.txtErpType.TabIndex = 9;
            // 
            // txtUom
            // 
            this.txtUom.Location = new System.Drawing.Point(291, 97);
            this.txtUom.Name = "txtUom";
            this.txtUom.ReadOnly = true;
            this.txtUom.Size = new System.Drawing.Size(120, 20);
            this.txtUom.TabIndex = 8;
            // 
            // txtClass
            // 
            this.txtClass.Location = new System.Drawing.Point(332, 19);
            this.txtClass.Name = "txtClass";
            this.txtClass.ReadOnly = true;
            this.txtClass.Size = new System.Drawing.Size(78, 20);
            this.txtClass.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 97);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Materials Type";
            // 
            // txtMatType
            // 
            this.txtMatType.Location = new System.Drawing.Point(83, 97);
            this.txtMatType.Name = "txtMatType";
            this.txtMatType.ReadOnly = true;
            this.txtMatType.Size = new System.Drawing.Size(120, 20);
            this.txtMatType.TabIndex = 5;
            // 
            // chk_enable
            // 
            this.chk_enable.AutoSize = true;
            this.chk_enable.Location = new System.Drawing.Point(264, 21);
            this.chk_enable.Name = "chk_enable";
            this.chk_enable.Size = new System.Drawing.Size(61, 17);
            this.chk_enable.TabIndex = 4;
            this.chk_enable.Text = "Disable";
            this.chk_enable.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Name";
            // 
            // Partnumber
            // 
            this.Partnumber.AutoSize = true;
            this.Partnumber.Location = new System.Drawing.Point(6, 19);
            this.Partnumber.Name = "Partnumber";
            this.Partnumber.Size = new System.Drawing.Size(66, 13);
            this.Partnumber.TabIndex = 2;
            this.Partnumber.Text = "Part Number";
            // 
            // txtPartname
            // 
            this.txtPartname.Location = new System.Drawing.Point(83, 45);
            this.txtPartname.Name = "txtPartname";
            this.txtPartname.ReadOnly = true;
            this.txtPartname.Size = new System.Drawing.Size(327, 46);
            this.txtPartname.TabIndex = 1;
            this.txtPartname.Text = "";
            // 
            // txtpartno
            // 
            this.txtpartno.Location = new System.Drawing.Point(83, 19);
            this.txtpartno.Name = "txtpartno";
            this.txtpartno.ReadOnly = true;
            this.txtpartno.Size = new System.Drawing.Size(158, 20);
            this.txtpartno.TabIndex = 0;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bom_add,
            this.bom_delete});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(108, 48);
            // 
            // bom_add
            // 
            this.bom_add.Name = "bom_add";
            this.bom_add.Size = new System.Drawing.Size(107, 22);
            this.bom_add.Text = "Add";
            this.bom_add.Click += new System.EventHandler(this.bom_add_Click);
            // 
            // bom_delete
            // 
            this.bom_delete.Name = "bom_delete";
            this.bom_delete.Size = new System.Drawing.Size(107, 22);
            this.bom_delete.Text = "Delete";
            // 
            // ctr_enginerrmenu1
            // 
            this.ctr_enginerrmenu1.Dock = System.Windows.Forms.DockStyle.Top;
            this.ctr_enginerrmenu1.Location = new System.Drawing.Point(0, 0);
            this.ctr_enginerrmenu1.Name = "ctr_enginerrmenu1";
            this.ctr_enginerrmenu1.Size = new System.Drawing.Size(995, 26);
            this.ctr_enginerrmenu1.TabIndex = 0;
            // 
            // frmBOM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(995, 578);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.ctr_enginerrmenu1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmBOM";
            this.Text = "BILL OF MATERIALS";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Activated += new System.EventHandler(this.frmBOM_Activated_1);
            this.Load += new System.EventHandler(this.frmBOM_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.frmBOM_Paint);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BOM_pictureBox)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private ctr_enginerrmenu ctr_enginerrmenu1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtpartno;
        private System.Windows.Forms.RichTextBox txtPartname;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label Partnumber;
        private System.Windows.Forms.CheckBox chk_enable;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtMatType;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBom;
        private System.Windows.Forms.Button btn_searchbom;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RichTextBox txtbomname;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtbomUpdateby;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtbomCreateDate;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtbomCreateby;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtbomType;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtbomRemark;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtbomUpdatedate;
        private System.Windows.Forms.TextBox txtClass;
        private System.Windows.Forms.TextBox txtMOQ;
        private System.Windows.Forms.TextBox txtWorkShop;
        private System.Windows.Forms.TextBox txtMakeBuy;
        private System.Windows.Forms.TextBox txtErpType;
        private System.Windows.Forms.TextBox txtUom;
        private System.Windows.Forms.PictureBox BOM_pictureBox;
        private System.Windows.Forms.TextBox txtLossrate;
        private System.Windows.Forms.TextBox txtlabor;
        private System.Windows.Forms.TextBox txtweight;
        private System.Windows.Forms.TextBox txtQty;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox txtLeadTime;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.TextBox txtUpdateDate;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.TextBox txtUpateBy;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.TextBox txtCreateDate;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.TextBox txtCreateBy;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem bom_add;
        private System.Windows.Forms.ToolStripMenuItem bom_delete;
    }
}