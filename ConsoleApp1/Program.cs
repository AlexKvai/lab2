using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                RomanNumber number1 = new RomanNumber(15); RomanNumber number2 = new RomanNumber(4); RomanNumber number3 = new RomanNumber(10);
                RomanNumber number4 = new RomanNumber(50); RomanNumber number5 = new RomanNumber(89);
                Console.WriteLine($"Сложение: {number1.ToString()} + {number5.ToString()} = {(number1 + number5).ToString()}");
                Console.WriteLine($"Деление: {number1.ToString()} / {number2.ToString()} = {(number1 / number2).ToString()}");
                Console.WriteLine($"Вычитание: {number5.ToString()} - {number4.ToString()} = {(number5 - number4).ToString()}");
                Console.WriteLine($"Умножение: {number2.ToString()} * {number3.ToString()} = {(number2 * number3).ToString()}");

                RomanNumber[] numbers = { number1, number2, number3, number4, number5 };
                Array.Sort(numbers);
                Console.WriteLine("Rezult sortirovki \n");
                foreach (var number in numbers)
                {
                    Console.WriteLine($"{number.ToString()} \n");
                }

            }
            catch (RomanNumberException ex)
            {
                Console.WriteLine($"Ошибка: {ex.Message}");
            }

        }
    }
}
