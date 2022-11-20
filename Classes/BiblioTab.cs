using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gestionBibiothequeV2.Classes
{
    internal class BiblioTab : Bibiotheque
    {
        private int capacite;
        Ouvrage[] Ouvrages;
        static int compteur = 0;
        public BiblioTab(int capacite)
        {
            this.capacite = capacite;
            Ouvrages = new Ouvrage[capacite];
        }
        public override void Ajouter(Ouvrage o)
        {
            if (capacite < Ouvrages.Length)
            {
                Ouvrages[capacite] = o;
                compteur++;
            }
        }
        public override void Supprimer(Ouvrage o)
        {
            for (int i = 0; i < Ouvrages.Length; i++)
            {
                if (o.Numerg == Ouvrages[i].Numerg)
                {
                     {
                            for (int j = i; j < Ouvrages.Length; j++)
                            {
                                Ouvrages[j] = Ouvrages[j + 1];
                            }
                        }
                    
                    compteur--;
                }
            }
        }
        public override string? ToString()
        {
            return base.ToString();
        }
    }
}
