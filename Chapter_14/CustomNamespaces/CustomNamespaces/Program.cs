using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Make use of types defined the MyShapes namespace.
using MyShapes;

// Resolve the ambiguity using a custom alias.
using The3DHexagon = My3DShapes.Hexagon;

namespace CustomNamespaces
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("This app does not really do anything...");
            Console.WriteLine("Just illustrating namespaces.");
            // This is really creating a My3DShapes.Hexagon class.
            The3DHexagon h2 = new The3DHexagon();

            Hexagon h = new Hexagon();
            Circle c = new Circle();
            Square s = new Square();
        }
    }
}
