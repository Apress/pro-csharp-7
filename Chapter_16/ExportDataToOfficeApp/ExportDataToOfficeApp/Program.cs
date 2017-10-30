using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Excel = Microsoft.Office.Interop.Excel;

namespace ExportDataToOfficeApp
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Car> carsInStock = new List<Car>
            {
                new Car {Color="Green", Make="VW", PetName="Mary"},
                new Car {Color="Red", Make="Saab", PetName="Mel"},
                new Car {Color="Black", Make="Ford", PetName="Hank"},
                new Car {Color="Yellow", Make="BMW", PetName="Davie"}
            };
            //ExportToExcelManual(carsInStock);
            ExportToExcel(carsInStock);
            Console.ReadLine();
        }

        static void ExportToExcel(List<Car> carsInStock)
        {
            // Load up Excel, then make a new empty workbook.
            Excel.Application excelApp = new Excel.Application();
            excelApp.Workbooks.Add();

            // This example uses a single workSheet. 
            Excel._Worksheet workSheet = excelApp.ActiveSheet;

            // Establish column headings in cells.
            workSheet.Cells[1, "A"] = "Make";
            workSheet.Cells[1, "B"] = "Color";
            workSheet.Cells[1, "C"] = "Pet Name";

            // Now, map all data in List<Car> to the cells of the spread sheet. 
            int row = 1;
            foreach (Car c in carsInStock)
            {
                row++;
                workSheet.Cells[row, "A"] = c.Make;
                workSheet.Cells[row, "B"] = c.Color;
                workSheet.Cells[row, "C"] = c.PetName;
            }

            // Give our table data a nice look and feel. 
            workSheet.Range["A1"].AutoFormat(Excel.XlRangeAutoFormat.xlRangeAutoFormatClassic2);

            // Save the file, quit Excel and display message to user. 
            workSheet.SaveAs($@"{Environment.CurrentDirectory}\Inventory.xlsx");
            excelApp.Quit();
            Console.WriteLine("The Inventory.xslx file has been saved to your app folder");
        }

        static void ExportToExcelManual(List<Car> carsInStock)
        {
            Excel.Application excelApp = new Excel.Application();

            // Must mark missing params! 
            excelApp.Workbooks.Add(Type.Missing);

            // Must cast Object as _Worksheet! 
            Excel._Worksheet workSheet = (Excel._Worksheet)excelApp.ActiveSheet;

            // Must cast each Object as Range object then call low level Value2 property!
            ((Excel.Range)excelApp.Cells[1, "A"]).Value2 = "Make";
            ((Excel.Range)excelApp.Cells[1, "B"]).Value2 = "Color";
            ((Excel.Range)excelApp.Cells[1, "C"]).Value2 = "Pet Name";

            int row = 1;
            foreach (Car c in carsInStock)
            {
                row++;
                // Must cast each Object as Range and call low level Value2 prop!
                ((Excel.Range)workSheet.Cells[row, "A"]).Value2 = c.Make;
                ((Excel.Range)workSheet.Cells[row, "B"]).Value2 = c.Color;
                ((Excel.Range)workSheet.Cells[row, "C"]).Value2 = c.PetName;
            }

            // Must call get_Range method and then specify all missing args!. 
            excelApp.Range["A1", Type.Missing].AutoFormat(Excel.XlRangeAutoFormat.xlRangeAutoFormatClassic2,
                Type.Missing, Type.Missing, Type.Missing,
                Type.Missing, Type.Missing, Type.Missing);

            // Must specify all missing optional args!  
            workSheet.SaveAs($@"{Environment.CurrentDirectory}\InventoryManual.xlsx",
                Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing,
                Type.Missing, Type.Missing, Type.Missing);
            excelApp.Quit();
            Console.WriteLine("The InventoryManual.xslx file has been saved to your app folder");
        }

    }
}
