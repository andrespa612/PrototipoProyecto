using Prototipo.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Prototipo
{
    public class RegisterController : ApiController
    {

        IRecordService recordService = new RecordService();
        IResultHistoryService resultHistoryService = new ResultHistoryService();

        // POST api/registrarVoto/<value>
        public int registrarVoto(string value)
        {
            recordService.registrar(value);
            return 1;
        }

        // POST api/registrarResultados/<conteo>
        public int registrarResultados(int conteo)
        {
            resultHistoryService.registrarResultados(conteo); 
            return 1;
        }

        // GET api/consultarConteo/<value>
        public int consultarConteo(string value)
        {
            return recordService.conteo(value);
        }

        // GET api/consultarHistorial/<value>
        public int consultarHistorial(int value)
        {
            return resultHistoryService.consultarResultados().Find(x => x == value);
        }

    }
}