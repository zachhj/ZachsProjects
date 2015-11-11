using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
   public class EFData
   {

      public static AdventureWorks2012Entities context = new AdventureWorks2012Entities();

      public static OctoberDBEntities contextOctober = new OctoberDBEntities();

      public void GetPeople()
      {
         foreach(var item in context.People.ToList())
         {
            Console.WriteLine(item.FirstName + " " + item.LastName);
         }
      }



      public void GetPeopleLinq()
      {
         var people = from p in context.People
                      select new { p.FirstName, p.LastName };
                      
         foreach(var item in people)
         {
            Console.WriteLine(item);
         }

       }



      public void GetMovie(string table, List<string> c)
      {

         foreach (var item in contextOctober.Movies.ToList())
         {
            Console.WriteLine(item.Title + " " + item.Duration);
         }
      }


      public void GetMovieLinq()
      {
         var people = from p in contextOctober.Movies
                      select new { p.Title, p.Duration };

         foreach (var item in people)
         {
            Console.WriteLine(item);
         }

      }


      public void DataWriterSimple()
      {
         contextOctober.Movies.Add(new Movie() { Title = "friday the 16th", Duration = new TimeSpan(2, 0, 0) });
         contextOctober.SaveChanges();
      
      }

      public void DataWriterEnhanced()
      {
         var movie = contextOctober.Movies.Attach(new Movie() { Title = "friday the 16th", Duration = new TimeSpan(2, 0, 0) });
         
         contextOctober.Entry(movie).State = System.Data.Entity.EntityState.Added;
         contextOctober.SaveChanges();
      }



   }
}
