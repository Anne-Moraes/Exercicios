using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace _1044_Bee_Crowd
{
    internal class Multiples
    {
        static void Main(string[] args)
        {
            multiplesProgram();

            /* Read two nteger values (A and B). After, the program should print the message "Sao Multiplos" 
            (are multiples) or "Nao sao Multiplos" (aren’t multiples), corresponding to the read values.

            Input
            The input has two integer numbers.

            Output
            Print the relative message to the input as stated above.*/
        }
        static void multiplesProgram()
        {
            int a, b;         

            string[] vet = Console.ReadLine().Split(' ');

            a = int.Parse(vet[0]);
            b = int.Parse(vet[1]);

            if (a % b == 0 || b % a == 0)
            {
                Console.WriteLine("Are multiples");
            }
            else
            {
                Console.WriteLine("Aren’t multiples");
            }


        }
    }
}