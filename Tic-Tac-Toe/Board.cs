using System;
using System.Collections.Generic;
using System.Text;

namespace Tic_Tac_Toe
{
    class Board
    {
        private char _player1Token;
        private char _player2Token;
        private char _currentToken;
        private char[,] _board;

        /// <summary>
        /// intialized player token
        /// </summary>
        public void Start()
        {
            _player1Token = 'x';
            _player2Token = 'o';
            _currentToken = _player1Token;
            _board = new char[3, 3] { { '1', '2', '3' }, 
                                      { '4', '5', '6' }, 
                                      { '7', '8', '9' } };
        }

        /// <summary>
        /// Gets the input from the player.
        /// sets the player token at the desired spot in the 2d array 
        /// check if there is a winner.
        /// changes token in play
        /// </summary>
        public void Update()
        {
            int choice = Game.GetInput("Choose your space to fill", "1", "2", "3", "4", "5", "6", "7", "8", "9");
                
            if (choice == 0)
            {
                _board[0, 0] = _currentToken;
            }
            else if (choice == 1)
            {
                _board[0, 1] = _currentToken;
            }
            else if (choice == 2)
            {
                _board[0, 2] = _currentToken;
            }
            else if (choice == 3)
            {
                _board[1, 0] = _currentToken;
            }
            else if (choice == 4)
            {
                _board[1, 1] = _currentToken;
            }
            else if (choice == 5)
            {
                _board[1, 2] = _currentToken;
            }
            else if (choice == 6)
            {
                _board[2, 0] = _currentToken;
            }
            else if (choice == 7)
            {
                _board[2, 1] = _currentToken;
            }
            else if (choice == 8)
            {
                _board[2, 2] = _currentToken;
            }


            if (_currentToken == _player1Token)
                _currentToken = _player2Token;
            else
                _currentToken = _player1Token;

        }

        /// <summary>
        /// Draws the tic tac toe board and lets the player know whos turn it is
        /// </summary>
        public void Draw()
        {
            Console.WriteLine(_board[0, 0] + " | " + _board[0, 1] + " | " + _board[0, 2] + "\n" +
                                                  "_________ \n" +
                              _board[1, 0] + " | " + _board[1, 1] + " | " + _board[1, 2] + "\n" +
                                                  "_________ \n" +                   
                              _board[2, 0] + " | " + _board[2, 1] + " | " + _board[2, 2]) ;


        }

        public void End()
        {
            Console.WriteLine("Congrats you just played tic-tac-toe");
        }

        /// <summary>
        /// Assigns the spot at the given indices in the board array
        /// </summary>
        /// <param name="token">The token to set the array index to.</param>
        /// <param name="posX">The x position of the token.</param>
        /// <param name="posY">The y postion of the token.</param>
        /// <returns>Retunr false if the indices are out of range</returns>
        public bool SetToken(char token, int posX, int posY)
        {
            return false;
        }

        /// <summary>
        /// Checks to see if the token appears three times consecutivley vetically, horizontally, or diagonally.
        /// </summary>
        /// <param name="token"></param>
        /// <returns></returns>
        private bool CheckWinner(char token)
        {
            //check rows
            if (_board[0, 0] == token && _board[0, 1] == token && _board[0, 2] == token) { return true; }
            if (_board[1, 0] == token && _board[1, 1] == token && _board[1, 2] == token) { return true; }
            if (_board[2, 0] == token && _board[2, 1] == token && _board[2, 2] == token) { return true; }

            //check colums
            if (_board[0, 0] == token && _board[1, 0] == token && _board[2, 0] == token) { return true; }
            if (_board[0, 1] == token && _board[1, 1] == token && _board[2, 1] == token) { return true; }
            if (_board[0, 2] == token && _board[1, 2] == token && _board[2, 2] == token) { return true; }

            //check diagonal
            if (_board[0, 0] == token && _board[1, 1] == token && _board[2, 2] == token) { return true; }
            if (_board[0, 2] == token && _board[1, 1] == token && _board[2, 0] == token) { return true; }

            return false;
        }

        /// <summary>
        /// Resets the board to its default state
        /// </summary>
        public void ClearBoard()
        {

        }

    }
    
    
}
