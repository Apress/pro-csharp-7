using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomConversions
{
    class Program
    {
        static void Main( string[] args )
        {
            Console.WriteLine("***** Fun with Conversions *****\n");

            // Make a Rectangle.
            Rectangle r = new Rectangle(15, 4);
            Console.WriteLine(r.ToString());
            r.Draw();

            Console.WriteLine();

            // Convert r into a Square,
            // based on the height of the Rectangle.
            Square s = (Square)r;
            Console.WriteLine(s.ToString());
            s.Draw();
            Console.WriteLine();

            // Convert Rectangle to Square to invoke method.
            Rectangle rect = new Rectangle(10, 5);
            DrawSquare((Square)rect);
            Console.WriteLine();

            // Converting an int to a Square.
            Square sq2 = (Square)90;
            Console.WriteLine("sq2 = {0}", sq2);

            // Converting a Square to a int.
            int side = (int)sq2;
            Console.WriteLine("Side length of sq2 = {0}", side);
            Console.WriteLine();

            Square s3 = new Square {Length = 83};

            // Attempt to make an implicit cast?
            Rectangle rect2 = s3;

            Console.ReadLine();
        }

        // This method requires a Square type.
        static void DrawSquare( Square sq )
        {
            Console.WriteLine(sq.ToString());
            sq.Draw();
        }

    }
}
