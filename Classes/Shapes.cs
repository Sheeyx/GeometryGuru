using System;

namespace Geometry
{
    public class Shapes
    {
        public void TriangleCalcule(){
            Console.Write("Enter length: ");
            decimal baseLength = Convert.ToDecimal(Console.ReadLine());
            Console.Write("Enter height: ");
            decimal height = Convert.ToDecimal(Console.ReadLine());
            
            decimal area = baseLength * height * (1/2);

            // Display the result
            Console.WriteLine("The area of the triangle is: " + area);
        }

        public void RectangleCalculate(){
            Console.Write("Enter length: ");
            decimal length = Convert.ToDecimal(Console.ReadLine());
            Console.Write("Enter width: ");
            decimal width = Convert.ToDecimal(Console.ReadLine());

            // Calculate the area
            decimal area = length * width;

            // Display the result
            Console.WriteLine("The area of the rectangle is: " + area);

        }

        public void CircleCalculate(){
            Console.Write("Enter radius: ");
            double radius = Convert.ToDouble(Console.ReadLine());

            // Calculate the area
            double area = Math.PI * Math.Pow(radius,2);

            // Display the result
            Console.WriteLine("The area of the circle is: " + area);

        }
    }
}