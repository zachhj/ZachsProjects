using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_Person
{
   public class Shape
   {

      public int NumberOfSides { get; private set; }

      //constroctors
      public Shape()
      {

      }
      public Shape(int sides)
      {
         NumberOfSides = sides;
      }

      //methods
      public virtual double Perimeter()
      {
         throw new NotImplementedException();
      }

      public virtual double Volume()
      {
         throw new NotImplementedException();
      }



      public override string ToString()
      {
         return string.Format("perimeter: {0}", Perimeter());
      }
   }
}
