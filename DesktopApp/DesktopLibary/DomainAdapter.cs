using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace DesktopLibary
{
   public static class DomainAdapter
   {
      private static string path = "C:\\multivision\\book.xml";

      public static void SaveBookXml(List<Person> people)
      {

         XmlSerializer xml = new XmlSerializer(typeof(List<Person>));
         StreamWriter writer = new StreamWriter(path);

         xml.Serialize(writer, people);
      }

      public static List<Person> RetrieveBookXml()
      {
         List<Person> list;
         XmlSerializer xml = new XmlSerializer(typeof(List<Person>));
         StreamReader reader = new StreamReader(path);

         list = (List<Person>)xml.Deserialize(reader);
         return list;
      }
   }
}
