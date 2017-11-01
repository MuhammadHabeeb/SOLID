using System;

namespace SingleResponsibility
{
    internal class Calculator
    {
        internal void CalulateShapeAria(string shape, double diameter, double height, double width)
        {
            double _area = 0;
            switch (shape.ToLower())
            {
                case "circle":
                    _area = Math.Round((Math.Sqrt(diameter / 2) * 3.14), 2);
                    Console.WriteLine($"Circle Area  = {(_area == 0 ? 0.0 : _area)}");
                    break;
                case "triangle":
                    _area = 0.5 * width * height;
                    Console.WriteLine($"triangle Area  = {(_area == 0 ? 0.0 : _area)}");
                    break;
                case "rectangle":
                    _area = width * height;
                    Console.WriteLine($"rectangle Area = {(_area == 0 ? 0.0 : _area)}");
                    break;
                default:
                    Console.WriteLine("Unknown Shape");
                    break;
            }
        }
    }
}