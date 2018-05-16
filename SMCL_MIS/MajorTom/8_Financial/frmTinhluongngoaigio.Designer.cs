namespace SMCL_MIS
{
    partial class frmTinhluongngoaigio
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
            this.ctr_Fimenu1 = new SMCL_MIS.userCtrl.ctr_Fimenu();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // ctr_Fimenu1
            // 
            this.ctr_Fimenu1.Dock = System.Windows.Forms.DockStyle.Top;
            this.ctr_Fimenu1.Location = new System.Drawing.Point(0, 0);
            this.ctr_Fimenu1.Name = "ctr_Fimenu1";
            this.ctr_Fimenu1.Size = new System.Drawing.Size(800, 24);
            this.ctr_Fimenu1.TabIndex = 0;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "yyyy-MM";
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(80, 30);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(76, 20);
            this.dateTimePicker1.TabIndex = 1;
            // 
            // frmTinhluongngoaigio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.ctr_Fimenu1);
            this.Name = "frmTinhluongngoaigio";
            this.Text = "frmTinhluongngoaigio";
            this.ResumeLayout(false);

        }

        #endregion

        private userCtrl.ctr_Fimenu ctr_Fimenu1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
    }
}