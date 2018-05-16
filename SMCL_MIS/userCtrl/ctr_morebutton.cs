using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SMCL_MIS
{
    public partial class ctr_morebutton : UserControl
    {
        public ctr_morebutton()
        {

            InitializeComponent();

            cbAction.Items.Insert(0, "More");
            cbAction.Items.Insert(1, "Cancel");
            cbAction.Items.Insert(2, "Delete");
            cbAction.SelectedIndex = 0;
        }

        private void btn_Go_Click(object sender, EventArgs e)
        {
            Igni ig = new Igni();
            if (cbAction.SelectedIndex == 2)
            {
                if (ig.check_user_permission(LoginInfo.username, ((Form)this.Parent).Name, "Fdelete"))
                {
                    switch (((Form)this.Parent).Name)
                    {
                        case "frmSO":

                            (System.Windows.Forms.Application.OpenForms["frmSO"] as frmSO).delete_so();
                            break;
                        case "frmQuotation":

                            (System.Windows.Forms.Application.OpenForms["frmQuotation"] as frmQuotation).delete_quote();
                            break;
                        case "frmPO":

                            (System.Windows.Forms.Application.OpenForms["frmPO"] as frmPO).delete_po();
                            break;

                    }
                }
                else
                    MessageBox.Show("You do not Permission to delete,Please contact Aministrator!", "Permission Required!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            }
        }
    }
}
