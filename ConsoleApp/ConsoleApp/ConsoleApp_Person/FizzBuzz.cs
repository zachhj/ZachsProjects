using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzz
{
   class Program
   {
      


      private void FizzBuz()
      {
         var input = Console.ReadLine();
         var i = int.Parse(input);

         for (int j = 1; j <= i; j++)
         {

            if (j % 3 == 0)
            {
               Console.Write("Fizz");
            }

            if (j % 5 == 0)
            {
               Console.Write("Buzz");
            }

            if (j % 3 != 0 && j % 5 != 0) { Console.Write(j); }

            Console.WriteLine();
         }
      }
   }

}