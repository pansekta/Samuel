using JsonServices;
using JsonServices.Web;

namespace Samuel
{
  /// <summary>
  /// Summary description for Handler
  /// </summary>
  public class Handler : JsonHandler
  {

     public Handler()
     {
       service.Name = "JSONWebAPI";
       service.Description = "JSON API for android appliation";
       var config = new InterfaceConfiguration("RestAPI", typeof(IServiceApi), typeof(ServiceApi));
       service.Interfaces.Add(config);
     }
  }
}