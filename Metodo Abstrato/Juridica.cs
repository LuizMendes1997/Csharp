using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio2MetodoAbstrato
{
    internal class Juridica : Pessoa
    {
        public int Funcionarios {  get; set; }

        public Juridica(string nome, double rendaAnual, int funcionarios) : base (nome, rendaAnual)
        {
            Funcionarios = funcionarios;
        }

        public override double impostos()
        {
            double imp = 0;
            if (Funcionarios > 10)
            {
                imp = RendaAnual / 100 * 14;
            }
            else
            {
                imp = RendaAnual / 100 * 16;
            }
            return imp;
        }
    }
}
