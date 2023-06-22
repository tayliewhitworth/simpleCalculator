using System;
// first C# program!

class Program {
  static void Main (string[] args) {
    Console.WriteLine("Simple Calculator");
    Console.WriteLine("-----------------");

    while (true) {
      Console.Write("Enter the first number: ");
      double num1 = Convert.ToDouble(Console.ReadLine());

      Console.Write("Enter an operator (+, -, *, /): ");
      char op = Convert.ToChar(Console.ReadLine());

      Console.Write("Enter the second number: ");
      double num2 = Convert.ToDouble(Console.ReadLine());

      double result = 0;

      switch (op)
            {
                case '+':
                    result = num1 + num2;
                    break;
                case '-':
                    result = num1 - num2;
                    break;
                case '*':
                    result = num1 * num2;
                    break;
                case '/':
                    result = num1 / num2;
                    break;
                default:
                    Console.WriteLine("Invalid operator.");
                    break;
            }

      Console.WriteLine("Result: " + result);
      Console.WriteLine("-----------------");

      Console.WriteLine("Do you want to perform another calc? (Y/N): ");
      char choice = Convert.ToChar(Console.ReadLine());

      if (choice != 'Y' && choice != 'y')
      break;

      Console.WriteLine();
    }
    Console.WriteLine("Thanks for using my calc! Press any key to exit.");
    Console.ReadKey();
  }
}
