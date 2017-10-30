using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Collections;

namespace IssuesWithNonGenericCollections
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***** Issues with Non-Generic Collections *****\n");
            UsePersonCollection();
            Console.WriteLine();
            UseGenericList();

            Console.ReadLine();
        }

        #region Simple Box / Unbox
        private static void SimpleBoxUnboxOperation()
        {
            // Make a int value type.
            int myInt = 25;

            // Box the int into an object reference.
            object boxedInt = myInt;

            // Unbox in the wrong data type to trigger
            // runtime exception. 
            try
            {
                long unboxedInt = (long)boxedInt;
            }
            catch (InvalidCastException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        #endregion

        #region ArrayList box / unbox
        static void WorkWithArrayList()
        {
            // Value types are automatically boxed when
            // passed to a member requesting an object.
            ArrayList myInts = new ArrayList();
            myInts.Add(10);
            myInts.Add(20);
            myInts.Add(35);
            Console.ReadLine();
        }
        #endregion

        #region ArrayList of random objects
        static void ArrayListOfRandomObjects()
        {
            // The ArrayList can hold anything at all.
            ArrayList allMyObjects = new ArrayList();
            allMyObjects.Add(true);
            allMyObjects.Add(new OperatingSystem(PlatformID.MacOSX, new Version(10, 0)));
            allMyObjects.Add(66);
            allMyObjects.Add(3.14);
        }
        #endregion

        #region Use custom generic class
        static void UsePersonCollection()
        {
            Console.WriteLine("***** Custom Person Collection *****\n");
            PersonCollection myPeople = new PersonCollection();
            myPeople.AddPerson(new Person("Homer", "Simpson", 40));
            myPeople.AddPerson(new Person("Marge", "Simpson", 38));
            myPeople.AddPerson(new Person("Lisa", "Simpson", 9));
            myPeople.AddPerson(new Person("Bart", "Simpson", 7));
            myPeople.AddPerson(new Person("Maggie", "Simpson", 2));

            // This would be a compile-time error!
            // myPeople.AddPerson(new Car());

            foreach (Person p in myPeople)
                Console.WriteLine(p);
        }
        #endregion

        #region Use generic list
        static void UseGenericList()
        {
            Console.WriteLine("***** Fun with Generics *****\n");
            // This List<> can only hold Person objects.
            List<Person> morePeople = new List<Person>();
            morePeople.Add(new Person("Frank", "Black", 50));
            Console.WriteLine(morePeople[0]);

            // This List<> can only hold numeric data.
            List<int> moreInts = new List<int>();
            moreInts.Add(10);
            moreInts.Add(2);
            int sum = moreInts[0] + moreInts[1];

            // Compile-time error! Can't add Person object
            // to a list of ints!
            //moreInts.Add(new Person());
        }
        #endregion
    }
}
