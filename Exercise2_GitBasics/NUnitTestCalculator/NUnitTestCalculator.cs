﻿using System;
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

        [Test]
        public void Test_Dividend()
        {
            //Act 
            double result = uut.Divide(10, 2);

            //Assert 
            Assert.That(result, Is.EqualTo(5));
        }

        [Test]

        public void Test_Divide_byZero_withTwoArguments()
        {
            uut.Clear();
            //Act og assert
            // Assert.Throws<Exception>(() => uut.Divide(2));
            Assert.That(() => uut.Divide(2, 0), Throws.TypeOf<Exception>());
        }

        [Test]
        public void Test_Overloaded_Add()
        {


            //Act 
            double result = uut.Add(10);


            //Assert 
            Assert.That(result, Is.EqualTo(10));
        }

        [Test]
        public void Test_Overloaded_Subtract()
        {

            uut.Add(10); 
            //Act 
            double result = uut.Subtract(25);


            //Assert 
            Assert.That(result, Is.EqualTo(15));
        }

        [Test]
        public void Test_Overloaded_Multiply()
        {
            uut.Add(15);
            uut.Subtract(30);
            //Act 
            double result = uut.Multiply(2);

            //Assert 
            Assert.That(result, Is.EqualTo(30));
        }

        [Test]
        public void Test_Overloaded_Power()
        {
            uut.Add(2);
            uut.Subtract(6);
            uut.Multiply(2);
            //Act 
            double result = uut.Power(2);

            //Assert 
            Assert.That(result, Is.EqualTo(256));
        }

        [Test]
        public void Test_Overloaded_Divide()
        {
            uut.Add(2);
            uut.Subtract(6);
            uut.Multiply(2);
            uut.Power(2);
            //Act 
            double result = uut.Divide( 1000);

            //Assert 
            Assert.That(result, Is.EqualTo(3.90625));
        }

        [Test]
        public void Test_ThatClearSetsValueToZero()
        {
            double result = uut.Add(25, 25); 
            uut.Clear();
            result = uut.Multiply(20);
            Assert.That(result, Is.EqualTo(0));
        }
        
        [Test]
        public void Test_IfExceptionIsThrown()
        {
            uut.Clear();
            //Act og assert
           // Assert.Throws<Exception>(() => uut.Divide(2));
            Assert.That(() => uut.Divide(2), Throws.TypeOf<Exception>());
        }
        

    }
}
