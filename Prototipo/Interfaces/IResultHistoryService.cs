using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototipo
{
    internal interface IResultHistoryService
    {
        void registrarResultados(int conteo);

        List<int> consultarResultados();
    }
}
