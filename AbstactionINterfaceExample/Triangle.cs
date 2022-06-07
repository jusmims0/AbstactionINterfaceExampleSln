using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstactionINterfaceExample
{
    public class Triangle : IShape, IColour
    {

        private double _base;
        private double _height;
        private string _colour;
        public Triangle(double baselength, double height, string colour)
        {

            _base = baselength;
            _height = height;
            _colour = colour;
        }

        public double GetArea()
        {
            return 0.5 * _base * _height;

        }

        public string GetColour()
        {
            return _colour;
        }
    }

}