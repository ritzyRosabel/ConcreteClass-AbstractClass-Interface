using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceConcreteClass
{
    public class OctagonClass : IPolygon
    {
        // when implementing an interface you implement all its abstract method and propertie
        // use public access modifiers on the imlemented methods and properties
        //you can also explicitly implement an interface methods by using this syntax <Interface Name>.<Method Name>
        // when explicitly implementing interface method do not make use of the public modifier
       
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
        double IPolygon.GetArea()
        {
            return  2 * (1 + Math.Sqrt(2)) *( LengthOfPolygon * LengthOfPolygon);
        }
        public void Search(string text)
        {
            Console.WriteLine("Searching in file");
        }
    }
}
