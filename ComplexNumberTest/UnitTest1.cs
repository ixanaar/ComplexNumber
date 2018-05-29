using System;
using ComplexNumber;
using Xunit;

namespace ComplexNumberTest
{
    public class UnitTest1
    {
        [Fact]
        public void ModulusOfOneOneIsSqrtTwo()
        {
            Complex c = new Complex(1.0, 1.0);
            double modulus = c.Modulus;
            double sqrt2 = Math.Sqrt(2);
            Assert.Equal(sqrt2, modulus);
        }

        [Fact]
        public void ConjugateofMinusIEqualsI()
        {
            Complex c1 = new Complex(0.0, -1.0);
            Complex c2 = Complex.Conjugate(c1);
            Assert.Equal(c1.Imaginary, -c2.Imaginary);
        }

        [Fact]
        public void DivisionByZeroThrowsException()
        {
            Complex c1 = new Complex(1.0, 1.0);
            Complex c2 = new Complex(0.0, 0.0);
            Assert.Throws<DivideByZeroException>(() => Complex.Divide(c1, c2));
        }

        [Fact]
        public void ReciprocalOfZeroEqualsZero()
        {
            Complex c1 = new Complex(0.0, 0.0);
            Complex c2 = Complex.Reciprocal(c1);
            Assert.Equal(0.0, c2.Real);
            Assert.Equal(0.0, c2.Imaginary);
        }
    }
}
