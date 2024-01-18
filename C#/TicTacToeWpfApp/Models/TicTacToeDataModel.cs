using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToeWpfApp.Models
{
    enum GameStatus
    {
        Win,
        Draw,
        Game
    }

    class TicTacToeDataModel
    {
        int gameBoardLenght;

        public string selectedPlayer;

        public List<string> boardText;

        public List<string> playerList;

        public Dictionary<int,string> GameBoard;

        public TicTacToeDataModel()
        {
            selectedPlayer = string.Empty;
            gameBoardLenght = 9;

            playerList = new List<string>() { "X", "O" };

            boardText = new List<string>();

            GameBoard = new Dictionary<int, string>();
            for (int i = 1; i < gameBoardLenght; i++)
            {
                GameBoard.Add(i, string.Empty);
            }

        }

    }
}
