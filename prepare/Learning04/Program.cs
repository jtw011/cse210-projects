using System;

class Program
{
    static void Main(string[] args)
    {
        Assignment assignment = new Assignment("John Doe", "History");

        Console.WriteLine("Base Assignment:");
        Console.WriteLine(assignment.GetSummary());

        MathAssignments mathAssignments = new MathAssignments("Alice Smith", "Algebra", "Chapter 3", "1-10");
        Console.WriteLine(mathAssignments.GetSummary());
        Console.WriteLine(mathAssignments.GetHomeworkList());

        WritingAssignment writingAssignment = new WritingAssignment("Mary Waters", "European History", "The Causes of World War II");
        Console.WriteLine(writingAssignment.GetSummary());
        Console.WriteLine(writingAssignment.GetWritingInformation());

        
    }   
}