using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practicum_38
{
    class Triangle : IShape
    {
        public double Side1 { get; set; }
        public double Side2 { get; set; }
        public double Side3 { get; set; }

        public Triangle(double side1, double side2, double side3) //Конструктор
        {
            Side1 = side1;  
            Side2 = side2;  
            Side3 = side3;  
        }

        public double Perimeter() //Вычисляем периметр
        {
            return Side1 + Side2 + Side3;    
        }

        
        public double Area() //Площадь
        {
            double perimeter = Perimeter() / 2;
            return Math.Sqrt(perimeter * (perimeter - Side1) * (perimeter - Side2) * (perimeter - Side3));
        }
    }
}
