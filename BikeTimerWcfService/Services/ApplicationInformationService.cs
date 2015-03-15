using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BikeTimerWcfService.Services
{
    public class ApplicationInformationService : IApplicationInformationService
    {
        public string GetServiceInformation()
        {
            return "hello world!";
        }
    }
}