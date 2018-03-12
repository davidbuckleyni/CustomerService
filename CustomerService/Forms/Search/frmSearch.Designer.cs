namespace CustomerService.Forms.Search
{
    partial class frmSearch
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
            Telerik.WinControls.UI.TableViewDefinition tableViewDefinition1 = new Telerik.WinControls.UI.TableViewDefinition();
            this.grdSearch = new Telerik.WinControls.UI.RadGridView();
            this.btnOk = new Telerik.WinControls.UI.RadButton();
            this.radButton2 = new Telerik.WinControls.UI.RadButton();
            ((System.ComponentModel.ISupportInitialize)(this.grdSearch)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdSearch.MasterTemplate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnOk)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radButton2)).BeginInit();
            this.SuspendLayout();
            // 
            // grdSearch
            // 
            this.grdSearch.BackColor = System.Drawing.SystemColors.Control;
            this.grdSearch.Cursor = System.Windows.Forms.Cursors.Default;
            this.grdSearch.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.grdSearch.ForeColor = System.Drawing.SystemColors.ControlText;
            this.grdSearch.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.grdSearch.Location = new System.Drawing.Point(6, 13);
            // 
            // 
            // 
            this.grdSearch.MasterTemplate.AllowAddNewRow = false;
            this.grdSearch.MasterTemplate.AllowColumnChooser = false;
            this.grdSearch.MasterTemplate.AllowColumnReorder = false;
            this.grdSearch.MasterTemplate.AllowColumnResize = false;
            this.grdSearch.MasterTemplate.AllowDragToGroup = false;
            this.grdSearch.MasterTemplate.AutoSizeColumnsMode = Telerik.WinControls.UI.GridViewAutoSizeColumnsMode.Fill;
            this.grdSearch.MasterTemplate.EnableGrouping = false;
            this.grdSearch.MasterTemplate.EnableSorting = false;
            this.grdSearch.MasterTemplate.ViewDefinition = tableViewDefinition1;
            this.grdSearch.Name = "grdSearch";
            this.grdSearch.ReadOnly = true;
            this.grdSearch.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.grdSearch.Size = new System.Drawing.Size(512, 191);
            this.grdSearch.TabIndex = 0;
            this.grdSearch.Text = "gr";
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(295, 210);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(110, 24);
            this.btnOk.TabIndex = 1;
            this.btnOk.Text = "Ok";
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // radButton2
            // 
            this.radButton2.Location = new System.Drawing.Point(415, 210);
            this.radButton2.Name = "radButton2";
            this.radButton2.Size = new System.Drawing.Size(110, 24);
            this.radButton2.TabIndex = 2;
            this.radButton2.Text = "Cancel";
            this.radButton2.Click += new System.EventHandler(this.radButton2_Click);
            // 
            // frmSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(547, 243);
            this.Controls.Add(this.radButton2);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.grdSearch);
            this.Name = "frmSearch";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Search";
            this.Load += new System.EventHandler(this.frmSearch_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdSearch.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdSearch)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnOk)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radButton2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Telerik.WinControls.UI.RadGridView grdSearch;
        private Telerik.WinControls.UI.RadButton btnOk;
        private Telerik.WinControls.UI.RadButton radButton2;
    }
}