using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;

namespace Prototipo.Services
{
    public class BoletaScannerService : IBoletaScannerService
    {
        public string Scan(FileStream file)
        {
            return file.Read();
        }

    }
}