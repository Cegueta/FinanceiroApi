using System;
using System.Collections.Generic;
using System.Text;

namespace FinanceiroAPP.APP
{
    public class InvestimentosApp
    {
        private int Taxa => 1; //juros de 1%

        public double TaxaJuros()
        {
            return ((double)Taxa / 100);
        }

        public string CalculaJuros(double ValorInicial, int Tempo)
        {
            return (ValorInicial * Math.Pow(this.TaxaJuros() + 1, Tempo)).ToString("f");
        }
    }
}
