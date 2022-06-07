using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstactionINterfaceExample
{
    public class Rectangle : IShape
    {
        private double _length;
        private double _breadth;
       
     public Rectangle(double length, double breadth)
        {
            _length = length;
            _breadth = breadth;

        }

        public double GetArea()
        {
            return _length * _breadth;
        }
    }
}
