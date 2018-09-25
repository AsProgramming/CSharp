using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Meduris
{
    public enum LaRessource
    {
        Bois = 1,
        Cuivre,
        Laine,
        Roche,
        Hutte,
        Temple,
        Ouvrier
    };
    class LesRessources
    {

        private SortedList<LaRessource, int> LstRessources;
        private bool NonDisponibla;
        public LesRessources()
        {
            LstRessources = new SortedList<LaRessource, int>();
            LstRessources.Add(LaRessource.Bois, 1);
            LstRessources.Add(LaRessource.Cuivre, 1);
            LstRessources.Add(LaRessource.Laine, 1);
            LstRessources.Add(LaRessource.Roche, 1);
            LstRessources.Add(LaRessource.Hutte, 8);
            LstRessources.Add(LaRessource.Temple, 2);
        }
        /// <summary>
        /// Ajuste le nombre de la ressource specifier
        /// </summary>
        /// <param name="Actualiser"></param>
        /// <param name="Modifier"></param>
        public void AjusterSpecific(LaRessource Actualiser, int Modifier)
        {
            int Nouveau = Quantite(Actualiser);
            Nouveau += Modifier;
            LstRessources[Actualiser] = Nouveau;
        }
        /// <summary>
        /// Obtient le nombre de ressources disponible
        /// </summary>
        /// <param name="Indice"></param>
        /// <returns></returns>
        public int Quantite(LaRessource Indice)
        {
            int Valeur;
            LstRessources.TryGetValue(Indice, out Valeur);
            return Valeur;
        }
    }

}

