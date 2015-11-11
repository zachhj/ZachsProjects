using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_Person
{
   public static class StringExtension
   {
      public static string Capitalize(this string value)
      {
         //var lower = value.ToLowerInvariant();
         //var sub = lower.Substring(1);
         //var cap = lower.Substring(0, 1).ToUpperInvariant();
         //return cap + sub;

         string lower = value.ToLowerInvariant();
         var cap = lower.Split();
        
         var FinalString = cap[0].Substring(0, 1).ToUpperInvariant() + cap[0].Substring(1);
         if(cap.Length > 1)
         {
            var j = cap.Length;
            for(int i = 1; i <= j ; i++)
            {
               FinalString += cap[i].Substring(0, 1).ToUpperInvariant() + cap[i].Substring(1);
            }

         }
         return FinalString;
      }



   }
}
