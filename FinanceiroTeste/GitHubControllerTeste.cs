using FinanceiroAPI.Controllers;
using System.Threading.Tasks;
using Xunit;

namespace FinanceiroTeste
{
    public class GitHubControllerTeste
    {
        private GitHubController _GitHubController;
      
        public GitHubControllerTeste()
        {
            _GitHubController = new GitHubController();
        }

        [Fact]
        public async Task ShowMeTheCodeTeste()
        {
            var resultado = _GitHubController.ShowMeTheCode();
            Assert.True(resultado.Value != string.Empty);
        }
    }
}
