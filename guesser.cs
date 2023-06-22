// This is a number guessers
using System;

class Program {
  static void Main(string[] args) {
    Console.Write("Type a number: ");
    double range = Convert.ToDouble(Console.ReadLine());

    Random rnd = new Random();
    int guessingNum = rnd.Next(1, (int)range + 1);

    int guesses = 0;

    while (true) {
      guesses += 1;
      Console.Write("Guess the number: ");
      double guess = Convert.ToDouble(Console.ReadLine());
      
      if (guess == guessingNum) {
        Console.WriteLine("You guessed it!");
        break;
      }
      else if (guess > guessingNum) {
        Console.WriteLine("Too High! Try again.");
      }
      else {
        Console.WriteLine("Too Low! Try again,");
      }
    }
    Console.WriteLine("You guessed the number in " + guesses + " guesses!");
    
  }
}
