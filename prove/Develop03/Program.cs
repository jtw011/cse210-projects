using System;

class Program
{
    static void Main(string[] args)
    {
        var scripture = new Scripture ("John 3:16", "For God so loved the world, that he gave his only Son, that whoever believes in him should not perish but have eternal life.");
       
        while(!scripture.AllWordsHidden)
        {
            Console.Clear();
            scripture.displayWithHiddenWords();
            Console.WriteLine("Press Enter to continue or type 'quit' to exit.");
            string input = Console.ReadLine();
            if (input.ToLower() == "quit")
            {
                break;
            }
            scripture.HideRandomWord();
            
        }

    }
}