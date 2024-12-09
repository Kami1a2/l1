using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Лабораторная_1_з1
{
    class Program
    {
        static void Main(string[] args)
        {
            double a, b, c;
            // Ввод знаения трех сторон треугольника
            Console.Write("Введите длину первой стороны треугольника: ");
            a = Convert.ToDouble(Console.ReadLine());

            Console.Write("Введите длину второй стороны треугольника: ");
            b = Convert.ToDouble(Console.ReadLine());

            Console.Write("Введите длину третьей стороны треугольника: ");
            c = Convert.ToDouble(Console.ReadLine());
            // Проверка, можно ли построить треугольник с данными сторонами 
            if (a + b > c && a + c > b && b + c > a)
            {
                //Проверка на прямоугольность 
                if (Math.Pow(a, 2) + Math.Pow(b, 2) == Math.Pow(c, 2) ||
                Math.Pow(a, 2) + Math.Pow(c, 2) == Math.Pow(b, 2) ||
                Math.Pow(b, 2) + Math.Pow(c, 2) == Math.Pow(a, 2))
                {
                    Console.WriteLine("Треугольник является прямоугольным.");
                }
                //Проверка на остроугольность
                else if (Math.Pow(a, 2) + Math.Pow(b, 2) > Math.Pow(c, 2) &&
                    Math.Pow(a, 2) + Math.Pow(c, 2) > Math.Pow(b, 2) &&
                    Math.Pow(b, 2) + Math.Pow(c, 2) > Math.Pow(a, 2))
                {
                    Console.WriteLine("Треугольник является остроугольным.");
                }
                //Если не прямоугольный и не остроугольный, то он тупоугольный
                else
                {
                    Console.WriteLine("Треугольник является тупоугольным.");
                }
            }
            else
            {
                Console.WriteLine("Треугольник с данными сторонами невозможно построить.");
            }
            Console.ReadLine();
        }
    }

}
