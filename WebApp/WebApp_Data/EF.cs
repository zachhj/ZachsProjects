using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebApp_Data
{
   public static class EF
   {
      private static AdventureWorks2012Entities db = new AdventureWorks2012Entities();

      public static IEnumerable<Person> getPersonList()
      {
         return db.People.ToList();
      }
   }
}
