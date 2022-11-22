using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace TD
{
    public class MainViewModel : ViewModelBase
    {
        private readonly ObservableCollection<ElementViewModel> _elements;

        public MainViewModel()
        {
            _elements = new ObservableCollection<ElementViewModel>();
        }

        public ObservableCollection<ElementViewModel> Elements
        {
            get { return _elements; }


        }
    }
}
