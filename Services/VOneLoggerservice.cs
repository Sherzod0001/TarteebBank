using System;

namespace TarteebBank.Services
{
    internal class VOneLoggerService : ILoggerService
    {
        public void Log(string message)
    {
            Console.WriteLine(message);
        }
    }
}
