using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace FinanceiroAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GitHubController : ControllerBase
    {
    [HttpGet]
    [Route("showmethecode")]
    public ActionResult<string> ShowMeTheCode()
    {
      try
      {
        return "https://www.google.com";
        //return _InvestimentosApp.TaxaJuros().ToString("f");
      }
      catch (Exception)
      {
        throw;
      }
    }

  }
}