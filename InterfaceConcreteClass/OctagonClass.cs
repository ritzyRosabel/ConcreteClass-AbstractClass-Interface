using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceConcreteClass
{
    public class OctagonClass : IPolygon
    {
        public int SidesOfPolygon { get; set; }
        public int LengthOfPolygon { get; set; }
        public OctagonClass(int side, int length)
        {
            SidesOfPolygon = side;
            LengthOfPolygon = length;
        }
        public int GetPerimeter()
        {
            return 8 * LengthOfPolygon ;
        }
        public double GetArea()
        {
            return  2 * (1 + Math.Sqrt(2)) *( LengthOfPolygon * LengthOfPolygon);
        }
    }
}
