using Prototipo.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Prototipo
{
    public class NotifyController : ApiController
    {

        INotifierService notifierService = new NotifierService();

       
        public void notificarCierre()
        {
            notifierService.notify("Ha finalizado el periodo de votación");
        }

        public void notificarCierrePronto()
        {
            notifierService.notify("Pronto acabará el periodo de votación");
        }

        public void notificarConteo()
        {
            notifierService.notify("El conteo de votos ha finalizado");
        }

    }
}