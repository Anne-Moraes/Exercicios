using System;

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

            int A, B, C, D, sumCD, sumAB, rest;

            string[] vet = Console.ReadLine().Split(' ');
            A = int.Parse(vet[0]);
            B = int.Parse(vet[1]);  
            C = int.Parse(vet[2]);
            D = int.Parse(vet[3]);

            sumAB = A + B;
            sumCD = C + D;

            rest = A % 2;

            if (B > C && D > A && sumCD > sumAB && C > 0 && D > 0 && rest == 0)
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