using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_Data
{
   public class DelegateProgramming
   {

      /// <summary>
      /// 
      /// </summary>
      /// <returns></returns>
      public delegate string MessageBoard();//Func<string> blah();
      public delegate void BillBoard();//Action<> blah();

      
      public void RunDelegate(MessageBoard mb, BillBoard bb)
      {
         Console.WriteLine(mb());
         bb();

      }

      public void MessageDelegation(MessageBoard mb)
      {
         mb();
      }

      public void BillDelegation(BillBoard bb)
      {
         bb();
      }
   }
}
