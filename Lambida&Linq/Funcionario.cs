using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioLambidaLinq
{
    internal class Funcionario
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public double Salaraio { get; set; }

        public Funcionario(string name, string email, double salaraio)
        {
            Name = name;
            Email = email;
            Salaraio = salaraio;
        }
    }
}
