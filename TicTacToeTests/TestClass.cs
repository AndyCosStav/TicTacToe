using System;
using TicTacToe;
using Xunit;

namespace TicTacToeTests
{
    public class TestClass
    {
        [Fact]
        public void TestHorizontalWin()
        {
            char[] FirstRow = { 'X', 'X', 'X', 'O', 'O', '-', '-', '-', '-', '-' };

            var result = WinningLogic.CheckForAWin(FirstRow);


            Assert.Equal(1, result);
        }

        [Fact]
        public void TestVerticalWin()
        {
            char[] FirstColumn = { 'X', 'O', 'O', 'X', '-', '-', 'X', '-', '-' };

            var result = WinningLogic.CheckForAWin(FirstColumn);


            Assert.Equal(1, result);
        }


        [Fact]
        public void TestDiagonalWin()
        {
            char[] Diagonal = { 'X', 'O', 'O', '-', 'X', '-', '-', '-', 'X'};

            var result = WinningLogic.CheckForAWin(Diagonal);


            Assert.Equal(1, result);
        }


        [Fact]
        public void TestGameDraw()
        {
            char[] Draw = { 'O', 'X', 'O', 'O', 'O', 'X', 'X', 'O', 'X' };

            var result = WinningLogic.CheckForAWin(Draw);


            Assert.Equal(-1, result);
        }



    }
}
