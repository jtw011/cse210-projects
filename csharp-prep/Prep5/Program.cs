using System;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
        DisplayWelcome();

        string userName = PromptUserName();
        int userNum = PromptUserNumber();
        int squaredNumber = SquareNumber(userNum);

        DisplayResults(userName, squaredNumber);

    }

    static void DisplayWelcome()
        {
            Console.WriteLine("Welcome to the program!");
        }

        static string PromptUserName()
        {
            Console.WriteLine("What is your name? ");
            string name = Console.ReadLine();

            return name;
        }

        static int PromptUserNumber()
        {
            Console.Write("What is your favorite number? ");
            int num = int.Parse(Console.ReadLine());

            return num;
        }
    
        static int SquareNumber(int num)
        {
            int square = num * num;
            return square;
        }

        static void DisplayResults(string name, int square)
        {
            Console.WriteLine($"{name}, the square of your number is {square}");
        }
}