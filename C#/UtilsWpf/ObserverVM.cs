using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace UtilsWpf
{
    public class ObserverVM : INotifyPropertyChanged
    {

        #region Informowanie bindowania
        //-----------------------
        // EVENT
        public event PropertyChangedEventHandler? PropertyChanged;

        //-----------------------
        // FUNCTIONS
        public void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
        #endregion
    }
}