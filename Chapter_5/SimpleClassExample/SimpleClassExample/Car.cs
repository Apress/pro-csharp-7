using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleClassExample
{
    class Car
    {
        // The 'state' of the Car.
        public string petName;

        public int currSpeed;

        #region Constructors

        // A custom default constructor.
        public Car()
        {
            petName = "Chuck";
            currSpeed = 10;
        }

        // Here, currSpeed will receive the
        // default value of an int (zero).
        public Car(string pn) => petName = pn;

        // Let caller set the full state of the Car.
        public Car(string pn, int cs)
        {
            petName = pn;
            currSpeed = cs;
        }

        #endregion

        // The functionality of the Car.
        // Using the expression-bodied member syntax introduced in C# 6
        public void PrintState()
            => Console.WriteLine("{0} is going {1} MPH.", petName, currSpeed);

        public void SpeedUp(int delta)
            => currSpeed += delta;
    }
}