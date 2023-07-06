using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Web;

namespace Prototipo.Services
{
    public class RecordService : IRecordService
    {
        int contador = 0;

        public void registrar(string value)
        {
            contador++;
        }

        public int conteo(string value)
        {
            return contador;
        }

    }
}