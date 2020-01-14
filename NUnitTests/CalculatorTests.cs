using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;
using bdd;

namespace NUnitTests
{
    [TestFixture]
    public class CalculatorTests
    {
        [Test]
        public void AddTwoSmallNumbers()
        {
            //Given
            var calculator = new BoringCalculator();
            var a = 5.0;
            var b = 10.0;

            //When
            var sum = calculator.Add(a, b);

            //Then
            Assert.AreEqual(15.0, sum);
        }
    }
}
