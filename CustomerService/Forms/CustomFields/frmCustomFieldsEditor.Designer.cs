namespace CustomerService.Forms.CustomFields
{
    partial class frmCustomFieldsEditor
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
            Telerik.WinControls.UI.RadListDataItem radListDataItem1 = new Telerik.WinControls.UI.RadListDataItem();
            Telerik.WinControls.UI.RadListDataItem radListDataItem2 = new Telerik.WinControls.UI.RadListDataItem();
            Telerik.WinControls.UI.RadListDataItem radListDataItem3 = new Telerik.WinControls.UI.RadListDataItem();
            Telerik.WinControls.UI.RadListDataItem radListDataItem4 = new Telerik.WinControls.UI.RadListDataItem();
            Telerik.WinControls.UI.RadListDataItem radListDataItem5 = new Telerik.WinControls.UI.RadListDataItem();
            this.txtFieldValue = new Telerik.WinControls.UI.RadTextBox();
            this.radLabel2 = new Telerik.WinControls.UI.RadLabel();
            this.txtName = new Telerik.WinControls.UI.RadTextBox();
            this.radLabel3 = new Telerik.WinControls.UI.RadLabel();
            this.btnSave = new Telerik.WinControls.UI.RadButton();
            this.radButton2 = new Telerik.WinControls.UI.RadButton();
            this.standardLookupsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.customerDbDataSet15 = new CustomerService.customerDbDataSet15();
            this.standardLookupsTableAdapter = new CustomerService.customerDbDataSet15TableAdapters.StandardLookupsTableAdapter();
            this.rdTableName = new Telerik.WinControls.UI.RadDropDownList();
            this.radLabel4 = new Telerik.WinControls.UI.RadLabel();
            ((System.ComponentModel.ISupportInitialize)(this.txtFieldValue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSave)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radButton2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.standardLookupsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerDbDataSet15)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rdTableName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel4)).BeginInit();
            this.SuspendLayout();
            // 
            // txtFieldValue
            // 
            this.txtFieldValue.Location = new System.Drawing.Point(129, 101);
            this.txtFieldValue.Name = "txtFieldValue";
            this.txtFieldValue.Size = new System.Drawing.Size(227, 20);
            this.txtFieldValue.TabIndex = 12;
            // 
            // radLabel2
            // 
            this.radLabel2.Location = new System.Drawing.Point(31, 67);
            this.radLabel2.Name = "radLabel2";
            this.radLabel2.Size = new System.Drawing.Size(36, 18);
            this.radLabel2.TabIndex = 11;
            this.radLabel2.Text = "Name";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(127, 65);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(227, 20);
            this.txtName.TabIndex = 10;
            // 
            // radLabel3
            // 
            this.radLabel3.Location = new System.Drawing.Point(33, 103);
            this.radLabel3.Name = "radLabel3";
            this.radLabel3.Size = new System.Drawing.Size(34, 18);
            this.radLabel3.TabIndex = 16;
            this.radLabel3.Text = "Value";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(264, 209);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(110, 24);
            this.btnSave.TabIndex = 19;
            this.btnSave.Text = "Save";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // radButton2
            // 
            this.radButton2.Location = new System.Drawing.Point(397, 209);
            this.radButton2.Name = "radButton2";
            this.radButton2.Size = new System.Drawing.Size(110, 24);
            this.radButton2.TabIndex = 20;
            this.radButton2.Text = "Cancel";
            // 
            // standardLookupsBindingSource
            // 
            this.standardLookupsBindingSource.DataMember = "StandardLookups";
            this.standardLookupsBindingSource.DataSource = this.customerDbDataSet15;
            // 
            // customerDbDataSet15
            // 
            this.customerDbDataSet15.DataSetName = "customerDbDataSet15";
            this.customerDbDataSet15.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // standardLookupsTableAdapter
            // 
            this.standardLookupsTableAdapter.ClearBeforeFill = true;
            // 
            // rdTableName
            // 
            radListDataItem1.Text = "Contacts";
            radListDataItem2.Text = "Program Types";
            radListDataItem3.Text = "Addons";
            radListDataItem4.Text = "Customer";
            radListDataItem5.Text = "Revenue";
            this.rdTableName.Items.Add(radListDataItem1);
            this.rdTableName.Items.Add(radListDataItem2);
            this.rdTableName.Items.Add(radListDataItem3);
            this.rdTableName.Items.Add(radListDataItem4);
            this.rdTableName.Items.Add(radListDataItem5);
            this.rdTableName.Location = new System.Drawing.Point(127, 29);
            this.rdTableName.Name = "rdTableName";
            this.rdTableName.Size = new System.Drawing.Size(227, 20);
            this.rdTableName.TabIndex = 24;
            // 
            // radLabel4
            // 
            this.radLabel4.Location = new System.Drawing.Point(31, 31);
            this.radLabel4.Name = "radLabel4";
            this.radLabel4.Size = new System.Drawing.Size(66, 18);
            this.radLabel4.TabIndex = 23;
            this.radLabel4.Text = "Table Name";
            // 
            // frmCustomFieldsEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(528, 245);
            this.Controls.Add(this.rdTableName);
            this.Controls.Add(this.radLabel4);
            this.Controls.Add(this.radButton2);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.radLabel3);
            this.Controls.Add(this.txtFieldValue);
            this.Controls.Add(this.radLabel2);
            this.Controls.Add(this.txtName);
            this.MinimizeBox = false;
            this.Name = "frmCustomFieldsEditor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Custom Field Editor";
            this.Load += new System.EventHandler(this.frmCustomFieldsEditor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txtFieldValue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSave)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radButton2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.standardLookupsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerDbDataSet15)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rdTableName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Telerik.WinControls.UI.RadTextBox txtFieldValue;
        private Telerik.WinControls.UI.RadLabel radLabel2;
        private Telerik.WinControls.UI.RadTextBox txtName;
        private Telerik.WinControls.UI.RadLabel radLabel3;
        private customerDbDataSet15 customerDbDataSet15;
        private System.Windows.Forms.BindingSource standardLookupsBindingSource;
        private customerDbDataSet15TableAdapters.StandardLookupsTableAdapter standardLookupsTableAdapter;
        private Telerik.WinControls.UI.RadButton btnSave;
        private Telerik.WinControls.UI.RadButton radButton2;
        private Telerik.WinControls.UI.RadDropDownList rdTableName;
        private Telerik.WinControls.UI.RadLabel radLabel4;
    }
}