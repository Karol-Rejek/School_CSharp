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

        private ICommand setPleyerCommand;
        public ICommand SetPleyerCommand
        {
            get
            {
                if (setPleyerCommand == null)
                    setPleyerCommand = new RelayCommand<object>(
                        o =>
                        {
                            int row = Grid.GetRow((FrameworkElement)o);
                            int col = Grid.GetColumn((FrameworkElement)o);
                            //int row = 0;
                            //int col = 0;
                            Tuple<int, int> position = new(row,col);
                            
                            dataModel.boardCellsDict[position] = dataModel.currentPlayer;
                            //check move is corect
                            //if (CanExecuteMove(position))
                            //{
                            //    dataModel.boardCellsDict[position] = dataModel.currentPlayer;

                            //    if (CheckForWinner() || CheckForDraw())
                            //    {

                            //    }
                            //    else
                            //    {
                            //        // change player
                            //        BoardCells[position.Item1] = dataModel.boardCellsDict[position];
                            //        dataModel.currentPlayer = (dataModel.currentPlayer == "X") ? "O" : "X";
                            //    }
                            //}

                            BoardCells[convertToIndex(position)] = dataModel.boardCellsDict[position];
                        }
                        );
                return setPleyerCommand;
            }
        }

        //private bool CanExecuteMove(Tuple<int, int> position)
        //{
        //    check cell is empty
        //    if (dataModel.boardCellsDict[position] == "\0")
        //    {
        //        return true;
        //    }

        //    return false;
        //}

        private short convertToIndex(Tuple<int, int> position) // test function
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
            if (position.Item1 == 1)
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

        private bool CheckForWinner()
        {
            // check if win
            return false;
        }

        private bool CheckForDraw()
        {
            // check if draw
            return false;
        }
    }
}
