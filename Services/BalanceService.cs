using System;
using TarteebBank.Services;

namespace TarteebBank.Servises
{
    public class Balance
    {   
        VOneLoggerService logger = new VOneLoggerService();
        internal void ShowBalance(decimal startBalance)
        {
            Console.Clear();
            logger.Log($"Your current balance is: ${startBalance}");
        }

        internal decimal WithdrawBalance(decimal startBalance)
        {
            Console.Clear();
            logger.Log("How much money you want to withdraw from your balance?");
            logger.Log("Enter the value: ");
            string userInputValueWithdrawBalance = Console.ReadLine();
            decimal withdrawValue = Convert.ToDecimal(userInputValueWithdrawBalance);

            if (withdrawValue > 0 && withdrawValue <= startBalance)
            {
                startBalance -= withdrawValue;
                logger.Log($"You have withdrawn ${withdrawValue} from your balance. Your current balance: ${startBalance}.");
            }
            else
            {
                logger.Log($"The withdrawal amount cannot exceed ${startBalance}.");
            }

            return startBalance;
        }

        internal decimal TopUpBalance(decimal startBalance)
        {
            Console.Clear();
            logger.Log("How much do you want to top up the balance?");
            logger.Log("Enter the value: ");
            string userInputValueTopUpBalance = Console.ReadLine();
            decimal topUpValue = Convert.ToDecimal(userInputValueTopUpBalance);

            if (topUpValue > 0)
            {
                startBalance += topUpValue;
                logger.Log($"You have topped up your balance by ${topUpValue}. Your current balance: ${startBalance}.");
            }
            else
            {
                logger.Log("The amount to be filled must be a positive number.");
            }

            return startBalance;
        }

        internal decimal GetExpenceBalance(decimal startBalance)
        {
            Console.Clear();
            logger.Log("Products to spend!!!");
            logger.Log("1 - Computer PC. Price = $2000");
            logger.Log("2 - Laptop ACER. Price = $1800");
            logger.Log("3 - MacBook Pro m5. Price = $3000");
            logger.Log("4 - Monitor ACER. Price = $1000");
            logger.Log("5 - For personal expenses. $2000");

            logger.Log("Enter your choice: ");
            string userInputChooceExpence = Console.ReadLine();
            int chooceExpence = Convert.ToInt32(userInputChooceExpence);

            decimal expenceBalance = 0;

            switch (chooceExpence)
            {
                case 1:
                    expenceBalance = 2000;
                    PrintPurchaseMade();

                    break;
                case 2:
                    expenceBalance = 1800;
                    PrintPurchaseMade();
                    break;
                case 3:
                    expenceBalance = 3000;
                    PrintPurchaseMade();
                    break;
                case 4:
                    expenceBalance = 1000;
                    PrintPurchaseMade();
                    break;
                case 5:
                    expenceBalance = 2000;
                    PrintPurchaseMade();
                    break;
                default:
                    logger.Log("Wrong choice. Run the program again!!!");
                    return startBalance;
            }

            if (chooceExpence > startBalance)
            {
                logger.Log("You don't have enough funds in your balance!!!");
            }
            else
            {
                startBalance -= expenceBalance;
                logger.Log($"You spent ${expenceBalance}. Your current balance: ${startBalance}.");
            }

            return startBalance;
        }
        private void PrintPurchaseMade()
        {
            logger.Log("The purchase was made successfully");
        }
    }
}