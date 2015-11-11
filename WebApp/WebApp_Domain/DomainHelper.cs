using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebApp_Data;

namespace WebApp_Domain
{
   public static class DomainHelper
   {

      private static Dictionary<string, Person> gp = new Dictionary<string, Person>();
      private static IEnumerable<Person> p = null;


      public static IEnumerable<Person> PersonLoader()
      {
         if (p == null)
         {
            List<Person> ip = new List<Person>();
            var pl = EF.getPersonList();

            foreach (var item in pl)
            {
               ip.Add(new Person(item.FirstName, item.LastName));
            }

            p = ip;
         }

         return p;
      }

      public static bool CheckPerson(string first, string last)
      {
         if(p == null)
         {
            PersonLoader();
         }

         return p.Any(i => i.FirstName == first && i.LastName == last);
      }

      public static string MakeCookie(string f, string l)
      {
         var g = Guid.NewGuid();
         gp.Add(g.ToString(), new Person(f, l));

         return g.ToString();
      }

      public static bool checkUser(string g)
      {
         return gp.ContainsKey(g);
      }


   }
}
