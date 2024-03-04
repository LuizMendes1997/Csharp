using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio2PolimorfismoHerança
{
    internal class Produto
    {
        public string Name { get; set; }
        public double Preco {  get; set; }



        public virtual string preco()
        {
            return Name + " $" + Preco;
        }

        public Produto(string name, double preco)
        {
            Name = name;
            Preco = preco;
        }
    }
}
