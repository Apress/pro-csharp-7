using System;
using System.Collections;
using System.Data;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using static System.Console;

namespace SimpleDataSet
{
	internal class Program
	{
		private static void Main(string[] args)
		{
			WriteLine("***** Fun with DataSets *****\n");

			// Create the DataSet object and add a few properties.
			var carsInventoryDS = new DataSet("Car Inventory");

			carsInventoryDS.ExtendedProperties["TimeStamp"] = DateTime.Now;
			carsInventoryDS.ExtendedProperties["DataSetID"] = Guid.NewGuid();
			carsInventoryDS.ExtendedProperties["Company"] =
				"Mikko’s Hot Tub Super Store";

			FillDataSet(carsInventoryDS);
			PrintDataSet(carsInventoryDS);
			SaveAndLoadAsXml(carsInventoryDS);
			SaveAndLoadAsBinary(carsInventoryDS);
			ReadLine();

		}
		private static void FillDataSet(DataSet ds)
		{
			// Create data columns that map to the 
			// 'real' columns in the Inventory table 
			// of the AutoLot database.
			var carIDColumn = new DataColumn("CarID", typeof(int))
			{
				Caption = "Car ID",
				ReadOnly = true,
				AllowDBNull = false,
				Unique = true,
				AutoIncrement = true,
				AutoIncrementSeed = 1,
				AutoIncrementStep = 1
			};

			var carMakeColumn = new DataColumn("Make", typeof(string));
			var carColorColumn = new DataColumn("Color", typeof(string));
			var carPetNameColumn = new DataColumn("PetName", typeof(string))
			{ Caption = "Pet Name" };

			// Now add DataColumns to a DataTable.
			var inventoryTable = new DataTable("Inventory");
			inventoryTable.Columns.AddRange(new[]
				{carIDColumn, carMakeColumn, carColorColumn, carPetNameColumn});

			// Now add some rows to the Inventory Table.
			DataRow carRow = inventoryTable.NewRow();
			carRow["Make"] = "BMW";
			carRow["Color"] = "Black";
			carRow["PetName"] = "Hamlet";
			inventoryTable.Rows.Add(carRow);

			carRow = inventoryTable.NewRow();
			// Column 0 is the autoincremented ID field, 
			// so start at 1.
			carRow[1] = "Saab";
			carRow[2] = "Red";
			carRow[3] = "Sea Breeze";
			inventoryTable.Rows.Add(carRow);

			// Mark the primary key of this table.
			inventoryTable.PrimaryKey = new[] { inventoryTable.Columns[0] };

			// Finally, add our table to the DataSet.
			ds.Tables.Add(inventoryTable);
		}
		private static void ManipulateDataRowState()
		{
			// Create a temp DataTable for testing.
			var temp = new DataTable("Temp");
			temp.Columns.Add(new DataColumn("TempColumn", typeof(int)));

			// RowState = Detached. 
			var row = temp.NewRow();
			WriteLine($"After calling NewRow(): {row.RowState}");

			// RowState = Added.
			temp.Rows.Add(row);
			WriteLine($"After calling Rows.Add(): {row.RowState}");

			// RowState = Added.
			row["TempColumn"] = 10;
			WriteLine($"After first assignment: {row.RowState}");

			// RowState = Unchanged.
			temp.AcceptChanges();
			WriteLine($"After calling AcceptChanges: {row.RowState}");

			// RowState = Modified.
			row["TempColumn"] = 11;
			WriteLine($"After first assignment: {row.RowState}");

			// RowState = Deleted.
			temp.Rows[0].Delete();
			WriteLine($"After calling Delete: {row.RowState}");
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

			//Print out each table using rows and columns
			//foreach (DataTable dt in ds.Tables)
			//{
			//	WriteLine($"=> {dt.TableName} Table:");

			//	// Print out the column names.
			//	for (var curCol = 0; curCol < dt.Columns.Count; curCol++)
			//	{
			//		Write($"{dt.Columns[curCol].ColumnName}\t");
			//	}
			//	WriteLine("\n----------------------------------");

			//	// Print the DataTable.
			//	for (var curRow = 0; curRow < dt.Rows.Count; curRow++)
			//	{
			//		for (var curCol = 0; curCol < dt.Columns.Count; curCol++)
			//		{
			//			Write($"{dt.Rows[curRow][curCol]}\t");
			//		}
			//		WriteLine();
			//	}
			//}

			//Print out each table using data reader
			foreach (DataTable dt in ds.Tables)
			{
				WriteLine($"=> {dt.TableName} Table:");

				// Print out the column names.
				for (int curCol = 0; curCol < dt.Columns.Count; curCol++)
				{
					Write($"{dt.Columns[curCol].ColumnName.Trim()}\t");
				}
				WriteLine("\n----------------------------------");

				// Call our new helper method.
				PrintTable(dt);
			}
		}
		static void PrintTable(DataTable dt)
		{
			// Get the DataTableReader type.
			DataTableReader dtReader = dt.CreateDataReader();

			// The DataTableReader works just like the DataReader.
			while (dtReader.Read())
			{
				for (var i = 0; i < dtReader.FieldCount; i++)
				{
					Write($"{dtReader.GetValue(i).ToString().Trim()}\t");
				}
				WriteLine();
			}
			dtReader.Close();
		}
		static void SaveAndLoadAsXml(DataSet carsInventoryDS)
		{
			// Save this DataSet as XML.
			carsInventoryDS.WriteXml("carsDataSet.xml");
			carsInventoryDS.WriteXmlSchema("carsDataSet.xsd");

			// Clear out DataSet.
			carsInventoryDS.Clear();

			// Load DataSet from XML file.
			carsInventoryDS.ReadXml("carsDataSet.xml");
		}
		static void SaveAndLoadAsBinary(DataSet carsInventoryDS)
		{
			// Set binary serialization flag.
			carsInventoryDS.RemotingFormat = SerializationFormat.Binary;

			// Save this DataSet as binary.
			var fs = new FileStream("BinaryCars.bin", FileMode.Create);
			var bFormat = new BinaryFormatter();
			bFormat.Serialize(fs, carsInventoryDS);
			fs.Close();

			// Clear out DataSet.
			carsInventoryDS.Clear();

			// Load DataSet from binary file.
			fs = new FileStream("BinaryCars.bin", FileMode.Open);
			var data = (DataSet)bFormat.Deserialize(fs);
		}
	}
}
