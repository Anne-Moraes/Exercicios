using System;

namespace _1114_Bee_Crowd
{
    internal class Password
    {
        static void Main(string[] args)
        {
            /*Make a program that reads five integer values. Count how many of these values ​​are even 
            and  print this information like the following example.

            Input
            The input will be 5 integer values.

            Output
            Print a message like the following example with all letters in lowercase, indicating how 
            many even numbers were typed.*/

            int n1, n2, n3,n4, n5, cont;

            n1 = int.Parse(Console.ReadLine());
            n2 = int.Parse(Console.ReadLine());
            n3 = int.Parse(Console.ReadLine());
            n4 = int.Parse(Console.ReadLine());
            n5 = int.Parse(Console.ReadLine());

            cont = 0;

            if (n1 % 2 == 0)
            {
                cont ++;
            }
            if(n2 % 2 == 0)
            {
                cont++;
            }
            if( n3 % 2 == 0)
            {
                cont++;
            }
            if(n4 % 2 == 0)
            {
                cont++;
            }
            if(n5 % 2 == 0)
            {
                cont++;
            }  

            Console.WriteLine($"({cont} even values)");
        }
    }
}