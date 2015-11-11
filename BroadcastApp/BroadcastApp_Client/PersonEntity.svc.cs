using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using WebApp_Domain;

namespace BroadcastApp_Client
{
  // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "PersonEntity" in code, svc and config file together.
  // NOTE: In order to launch WCF Test Client for testing this service, please select PersonEntity.svc or PersonEntity.svc.cs at the Solution Explorer and start debugging.
  public class PersonEntity : IPerson
  {
    /// <summary>
    /// 
    /// </summary>
    /// <returns></returns>
    public IEnumerable<PersonDTO> GetPersonList()
    {
      var pd = new List<PersonDTO>();
      var p = DomainHelper.PersonLoader();

      foreach (var item in p.ToList())
      {
        pd.Add(new PersonDTO() { First = item.FirstName, Last = item.LastName });
      }

      return pd;
    }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="fn"></param>
    /// <param name="ln"></param>
    /// <returns></returns>
    public bool CheckPersonName(string fn, string ln)
    {
      return DomainHelper.CheckPerson(fn, ln);
    }
  }
}
