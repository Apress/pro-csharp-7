namespace DataGridViewDataDesigner
{
	partial class MainForm
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
			this.inventoryDataGridView = new System.Windows.Forms.DataGridView();
			this.carIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.makeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.colorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.petNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.inventoryDataSet = new DataGridViewDataDesigner.InventoryDataSet();
			this.inventoryBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.inventoryTableAdapter = new DataGridViewDataDesigner.InventoryDataSetTableAdapters.InventoryTableAdapter();
			this.btnUpdateInventory = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.inventoryDataGridView)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.inventoryDataSet)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.inventoryBindingSource)).BeginInit();
			this.SuspendLayout();
			// 
			// inventoryDataGridView
			// 
			this.inventoryDataGridView.AutoGenerateColumns = false;
			this.inventoryDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.inventoryDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.carIdDataGridViewTextBoxColumn,
            this.makeDataGridViewTextBoxColumn,
            this.colorDataGridViewTextBoxColumn,
            this.petNameDataGridViewTextBoxColumn});
			this.inventoryDataGridView.DataSource = this.inventoryBindingSource;
			this.inventoryDataGridView.Location = new System.Drawing.Point(12, 12);
			this.inventoryDataGridView.Name = "inventoryDataGridView";
			this.inventoryDataGridView.RowTemplate.Height = 24;
			this.inventoryDataGridView.Size = new System.Drawing.Size(762, 355);
			this.inventoryDataGridView.TabIndex = 0;
			// 
			// carIdDataGridViewTextBoxColumn
			// 
			this.carIdDataGridViewTextBoxColumn.DataPropertyName = "CarId";
			this.carIdDataGridViewTextBoxColumn.HeaderText = "CarId";
			this.carIdDataGridViewTextBoxColumn.Name = "carIdDataGridViewTextBoxColumn";
			this.carIdDataGridViewTextBoxColumn.ReadOnly = true;
			// 
			// makeDataGridViewTextBoxColumn
			// 
			this.makeDataGridViewTextBoxColumn.DataPropertyName = "Make";
			this.makeDataGridViewTextBoxColumn.HeaderText = "Make";
			this.makeDataGridViewTextBoxColumn.Name = "makeDataGridViewTextBoxColumn";
			// 
			// colorDataGridViewTextBoxColumn
			// 
			this.colorDataGridViewTextBoxColumn.DataPropertyName = "Color";
			this.colorDataGridViewTextBoxColumn.HeaderText = "Color";
			this.colorDataGridViewTextBoxColumn.Name = "colorDataGridViewTextBoxColumn";
			// 
			// petNameDataGridViewTextBoxColumn
			// 
			this.petNameDataGridViewTextBoxColumn.DataPropertyName = "PetName";
			this.petNameDataGridViewTextBoxColumn.HeaderText = "PetName";
			this.petNameDataGridViewTextBoxColumn.Name = "petNameDataGridViewTextBoxColumn";
			// 
			// inventoryDataSet
			// 
			this.inventoryDataSet.DataSetName = "InventoryDataSet";
			this.inventoryDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
			// 
			// inventoryBindingSource
			// 
			this.inventoryBindingSource.DataMember = "Inventory";
			this.inventoryBindingSource.DataSource = this.inventoryDataSet;
			// 
			// inventoryTableAdapter
			// 
			this.inventoryTableAdapter.ClearBeforeFill = true;
			// 
			// btnUpdateInventory
			// 
			this.btnUpdateInventory.Location = new System.Drawing.Point(674, 374);
			this.btnUpdateInventory.Margin = new System.Windows.Forms.Padding(4);
			this.btnUpdateInventory.Name = "btnUpdateInventory";
			this.btnUpdateInventory.Size = new System.Drawing.Size(100, 28);
			this.btnUpdateInventory.TabIndex = 2;
			this.btnUpdateInventory.Text = "Update!";
			this.btnUpdateInventory.UseVisualStyleBackColor = true;
			this.btnUpdateInventory.Click += new System.EventHandler(this.btnUpdateInventory_Click);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(786, 408);
			this.Controls.Add(this.btnUpdateInventory);
			this.Controls.Add(this.inventoryDataGridView);
			this.Name = "MainForm";
			this.Text = "Windows Forms Data Wizards";
			this.Load += new System.EventHandler(this.MainForm_Load);
			((System.ComponentModel.ISupportInitialize)(this.inventoryDataGridView)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.inventoryDataSet)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.inventoryBindingSource)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.DataGridView inventoryDataGridView;
		private System.Windows.Forms.DataGridViewTextBoxColumn carIdDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn makeDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn colorDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn petNameDataGridViewTextBoxColumn;
		private InventoryDataSet inventoryDataSet;
		private System.Windows.Forms.BindingSource inventoryBindingSource;
		private InventoryDataSetTableAdapters.InventoryTableAdapter inventoryTableAdapter;
		private System.Windows.Forms.Button btnUpdateInventory;
	}
}

