using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace gestionBibiothequeV2.Classes
{
    internal class Livre : Ouvrage
    {
        protected string auteur;
        protected string titre;
        protected string editeur;

        public Livre(string auteur, string titre, string editeur, string date, string cote) : base(date, cote)
        {
            this.auteur = auteur;
            this.titre = titre;
            this.editeur = editeur;
        }

        public string Auteur() { return auteur; }
        public string Titre() { return titre; }
        public string Editeur() { return editeur; }
        public void SetAuteur(string valuer)
        {
            auteur = valuer;
        }
        public void SetTitre(string value)
        {
            titre = value;
        }
        public void SetEditeur(string value)
        {
            editeur = value;
        }



        public override string? ToString()
        {
            return base.ToString() + "auteur :" + auteur + " titre: " + titre + "" + Numerg;
        }
    }
}
