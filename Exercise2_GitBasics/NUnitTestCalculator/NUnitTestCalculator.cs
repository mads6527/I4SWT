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
        Calculator num = new Calculator();
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

        [Test]
        public void Test_Dividend()
        {
            //Act 
            double result = uut.Divide(10, 2);

            //Assert 
            Assert.That(result, Is.EqualTo(5));
        }

        [Test]
        public void Test_Overloaded_Add()
        {


            //Act 
            double result = uut.Add(10);


            //Assert 
            Assert.That(result, Is.EqualTo(10));
            num.Accumulator = result;
        }

        [Test]
        public void Test_Overloaded_Subtract()
        {

            //Act 
            double result = uut.Subtract(25);


            //Assert 
            Assert.That(result, Is.EqualTo(15));
            num.Accumulator = result;
        }

        [Test]
        public void Test_Overloaded_Multiply()
        {
            //Act 
            double result = uut.Multiply(2);

            //Assert 
            Assert.That(result, Is.EqualTo(30));
        }


    }
}
