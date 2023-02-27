using System;

namespace Guessing_Game
{
    class Program
    {
        static void Main(string[] args)
        {

int secretNumber = 42;

            Console.WriteLine("Guess the secret number!");
            string input = Console.ReadLine();
          //   Console.WriteLine(input);
int parsedInput = int.Parse(input);

          if (parsedInput == secretNumber) {
            Console.WriteLine("Your guess is correct!");
          }
          else {
            Console.WriteLine("Sorry your guess is wrong");
          }
        }
    }
}
