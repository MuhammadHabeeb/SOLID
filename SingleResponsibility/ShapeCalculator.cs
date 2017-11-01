using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingleResponsibility
{
    class ShapeCalculator
    {
        internal void Calculate(object shape)
        {
            if (shape is Circle)
            {
                Circle _circle = shape as Circle;
                _circle.CalculateArea();
            }
            else if (shape is Triangle)
            {
                Triangle _triangle = shape as Triangle;
                _triangle.CalculateArea();
            }
            else if(shape is Rectangle)
            {
                Rectangle _rectangle = shape as Rectangle;
                _rectangle.CalculateArea();
            }
            else
                Console.WriteLine("Unknown Shape");
            
        }
    }
}
