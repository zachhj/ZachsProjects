using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesktopLibary
{
   public partial class Location
   {

      public override string ToString()
      {
         return string.Format("{0}\r\n{1}, {2} {3}\n", Street, City, State, Areacode);
      }

   }
}
