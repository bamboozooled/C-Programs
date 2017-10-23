// AreaAndPerimeterTimiOwoturo
// Name: Timi Owoturo
// Teachers Name: Miss Lischynski
// Date: 24/05/2016
// Description: Using methods to calculate area and perimeter for a rectangle.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AreaAndPerimeterTimiOwoturo
{
    class Program
    {
        //creating variables
        static string area;
        static string perimeter;
        static string height;
        static string width;
        static void Main(string[] args)
        {
            //Parameters
            area = CalculatingArea("Please enter your height and width for the area");
            perimeter = CalculatingPerimeter("Please enter your height and width for the perimeter");

            //converting area and perimeter to decimal
            decimal area2 = decimal.Parse(area);

            decimal perimeter2 = decimal.Parse(perimeter);
            
            //outputting the area and perimeter to 1dp
            //output(area, perimeter);
            Console.WriteLine("The area is:      {0:N1}", area2);
            Console.WriteLine("The perimeter is: {0:N1}", perimeter2);
            Console.ReadLine();

        }
        //creating Area method
        private static string CalculatingArea(string height2)
        {
            
            Console.WriteLine(height2);
            //asking for input
            height = Console.ReadLine();
            width = Console.ReadLine();
            // calculating the area
            decimal CalcArea;

            CalcArea = decimal.Parse(height) * decimal.Parse(width);
             

            return CalcArea.ToString();
        }
        //Perimeter method
        private static string CalculatingPerimeter(string height3)
        {
            
            height = height;
            width = width;
            decimal CalcPerim;

            //calculating the perimeter
            CalcPerim = (decimal.Parse(height) * 2) + (decimal.Parse(width) * 2);

            

            return CalcPerim.ToString();
        }
        //not necessary
        /*static void output(string area, string perimeter)
        {
            Console.WriteLine("Your area is {0} and your perimeter is {1}", area, perimeter);
        } */
    }

}
