//************************************************************************************************************************
// AverageTemperaturesProgram
// Name: Timi Owoturo
// Teachers Name: Miss Lischynski 
// Date: 25/02/2016
// Description: A console window that prompts the user to enter a series of 12 temperature values and prints out the difference
// between them. At the end, it calculates the average of those 12 temperature values and prints it out on the console window.
//*********************************************************************************
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AverageTemperatureTimi
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please Input a series of 12 temperatures in degrees celsius");
            string startingtemp = Console.ReadLine();   
            string secondtemp = Console.ReadLine();
            Console.WriteLine("You typed {0} and the difference is {1}", secondtemp, decimal.Parse(secondtemp) - decimal.Parse(startingtemp));
            string thirdtemp = Console.ReadLine();
            Console.WriteLine("You typed {0} and the difference is {1}", thirdtemp, decimal.Parse(thirdtemp) - decimal.Parse(secondtemp));
            string fourthtemp = Console.ReadLine();
            Console.WriteLine("You typed {0} and the difference is {1}", fourthtemp, decimal.Parse(fourthtemp) - decimal.Parse(thirdtemp));
            string fifthtemp = Console.ReadLine();
            Console.WriteLine("You typed {0} and the difference is {1}", fifthtemp, decimal.Parse(fifthtemp) - decimal.Parse(fourthtemp));
            string sixthtemp = Console.ReadLine();
            Console.WriteLine("You typed {0} and the difference is {1}", sixthtemp, decimal.Parse(sixthtemp) - decimal.Parse(fifthtemp));
            string seventhtemp = Console.ReadLine();
            Console.WriteLine("You typed {0} and the difference is {1}", seventhtemp, decimal.Parse(seventhtemp) - decimal.Parse(sixthtemp));
            string eighttemp = Console.ReadLine();
            Console.WriteLine("You typed {0} and the difference is {1}", eighttemp, decimal.Parse(eighttemp) - decimal.Parse(seventhtemp));
            string ninghttemp = Console.ReadLine();
            Console.WriteLine("You typed {0} and the difference is {1}", ninghttemp, decimal.Parse(ninghttemp) - decimal.Parse(eighttemp));
            string tenghttemp = Console.ReadLine();
            Console.WriteLine("You typed {0} and the difference is {1}", tenghttemp, decimal.Parse(tenghttemp) - decimal.Parse(ninghttemp));
            string eleventhtemp = Console.ReadLine();
            Console.WriteLine("You typed {0} and the difference is {1}", eleventhtemp, decimal.Parse(eleventhtemp) - decimal.Parse(tenghttemp));
            string twelvetemp = Console.ReadLine();
            Console.WriteLine("You typed {0} and the difference is {1}", twelvetemp, decimal.Parse(twelvetemp) - decimal.Parse(eleventhtemp));


            
            var avg = (decimal.Parse(startingtemp) + decimal.Parse(secondtemp) + decimal.Parse(thirdtemp) + decimal.Parse(fourthtemp) + decimal.Parse(fifthtemp) + decimal.Parse(sixthtemp) + decimal.Parse(seventhtemp) + decimal.Parse(eighttemp) + decimal.Parse(ninghttemp) + decimal.Parse(tenghttemp) + decimal.Parse(eleventhtemp) + decimal.Parse(twelvetemp));
            var avgfinal = ((avg) / 12);

            Console.WriteLine("The average of this temperatures are {0}", avgfinal);
            Console.ReadLine();
                 
        }
    }
}
