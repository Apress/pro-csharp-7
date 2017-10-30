using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace FillDataSetUsingSqlDataAdapter
{
	class Program
	{
		static void Main(string[] args)
		{
			WriteLine("***** Fun with Data Adapters *****\n");

			// Hard-coded connection string.
			string connectionString = "Integrated Security = SSPI;Initial Catalog=AutoLot;" +
				@"Data Source=(local)\SQLEXPRESS2014";

			// Caller creates the DataSet object.
			DataSet ds = new DataSet("AutoLot");

			// Inform adapter of the Select command text and connection.
			SqlDataAdapter adapter =
				new SqlDataAdapter("Select * From Inventory", connectionString);

			// Now map DB column names to user-friendly names. 
			DataTableMapping tableMapping =
				adapter.TableMappings.Add("Inventory", "Current Inventory");
			tableMapping.ColumnMappings.Add("CarId", "Car Id");
			tableMapping.ColumnMappings.Add("PetName", "Name of Car");
			adapter.Fill(ds, "Inventory");

			// Display contents of DataSet.
			PrintDataSet(ds);
			ReadLine();
		}
		static void PrintDataSet(DataSet ds)
		{
			// Print out any name and extended properties. 
			WriteLine($"DataSet is named: {ds.DataSetName}");
			foreach (DictionaryEntry de in ds.ExtendedProperties)
			{
				WriteLine($"Key = {de.Key}, Value = {de.Value}");
			}
			WriteLine();

			foreach (DataTable dt in ds.Tables)
			{
				WriteLine($"=> {dt.TableName} Table:");

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
						Write(dt.Rows[curRow][curCol].ToString().Trim() + "\t");
					}
					WriteLine();
				}
			}
		}

	}
}
