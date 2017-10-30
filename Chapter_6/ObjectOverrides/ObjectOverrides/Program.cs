using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOverrides
{
  #region Person class

  // Remember! Person extends Object.
  class Person
  {
    public string FirstName { get; set; } = "";
    public string LastName { get; set; } = "";
    public int Age { get; set; }
    public string SSN { get; set; } = "";

    public Person(string fName, string lName, int personAge)
    {
      FirstName = fName;
      LastName = lName;
      Age = personAge;
    }

    public Person()
    {
    }

    #region Object overrides 

    public override string ToString()
      => $"[First Name: {FirstName}; Last Name: {LastName}; Age: {Age}]";
    /*
      public override bool Equals(object obj)
      {
          if (obj is Person && obj != null)
          {
              Person temp;
              temp = (Person)obj;
              if (temp.FirstName == this.FirstName
                && temp.LastName == this.LastName
                && temp.Age == this.Age)
              {
                  return true;
              }
              else
              {
                  return false;
              }
          }
          return false;
      }
      */

    // No need to cast "obj" to a Person anymore,
    // as everything has a ToString() method.
    public override bool Equals(object obj) => obj?.ToString() == ToString();

    // Return a hash code based on a point of unique string data.
    public override int GetHashCode() => SSN.GetHashCode();

    #endregion
  }

  #endregion

  class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine("***** Fun with System.Object *****\n");

      // NOTE: We want these to be identical to test
      // the Equals() and GetHashCode() methods.
      Person p1 = new Person("Homer", "Simpson", 50);
      Person p2 = new Person("Homer", "Simpson", 50);

      // Get stringified version of objects.
      Console.WriteLine("p1.ToString() = {0}", p1.ToString());
      Console.WriteLine("p2.ToString() = {0}", p2.ToString());

      // Test overridden Equals().
      Console.WriteLine("p1 = p2?: {0}", p1.Equals(p2));

      // Test hash codes.
      Console.WriteLine("Same hash codes?: {0}", p1.GetHashCode() == p2.GetHashCode());
      Console.WriteLine();

      // Change age of p2 and test again.
      p2.Age = 45;
      Console.WriteLine("p1.ToString() = {0}", p1.ToString());
      Console.WriteLine("p2.ToString() = {0}", p2.ToString());
      Console.WriteLine("p1 = p2?: {0}", p1.Equals(p2));
      Console.WriteLine("Same hash codes?: {0}", p1.GetHashCode() == p2.GetHashCode());
      Console.ReadLine();
    }

    static void StaticMembersOfObject()
    {
      // Static members of System.Object.
      Person p3 = new Person("Sally", "Jones", 4);
      Person p4 = new Person("Sally", "Jones", 4);
      Console.WriteLine("P3 and P4 have same state: {0}", object.Equals(p3, p4));
      Console.WriteLine("P3 and P4 are pointing to same object: {0}",
        object.ReferenceEquals(p3, p4));
    }
  }
}