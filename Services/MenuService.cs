using System;
using TarteebBank.Services;

namespace TarteebBank.Servises
{
    internal class Menu
    {
        internal void ShowMenu()
        {
            VOneLoggerService logger = new VOneLoggerService();
            logger.Log("\nChoose one below!!!");
            logger.Log("1 - Balance check.");
            logger.Log("2 - Withdraw money from the balance.");
            logger.Log("3 - Topping up the balance.");
            logger.Log("4 - Spending");
            logger.Log("5 - Exit the program");
        }
    }
}