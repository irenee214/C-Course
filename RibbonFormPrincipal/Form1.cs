using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace RibbonFormPrincipal
{
    public partial class ribbonForm : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public ribbonForm()
        {
            InitializeComponent();
        }

        private void ribbonForm_Load(object sender, EventArgs e)
        {

        }

        private void barButtonItemAgregarEmpleado_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmEmpleado empleado = new frmEmpleado();
            empleado.MdiParent = this;
            empleado.Show();
        }

        private void barButtonItemCerrarApp_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Application.Exit();
        }
    }
}
