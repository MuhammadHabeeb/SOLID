﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingleResponsibility
{
    class Circle
    {
        public double Diameter { get; set; }
        public double Area { get; set; }
        public Circle(double diameter)
        {
            Diameter = diameter;
        }
        public void CalculateArea()
        {
            Area = 0;
            if (Diameter > 0)
            {
                Area = Math.Round((Math.Sqrt(Diameter / 2) * 3.14), 2);
                Console.WriteLine($"Circle Area  = {(Area == 0 ? 0.0 : Area)}");
            }
        }
    }
}
