namespace CustomerService.Forms.CustomFields
{
    partial class frmCustomFields
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
            Telerik.WinControls.UI.GridViewDecimalColumn gridViewDecimalColumn5 = new Telerik.WinControls.UI.GridViewDecimalColumn();
            Telerik.WinControls.UI.GridViewDecimalColumn gridViewDecimalColumn6 = new Telerik.WinControls.UI.GridViewDecimalColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn5 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn6 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn7 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewDecimalColumn gridViewDecimalColumn7 = new Telerik.WinControls.UI.GridViewDecimalColumn();
            Telerik.WinControls.UI.GridViewCheckBoxColumn gridViewCheckBoxColumn5 = new Telerik.WinControls.UI.GridViewCheckBoxColumn();
            Telerik.WinControls.UI.GridViewDecimalColumn gridViewDecimalColumn8 = new Telerik.WinControls.UI.GridViewDecimalColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn8 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewCheckBoxColumn gridViewCheckBoxColumn6 = new Telerik.WinControls.UI.GridViewCheckBoxColumn();
            Telerik.WinControls.UI.GridViewCheckBoxColumn gridViewCheckBoxColumn7 = new Telerik.WinControls.UI.GridViewCheckBoxColumn();
            Telerik.WinControls.UI.GridViewDateTimeColumn gridViewDateTimeColumn3 = new Telerik.WinControls.UI.GridViewDateTimeColumn();
            Telerik.WinControls.UI.GridViewDateTimeColumn gridViewDateTimeColumn4 = new Telerik.WinControls.UI.GridViewDateTimeColumn();
            Telerik.WinControls.UI.GridViewCheckBoxColumn gridViewCheckBoxColumn8 = new Telerik.WinControls.UI.GridViewCheckBoxColumn();
            Telerik.WinControls.UI.TableViewDefinition tableViewDefinition2 = new Telerik.WinControls.UI.TableViewDefinition();
            this.btnEditCustomField = new Telerik.WinControls.UI.RadButton();
            this.btnAddCustomField = new Telerik.WinControls.UI.RadButton();
            this.grdCustomFields = new Telerik.WinControls.UI.RadGridView();
            this.customFieldsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.customerDbDataSet13 = new CustomerService.customerDbDataSet13();
            this.customFieldsTableAdapter = new CustomerService.customerDbDataSet13TableAdapters.CustomFieldsTableAdapter();
            this.customerDbDataSet14 = new CustomerService.customerDbDataSet14();
            this.customFieldsBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.customFieldsTableAdapter1 = new CustomerService.customerDbDataSet14TableAdapters.CustomFieldsTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.btnEditCustomField)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnAddCustomField)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdCustomFields)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdCustomFields.MasterTemplate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customFieldsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerDbDataSet13)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerDbDataSet14)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customFieldsBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnEditCustomField
            // 
            this.btnEditCustomField.Location = new System.Drawing.Point(128, 219);
            this.btnEditCustomField.Name = "btnEditCustomField";
            this.btnEditCustomField.Size = new System.Drawing.Size(110, 24);
            this.btnEditCustomField.TabIndex = 8;
            this.btnEditCustomField.Text = "Edit Custom Field";
            this.btnEditCustomField.Click += new System.EventHandler(this.btnEditCustomField_Click);
            // 
            // btnAddCustomField
            // 
            this.btnAddCustomField.Location = new System.Drawing.Point(12, 219);
            this.btnAddCustomField.Name = "btnAddCustomField";
            this.btnAddCustomField.Size = new System.Drawing.Size(110, 24);
            this.btnAddCustomField.TabIndex = 7;
            this.btnAddCustomField.Text = "Add Custom Field";
            this.btnAddCustomField.Click += new System.EventHandler(this.btnAddCustomField_Click);
            // 
            // grdCustomFields
            // 
            this.grdCustomFields.BackColor = System.Drawing.SystemColors.Control;
            this.grdCustomFields.Cursor = System.Windows.Forms.Cursors.Default;
            this.grdCustomFields.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.grdCustomFields.ForeColor = System.Drawing.SystemColors.ControlText;
            this.grdCustomFields.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.grdCustomFields.Location = new System.Drawing.Point(12, 12);
            // 
            // 
            // 
            this.grdCustomFields.MasterTemplate.AllowAddNewRow = false;
            this.grdCustomFields.MasterTemplate.AllowColumnChooser = false;
            this.grdCustomFields.MasterTemplate.AllowDragToGroup = false;
            this.grdCustomFields.MasterTemplate.AllowRowResize = false;
            this.grdCustomFields.MasterTemplate.AutoSizeColumnsMode = Telerik.WinControls.UI.GridViewAutoSizeColumnsMode.Fill;
            gridViewDecimalColumn5.DataType = typeof(int);
            gridViewDecimalColumn5.EnableExpressionEditor = false;
            gridViewDecimalColumn5.FieldName = "id";
            gridViewDecimalColumn5.HeaderText = "id";
            gridViewDecimalColumn5.IsAutoGenerated = true;
            gridViewDecimalColumn5.IsVisible = false;
            gridViewDecimalColumn5.Name = "id";
            gridViewDecimalColumn6.DataType = typeof(int);
            gridViewDecimalColumn6.EnableExpressionEditor = false;
            gridViewDecimalColumn6.FieldName = "CustomerId";
            gridViewDecimalColumn6.HeaderText = "CustomerId";
            gridViewDecimalColumn6.IsAutoGenerated = true;
            gridViewDecimalColumn6.IsVisible = false;
            gridViewDecimalColumn6.Name = "CustomerId";
            gridViewTextBoxColumn5.EnableExpressionEditor = false;
            gridViewTextBoxColumn5.FieldName = "TableName";
            gridViewTextBoxColumn5.HeaderText = "TableName";
            gridViewTextBoxColumn5.IsAutoGenerated = true;
            gridViewTextBoxColumn5.Name = "TableName";
            gridViewTextBoxColumn5.Width = 150;
            gridViewTextBoxColumn6.EnableExpressionEditor = false;
            gridViewTextBoxColumn6.FieldName = "FieldName";
            gridViewTextBoxColumn6.HeaderText = "Field Name";
            gridViewTextBoxColumn6.IsAutoGenerated = true;
            gridViewTextBoxColumn6.Name = "FieldName";
            gridViewTextBoxColumn6.Width = 150;
            gridViewTextBoxColumn7.EnableExpressionEditor = false;
            gridViewTextBoxColumn7.FieldName = "FieldValue";
            gridViewTextBoxColumn7.HeaderText = "Field Value";
            gridViewTextBoxColumn7.IsAutoGenerated = true;
            gridViewTextBoxColumn7.Name = "FieldValue";
            gridViewTextBoxColumn7.Width = 150;
            gridViewDecimalColumn7.DataType = typeof(int);
            gridViewDecimalColumn7.EnableExpressionEditor = false;
            gridViewDecimalColumn7.FieldName = "FieldType";
            gridViewDecimalColumn7.HeaderText = "Field Type";
            gridViewDecimalColumn7.IsAutoGenerated = true;
            gridViewDecimalColumn7.Name = "FieldType";
            gridViewDecimalColumn7.Width = 150;
            gridViewCheckBoxColumn5.EnableExpressionEditor = false;
            gridViewCheckBoxColumn5.FieldName = "boolValue";
            gridViewCheckBoxColumn5.HeaderText = "boolValue";
            gridViewCheckBoxColumn5.IsAutoGenerated = true;
            gridViewCheckBoxColumn5.IsVisible = false;
            gridViewCheckBoxColumn5.MinWidth = 20;
            gridViewCheckBoxColumn5.Name = "boolValue";
            gridViewDecimalColumn8.EnableExpressionEditor = false;
            gridViewDecimalColumn8.FieldName = "decimalValue";
            gridViewDecimalColumn8.HeaderText = "decimalValue";
            gridViewDecimalColumn8.IsAutoGenerated = true;
            gridViewDecimalColumn8.IsVisible = false;
            gridViewDecimalColumn8.Name = "decimalValue";
            gridViewTextBoxColumn8.EnableExpressionEditor = false;
            gridViewTextBoxColumn8.FieldName = "TextValue";
            gridViewTextBoxColumn8.HeaderText = "TextValue";
            gridViewTextBoxColumn8.IsAutoGenerated = true;
            gridViewTextBoxColumn8.IsVisible = false;
            gridViewTextBoxColumn8.Name = "TextValue";
            gridViewCheckBoxColumn6.EnableExpressionEditor = false;
            gridViewCheckBoxColumn6.FieldName = "isVisible";
            gridViewCheckBoxColumn6.HeaderText = "isVisible";
            gridViewCheckBoxColumn6.IsAutoGenerated = true;
            gridViewCheckBoxColumn6.MinWidth = 20;
            gridViewCheckBoxColumn6.Name = "isVisible";
            gridViewCheckBoxColumn6.Width = 151;
            gridViewCheckBoxColumn7.EnableExpressionEditor = false;
            gridViewCheckBoxColumn7.FieldName = "isDeleted";
            gridViewCheckBoxColumn7.HeaderText = "isDeleted";
            gridViewCheckBoxColumn7.IsAutoGenerated = true;
            gridViewCheckBoxColumn7.IsVisible = false;
            gridViewCheckBoxColumn7.MinWidth = 20;
            gridViewCheckBoxColumn7.Name = "isDeleted";
            gridViewDateTimeColumn3.EnableExpressionEditor = false;
            gridViewDateTimeColumn3.FieldName = "CreatedBy";
            gridViewDateTimeColumn3.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            gridViewDateTimeColumn3.HeaderText = "CreatedBy";
            gridViewDateTimeColumn3.IsAutoGenerated = true;
            gridViewDateTimeColumn3.IsVisible = false;
            gridViewDateTimeColumn3.Name = "CreatedBy";
            gridViewDateTimeColumn4.EnableExpressionEditor = false;
            gridViewDateTimeColumn4.FieldName = "CreatedDate";
            gridViewDateTimeColumn4.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            gridViewDateTimeColumn4.HeaderText = "CreatedDate";
            gridViewDateTimeColumn4.IsAutoGenerated = true;
            gridViewDateTimeColumn4.IsVisible = false;
            gridViewDateTimeColumn4.Name = "CreatedDate";
            gridViewCheckBoxColumn8.EnableExpressionEditor = false;
            gridViewCheckBoxColumn8.FieldName = "isActive";
            gridViewCheckBoxColumn8.HeaderText = "isActive";
            gridViewCheckBoxColumn8.IsAutoGenerated = true;
            gridViewCheckBoxColumn8.IsVisible = false;
            gridViewCheckBoxColumn8.MinWidth = 20;
            gridViewCheckBoxColumn8.Name = "isActive";
            this.grdCustomFields.MasterTemplate.Columns.AddRange(new Telerik.WinControls.UI.GridViewDataColumn[] {
            gridViewDecimalColumn5,
            gridViewDecimalColumn6,
            gridViewTextBoxColumn5,
            gridViewTextBoxColumn6,
            gridViewTextBoxColumn7,
            gridViewDecimalColumn7,
            gridViewCheckBoxColumn5,
            gridViewDecimalColumn8,
            gridViewTextBoxColumn8,
            gridViewCheckBoxColumn6,
            gridViewCheckBoxColumn7,
            gridViewDateTimeColumn3,
            gridViewDateTimeColumn4,
            gridViewCheckBoxColumn8});
            this.grdCustomFields.MasterTemplate.DataSource = this.customFieldsBindingSource;
            this.grdCustomFields.MasterTemplate.EnableGrouping = false;
            this.grdCustomFields.MasterTemplate.EnableSorting = false;
            this.grdCustomFields.MasterTemplate.ViewDefinition = tableViewDefinition2;
            this.grdCustomFields.Name = "grdCustomFields";
            this.grdCustomFields.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.grdCustomFields.Size = new System.Drawing.Size(768, 201);
            this.grdCustomFields.TabIndex = 6;
            this.grdCustomFields.Text = "radGridView1";
            this.grdCustomFields.SelectionChanged += new System.EventHandler(this.grdCustomFields_SelectionChanged);
            // 
            // customFieldsBindingSource
            // 
            this.customFieldsBindingSource.DataMember = "CustomFields";
            this.customFieldsBindingSource.DataSource = this.customerDbDataSet13;
            // 
            // customerDbDataSet13
            // 
            this.customerDbDataSet13.DataSetName = "customerDbDataSet13";
            this.customerDbDataSet13.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // customFieldsTableAdapter
            // 
            this.customFieldsTableAdapter.ClearBeforeFill = true;
            // 
            // customerDbDataSet14
            // 
            this.customerDbDataSet14.DataSetName = "customerDbDataSet14";
            this.customerDbDataSet14.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // customFieldsBindingSource1
            // 
            this.customFieldsBindingSource1.DataMember = "CustomFields";
            this.customFieldsBindingSource1.DataSource = this.customerDbDataSet14;
            // 
            // customFieldsTableAdapter1
            // 
            this.customFieldsTableAdapter1.ClearBeforeFill = true;
            // 
            // frmCustomFields
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(792, 259);
            this.Controls.Add(this.btnEditCustomField);
            this.Controls.Add(this.btnAddCustomField);
            this.Controls.Add(this.grdCustomFields);
            this.Name = "frmCustomFields";
            this.Text = "Custom Fields";
            this.Load += new System.EventHandler(this.frmCustomFields_Load);
            ((System.ComponentModel.ISupportInitialize)(this.btnEditCustomField)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnAddCustomField)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdCustomFields.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdCustomFields)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customFieldsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerDbDataSet13)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerDbDataSet14)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customFieldsBindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Telerik.WinControls.UI.RadButton btnEditCustomField;
        private Telerik.WinControls.UI.RadButton btnAddCustomField;
        private Telerik.WinControls.UI.RadGridView grdCustomFields;
        private customerDbDataSet13 customerDbDataSet13;
        private System.Windows.Forms.BindingSource customFieldsBindingSource;
        private customerDbDataSet13TableAdapters.CustomFieldsTableAdapter customFieldsTableAdapter;
        private customerDbDataSet14 customerDbDataSet14;
        private System.Windows.Forms.BindingSource customFieldsBindingSource1;
        private customerDbDataSet14TableAdapters.CustomFieldsTableAdapter customFieldsTableAdapter1;
    }
}