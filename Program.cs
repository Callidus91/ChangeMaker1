using System;

namespace ChangeMaker1
{
    class Program
    {
        static void Main(string[] args)
        {
            int change;

            Console.Write("Enter your change: ");
            change = Convert.ToInt32(Console.ReadLine());
            

            int quarters = change / 25;
            change %= 25;
            int dimes = change / 10;
            change %= 10;
            int nickels = change / 5;
            int pennies = change - nickels * 5;
            Console.WriteLine("quarters: " + quarters);
            Console.WriteLine("dimes: " + dimes);
            Console.WriteLine("nickels: " + nickels);
            Console.WriteLine("pennies: " + pennies);

            if (change > 99)
            {
                Console.WriteLine("No can do");
                
            }
            
            
            Console.Write("Do you want more?");
            string ans = Console.ReadLine();

            Console.ReadLine();
        }

    }
}
