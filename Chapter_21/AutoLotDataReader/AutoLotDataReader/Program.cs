using System;
using System.Data.SqlClient;
using static System.Console;

namespace AutoLotDataReader
{
	class Program
	{
		static void FirstVersion()
		{
			WriteLine("***** Fun with Data Readers *****\n");
			// Create and open a connection.
			using (SqlConnection connection = new SqlConnection())
			{
				connection.ConnectionString =
                    @"Data Source=(localdb)\mssqllocaldb;Integrated Security=true;" +
					"Initial Catalog=AutoLot";
				connection.Open();

				// Create a SQL command object.
				string sql = "Select * From Inventory";
				SqlCommand myCommand = new SqlCommand(sql, connection);

				// Obtain a data reader a la ExecuteReader().
				using (SqlDataReader myDataReader = myCommand.ExecuteReader())
				{
					// Loop over the results.
					while (myDataReader.Read())
					{
						WriteLine($"-> Make: {myDataReader["Make"]}, PetName: {myDataReader["PetName"]}, Color: {myDataReader["Color"]}.");
					}
				}
			}
			ReadLine();
		}
		static void Main(string[] args)
		{
			WriteLine("***** Fun with Data Readers *****\n");
			// Create a connection string via the builder object.
			var cnStringBuilder = new SqlConnectionStringBuilder
			{
				InitialCatalog = "AutoLot",
				DataSource = @"(localdb)\mssqllocaldb",
				ConnectTimeout = 30,
				IntegratedSecurity = true
			};

			// Create an open a connection.
			using (var connection = new SqlConnection())
			{
				connection.ConnectionString = cnStringBuilder.ConnectionString;
				connection.Open();
				ShowConnectionStatus(connection);

				// Create a SQL command object.
				string sql = "Select * From Inventory;Select * from Customers";

				using (SqlCommand myCommand = new SqlCommand(sql, connection))
				{
					//iterate over the inventory & customers
					// Obtain a data reader a la ExecuteReader().
					using (SqlDataReader myDataReader = myCommand.ExecuteReader())
					{
						do
						{
							while (myDataReader.Read())
							{
								WriteLine("***** Record *****");
								for (int i = 0; i < myDataReader.FieldCount; i++)
								{
									WriteLine($"{myDataReader.GetName(i)} = {myDataReader.GetValue(i)}");
								}
								WriteLine();
							}
						} while (myDataReader.NextResult());
					}
				}
			}
			ReadLine();

		}
		static void ShowConnectionStatus(SqlConnection connection)
		{
			// Show various stats about current connection object.
			WriteLine("***** Info about your connection *****");
			WriteLine($"Database location: {connection.DataSource}");
			WriteLine($"Database name: {connection.Database}");
			WriteLine($"Timeout: {connection.ConnectionTimeout}");
			WriteLine($"Connection state: {connection.State}\n");
		}

	}
}
