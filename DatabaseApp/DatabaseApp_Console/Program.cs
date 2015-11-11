using ClassLibrary1;
using DatabaseApp_Data;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseApp_Console
{
   class Program
   {
      static void Main(string[] args)
      {

         AdoData ado = new AdoData();
         ado.DataWriter("akdjflkas", "1:00");



         //List<string> collums = new List<string>() { "ScreeningId", "MovieId", "RoomId", "Occupency", "StartTime", "EndTime"};
         //string table = "Theater.Screening";


         //var people = new {p};



         //EFData ef = new EFData();
         //ef.DataWriterSimple();


         //ef.GetMovie(table, collums);
         //(new AdoData()).DataWriter("Movie", "tester", "5:00:00");
         //Console.ReadLine();
         //foreach(var item in people)
         //{
         //   Console.WriteLine(item.ToString());
         //}

         //Console.Read();

      }
   }
}
