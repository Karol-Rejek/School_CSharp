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
        public int gameNumberOfPisibleMoves;

        public string currentPlayer;

        //public ObservableCollection<BoardCell> boardCellCollection;
        public ObservableCollection<string> boardCells;
        
        public List<string> playerList;
        //public ObservableCollection<string> boardCells;
        //public string[,] board;
        //public Dictionary<string, string> boardDict;
        public Dictionary<Tuple<int,int>,string> boardCellsDict;
        public TicTacToeDataModel()
        {
            currentPlayer = "X";
            gameNumberOfPisibleMoves = 9;

            playerList = new List<string>() { "X", "O" };
            //board = new string[3, 3];
            
            //boardCells = new();

            //boardCellCollection = new ObservableCollection<BoardCell>();
            boardCellsDict = new()
            {
                { new Tuple<int, int>(0, 0), string.Empty },
                { new Tuple<int, int>(0, 1), string.Empty },
                { new Tuple<int, int>(0, 2), string.Empty },
                { new Tuple<int, int>(1, 0), string.Empty },
                { new Tuple<int, int>(1, 1), string.Empty },
                { new Tuple<int, int>(1, 2), string.Empty },
                { new Tuple<int, int>(2, 0), string.Empty },
                { new Tuple<int, int>(2, 1), string.Empty },
                { new Tuple<int, int>(2, 2), string.Empty }
            };

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

            boardCells = new();
            foreach (var cell in boardCellsDict)
            {
                boardCells.Add(cell.Value);
            }
            //boardDict = new();
            //foreach (var cell in boardCellsDict)
            //{
            //    boardDict.Add(cell.Key.Item1.ToString() + cell.Key.Item2.ToString(), cell.Value);
            //}
        }

    }
}
