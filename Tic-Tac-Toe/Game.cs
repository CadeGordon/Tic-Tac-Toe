using System;
using System.Collections.Generic;
using System.Text;

namespace Tic_Tac_Toe
{
    class Game
    {
        private static bool _gameOver = false;
        private Board _gameBoard;


        /// <summary>
        /// Function the start the main game loop
        /// </summary>
        public void Run()
        {
            Start();

            while (!_gameOver)
            {
                Draw();
                Update();
            }

            End();
        }

        /// <summary>
        /// Initialized the board on game start
        /// </summary>
        private void Start()
        {
            _gameBoard = new Board();
            _gameBoard.Start();
        }

        /// <summary>
        /// Updates the game board after each player turn
        /// </summary>
        private void Update()
        {
            _gameBoard.Update();
        }

        private void End()
        {
            _gameBoard.End();
        }

        /// <summary>
        /// updates
        /// </summary>
        private void Draw()
        {
            Console.Clear();
            _gameBoard.Draw();
            
        }

        public static int GetInput()
        {
            int choice = -1;
                if (!int.TryParse(Console.ReadLine(), out choice))
                choice = -1;

            return choice;
        }
    }
}
