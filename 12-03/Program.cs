using System;

namespace MyApplication
{
    class Program
    {

        static double Add(double a, double b)
        {
            return a + b;
        }

        static double Sub(double a, double b)
        {
            return a - b;
        }

        static double Mul(double a, double b)
        {
            return a * b;
        }

        static double Div(double a, double b)
        {
            if (b == 0)
            {
                Console.WriteLine("Cannot divide by zero");
                return 0;
            }
            return a / b;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Enter x: ");
            double x = double.Parse(Console.ReadLine());

            Console.WriteLine("Enter y: ");
            double y = double.Parse(Console.ReadLine());

            Console.WriteLine("Sum: " + Add(x, y));
            Console.WriteLine("Sub: " + Sub(x, y));
            Console.WriteLine("Mul: " + Mul(x, y));
            Console.WriteLine("Div: " + Div(x, y));
        }
    }
}
