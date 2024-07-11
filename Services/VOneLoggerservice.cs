using System;

namespace TarteebBank.Services
{
    internal class VOneLoggerService : LoggerService
    {
        internal override void Log(string message)
        {
            Console.WriteLine(message);
        }
    }
}
