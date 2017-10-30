namespace InventoryDALDisconnectedGUI
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
			this.lblInstructions = new System.Windows.Forms.Label();
			this.inventoryGrid = new System.Windows.Forms.DataGridView();
			this.btnUpdateInventory = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.inventoryGrid)).BeginInit();
			this.SuspendLayout();
			// 
			// lblInstructions
			// 
			this.lblInstructions.AutoSize = true;
			this.lblInstructions.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblInstructions.Location = new System.Drawing.Point(13, 9);
			this.lblInstructions.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lblInstructions.Name = "lblInstructions";
			this.lblInstructions.Size = new System.Drawing.Size(271, 29);
			this.lblInstructions.TabIndex = 3;
			this.lblInstructions.Text = "Please Edit the Data...";
			// 
			// inventoryGrid
			// 
			this.inventoryGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.inventoryGrid.Location = new System.Drawing.Point(13, 44);
			this.inventoryGrid.Margin = new System.Windows.Forms.Padding(4);
			this.inventoryGrid.Name = "inventoryGrid";
			this.inventoryGrid.Size = new System.Drawing.Size(740, 218);
			this.inventoryGrid.TabIndex = 2;
			// 
			// btnUpdateInventory
			// 
			this.btnUpdateInventory.Location = new System.Drawing.Point(653, 270);
			this.btnUpdateInventory.Margin = new System.Windows.Forms.Padding(4);
			this.btnUpdateInventory.Name = "btnUpdateInventory";
			this.btnUpdateInventory.Size = new System.Drawing.Size(100, 28);
			this.btnUpdateInventory.TabIndex = 4;
			this.btnUpdateInventory.Text = "Update!";
			this.btnUpdateInventory.UseVisualStyleBackColor = true;
			this.btnUpdateInventory.Click += new System.EventHandler(this.btnUpdateInventory_Click);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(755, 305);
			this.Controls.Add(this.btnUpdateInventory);
			this.Controls.Add(this.lblInstructions);
			this.Controls.Add(this.inventoryGrid);
			this.Name = "MainForm";
			this.Text = "Simple GUI Front End to the Inventory Table";
			((System.ComponentModel.ISupportInitialize)(this.inventoryGrid)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label lblInstructions;
		private System.Windows.Forms.DataGridView inventoryGrid;
		private System.Windows.Forms.Button btnUpdateInventory;
	}
}

