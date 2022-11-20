using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gestionBibiothequeV2.Classes
{
    internal class Utilisateur
    {

        private string nom;
        private string mot_passe;

        public Utilisateur(string nom, string mot_passe)
        {
            Nom = nom;
            Mot_passe = mot_passe;
        }

        public string Nom { get => nom; set => nom = value; }
        public string Mot_passe { get => mot_passe; set => mot_passe = value; }
    }
}
