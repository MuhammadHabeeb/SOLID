using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Open_Closed___Liscov
{
    class Program
    {
        static void Main(string[] args)
        {
            Calculate();
            Console.ReadKey();
        }

        private static void Calculate()
        {
            Calculator _calculator = new Calculator();
            List<ShapeBase> _shapes = new List<ShapeBase>();
            _shapes.Add(new Circle(10));
            _shapes.Add(new Triangle(10,12.5));
            _shapes.Add(new Rectangle(10,6));
            _calculator.CalulateShapesAria(_shapes);
        }
    }
}
