using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FinanceiroAPP.APP;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace FinanceiroAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class InvestimentosController : ControllerBase
    {
        private InvestimentosApp _InvestimentosApp;
        public InvestimentosController()
        {
            _InvestimentosApp = new InvestimentosApp();
        }

        [HttpGet]
        [Route("taxaJuros")]
        public ActionResult<string> TaxaJuros()
        {
            try
            {
                return _InvestimentosApp.TaxaJuros().ToString("f");
            }
            catch (Exception)
            {
                throw;
            }
        }

        [HttpGet]
        [Route("calculajuros")]
        public ActionResult<string> CalculaJuros(double ValorInicial, int Tempo)
        {
            try
            {
                return _InvestimentosApp.CalculaJuros(ValorInicial, Tempo);
            }
            catch (Exception)
            {

                throw;
            }

        }
    }
}