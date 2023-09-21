using System;

class Program
{
    static void Main(string[] args)
    {
    
    List<int> numbers = new List<int>();

    int userNumber = -1;
    
        Console.WriteLine("Give me a series of numbers. Type 0 when finished: ");

    // ask for series of numbers
    do 
    {
        Console.Write("Enter number: ");
          string user = Console.ReadLine();
            userNumber = int.Parse(user);

             if (userNumber != 0)
        {
            numbers.Add(userNumber);
        }

    } while (userNumber != 0);


        // Sum
        int sum =0;
        foreach (int number in numbers)
        {
            sum += number;    
        }
        Console.WriteLine($"The sum is: {sum}");

        // Average
        float average = ((float)sum) /numbers.Count;
            Console.WriteLine($"The average is {average}");

        // Max
        int big = numbers[0];

        foreach (int number in numbers)
        {
            if (number > big)
            {
                big = number;
            }

        }
    
        Console.WriteLine($"The biggest number is: {big}");

    }   
}