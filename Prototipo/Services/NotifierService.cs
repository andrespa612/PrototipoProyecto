using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Prototipo.Services
{
    public class NotifierService : INotifierService
    {
        public void notify(string message)
        {
            Console.WriteLine(message);
        }
    }
}