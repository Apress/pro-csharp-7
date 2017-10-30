using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employees
{
    // Managers need to know their number of stock options.
    class Manager : Employee
    {
        #region constructors 
        public Manager()
        {

        }

        public Manager(string fullName, int age, int empID,
                       float currPay, string ssn, int numbOfOpts)
          : base(fullName, age, empID, currPay, ssn)
        {
            // This property is defined by the Manager class.
            StockOptions = numbOfOpts;
        }
        #endregion

        public int StockOptions { get; set; }

        public override void GiveBonus(float amount)
        {
            base.GiveBonus(amount);
            Random r = new Random();
            StockOptions += r.Next(500);
        }
        public override void DisplayStats()
        {
            base.DisplayStats();
            Console.WriteLine("Number of Stock Options: {0}", StockOptions);
        }
    }
}
