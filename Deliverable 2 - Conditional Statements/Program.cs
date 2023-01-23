using System;

class Program
{
    static void Main(string[] args)
    {
        int grade;
        try
        {
            Console.WriteLine("What grade do you expect to get in the class? (Enter a numeric value)");
            grade = int.Parse(Console.ReadLine());
            if (grade >= 90)
            {
                Console.WriteLine("Your letter grade is A.");
            }
            else if (grade >= 80)
            {
                Console.WriteLine("Your letter grade is B.");
            }
            else if (grade >= 70)
            {
                Console.WriteLine("Your letter grade is C.");
            }
            else if (grade >= 60)
            {
                Console.WriteLine("Your letter grade is D.");
            }
            else
            {
                Console.WriteLine("Your letter grade is F.");
            }
        }
        catch (FormatException)
        {
            Console.WriteLine("Invalid input. Please enter a numeric value.");
        }
    }
}