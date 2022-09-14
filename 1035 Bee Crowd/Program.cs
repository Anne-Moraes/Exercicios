using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1035_Bee_Crowd
{
    internal class Selection
    {
        static void Main(string[] args)
        {

            /* Read 4 integer values A, B, C and D. Then if B is greater than C and D is greater 
            than A and if the sum of C and D is greater than the sum of A and B and if C and D 
            were positives values and if A is even, write the message “Valores aceitos” 
            (Accepted values). Otherwise, write the message “Valores nao aceitos” 
            (Values not accepted).

            Input
            Four integer numbers A, B, C and D.

            Output
            Show the corresponding message after the validation of the values​​. */

            int a, b, c, d, sumCD, sumAB, rest;

            string[] vet = Console.ReadLine().Split(' ');
            a = int.Parse(vet[0]);
            b = int.Parse(vet[1]);  
            c = int.Parse(vet[2]);
            d = int.Parse(vet[3]);

            sumAB = a + b;
            sumCD = c + d;

            rest = a % 2;

            if (b > c && d > a && sumCD > sumAB && c > 0 && d > 0 && rest == 0)
            {
                Console.WriteLine("Accepted values");
            }
            else
            {
                Console.WriteLine("Values not accepted");
            }
        }
    }
}