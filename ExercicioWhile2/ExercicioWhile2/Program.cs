using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int opcao;
            int alcool = 0;  int diesel = 0; int gasolina =0;
            Console.WriteLine("Qual abastecimento deve ser incluido: ");
            Console.WriteLine("1. Alcool ");
            Console.WriteLine("2. Diesel ");
            Console.WriteLine("3. Gasolina ");
            Console.WriteLine("4. Fim ");
            opcao = int.Parse(Console.ReadLine());
            
                while (opcao != 4)
                    {
                        if (opcao == 1)
                        {
                            alcool = alcool + 1;
                        }
                        else if (opcao == 2)
                        {
                            diesel = diesel + 1;
                        }
                        else if (opcao == 3)
                        {
                            gasolina = gasolina + 1;
                        }
                        Console.WriteLine("Qual abastecimento deve ser incluido: ");
                        Console.WriteLine("1. Alcool ");
                        Console.WriteLine("2. Diesel ");
                        Console.WriteLine("3. Gasolina ");
                        Console.WriteLine("4. Fim ");
                        opcao = int.Parse(Console.ReadLine());
                    }
                
                          
            Console.WriteLine("Muito Obrigado");
            Console.WriteLine("Alcool " + alcool);
            Console.WriteLine("Diesel " + diesel);
            Console.WriteLine("Gasoline " + gasolina);
        }
    }
}
