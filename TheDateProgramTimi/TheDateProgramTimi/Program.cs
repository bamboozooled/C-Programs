//************************************************************************************************************************
// TheDateProgram
// Name: Timi Owoturo
// Teachers Name: Miss Lischynski 
// Date: 12/02/2016
// Description: A console window that prompts the user to enter the numerical value
// of the month,day and year and prints it out in the format MM/DD/YY
//*********************************************************************************
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheDateProgramTimi
{
    class Program
    {
        public static object Application { get; private set; }

        static void Main(string[] args)
        {
            
            // outputs the command on the console window
            Console.WriteLine("Enter the  numerical value of the month, day, and year:");
            // Allows user enter a value
            string month = Console.ReadLine();
            // An if statement to make sure the user does not enter the wrong value for the month
            if (int.Parse(month) > 12)
            {
                Console.WriteLine("Come on!!,There are only 12 months in a year");
                Console.WriteLine("Now restart application and Enter the correct value for the month if not, the date will be wrong");
            }
            string day = Console.ReadLine();
            if (int.Parse(day) > 31)
            {
                Console.WriteLine("There are only 30-31 days in a month!");
                Console.WriteLine("Now restart application Enter the correct value for the day");
            }
            string year = Console.ReadLine();
            if (int.Parse(year) < 2016)
            {
                Console.WriteLine("We are in the present not the past. Put in a value e.g 2016");
                Console.WriteLine("Now restart application and enter the correct value");
            }
            string seperator = "/";
            Console.WriteLine(" ");
            Console.WriteLine("Today's date is:" + month + seperator + day + seperator + year); 





            Console.ReadLine();
        }
    }
}
