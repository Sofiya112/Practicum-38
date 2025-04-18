using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practicum_38
{
    class Program
    {
        public static void Print(IShape shape)
        {
            if (shape is Triangle triangle)
            {
                Console.WriteLine("Треугольник:");
                Console.WriteLine($"Стороны: {triangle.Side1}, {triangle.Side2}, {triangle.Side3}");
                Console.WriteLine($"Периметр: {triangle.Perimeter()}");
                Console.WriteLine($"Площадь: {triangle.Area()}");
            }
            else if (shape is Disk disk)
            {
                Console.WriteLine("Круг (Диск):");
                Console.WriteLine($"Радиус: {disk.Radius}");
                Console.WriteLine($"Периметр: {disk.Perimeter()}");
                Console.WriteLine($"Площадь: {disk.Area()}");
            }
        }
        static void Main(string[] args)
        {
            IShape triangle = new Triangle(3, 4, 5); 
            IShape disk = new Disk(7);

            
            Print(triangle); // Выводим информацию о треугольнике
            Console.WriteLine(); 
            Print(disk); // Выводим информацию о круге

            Console.ReadLine(); 
        }
    }
}
