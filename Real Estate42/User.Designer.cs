namespace Real_Estate42
{
    partial class User
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.sampleToolStrip = new System.Windows.Forms.ToolStrip();
            this.sampleToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.real_Estate_DataDataSet3 = new Real_Estate42.Real_Estate_DataDataSet3();
            this.realEstateDataBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.real_Estate_DataTableAdapter = new Real_Estate42.Real_Estate_DataDataSet3TableAdapters.Real_Estate_DataTableAdapter();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buildingNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.typeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.viewDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.spaceM2DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pricePerMeterDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rentPriceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.purchasePriceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.sampleToolStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.real_Estate_DataDataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.realEstateDataBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn,
            this.buildingNumberDataGridViewTextBoxColumn,
            this.addressDataGridViewTextBoxColumn,
            this.typeDataGridViewTextBoxColumn,
            this.viewDataGridViewTextBoxColumn,
            this.spaceM2DataGridViewTextBoxColumn,
            this.pricePerMeterDataGridViewTextBoxColumn,
            this.rentPriceDataGridViewTextBoxColumn,
            this.purchasePriceDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.realEstateDataBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(0, 28);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(916, 424);
            this.dataGridView1.TabIndex = 0;
            // 
            // sampleToolStrip
            // 
            this.sampleToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sampleToolStripButton});
            this.sampleToolStrip.Location = new System.Drawing.Point(0, 0);
            this.sampleToolStrip.Name = "sampleToolStrip";
            this.sampleToolStrip.Size = new System.Drawing.Size(916, 25);
            this.sampleToolStrip.TabIndex = 9;
            this.sampleToolStrip.Text = "sampleToolStrip";
            // 
            // sampleToolStripButton
            // 
            this.sampleToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.sampleToolStripButton.Name = "sampleToolStripButton";
            this.sampleToolStripButton.Size = new System.Drawing.Size(50, 22);
            this.sampleToolStripButton.Text = "Sample";
            this.sampleToolStripButton.Click += new System.EventHandler(this.sampleToolStripButton_Click);
            // 
            // real_Estate_DataDataSet3
            // 
            this.real_Estate_DataDataSet3.DataSetName = "Real_Estate_DataDataSet3";
            this.real_Estate_DataDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // realEstateDataBindingSource
            // 
            this.realEstateDataBindingSource.DataMember = "Real Estate Data";
            this.realEstateDataBindingSource.DataSource = this.real_Estate_DataDataSet3;
            // 
            // real_Estate_DataTableAdapter
            // 
            this.real_Estate_DataTableAdapter.ClearBeforeFill = true;
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            this.iDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // buildingNumberDataGridViewTextBoxColumn
            // 
            this.buildingNumberDataGridViewTextBoxColumn.DataPropertyName = "Building Number";
            this.buildingNumberDataGridViewTextBoxColumn.HeaderText = "Building Number";
            this.buildingNumberDataGridViewTextBoxColumn.Name = "buildingNumberDataGridViewTextBoxColumn";
            this.buildingNumberDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // addressDataGridViewTextBoxColumn
            // 
            this.addressDataGridViewTextBoxColumn.DataPropertyName = "Address";
            this.addressDataGridViewTextBoxColumn.HeaderText = "Address";
            this.addressDataGridViewTextBoxColumn.Name = "addressDataGridViewTextBoxColumn";
            this.addressDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // typeDataGridViewTextBoxColumn
            // 
            this.typeDataGridViewTextBoxColumn.DataPropertyName = "Type";
            this.typeDataGridViewTextBoxColumn.HeaderText = "Type";
            this.typeDataGridViewTextBoxColumn.Name = "typeDataGridViewTextBoxColumn";
            this.typeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // viewDataGridViewTextBoxColumn
            // 
            this.viewDataGridViewTextBoxColumn.DataPropertyName = "View";
            this.viewDataGridViewTextBoxColumn.HeaderText = "View";
            this.viewDataGridViewTextBoxColumn.Name = "viewDataGridViewTextBoxColumn";
            this.viewDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // spaceM2DataGridViewTextBoxColumn
            // 
            this.spaceM2DataGridViewTextBoxColumn.DataPropertyName = "Space (M^2)";
            this.spaceM2DataGridViewTextBoxColumn.HeaderText = "Space (M^2)";
            this.spaceM2DataGridViewTextBoxColumn.Name = "spaceM2DataGridViewTextBoxColumn";
            this.spaceM2DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // pricePerMeterDataGridViewTextBoxColumn
            // 
            this.pricePerMeterDataGridViewTextBoxColumn.DataPropertyName = "Price per Meter";
            this.pricePerMeterDataGridViewTextBoxColumn.HeaderText = "Price per Meter";
            this.pricePerMeterDataGridViewTextBoxColumn.Name = "pricePerMeterDataGridViewTextBoxColumn";
            this.pricePerMeterDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // rentPriceDataGridViewTextBoxColumn
            // 
            this.rentPriceDataGridViewTextBoxColumn.DataPropertyName = "Rent Price";
            this.rentPriceDataGridViewTextBoxColumn.HeaderText = "Rent Price";
            this.rentPriceDataGridViewTextBoxColumn.Name = "rentPriceDataGridViewTextBoxColumn";
            this.rentPriceDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // purchasePriceDataGridViewTextBoxColumn
            // 
            this.purchasePriceDataGridViewTextBoxColumn.DataPropertyName = "Purchase Price";
            this.purchasePriceDataGridViewTextBoxColumn.HeaderText = "Purchase Price";
            this.purchasePriceDataGridViewTextBoxColumn.Name = "purchasePriceDataGridViewTextBoxColumn";
            this.purchasePriceDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // User
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(916, 452);
            this.Controls.Add(this.sampleToolStrip);
            this.Controls.Add(this.dataGridView1);
            this.Name = "User";
            this.Text = "User";
            this.Load += new System.EventHandler(this.User_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.sampleToolStrip.ResumeLayout(false);
            this.sampleToolStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.real_Estate_DataDataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.realEstateDataBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ToolStrip sampleToolStrip;
        private System.Windows.Forms.ToolStripButton sampleToolStripButton;
        private Real_Estate_DataDataSet3 real_Estate_DataDataSet3;
        private System.Windows.Forms.BindingSource realEstateDataBindingSource;
        private Real_Estate_DataDataSet3TableAdapters.Real_Estate_DataTableAdapter real_Estate_DataTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn buildingNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn addressDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn typeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn viewDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn spaceM2DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pricePerMeterDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rentPriceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn purchasePriceDataGridViewTextBoxColumn;
    }
}