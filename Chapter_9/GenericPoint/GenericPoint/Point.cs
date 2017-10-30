using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericPoint
{
    // A generic Point structure.
    public struct Point<T>
    {
        // Generic properties 
        public T X { get; set; }
        public T Y { get; set; }

        // Generic constructor.
        public Point(T xVal, T yVal)
        {
            X = xVal;
            Y = yVal;
        }

        public override string ToString() => $"[{X}, {Y}]";

        // Reset fields to the default value of the
        // type parameter.
        public void ResetPoint()
        {
            X = default(T);
            Y = default(T);
        }
    }
}
