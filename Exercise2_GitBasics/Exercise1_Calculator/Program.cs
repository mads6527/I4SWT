﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise1_Calculator
{

    public class Calculator
    {

        private double _latestCalculation;
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Calculator num = new Calculator();
            num.Accumulator = 24;
            Console.Write("Sets latest calculation to");
            Console.WriteLine(num.Accumulator);
            Console.Write("Clears lates calculation");
            num.Clear();
            Console.WriteLine(num.Accumulator);

            Console.Write("25 + 0 = ");
            double result = num.Add(25);
            Console.WriteLine(result);
            Console.Write("100 - 25 = ");
            result = num.Subtract(100);
            Console.WriteLine(result);

        }

        public double Add(double a, double b)
        {
            double sum = a + b;
            return sum;
        }

        public double Subtract(double a, double b)
        {
            double sum = a - b;
            return sum;
        }

        public double Multiply(double a, double b)
        {
            double sum = a * b;
            return sum;
        }

        public double Power(double x, double exp)
        {
            double sum = Math.Pow(x, exp);
            return sum;
        }

        public double Divide(double dividend, double divisor)
        {
            double sum = dividend / divisor;
            if (divisor != 0)
            {
                return sum;
            }
            else
            {
                throw new Exception("Divided by zero");
            }
        }

        public double Accumulator
        {
            get
            {
                return _latestCalculation;

            }
            set
            {
                _latestCalculation = value;

            }
        }

        public void Clear()
        {
            _latestCalculation = 0;
        }

        public double Add(double a)
        {
            double sum = a + _latestCalculation;
            _latestCalculation = sum;
            return sum;
        }

        public double Subtract(double a)
        {
            double sum = a - _latestCalculation;
            _latestCalculation = sum;
            return sum;
        }

        public double Multiply(double a)
        {
            double sum = a * _latestCalculation;
            _latestCalculation = sum;
            return sum;
        }

        public double Power(double x)
        {
            double sum = Math.Pow(x, _latestCalculation);
            _latestCalculation = sum;
            return sum;
        }

        public double Divide(double dividend)
        {
            double sum = dividend / _latestCalculation;

            if (_latestCalculation != 0)
            {
                _latestCalculation = sum;
                return sum;
            }

            else
            {
                throw new Exception("Divided by zero");
            }
        }


    }
}
