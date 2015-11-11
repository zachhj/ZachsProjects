using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_Person
{
   public class Rectangle : Shape
   {
      public double Length {get; set;}
      public double Width {get; set;}
      //constructor
      public Rectangle() : base(4)
      {

      }

      //
      override public double Volume()
      {
         return Length * Width;
      }

      override public double Perimeter()
      {
         return 2 * (Length + Width);
      }

   }
}
