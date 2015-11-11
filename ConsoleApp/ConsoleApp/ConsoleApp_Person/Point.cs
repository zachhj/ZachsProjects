using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ConsoleApp_Person
{
   /// <summary>
   /// 
   /// </summary>
   struct Point
   {
      //properties
      public int Xcoord;
      public int Ycoord;

      //constructors
      public Point(int x, int y)
      {
         Xcoord = x;
         Ycoord = y;
      }



      //methods
      public double Distance()
      {
         return Math.Sqrt(Xcoord * Xcoord + Ycoord * Ycoord);
      }
   }
}
