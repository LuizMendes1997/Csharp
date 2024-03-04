using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int senha;
            Console.WriteLine("Digite sua senha: ");
            senha = int.Parse(Console.ReadLine());

            while (senha != 2002) {
            
                Console.WriteLine("Senha Incorreta!");
                Console.WriteLine("Tente Novamente: ");
                senha = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("Finalizado!!!!");
            
        }
    }
}
