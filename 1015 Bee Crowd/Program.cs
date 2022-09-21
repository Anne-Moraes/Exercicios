using System;
using System.Globalization;

namespace uri1015
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Read the four values corresponding to the x and y axes of two points in the plane, 
            p1 (x1, y1) and p2(x2, y2) and calculate the distance between them, showing four decimal
            places after the comma, according to the formula:

            distance is equal to the square root x2 minus x1 squared plus y2 minus y1 squared.

            Input
            The input file contains two lines of data. The first one contains 
            two double values: x1 y1 and the second one also contains two double values with one digit 
            after the decimal point: x2 y2.

            Output
            Calculate and print the distance value using the provided formula, with 4 digits after the 
            decimal point.*/

            double x1, x2, y1, y2, distance;

            Console.WriteLine("To calculate distance enter:");

            Console.WriteLine("The first values of x and y respectively.");
            string[] values = Console.ReadLine().Split(' ');
            x1 = double.Parse(values[0], CultureInfo.InvariantCulture);
            y1 = double.Parse(values[1], CultureInfo.InvariantCulture);

            Console.WriteLine("The second values of x and y respectively");
            values = Console.ReadLine().Split(' ');
            x2 = double.Parse(values[0], CultureInfo.InvariantCulture);
            y2 = double.Parse(values[1], CultureInfo.InvariantCulture);

            distance = Math.Sqrt(Math.Pow(x2 - x1, 2.0) + Math.Pow(y2 - y1, 2.0));

            Console.WriteLine($"Distance = {distance.ToString("F4")}");
        }
    }
}