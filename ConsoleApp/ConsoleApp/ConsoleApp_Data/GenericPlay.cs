using ConsoleApp_Person;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_Data
{
   public class GenericPlay
   {
      public void Play()
      {
         var gl = new GenericLife<Person>();
         var p = new Person("Zachary", "Johnson", "Hiles");
         
         gl.Add(p);
         gl.Add(new Person("bill", "dlafsj", "aksdfj"));
         gl.Add(new Person("bob", "joe", "joe"));
         Console.WriteLine(gl.ToString());
         gl.Remove(p);
      }
   }
}
