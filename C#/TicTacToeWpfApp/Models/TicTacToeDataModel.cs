using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TicTacToeWpfApp.Objects;

namespace TicTacToeWpfApp.Models
{
    class TicTacToeDataModel
    {
        public Position gameBoardSize;
        public int gameNumberOfPisibleMoves;
        public bool bGameRun;

        public string currentPlayer;
        public string colQuantity;
        public string rowQuantity;

        //public ObservableCollection<BoardCell> boardCellCollection;
        public ObservableCollection<BoardCell> boardCells;
        
        public List<string> playerList;
        //public ObservableCollection<BoardCell> boardCells;
        //public string[,] board;
        //public Dictionary<string, string> boardDict;
        //public Dictionary<Tuple<int,int>,string> boardCellsDict;
        public TicTacToeDataModel()
        {
            currentPlayer = "X";
            gameNumberOfPisibleMoves = 9;
            bGameRun = true;
            gameBoardSize = new();

            playerList = new List<string>() { "X", "O" };

            //boardCells = new();

            boardCells = new()
            {
                new() { Position = new Position() { X = 0, Y = 2 }, SettedPlayer = string.Empty },
                new() { Position = new Position() { X = 0, Y = 1 }, SettedPlayer = string.Empty },
                new() { Position = new Position() { X = 0, Y = 0 }, SettedPlayer = string.Empty },
                new() { Position = new Position() { X = 1, Y = 2 }, SettedPlayer = string.Empty },
                new() { Position = new Position() { X = 1, Y = 1 }, SettedPlayer = string.Empty },
                new() { Position = new Position() { X = 1, Y = 0 }, SettedPlayer = string.Empty },
                new() { Position = new Position() { X = 2, Y = 2 }, SettedPlayer = string.Empty },
                new() { Position = new Position() { X = 2, Y = 1 }, SettedPlayer = string.Empty },
                new() { Position = new Position() { X = 2, Y = 0 }, SettedPlayer = string.Empty }
            };

            //boardCells = new();
            //foreach (var cell in boardCellsDict)
            //{
            //    boardCells.Add(cell.Value);
            //}
            //boardDict = new();
            //foreach (var cell in boardCellsDict)
            //{
            //    boardDict.Add(cell.Key.Item1.ToString() + cell.Key.Item2.ToString(), cell.Value);
            //}
        }

    }
}
