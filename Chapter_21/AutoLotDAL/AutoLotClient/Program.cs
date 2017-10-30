using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using AutoLotDAL.BulkImport;
using AutoLotDAL.DataOperations;
using AutoLotDAL.Models;

namespace AutoLotClient
{
    class Program
    {
        static void Main(string[] args)
        {
            InventoryDAL dal = new InventoryDAL();
            var list = dal.GetAllInventory();
            Console.WriteLine(" ************** All Cars ************** ");
            Console.WriteLine("CarId\tMake\tColor\tPet Name");
            foreach (var itm in list)
            {
                Console.WriteLine($"{itm.CarId}\t{itm.Make}\t{itm.Color}\t{itm.PetName}");
            }
            Console.WriteLine();
            var car = dal.GetCar(list.OrderBy(x => x.Color).Select(x => x.CarId).First());
            Console.WriteLine(" ************** First Car By Color ************** ");
            Console.WriteLine("CarId\tMake\tColor\tPet Name");
            Console.WriteLine($"{car.CarId}\t{car.Make}\t{car.Color}\t{car.PetName}");

            try
            {
                dal.DeleteCar(5);
                Console.WriteLine("Car deleted.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An exception occurred: {ex.Message}");
            }
            //dal.InsertAuto(new Car {Color = "Blue", Make = "Pilot", PetName = "TowMonster"});
            //list = dal.GetAllInventory();
            //var newCar = list.First(x => x.PetName == "TowMonster");
            //Console.WriteLine(" ************** New Car ************** ");
            //Console.WriteLine("CarId\tMake\tColor\tPet Name");
            //Console.WriteLine($"{newCar.CarId}\t{newCar.Make}\t{newCar.Color}\t{newCar.PetName}");
            //dal.DeleteCar(newCar.CarId);
            var petName = dal.LookUpPetName(car.CarId);
            Console.WriteLine(" ************** New Car ************** ");
            Console.WriteLine($"Car pet name: {petName}");
            DoBulkCopy();
            //MoveCustomer();
            Console.Write("Press enter to continue...");
            Console.ReadLine();
        }

        public static void MoveCustomer()
        {
            Console.WriteLine("***** Simple Transaction Example *****\n");

            // A simple way to allow the tx to succeed or not.
            bool throwEx = true;

            Console.Write("Do you want to throw an exception (Y or N): ");
            var userAnswer = Console.ReadLine();
            if (userAnswer?.ToLower() == "n")
            {
                throwEx = false;
            }

            var dal = new InventoryDAL();

            // Process customer 1 – enter the id for the customer to move.
            dal.ProcessCreditRisk(throwEx, 1);
            Console.WriteLine("Check CreditRisk table for results");
            Console.ReadLine();
        }

        public static void DoBulkCopy()
        {
            Console.WriteLine(" ************** Do Bulk Copy ************** ");
            var cars = new List<Car>
            {
                new Car() {Color = "Blue", Make = "Honda", PetName = "MyCar1"},
                new Car() {Color = "Red", Make = "Volvo", PetName = "MyCar2"},
                new Car() {Color = "White", Make = "VW", PetName = "MyCar3"},
                new Car() {Color = "Yellow", Make = "Toyota", PetName = "MyCar4"}
            };
            ProcessBulkImport.ExecuteBulkImport(cars, "Inventory");
            InventoryDAL dal = new InventoryDAL();
            var list = dal.GetAllInventory();
            Console.WriteLine(" ************** All Cars ************** ");
            Console.WriteLine("CarId\tMake\tColor\tPet Name");
            foreach (var itm in list)
            {
                Console.WriteLine($"{itm.CarId}\t{itm.Make}\t{itm.Color}\t{itm.PetName}");
            }
            Console.WriteLine();
        }
    }
}