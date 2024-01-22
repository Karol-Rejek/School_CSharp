using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TicTacToeWpfApp.Objects;

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

        public string currentPlayer;

        //public ObservableCollection<BoardCell> boardCellCollection;
        //public ObservableCollection<string> boardCells;

        public List<string> playerList;

        public string[][] board = { new string[3], new string[3] };

        public TicTacToeDataModel()
        {
            currentPlayer = "X";
            gameBoardLenght = 9;

            playerList = new List<string>() { "X", "O" };

            //boardCellCollection = new ObservableCollection<BoardCell>();

            //boardCellCollection = new()
            //{
            //    new() { position = new Position() { x = 0, y = 2 }, settedPlayer = string.Empty },
            //    new() { position = new Position() { x = 0, y = 1 }, settedPlayer = string.Empty },
            //    new() { position = new Position() { x = 0, y = 0 }, settedPlayer = string.Empty },
            //    new() { position = new Position() { x = 1, y = 2 }, settedPlayer = string.Empty },
            //    new() { position = new Position() { x = 1, y = 1 }, settedPlayer = string.Empty },
            //    new() { position = new Position() { x = 1, y = 0 }, settedPlayer = string.Empty },
            //    new() { position = new Position() { x = 2, y = 2 }, settedPlayer = string.Empty },
            //    new() { position = new Position() { x = 2, y = 1 }, settedPlayer = string.Empty },
            //    new() { position = new Position() { x = 2, y = 0 }, settedPlayer = string.Empty }
            //};

            //boardCells = new();
            //foreach (var cell in boardCellCollection)
            //{
            //    boardCells.Add(cell.settedPlayer);
            //}


        }

    }
}
