using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticDataAndMembers
{
    // A simple savings account class.
    class SavingsAccount
    {
        // Instance level data. 
        public double currBalance;

        // A static point of data.
        public static double currInterestRate;

        // A static constructor!
        static SavingsAccount()
        {
            Console.WriteLine("In static ctor!");
            currInterestRate = 0.04;
        }

        public SavingsAccount(double balance)
        {
            currBalance = balance;
        }

        #region Get / Set methods for interest rate
        // Static members to get/set interest rate.
        public static void SetInterestRate(double newRate)
        { currInterestRate = newRate; }

        public static double GetInterestRate()
        { return currInterestRate; }
        #endregion

        // A static property.
        public static double InterestRate
        {
            get { return currInterestRate; }
            set { currInterestRate = value; }
        }
    }
}
