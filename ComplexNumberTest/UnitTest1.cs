using System;
using ComplexNumber;
using Xunit;

namespace ComplexNumberTest
{
    public class UnitTest1
    {
        #region Addition
        [Theory]
        [InlineData(1,1,1,1,2,2)]
        [InlineData(1,1,-1,-1,0,0)]
        [InlineData(0,0,0,0,0,0)]
        public void AdditionTheory(double c1R, double c1I, double c2R, double c2I, double expectedR, double expectedI)
        {
            Complex c1 = new Complex(c1R, c1I);
            Complex c2 = new Complex(c2R, c2I);
            Complex sum = c1 + c2;
            Assert.Equal(sum.Real, expectedR);
            Assert.Equal(sum.Imaginary, expectedI);
        }
        #endregion

        #region Subtraction
        [Theory]
        [InlineData(1, 1, 1, 1, 0, 0)]
        [InlineData(1, 1, -1, -1, 2, 2)]
        [InlineData(0, 0, 0, 0, 0, 0)]
        public void SubtractionTheory(double c1R, double c1I, double c2R, double c2I, double expectedR, double expectedI)
        {
            Complex c1 = new Complex(c1R, c1I);
            Complex c2 = new Complex(c2R, c2I);
            Complex difference = c1 - c2;
            Assert.Equal(difference.Real, expectedR);
            Assert.Equal(difference.Imaginary, expectedI);
        }
        #endregion

        #region Multiplication
        [Theory]
        [InlineData(1, 1, 1, 1, 0, 2)]
        public void MultiplicationTheory(double c1R, double c1I, double c2R, double c2I, double expectedR, double expectedI)
        {
            Complex c1 = new Complex(c1R, c1I);
            Complex c2 = new Complex(c2R, c2I);
            Complex product = c1 * c2;
            Assert.Equal(product.Real, expectedR);
            Assert.Equal(product.Imaginary, expectedI);
        }
        #endregion

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
