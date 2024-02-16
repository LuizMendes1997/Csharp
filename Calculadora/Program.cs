using ExercicioCalculadoracomClasse;
using System;
using System.Globalization;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Calculadora");
            Console.WriteLine("1. Soma: ");
            Console.WriteLine("2. Multiplicacao: ");
            Console.WriteLine("3. Divisao: ");
            Console.WriteLine("4. Subtração: ");
            int op = int.Parse(Console.ReadLine());
            Console.WriteLine("Passe os dois numeros: ");
            double nume1 = double.Parse(Console.ReadLine());
            double nume2 = double.Parse(Console.ReadLine());
            Calcular calcular = new Calcular();
            if (op == 1) { calcular.soma(nume1, nume2); }
            else if (op == 2) { calcular.multiplica(nume1, nume2); }
            else if (op == 3) { calcular.divisao(nume1, nume2); }
            else if (op == 4) { calcular.subtracao(nume1, nume2); }
            Console.WriteLine(calcular);




        }
    }
}