using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioCalculadoracomClasse
{
    internal class Calcular
    {
        public double Numero1 {  get; set; }
        public double Numero2 {  get; set; }
        public double Valor {  get; set; }

        public Calcular(double numero1, double numero2, double valor)
        {
            Numero1 = numero1;
            Numero2 = numero2;
            Valor = valor;
        }

        public Calcular(double numero1, double numero2)
        {
            Numero1 = numero1;
            Numero2 = numero2;
        }

        public Calcular()
        {
        }

        public double soma(double numero1, double numero2)
        {
               return Valor = numero1 + numero2;
        }
        public double divisao(double numero1, double numero2)
        {
            return Valor = numero1 / numero2;
        }

        public double multiplica(double numero1, double numero2)
        {
            return Valor = numero1 * numero2;
        }
        public double subtracao(double numero1, double numero2)
        {
            return Valor = numero1 - numero2;
        }

        public override string ToString()
        {
            return Valor.ToString();
        }
    }
}
