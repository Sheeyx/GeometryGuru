using System;
using Microsoft.VisualBasic;
using Information = Microsoft.VisualBasic.Information;

namespace Geometry
{
    class Program
    {
        static void Main()
        {
            string yesOrno = ("");
            Shapes shape = new Shapes();
            Option option = new Option();
            do
            {
                option.ShowMenu();
                int choosedNumber = int.Parse(Console.ReadLine()!);
                switch (choosedNumber)
                {
                    case 1:
                        shape.TriangleCalcule();
                        break;

                    case 2:
                        shape.RectangleCalculate();
                        break;

                    case 3:
                        shape.CircleCalculate();
                        break;

                    default:
                        option.DefaultReport();
                        break;
                } 
                option.Report();
                yesOrno = Console.ReadLine()!;
            } while (yesOrno == "y");
        }
    }
}