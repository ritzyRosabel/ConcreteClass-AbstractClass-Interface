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
        //  If this code works, then it was writen by Rosabel Olugbenga. If it doesn't, then i can only say one thing  "IT IS WHAT IT IS".

        static void Main(string[] args)
        {
            SquareClass square = new SquareClass(4);
            Display("Square", square);

            EquilateralTriangleClass triangle = new EquilateralTriangleClass(3);
             Display("Triangle", triangle);

            OctagonClass octagon = new OctagonClass(8, 7);// this object can access all members of the class and implicitly implemented members of interface
            Display("Octagon", octagon);
            
            IPolygon octagon1  = new OctagonClass(8, 7);// this object can only access implicitly and explicitly implemented members of the interface
            Display("Octagon", octagon1);
            
           
            
            

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
