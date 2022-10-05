using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace _1038_Bee_Crowd
{
    internal class Snack
    {
        static void Main(string[] args)
        {
         

            /* Using the following table, write a program that reads a code and the amount of an item. 
            After, print the value to pay. This is a very simple program with the only intention of practice of 
            selection commands.

            Input
            The input file contains two integer numbers X and Y. X is the product code and Y is the quantity of this 
            item according to the above table.

            Output
            The output must be a message "Total: R$ " followed by the total value to be paid, with 2 digits after the 
            decimal point.*/
        
            int x, y;
            double price;

            string[] vet = Console.ReadLine().Split(' ');

            x = int.Parse(vet[0]);
            y = int.Parse(vet[1]);

            price = 0;

            if (x == 1)
            {
                price = y * 4;
            }
            else if (x == 2)
            {
                price = y * 4.5;
            }
            else if (x == 3)
            {
                price = y * 5;
            }
            else if (x == 4)
            {
                price = y * 2;
            }
            else if (x == 5)
            {
                price = y * 1.5;
            }
            Console.WriteLine($"Total: R$ {price.ToString("F2")}");
        }
    }
}