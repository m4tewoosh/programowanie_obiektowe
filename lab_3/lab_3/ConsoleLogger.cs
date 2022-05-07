using System;

namespace lab_3
{
    public class ConsoleLogger : WriterLogger
    {
        public ConsoleLogger()
        {
            writer = Console.Out;
        }
    }
}
