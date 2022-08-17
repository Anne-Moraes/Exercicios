using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1035_Bee_Crowd
{
    internal class Selecao
    {
        static void Main(string[] args)
        {
            testeDeSelecao();

            /* Leia 4 valores inteiros A, B, C e D. Então se B for maior que C e D for maior que A e se a 
            soma de C e D for maior que a soma de A e B e se C e D forem valores positivos e se A for par, 
            escreva a mensagem “Valores aceitos” . Caso contrário, escreva a mensagem “Valores não aceitos”.  
            
            b > c && d > a && somaCD > somaAB && c > 0 && d > 0 && resto == 0

            Entrada
            Quatro números inteiros A, B, C e D.

            Resultado
            Mostre a mensagem correspondente após a validação dos valores​​. */
        }
        static void testeDeSelecao()
        {
            int a, b, c, d, somaCD, somaAB, resto;

            string[] vet = Console.ReadLine().Split(' ');
            a = int.Parse(vet[0]);
            b = int.Parse(vet[1]);  
            c = int.Parse(vet[2]);
            d = int.Parse(vet[3]);

            somaAB = a + b;
            somaCD = c + d;

            resto = a % 2;

            if (b > c && d > a && somaCD > somaAB && c > 0 && d > 0 && resto == 0)
            {
                Console.WriteLine("Valores aceitos");
            }
            else
            {
                Console.WriteLine("Valores não aceitos");
            }
        }
    }
}