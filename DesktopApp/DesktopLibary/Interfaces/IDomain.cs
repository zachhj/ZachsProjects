using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesktopLibary.Interfaces
{

      public interface IDomain
      {
         bool AddPerson(Person person);
         bool DeletePerson(Person person);
         List<Person> ListPeople();
      }
   
}
