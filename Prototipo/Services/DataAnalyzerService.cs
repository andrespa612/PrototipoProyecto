using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Prototipo.Services
{
    public class DataAnalyzerService : IDataAnalyzerService
    {
        public string clasificar(string content)
        {
            if (content != null)
            {
                return "lleno";
            }
            else { return "vacío"; }
        }
    }
}