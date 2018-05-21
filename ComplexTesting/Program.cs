using ComplexNumber;
using System;

namespace ComplexTesting
{
    class Program
    {
        static void Main(string[] args)
        {
            Complex c1 = new Complex(0.0, 1.0);
            Complex c2 = new Complex(0.0, 1.0);
            Complex c3 = Complex.Reciprocal(c2);
            Complex c4 = Complex.Multiply(c1, c2);
            Console.WriteLine(c3.ToString());
            Console.ReadKey();
        }
    }
}
