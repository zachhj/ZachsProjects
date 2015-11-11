using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace BroadcastApp_Client
{
  [DataContract]
  public class PersonDTO
  {
    [DataMember]
    public string First { get; set; }

    [DataMember]
    public string Last { get; set; }
  }
}