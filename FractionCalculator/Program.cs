using System;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace FractionCalculator
{
    class Program
    {
        static void Main()
        {
            // Налаштування кодування для українських символів
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            // Встановлюємо заголовок консолі
            Console.Title = "Калькулятор дробів";

            // Виводимо привітання з рамкою
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("╔════════════════════════════════════╗");
            Console.WriteLine("║      Вітаємо у калькуляторі дробів!      ║");
            Console.WriteLine("╚════════════════════════════════════╝");
            Console.ResetColor();

            // Запитуємо перший дріб
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write(" Введіть перший дріб (числівник/знаменник, наприклад, 1/2): ");
            Console.ResetColor();
            Fraction a = ReadFraction();

            // Запитуємо другий дріб
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write(" Введіть другий дріб (числівник/знаменник, наприклад, 1/3): ");
            Console.ResetColor();
            Fraction b = ReadFraction();

            // Запитуємо операцію
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("\n Оберіть операцію:");
            Console.WriteLine(" ┌──────────────┐");
            Console.WriteLine(" │ +  -  *  /   │");
            Console.WriteLine(" └──────────────┘");
            Console.Write(" Ваш вибір: ");
            Console.ResetColor();
            char op = Console.ReadKey().KeyChar;
            Console.WriteLine();

            // Виконуємо операцію
            Fraction result;
            try
            {
                result = op switch
                {
                    '+' => a + b,
                    '-' => a - b,
                    '*' => a * b,
                    '/' => a / b,
                    _ => throw new InvalidOperationException("Недійсна операція")
                };

                // Виводимо результат із красивим оформленням
                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.WriteLine("\n╔════════════════════════════╗");
                Console.WriteLine($"║ Результат: {a} {op} {b} = {result} ║");
                Console.WriteLine("╚════════════════════════════╝");
                Console.ResetColor();
            }
            catch (Exception ex)
            {
                // Обробка помилок із червоним кольором
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("\n╔════════════════════════════╗");
                Console.WriteLine($"║ Помилка: {ex.Message}       ║");
                Console.WriteLine("╚════════════════════════════╝");
                Console.ResetColor();
            }
        }

        static Fraction ReadFraction()
        {
            string? input = Console.ReadLine();
            string[] parts = input.Split('/');
            return new Fraction(int.Parse(parts[0]), int.Parse(parts[1]));
        }
    }

    // Клас Fraction залишається без змін, тому я його тут не повторюю
}