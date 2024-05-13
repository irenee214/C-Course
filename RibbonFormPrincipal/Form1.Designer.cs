namespace RibbonFormPrincipal
{
    partial class ribbonForm
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ribbonForm));
            ribbonControl1 = new DevExpress.XtraBars.Ribbon.RibbonControl();
            applicationMenu1 = new DevExpress.XtraBars.Ribbon.ApplicationMenu(components);
            barButtonItemCerrarApp = new DevExpress.XtraBars.BarButtonItem();
            barButtonItemAyuda = new DevExpress.XtraBars.BarButtonItem();
            barButtonItemAgregarEmpleado = new DevExpress.XtraBars.BarButtonItem();
            ribbonGalleryBarItem1 = new DevExpress.XtraBars.RibbonGalleryBarItem();
            barEditItem1 = new DevExpress.XtraBars.BarEditItem();
            repositoryItemImageEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemImageEdit();
            ribbonPageEmpleados = new DevExpress.XtraBars.Ribbon.RibbonPage();
            ribbonPageGroupListadoEmpleados = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            RibbonPageClientes = new DevExpress.XtraBars.Ribbon.RibbonPage();
            ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            ((System.ComponentModel.ISupportInitialize)ribbonControl1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)applicationMenu1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)repositoryItemImageEdit1).BeginInit();
            SuspendLayout();
            // 
            // ribbonControl1
            // 
            ribbonControl1.ApplicationButtonDropDownControl = applicationMenu1;
            ribbonControl1.ExpandCollapseItem.Id = 0;
            ribbonControl1.Items.AddRange(new DevExpress.XtraBars.BarItem[] { ribbonControl1.ExpandCollapseItem, barButtonItemAgregarEmpleado, ribbonGalleryBarItem1, barEditItem1, barButtonItemCerrarApp, barButtonItemAyuda });
            ribbonControl1.Location = new System.Drawing.Point(0, 0);
            ribbonControl1.MaxItemId = 7;
            ribbonControl1.Name = "ribbonControl1";
            ribbonControl1.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] { ribbonPageEmpleados, RibbonPageClientes });
            ribbonControl1.QuickToolbarItemLinks.Add(barButtonItemCerrarApp);
            ribbonControl1.QuickToolbarItemLinks.Add(barButtonItemAyuda);
            ribbonControl1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] { repositoryItemImageEdit1 });
            ribbonControl1.Size = new System.Drawing.Size(1188, 177);
            // 
            // applicationMenu1
            // 
            applicationMenu1.ItemLinks.Add(barButtonItemCerrarApp);
            applicationMenu1.ItemLinks.Add(barButtonItemAyuda);
            applicationMenu1.Name = "applicationMenu1";
            applicationMenu1.Ribbon = ribbonControl1;
            // 
            // barButtonItemCerrarApp
            // 
            barButtonItemCerrarApp.Caption = "Cerrar Aplicacion";
            barButtonItemCerrarApp.Id = 5;
            barButtonItemCerrarApp.ImageOptions.Image = (System.Drawing.Image)resources.GetObject("barButtonItemCerrarApp.ImageOptions.Image");
            barButtonItemCerrarApp.ImageOptions.LargeImage = (System.Drawing.Image)resources.GetObject("barButtonItemCerrarApp.ImageOptions.LargeImage");
            barButtonItemCerrarApp.Name = "barButtonItemCerrarApp";
            barButtonItemCerrarApp.ItemClick += barButtonItemCerrarApp_ItemClick;
            // 
            // barButtonItemAyuda
            // 
            barButtonItemAyuda.Caption = "AYUDA";
            barButtonItemAyuda.Id = 6;
            barButtonItemAyuda.ImageOptions.Image = (System.Drawing.Image)resources.GetObject("barButtonItemAyuda.ImageOptions.Image");
            barButtonItemAyuda.ImageOptions.LargeImage = (System.Drawing.Image)resources.GetObject("barButtonItemAyuda.ImageOptions.LargeImage");
            barButtonItemAyuda.Name = "barButtonItemAyuda";
            // 
            // barButtonItemAgregarEmpleado
            // 
            barButtonItemAgregarEmpleado.Caption = "Registrar";
            barButtonItemAgregarEmpleado.Id = 2;
            barButtonItemAgregarEmpleado.ImageOptions.Image = (System.Drawing.Image)resources.GetObject("barButtonItemAgregarEmpleado.ImageOptions.Image");
            barButtonItemAgregarEmpleado.ImageOptions.LargeImage = (System.Drawing.Image)resources.GetObject("barButtonItemAgregarEmpleado.ImageOptions.LargeImage");
            barButtonItemAgregarEmpleado.Name = "barButtonItemAgregarEmpleado";
            barButtonItemAgregarEmpleado.ItemClick += barButtonItemAgregarEmpleado_ItemClick;
            // 
            // ribbonGalleryBarItem1
            // 
            ribbonGalleryBarItem1.Caption = "ribbonGalleryBarItem1";
            ribbonGalleryBarItem1.Id = 3;
            ribbonGalleryBarItem1.Name = "ribbonGalleryBarItem1";
            // 
            // barEditItem1
            // 
            barEditItem1.Caption = "barEditItem1";
            barEditItem1.Edit = repositoryItemImageEdit1;
            barEditItem1.Id = 4;
            barEditItem1.Name = "barEditItem1";
            // 
            // repositoryItemImageEdit1
            // 
            repositoryItemImageEdit1.AutoHeight = false;
            repositoryItemImageEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
            repositoryItemImageEdit1.Name = "repositoryItemImageEdit1";
            // 
            // ribbonPageEmpleados
            // 
            ribbonPageEmpleados.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] { ribbonPageGroupListadoEmpleados });
            ribbonPageEmpleados.ImageOptions.Image = (System.Drawing.Image)resources.GetObject("ribbonPageEmpleados.ImageOptions.Image");
            ribbonPageEmpleados.Name = "ribbonPageEmpleados";
            ribbonPageEmpleados.Text = "Empleados";
            // 
            // ribbonPageGroupListadoEmpleados
            // 
            ribbonPageGroupListadoEmpleados.ItemLinks.Add(barButtonItemAgregarEmpleado);
            ribbonPageGroupListadoEmpleados.Name = "ribbonPageGroupListadoEmpleados";
            ribbonPageGroupListadoEmpleados.Text = "Empleado";
            // 
            // RibbonPageClientes
            // 
            RibbonPageClientes.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] { ribbonPageGroup1 });
            RibbonPageClientes.ImageOptions.Image = (System.Drawing.Image)resources.GetObject("RibbonPageClientes.ImageOptions.Image");
            RibbonPageClientes.Name = "RibbonPageClientes";
            RibbonPageClientes.Text = "Clientes";
            // 
            // ribbonPageGroup1
            // 
            ribbonPageGroup1.Name = "ribbonPageGroup1";
            ribbonPageGroup1.Text = "ribbonPageGroup1";
            // 
            // ribbonForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(1188, 627);
            Controls.Add(ribbonControl1);
            IsMdiContainer = true;
            Name = "ribbonForm";
            Ribbon = ribbonControl1;
            Text = "Punto de Venta SISTEIN";
            WindowState = System.Windows.Forms.FormWindowState.Maximized;
            Load += ribbonForm_Load;
            ((System.ComponentModel.ISupportInitialize)ribbonControl1).EndInit();
            ((System.ComponentModel.ISupportInitialize)applicationMenu1).EndInit();
            ((System.ComponentModel.ISupportInitialize)repositoryItemImageEdit1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl1;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPageEmpleados;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroupListadoEmpleados;
        private DevExpress.XtraBars.BarButtonItem barButtonItemAgregarEmpleado;
        private DevExpress.XtraBars.Ribbon.RibbonPage RibbonPageClientes;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.RibbonGalleryBarItem ribbonGalleryBarItem1;
        private DevExpress.XtraBars.BarEditItem barEditItem1;
        private DevExpress.XtraEditors.Repository.RepositoryItemImageEdit repositoryItemImageEdit1;
        private DevExpress.XtraBars.BarButtonItem barButtonItemCerrarApp;
        private DevExpress.XtraBars.BarButtonItem barButtonItemAyuda;
        private DevExpress.XtraBars.Ribbon.ApplicationMenu applicationMenu1;
    }
}

