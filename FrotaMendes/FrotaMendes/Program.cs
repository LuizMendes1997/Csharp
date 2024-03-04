using System;

using System.Globalization;

using System.Collections.Generic;


public class Program
{

    public static void Main()

    {
      
        int guacon = 0;

        int congua = 0;

        int liberacao = 0;

        int encerrado = 0;

        int frota = 8;

        Stack<int> pilhaInt;
        pilhaInt = new Stack<int>();

        Stack<int> guarulhos = new Stack<int>();

        Stack<int> congonhas = new Stack<int>();

        for (int i = 1; i <= frota; i++)
        {
            int pos = i-1;
              
            pilhaInt.Push(i);
         
        }

       
        
        mostraPilha(pilhaInt);

        Console.WriteLine("Bem vindo a Empresa Mendes Tr. ");

        Console.WriteLine("0.Finalizar");

        Console.WriteLine("1.Cadastrar veículo");

        Console.WriteLine("2.Cadastrar garagem");

        Console.WriteLine("3.Iniciar jornada");

        Console.WriteLine("4.Encerrar jornada");

        Console.WriteLine("5. Liberar viagem de uma determinada origem para um determinado destino");

        Console.WriteLine("6. Listar veículos em determinada garagem (informando a quantidade de veículos" +

              " e seu potencial de transporte)");

        Console.WriteLine("7.Informar quantidade de viagens efetuadas de uma determinada origem para " +

                "um determinado destino");

        Console.WriteLine("8. Listar viagens efetuadas de uma determinada origem para um determinado destino");

        Console.WriteLine("9. Informar quantidade de passageiros transportados de uma determinada origem para " +

                "um determinado destino");

        int n = int.Parse(Console.ReadLine());

        while (n != 0)

        {

            if (n == 1 && encerrado > 0)

            {

                Console.WriteLine("Quantas frotas deseja cadastrar: ");

                int cadastrar = int.Parse(Console.ReadLine());

                cadastrar = cadastrar + frota;

                frota = frota + 1;

                for (int i = frota; i <= cadastrar; i++)

                {

                    pilhaInt.Push(i);

                }

                frota = cadastrar;

            }

            else if (n == 1 || n == 2 & encerrado == 0)

            {

                Console.WriteLine("Não teve encerramento de jornada, favor encerrar!");

            }

            else if (n == 2 && encerrado > 0)

            {

                Console.WriteLine("Garagem a se cadastrar: ");

            }

            else if (n == 3)

            {

                for (int i = 1; i <= frota; i++)

                {

                    guarulhos.Push(i);

                    i++;

                    congonhas.Push(i);

                }

                liberacao = liberacao + 1;

            }
            else if(n == 4)
            {

                congonhas.Clear();
                guarulhos.Clear();
                encerrado = encerrado + 1;
            }
            else if (n == 5 && liberacao > 0)

            {

                Console.WriteLine("Qual a viagem selecionada: ");

                Console.WriteLine("Digite 1 se for de  Congonhas para Guarulhos: ");

                Console.WriteLine("Digite 2 se for de  Guarulhos para Congonhas: ");

                int destino = int.Parse(Console.ReadLine());

                if (destino == 1 && congonhas.Count > 0)

                {
                    int b, c, d, i, f, g, h, j;
                    b = 0; c = 0; d = 0; i = 0; f = 0; g = 0; h = 0; j = 0;
                    int a = congonhas.Peek();
                    guarulhos.Push(congonhas.Peek());
                    congonhas.Pop();
                    congua = congua + 1;
                  
            

                }

                else if (destino == 2 && guarulhos.Count > 0)
                {

                    congonhas.Push(guarulhos.Peek());

                    guarulhos.Pop();

                    guacon = guacon + 1;

                }
                else if (destino == 2 || congonhas.Count < 1)
                {
                    Console.WriteLine("Não existe frota para viagem");
                }
                else if (destino == 1 || guarulhos.Count < 1)
                {
                    Console.WriteLine("Não existe frota para viagem");
                }

            }

            else if (n == 5 && liberacao == 0)

            {

                Console.WriteLine("Não teve inicio de jornada, favor inciar!");

            }

            else if (n == 6)
            {

                Console.WriteLine("Qual a garagem selecionada: ");

                Console.WriteLine("Digite 1 se for de Guarulhos: ");

                Console.WriteLine("Digite 2 se for de Congonhas: ");

                int garagem = int.Parse(Console.ReadLine());

                if (garagem == 1)

                {

                    Console.WriteLine("Guarulhos");

                    mostraGaragem(congonhas);

                }

                else if (garagem == 2)
                {

                    Console.WriteLine("Congonhas");

                    mostraGaragem(congonhas);

                }

            }

            else if (n == 7)
            {

                Console.WriteLine("Qual a viagem selecionada: ");

                Console.WriteLine("Digite 1 se for de  Congonhas para Guarulhos: ");

                Console.WriteLine("Digite 2 se for de  Guarulhos para Congonhas: ");

                int garagem = int.Parse(Console.ReadLine());

                if (garagem == 1)

                {

                    Console.WriteLine("Congonhas para Guarulhos");

                    Console.WriteLine("Total de {0}, viagens!", congua);

                }

                else if (garagem == 2)
                {

                    Console.WriteLine("Guarulhos para Congonhas");

                    Console.WriteLine("Total de {0} viagens!", guacon);

                }

            }
            else if (n == 8)
            {

                Console.WriteLine("Qual a viagem selecionada: ");

                Console.WriteLine("Digite 1 se for de  Congonhas para Guarulhos: ");

                Console.WriteLine("Digite 2 se for de  Guarulhos para Congonhas: ");

                int garagem = int.Parse(Console.ReadLine());

                if (garagem == 1)

                {

                    Console.WriteLine("Congonhas para Guarulhos");

                    Console.WriteLine("Total de {0}, viagens!", congua);

                }

                else if (garagem == 2)
                {

                    Console.WriteLine("Guarulhos para Congonhas");

                    Console.WriteLine("Total de {0} viagens!", guacon);

                }

            }
            else if (n == 9)
            {

                Console.WriteLine("Qual a viagem selecionada: ");

                Console.WriteLine("Digite 1 se for de  Congonhas para Guarulhos: ");

                Console.WriteLine("Digite 2 se for de  Guarulhos para Congonhas: ");

                int garagem = int.Parse(Console.ReadLine());

                if (garagem == 1)

                {
                    int passageiros = congua * 20;

                    Console.WriteLine("Congonhas para Guarulhos");

                    Console.WriteLine("Total de {0} passageiros!", passageiros);

                }

                else if (garagem == 2)
                {
                    int passageiros = guacon * 20;
                    Console.WriteLine("Guarulhos para Congonhas");

                    Console.WriteLine("Total de {0} passageiros!", passageiros);

                }

            }

            Console.WriteLine("Bem vindo a Empresa Mendes Tr. ");

            Console.WriteLine("0.Finalizar");

            Console.WriteLine("1.Cadastrar veículo");

            Console.WriteLine("2.Cadastrar garagem");

            Console.WriteLine("3.Iniciar jornada");

            Console.WriteLine("4.Encerrar jornada");

            Console.WriteLine("5.Liberar viagem de uma determinada origem para um determinado destino");

            Console.WriteLine("6.Listar veículos em determinada garagem (informando a quantidade de veículos" +

                   " e seu potencial de transporte)");

            Console.WriteLine("7.Informar quantidade de viagens efetuadas de uma determinada origem para " +

                   "um determinado destino");

            Console.WriteLine("8. Listar viagens efetuadas de uma determinada origem para um determinado destino");

            Console.WriteLine("9. Informar quantidade de passageiros transportados de uma determinada origem para " +

                   "um determinado destino");

            n = int.Parse(Console.ReadLine());

        }

        mostraPilha(pilhaInt);

        Console.WriteLine("Congonhas");

        mostraPilha(congonhas);

        Console.WriteLine("Guarulhos");

        mostraPilha(guarulhos);
        
    }

    static void mostraPilha(Stack<int> pilha)

    {

        Console.WriteLine("-- Qtde de Frotas: {0} --", pilha.Count);

        foreach (int i in pilha)

        {

            Console.WriteLine(" Frota: {0}", i);

        }

        Console.WriteLine("----------------------");

    }

    static void mostraGaragem(Stack<int> list)

    {

        Console.WriteLine("-- Qtde de Frotas: {0} --", list.Count);

        int k = 20 * list.Count;

        Console.WriteLine("Quantidade total de vagas para passageiros das frotas desta garagem : ");

        Console.WriteLine(k);

        Console.WriteLine("----------------------");

    }

}
