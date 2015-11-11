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

      //fields
      //private string FirstName = default(String);
      //private string LastName = default(String);


      //backing fields
      private string _FirstName = default(string);
      private string _LastName = default(string);
      private string _MiddleName = default(string);



      //properties
      public string FirstName
      {
         get
         {
            return _FirstName;
         }
         set
         {
            var result = NameCheck(value);

            if (!string.IsNullOrWhiteSpace(result))
            {
               _FirstName = result;
            }
         }
      }

      public string LastName
      {
         get
         {
            return _LastName;
         }
         set
         {
            var result = NameCheck(value);

            if (!string.IsNullOrWhiteSpace(result))
            {
               _LastName = result;
            }
         }
      }

      public string MiddleName
      {
         get
         {
            return _MiddleName;
         }
         set
         {
            var result = NameCheck(value);

            if (!string.IsNullOrWhiteSpace(result))
            {
               _MiddleName = result;
            }
         }
      }




   }
}
