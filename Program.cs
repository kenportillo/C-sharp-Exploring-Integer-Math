using System;

namespace Exploring_Integer_Math
{
    class Program
    {
        static void WorkingWithIntegers()
        {
            int a = 18;
            int b = 6;
            int c = a + b;
            Console.WriteLine(c);

            // subtraction
            c = a - b;
            Console.WriteLine(c);
            
            // multiplication
            c = a * b;
            Console.WriteLine(c);

            // division
            c = a / b;
            Console.WriteLine(c);

            // Experiment Mathematics
            c = a + b - 12 * 17;
            Console.WriteLine(c);

            // Console.WriteLine("Hello World!");
        }

        static void Main(string[] args)
        {
            // WorkingWithIntegers();

            // The output demonstrates that the multiplication is performed
            // before the addition.
            int a = 5;
            int b = 4;
            int c = 2;
            int d = a + b * c;
            Console.WriteLine(d);

        }
    }
}
