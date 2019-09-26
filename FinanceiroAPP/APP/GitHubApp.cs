using System;
using System.Collections.Generic;
using System.Text;

namespace FinanceiroAPP.APP
{
    public class GitHubApp
    {
        private string UrlGit => "https://github.com/Cegueta/FinanceiroApi";

        public string ObterUrlGithub()
        {
            return this.UrlGit;
        }
    }
}
