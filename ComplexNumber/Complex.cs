using System;

namespace ComplexNumber
{
    public class Complex
    {
        public double Real { get; }
        public double Imaginary { get; }
        public double Modulus
        {
            get
            {
                return Complex.Abs(this);
            }
        }
        public double Phase
        {
            get
            {
                return Math.Atan2(Imaginary, Real);
            }
        }

        public Complex(double real, double imaginary)
        {
            Real = real;
            Imaginary = imaginary;
        }


        #region Elementary Operations
        public static Complex Add(Complex c1, Complex c2) => c1 + c2;

        public static Complex Subtract(Complex c1, Complex c2) => c1 - c2;

        public static Complex Multiply(Complex c1, Complex c2) => c1 * c2;
        #endregion

        #region Operator Overloads
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
        #endregion

        #region Other
        public static double Abs(Complex c) =>
             Math.Sqrt(Math.Pow(c.Real, 2) + Math.Pow(c.Imaginary, 2));

        public static Complex Conjugate(Complex c) =>
             new Complex(c.Real, -c.Imaginary);

        public static Complex Reciprocal(Complex c)
        {
            if (c.Real == 0 && c.Imaginary == 0)
            {
                return new Complex(0.0, 0.0);
            }
            else
            {
                double sumOfSquares = Math.Pow(c.Real, 2) + Math.Pow(c.Imaginary, 2);
                return new Complex(c.Real / sumOfSquares, -c.Imaginary / sumOfSquares);
            }
        }

        public override string ToString() => $"({Real}, {Imaginary}i)";
        #endregion
    }
}
