using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace shapeCalculator
{
    class Triangle: Ishapes
    {
        public double height { get; set; }
        public double width { get; set; }

        public double Area()
        {
            return (height * width) / 2;
        }

        public double perimeter()
        {
            double sideC = (height * height) + (width * width);
            sideC = Math.Sqrt(sideC);
            return height + width + sideC;
        }
    }
}
