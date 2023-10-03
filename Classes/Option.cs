using System;

namespace Geometry
{
    public class Option
    {
       public void ShowMenu()
        {
            Console.WriteLine("Welcome to our GeometryGuru console application!");
            Console.WriteLine("Do you want to know the area of Triangle, Rectangle and Circle?");
            Console.WriteLine("1.Triangle\n2.Rectangle\n3.Circle");
            Console.Write("Choose an option: ");
        }
        public void Report()
        {
            Console.Write("Do you want to continue [y/n]: "); 
        }

        public void DefaultReport()
        {
            Console.WriteLine("Sorry,You entered invalid input, try again");
        }
    }
}