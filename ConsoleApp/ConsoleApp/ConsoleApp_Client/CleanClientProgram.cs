using ConsoleApp_Person;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ConsoleApp_Client
{
   class CleanClientProgram
   {

      public void DispalyName()
      {
         var p = new Person("Zachary", "Johnson", "Hiles");

         Console.WriteLine(p);
      }


      public static void ShapeShifter(Shape s)
      {
         Console.WriteLine(s);
      }

      public static void DisplayShape()
      {
         var s = new Shape();
         var r = new Rectangle();

         ShapeShifter(r);
      }

      public static void Capatalize()
      {
         var s = "hello";
         s.Capitalize();

      }
   
   

   }
}
