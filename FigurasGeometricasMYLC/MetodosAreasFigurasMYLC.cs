using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FigurasGeometricasMYLC
{
    public class Circle_MYLC : IAreaCalculator_MYLC
    {
        private double _radius;
        public Circle_MYLC(double radius) => _radius = radius;

        public double CalculateArea_MYLC() => Math.PI * _radius * _radius;
    }

    public class Square_MYLC : IAreaCalculator_MYLC
    {
        private double _side;
        public Square_MYLC(double side) => _side = side;

        public double CalculateArea_MYLC() => _side * _side;
    }


}
