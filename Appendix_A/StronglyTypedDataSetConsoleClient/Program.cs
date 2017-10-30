using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoLotDAL3.DataSets;
using AutoLotDAL3.DataSets.AutoLotDataSetTableAdapters;
using static System.Console;

namespace StronglyTypedDataSetConsoleClient
{
	class Program
	{
		static void Main(string[] args)
		{
			WriteLine("***** Fun with Strongly Typed DataSets *****\n");

			// Caller creates the DataSet object.
			var table = new AutoLotDataSet.InventoryDataTable();

			// Inform adapter of the Select command text and connection.
			var adapter = new InventoryTableAdapter();

			// Fill our DataSet with a new table, named Inventory.
			adapter.Fill(table);
			PrintInventory(table);
			WriteLine();

			// Add rows, update and reprint. 
			AddRecords(table, adapter);
			table.Clear();
			adapter.Fill(table);
			PrintInventory(table);
			WriteLine();

			// Remove rows we just made and reprint.
			RemoveRecords(table, adapter);
			table.Clear();
			adapter.Fill(table);
			PrintInventory(table);
			WriteLine();

			CallStoredProc();
			ReadLine();

		}
		static void PrintInventory(AutoLotDataSet.InventoryDataTable dt)
		{
			// Print out the column names.
			for (int curCol = 0; curCol < dt.Columns.Count; curCol++)
			{
				Write(dt.Columns[curCol].ColumnName + "\t");
			}
			WriteLine("\n----------------------------------");

			// Print the DataTable.
			for (int curRow = 0; curRow < dt.Rows.Count; curRow++)
			{
				for (int curCol = 0; curCol < dt.Columns.Count; curCol++)
				{
					Write(dt.Rows[curRow][curCol] + "\t");
				}
				WriteLine();
			}
		}
		public static void AddRecords(
			AutoLotDataSet.InventoryDataTable table,
			InventoryTableAdapter adapter)
		{
			try
			{
				// Get a new strongly typed row from the table.
				AutoLotDataSet.InventoryRow newRow = table.NewInventoryRow();

				// Fill row with some sample data.
				newRow.Color = "Purple";
				newRow.Make = "BMW";
				newRow.PetName = "Saku";

				// Insert the new row.
				table.AddInventoryRow(newRow);

				// Add one more row, using overloaded Add method.
				table.AddInventoryRow("Yugo", "Green", "Zippy");

				// Update database.
				adapter.Update(table);
			}
			catch (Exception ex)
			{
				WriteLine(ex.Message);
			}
		}
		private static void RemoveRecords(AutoLotDataSet.InventoryDataTable table, InventoryTableAdapter adapter)
		{
			try
			{
				AutoLotDataSet.InventoryRow rowToDelete = table.FindByCarId(8);
				adapter.Delete(rowToDelete.CarId, rowToDelete.Make, rowToDelete.Color, rowToDelete.PetName);
				rowToDelete = table.FindByCarId(9);
				adapter.Delete(rowToDelete.CarId, rowToDelete.Make, rowToDelete.Color, rowToDelete.PetName);
			}
			catch (Exception ex)
			{
				WriteLine(ex.Message);
			}
		}
		public static void CallStoredProc()
		{
			try
			{
				var queriesTableAdapter = new QueriesTableAdapter();
				Write("Enter ID of car to look up: ");
				string carID = ReadLine() ?? "0";
				string carName = "";
				queriesTableAdapter.GetPetName(int.Parse(carID), ref carName);
				WriteLine($"CarID {carID} has the name of {carName}");
			}
			catch (Exception ex)
			{
				WriteLine(ex.Message);
			}
		}


	}
}
