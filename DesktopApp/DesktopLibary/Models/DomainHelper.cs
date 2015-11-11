using Desktop_Data;
using DesktopLibary.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesktopLibary.Models
{
   public class DomainHelper : IDomain
   {
      private static List<Person> AddressBook = new List<Person>();

      /// <summary>
      /// 
      /// </summary>
      /// <param name="person"></param>
      /// <returns></returns>
      public bool AddPerson(Person person)
      {
        
         try
         {
          AddressBook.Add(person);
          DomainAdapter.SaveBookXml(AddressBook);
         }
         catch(Exception)
         {
            return false;
         }

         return true;


      }
      /// <summary>
      /// 
      /// </summary>
      /// <param name="person"></param>
      /// <returns></returns>
      public bool DeletePerson(Person person)
      {
         var p = Finder(person);

         if (p != null)
         {
            AddressBook.Remove(p);
            return true;
         }

         return false;
      }
      /// <summary>
      /// 
      /// </summary>
      public List<Person> ListPeople()
      {
         if(!AddressBook.Any())
         {
            var list = RetrieveAddressBook();
               foreach(var person in list)
               {
                  AddressBook.Add(new Person() { FirstName = person });
               }
         }
        return AddressBook;
      }
      /// <summary>
      /// 
      /// </summary>
      public void SaveAddressBook()
      {
         DataAccess.SaveBook(AddressBook.Select(p => p.ToString()).ToList());
      }
      /// <summary>
      /// 
      /// </summary>
      /// <returns></returns>
      public List<string> RetrieveAddressBook()
      {
         var data = DataAccess.RetrieveBook();
         return data.ToList();
      }
      /// <summary>
      /// 
      /// </summary>
      /// <param name="person"></param>
      /// <returns></returns>
      private Person Finder(Person person)
      {
         return AddressBook.FirstOrDefault(p => p.FirstName == person.FirstName && p.LastName == person.LastName && p.PhoneNumber == person.PhoneNumber);
      }
   }
   }

