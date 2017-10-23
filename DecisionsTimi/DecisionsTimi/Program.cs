// Decisions
// Name: Timi Owoturo
// Teachers Name: Miss Lischynski
// Date: 17/02/2016
// Description: Prints out what the user selects from the game and awards him something
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecisionsTimi
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("I wrote something :)");
            //string userValue;
            //userValue = Console.ReadLine();
            //Console.WriteLine("You typed:" + userValue);
            //Console.ReadLine();

            Console.WriteLine("Would you prefer what is behind door number 1, 2 or 3?");
            string userValue = Console.ReadLine();
            /*
            string message = "";
            
            if (userValue == "1")
         
                message = "You won a new car!";
          
            else if (userValue == "2")
            
                message = "You won a new boat!";
             
            else if (userValue == "3")
            
                message = "You won a new cat";

            else
 
                message = "Sorry, we didn't understand. You lose!";
           */

            //conditions
            string message = (userValue == "1") ? "boat" : "strand of lint";
            //Prints out what the user selects
            Console.WriteLine("You won a {0}! And you typed {1}", message, userValue);
            //Console.WriteLine(message);
            Console.ReadLine();

        }
    }
}
