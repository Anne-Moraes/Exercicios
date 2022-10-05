using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1011_Bee_Crowd
{
    internal class CalculatesVolume
    {
        static void Main(string[] args)
        {
            /*Make a program that calculates and shows the volume of a sphere being provided the 
            value of its radius (R) . The formula to calculate the volume is: (4/3) * pi * R3. 
            Consider (assign) for pi the value 3.14159.

            Tip: Use (4/3.0) or (4.0/3) in your formula, because some languages (including C++) 
            assume that the division's result between two integers is another integer. :)

            Input
            The input contains a value of floating point (double precision).

            Output
            The output must be a message "VOLUME" like the following example with a space before 
            and after the equal signal. The value must be presented with 3 digits after the decimal 
            point. */           

            double radius, volume;
           
            radius = double.Parse(Console.ReadLine());

            volume = (4.0/3) * 3.14159 * (radius * radius * radius);

            Console.WriteLine($"VOLUME = {volume.ToString("F3")}");
        }
    }
}