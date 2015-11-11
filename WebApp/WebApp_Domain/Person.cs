﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebApp_Domain
{
   public class Person
   {

      public string FirstName { get; set; }
      public string LastName { get; set; }

      public Person(string f, string l)
      {
         FirstName = f;
         LastName = l;
      }


      public override string ToString()
      {
         return string.Format("{0} {1}", FirstName, LastName);
      }
   }
}
