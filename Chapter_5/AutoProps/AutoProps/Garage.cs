using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoProps
{
    #region First iteration of Garage class 
    /*
    class Garage
    {
        // The hidden backing field is set to zero!
        public int NumberOfCars { get; set; }

        // The hidden backing field is set to null!
        public Car MyAuto { get; set; }

        // Must use constructors to override default 
        // values assigned to hidden backing fields.
        public Garage()
        {
            MyAuto = new Car();
            NumberOfCars = 1;
        }
        public Garage(Car car, int number)
        {
            MyAuto = car;
            NumberOfCars = number;
        }
    }
    */
    #endregion

    #region Second Iteration of Garage class
    class Garage
    {
        // The hidden backing field is set to one!
        public int NumberOfCars { get; set; } = 1;

        // The hidden backing field is set to a new Car object!
        public Car MyAuto { get; set; } = new Car();

        public Garage(){}
        public Garage(Car car, int number)
        {
            MyAuto = car;
            NumberOfCars = number;
        }
    }
    #endregion
}
