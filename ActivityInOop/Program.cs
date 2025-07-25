using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter name: "); //asked user to input their name
        string name = Console.ReadLine();

        Console.Write("Enter age: "); //asked user to input their age
        int age = int.Parse(Console.ReadLine());

        Console.Write("Enter height (in feet): "); ////asked user to input their heigth
        float height = float.Parse(Console.ReadLine());

        Console.WriteLine($"Name: {name}, Age: {age}, Height: {height}"); //display all the information in one line
    }
}

