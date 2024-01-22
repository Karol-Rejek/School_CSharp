using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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

        public string[,] Board
        {
            get { return dataModel.board; }
            set
            {
                dataModel.board = value;
                OnPropertyChanged(nameof(Board));
            }
        }

        //public ObservableCollection<string> BoardCells
        //{
        //    get { return dataModel.boardCells; }
        //    set
        //    {
        //        dataModel.boardCells = value;
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
                            Tuple<int, int> position = (Tuple<int, int>)o;
                            int row = position.Item1;
                            int col = position.Item2;

                            // check move is corect
                            if (CanExecute(o))
                            {
                                // Aktualizuj model
                                dataModel.board[row, col] = dataModel.currentPlayer;

                                if (CheckForWinner() || CheckForDraw())
                                {
                                   
                                }
                                else
                                {
                                    // change player
                                    dataModel.currentPlayer = (dataModel.currentPlayer == "X") ? "O" : "X";
                                }
                            }
                        }
                        );
                return setPleyerCommand;
            }
        }

        private bool CanExecute(object parameter)
        {
            if (parameter is Tuple<int, int> position)
            {
                int row = position.Item1;
                int col = position.Item2;

                //check cell is empty
                if (dataModel.board[row, col] == "\0")
                {
                    return true;
                }
            }

            return false;
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
