using System;

namespace Guessing_Game
{
    class Program
    {
        static void Main(string[] args)
        {

int secretNumber = 42;
// clear console
Console.Clear();

            Console.WriteLine("Guess the secret number!");

            for (int i = 0; i < 4; i++){
            string input = Console.ReadLine();
          //   Console.WriteLine(input);
int parsedInput = int.Parse(input);

          if (parsedInput == secretNumber) {
            Console.WriteLine($"Your guess is correct! Guess number {i + 1}");
            // stop loop if it matches
            break;
          }
          else {
            Console.WriteLine($"Sorry your guess is wrong. Guess number {i + 1}");
          }

            }
        }
    }
}
