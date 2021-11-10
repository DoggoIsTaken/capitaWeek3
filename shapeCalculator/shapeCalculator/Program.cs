using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace shapeCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Rectangle rec = new Rectangle();
            Circle circle = new Circle();
            Triangle tri = new Triangle();

            Console.WriteLine("Choose a shape. 1 for Rectangle , 2 for Circle and 3 for Triangle");
            int chosenShape =Convert.ToInt32(Console.ReadLine());

            double a = 0;
            double b = 0;
            double c = 0.0;
            double area = 0.0;
            double perimeter = 0.0; 

            switch (chosenShape)
            {
                case 1:
                    Console.WriteLine("Input Height");
                    a = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Input Width");
                    b = Convert.ToDouble(Console.ReadLine());

                    rec.height = a;
                    rec.width = b;

                    area = rec.Area();
                    Console.WriteLine("Area of rectangle is:{0:F}", area);

                    perimeter = rec.perimeter();
                    Console.WriteLine("Perimeter of rectangle is :{0:F}", perimeter);
                    break;

                case 2:
                    Console.WriteLine("Input Radius");
                    c = Convert.ToDouble(Console.ReadLine());
                    circle.radius = c;
                    area = circle.Area();
                    Console.WriteLine("Area of circle is:{0:F}", area);
                    perimeter = circle.perimeter();
                    Console.WriteLine("Perimeter of Circle is:{0:F}", perimeter);
                    break;

                case 3:
                    Console.WriteLine("Input Height");
                    a = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Input Width");
                    b = Convert.ToDouble(Console.ReadLine());

                    tri.height = a;
                    tri.width = b;

                    area = tri.Area();
                    Console.WriteLine("Area of Triangle is: {0:F}", area);

                    perimeter = tri.perimeter();
                    Console.WriteLine("Perimeter of Triangle is: {0:F}", perimeter);
                    break;
            }
            Console.ReadLine();
        }
    }
}
