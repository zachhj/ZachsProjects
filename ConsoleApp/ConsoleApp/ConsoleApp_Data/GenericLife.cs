using ConsoleApp_Person;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_Data
{
   public class GenericLife<T> where T : Person
   {

      private List<T> GenericList = new List<T>();

      public void Add(T value)
      {
         GenericList.Add(value);
      }

      public void Remove(T value)
      {
         GenericList.Remove(value);
      }

      public void List()
      {
         GenericList.ToList();
      }

      public override string ToString()
      {
         var s = new StringBuilder();
         foreach(var item in GenericList)
         {
            s.AppendLine(item.ToString());
         }
         return s.ToString();  
      }


   }
}
