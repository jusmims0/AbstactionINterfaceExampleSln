using System;
using System.Collections.Generic;

namespace AbstactionINterfaceExample
{
    internal class Program
    {
        static void Main(string[] args)
        {

            List<IShape> listofShapes = new List<IShape>();
            
            Triangle triangle = new Triangle(4, 7, "Yellow");

            Rectangle rectangle = new Rectangle(4, 5);


            listofShapes.Add(triangle);
            listofShapes.Add(rectangle); 


            foreach(IShape shape in listofShapes)
            {
                Console.WriteLine(shape.GetArea());
            }


            // Console.WriteLine(triangle.GetArea());
            //Console.WriteLine(triangle.GetColour());
        }
    }
}
