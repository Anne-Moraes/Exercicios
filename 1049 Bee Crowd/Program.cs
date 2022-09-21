using System;

namespace _1046_Bee_Crowd
{
    internal class GameTime
    {
        static void Main(string[] args)
        {
            /*In this problem, your job is to read three Portuguese words. These words define an animal 
            according to the table below, from left to right. After, print the chosen animal defined by 
            these three words.

            Input
            The input contains 3 words, one by line, that will be used to identify the animal, according 
            to the above table, with all letters in lowercase.

            Output
            Print the animal name according to the given input.*/

            string structure, animalClass, diet;

            Console.WriteLine("What is the animal's structure?");
            structure = Console.ReadLine();

            Console.WriteLine("What is the animal's class?");
            animalClass = Console.ReadLine();   

            Console.WriteLine("What is the animal's diet?");
            diet = Console.ReadLine();

            if(structure == "vertebrate")
            {
                if (animalClass == "bird" && diet == "carnivore")
                {
                    Console.WriteLine("This Bird is a Eagle");
                }
                else if (animalClass == "bird" && diet == "omnivorous")
                {
                    Console.WriteLine("This Bird is a Dove");
                }
                else if (animalClass == "mammal" && diet == "omnivorous")
                {
                    Console.WriteLine("This Animal is a Human");
                }
                else if (animalClass == "mammal" && diet == "herbivore")
                {
                    Console.WriteLine("This Animal is a Cow");
                }
            }
            else if(structure == "invertebrate")
            {
                if (animalClass == "insect" && diet == "hematophagous")
                {
                    Console.WriteLine("This Insect is a Flea");
                }
                else if (animalClass == "insect" && diet == "herbivore")
                {
                    Console.WriteLine("This Insect is a Caterpillar");
                }
                else if (animalClass == "annelid" && diet == "hematophagous")
                {
                    Console.WriteLine("This Annelid is a Leech");
                }
                else if (animalClass == "annelid" && diet == "omnivorous")
                {
                    Console.WriteLine("This Annelid is a Earthworm");
                }
            }
        }
    }
}