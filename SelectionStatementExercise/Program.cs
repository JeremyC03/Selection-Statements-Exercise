﻿namespace SelectionStatementExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            //Exercise 1

            var r = new Random();
            var favNumber = r.Next(1, 5);

            Console.WriteLine("Try to guess my favorie number");
            var userInput = int.Parse(Console.ReadLine());

            if (userInput < favNumber)
            {
                Console.WriteLine("too low.");
            }
            else if (userInput > favNumber)
            {
                Console.WriteLine("too high.");
            }
            else
            {
                Console.WriteLine("You guessed it!!!");
            }
        }
    }
}
