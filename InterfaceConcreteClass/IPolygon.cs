using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceConcreteClass
{
    public interface IPolygon
    {
        //interface doesnt contain  fields and variables
        // they cn have propertie, methods, indexers and events
        // do not put access modifiers when decllaring members for interface
        // interface cannot have constructors
        int SidesOfPolygon { get; set; }
        int LengthOfPolygon { get; set; }

        int GetPerimeter();

        double GetArea();

    }
}
