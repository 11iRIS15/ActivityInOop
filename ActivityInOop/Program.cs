using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter your first name: "); //asked user to input their first name
        string firstName = Console.ReadLine();

        Console.Write("Enter your last name: "); //asked user to input their last name
        string lastName = Console.ReadLine();

        if (string.IsNullOrWhiteSpace(firstName) || string.IsNullOrWhiteSpace(lastName)) //check if the name is empty
        {
            Console.WriteLine("Error: First name and last name cannot be empty."); //display when the name is empty
        }
        else
        {
            Console.WriteLine($"Your full name is: {firstName} {lastName}"); //display if it is successful
        }
    }
}

