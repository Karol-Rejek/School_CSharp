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

        public ObservableCollection<string> BoardCells
        {
            get { return dataModel.boardCells; }
            set
            {
                dataModel.boardCells = value;
                OnPropertyChanged(nameof(BoardCells));
            }
        }

        //public Dictionary<string, string> BoardCells
        //{
        //    get { return dataModel.boardDict; }
        //    set
        //    {
        //        dataModel.boardDict = value;
        //        OnPropertyChanged(nameof(BoardCells));
        //    }
        //}

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
        private ICommand setPleyerCommand;
        public ICommand SetPleyerCommand
        {
            get
            {
                setPleyerCommand ??= new RelayCommand<object>(
                        o =>
                        {
                            int row = Grid.GetRow((FrameworkElement)o);
                            int col = Grid.GetColumn((FrameworkElement)o);
                            Tuple<int, int> position = new(col,row);
                            
                            //dataModel.boardCellsDict[position] = dataModel.currentPlayer;

                            // check move is corect
                            if (CanExecuteMove(position))
                            {
                                dataModel.boardCellsDict[position] = dataModel.currentPlayer;
                                if (convertToIndex(position) != -1)
                                    BoardCells[convertToIndex(position)] = dataModel.boardCellsDict[position];
                                dataModel.gameNumberOfPisibleMoves--;

                                string message = string.Empty;
                                if (CheckForWin(out message) || CheckForDraw(out message))
                                {
                                    MessageBox.Show("Wynik gry: " + message);
                                    GameEnd();
                                }
                                else
                                {
                                    dataModel.currentPlayer = (dataModel.currentPlayer == "X") ? "O" : "X";
                                }

                                
                            }
                            
                        }
                        );
                return setPleyerCommand;
            }
        }

        // checking if player can make move
        private bool CanExecuteMove(Tuple<int, int> position)
        {
            // check cell is empty
            if (dataModel.boardCellsDict[position] == "")
            {
                return true;
            }

            return false;
        }

        // ending game and start new
        void GameEnd()
        {
            foreach (var item in dataModel.boardCellsDict)
            {
                dataModel.boardCellsDict[item.Key] = string.Empty;
                if (convertToIndex(item.Key) != -1)
                    BoardCells[convertToIndex(item.Key)] = dataModel.boardCellsDict[item.Key];
            }
        }

        private short convertToIndex(Tuple<int, int> position) // test function to rebuild
        {
            if (position.Item1 == 0)
            {
                if (position.Item2 == 0)
                    return 0;
                if (position.Item2 == 1)
                    return 1;
                if (position.Item2 == 2)
                    return 2;
            }
            if (position.Item1 == 1)
            {
                if (position.Item2 == 0) 
                    return 3;
                if (position.Item2 == 1)
                    return 4;
                if (position.Item2 == 2)
                    return 5;
            }
            if (position.Item1 == 2)
            {
                if (position.Item2 == 0)
                    return 6;
                if (position.Item2 == 1)
                    return 7;
                if (position.Item2 == 2)
                    return 8;
            }
            return -1;
        }

        #region Checking game status functions
        // check if win
        private bool CheckForWin(out string message)
        {
            for(int col = 0; col < 3; col++)
            {
                if (dataModel.boardCellsDict[new(col,0)] == CurrentPlayer &&
                    dataModel.boardCellsDict[new(col,1)] == CurrentPlayer &&
                    dataModel.boardCellsDict[new(col,2)] == CurrentPlayer)
                {
                    message = "Wygrał: " + CurrentPlayer;
                    return true;
                }
            }

            for (int row = 0; row < 3; row++)
            {
                if (dataModel.boardCellsDict[new(0, row)] == CurrentPlayer &&
                    dataModel.boardCellsDict[new(1, row)] == CurrentPlayer &&
                    dataModel.boardCellsDict[new(2, row)] == CurrentPlayer)
                {
                    message = "Wygrał: " + CurrentPlayer;
                    return true;
                }
            }

            if (dataModel.boardCellsDict[new(0, 0)] == CurrentPlayer &&
                    dataModel.boardCellsDict[new(1, 1)] == CurrentPlayer &&
                    dataModel.boardCellsDict[new(2, 2)] == CurrentPlayer)
            {
                message = "Wygrał: " + CurrentPlayer;
                return true;
            }

            if (dataModel.boardCellsDict[new(2, 0)] == CurrentPlayer &&
                    dataModel.boardCellsDict[new(1, 1)] == CurrentPlayer &&
                    dataModel.boardCellsDict[new(0, 2)] == CurrentPlayer)
            {
                message = "Wygrał: " + CurrentPlayer;
                return true;
            }

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
                    if (dataModel.boardCellsDict[new(col, row)] == "" )
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
