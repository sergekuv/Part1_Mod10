using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_10_5
{
    class ConsoleLogger : ILogger
    {
        public void WriteError(string message)
        {
            ConsoleColor currentColor = Console.ForegroundColor;
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"{DateTime.Now.ToString("yyyy/MM/dd hh:mm:ss.ffff")}\tINFO\t{message}");
            Console.ForegroundColor = currentColor;
        }

        public void WriteInfo(string message)
        {
            ConsoleColor currentColor = Console.ForegroundColor;
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine($"{DateTime.Now.ToString("yyyy/MM/dd hh:mm:ss.ffff")}\tINFO\t{message}");
            Console.ForegroundColor = currentColor;
        }
    }
}
