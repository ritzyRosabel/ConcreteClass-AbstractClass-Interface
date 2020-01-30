using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceConcreteClass
{
    public class SquareClass : ConcretePolygon
    {
        public int Length { get; set; }

        public SquareClass(int length) :base(4,length)
        {
            Length = length;
        }
        public override int GetArea()
        {
            return Length * Length;
        }
    }
}
