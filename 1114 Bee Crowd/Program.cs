using System;

namespace _1114_Bee_Crowd
{
    internal class Password
    {
        static void Main(string[] args)
        {
            /*Write a program that keep reading a password until it is valid. For each wrong 
            password read, write the message "Senha inválida". When the password is typed correctly 
            print the message "Acesso Permitido" and finished the program. The correct password is 
            the number 2002.

            Input
            The input file contains several tests cases. Each test case contains only an integer 
            number.

            Output
            For each number read print a message corresponding to the description of the problem.*/

            int password, user, tentativas;
            password = 2002;
            user = 0;

            while (password != user)
            {
                user = int.Parse(Console.ReadLine());

                if (password == user)
                {
                    Console.WriteLine("Allowed Access");
                }
                else
                {
                    Console.WriteLine("Invalid password");
                }
            }
        }
    }
}