using System;
using System.Collections.Generic;
using System.Text;

namespace TicTacToe
{
    public static class WinningLogic
    {
        public static int CheckForAWin(char[] arr)
        {
            //horizontal winning conditions
            if (arr[0] != '-' && arr[0] == arr[1] && arr[1] == arr[2])
            {
                return 1;
            }

            else if (arr[3] != '-' && arr[3] == arr[4] && arr[4] == arr[5])
            {
                return 1;
            }

            else if (arr[6] != '-' && arr[6] == arr[7] && arr[7] == arr[8])
            {
                return 1;
            }


            //vertical winning conditions
            else if (arr[0] != '-' && arr[0] == arr[3] && arr[3] == arr[6])
            {
                return 1;
            }

            else if (arr[1] != '-' && arr[1] == arr[4] && arr[4] == arr[7])

            {

                return 1;

            }

            else if (arr[2] != '-' && arr[2] == arr[5] && arr[5] == arr[8])

            {

                return 1;

            }

            //diagonal winning conditions

            else if (arr[0] != '-' && arr[0] == arr[4] && arr[4] == arr[8])

            {

                return 1;

            }

            else if (arr[2] != '-' && arr[2] == arr[4] && arr[4] == arr[6])

            {

                return 1;

            }


              else if (arr[0] != '-' && arr[1] != '-' && arr[2] != '-' && arr[3] != '-' && arr[4] != '-' && arr[5] != '-' && arr[6] != '-' && arr[7] != '-' && arr[8] != '-')

            {

                return -1;

            }




            else
            {
                return 0;
            }


        }
    }
}
