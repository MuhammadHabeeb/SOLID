using System;
using System.Collections.Generic;

namespace Open_Closed___Liscov
{
    internal class Calculator
    {
        internal void CalulateShapesAria(List<ShapeBase> shapes)
        {
            if (shapes != null && shapes.Count > 0)
            {
                foreach (ShapeBase shape in shapes)
                    shape.CalculateArea();
            }
            else
                Console.WriteLine("Unknown Shape");
        }
    }
}