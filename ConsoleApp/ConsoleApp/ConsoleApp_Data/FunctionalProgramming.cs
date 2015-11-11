using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_Data
{
   public class FunctionalProgramming
   {

      //Functions
      Func<string> greetings = () =>
         {
            var result = "Good Morning";
            if (DateTime.Now.Hour > 12)
            {
               result = "Good Afternoon";
            }
            return result;
         };


      Func<string> goodbyes = () => { return "Good Day"; };


      Func<double, double, double> add = (double a, double b) => { return a + b; };
      Func<double, double, double> subtract = (double a, double b) => { return a - b; };

      //function with no return type
      Action<string> ConsoleOutput = (string hello) => { Console.WriteLine(hello); };

      //Methods

      public string Culture()
      {
         return greetings();
      }

      public string Culture(Func<string> greet)
      {
         return greet();
      }

      public double Arithmetic(Func<double, double, double> compute, double a, double b)
      {
         return compute(a,b);
      }

      public void ConsoleOutput2(string hello)
      {
         Console.WriteLine("--" + hello + "--");
      }

      public void RunConsole()
      {
         Consolo(ConsoleOutput, "say hello to my little friend");
         Consolo(ConsoleOutput2, "say hello to my little friend");
      }
   
      public void Consolo(Action<string> present , string message)
      {
         present(message);
      }
   
   }
}
