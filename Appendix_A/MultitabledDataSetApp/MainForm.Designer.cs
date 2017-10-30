namespace MultitabledDataSetApp
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
			this.btnUpdateDatabase = new System.Windows.Forms.Button();
			this.label3 = new System.Windows.Forms.Label();
			this.dataGridViewOrders = new System.Windows.Forms.DataGridView();
			this.label2 = new System.Windows.Forms.Label();
			this.dataGridViewCustomers = new System.Windows.Forms.DataGridView();
			this.label1 = new System.Windows.Forms.Label();
			this.dataGridViewInventory = new System.Windows.Forms.DataGridView();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.btnGetOrderInfo = new System.Windows.Forms.Button();
			this.label4 = new System.Windows.Forms.Label();
			this.txtCustID = new System.Windows.Forms.TextBox();
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewOrders)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewCustomers)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewInventory)).BeginInit();
			this.groupBox1.SuspendLayout();
			this.SuspendLayout();
			// 
			// btnUpdateDatabase
			// 
			this.btnUpdateDatabase.Location = new System.Drawing.Point(540, 434);
			this.btnUpdateDatabase.Margin = new System.Windows.Forms.Padding(4);
			this.btnUpdateDatabase.Name = "btnUpdateDatabase";
			this.btnUpdateDatabase.Size = new System.Drawing.Size(152, 28);
			this.btnUpdateDatabase.TabIndex = 13;
			this.btnUpdateDatabase.Text = "Update Database";
			this.btnUpdateDatabase.Click += new System.EventHandler(this.btnUpdateDatabase_Click);
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(13, 285);
			this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(103, 17);
			this.label3.TabIndex = 12;
			this.label3.Text = "Current Orders";
			// 
			// dataGridViewOrders
			// 
			this.dataGridViewOrders.Location = new System.Drawing.Point(14, 310);
			this.dataGridViewOrders.Margin = new System.Windows.Forms.Padding(4);
			this.dataGridViewOrders.Name = "dataGridViewOrders";
			this.dataGridViewOrders.Size = new System.Drawing.Size(679, 111);
			this.dataGridViewOrders.TabIndex = 11;
			this.dataGridViewOrders.Text = "dataGridView3";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(13, 140);
			this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(126, 17);
			this.label2.TabIndex = 10;
			this.label2.Text = "Current Customers";
			// 
			// dataGridViewCustomers
			// 
			this.dataGridViewCustomers.Location = new System.Drawing.Point(14, 165);
			this.dataGridViewCustomers.Margin = new System.Windows.Forms.Padding(4);
			this.dataGridViewCustomers.Name = "dataGridViewCustomers";
			this.dataGridViewCustomers.Size = new System.Drawing.Size(679, 111);
			this.dataGridViewCustomers.TabIndex = 9;
			this.dataGridViewCustomers.Text = "dataGridView2";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(12, 7);
			this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(117, 17);
			this.label1.TabIndex = 8;
			this.label1.Text = "Current Inventory";
			// 
			// dataGridViewInventory
			// 
			this.dataGridViewInventory.Location = new System.Drawing.Point(13, 32);
			this.dataGridViewInventory.Margin = new System.Windows.Forms.Padding(4);
			this.dataGridViewInventory.Name = "dataGridViewInventory";
			this.dataGridViewInventory.Size = new System.Drawing.Size(679, 101);
			this.dataGridViewInventory.TabIndex = 7;
			this.dataGridViewInventory.Text = "dataGridView1";
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.btnGetOrderInfo);
			this.groupBox1.Controls.Add(this.label4);
			this.groupBox1.Controls.Add(this.txtCustID);
			this.groupBox1.Location = new System.Drawing.Point(13, 429);
			this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
			this.groupBox1.Size = new System.Drawing.Size(267, 123);
			this.groupBox1.TabIndex = 14;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Lookup Customer Order";
			// 
			// btnGetOrderInfo
			// 
			this.btnGetOrderInfo.Location = new System.Drawing.Point(112, 87);
			this.btnGetOrderInfo.Margin = new System.Windows.Forms.Padding(4);
			this.btnGetOrderInfo.Name = "btnGetOrderInfo";
			this.btnGetOrderInfo.Size = new System.Drawing.Size(147, 28);
			this.btnGetOrderInfo.TabIndex = 7;
			this.btnGetOrderInfo.Text = "Get Order Details";
			this.btnGetOrderInfo.Click += new System.EventHandler(this.btnGetOrderInfo_Click);
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(13, 36);
			this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(89, 17);
			this.label4.TabIndex = 9;
			this.label4.Text = "Customer ID:";
			// 
			// txtCustID
			// 
			this.txtCustID.Location = new System.Drawing.Point(112, 36);
			this.txtCustID.Margin = new System.Windows.Forms.Padding(4);
			this.txtCustID.Name = "txtCustID";
			this.txtCustID.Size = new System.Drawing.Size(145, 22);
			this.txtCustID.TabIndex = 8;
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(704, 559);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.btnUpdateDatabase);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.dataGridViewOrders);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.dataGridViewCustomers);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.dataGridViewInventory);
			this.Name = "MainForm";
			this.Text = "AutoLot Database Manipulator";
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewOrders)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewCustomers)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewInventory)).EndInit();
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button btnUpdateDatabase;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.DataGridView dataGridViewOrders;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.DataGridView dataGridViewCustomers;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.DataGridView dataGridViewInventory;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Button btnGetOrderInfo;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox txtCustID;
	}
}

