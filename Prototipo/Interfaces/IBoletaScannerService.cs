using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototipo
{
    internal interface IBoletaScannerService
    {

        string Scan(FileStream file);

    }
}
