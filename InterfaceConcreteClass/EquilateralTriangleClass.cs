﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceConcreteClass
{
    public class EquilateralTriangleClass : AbstractPolygon
    {
        public int Length { get; set; }
        public EquilateralTriangleClass(int length) : base(3, length)
        {
            Length = length;
        }

        public override double GetArea()
        {
            return Length * Length * Math.Sqrt(3) / 4;

        }
    }
}
