using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomInterface
{
    class Fork : IPointy
    {
        public byte Points
        {
            get { return 4; }
        }
    }

    class PitchFork : IPointy
    {
        public byte Points
        {
            get { return 3; }
        }
    }

    class Knife : IPointy
    {
        public byte Points
        {
            get { return 1; }
        }
    }
}
