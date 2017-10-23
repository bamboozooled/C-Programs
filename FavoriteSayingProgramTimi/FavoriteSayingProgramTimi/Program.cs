// FavoriteSayingProgramTimi
// Name: Timi Owoturo
// Teachers Name: Miss Lischynski
// Date: 29/03/2016
// Description: Using methods to output a users name and favorite saying
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FavoriteSayingProgramTimi
{
    class Program
    {
        static string name;
        static string favoritesaying;
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter your name and favorite saying");
            // creating variables and using parameters
            name = input("What is your name");
            favoritesaying = input("What is your favorite saying");
            Console.Clear();
            output(name, favoritesaying);
            Console.ReadLine();
        }
        // creating the method and returning user input
        static string input(string input2)
        {
            string value;
            Console.WriteLine(input2);
            value = Console.ReadLine();
            return value;
        }
        // creating the method to output user input. 
        static void output(string name, string favouritesaying)
        {
            Console.WriteLine("<><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><>");
            Console.WriteLine("Your name is {0}, Your favorite saying is {1}", name, favoritesaying);
            Console.WriteLine("<><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><>");
        }
    }
}
