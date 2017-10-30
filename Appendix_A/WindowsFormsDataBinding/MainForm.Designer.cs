namespace WindowsFormsDataBinding
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
			this.carInventoryGridView = new System.Windows.Forms.DataGridView();
			this.lblGridInfoMessage = new System.Windows.Forms.Label();
			this.groupBoxDeleteRow = new System.Windows.Forms.GroupBox();
			this.btnRemoveCar = new System.Windows.Forms.Button();
			this.txtCarToRemove = new System.Windows.Forms.TextBox();
			this.groupBoxViewMakes = new System.Windows.Forms.GroupBox();
			this.btnDisplayMakes = new System.Windows.Forms.Button();
			this.txtMakeToView = new System.Windows.Forms.TextBox();
			this.btnChangeMakes = new System.Windows.Forms.Button();
			this.dataGridYugosView = new System.Windows.Forms.DataGridView();
			this.lblOnlyYugos = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.carInventoryGridView)).BeginInit();
			this.groupBoxDeleteRow.SuspendLayout();
			this.groupBoxViewMakes.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridYugosView)).BeginInit();
			this.SuspendLayout();
			// 
			// carInventoryGridView
			// 
			this.carInventoryGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.carInventoryGridView.Location = new System.Drawing.Point(16, 68);
			this.carInventoryGridView.Name = "carInventoryGridView";
			this.carInventoryGridView.RowTemplate.Height = 24;
			this.carInventoryGridView.Size = new System.Drawing.Size(716, 235);
			this.carInventoryGridView.TabIndex = 0;
			// 
			// lblGridInfoMessage
			// 
			this.lblGridInfoMessage.AutoSize = true;
			this.lblGridInfoMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblGridInfoMessage.Location = new System.Drawing.Point(16, 16);
			this.lblGridInfoMessage.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lblGridInfoMessage.Name = "lblGridInfoMessage";
			this.lblGridInfoMessage.Size = new System.Drawing.Size(357, 29);
			this.lblGridInfoMessage.TabIndex = 2;
			this.lblGridInfoMessage.Text = "Here is what we have in stock";
			// 
			// groupBoxDeleteRow
			// 
			this.groupBoxDeleteRow.Controls.Add(this.btnRemoveCar);
			this.groupBoxDeleteRow.Controls.Add(this.txtCarToRemove);
			this.groupBoxDeleteRow.Location = new System.Drawing.Point(21, 321);
			this.groupBoxDeleteRow.Margin = new System.Windows.Forms.Padding(4);
			this.groupBoxDeleteRow.Name = "groupBoxDeleteRow";
			this.groupBoxDeleteRow.Padding = new System.Windows.Forms.Padding(4);
			this.groupBoxDeleteRow.Size = new System.Drawing.Size(352, 97);
			this.groupBoxDeleteRow.TabIndex = 3;
			this.groupBoxDeleteRow.TabStop = false;
			this.groupBoxDeleteRow.Text = "Enter ID of Car to Delete";
			// 
			// btnRemoveCar
			// 
			this.btnRemoveCar.Location = new System.Drawing.Point(213, 44);
			this.btnRemoveCar.Margin = new System.Windows.Forms.Padding(4);
			this.btnRemoveCar.Name = "btnRemoveCar";
			this.btnRemoveCar.Size = new System.Drawing.Size(132, 28);
			this.btnRemoveCar.TabIndex = 1;
			this.btnRemoveCar.Text = "Delete!";
			this.btnRemoveCar.UseVisualStyleBackColor = true;
			this.btnRemoveCar.Click += new System.EventHandler(this.btnRemoveCar_Click);
			// 
			// txtCarToRemove
			// 
			this.txtCarToRemove.Location = new System.Drawing.Point(23, 44);
			this.txtCarToRemove.Margin = new System.Windows.Forms.Padding(4);
			this.txtCarToRemove.Name = "txtCarToRemove";
			this.txtCarToRemove.Size = new System.Drawing.Size(181, 22);
			this.txtCarToRemove.TabIndex = 0;
			// 
			// groupBoxViewMakes
			// 
			this.groupBoxViewMakes.Controls.Add(this.btnDisplayMakes);
			this.groupBoxViewMakes.Controls.Add(this.txtMakeToView);
			this.groupBoxViewMakes.Location = new System.Drawing.Point(381, 321);
			this.groupBoxViewMakes.Margin = new System.Windows.Forms.Padding(4);
			this.groupBoxViewMakes.Name = "groupBoxViewMakes";
			this.groupBoxViewMakes.Padding = new System.Windows.Forms.Padding(4);
			this.groupBoxViewMakes.Size = new System.Drawing.Size(347, 97);
			this.groupBoxViewMakes.TabIndex = 4;
			this.groupBoxViewMakes.TabStop = false;
			this.groupBoxViewMakes.Text = "Enter Make to View";
			// 
			// btnDisplayMakes
			// 
			this.btnDisplayMakes.Location = new System.Drawing.Point(207, 44);
			this.btnDisplayMakes.Margin = new System.Windows.Forms.Padding(4);
			this.btnDisplayMakes.Name = "btnDisplayMakes";
			this.btnDisplayMakes.Size = new System.Drawing.Size(132, 28);
			this.btnDisplayMakes.TabIndex = 3;
			this.btnDisplayMakes.Text = "View!";
			this.btnDisplayMakes.UseVisualStyleBackColor = true;
			this.btnDisplayMakes.Click += new System.EventHandler(this.btnDisplayMakes_Click);
			// 
			// txtMakeToView
			// 
			this.txtMakeToView.Location = new System.Drawing.Point(16, 44);
			this.txtMakeToView.Margin = new System.Windows.Forms.Padding(4);
			this.txtMakeToView.Name = "txtMakeToView";
			this.txtMakeToView.Size = new System.Drawing.Size(181, 22);
			this.txtMakeToView.TabIndex = 2;
			// 
			// btnChangeMakes
			// 
			this.btnChangeMakes.Location = new System.Drawing.Point(435, 20);
			this.btnChangeMakes.Margin = new System.Windows.Forms.Padding(4);
			this.btnChangeMakes.Name = "btnChangeMakes";
			this.btnChangeMakes.Size = new System.Drawing.Size(297, 28);
			this.btnChangeMakes.TabIndex = 5;
			this.btnChangeMakes.Text = "Change All BMWs to Yugos";
			this.btnChangeMakes.UseVisualStyleBackColor = true;
			this.btnChangeMakes.Click += new System.EventHandler(this.btnChangeMakes_Click);
			// 
			// dataGridYugosView
			// 
			this.dataGridYugosView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridYugosView.Location = new System.Drawing.Point(8, 466);
			this.dataGridYugosView.Name = "dataGridYugosView";
			this.dataGridYugosView.RowTemplate.Height = 24;
			this.dataGridYugosView.Size = new System.Drawing.Size(716, 235);
			this.dataGridYugosView.TabIndex = 6;
			// 
			// lblOnlyYugos
			// 
			this.lblOnlyYugos.AutoSize = true;
			this.lblOnlyYugos.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblOnlyYugos.Location = new System.Drawing.Point(16, 430);
			this.lblOnlyYugos.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lblOnlyYugos.Name = "lblOnlyYugos";
			this.lblOnlyYugos.Size = new System.Drawing.Size(147, 29);
			this.lblOnlyYugos.TabIndex = 7;
			this.lblOnlyYugos.Text = "Only Yugos";
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(740, 710);
			this.Controls.Add(this.lblOnlyYugos);
			this.Controls.Add(this.dataGridYugosView);
			this.Controls.Add(this.btnChangeMakes);
			this.Controls.Add(this.groupBoxViewMakes);
			this.Controls.Add(this.groupBoxDeleteRow);
			this.Controls.Add(this.lblGridInfoMessage);
			this.Controls.Add(this.carInventoryGridView);
			this.Name = "MainForm";
			this.Text = "Windows Forms Data Binding";
			((System.ComponentModel.ISupportInitialize)(this.carInventoryGridView)).EndInit();
			this.groupBoxDeleteRow.ResumeLayout(false);
			this.groupBoxDeleteRow.PerformLayout();
			this.groupBoxViewMakes.ResumeLayout(false);
			this.groupBoxViewMakes.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridYugosView)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.DataGridView carInventoryGridView;
		private System.Windows.Forms.Label lblGridInfoMessage;
		private System.Windows.Forms.GroupBox groupBoxDeleteRow;
		private System.Windows.Forms.Button btnRemoveCar;
		private System.Windows.Forms.TextBox txtCarToRemove;
		private System.Windows.Forms.GroupBox groupBoxViewMakes;
		private System.Windows.Forms.Button btnDisplayMakes;
		private System.Windows.Forms.TextBox txtMakeToView;
		private System.Windows.Forms.Button btnChangeMakes;
		private System.Windows.Forms.DataGridView dataGridYugosView;
		private System.Windows.Forms.Label lblOnlyYugos;
	}
}

