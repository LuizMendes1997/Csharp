using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioPolimorfismoeHerança
{
    internal class Funcionario
    {
        public string Name {  get; set; }
        public int Horas { get; set; }
        public double ValorporHora { get; set; }



        public virtual double Pagamento ()
        {
            return Horas * ValorporHora;
            
        }

        public Funcionario(string name, int horas, double valorporhora)
        {
            Name = name;
            Horas = horas;
            ValorporHora = valorporhora;
        }

        public Funcionario()
        {
        }
    }
}
