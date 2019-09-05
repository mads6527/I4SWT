using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise1_Calculator
{

    public class Calculator
    {
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
                Accumulator = 0;
                throw new Exception("Divided by zero. Accumulator is set to 0");
            }
        }

        public double Accumulator
        {
            get { return Accumulator; }
            set
            {
                Accumulator = value;
            }
        }

        public void Clear()
        {
            Accumulator = 0;
        }

        public double Add(double a)
        {
            double sum = a + Accumulator;
            Accumulator = sum;
            return sum;
        }

        public double Subtract(double a)
        {
            double sum = a - Accumulator;
            Accumulator = sum;
            return sum;
        }

        public double Multiply(double a)
        {
            double sum = a * Accumulator;
            Accumulator = sum;
            return sum;
        }

        public double Power(double x)
        {
            double sum = Math.Pow(x, Accumulator);
            Accumulator = sum;
            return sum;
        }

        public double Divide(double dividend)
        {
            double sum = dividend / Accumulator;

            if (Accumulator != 0)
            {
                Accumulator = sum;
                return sum;
            }

            else
            {
                Accumulator = 0;
                throw new Exception("Divided by zero. Accumulator is set to 0");
            }
        }
    }
}
