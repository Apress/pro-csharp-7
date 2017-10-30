using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsDataBinding
{
	public partial class MainForm : Form
	{
		// A collection of Car objects.
		private List<Car> listCars = new List<Car>();

		// Inventory information
		private DataTable inventoryTable = new DataTable();

		//View of the DataTable
		private DataView _yugosOnlyView;
		public MainForm()
		{
			InitializeComponent();
			listCars = new List<Car>
			{
			new Car { Id = 1, PetName = "Chucky", Make = "BMW", Color = "Green" },
			new Car { Id = 2, PetName = "Tiny", Make = "Yugo", Color = "White" },
			new Car { Id = 3, PetName = "Ami", Make = "Jeep", Color = "Tan" },
			new Car { Id = 4, PetName = "Pain Inducer", Make = "Caravan", Color = "Pink" },
			new Car { Id = 5, PetName = "Fred", Make = "BMW", Color = "Green" },
			new Car { Id = 6, PetName = "Sidd", Make = "BMW", Color = "Black" },
			new Car { Id = 7, PetName = "Mel", Make = "Firebird", Color = "Red" },
			new Car { Id = 8, PetName = "Sarah", Make = "Colt", Color = "Black" },
			};
			CreateDataTable();
			//ShowCarsWithIdGreaterThanFive();
			CreateDataView();
		}

		void CreateDataTable()
		{
			// Create table schema.
			var carIDColumn = new DataColumn("Id", typeof(int));
			var carMakeColumn = new DataColumn("Make", typeof(string));
			var carColorColumn = new DataColumn("Color", typeof(string));
			var carPetNameColumn = new DataColumn("PetName", typeof(string))
			{ Caption = "Pet Name" };
			inventoryTable.Columns.AddRange(
				new[] { carIDColumn, carMakeColumn, carColorColumn, carPetNameColumn });

			// Iterate over the array list to make rows.
			foreach (var c in listCars)
			{
				var newRow = inventoryTable.NewRow();
				newRow["Id"] = c.Id;
				newRow["Make"] = c.Make;
				newRow["Color"] = c.Color;
				newRow["PetName"] = c.PetName;
				inventoryTable.Rows.Add(newRow);
			}
			// Bind the DataTable to the carInventoryGridView.
			carInventoryGridView.DataSource = inventoryTable;
		}
		private void CreateDataView()
		{
			// Set the table that is used to construct this view.
			_yugosOnlyView = new DataView(inventoryTable);

			// Now configure the views using a filter.
			_yugosOnlyView.RowFilter = "Make = 'Yugo'";

			// Bind to the new grid.
			dataGridYugosView.DataSource = _yugosOnlyView;
		}

		private void btnRemoveCar_Click(object sender, EventArgs e)
		{
			try
			{
				// Find the correct row to delete.
				DataRow[] rowToDelete = inventoryTable.Select($"Id={int.Parse(txtCarToRemove.Text)}");

				// Delete it!
				rowToDelete[0].Delete();
				inventoryTable.AcceptChanges();
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}

		}

		private void btnDisplayMakes_Click(object sender, EventArgs e)
		{
			// Build a filter based on user input.
			string filterStr = $"Make='{txtMakeToView.Text}'";

			// Find all rows matching the filter.
			DataRow[] makes = inventoryTable.Select(filterStr, "PetName DESC");

			// Show what we got!
			if (makes.Length == 0)
				MessageBox.Show("Sorry, no cars...", "Selection error!");
			else
			{
				string strMake = null;
				for (var i = 0; i < makes.Length; i++)
				{
					strMake += makes[i]["PetName"] + "\n";
				}
				// Now show all matches in a message box.
				MessageBox.Show(strMake, $"We have {txtMakeToView.Text}s named:");
			}
		}
		private void ShowCarsWithIdGreaterThanFive()
		{
			// Now show the pet names of all cars with ID greater than 5.
			DataRow[] properIDs;
			string newFilterStr = "Id > 5";
			properIDs = inventoryTable.Select(newFilterStr);
			string strIDs = null;
			for (int i = 0; i < properIDs.Length; i++)
			{
				DataRow temp = properIDs[i];
				strIDs += $"{temp["PetName"]} is ID {temp["ID"]}\n";
			}
			MessageBox.Show(strIDs, "Pet names of cars where Id > 5");
		}

		private void btnChangeMakes_Click(object sender, EventArgs e)
		{
			// Make sure user has not lost his or her mind.
			if (DialogResult.Yes !=
				MessageBox.Show("Are you sure?? BMWs are much nicer than Yugos!",
				"Please Confirm!", MessageBoxButtons.YesNo))
				return;
			// Build a filter.
			string filterStr = "Make='BMW'";

			// Find all rows matching the filter.
			DataRow[] makes = inventoryTable.Select(filterStr);

			// Change all Beemers to Yugos!
			for (int i = 0; i < makes.Length; i++)
			{
				makes[i]["Make"] = "Yugo";
			}
		}
	}
}
