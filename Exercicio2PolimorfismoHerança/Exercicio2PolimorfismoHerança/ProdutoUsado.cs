using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio2PolimorfismoHerança
{
    internal class ProdutoUsado : Produto

    {
        public DateTime DataFabricacao { get; set; }

        public ProdutoUsado(string name, double preco, DateTime datafabricacao) : base(name, preco)
        {
            DataFabricacao = datafabricacao;
        }
        public override string preco()
        {
            return Name + " - " + Preco + ", Fabricacao: " + DataFabricacao;
        }
    }
}
