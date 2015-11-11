using System;

using ConsoleApp_Person;
using ConsoleApp_Data;

namespace ConsoleApp_Client
{
   internal class Program
   {
      static void Main(string[] args)
      {
         Events();

         Console.ReadLine();
         Person p = new Person("Zach","johnson", "h");
         string  v = p.FirstName;
      }

      public static void Generics()
      {
         (new GenericPlay()).Play();
      }
   
      public static void Programming()
      {
         (new FunctionalProgramming()).RunConsole();
      }
      public static void Delegates()
      {
         var d = new DelegateProgramming();

         d.RunDelegate(() => { return "message received"; }, () => { Console.WriteLine("bill recieved"); });
      }

      public static void TryOuts()
      {

      }

      public static void Events()
      {
         var eb = new EventBroadcaster();
         var er = new EventReceiver();
         var fr = new PhantomBroadcaster();

         er.Subscribe(eb);
         fr.Publish(eb);
         eb.Publish();
      }
   }



   
}
