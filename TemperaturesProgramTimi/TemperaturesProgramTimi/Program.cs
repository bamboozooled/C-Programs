//************************************************************************************************************************
// TemperaturesProgram
// Name: Timi Owoturo
// Teachers Name: Miss Lischynski 
// Date: 19/02/2016
// Description: A console window that prompts the user to enter the temperature and prints out a message if the condition
// is true.
//*********************************************************************************
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemperaturesProgramTimi
{
    class Program
    {
        static void Main(string[] args)
        {
            // creating variables
            Console.WriteLine("Please enter the temperature in celsius so we can tell you what activity you can do for the day");
            string userInput = Console.ReadLine();
            string message = "";
            // conditions for temperature/activity
            if (int.Parse(userInput) > 30)
                // message that gets printed if condition is true
                message = "We recommend swimming. Take your swimming trunks and swim! :)";
            else if (int.Parse(userInput) > 20 && int.Parse(userInput) <= 30)

                message = "Take your rackets out and go play some tennis :D";
            else if (int.Parse(userInput) > 0 && int.Parse(userInput) <= 20)
                message = "Lets go and play some Golf!";
            else if (int.Parse(userInput) > -15 && int.Parse(userInput) <= 0)
                message = "Take your ski boots, skis and poles and lets go skiing! :D";
            else if (int.Parse(userInput) <= -15)
                message = "Lets Dance!!!!! :D";
            else
                message = "I have no idea what youre doing.";
            // outputs to the console window
            Console.WriteLine("{0} And you typed {1}", message, userInput);
            Console.ReadLine();
        }
    }
}
