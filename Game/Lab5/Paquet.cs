using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5
{
    public class Paquet
    {
        private Maison LaMaison;
        private bool EnRoute;
        private int[] LaCommande;
        private int NbJours;

        public Paquet(Maison LaM, int[] _n)
        {
            EnRoute = true;
            LaMaison = LaM;
            LaCommande = _n;
        }

        public Paquet(Maison LaM)
        {
            EnRoute = false;
            LaMaison = LaM;
        }

        public bool EnTransit
        {
            get { return EnRoute; }
        }

        public int EnAttente
        {
            set { NbJours = value; }
            get { return NbJours; }
        }
        /// <summary>
        /// Methode qui se charge de convertir le prix en nombre de semance
        /// </summary>
        /// <param name="_i"></param>
        /// <returns></returns>
        private int NbExact(int _i)
        {
            switch (_i)
            {
                case 3:
                    return _i = LaCommande[_i - 1] / 20;
                case 4:
                    return _i = LaCommande[_i - 1] / 50;
                case 5:
                    return _i = LaCommande[_i - 1] / 80;
                default:
                    return _i = LaCommande[_i - 1] / 10;
            }
        }
        /// <summary>
        /// Methode qui se charge de donner au joueur les semances
        /// </summary>
        public void Livrer()
        {
            if (!LaMaison.PlusieursCommande())
            {
                LaMaison.PasserCommande = false;
            }
            EnRoute = false;
            for (int i = 1; i < LaCommande.Length; i++)
            {
                if (LaCommande[i - 1] > 0)
                {
                    LaMaison.Acces.LeJoueur.Disponible.AchatSemance(i, NbExact(i));
                }
            }
        }
    }
}
