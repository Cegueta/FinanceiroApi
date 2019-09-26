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
    public class GitHubController : ControllerBase
    {
        private GitHubApp _GitHubApp;

        public GitHubController()
        {
            _GitHubApp = new GitHubApp();
        }


        [HttpGet]
        [Route("showmethecode")]
        public ActionResult<string> ShowMeTheCode()
        {
            try
            {
                return _GitHubApp.ObterUrlGithub();
            }
            catch (Exception)
            {
                throw;
            }
        }

    }
}