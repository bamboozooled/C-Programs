// ChessBoard
// Name: Timi Owoturo
// Teachers Name: Miss Lischynski
// Date: 10/03/2016
// Description: Using asteriks and white spaces to create a chessboard and using loops to create an option
// of how many columns and rows the user wants. The user types it in the code window 
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessboardTimi
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the chessboard program");
            Console.WriteLine("How many chessboard columns do you want?");
            string columns = Console.ReadLine();
            Console.WriteLine("How long do you want the rows to be?");
            string rows = Console.ReadLine();
            Console.WriteLine("How long do you want the columns?");
            string length = Console.ReadLine();
            Console.Clear();

            //Declaring variables Black 
            string chessboardBlack = "";
            string chessboardBlackrow = "";
            //Declaring and assigning variables White
            string chessboardWhite = "";
            string chessboardWhiteRow = "";
            
           
            //Creating the Loops
            for (int i = 0; i < int.Parse(length); i++)
            {
                chessboardBlack = chessboardBlack + "*";
                chessboardWhite = chessboardWhite + " ";
            }
            
            
            for (int i = 0; i < int.Parse(columns); i++)
            
            {
                if (i % 2 == 0)
                {
                    chessboardBlackrow = chessboardBlackrow + chessboardBlack;
                    chessboardWhiteRow = chessboardWhiteRow + chessboardWhite;
                }

                else 
                {
                    
                    chessboardBlackrow = chessboardBlackrow + chessboardWhite;
                    chessboardWhiteRow = chessboardWhiteRow + chessboardBlack;
                }
            }
 
            for (int i = 0; i < int.Parse(rows); i++)
            {
                if (i % 2 == 0)
                {
                    for (int j = 0; j < 5; j++)
                    {
                        Console.WriteLine(chessboardBlackrow);
                    }
                 } 
                else
                {
                    for (int j = 0;  j < 5; j++)
                    {
                        Console.WriteLine(chessboardWhiteRow);
                    }
                }
            }
              
            
            Console.ReadLine();
        }
    }
}
