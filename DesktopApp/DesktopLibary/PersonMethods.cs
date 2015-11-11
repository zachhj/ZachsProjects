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
      /// 
      /// </summary>
      /// <returns></returns>
      public override string ToString()
      {
         return string.Format("{0} {1}\r\n{2}\r\n{3}", FirstName, LastName, PhoneNumber, Address);
      }
   }
}
