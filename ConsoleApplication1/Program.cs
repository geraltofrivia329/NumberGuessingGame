using System;
using System.Security.Cryptography;

namespace NumberGuessingGame
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Random r = new Random();
            int winNum = r.Next(1, 10);
            bool win = false;

            do
            {
                Console.WriteLine("Please Guess a number between 1 and 10");
                string s = Console.ReadLine();
                int i = int.Parse(s);

                if (i > winNum)
                {
                    Console.WriteLine("To high! Guess lower...");
                }
                else if (i < winNum)
                {
                    Console.WriteLine("To Low! Guess higher...");
                }
                else if (i == winNum)
                {
                    Console.WriteLine("You Win!");
                    win = true;
                }

            } while (win == false);

        }
    }

}