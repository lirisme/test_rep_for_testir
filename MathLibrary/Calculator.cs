 using System;

namespace MathLibrary
{
    public class Calculator
    {
        public static double Add(double a, double b)
        {
            return a + b;
        }

        public static double Subtract(double a, double b)
        {
            return a - b;
        }

        public static double Multiply(double a, double b)
        {
            return a * b;
        }

        public static double Divide(double a, double b)
        {
            if (b == 0)
            {
                throw new DivideByZeroException("Делитель не может быть равен нулю.");
            }
            return a / b;
        }

        public static bool IsPrime(int number)
        {
            if (number <= 1)
                return false;
            if (number == 2)
                return true;
            if (number % 2 == 0)
                return false;

            for (int i = 3; i <= Math.Sqrt(number); i += 2)
            {
                if (number % i == 0)
                    return false;
            }
            return true;
        }

        public static double Power(double number, double power)
        {
            return Math.Pow(number, power);
        }

        public static long Factorial(int n)
        {
            if (n < 0)
                throw new ArgumentException("Факториал отрицательного числа не определен.");

            if (n == 0 || n == 1)
                return 1;

            long result = 1;
            for (int i = 2; i <= n; i++)
            {
                result *= i;
            }
            return result;
        }

        public static bool SolveQuadratic(double a, double b, double c, out double? x1, out double? x2)
        {
            x1 = null;
            x2 = null;

            if (a == 0)
            {
                if (b != 0)
                {
                    x1 = -c / b;
                    return true;
                }
                return false;
            }

            double discriminant = b * b - 4 * a * c;

            if (discriminant < 0)
            {
                return false;
            }
            else if (discriminant == 0)
            {
                x1 = -b / (2 * a);
                return true;
            }
            else
            {
                x1 = (-b + Math.Sqrt(discriminant)) / (2 * a);
                x2 = (-b - Math.Sqrt(discriminant)) / (2 * a);
                return true;
            }
        }
    }
}
