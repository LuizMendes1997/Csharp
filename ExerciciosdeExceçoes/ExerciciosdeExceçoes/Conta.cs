using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosdeExceçoes
{
    internal class Conta
    {
        public int NumeroConta {  get; set; }
        public string Nome { get; set; }

        public double Saldo { get; set; }
        public double LimiteSaque {  get; set; }

        public Conta(int numeroConta, string nome, double saldo, double limitesaque)
        {
            NumeroConta = numeroConta;
            Nome = nome;
            Saldo = saldo;
            LimiteSaque = limitesaque;
        }
        public void SaldoFinal(double saque)
        {
            if (saque > LimiteSaque)
            {
                throw new DominioExcecao("Saque passou do limite");
            }
            if (saque > Saldo)
            {
                throw new DominioExcecao("Não tem saldo suficiente");
            }

            Saldo = Saldo - saque;
        }

        
    }
}
