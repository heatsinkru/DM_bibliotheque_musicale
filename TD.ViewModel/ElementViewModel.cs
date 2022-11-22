using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace TD
{
    public class ElementViewModel : ViewModelBase
    {
        private string _compositeur;
        private string _album;
        private List<Piste> _pistes;

        public ElementViewModel(string compositeur, string album, List<Piste> pistes)
        {
            _compositeur = compositeur;
            _album = album;
            _pistes = pistes;

        }
        public string Compositeur
        {
            get { return _compositeur; }
            set { _compositeur = value; }
        }
        public string Album
        {
            get { return _album; }
            set { _album = value; }
        }
        public List<Piste> Pistes
        {
            get { return _pistes; }
            set { _pistes = value; }
        }

    }
}
