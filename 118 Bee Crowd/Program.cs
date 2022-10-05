using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1018_Bee_Crowd
{
    internal class Banknotes
    {
        static void Main(string[] args)
        {
            
            /* In this problem you have to read an integer value and calculate the smallest possible number of banknotes in 
            which the value may be decomposed. The possible banknotes are 100, 50, 20, 10, 5, 2 e 1. Print the read value and
            the list of banknotes.

            Input
            The input file contains an integer value N (0 < N < 1000000).

            Output
            Print the read number and the minimum quantity of each necessary banknotes in Portuguese language, as the given example.
            Do not forget to print the end of line after each line, otherwise you will receive “Presentation Error”. . */         
            
            int n, oneHundred, fifty, twenty, ten, five, two, one, rest;

            n = int.Parse(Console.ReadLine());
            rest = n;

            if (0 < n && n < 100000)
            {
                oneHundred = n / 100;
                rest = rest % 100;

                fifty = rest / 50;
                rest = rest % 50;

                twenty = rest / 20;
                rest = rest % 20;

                ten = rest / 10;
                rest = rest % 10;

                five = rest / 5;
                rest = rest % 5;

                two = rest / 2;
                rest = rest % 2;

                one = rest / 1;

                Console.WriteLine($"{n} \n{oneHundred} banknote(s) from R$ 100,00 \n{fifty} banknote(s) from R$ 50,00 " +
                    $"\n{twenty} banknote(s) from R$ 20,00 \n{ten} banknote(s) from R$ 10,00 \n{five} banknote(s) from R$ 5,00 " +
                    $"\n{two} banknote(s) from R$ 2,00 \n{one} banknote(s) from R$ 1,00");                
            }
            else;  
            
        }
    }
}



