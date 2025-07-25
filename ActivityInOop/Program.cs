using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter your age in years: "); //asked user to input the age
        int age = int.Parse(Console.ReadLine());

        if (age >= 1 && age <= 120) //check if the user's age is between 1 and 120
        {
            Console.WriteLine($"You are {age * 12} months old."); //if it is between 1 and 120 the age will multiplied by 12
        }
        else
        {
            Console.WriteLine("Invalid age. Age must be between 1 and 120."); //display when the age is out of range
        }
    }
}
