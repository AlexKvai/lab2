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
                Console.WriteLine($"Vichitanie: {number5.ToString()} - {number4.ToString()} = {RomanNumber.Sub(number5, number4).ToString()} \n");
                Console.WriteLine($"Umnojenie: {number3.ToString()} * {number4.ToString()} = {RomanNumber.Mul(number3, number4).ToString()} \n");
                Console.WriteLine($"Slojenie: {number1.ToString()} + {number5.ToString()} = {RomanNumber.Add(number1, number5).ToString()} \n");
                Console.WriteLine($"Delenie: {number1.ToString()} / {number2.ToString()} = {RomanNumber.Div(number1, number2).ToString()} \n");
                
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
