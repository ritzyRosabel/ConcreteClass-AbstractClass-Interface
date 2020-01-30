﻿using System;
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
            return LengthOfPolygon * SidesOfPolygon;
        }
        public double GetArea()
        {
            return LengthOfPolygon * LengthOfPolygon;
        }
    }
}