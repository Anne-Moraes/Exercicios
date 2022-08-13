using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _118_Bee_Crowd
{
    internal class Notas
    {
        static void Main(string[] args)
        {
            calculoNotas();

            /* Neste problema você tem que ler um valor inteiro e calcular o menor número possível de notas 
             em que o valor pode ser decomposto. As notas possíveis são 100, 50, 20, 10, 5, 2 e 1.Imprima o 
             valor lido e a lista de notas.

            Entrada
            O arquivo de entrada contém um valor inteiro N(0 < N < 1000000).

            Resultado
            Imprima o número lido e a quantidade mínima de cada cédula necessária em língua portuguesa, 
            conforme o exemplo dado.Não se esqueça de imprimir o final de linha após cada linha, caso 
            contrário você receberá “Erro de apresentação” . */
        }
        static void calculoNotas()
        {
            int n, cem, cinquenta, vinte, dez, cinco, dois, um, resto;

            n = int.Parse(Console.ReadLine());
            resto = n;

            if (0 < n && n < 100000)
            {
                cem = n / 100;
                resto = resto % 100;
                cinquenta = resto / 50;
                resto = resto % 50;
                vinte = resto / 20;
                resto = resto % 20;
                dez = resto / 10;
                resto = resto % 10;
                cinco = resto / 5;
                resto = resto % 5;
                dois = resto / 2;
                resto = resto % 2;
                um = resto / 1;
                Console.WriteLine($"{cem} nota(s) de R$ 100,00 \n{cinquenta} nota(s) de R$ 50,00 \n{vinte} nota(s) de R$ 20,00 \n{dez} nota(s) de R$ 10,00 \n{cinco} nota(s) de R$ 5,00 \n{dois} nota(s) de R$ 2,00 \n{um} nota(s) de R$ 1,00");                
            }
            else;       
        }
    }
}



