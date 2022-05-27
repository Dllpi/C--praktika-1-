using System;
using System.Collections.Generic;
using System.Text;

namespace Дополнительное_задание_
{
    class Triangle
    {
        private double a;
        private double b;
        private double c;
/*        private double p;*/

        public Triangle(double a1, double b1, double c1)
        {
            a = a1;
            b = b1;
            c = c1;
        }

        public void output(double a, double b, double c)
        {
            Console.WriteLine("Сторона a: {0}", a);
            Console.WriteLine("Сторона b: {0}", b);
            Console.WriteLine("Сторона c: {0}", c);
        }

        public double perimeter(double a, double b, double c)
        {
            return (a + b + c);
        }

        public double square(double a, double b, double c)
        {
            double p = (a + b + c) / 2;
            return Math.Sqrt(p * (p-a) * (p-b) * (p-c));
        }

        public bool Check(double a, double b, double c)
        {
            if (a + b > c & a + c > b & b + c > a) 
            { return true; }

            else 
            { return false; }
        }
    }
}
