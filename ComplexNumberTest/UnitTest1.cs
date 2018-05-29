using System;
using ComplexNumber;
using Xunit;

namespace ComplexNumberTest
{
    public class UnitTest1
    {
        [Theory]
        [InlineData(0, 1, 1)]
        [InlineData(1, 0, 1)]
        [InlineData(0, 0, 0)]
        public void ModulusTheory(double real, double imaginary, double expected)
        {
            Complex c = new Complex(real, imaginary);
            double modulus = c.Modulus;
            Assert.Equal(expected, modulus);
        }

        [Theory]
        [InlineData(1,1,1,-1)]
        [InlineData(1,-1,1,1)]
        [InlineData(1,0,1,0)]
        [InlineData(3,5,3,-5)]
        public void ConjugateTheory(double real, double imaginary,
            double expectedReal, double expectedImaginary)
        {
            Complex c1 = new Complex(real, imaginary);
            Complex c2 = Complex.Conjugate(c1);
            Assert.Equal(expectedReal, c2.Real);
            Assert.Equal(expectedImaginary, c2.Imaginary);
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
