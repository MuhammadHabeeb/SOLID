using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingleResponsibility
{
    class Triangle
    {
        public double Base { get; set; }
        public double Height { get; set; }
        public double Area { get; set; }
        public Triangle(double _base, double _height)
        {
            Base = _base; Height = _height;
        }
        public void CalculateArea()
        {
            Area = 0;
            if (Base>0&&Height>0)
            {
                Area = 0.5 * Base * Height;
                Console.WriteLine($"triangle Area  = {(Area == 0 ? 0.0 : Area)}");
            }
        }
    }
}
