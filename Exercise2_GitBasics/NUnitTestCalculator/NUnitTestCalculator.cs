using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Exercise1_Calculator;
using NUnit.Framework;

namespace NUnitTestCalculator
{
    public class CalculatorTest
    {
        private Calculator uut;
        [SetUp]
        public void setup()
        {
            //Arrange 
            uut = new Calculator();
        }
        [Test]
        public void Test_Add()
        {
            //Act 
            double result = uut.Add(4, 4);

            //Assert 
            Assert.That(result, Is.EqualTo(8));
        }

        [Test]
        public void Test_Subtract()
        {
            //Act 
            double result = uut.Subtract(5, 4);

            //Assert 
            Assert.That(result, Is.EqualTo(1));
        }
        [Test]
        public void Test_Multiply()
        {
            //Act 
            double result = uut.Multiply(5, 4);

            //Assert 
            Assert.That(result, Is.EqualTo(20));
        }

        [Test]
        public void Test_Power()
        {
            //Act 
            double result = uut.Power(2, 2);

            //Assert 
            Assert.That(result, Is.EqualTo(4));
        }
    }
}
