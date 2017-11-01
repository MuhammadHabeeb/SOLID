using System;
using System.Collections.Generic;

namespace InterfaceSergregation
{
    internal class Calculator
    {
        internal void CalulateShapesAria(List<IShape> shapes)
        {
            if (shapes != null && shapes.Count > 0)
            {
                foreach (IShape shape in shapes)
                    shape.CalculateShapeArea();
            }
            else
                Console.WriteLine("Unknown Shape");
        }
    }
}