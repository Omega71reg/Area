using System;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {
            double a = 1,b=1,c=1;
            Area(a,b,c);
        }

        static void Area(double a, double b = 0, double c = 0)
        {
            if (b == 0 & c == 0)
            {
                Console.WriteLine("Это круг");
                double AreaКруга = Math.PI * Math.Pow(a, 2);
                Console.WriteLine(AreaКруга);
                return;
            }

            else
            {
                if( Math.Pow(c, 2) == Math.Pow(a, 2) + Math.Pow(b, 2))
                    Console.WriteLine("Прямоугольный");
                Console.WriteLine("Это треугольник");
                double p = (a + b + c) / 2;
                double AreaТреугольника = Math.Sqrt(p * (p - a) * (p - b) * (p - c));
                Console.WriteLine(AreaТреугольника);
            }
        }
    }
}
