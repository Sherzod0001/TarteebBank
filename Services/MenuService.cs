using System;

namespace TarteebBank.Servises
{
    internal class Menu
    {
        internal void ShowMenu()
        {
           Console.WriteLine("\nChoose one below!!!");
            Console.WriteLine("1 - Balance check.");
            Console.WriteLine("2 - Withdraw money from the balance.");
            Console.WriteLine("3 - Topping up the balance.");
            Console.WriteLine("4 - Spending");
            Console.WriteLine("5 - Exit the program");
        }
    }
}