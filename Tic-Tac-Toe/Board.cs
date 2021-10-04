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

        public void Start()
        {
            _player1Token = 'x';
            _player2Token = 'o';
            _currentToken = _player1Token;
            _board = new char[3, 3];
        }

        public void Update()
        {

        }

        public void End()
        {

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

        private bool CheckWinner(char token)
        {

        }

    }
    
    
}
