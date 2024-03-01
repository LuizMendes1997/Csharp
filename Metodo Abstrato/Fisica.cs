using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio2MetodoAbstrato
{
    internal class Fisica : Pessoa
    {
        public double DespesaSaude { get; set; }
        public Fisica(string nome, double rendaAnual, double despesaSaude) : base(nome, rendaAnual)
        {
            DespesaSaude = despesaSaude;
        }

        public override double impostos()
        {
            double imp = 0;
            if(RendaAnual > 20000)
            {
                imp = RendaAnual / 100 * 25 - (DespesaSaude / 2);
            }
            else
            {
                imp = RendaAnual / 100 * 15 - (DespesaSaude / 2);
            }
            return imp;
        }
    }
}
