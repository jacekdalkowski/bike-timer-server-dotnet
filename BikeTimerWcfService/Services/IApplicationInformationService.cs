using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using System.Threading.Tasks;

namespace BikeTimerWcfService.Services
{
    [ServiceContract]
    public interface IApplicationInformationService
    {
        [OperationContract]
        [WebGet(UriTemplate="/", ResponseFormat=WebMessageFormat.Json)]
        string GetServiceInformation();
    }
}
