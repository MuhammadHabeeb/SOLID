using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Open_Closed___Liscov
{
    class Rectangle : ShapeBase
    {
        public double Width { get; set; }
        public double Height { get; set; }
        public double Area { get; set; }
        public Rectangle(double _width, double _height)
        {
            Width = _width; Height = _height;
        }
        internal override void CalculateArea()
        {
            Area = 0;
            if (Width > 0 && Height > 0)
            {
                Area = Width * Height;
                Console.WriteLine($"rectangle Area = {(Area == 0 ? 0.0 : Area)}");
            }
        }
    }
}
