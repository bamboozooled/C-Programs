// IntegerTextFile
// Name: Timi Owoturo
// Teachers Name: Miss Lischynski
// Date: 14/04/2016
// Description: Using a bunch of values in a textfile to calculate the average of the values, max, min, length.
using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Text;
using System.Threading.Tasks;

namespace IntegerTextFile
{
    class Program
    {
        static void Main(string[] args)
        {

            StreamReader myReader = new StreamReader("TextFileTimi.txt");
            string line = "";

            //Reading/cycling through the text file and assigning its value to an Array
            string[] allLines = File.ReadAllLines("TextFileTimi.txt");

            //Declaring the variables
            decimal average;
            string decto2;

            // Calculating the Average by adding every value in the array/parsing it to decimal and dividing by 10(The number of values in the array
            average = (decimal.Parse(allLines[0]) + decimal.Parse(allLines[1]) + decimal.Parse(allLines[2]) + decimal.Parse(allLines[3]) + decimal.Parse(allLines[4]) + decimal.Parse(allLines[5]) + decimal.Parse(allLines[6]) + decimal.Parse(allLines[7]) + decimal.Parse(allLines[8]) + decimal.Parse(allLines[9])) / 10;
            // Using string.Format to format the result of the array to 2dp
            decto2 = string.Format("Average: {0:N}", average);
            Console.WriteLine(decto2);
            // Calculating the length of the array and setting it to a variable
            int arrayLength = allLines.Length;
            // Outputting the array length 
            Console.WriteLine("The number of values you have in your text file is {0}:", arrayLength);
            
            // Declaring max/min variables
            decimal max = 0;
            decimal min = decimal.Parse(allLines[0]);
            for (int i = 0; i < 10; i++)
            {
                // Calculating max and min of the Array/TextFile
                max = Math.Max(max, decimal.Parse(allLines[i]));
                min = Math.Min(min, decimal.Parse(allLines[i]));
            }
            
            // Outputting the Max and Min
            Console.WriteLine("Your maximum value is: {0}", max);
            Console.WriteLine("Your minimum value is: {0}", min);

            
            while (line != null)
            {
                line = myReader.ReadLine();
                if (line != null)
                    Console.WriteLine(line);
            }
            

            myReader.Close();
            Console.ReadLine();
        }
    }
}
