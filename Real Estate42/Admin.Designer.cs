namespace Real_Estate42
{
    partial class Admin
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
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.accountsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.accountsDataSet1 = new Real_Estate42.AccountsDataSet1();
            this.accountsTableAdapter = new Real_Estate42.AccountsDataSet1TableAdapters.AccountsTableAdapter();
            this.realEstateDataBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.real_Estate_DataDataSet1 = new Real_Estate42.Real_Estate_DataDataSet1();
            this.real_Estate_DataTableAdapter = new Real_Estate42.Real_Estate_DataDataSet1TableAdapters.Real_Estate_DataTableAdapter();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.real_Estate47DataSet = new Real_Estate42.Real_Estate47DataSet();
            this.realEstateDataBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.real_Estate_DataTableAdapter1 = new Real_Estate42.Real_Estate47DataSetTableAdapters.Real_Estate_DataTableAdapter();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buildingNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.typeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.viewDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.spaceM2DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pricePerMeterDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rentPriceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.purchasePriceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.accountsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.accountsDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.realEstateDataBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.real_Estate_DataDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.real_Estate47DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.realEstateDataBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(289, 534);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(149, 60);
            this.button2.TabIndex = 1;
            this.button2.Text = "Show Data";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(756, 534);
            this.button3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(140, 60);
            this.button3.TabIndex = 2;
            this.button3.Text = "Back";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // accountsBindingSource
            // 
            this.accountsBindingSource.DataMember = "Accounts";
            this.accountsBindingSource.DataSource = this.accountsDataSet1;
            // 
            // accountsDataSet1
            // 
            this.accountsDataSet1.DataSetName = "AccountsDataSet1";
            this.accountsDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // accountsTableAdapter
            // 
            this.accountsTableAdapter.ClearBeforeFill = true;
            // 
            // realEstateDataBindingSource
            // 
            this.realEstateDataBindingSource.DataMember = "Real Estate Data";
            this.realEstateDataBindingSource.DataSource = this.real_Estate_DataDataSet1;
            // 
            // real_Estate_DataDataSet1
            // 
            this.real_Estate_DataDataSet1.DataSetName = "Real_Estate_DataDataSet1";
            this.real_Estate_DataDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // real_Estate_DataTableAdapter
            // 
            this.real_Estate_DataTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridView1
            // 
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
            this.dataGridView1.DataSource = this.realEstateDataBindingSource1;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1266, 511);
            this.dataGridView1.TabIndex = 6;
            this.dataGridView1.Visible = false;
            // 
            // real_Estate47DataSet
            // 
            this.real_Estate47DataSet.DataSetName = "Real_Estate47DataSet";
            this.real_Estate47DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // realEstateDataBindingSource1
            // 
            this.realEstateDataBindingSource1.DataMember = "Real Estate Data";
            this.realEstateDataBindingSource1.DataSource = this.real_Estate47DataSet;
            // 
            // real_Estate_DataTableAdapter1
            // 
            this.real_Estate_DataTableAdapter1.ClearBeforeFill = true;
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            this.iDDataGridViewTextBoxColumn.Width = 125;
            // 
            // buildingNumberDataGridViewTextBoxColumn
            // 
            this.buildingNumberDataGridViewTextBoxColumn.DataPropertyName = "Building Number";
            this.buildingNumberDataGridViewTextBoxColumn.HeaderText = "Building Number";
            this.buildingNumberDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.buildingNumberDataGridViewTextBoxColumn.Name = "buildingNumberDataGridViewTextBoxColumn";
            this.buildingNumberDataGridViewTextBoxColumn.Width = 125;
            // 
            // addressDataGridViewTextBoxColumn
            // 
            this.addressDataGridViewTextBoxColumn.DataPropertyName = "Address";
            this.addressDataGridViewTextBoxColumn.HeaderText = "Address";
            this.addressDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.addressDataGridViewTextBoxColumn.Name = "addressDataGridViewTextBoxColumn";
            this.addressDataGridViewTextBoxColumn.Width = 125;
            // 
            // typeDataGridViewTextBoxColumn
            // 
            this.typeDataGridViewTextBoxColumn.DataPropertyName = "Type";
            this.typeDataGridViewTextBoxColumn.HeaderText = "Type";
            this.typeDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.typeDataGridViewTextBoxColumn.Name = "typeDataGridViewTextBoxColumn";
            this.typeDataGridViewTextBoxColumn.Width = 125;
            // 
            // viewDataGridViewTextBoxColumn
            // 
            this.viewDataGridViewTextBoxColumn.DataPropertyName = "View";
            this.viewDataGridViewTextBoxColumn.HeaderText = "View";
            this.viewDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.viewDataGridViewTextBoxColumn.Name = "viewDataGridViewTextBoxColumn";
            this.viewDataGridViewTextBoxColumn.Width = 125;
            // 
            // spaceM2DataGridViewTextBoxColumn
            // 
            this.spaceM2DataGridViewTextBoxColumn.DataPropertyName = "Space (M^2)";
            this.spaceM2DataGridViewTextBoxColumn.HeaderText = "Space (M^2)";
            this.spaceM2DataGridViewTextBoxColumn.MinimumWidth = 6;
            this.spaceM2DataGridViewTextBoxColumn.Name = "spaceM2DataGridViewTextBoxColumn";
            this.spaceM2DataGridViewTextBoxColumn.Width = 125;
            // 
            // pricePerMeterDataGridViewTextBoxColumn
            // 
            this.pricePerMeterDataGridViewTextBoxColumn.DataPropertyName = "Price per Meter";
            this.pricePerMeterDataGridViewTextBoxColumn.HeaderText = "Price per Meter";
            this.pricePerMeterDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.pricePerMeterDataGridViewTextBoxColumn.Name = "pricePerMeterDataGridViewTextBoxColumn";
            this.pricePerMeterDataGridViewTextBoxColumn.Width = 125;
            // 
            // rentPriceDataGridViewTextBoxColumn
            // 
            this.rentPriceDataGridViewTextBoxColumn.DataPropertyName = "Rent Price";
            this.rentPriceDataGridViewTextBoxColumn.HeaderText = "Rent Price";
            this.rentPriceDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.rentPriceDataGridViewTextBoxColumn.Name = "rentPriceDataGridViewTextBoxColumn";
            this.rentPriceDataGridViewTextBoxColumn.Width = 125;
            // 
            // purchasePriceDataGridViewTextBoxColumn
            // 
            this.purchasePriceDataGridViewTextBoxColumn.DataPropertyName = "Purchase Price";
            this.purchasePriceDataGridViewTextBoxColumn.HeaderText = "Purchase Price";
            this.purchasePriceDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.purchasePriceDataGridViewTextBoxColumn.Name = "purchasePriceDataGridViewTextBoxColumn";
            this.purchasePriceDataGridViewTextBoxColumn.Width = 125;
            // 
            // Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1255, 619);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Admin";
            this.Text = "Admin";
            this.Load += new System.EventHandler(this.Admin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.accountsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.accountsDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.realEstateDataBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.real_Estate_DataDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.real_Estate47DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.realEstateDataBindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private AccountsDataSet1 accountsDataSet1;
        private System.Windows.Forms.BindingSource accountsBindingSource;
        private AccountsDataSet1TableAdapters.AccountsTableAdapter accountsTableAdapter;
        private Real_Estate_DataDataSet1 real_Estate_DataDataSet1;
        private System.Windows.Forms.BindingSource realEstateDataBindingSource;
        private Real_Estate_DataDataSet1TableAdapters.Real_Estate_DataTableAdapter real_Estate_DataTableAdapter;
        private System.Windows.Forms.DataGridView dataGridView1;
        private Real_Estate47DataSet real_Estate47DataSet;
        private System.Windows.Forms.BindingSource realEstateDataBindingSource1;
        private Real_Estate47DataSetTableAdapters.Real_Estate_DataTableAdapter real_Estate_DataTableAdapter1;
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