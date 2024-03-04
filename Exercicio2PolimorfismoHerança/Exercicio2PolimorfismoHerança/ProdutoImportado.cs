using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio2PolimorfismoHerança
{
    internal class ProdutoImportado : Produto
    {
        public double TaxaImportacao {  get; set; }

        public ProdutoImportado(string name, double preco, double taxaImportacao) : base(name, preco)
        {
            TaxaImportacao = taxaImportacao;
        }

        public double valor()
        {
            return Preco + TaxaImportacao;
        }
        public override string preco()
        {
            return Name + " - " + valor().ToString() + ", Taxa - " + TaxaImportacao;
        }
    }
}
