//*********************************************************************************
// Variables
// Name: Timi Owoturo
// Teachers Name: Miss Lischynski
// Date: 08/02/2016
// Description: Shows us how to use variables using "String", "Int" and "Var" and how to convert "int" to
// a string using .ToString() and how to convert "String" to an integer using int.Parse() the program
// prints 75
//        10
// on the console window
//*********************************************************************************
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VariablesTimi
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            int x;
            int y;

            x = 7;
            y = x + 3;
            Console.WriteLine(y);
            */

            //string myFirstName;
            //myFirstName = "Bob";

            //string myFirstName = "Bob";

            //var myFirstName = "Bob";

            //Console.WriteLine(myFirstName);

            int x = 7;
            string y = "5";
            string myFirstTry = x.ToString() + y;
            int mySecondTry = x + int.Parse(y);
            Console.WriteLine(myFirstTry);
            Console.WriteLine(mySecondTry);


            Console.ReadLine();
        }
    }
}
