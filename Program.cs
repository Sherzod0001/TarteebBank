using System;
using TarteebBank.Services;
using TarteebBank.Servises;

namespace TarteebBank
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            ILoggerService logger = new VTwoLoggerService();
            
            try
            {
                

                var menu = new Menu();
                var password = new Password();
                var balance = new Balance();
                Console.ForegroundColor = ConsoleColor.Magenta;
                string userInputThoughtPassword = password.GetUserValueByPassword("Create a unique password to use the program!!!\n" +
                                                                                  "Your password is: ");

                logger.Log("Password created.........");


                Console.Clear();

                logger.Log("Password created.........");
                logger.Log("\nWelcome to TarteebBank!!!");
                logger.Log("You've been awarded 10,000 for being accepted into the Tarteeb team!\n" +
                             "Now you can spend it!!!\n");

                logger.Log("Enter your password to use the program!!!");

                string userInputPassword;

                string yesOrNo;
                do
                {
                    do
                    {
                        userInputPassword = password.GetUserValueByPassword("Enter password: ");

                    } while (userInputPassword != userInputThoughtPassword);
                    {
                        if (userInputPassword == userInputThoughtPassword)
                        {
                            decimal startBalance = 10000.00m;

                            menu.ShowMenu();

                            logger.Log("Enter your choice: ");
                            string userInputValue = Console.ReadLine();
                            int userInput = Convert.ToInt32(userInputValue);

                            switch (userInput)
                            {
                                case 1:

                                    balance.ShowBalance(startBalance);
                                    break;

                                case 2:
                                    balance.WithdrawBalance(startBalance);
                                    break;

                                case 3:
                                    balance.TopUpBalance(startBalance);
                                    break;

                                case 4:
                                    balance.GetExpenceBalance(startBalance);
                                    break;

                                case 5:
                                    logger.Log("Exit the program....");
                                    logger.Log("Thank you for using our program");
                                    return;

                                default:
                                    logger.Log("Wrong choice. Try again.");
                                    break;
                            }
                        }
                    }

                    logger.Log("\nDo you want to continue? (yes / no)");
                    yesOrNo = Console.ReadLine();

                } while (yesOrNo.ToLower() == "yes" || yesOrNo.ToLower() == "y");
                {
                    logger.Log("Thank you for using our program");
                }

                static string PrintMassege(string massege)
                {
                    return (massege);
                }
            }
            catch (Exception ex)
            {
                logger.Log(ex.Message);
                logger.Log("Restart the program"); 
            }
        }
    }
}
