using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingleResponsibility
{
    class Program
    {
        static void Main(string[] args)
        {
            #region ISSUE
            //Calculate();
            #endregion

            #region SOLUTION
            Calculate(0);
            #endregion

            Console.ReadKey();
        }

        private static void Calculate()
        {
            Calculator _calculator = new Calculator();
            _calculator.CalulateShapeAria("circle", 10.00, 0, 0);
            _calculator.CalulateShapeAria("TRiangle", 0, 10, 5);
            _calculator.CalulateShapeAria("rectangle", 0, 12, 4);
            _calculator.CalulateShapeAria("SQUARE", 0, 6, 6);
            Console.ReadKey();
        }

        private static void Calculate(int x)
        {
            ShapeCalculator _shapeCalculator = new ShapeCalculator();

            Circle _circle = new Circle(10);
            _shapeCalculator.Calculate(_circle);

            Triangle _triangle = new Triangle(10, 5);
            _shapeCalculator.Calculate(_triangle);

            Rectangle _rectangle = new Rectangle(12,4);
            _shapeCalculator.Calculate(_rectangle);

            _shapeCalculator.Calculate(null);
        }
    }
}
