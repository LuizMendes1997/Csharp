using ExercicioLambidaLinq;
using System;
using System.Globalization;
using System.Linq;
using System.IO;
namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter full file patch: ");
            string pathin = Console.ReadLine();
            List<Funcionario> list = new List<Funcionario>();
            

            using(StreamReader reader = File.OpenText(pathin))
            {

                while(!reader.EndOfStream)
                {
                    string[] fields = reader.ReadLine().Split(",");
                    string name = fields[0];
                    string email = fields[1];
                    double salario = double.Parse(fields[2], CultureInfo.InvariantCulture);
                    list.Add(new Funcionario(name, email, salario));
                }

            }
            
            Console.WriteLine("Enter the value: ");
            double value = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            var rst = list.Where(l => l.Salaraio > value).OrderByDescending(l => l.Email).Select(L => L.Email);
            
            foreach(string email  in rst)
            {
                Console.WriteLine(email);
            }

            var rst2 = list.Where(l => l.Name[0] == 'M').Average(l => l.Salaraio);
            Console.WriteLine(rst2);




        }
    }
}