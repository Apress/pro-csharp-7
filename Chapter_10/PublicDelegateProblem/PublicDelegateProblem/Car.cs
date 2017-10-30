using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PublicDelegateProblem
{
    public class Car
    {
        public delegate void CarEngineHandler( string msgForCaller );

        // Now a public member!
        public CarEngineHandler listOfHandlers;

        // Just fire out the Exploded notification.
        public void Accelerate( int delta )
        {
            if (listOfHandlers != null)
                listOfHandlers("Sorry, this car is dead...");
        }
    }
}
