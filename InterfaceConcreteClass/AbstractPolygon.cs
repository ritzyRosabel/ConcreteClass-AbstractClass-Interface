using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceConcreteClass
{
    public abstract class AbstractPolygon
    {
        public int SidesOfPolygon { get; set; }
        public int LengthOfPolygon { get; set; }

        public AbstractPolygon(int sidesOfPolygon, int length)
        {
            SidesOfPolygon = sidesOfPolygon;
            LengthOfPolygon = length;
        }

        public int GetPerimeter()
        {
            return LengthOfPolygon * SidesOfPolygon;
        }
        public abstract double GetArea();

    }
}
