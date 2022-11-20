using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gestionBibiothequeV2.Classes
{
    internal abstract class Bibiotheque
    {

        abstract public void Ajouter(Ouvrage o);
        abstract public void Supprimer(Ouvrage o);
    }
}
