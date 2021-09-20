using System;

namespace Homework_4_Project_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the price of the item (From 25 cents to a dollar, in a 5-cent increment).");
            double totalPrice = Convert.ToDouble(Console.ReadLine());
            //Calculate the change
            double change = 100 - totalPrice;
            Console.WriteLine("Your change is: " + change.ToString() + " cents.");

            double quarters = change / 25;
            quarters = Math.Round(quarters, 0);
            Console.WriteLine(quarters.ToString() + " quarters");
            change = change % 25;

            double dimes = change / 10;
            dimes = Math.Round(dimes, 0);
            Console.WriteLine(dimes.ToString() + " dimes");
            change = change % 10;

            double nickels = change / 5;
            nickels = Math.Round(nickels, 0);
            Console.WriteLine(nickels.ToString() + " nickels");
            change = change % 5;



        }
    }
}
