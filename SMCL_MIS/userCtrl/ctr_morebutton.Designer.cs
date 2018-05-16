namespace SMCL_MIS
{
    partial class ctr_morebutton
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.cbAction = new System.Windows.Forms.ComboBox();
            this.btn_Go = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cbAction
            // 
            this.cbAction.FormattingEnabled = true;
            this.cbAction.Location = new System.Drawing.Point(0, 0);
            this.cbAction.Name = "cbAction";
            this.cbAction.Size = new System.Drawing.Size(106, 21);
            this.cbAction.TabIndex = 0;
            // 
            // btn_Go
            // 
            this.btn_Go.Location = new System.Drawing.Point(112, -1);
            this.btn_Go.Name = "btn_Go";
            this.btn_Go.Size = new System.Drawing.Size(41, 23);
            this.btn_Go.TabIndex = 1;
            this.btn_Go.Text = "Go";
            this.btn_Go.UseVisualStyleBackColor = true;
            this.btn_Go.Click += new System.EventHandler(this.btn_Go_Click);
            // 
            // ctr_morebutton
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btn_Go);
            this.Controls.Add(this.cbAction);
            this.Name = "ctr_morebutton";
            this.Size = new System.Drawing.Size(153, 23);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cbAction;
        private System.Windows.Forms.Button btn_Go;
    }
}
