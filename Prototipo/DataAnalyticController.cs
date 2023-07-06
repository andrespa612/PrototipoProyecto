using Prototipo.Services;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Prototipo
{
    public class DataAnalyticController : ApiController
    {

        IBoletaScannerService scannerService;
        IDataAnalyzerService dataAnalyzerService;


        bool valido(String content)
        {
            if (content == null) return false;
            return true;
        }


        // POST api/Scan/<File>
        public int Scan(FileStream file)
        {
            scannerService = new BoletaScannerService();
            if (scannerService.Scan(file) != "") { return 1; }
            else { return 0; }
        }

        // GET api/Analize/<content>
        public string Analize(string content)
        {
            dataAnalyzerService = new DataAnalyzerService();
            if (valido(content))
            {
                return dataAnalyzerService.clasificar(content);
            }
            else { return "";  }
        }
    }
}