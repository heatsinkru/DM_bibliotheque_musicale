using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TD
{
    public class ViewModelBase : INotifyPropertyChanged
    {
        // Evènement déclenché lorsqu'une propriété change de valeur.
        public event PropertyChangedEventHandler? PropertyChanged;

        protected void OnPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null) // Vérifie si l'évènement a bien un abonné.
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }
    }
}
