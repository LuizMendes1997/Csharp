using Exercicio2MetodoAbstrato;
using System;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Pessoa> list = new List<Pessoa>();
            Console.WriteLine("Quantos contribuintes? ");
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Pessoa Fisica ou Juridica (F/J)");
                string tipo = Console.ReadLine();
                Console.WriteLine("Nome: ");
                string nome = Console.ReadLine();
                Console.WriteLine("Renda Anual: ");
                double renda = double.Parse(Console.ReadLine());
                if (tipo == "F")
                {
                    Console.WriteLine("Gastos com Saude: ");
                    double gastos = double.Parse(Console.ReadLine());
                    list.Add(new Fisica(nome, renda, gastos));
                }
                else
                {
                    Console.WriteLine("Numero de funcionarios: ");
                    int fun = int.Parse(Console.ReadLine());
                    list.Add(new Juridica(nome, renda, fun));
                }
            }
            double sum = 0;
            foreach (Pessoa pessoa in list)
            {
                Console.WriteLine(pessoa.Nome + " - $" + pessoa.impostos());
                sum = sum + pessoa.impostos();
            }

            Console.WriteLine("Total de impostos: $" + sum);
        }

    }
}