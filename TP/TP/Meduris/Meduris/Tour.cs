using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Meduris
{
    class Tour
    {
        private int Indice = 0;
        private List<Joueur> LstJoueur;

        /// <summary>
        /// ///////
        /// </summary>
        /// <param name="un"></param>
        /// <param name="deux"></param>
        /// <param name="trois"></param>
        public Tour(Joueur un, Joueur deux, Joueur trois)
        {
            //better to add tab de joueur and cycle through
            LstJoueur = new List<Joueur>();
            LstJoueur.Add(un);
            LstJoueur.Add(deux);            //              //////////////////////////////////
            LstJoueur.Add(trois);
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="_LaLst"></param>
        /// 


        public Tour(List<Joueur> _LaLst)
        {
            LstJoueur = _LaLst;
        }
        /// <summary>
        /// Revien au debut de la liste
        /// </summary>
        /// <returns></returns>
        public Joueur Debut()
        {
            Indice = 0;
            return LstJoueur.First();
        }
        /// <summary>
        /// Obtient le prochain joueur
        /// </summary>
        /// <returns></returns>
        public Joueur Prochain()
        {
            if(Indice < 2)
            {
                Indice += 1;
                return LstJoueur.ElementAt(Indice);
            }
            else { return Debut(); }
        }
        /// <summary>
        /// Retourne le joueur qui est entrain de joueur
        /// </summary>
        /// <returns></returns>
        public Joueur Courant()
        {
            return LstJoueur.ElementAt(Indice);
        }
        /// <summary>
        /// retourne les noms des joueurs
        /// </summary>
        /// <returns></returns>
        public string[] LesNoms()
        {
            string[] Noms = new string[3];
            for (int i = 0; i < LstJoueur.Count; i++)
            {
                Noms[i] = LstJoueur.ElementAt(i).Nom;
            }
            return Noms;
        }
        /// <summary>
        ///Donne access a la liste de joueur
        /// </summary>
        /// <returns></returns>
        public List<Joueur> LaListe()
        {
            return LstJoueur;
        }
        /// <summary>
        /// Ajustement des ressources
        /// </summary>
        /// <param name="_couleur"></param>
        /// <param name="_valeur"></param>
        /// <param name="_ajuster"></param>
        public void CollecterRessource(Couleur _couleur, int _valeur, LaRessource _ajuster)
        {
            foreach(Joueur j in LstJoueur)
            {
                if(j.Couleur == _couleur && _valeur > 0)
                {
                    j.AjusterRessource(_ajuster, _valeur);
                }else if(j.Couleur == _couleur && j.NbRessource(_ajuster) > 0)
                {
                    j.AjusterRessource(_ajuster, _valeur);
                }
            }
        }
        /// <summary>
        /// Donne les points au bon joueur
        /// </summary>
        /// <param name="_indice"></param>
        /// <param name="_Pts"></param>
        public void DonnerLesPoints(int _indice, int _Pts)
        {
            LstJoueur.ElementAt(_indice).AjusterPoints(_Pts);
        }
        /// <summary>
        /// Affiche le resultat de la partie
        /// </summary>
        public void FinPartie()
        {
            MessageBox.Show("Résultat :" + Environment.NewLine + LstJoueur.ElementAt(0).Nom+
                " a " +LstJoueur.ElementAt(0).Points.NbPoints +" Points" + Environment.NewLine 
                + LstJoueur.ElementAt(1).Nom +
                " a " + LstJoueur.ElementAt(1).Points.NbPoints + " Points" + Environment.NewLine
                + LstJoueur.ElementAt(2).Nom +
                " a " + LstJoueur.ElementAt(2).Points.NbPoints + " Points" + Environment.NewLine);
        }
    }
}
