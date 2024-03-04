using ExerciciosdeExceçoes;
using System;
using System.Globalization;
namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Entre com os dados da conta bancaria");
            Console.WriteLine("Numero da Conta: ");
            int num = int.Parse(Console.ReadLine());
            Console.WriteLine("Nome do usuario: ");
            string name = Console.ReadLine();
            Console.WriteLine("Seu saldo inicial: ");
            double saldo = double.Parse(Console.ReadLine());
            Console.WriteLine("Valor Limite do saque: ");
            double Limitesaque = double.Parse(Console.ReadLine());
            Conta conta = new Conta(num, name, saldo, Limitesaque);

            Console.WriteLine("Saque a se realizar: ");
            double saque = double.Parse(Console.ReadLine());
            try
            {
                conta.SaldoFinal(saque);
               
                Console.WriteLine("Novo Saldo: " + conta.Saldo.ToString("F2", CultureInfo.InvariantCulture));
            }
            catch (DominioExcecao e)
            {
                Console.WriteLine("Saque error: " + e.Message);
            }


        }
    }
}