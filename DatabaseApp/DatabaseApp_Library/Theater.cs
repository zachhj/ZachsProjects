using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseApp_Library
{
   public static class Theater
   {

      private static List<Movie> Movies = new List<Movie>();
      private static List<Room> Rooms = new List<Room>();
      public static Dictionary<Movie, List<Screening>> Screenings = new Dictionary<Movie, List<Screening>>();

      public static void AddScreening(Screening s)
      {
         
         if(Screenings.ContainsKey(s.Showing))
         {
            Screenings[s.Showing].Add(s);
            return;
         }
         Screenings.Add(s.Showing, new List<Screening>() { s } );
      }

      public static void TicketSale(Screening s, int num)
      {
         if(s.CheckCapacity(num))
         {
            s.Occupency += num;
         }

      }
   }
}
