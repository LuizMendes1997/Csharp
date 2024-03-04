using Exercicio2PolimorfismoHerança;
using System;
using System.Collections.Generic;
using System.Globalization;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Produto> list = new List<Produto>();
            Console.WriteLine("Entre com a quantidade dos produtos");
            int prod = int.Parse(Console.ReadLine());

            for (int i = 1; i <= prod; i++) 
            {
                
                Console.WriteLine(i + "º Produto: ");
                Console.WriteLine("Comum / Usado / Importado = (C / U / I )");
                string tipo = Console.ReadLine();
                Console.WriteLine("Nome : ");
                string nome = Console.ReadLine();
                Console.WriteLine("Preco: ");
                double preco = double.Parse(Console.ReadLine());
                if(tipo == "I")
                {
                    Console.WriteLine("Custo da importacao: ");
                    double taxa = double.Parse(Console.ReadLine());
                    list.Add(new ProdutoImportado(nome, preco, taxa));
                }
                else if(tipo == "U")
                {
                    Console.WriteLine("Data da Fabricação: ");
                    DateTime datadafabricacao = DateTime.Parse(Console.ReadLine());
                    list.Add(new ProdutoUsado(nome, preco, datadafabricacao));
                }
                else
                {
                    list.Add(new Produto(nome, preco));
                }
             }
            foreach (Produto produto in list)
            {
                Console.WriteLine(produto.preco());
            }
        }
    }
}