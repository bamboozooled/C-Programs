using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RainfallsArraysTimi
{
    class Program
    {
        static void Main(string[] args)
        {
            // Creating the arrays 
            decimal[] mean = new decimal [12]; 
            //Array for months - Not really needed
            string[] months = new string[12];
            months[0] = "January";
            months[1] = "February";
            months[2] = "March";
            months[3] = "April";
            months[4] = "May";
            months[5] = "June";
            months[6] = "July";
            months[7] = "August";
            months[8] = "September";
            months[9] = "October";
            months[10] = "November";
            months[11] = "December";

            // Array for rainfalls
            string[] rainfalls = new string[12];
            Console.WriteLine("Please for each month, enter the rainfall amounts for each month. How many times did it rain?");
            rainfalls[0] = Console.ReadLine();
            rainfalls[1] = Console.ReadLine();
            rainfalls[2] = Console.ReadLine();
            rainfalls[3] = Console.ReadLine();
            rainfalls[4] = Console.ReadLine();
            rainfalls[5] = Console.ReadLine();
            rainfalls[6] = Console.ReadLine();
            rainfalls[7] = Console.ReadLine();
            rainfalls[8] = Console.ReadLine();
            rainfalls[9] = Console.ReadLine();
            rainfalls[10] = Console.ReadLine();
            rainfalls[11] = Console.ReadLine();
            Console.Clear();
            
            // Variables for concactenation
            string add = ":";
            string concactenate = "Rainfalls:";
            //Array for months - Most Important
            string[] shortmonth = { "Jan", "Feb", "Mar", "Apr", "May", "June", "July", "Aug", "Sept", "Oct", "Nov", "Dec" };

            // Creating the for loop, for the rainfalls and months
            for (int i = 0; i < rainfalls.Length; i++)
            {
                Console.WriteLine(shortmonth[i] + add + concactenate + int.Parse(rainfalls[i]));
            }

            //Adding the elements in the array and converting it to decimal type
            decimal mean2 = decimal.Parse(rainfalls[0]) + decimal.Parse(rainfalls[1]) + decimal.Parse(rainfalls[2]) + decimal.Parse(rainfalls[3]) + decimal.Parse(rainfalls[4]) + decimal.Parse(rainfalls[5]) + decimal.Parse(rainfalls[6]) + decimal.Parse(rainfalls[7]) + decimal.Parse(rainfalls[8]) + decimal.Parse(rainfalls[9]) + decimal.Parse(rainfalls[10]) + decimal.Parse(rainfalls[11]);
            // dividing the variable mean2 by 12- Getting the average and putting it in a variable
            decimal mean2new = mean2 / 12;

          
            
            

            decimal Values0 = decimal.Parse(rainfalls[0]);
            decimal Values1 = decimal.Parse(rainfalls[1]);
            decimal Values2 = decimal.Parse(rainfalls[2]);
            decimal Values3 = decimal.Parse(rainfalls[3]);
            decimal Values4 = decimal.Parse(rainfalls[4]);
            decimal Values5 = decimal.Parse(rainfalls[5]);
            decimal Values6 = decimal.Parse(rainfalls[6]);
            decimal Values7 = decimal.Parse(rainfalls[7]);
            decimal Values8 = decimal.Parse(rainfalls[8]);
            decimal Values9 = decimal.Parse(rainfalls[9]);
            decimal Values10 = decimal.Parse(rainfalls[10]);
            decimal Values11 = decimal.Parse(rainfalls[11]);


            decimal variance = ((Values0 - mean2new) * (Values0 - mean2new) + ((Values1 - mean2new) * (Values1 - mean2new)) + ((Values2 - mean2new)* (Values2 - mean2new)) + ((Values3 - mean2new)* (Values3 - mean2new)) + ((Values4 - mean2new)*(Values4 - mean2new)) + ((Values5 - mean2new)*(Values5 - mean2new)) + ((Values6 - mean2new)*(Values6 - mean2new)) + ((Values7 - mean2new)*(Values7 - mean2new)) + ((Values8 - mean2new)*(Values8 - mean2new)) + ((Values9 - mean2new)*(Values9 - mean2new)) + ((Values10 - mean2new)*(Values10 - mean2new)) + ((Values11 - mean2new)*(Values11 - mean2new)));

            decimal variance2 = variance / 12;

            // Outputing the average
            Console.WriteLine("The average rainfall is:" + mean2new);
            // Outputing the variance
            Console.WriteLine("The Variance is:" + variance2);
            Console.ReadLine();
            
        }
    }
}
