# TicTacToe

Hi all, 

This is just a really straight forward attempt at coding a Tic Tac Toe game. 

The approach I have taken essentially involves delcaring a starting char array and the users taking turns to change the values within that array. 
I decided to capture the values in a single dimensional char array, as it seemed the simplest and most straight forward optioned. Initially I  considered using 
something along the lines or a jagged array but I did not want to over engineer a solution for this level of problem. 

As the game progresses a program written to handle the 'win' logic scans though the array and returns a value based on the placements of the 'X' and 'O' values in the array. 

I have also included some Unit tests as a simple example of things that I would typically look to test for, in this case it is the core functionality of the game. such as the win 
and lose and draw elements of the game. 

I have chosen XUnit as the testing framework as this is a .net core application so its easy to set up and flexible for any future additions to the game. 

Thanks for reading! 
