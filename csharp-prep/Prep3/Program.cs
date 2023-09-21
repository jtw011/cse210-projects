using System;
using System.Globalization;
using System.Net;

class Program
{
    static void Main(string[] args)
    {
     Random randomGenerator = new Random();
     int magicNumber = randomGenerator.Next(1, 10);
   
   while (true)
   
    Console.Write("What is the Magic Number? ");
    int number = int.Parse(Console.ReadLine());
    
    {
        if (number > magicNumber)
     {
        Console.WriteLine("Lower");
     }
     else if (number < magicNumber)
     {
        Console.WriteLine("Higher");
     }
     else
     {
        Console.WriteLine("You Guessed it!");
     }
    }
    
   }

}