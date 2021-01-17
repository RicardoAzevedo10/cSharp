using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleShip
{
    class BattleshipBoard //This script is for the battleship board game
    {
        public void DisplayBoard(char[,] Board)
        {
            //Divided by rows and columns
            int Row;
            int Column;
            
            //Design for every column a row 
            Console.WriteLine("  ¦ 0 1 2 3 4 5 6 7 8 9");
            Console.WriteLine("--+--------------------");
            for (Row = 0; Row <= 9; Row++)
            {
                Console.Write((Row).ToString() + " ¦ ");
                for (Column = 0; Column <= 9; Column++)
                {
                    Console.Write(Board[Column, Row] + " ");
                }
                Console.WriteLine();
            }

            Console.WriteLine("\n");
        }
    }
}
