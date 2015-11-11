
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Desktop_Data
{
   public static class DataAccess
   {
      private static string path = "C:\\multivision\\book.txt";
     
         
         
      public static void SaveBook(List<string> people)
      {
         var book = new StringBuilder();
         foreach(var item in people)
         {
            book.Append(item.ToString());

         }
         book.Append("//end of entry");
         File.WriteAllText(path, book.ToString());
      }


      public static List<string> RetrieveBook()
      {
        return File.ReadAllLines(path).ToList();
      }

   }
}
