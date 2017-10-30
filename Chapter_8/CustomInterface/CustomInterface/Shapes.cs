using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomInterface
{
    // The abstract base class of the hierarchy.
    abstract class Shape
    {
        public Shape(string name = "NoName")
        { PetName = name; }

        public string PetName { get; set; }

        // Force all child classes to define how to be rendered.
        public abstract void Draw();
    }

    #region Circle class
    class Circle : Shape
    {
        public Circle() { }
        public Circle(string name) : base(name) { }
        public override void Draw()
        {
            Console.WriteLine("Drawing {0} the Circle", PetName);
        }
    }
    #endregion

    #region Hexagon class 
    class Hexagon : Shape, IPointy, IDraw3D
    {
        public Hexagon() { }
        public Hexagon(string name) : base(name) { }
        public override void Draw()
        {
            Console.WriteLine("Drawing {0} the Hexagon", PetName);
        }
        // IPointy implementation.
        public byte Points
        {
            get { return 6; }
        }
        public void Draw3D()
        { Console.WriteLine("Drawing Hexagon in 3D!"); }
    }
    #endregion

    #region 3D circle
    class ThreeDCircle : Circle, IDraw3D
    {
        // Hide the PetName property above me.
        public new string PetName { get; set; }

        // Hide any Draw() implementation above me.
        public new void Draw()
        {
            Console.WriteLine("Drawing a 3D Circle");
        }
        public void Draw3D()
        { Console.WriteLine("Drawing Circle in 3D!"); }
    }
    #endregion
}
