using ExercicioPolimorfismoeHerança;
using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Funcionario> list = new List<Funcionario>();
            Console.WriteLine("Quantos funcionarios deseja registrar: ");
            int qtd = int.Parse(Console.ReadLine());

            for (int i = 1; i <= qtd; i++) {

                Console.WriteLine("Terceirizado (S/N)");
                string op = Console.ReadLine();
                
                Console.WriteLine("Nome do " + i + "º Funcionario: ");
                string name = Console.ReadLine();

                Console.WriteLine("Horas trabalhadas: ");
                int hora = int.Parse(Console.ReadLine());

                Console.WriteLine("Valor por horas: ");
                double valor = double.Parse(Console.ReadLine());
                if (op == "S")
                {
                   
                    Console.WriteLine("Despesa: ");
                    double despesa = double.Parse(Console.ReadLine());

                    list.Add(new Terceiro(name, hora, valor, despesa));
                }
                else
                {
                    list.Add(new Funcionario (name, hora, valor));
                }

                foreach (Funcionario item in list)
                {
                    Console.WriteLine(item.Name + " - " + item.Pagamento());
                }
            }
        }
    }
}