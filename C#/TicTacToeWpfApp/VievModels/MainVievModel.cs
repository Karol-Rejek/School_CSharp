using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using TicTacToeWpfApp.Models;
using UtilsWpf;

namespace TicTacToeWpfApp.VievModels
{
    class MainVievModel : ObserverVM
    {

        TicTacToeDataModel dataModel = new();

        public string SelectedPlayer
        {
            get { return dataModel.selectedPlayer; }
            set
            {
                dataModel.selectedPlayer = value;
                OnPropertyChanged(nameof(SelectedPlayer));
            }
        }

        public List<string> BoardText
        {
            get { return dataModel.boardText; }
            set
            {
                dataModel.boardText = value;
                OnPropertyChanged(nameof(BoardText));
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


        private ICommand setPleyerCommand;
        public ICommand SetPleyerCommand
        {
            get
            {
                if (setPleyerCommand == null)
                    setPleyerCommand = new RelayCommand<object>(
                        o =>
                        {
                            // find way to set button content without creating properties to each button
                            BoardText.Add(SelectedPlayer);
                        }
                        );
                return setPleyerCommand;
            }
        }
    }
}
