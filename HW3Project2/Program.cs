using System;

namespace HW3Project2
{
    class Program
    {
        static void Main(string[] args)
        {
			const int QUARTERS_CHANGE = 25;
			const int DIMES_CHANGE = 10;
			const int NICKELS_CHANGE = 5;
			const int DOLLAR = 100;

			Console.WriteLine("Enter price of item"
			+ " (from 25 cents to a dollar, in 5-cent increments): ");

			int price = Int32.Parse(Console.ReadLine());

			int change = DOLLAR - price;
			int numQuarters, numDimes, numNickels;


			numQuarters = change / QUARTERS_CHANGE;
			numDimes = (change - numQuarters * QUARTERS_CHANGE) / DIMES_CHANGE;
			numNickels = (change - numQuarters * QUARTERS_CHANGE - numDimes * DIMES_CHANGE) / NICKELS_CHANGE;

			
			Console.WriteLine("The price of your item is " + price + " cents and you gave me a dollar." + "\n"
			+ "Your change is " + change + " cents:" + "\n"
			+ numQuarters + " quarters," + "\n"
			+ numDimes + " dimes, and" + "\n"
			+ numNickels + " nickels." + "\n");
		}
    }
}
