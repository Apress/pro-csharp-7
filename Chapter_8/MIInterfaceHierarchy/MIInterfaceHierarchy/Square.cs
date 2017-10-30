using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MIInterfaceHierarchy
{
    class Square : IShape
    {
        // Using explicit implementation to handle member name clash.
        void IPrintable.Draw()
        {
            // Draw to printer ...
        }
        void IDrawable.Draw()
        {
            // Draw to screen ...
        }
        public void Print()
        {
            // Print ...
        }

        public int GetNumberOfSides()
        { return 4; }
    }
}