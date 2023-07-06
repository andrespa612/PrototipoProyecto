using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Prototipo.Services
{
    public class DataHandlerService : IDataHandlerService
    {
        public void handle(string data)
        {
            Console.Write(data);
        }
    }
}