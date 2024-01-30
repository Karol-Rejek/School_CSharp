using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Automation.Provider;
using System.Windows.Controls;
using System.Windows.Input;
using TicTacToeWpfApp.Models;
using TicTacToeWpfApp.Objects;
using UtilsWpf;

namespace TicTacToeWpfApp.VievModels
{
    class MainVievModel : ObserverVM
    {
        TicTacToeDataModel dataModel = new();

        //-------------------------
        // Properties
        public string CurrentPlayer
        {
            get { return dataModel.currentPlayer; }
            set
            {
                dataModel.currentPlayer = value;
                OnPropertyChanged(nameof(CurrentPlayer));
            }
        }

        public ObservableCollection<BoardCell> BoardCells
        {
            get { return dataModel.boardCells; }
            set
            {
                dataModel.boardCells = value;
                OnPropertyChanged(nameof(BoardCells));
            }
        }

        public string ColQuantity
        {
            get { return dataModel.colQuantity; }
            set
            {
                dataModel.colQuantity = value;
                OnPropertyChanged(nameof(ColQuantity));
            }
        }

        public string RowQuantity
        {
            get { return dataModel.rowQuantity; }
            set
            {
                dataModel.rowQuantity = value;
                OnPropertyChanged(nameof(RowQuantity));
            }
        }

        public List<string> PlayerList
        {
            get { return dataModel.playerList; }
            set
            {
                dataModel.playerList = value;
                OnPropertyChanged(nameof(PlayerList));
            }
        }

        //-------------------------
        // Functions

        private ICommand gameStart;
        public ICommand GameStart
        {
            get
            {
                if (gameStart == null)
                    gameStart = new RelayCommand<object>(
                        o =>
                        {
                            if (int.TryParse(ColQuantity, out var col) && int.TryParse(RowQuantity, out var row))
                            {
                                dataModel.gameBoardSize.X = col;
                                dataModel.gameBoardSize.Y = row;
                                dataModel.bGameRun = true;
                            }
                        }
                        );
                return gameStart;
            }
        }

        private ICommand setPleyerCommand;
        public ICommand SetPleyerCommand
        {
            get
            {
                setPleyerCommand ??= new RelayCommand<int>(
                        o =>
                        {
                            if (dataModel.bGameRun)
                            {
                                Position position = new() { X = o / dataModel.gameBoardSize.X, Y = o % dataModel.gameBoardSize.Y };

                                //dataModel.boardCellsDict[position] = dataModel.currentPlayer;

                                // check move is corect
                                if (CanExecuteMove(position))
                                {
                                    BoardCell boardCell = FindElementOfIndex(BoardCells, position);

                                    if (boardCell != null)
                                    {
                                        boardCell.SettedPlayer = CurrentPlayer;
                                        dataModel.gameNumberOfPisibleMoves--;
                                    }

                                    string message = string.Empty;
                                    if (CheckForWin(out message) || CheckForDraw(out message))
                                    {
                                        MessageBox.Show("Wynik gry: " + message);
                                        GameEnd();
                                    }
                                    else
                                    {
                                        CurrentPlayer = ChangePlayer(CurrentPlayer);
                                    }
                                }
                            }
                        }
                        );
                return setPleyerCommand;
            }
        }

        // checking if player can make move
        private bool CanExecuteMove(Position position)
        {
            // check cell is empty
            return (FindElementOfIndex(BoardCells, position).SettedPlayer == "") ? true : false;
        }

        BoardCell FindElementOfIndex(ObservableCollection<BoardCell> collection, Position index)
        {
            return collection.FirstOrDefault(bc => bc.Position.X == index.X && bc.Position.Y == index.Y);
        }

        string ChangePlayer(string player)
        {
            return (player == "X") ? "O" : "X";
        }

        // ending game and start new
        void GameEnd()
        {
            dataModel.bGameRun = false;

            foreach (var item in BoardCells)
            {
               item.SettedPlayer = string.Empty;
            }
        }

        #region Checking game status functions
        // check if win
        private bool CheckForWin(out string message)
        {
            int setPlayers = 0;
            for (int col = 0; col < dataModel.; col++)
            {
                for(int row = 0; row < 3; row++)
                {
                    if (FindElementOfIndex(BoardCells, new() { X = col, Y = row }).SettedPlayer == CurrentPlayer)
                    {
                        setPlayers++;
                        message = "Wygrał: " + CurrentPlayer;
                        return true;
                    }
                }
            }

            //for (int row = 0; row < 3; row++)
            //{
            //    if (dataModel.boardCellsDict[new(0, row)] == CurrentPlayer &&
            //        dataModel.boardCellsDict[new(1, row)] == CurrentPlayer &&
            //        dataModel.boardCellsDict[new(2, row)] == CurrentPlayer)
            //    {
            //        message = "Wygrał: " + CurrentPlayer;
            //        return true;
            //    }
            //}

            //if (dataModel.boardCellsDict[new(0, 0)] == CurrentPlayer &&
            //        dataModel.boardCellsDict[new(1, 1)] == CurrentPlayer &&
            //        dataModel.boardCellsDict[new(2, 2)] == CurrentPlayer)
            //{
            //    message = "Wygrał: " + CurrentPlayer;
            //    return true;
            //}

            //if (dataModel.boardCellsDict[new(2, 0)] == CurrentPlayer &&
            //        dataModel.boardCellsDict[new(1, 1)] == CurrentPlayer &&
            //        dataModel.boardCellsDict[new(0, 2)] == CurrentPlayer)
            //{
            //    message = "Wygrał: " + CurrentPlayer;
            //    return true;
            //}

            message = string.Empty;
            return false;
        }

        // check if draw
        private bool CheckForDraw(out string message)
        {
            bool isDraw = true;
            for (int col = 0; col < 3; col++)
            {
                for (int row = 0; col < 3; col++)
                {
                    if (FindElementOfIndex(BoardCells, new Position() { X = col, Y = row }).SettedPlayer == "" )
                    {
                        isDraw = false;
                    }
                }
            }

            if (isDraw && dataModel.gameNumberOfPisibleMoves == 0 || dataModel.gameNumberOfPisibleMoves == 0)
            {
                message = "Remis";
                return true;
            }
            message = string.Empty;
            return false;
        }
        #endregion
    }
}
