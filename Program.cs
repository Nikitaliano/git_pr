using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ome_work
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Circle circle = new Circle();
            Square1 square1 = new Square1();
            Console.Write("Введите радиус окружности: ");
            double R = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите сторону квадрата: ");
            double A = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine($"Площадь окружности - {circle.CalculateAreaCircle(R)}");
            Console.WriteLine($"Периметр окружности - {circle.CalculatePerimetrCircle(R)}");
            Console.WriteLine($"Площадь квадрата - {square1.calculteSquareArea(A)}");
            Console.WriteLine($"Периметр квадрата - {square1.calculateSquarePerimetr(A)}");
            Console.ReadKey();
        }
    }
}
