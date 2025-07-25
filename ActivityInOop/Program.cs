using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter price: "); //asked the user to input the price
        float price = float.Parse(Console.ReadLine());

        Console.Write("Enter quantity: "); //asked the user to input the quantity
        int quantity = int.Parse(Console.ReadLine());

        if (price > 0 && quantity > 0) //check if the price and the quantity is greater than 0
        {
            float total = price * quantity; //multiply it
            Console.WriteLine($"Total cost: Php {total:F2}"); //display 
        }
        else
        {
            Console.WriteLine("Price and quantity must be positive."); //display when the value is out of range
        }
    }
}
