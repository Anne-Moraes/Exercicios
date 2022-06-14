using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;


namespace _1
{
    internal class Exercicios
    {
        static void Main(string[] args)
        {
            ex1Imc(); //Calcule seu IMC, ex if e else if;
        }
        static void ex1Imc()
        {
            Console.WriteLine("Vamos ver como está sua saúde? Calcule seu IMC!");

            double imc, peso, altura;

            Console.WriteLine("Insira seu peso");
            peso = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Insira sua altura");
            altura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            imc = peso / (altura * altura);

            Console.WriteLine($"seu resultado é:");


            if (imc <= 18.5)
            {
                Console.WriteLine($"{imc} - Anêmico");
            }
            else if (imc <= 24.9)
            {
                Console.WriteLine($"{imc.ToString("F")} - Normal");
            }
            else if (imc <= 29.9)
            {
                Console.WriteLine($"{imc.ToString("F")} - Sobrepeso");
            }
            else if (imc <= 40)
            {
                Console.WriteLine($"{imc.ToString("F")} - Obesidade");
            }
            else if (imc > 40)
            {
                Console.WriteLine($"{imc.ToString("F")} - Obesidade Grave");
            }
        }
    }
}
