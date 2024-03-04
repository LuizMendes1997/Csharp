using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioPolimorfismoeHerança
{
    internal class Terceiro : Funcionario
    {
        public double TaxaAdcional { get; set; }

        public Terceiro(string name, int horas, double valorporhora, double taxaAdcional) : base(name, horas, valorporhora)
        {
            TaxaAdcional = taxaAdcional;
        }

        public override double Pagamento()
        {
            return base.Pagamento() + 1.1 * TaxaAdcional;
        }
    }
}
