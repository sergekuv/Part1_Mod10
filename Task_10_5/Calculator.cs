using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_10_5
{
    public delegate double CalcAction (double x, double y);
     
    class Calculator : ISummable
    {
        string input;
        double a, b;
        CalcAction action;
        bool isCorrect;
        public bool IsCorrect { get { return isCorrect; } }

        ILogger logger;
        internal Calculator(string input, ILogger logger)        
        {
            this.logger = logger;
            logger.WriteInfo("Creating Calculator");
            this.input = input;
                if (input.Contains('+'))
                {
                    action = Sum;
                    string[] operands = input.Split('+');
                    if (operands.Length == 2 && double.TryParse(operands[0].Trim(), out a) && double.TryParse(operands[1].Trim(), out b))
                    {
                        isCorrect = true;   
                    }
                }
                if (!isCorrect)
                {
                    logger.WriteError($"Failed to create Calculator with given input {input}");
                    throw new ArgumentException($"Не получается интерпретирвоать выражение: {input}");
                }
            logger.WriteInfo("Calculator Created");
        }
        public double Sum(double x, double y) => x + y; 

        public double Calculate()
        {
            logger.WriteInfo("Calculator: Calculate method called");
            return action(a, b);
        }
        public void Display()       // Это было создано в первой части задачи, еще до логгера. 
        {
            logger.WriteInfo("Calculator: Display method called");
            Console.WriteLine($"Введено: {input}. Выражение {(IsCorrect ? "корректно": "НЕкорректно")}");
            Console.WriteLine($"Выражение для вычисления: {action.Method}; аргументы: {a}, {b}");
        }
    }
}
