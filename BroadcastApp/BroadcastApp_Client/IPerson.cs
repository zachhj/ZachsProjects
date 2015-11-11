using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using System.Threading.Tasks;

namespace BroadcastApp_Client
{
  [ServiceContract]
  public interface IPerson
  {
    [OperationContract]
    [WebInvoke(
      BodyStyle = WebMessageBodyStyle.Wrapped,
      Method = "GET",
      ResponseFormat = WebMessageFormat.Json,
      UriTemplate = "list"
    )]
    IEnumerable<PersonDTO> GetPersonList();

    [OperationContract]
    [WebInvoke(
      BodyStyle = WebMessageBodyStyle.Wrapped,
      Method = "POST",
      RequestFormat = WebMessageFormat.Json,
      ResponseFormat = WebMessageFormat.Json,
      UriTemplate = "check"
    )]
    bool CheckPersonName(string fn, string ln);
  }
}
