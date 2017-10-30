using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataGridViewDataDesigner
{
	public partial class MainForm : Form
	{
		public MainForm()
		{
			InitializeComponent();
		}

		private void MainForm_Load(object sender, EventArgs e)
		{
			// TODO: This line of code loads data into the 'inventoryDataSet.Inventory' table. You can move, or remove it, as needed.
			this.inventoryTableAdapter.Fill(this.inventoryDataSet.Inventory);

		}

		private void btnUpdateInventory_Click(object sender, EventArgs e)
		{
			try
			{
				// Save changes with the Inventory table back to the database.    
				inventoryTableAdapter.Update(this.inventoryDataSet.Inventory);
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
			// Get fresh copy for grid.
			inventoryTableAdapter.Fill(this.inventoryDataSet.Inventory);
		}
	}
}
