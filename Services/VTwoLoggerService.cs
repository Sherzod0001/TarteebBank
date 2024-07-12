using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TarteebBank.Services
{
    internal class VTwoLoggerService : ILoggerService
    {
        public void Log(string message)
        {
            Console.BackgroundColor = ConsoleColor.Cyan;
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.WriteLine($"{message}");
        }
    }
}
