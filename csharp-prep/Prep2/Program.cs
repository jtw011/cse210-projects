using System;
using System.Runtime;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("What is your grade percentage");
        string answer = Console.ReadLine();
        int percent = int.Parse(answer);

        string letter = "";

        if (percent >= 90)
        {
        letter = "A";
        }

        else if (percent >= 80)
        {
            letter = "B";
        }
        
        else if (percent >=70)
        {
            letter = "C";
        }

        else if (percent >= 60)
        {
            letter = "D";
        }

        else
        {
        letter = "f";
        }

        Console.WriteLine($"Your Grade is {letter}");

        if (percent >= 70)
        {
            Console.WriteLine("You passed!");
        }

        else
        {
            Console.WriteLine("Better luck next semester!");
        }
    }
}