using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceConcreteClass
{
    public class ConcretePolygon
    {
        public int SidesOfPolygon { get; set; }
        public int LengthOfPolygon { get; set; }

        public ConcretePolygon(int sidesOfPolygon, int length )
        {
            SidesOfPolygon = sidesOfPolygon;
            LengthOfPolygon = length;
        }

        public int GetPerimeter()
        {
            return LengthOfPolygon * SidesOfPolygon;
        }
        public virtual int GetArea()
        {
            throw new NotImplementedException();
        }
    }
}
