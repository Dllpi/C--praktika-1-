using System;

namespace Дополнительное_задание_
{
    class Program
    {
        static void Main(string[] args)
        {
            double a, b, c;

            Console.Write($"Введите первыую сторону: ");
            a = Convert.ToDouble(Console.ReadLine());
            Console.Write($"Введите вторую сторону: ");
            b = Convert.ToDouble(Console.ReadLine());
            Console.Write($"Введите третию сторону: ");
            c = Convert.ToDouble(Console.ReadLine());

            Triangle t1 = new Triangle(a, b, c);

            t1.output(a, b, c);

            Console.WriteLine("Площадь: {0}", t1.perimeter(a, b, c));

            Console.WriteLine("Периметр: {0}", t1.square(a, b, c));

            if (t1.Check(a, b, c) == true)
            {
                Console.WriteLine("Треугольник существует");
            }
            else
            {
                Console.WriteLine("Треугольник не существует");
            }
        }
    }
}
