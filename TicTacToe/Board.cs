using System;
using System.Collections.Generic;
using System.Text;

namespace TicTacToe
{
    public static class Board
    {

        public static void GameIntro()
        {
            Console.WriteLine("Welcome to TicTacToe");
            Console.WriteLine("");
            Console.WriteLine("Player 1 = X | | Player 2 = O");
            Console.WriteLine("");
            Console.WriteLine("Player 1 to start!");
            Console.WriteLine("");
        }


        public static void BuildGameBoard(char[] arr)
        {

            Console.Write(" " + arr[0] + " ");
            Console.Write(" " + arr[1] + " ");
            Console.Write(" " + arr[2] + " ");

            Console.WriteLine(" ");

            Console.Write(" " + arr[3] + " ");
            Console.Write(" " + arr[4] + " ");
            Console.Write(" " + arr[5] + " ");

            Console.WriteLine(" ");

            Console.Write(" " + arr[6] + " ");
            Console.Write(" " + arr[7] + " ");
            Console.Write(" " + arr[8] + " ");

            Console.WriteLine(" ");
        }
    }
}
