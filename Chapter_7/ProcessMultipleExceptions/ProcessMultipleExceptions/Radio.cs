using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProcessMultipleExceptions
{
    class Radio
    {
        public void TurnOn(bool on)
        {
          Console.WriteLine(on ? "Jamming..." : "Quiet time...");
        }
    }
}
