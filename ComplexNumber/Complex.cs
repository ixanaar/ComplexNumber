using System;

namespace ComplexNumber
{
    public class Complex
    {
        public double Real { get; }
        public double Imaginary { get; }

        public Complex(double real, double imaginary)
        {
            Real = real;
            Imaginary = imaginary;
        }


        //Elementary operations
        public static Complex Add(Complex c1, Complex c2) => c1 + c2;

        public static Complex Subtract(Complex c1, Complex c2) => c1 - c2;

        public static Complex Multiply(Complex c1, Complex c2) => c1 * c2;

        //Operator overloads
        public static Complex operator +(Complex c1, Complex c2) => 
            new Complex(c1.Real + c2.Real, c1.Imaginary + c2.Imaginary);


        public static Complex operator -(Complex c1, Complex c2) =>
            new Complex(c1.Real - c2.Real, c1.Imaginary - c2.Imaginary);

        public static Complex operator *(Complex c1, Complex c2)
        {
            double real = (c1.Real * c2.Real) - (c1.Imaginary * c2.Imaginary);
            double imaginary = (c1.Imaginary * c2.Real) - (c1.Real * c2.Imaginary);
            return new Complex(real, imaginary);
        }

        public override string ToString() => $"{Real} + {Imaginary}i";
    }
}
