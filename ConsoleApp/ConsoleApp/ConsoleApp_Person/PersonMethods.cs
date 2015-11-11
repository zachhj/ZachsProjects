using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ConsoleApp_Person
{
   public partial class Person
   {


      public Person(string firstName, string lastName, string middleName)
      {
         FirstName = firstName;
         LastName = lastName;
         MiddleName = middleName;
      }


      //methods

      public string NameCheck(string n)
      {
         var regex = new Regex("[a-zA-Z]+");
         var result = regex.Match(n).Value;
         return result;
      }

      override public string ToString()
      {
         return string.Format("{0} {2} {1}", this._FirstName, this._LastName, this._MiddleName);
      }
   }
}
