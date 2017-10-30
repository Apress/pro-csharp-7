using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Linq;

namespace ConstructingXmlDocs
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***** Fun making XML docs! *****");
            CreateFullXDocument();
            CreateRootAndChildren();
            MakeXElementFromArray();
            Console.WriteLine();

            ParseAndLoadExistingXml();
            Console.ReadLine();
        }

        #region Create full XDocument
        static void CreateFullXDocument()
        {
            XDocument inventoryDoc =
              new XDocument(
                new XComment("Current Inventory of cars!"),
                new XProcessingInstruction("xml-stylesheet",
                  "href='MyStyles.css' title='Compact' type='text/css'"),
                new XElement("Inventory",
                  new XElement("Car", new XAttribute("ID", "1"),
                    new XElement("Color", "Green"),
                    new XElement("Make", "BMW"),
                    new XElement("PetName", "Stan")
                  ),
                  new XElement("Car", new XAttribute("ID", "2"),
                    new XElement("Color", "Pink"),
                    new XElement("Make", "Yugo"),
                    new XElement("PetName", "Melvin")
                  )
                )
              );
            // Save to disk.
            inventoryDoc.Save("FullXmlDoc.xml");

        }
        #endregion

        #region Make XElement and save to disk.
        static void CreateRootAndChildren()
        {
            XElement inventoryDoc =
              new XElement("Inventory",
                new XComment("Current Inventory of cars!"),
                    new XElement("Car", new XAttribute("ID", "1"),
                    new XElement("Color", "Green"),
                    new XElement("Make", "BMW"),
                    new XElement("PetName", "Stan")
                  ),
                  new XElement("Car", new XAttribute("ID", "2"),
                    new XElement("Color", "Pink"),
                    new XElement("Make", "Yugo"),
                    new XElement("PetName", "Melvin")
                  )
              );

            // Save to disk.
            inventoryDoc.Save("SimpleInventory.xml");
        }
        #endregion

        #region Map array to XElement
        static void MakeXElementFromArray()
        {
            // Create an anonymous array of anonymous types.
            var people = new[] {
                new { FirstName = "Mandy", Age = 40},
                new { FirstName = "Andrew", Age  = 32 },
                new { FirstName = "Dave", Age  = 41 },
                new { FirstName = "Sara", Age  = 31}
            };

            //XElement peopleDoc =
            //  new XElement("People",
            //     from c in people select 
            //         new XElement("Person", new XAttribute("Age", c.Age), new XElement("FirstName", c.FirstName))
            //   );

            var arrayDataAsXElements = from c in people
                                       select
                                       new XElement("Person", 
                                           new XAttribute("Age", c.Age), 
                                           new XElement("FirstName", c.FirstName));
            
            XElement peopleDoc = new XElement("People", arrayDataAsXElements);
            Console.WriteLine(peopleDoc);
        }
        #endregion

        #region Parse / Load
        static void ParseAndLoadExistingXml()
        {
            // Build an XElement from string.
            string myElement =
              @"<Car ID ='3'>
                  <Color>Yellow</Color>
                  <Make>Yugo</Make>
                </Car>";
            XElement newElement = XElement.Parse(myElement);
            Console.WriteLine(newElement);
            Console.WriteLine();

            // Load the SimpleInventory.xml file.
            XDocument myDoc = XDocument.Load("SimpleInventory.xml");
            Console.WriteLine(myDoc);
        }
        #endregion
    }
}
