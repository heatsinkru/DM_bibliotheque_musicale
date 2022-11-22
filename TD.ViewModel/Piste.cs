using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TD
{
    public class Piste
    {
        private string _id;
        private string _titre;
        public Piste(string id, string titre)
        {
            _id = id;
            _titre = titre;

        }

        public string Id
        {
            get { return _id; }

        }
        public string Titre
        {
            get { return _titre; }
            set { _titre = value; }
        }


    }
}
