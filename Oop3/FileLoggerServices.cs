using System;

namespace Oop3
{
    class FileLoggerServices : ILoggerService
    {
        public void Log()
        {
            Console.WriteLine("Dosyaya loglandı");
        }
    }
}
