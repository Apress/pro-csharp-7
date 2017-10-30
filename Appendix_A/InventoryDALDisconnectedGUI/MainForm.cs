using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AutoLotDAL2.DisconnectedLayer;

namespace InventoryDALDisconnectedGUI
{
	public partial class MainForm : Form
	{
		private InventoryDALDC _dal = null;
		public MainForm()
		{
			InitializeComponent();
			string connectionString = 
				@"Data Source=(local)\SQLEXPRESS2014;Initial Catalog=AutoLot;" +
				"Integrated Security=True;Pooling=False";

			// Create our data access object.
			_dal = new InventoryDALDC(connectionString);

			// Fill up our grid!
			inventoryGrid.DataSource = _dal.GetAllInventory();

		}

		private void btnUpdateInventory_Click(object sender, EventArgs e)
		{
			// Get modified data from the grid.
			DataTable changedDT = (DataTable)inventoryGrid.DataSource;
			try
			{
				// Commit our changes. 
				_dal.UpdateInventory(changedDT);
				inventoryGrid.DataSource = _dal.GetAllInventory();
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}

		}
	}
}
