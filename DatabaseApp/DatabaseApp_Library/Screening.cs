using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseApp_Library
{
   public class Screening
   {

      public Room Location { get; set; }
      public Movie Showing { get; set; }
      public int Occupency { get; set; }
      public DateTime StartTime { get; set; }
      public DateTime EndTime 
      { 
         get
         {
            return StartTime.Add(Showing.Duration.TimeOfDay);
         } 
       }

      public bool CheckCapacity(int num)
      {

         return (Location.Capactity - Occupency) >= num;
      }


   }
}
