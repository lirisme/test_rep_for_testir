 
using System;
using MathLibrary;

namespace MathLibrary.Client//блаблабла
{
    class Program
    {
        static void Main(string[] args)
        {

            double x = 10, y = 4;
            Console.WriteLine($"Сложение: {x} + {y} = {Calculator.Add(x, y)}");
            Console.WriteLine($"Вычитание: {x} - {y} = {Calculator.Subtract(x, y)}");
            Console.WriteLine($"Умножение: {x} * {y} = {Calculator.Multiply(x, y)}");

            try
            {
                Console.WriteLine($"Деление: {x} / {y} = {Calculator.Divide(x, y)}");
                Console.WriteLine($"Попытка деления на ноль: {Calculator.Divide(x, 0)}");
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine($"Ошибка при делении: {ex.Message}");
            }

            Console.WriteLine("\nПроверка простых чисел");
            int[] numbers = { 2, 7, 10, 17, 20, 23 };
            foreach (int num in numbers)
            {
                Console.WriteLine($"Число {num} простое? {Calculator.IsPrime(num)}");
            }

            Console.WriteLine("\nВозведение в степень");
            Console.WriteLine($"2^3 = {Calculator.Power(2, 3)}");
            Console.WriteLine($"5^2 = {Calculator.Power(5, 2)}");
            Console.WriteLine($"10^0.5 = {Calculator.Power(10, 0.5)}");

            Console.WriteLine("\nФакториал");
            int[] factNumbers = { 0, 1, 5, 7 };
            foreach (int num in factNumbers)
            {
                try
                {
                    Console.WriteLine($"{num}! = {Calculator.Factorial(num)}");
                }
                catch (ArgumentException ex)
                {
                    Console.WriteLine($"Ошибка для {num}: {ex.Message}");
                }
            }

            Console.WriteLine("\nРешение квадратных уравнений");
            
            SolveAndPrint(1, -3, 2, "x^2 - 3x + 2 = 0");
            
            SolveAndPrint(1, -4, 4, "x^2 - 4x + 4 = 0");
            
            SolveAndPrint(1, 1, 1, "x^2 + x + 1 = 0");

            Console.ReadKey();
        }

        static void SolveAndPrint(double a, double b, double c, string equation)
        {
            double? x1, x2;
            bool hasRoots = Calculator.SolveQuadratic(a, b, c, out x1, out x2);
            
            Console.WriteLine($"Уравнение: {equation}");
            if (hasRoots)
            {
                if (x1.HasValue && x2.HasValue && x1 != x2)
                    Console.WriteLine($"Корни: x1 = {x1:F2}, x2 = {x2:F2}");
                else if (x1.HasValue)
                    Console.WriteLine($"Корень: x = {x1:F2} (кратности 2)");
            }
            else
            {
                Console.WriteLine("Нет действительных корней");
            }
            Console.WriteLine();
        }
    }
}