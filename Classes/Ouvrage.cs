using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gestionBibiothequeV2.Classes
{
    internal class Ouvrage
    {
        protected int numerg;
        protected string date;
        protected string cote;
        static int cmp = 0;

        public int Numerg { get => numerg; set => numerg = value; }
        public string Date { get => date; set => date = value; }
        public string Cote { get => cote; set => cote = value; }
        public static int Cmp { get => cmp; set => cmp = value; }

        public Ouvrage(string date, string cote)
        {
            Numerg = ++cmp;
            Date = date;
            Cote = cote;
        }


    }
}
