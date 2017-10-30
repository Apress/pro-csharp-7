using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

// For older DOM support.
using System.Xml;

// For newer LINQ to XML support. 
using System.Xml.Linq;

namespace BuildXmlDocExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***** A Tale of Two XML APIs *****");
            BuildXmlDocWithDOM();
            BuildXmlDocWithLINQToXml();

            // Test functionality from the VB library in this solution.
            VbXmlLiteralLibrary.XmlLiteralExample vbXml = new VbXmlLiteralLibrary.XmlLiteralExample();
            vbXml.MakeXmlFileUsingLiterals();

            Console.WriteLine("XML data saved to output directory.");

            // Delete a node. 
            DeleteNodeFromDoc();
            Console.ReadLine();
        }

        #region Build XML file using System.Xml.dll types.
        private static void BuildXmlDocWithDOM()
        {
            // Make a new XML document in memory.
            XmlDocument doc = new XmlDocument();

            // Fill this document with a root element
            // named <Inventory>.
            XmlElement inventory = doc.CreateElement("Inventory");

            // Now, make a sub element named <Car> with 
            // an ID attribute. 
            XmlElement car = doc.CreateElement("Car");
            car.SetAttribute("ID", "1000");

            // Build the data within the <Car> element. 
            XmlElement name = doc.CreateElement("PetName");
            name.InnerText = "Jimbo";
            XmlElement color = doc.CreateElement("Color");
            color.InnerText = "Red";
            XmlElement make = doc.CreateElement("Make");
            make.InnerText = "Ford";

            // Add <PetName>, <Color> and <Make> to the <Car>
            // element. 
            car.AppendChild(name);
            car.AppendChild(color);
            car.AppendChild(make);

            // Add the <Car> element to the <Inventory> element. 
            inventory.AppendChild(car);

            // Insert the complete XML into the XmlDocument object,
            // and save to file. 
            doc.AppendChild(inventory);
            doc.Save("Inventory.xml");
        }
        #endregion

        #region Build XML doc with LINQ to XML
        private static void BuildXmlDocWithLINQToXml()
        {
            // Create a 'functional' XML document.
            XElement doc =
                new XElement("Inventory",
                    new XElement("Car", new XAttribute("ID", "1000"),
                        new XElement("PetName", "Jimbo"),
                        new XElement("Color", "Red"),
                        new XElement("Make", "Ford")
                    )
                );

            // Save to file.
            doc.Save("InventoryWithLINQ.xml");
        }
        #endregion

        #region Remove an element.
        private static void DeleteNodeFromDoc()
        {
            // Create a 'functional' XML document.
            XElement doc =
                new XElement("Inventory",
                    new XElement("Car", new XAttribute("ID", "1000"),
                        new XElement("PetName", "Jimbo"),
                        new XElement("Color", "Red"),
                        new XElement("Make", "Ford")
                    )
                );

            // Delete the PetName element from the tree. 
            doc.Descendants("PetName").Remove();
            Console.WriteLine(doc);
        }
        #endregion
    }
}
