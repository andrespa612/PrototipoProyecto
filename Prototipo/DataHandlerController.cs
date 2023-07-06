using Prototipo.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Prototipo
{
    public class DataHandlerController : ApiController
    {
        
        IDataHandlerService dataHandlerService = new DataHandlerService();

        // GET api/<controller>
        public void Get(string data)
        {
            dataHandlerService.handle(data);
        }


    }
}