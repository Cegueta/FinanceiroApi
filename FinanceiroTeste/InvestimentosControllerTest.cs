using FinanceiroAPI.Controllers;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;
using Xunit;

namespace FinanceiroTeste
{
  public class InvestimentosControllerTest
  {
    private InvestimentosController _InvestimentosController;

    public InvestimentosControllerTest()
    {
      _InvestimentosController = new InvestimentosController();
    }

    [Fact]
    public async Task ObterTaxaJurosApiTeste()
    {
      var resultado =  _InvestimentosController.TaxaJuros();
      Assert.True(resultado.Value == "0,01");

    }

    [Fact]
    public async Task ObterCalculoJurosApiTeste()
    {
      var resultado = _InvestimentosController.CalculaJuros(100,5);
      Assert.True(resultado.Value == "105,10");

    }
  }
}
