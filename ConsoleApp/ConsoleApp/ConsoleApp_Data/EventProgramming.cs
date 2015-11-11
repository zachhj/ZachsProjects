using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleApp_Data
{

public class EventBroadcaster
   {
      public delegate void TickHandler(); //Transmition 
      public event TickHandler TickEvent; //Trigger/Broadcast

      public void Publish()
      {
         var count = 1;

         while (count < 6)
         {
            Thread.Sleep(2000);
            TickEvent();
            count++;
         }
      }
   }

   public class EventPlanner
   {
      public delegate void MethodHandler();
      public event MethodHandler MethodEvent;

      public void Publish()
      {

      }
   }

   public class EventReceiver
   {
      public void Subscribe(EventBroadcaster tick)
      {
         tick.TickEvent += EventHandling;
      }

      public void EventHandling()
      {

         Console.WriteLine("tick event raised");
      }

   }

   public class PhantomBroadcaster
   {
      public void Subscribe(EventBroadcaster tick)
      {
         tick.TickEvent += EventSpooky;
      }
      

      public void EventSpooky()
      {
         Console.ForegroundColor = ConsoleColor.Black;
         Console.BackgroundColor = ConsoleColor.DarkRed;
         Console.WriteLine("spooky");
      }
   }
}
