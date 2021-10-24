using System;

namespace Task_10_5
{
    /// Задание 1
    /// Создайте консольный мини-калькулятор, который будет подсчитывать сумму двух чисел. Определите интерфейс для функции сложения числа и реализуйте его.
    /// Дополнительно: добавьте конструкцию Try/Catch/Finally для проверки корректности введённого значения.
    /// Задание 2
    /// Реализуйте механизм внедрения зависимостей: добавьте в мини-калькулятор логгер, используя материал из скринкаста юнита 10.1.
    /// Дополнительно: текст ошибки, выводимый в логгере, окрасьте в красный цвет, а текст события — в синий цвет.

    class Program
    {

        static void Main(string[] args)
        {
            ConsoleLogger logger = new();
            while (true)
            {
                Console.WriteLine("\nВведите выражение для вычисления. Например, 1 + 2 \n Пока поддерживается только операция сложения\n" +
                                    "Для завершения работы введите  END");
                string userInput = Console.ReadLine().ToLower();
                if (userInput == "end") break;
                try
                {
                    Calculator calc = new Calculator(userInput, logger);
                    calc.Display();
                    Console.WriteLine($"Результат вычисления: {calc.Calculate()}");
                }
                catch (ArgumentException ex)
                {
                    logger.WriteError(ex.Message);
                }
                catch (Exception ex)
                {
                    logger.WriteError(ex.ToString());
                }
            }
            Console.WriteLine("-- end --");
        }

    }
}
