using FinanceiroAPP.APP;
using System;
using System.Threading.Tasks;
using Xunit;

namespace FinanceiroTeste
{
    public class InvestimentosAppTeste
    {
        InvestimentosApp _InvestimentosApp;

        public InvestimentosAppTeste()
        {
            _InvestimentosApp = new InvestimentosApp();
        }

        [Fact]
        public async Task ObterTaxaJurosAppTeste()
        {
            var resultado = _InvestimentosApp.TaxaJuros();
            Assert.True(resultado == 0.01);
        }

        [Fact]
        public async Task ObterCalculoJurosAppTeste()
        {
            var resultado = _InvestimentosApp.CalculaJuros(100, 5);
            Assert.True(resultado == "105,10");

        }
    }
}
