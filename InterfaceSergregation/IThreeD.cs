using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceSergregation
{
    interface IThreeD : IShape
    {
        void CalculateShapeVolume();
    }
}
