using System;
using System.Collections.Generic;
using System.Text;

namespace Oop3
{
    class DatabaseLoggerServices : ILoggerService
    {
        public void Log()
        {
            Console.WriteLine("Veri tabanına loglandı");
        }
    }
}
