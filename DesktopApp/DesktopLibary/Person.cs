using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesktopLibary
{
   public partial class Person
   {
      /// <summary>
      /// define person obj
      /// </summary>
      private string _FirstName = default(string);
      private string _LastName = default(string);
      private string _PhoneNumber = default(string);
      private Location _Address = default(Location);

      /// <summary>
      /// 
      /// </summary>
      public string FirstName { 
         get
         {
            return _FirstName;
         }
         set
         {
            _FirstName = value;
         }
      }
      public string LastName { 
         get
         {
            return _LastName;
         }
         set
         {
            _LastName = value;
         }
      }
      public string PhoneNumber { 
         get
         {
            return _PhoneNumber;
         }
         set
         {
            _PhoneNumber = value;
         }
      }
      public Location Address { 
         get
         {
            return _Address;
         }
         set
         {
            _Address = value;
         }
      }





     

   }
}
