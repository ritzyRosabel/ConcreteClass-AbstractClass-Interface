using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceConcreteClass
{
    class Program
    {
        //this project explains to me the difference between Concrete class, Abstract Class and Interfaces
        static void Main(string[] args)
        {
            SquareClass square = new SquareClass(4);
            Display("Square", square);

            EquilateralTriangleClass triangle = new EquilateralTriangleClass(3);
             Display("Triangle", triangle);

            OctagonClass octagon = new OctagonClass(8, 7);
            Display("Octagon", octagon);
            Console.ReadLine();

        }

        private static void Display(string polygonType, dynamic polygon)
        {
            Console.WriteLine("{0} number of sides is  {1}", polygonType, polygon.SidesOfPolygon);
            Console.WriteLine("{0} Length of side is  {1}", polygonType, polygon.LengthOfPolygon);
            Console.WriteLine("{0} Perimeter is  {1}", polygonType, polygon.GetPerimeter());
            Console.WriteLine("{0} Area is  {1}", polygonType, polygon.GetArea());
            Console.WriteLine("");


        }
    }
}
