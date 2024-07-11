using System;

namespace TarteebBank.Servises
{
    internal class Password
    {
        internal string GetUserValueByPassword(string massege)
        {
            Console.Write(massege);
            return Console.ReadLine();
        }
    }
}