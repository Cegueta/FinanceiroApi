using FinanceiroAPP.APP;
using System.Threading.Tasks;
using Xunit;

namespace FinanceiroTeste
{
    public class GitHubAppTeste
    {
        private GitHubApp _GitHubApp = new GitHubApp();

        public GitHubAppTeste()
        {
            _GitHubApp = new GitHubApp();
        }

        [Fact]
        public async Task ObterUrlGithubTeste()
        {
            var resultado = _GitHubApp.ObterUrlGithub();
            Assert.True(resultado != string.Empty);
        }
    }
}
