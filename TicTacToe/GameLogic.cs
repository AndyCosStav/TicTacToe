using System;
using System.Collections.Generic;
using System.Text;

namespace TicTacToe
{
    public static class GameLogic
    {
        public static void Logic()
        {
            Board.GameIntro();

            int player = 0;

            int win = 0;

            char[] arr = { '-', '-', '-', '-', '-', '-', '-', '-', '-', '-' };

            do
            {
                Console.WriteLine("");

                Board.BuildGameBoard(arr);

                Console.WriteLine("");

                Console.WriteLine("Where do you want to move? Enter 1-9");

                Console.WriteLine("");

                var choice = Convert.ToInt32(Console.ReadLine());

                if (arr[choice - 1] != 'X' && arr[choice - 1] != 'O')
                {

                    if (player == 0)
                    {
                        arr[choice - 1] = 'X';
                        player++;
                    }

                    else
                    {
                        arr[choice - 1] = 'O';
                        player--;
                    }
                }
                else
                {
                    Console.WriteLine("That spot is taken, try another spot!");
                }

                win = WinningLogic.CheckForAWin(arr);

            } while (win == 0);

            if (win == 1)
            {
                if (player == 1)
                {
                    Board.BuildGameBoard(arr);
                    Console.WriteLine("player 1 has won the match!");
                }

                else
                {
                    Board.BuildGameBoard(arr);
                    Console.WriteLine("player 2 has won the match!");
                }
            }

            if (win == -1)
            {
                Board.BuildGameBoard(arr);
                Console.WriteLine("It's a draw!");
            }

        }
    }
}
