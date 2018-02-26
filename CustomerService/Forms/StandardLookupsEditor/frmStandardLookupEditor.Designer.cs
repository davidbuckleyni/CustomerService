namespace CustomerService.Forms.StandardLookupsEditor
{
    partial class frmStandardLookupEditor
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
            Telerik.WinControls.UI.GridViewDecimalColumn gridViewDecimalColumn1 = new Telerik.WinControls.UI.GridViewDecimalColumn();
            Telerik.WinControls.UI.GridViewDecimalColumn gridViewDecimalColumn2 = new Telerik.WinControls.UI.GridViewDecimalColumn();
            Telerik.WinControls.UI.GridViewDecimalColumn gridViewDecimalColumn3 = new Telerik.WinControls.UI.GridViewDecimalColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn1 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn2 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.TableViewDefinition tableViewDefinition1 = new Telerik.WinControls.UI.TableViewDefinition();
            this.bntEditLookup = new Telerik.WinControls.UI.RadButton();
            this.btnAddLookup = new Telerik.WinControls.UI.RadButton();
            this.grdLookups = new Telerik.WinControls.UI.RadGridView();
            this.customerDbDataSet10 = new CustomerService.customerDbDataSet10();
            this.standardLookupsBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.standardLookupsTableAdapter = new CustomerService.customerDbDataSet10TableAdapters.StandardLookupsTableAdapter();
            this.standardLookupsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.customerDbDataSet11 = new CustomerService.customerDbDataSet11();
            this.standardLookupsBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.standardLookupsTableAdapter1 = new CustomerService.customerDbDataSet11TableAdapters.StandardLookupsTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.bntEditLookup)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnAddLookup)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdLookups)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdLookups.MasterTemplate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerDbDataSet10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.standardLookupsBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.standardLookupsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerDbDataSet11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.standardLookupsBindingSource2)).BeginInit();
            this.SuspendLayout();
            // 
            // bntEditLookup
            // 
            this.bntEditLookup.Location = new System.Drawing.Point(128, 219);
            this.bntEditLookup.Name = "bntEditLookup";
            this.bntEditLookup.Size = new System.Drawing.Size(110, 24);
            this.bntEditLookup.TabIndex = 5;
            this.bntEditLookup.Text = "Edit Lookup Option";
            this.bntEditLookup.Click += new System.EventHandler(this.bntEditLookup_Click);
            // 
            // btnAddLookup
            // 
            this.btnAddLookup.Location = new System.Drawing.Point(12, 219);
            this.btnAddLookup.Name = "btnAddLookup";
            this.btnAddLookup.Size = new System.Drawing.Size(110, 24);
            this.btnAddLookup.TabIndex = 4;
            this.btnAddLookup.Text = "Add Lookup Option";
            this.btnAddLookup.Click += new System.EventHandler(this.btnAddLookup_Click);
            // 
            // grdLookups
            // 
            this.grdLookups.BackColor = System.Drawing.SystemColors.Control;
            this.grdLookups.Cursor = System.Windows.Forms.Cursors.Default;
            this.grdLookups.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.grdLookups.ForeColor = System.Drawing.SystemColors.ControlText;
            this.grdLookups.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.grdLookups.Location = new System.Drawing.Point(12, 12);
            // 
            // 
            // 
            this.grdLookups.MasterTemplate.AllowAddNewRow = false;
            this.grdLookups.MasterTemplate.AllowColumnChooser = false;
            this.grdLookups.MasterTemplate.AllowDragToGroup = false;
            this.grdLookups.MasterTemplate.AllowRowResize = false;
            gridViewDecimalColumn1.DataType = typeof(int);
            gridViewDecimalColumn1.EnableExpressionEditor = false;
            gridViewDecimalColumn1.FieldName = "id";
            gridViewDecimalColumn1.HeaderText = "id";
            gridViewDecimalColumn1.IsAutoGenerated = true;
            gridViewDecimalColumn1.Name = "id";
            gridViewDecimalColumn1.ReadOnly = true;
            gridViewDecimalColumn2.DataType = typeof(string);
            gridViewDecimalColumn2.EnableExpressionEditor = false;
            gridViewDecimalColumn2.FieldName = "Code";
            gridViewDecimalColumn2.HeaderText = "Code";
            gridViewDecimalColumn2.IsAutoGenerated = true;
            gridViewDecimalColumn2.IsVisible = false;
            gridViewDecimalColumn2.Name = "Code";
            gridViewDecimalColumn2.Width = 226;
            gridViewDecimalColumn3.DataType = typeof(int);
            gridViewDecimalColumn3.EnableExpressionEditor = false;
            gridViewDecimalColumn3.FieldName = "lookupgroup";
            gridViewDecimalColumn3.HeaderText = "lookupgroup";
            gridViewDecimalColumn3.IsAutoGenerated = true;
            gridViewDecimalColumn3.IsVisible = false;
            gridViewDecimalColumn3.Name = "lookupgroup";
            gridViewTextBoxColumn1.EnableExpressionEditor = false;
            gridViewTextBoxColumn1.FieldName = "Description";
            gridViewTextBoxColumn1.HeaderText = "Code";
            gridViewTextBoxColumn1.IsAutoGenerated = true;
            gridViewTextBoxColumn1.Name = "Description";
            gridViewTextBoxColumn1.Width = 132;
            gridViewTextBoxColumn2.EnableExpressionEditor = false;
            gridViewTextBoxColumn2.FieldName = "lookupdescription";
            gridViewTextBoxColumn2.HeaderText = "Description";
            gridViewTextBoxColumn2.IsAutoGenerated = true;
            gridViewTextBoxColumn2.Name = "lookupdescription";
            gridViewTextBoxColumn2.Width = 435;
            this.grdLookups.MasterTemplate.Columns.AddRange(new Telerik.WinControls.UI.GridViewDataColumn[] {
            gridViewDecimalColumn1,
            gridViewDecimalColumn2,
            gridViewDecimalColumn3,
            gridViewTextBoxColumn1,
            gridViewTextBoxColumn2});
            this.grdLookups.MasterTemplate.DataSource = this.standardLookupsBindingSource2;
            this.grdLookups.MasterTemplate.EnableGrouping = false;
            this.grdLookups.MasterTemplate.EnableSorting = false;
            this.grdLookups.MasterTemplate.ViewDefinition = tableViewDefinition1;
            this.grdLookups.Name = "grdLookups";
            this.grdLookups.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.grdLookups.Size = new System.Drawing.Size(697, 201);
            this.grdLookups.TabIndex = 3;
            this.grdLookups.Text = "radGridView1";
            this.grdLookups.SelectionChanged += new System.EventHandler(this.grdLookups_SelectionChanged);
            // 
            // customerDbDataSet10
            // 
            this.customerDbDataSet10.DataSetName = "customerDbDataSet10";
            this.customerDbDataSet10.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // standardLookupsBindingSource1
            // 
            this.standardLookupsBindingSource1.DataMember = "StandardLookups";
            this.standardLookupsBindingSource1.DataSource = this.customerDbDataSet10;
            // 
            // standardLookupsTableAdapter
            // 
            this.standardLookupsTableAdapter.ClearBeforeFill = true;
            // 
            // standardLookupsBindingSource
            // 
            this.standardLookupsBindingSource.DataSource = typeof(CustomerService.Classes.StandardLookups);
            // 
            // customerDbDataSet11
            // 
            this.customerDbDataSet11.DataSetName = "customerDbDataSet11";
            this.customerDbDataSet11.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // standardLookupsBindingSource2
            // 
            this.standardLookupsBindingSource2.DataMember = "StandardLookups";
            this.standardLookupsBindingSource2.DataSource = this.customerDbDataSet11;
            // 
            // standardLookupsTableAdapter1
            // 
            this.standardLookupsTableAdapter1.ClearBeforeFill = true;
            // 
            // frmStandardLookupEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(739, 256);
            this.Controls.Add(this.bntEditLookup);
            this.Controls.Add(this.btnAddLookup);
            this.Controls.Add(this.grdLookups);
            this.MaximizeBox = false;
            this.Name = "frmStandardLookupEditor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lookup Editor";
            this.Load += new System.EventHandler(this.frmStandardLookupEditor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bntEditLookup)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnAddLookup)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdLookups.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdLookups)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerDbDataSet10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.standardLookupsBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.standardLookupsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerDbDataSet11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.standardLookupsBindingSource2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Telerik.WinControls.UI.RadButton bntEditLookup;
        private Telerik.WinControls.UI.RadButton btnAddLookup;
        private Telerik.WinControls.UI.RadGridView grdLookups;
        private System.Windows.Forms.BindingSource standardLookupsBindingSource;
        private customerDbDataSet10 customerDbDataSet10;
        private System.Windows.Forms.BindingSource standardLookupsBindingSource1;
        private customerDbDataSet10TableAdapters.StandardLookupsTableAdapter standardLookupsTableAdapter;
        private customerDbDataSet11 customerDbDataSet11;
        private System.Windows.Forms.BindingSource standardLookupsBindingSource2;
        private customerDbDataSet11TableAdapters.StandardLookupsTableAdapter standardLookupsTableAdapter1;
    }
}