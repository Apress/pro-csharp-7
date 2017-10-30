using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoLotDAL3.DataSets;
using AutoLotDAL3.DataSets.AutoLotDataSetTableAdapters;
using static System.Console;

namespace LinqToDataSetApp
{
	class Program
	{
		static void Main(string[] args)
		{
			WriteLine("***** LINQ over DataSet *****\n");

			// Get a strongly typed DataTable containing the current Inventory
			// of the AutoLot database.
			AutoLotDataSet dal = new AutoLotDataSet();
			InventoryTableAdapter tableAdapter = new InventoryTableAdapter();
			AutoLotDataSet.InventoryDataTable data = tableAdapter.GetData();

			// Print all car ids.
			PrintAllCarIDs(data);
			WriteLine();

			// Show all red cars.
			ShowRedCars(data);
			WriteLine();

			BuildDataTableFromQuery(data);
			WriteLine();

			ReadLine();

		}
		static void PrintAllCarIDs(DataTable data)
		{
			// Get enumerable version of DataTable.
			EnumerableRowCollection enumData = data.AsEnumerable();

			// Print the car ID values.
			foreach (DataRow r in enumData)
			{
				WriteLine($"Car ID = {r["CarID"]}");
			}
		}
		static void ShowRedCars(DataTable data)
		{
			// Project a new result set containing
			// the ID/Make for rows where Color == Red.
			var cars = from car in data.AsEnumerable()
					   where
						 car.Field<string>("Color") == "Black"
					   select new
					   {
						   ID = car.Field<int>("CarID"),
						   Make = car.Field<string>("Make")
					   };


			WriteLine("Here are the red cars we have in stock:");
			foreach (var item in cars)
			{
				WriteLine($"-> CarID = {item.ID} is {item.Make}");
			}
		}
		static void BuildDataTableFromQuery(DataTable data)
		{
			var cars = from car in data.AsEnumerable()
					   where car.Field<int>("CarID") > 5
					   select car;

			// Use this result set to build a new DataTable.
			DataTable newTable = cars.CopyToDataTable();

			// Print the DataTable.
			for (var curRow = 0; curRow < newTable.Rows.Count; curRow++)
			{
				for (var curCol = 0; curCol < newTable.Columns.Count; curCol++)
				{
					Write(newTable.Rows[curRow][curCol].ToString().Trim() + "\t");
				}
				WriteLine();
			}
		}

	}
}
