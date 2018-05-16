namespace SMCL_MIS { 
    partial class frmUsersettup
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button3 = new System.Windows.Forms.Button();
            this.cbDept = new System.Windows.Forms.ComboBox();
            this.txtfullname = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtrepwd = new System.Windows.Forms.TextBox();
            this.txtpwd = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.DG_userright = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.radio_manager = new System.Windows.Forms.RadioButton();
            this.radio_crud = new System.Windows.Forms.RadioButton();
            this.radio_readonly = new System.Windows.Forms.RadioButton();
            this.radio_none = new System.Windows.Forms.RadioButton();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.cb_module = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_delete = new System.Windows.Forms.Button();
            this.crt_Settingsmenu1 = new SMCL_MIS.crt_Settingsmenu();
            this.txtuserid = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.useridCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.frmCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.readCol = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.createCol = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.updateCol = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.deleteCol = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.approveCol = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DG_userright)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button3);
            this.groupBox1.Controls.Add(this.cbDept);
            this.groupBox1.Controls.Add(this.txtfullname);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(12, 64);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(278, 115);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "User Info";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(148, 82);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 10;
            this.button3.Text = "Search";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // cbDept
            // 
            this.cbDept.FormattingEnabled = true;
            this.cbDept.Location = new System.Drawing.Point(94, 54);
            this.cbDept.Name = "cbDept";
            this.cbDept.Size = new System.Drawing.Size(129, 21);
            this.cbDept.TabIndex = 6;
            // 
            // txtfullname
            // 
            this.txtfullname.Location = new System.Drawing.Point(94, 28);
            this.txtfullname.Name = "txtfullname";
            this.txtfullname.Size = new System.Drawing.Size(130, 20);
            this.txtfullname.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 57);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Department";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Full name";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtrepwd);
            this.groupBox2.Controls.Add(this.txtpwd);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Location = new System.Drawing.Point(12, 185);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(278, 96);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Password";
            // 
            // txtrepwd
            // 
            this.txtrepwd.Location = new System.Drawing.Point(94, 49);
            this.txtrepwd.Name = "txtrepwd";
            this.txtrepwd.Size = new System.Drawing.Size(130, 20);
            this.txtrepwd.TabIndex = 9;
            this.txtrepwd.UseSystemPasswordChar = true;
            // 
            // txtpwd
            // 
            this.txtpwd.Location = new System.Drawing.Point(94, 23);
            this.txtpwd.Name = "txtpwd";
            this.txtpwd.Size = new System.Drawing.Size(130, 20);
            this.txtpwd.TabIndex = 8;
            this.txtpwd.UseSystemPasswordChar = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 53);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "Repeat";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 30);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 13);
            this.label6.TabIndex = 2;
            this.label6.Text = "Password";
            // 
            // DG_userright
            // 
            this.DG_userright.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DG_userright.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DG_userright.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.useridCol,
            this.frmCol,
            this.Description,
            this.readCol,
            this.createCol,
            this.updateCol,
            this.deleteCol,
            this.approveCol});
            this.DG_userright.Location = new System.Drawing.Point(296, 43);
            this.DG_userright.Name = "DG_userright";
            this.DG_userright.Size = new System.Drawing.Size(492, 342);
            this.DG_userright.TabIndex = 6;
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button1.Location = new System.Drawing.Point(12, 415);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 7;
            this.button1.Text = "Save";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button2.Location = new System.Drawing.Point(93, 415);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 8;
            this.button2.Text = "Reset";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.radio_manager);
            this.groupBox3.Controls.Add(this.radio_crud);
            this.groupBox3.Controls.Add(this.radio_readonly);
            this.groupBox3.Controls.Add(this.radio_none);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.textBox1);
            this.groupBox3.Controls.Add(this.cb_module);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Location = new System.Drawing.Point(12, 287);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(278, 122);
            this.groupBox3.TabIndex = 9;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Function";
            // 
            // radio_manager
            // 
            this.radio_manager.AutoSize = true;
            this.radio_manager.Location = new System.Drawing.Point(204, 90);
            this.radio_manager.Name = "radio_manager";
            this.radio_manager.Size = new System.Drawing.Size(67, 17);
            this.radio_manager.TabIndex = 15;
            this.radio_manager.TabStop = true;
            this.radio_manager.Text = "Manager";
            this.radio_manager.UseVisualStyleBackColor = true;
            this.radio_manager.CheckedChanged += new System.EventHandler(this.radioButtons_CheckedChanged);
            // 
            // radio_crud
            // 
            this.radio_crud.AutoSize = true;
            this.radio_crud.Location = new System.Drawing.Point(142, 90);
            this.radio_crud.Name = "radio_crud";
            this.radio_crud.Size = new System.Drawing.Size(56, 17);
            this.radio_crud.TabIndex = 14;
            this.radio_crud.TabStop = true;
            this.radio_crud.Text = "CRUD";
            this.radio_crud.UseVisualStyleBackColor = true;
            this.radio_crud.CheckedChanged += new System.EventHandler(this.radioButtons_CheckedChanged);
            // 
            // radio_readonly
            // 
            this.radio_readonly.AutoSize = true;
            this.radio_readonly.Location = new System.Drawing.Point(66, 90);
            this.radio_readonly.Name = "radio_readonly";
            this.radio_readonly.Size = new System.Drawing.Size(70, 17);
            this.radio_readonly.TabIndex = 13;
            this.radio_readonly.TabStop = true;
            this.radio_readonly.Text = "Readonly";
            this.radio_readonly.UseVisualStyleBackColor = true;
            this.radio_readonly.CheckedChanged += new System.EventHandler(this.radioButtons_CheckedChanged);
            // 
            // radio_none
            // 
            this.radio_none.AutoSize = true;
            this.radio_none.Location = new System.Drawing.Point(9, 90);
            this.radio_none.Name = "radio_none";
            this.radio_none.Size = new System.Drawing.Size(51, 17);
            this.radio_none.TabIndex = 12;
            this.radio_none.TabStop = true;
            this.radio_none.Text = "None";
            this.radio_none.UseVisualStyleBackColor = true;
            this.radio_none.CheckedChanged += new System.EventHandler(this.radioButtons_CheckedChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(8, 54);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(60, 13);
            this.label7.TabIndex = 10;
            this.label7.Text = "Description";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(94, 51);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(129, 20);
            this.textBox1.TabIndex = 10;
            // 
            // cb_module
            // 
            this.cb_module.FormattingEnabled = true;
            this.cb_module.Location = new System.Drawing.Point(94, 24);
            this.cb_module.Name = "cb_module";
            this.cb_module.Size = new System.Drawing.Size(129, 21);
            this.cb_module.TabIndex = 11;
            this.cb_module.TextChanged += new System.EventHandler(this.cb_module_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 27);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Select Fuction";
            // 
            // btn_delete
            // 
            this.btn_delete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_delete.Location = new System.Drawing.Point(174, 415);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(75, 23);
            this.btn_delete.TabIndex = 10;
            this.btn_delete.Text = "Delete";
            this.btn_delete.UseVisualStyleBackColor = true;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // crt_Settingsmenu1
            // 
            this.crt_Settingsmenu1.Dock = System.Windows.Forms.DockStyle.Top;
            this.crt_Settingsmenu1.Location = new System.Drawing.Point(0, 0);
            this.crt_Settingsmenu1.Name = "crt_Settingsmenu1";
            this.crt_Settingsmenu1.Size = new System.Drawing.Size(800, 23);
            this.crt_Settingsmenu1.TabIndex = 12;
            // 
            // txtuserid
            // 
            this.txtuserid.Location = new System.Drawing.Point(106, 38);
            this.txtuserid.Name = "txtuserid";
            this.txtuserid.Size = new System.Drawing.Size(130, 20);
            this.txtuserid.TabIndex = 14;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "Userid";
            // 
            // useridCol
            // 
            this.useridCol.HeaderText = "User ID";
            this.useridCol.Name = "useridCol";
            // 
            // frmCol
            // 
            this.frmCol.HeaderText = "Form";
            this.frmCol.Name = "frmCol";
            // 
            // Description
            // 
            this.Description.HeaderText = "Description";
            this.Description.Name = "Description";
            this.Description.ReadOnly = true;
            // 
            // readCol
            // 
            this.readCol.HeaderText = "READ";
            this.readCol.Name = "readCol";
            this.readCol.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.readCol.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // createCol
            // 
            this.createCol.HeaderText = "Create";
            this.createCol.Name = "createCol";
            this.createCol.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.createCol.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // updateCol
            // 
            this.updateCol.HeaderText = "Update";
            this.updateCol.Name = "updateCol";
            this.updateCol.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.updateCol.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // deleteCol
            // 
            this.deleteCol.HeaderText = "Delete";
            this.deleteCol.Name = "deleteCol";
            this.deleteCol.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.deleteCol.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // approveCol
            // 
            this.approveCol.HeaderText = "Approve";
            this.approveCol.Name = "approveCol";
            this.approveCol.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.approveCol.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // frmUsersettup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtuserid);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.crt_Settingsmenu1);
            this.Controls.Add(this.btn_delete);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.DG_userright);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmUsersettup";
            this.Text = "frmUsersettup";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmUsersettup_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DG_userright)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
         
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtfullname;
        private System.Windows.Forms.TextBox txtrepwd;
        private System.Windows.Forms.TextBox txtpwd;
        private System.Windows.Forms.ComboBox cbDept;
        private System.Windows.Forms.DataGridView DG_userright;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ComboBox cb_module;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.RadioButton radio_crud;
        private System.Windows.Forms.RadioButton radio_readonly;
        private System.Windows.Forms.RadioButton radio_none;
        private System.Windows.Forms.RadioButton radio_manager;
        private System.Windows.Forms.Button btn_delete; 
        private crt_Settingsmenu crt_Settingsmenu1;
        private System.Windows.Forms.TextBox txtuserid;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn useridCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn frmCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn Description;
        private System.Windows.Forms.DataGridViewCheckBoxColumn readCol;
        private System.Windows.Forms.DataGridViewCheckBoxColumn createCol;
        private System.Windows.Forms.DataGridViewCheckBoxColumn updateCol;
        private System.Windows.Forms.DataGridViewCheckBoxColumn deleteCol;
        private System.Windows.Forms.DataGridViewCheckBoxColumn approveCol;
    }
}