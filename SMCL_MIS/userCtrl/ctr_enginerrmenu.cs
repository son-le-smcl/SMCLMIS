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
    public partial class ctr_enginerrmenu : UserControl
    {
        Igni i = new Igni();
        public ctr_enginerrmenu()
        {
            InitializeComponent();
            Extensions.check_per_menu(menuStrip1); 
        } 
        private void button1_Click(object sender, EventArgs e)
        {
            ((Form)this.Parent).Close();
        } 

        //private void frmBOM_Click(object sender, EventArgs e)
        //{
        //    frmBOM f = new frmBOM();
        //    (Application.OpenForms["Main"] as Main).openform(f);
        //}

        //private void frmMaterials_Click(object sender, EventArgs e)
        //{
        //    frmMaterials f = new frmMaterials();
        //    (Application.OpenForms["Main"] as Main).openform(f);
        //}

        //private void frmImportMaterials_Click(object sender, EventArgs e)
        //{
        //    string formToCall = "frmImportMaterials";
        //    var type = Type.GetType("SMCL_MIS." + formToCall);
        //    var form = Activator.CreateInstance(type) as Form; 
        //    (Application.OpenForms["Main"] as Main).openform(form);
        //}
    }
}
