using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Prototipo.Services
{
    public class ResultHistoryService : IResultHistoryService
    {
        List<int> resultadosAntiguos = new List<int>();
        public void registrarResultados(int conteo)
        {
            resultadosAntiguos.Add(conteo);
        }

        public List<int> consultarResultados()
        {
            return resultadosAntiguos;
        }
    }
}