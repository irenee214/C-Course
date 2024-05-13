namespace PruebaProyecto
{
    partial class Form1
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
            this.dataLayoutControl1 = new DevExpress.XtraDataLayout.DataLayoutControl();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.pRUEBA_PROYECTODataSet = new PruebaProyecto.PRUEBA_PROYECTODataSet();
            this.pALETSBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pALETSTableAdapter = new PruebaProyecto.PRUEBA_PROYECTODataSetTableAdapters.PALETSTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataLayoutControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pRUEBA_PROYECTODataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pALETSBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataLayoutControl1
            // 
            this.dataLayoutControl1.DataSource = this.pALETSBindingSource;
            this.dataLayoutControl1.Location = new System.Drawing.Point(2, 0);
            this.dataLayoutControl1.Name = "dataLayoutControl1";
            this.dataLayoutControl1.Root = this.Root;
            this.dataLayoutControl1.Size = new System.Drawing.Size(802, 457);
            this.dataLayoutControl1.TabIndex = 0;
            this.dataLayoutControl1.Text = "dataLayoutControl1";
            // 
            // Root
            // 
            this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.Root.GroupBordersVisible = false;
            this.Root.Name = "Root";
            this.Root.Size = new System.Drawing.Size(802, 457);
            this.Root.TextVisible = false;
            // 
            // pRUEBA_PROYECTODataSet
            // 
            this.pRUEBA_PROYECTODataSet.DataSetName = "PRUEBA_PROYECTODataSet";
            this.pRUEBA_PROYECTODataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // pALETSBindingSource
            // 
            this.pALETSBindingSource.DataMember = "PALETS";
            this.pALETSBindingSource.DataSource = this.pRUEBA_PROYECTODataSet;
            // 
            // pALETSTableAdapter
            // 
            this.pALETSTableAdapter.ClearBeforeFill = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataLayoutControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataLayoutControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pRUEBA_PROYECTODataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pALETSBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DataLayoutControl dataLayoutControl1;
        private LayoutControlGroup Root;
        private PRUEBA_PROYECTODataSet pRUEBA_PROYECTODataSet;
        private System.Windows.Forms.BindingSource pALETSBindingSource;
        private PRUEBA_PROYECTODataSetTableAdapters.PALETSTableAdapter pALETSTableAdapter;
    }
}