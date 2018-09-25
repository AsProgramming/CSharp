using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Meduris
{
    public class Druide
    {
        private int Construction;
        private int Indice = 0;
        private int PositionAvant;
        private int Prochain;
        private int LaReponse;
        private bool TraverserRiviere;
        private bool TourFinal;
        private List<CaseJeu> CaseTemple;
        private List<CaseJeu> CaseHutte;
        private List<CaseJeu> CaseJoueur;
        private List<Joueur> LstJoueurs;
        private List<int> AVisiter;
        private LaRessource ReponseSelection;

        public Druide(List<CaseJeu> _associer)
        {
            Construction = -1;
            CaseTemple = _associer;
            AVisiter = new List<int>();
        }
        /// <summary>
        /// Ajoute les huttes dans la liste a vister du druide
        /// </summary>
        /// <param name="_indice"></param>
        /// <param name="_Lst"></param>
        public void AjouterHutte(int _indice, List<CaseJeu> _Lst)
        {
            AVisiter.Add(_indice);
            AVisiter.Sort();
            CaseJoueur = _Lst;
        }
        /// <summary>
        /// Ajuste la liste de hutte au besoin
        /// </summary>
        public List<CaseJeu> NouvelleLst
        {
            get { return CaseHutte; }
            set { CaseHutte = value; }
        }
        /// <summary>
        /// Avise si le Druide a fait un tour complet du tableau
        /// </summary>
        public bool TourComplet
        {
            get { return TraverserRiviere; }
            set { TraverserRiviere = value; }
        }

        public void CaseOffrande(List<CaseJeu> _associer)
        {
            CaseHutte = _associer;
        }

        public bool AvantFinal
        {
            get { return TourFinal; }
            set { TourFinal = value; }
        }

        public int NbConstruction
        {
            get { return Construction; }
            set { Construction = value; }
        }

        public void JoueurConstruit()
        {
            if(Construction < 4)
            {
                Construction += 1;
            }   
        }

        public void Correspondant(List<Joueur> _Lst)
        {
            LstJoueurs = _Lst;
        }

        public void DescendreTemple()
        {
            switch (Construction)
            {
                case 1:
                    CaseTemple.ElementAt(1).CaseAssocier().BackgroundImage = null;
                    CaseTemple.ElementAt(2).CaseAssocier().BackgroundImage = Meduris.
                        Properties.Resources.druide_normal;
                    break;
                case 2:
                    CaseTemple.ElementAt(2).CaseAssocier().BackgroundImage = null;
                    CaseTemple.ElementAt(3).CaseAssocier().BackgroundImage = Meduris.
                        Properties.Resources.druide_normal;
                    break;
                case 3:
                    CaseTemple.ElementAt(3).CaseAssocier().BackgroundImage = null;
                    VisiterHutte();
                    break;
                default:
                    CaseTemple.ElementAt(0).CaseAssocier().BackgroundImage = null;
                    CaseTemple.ElementAt(1).CaseAssocier().BackgroundImage = Meduris.
                        Properties.Resources.druide_normal;
                    break;
            }
        }
        /// <summary>
        /// Deplace le druide au bon endroit
        /// </summary>
        public void VisiterHutte()
        {
            if(NbConstruction == 3)
            {
                if (PositionAvant == 0 && AVisiter.Count != 0)
                {
                    PositionAvant = AVisiter.ElementAt(Indice);
                    CaseHutte.ElementAt(PositionAvant).CaseAssocier().BackgroundImage = Meduris.
                        Properties.Resources.druide_normal;
                }else if (PositionAvant == 0 && AVisiter.Count == 0)
                {
                    CaseTemple.ElementAt(3).CaseAssocier().BackgroundImage = null;
                    CaseTemple.ElementAt(3).CaseAssocier().BackgroundImage = Meduris.
                        Properties.Resources.druide_normal;
                }
                else
                {
                    Avancer();
                    CaseHutte.ElementAt(PositionAvant).CaseAssocier().BackgroundImage = null;
                    CaseHutte.ElementAt(Prochain).CaseAssocier().BackgroundImage = Meduris.
                        Properties.Resources.druide_normal;
                    PositionAvant = Prochain;
                }
            DemanderOffrande(CaseJoueur.ElementAt(PositionAvant).CouleurAssocier);
            }
        }
        /// <summary>
        /// Avance le druide
        /// </summary>
        private void Avancer()
        {
            Indice += 1;
            if (Indice < AVisiter.Count)
            {
                Prochain = AVisiter.ElementAt(Indice);
            }
            else
            {
                Indice = 0;
                TraverserRiviere = true;
                Prochain = AVisiter.ElementAt(Indice);
            }
        }
        /// <summary>
        /// Demande a la case les offrandes
        /// </summary>
        /// <param name="_indice"></param>
        private void DemanderOffrande(Couleur _indice)
        {
            Joueur Joueur = TrouverJoueur(_indice);

            Question Popup = new Question(Joueur.Nom, this);
            Popup.LeCout(CaseJoueur.ElementAt(PositionAvant).Cout, CaseJoueur.ElementAt(PositionAvant).Cout2);
            Popup.ShowDialog();
            if (LaReponse == 0)
            {
                if(Joueur.Points.NbPoints - 1 >= 0)
                {
                    Joueur.AjusterPoints(-1);
                }
            }
            else if (LaReponse == 1)
            {
                Selection reponse = new Selection(this);
                reponse.LeCout(CaseJoueur.ElementAt(PositionAvant).Cout, CaseJoueur.ElementAt(PositionAvant).Cout2);
                reponse.Information(Joueur.Nom, 
                    Joueur.NbRessource(CaseJoueur.ElementAt(PositionAvant).Cout).ToString(), 
                    Joueur.NbRessource(CaseJoueur.ElementAt(PositionAvant).Cout2).ToString());
                reponse.ShowDialog();
                if (Joueur.AjusterRessource(ReponseSelection, -1)){
                    Joueur.AjusterPoints(1);
                    Joueur.AjusterRessource(ReponseSelection, -1);
                }else
                {
                    Joueur.AjusterPoints(-1);
                    MessageBox.Show("Vous ne pouvez pas payer ces ressources");
                }
            }
            else if(LaReponse == 2)
            {
                if(Joueur.AjusterRessource(CaseJoueur.ElementAt(PositionAvant).Cout, -1) &&
                Joueur.AjusterRessource(CaseJoueur.ElementAt(PositionAvant).Cout2, -1))
                {
                    Joueur.AjusterPoints(CalculerPoint());
                }else
                {
                    MessageBox.Show("Vous ne pouvez pas payer ces ressources");
                    Popup.Dispose();
                    DemanderOffrande(_indice);
                }
                
                //calculer si colonie ou non
            }
            LaReponse = 0;
        }
        /// <summary>
        /// Modifie le joueur correspondant
        /// </summary>
        /// <param name="_indice"></param>
        /// <returns></returns>
        private Joueur TrouverJoueur(Couleur _indice)
        {
            Joueur LeJoueur = null;
            for (int i = 0; i < LstJoueurs.Count; i++)
            {
                if (LstJoueurs.ElementAt(i).Couleur == _indice)
                {
                    LeJoueur = LstJoueurs.ElementAt(i);
                }
            }
            return LeJoueur;
        }
        /// <summary>
        /// Calcul des points selon l'option choisi
        /// </summary>
        /// <returns></returns>
        private int CalculerPoint()
        {
            int LesPoints = 1;
            LesPoints *= CaseJoueur.ElementAt(PositionAvant).Taille;
            return LesPoints;
        }
        /// <summary>
        /// Acces de la reponse du joueur dans le popup
        /// </summary>
        /// <param name="_reponse"></param>
        public void ReponsePopUp(int _reponse)
        {
            LaReponse = _reponse;
        }
        /// <summary>
        /// Acces de la ressource du joueur dans le popup
        /// </summary>
        /// <param name="_reponse"></param>
        public void ReponseRessource(LaRessource _reponse)
        {
            ReponseSelection = _reponse;
        }

        public void AjusterList(List<CaseJeu> _Lst)
        {
            CaseJoueur = _Lst;
        }
        /// <summary>
        /// Garde la derniere position pour revenir pour annoncez la fin du jeu
        /// </summary>
        /// <param name="_PositionFinal"></param>
        /// <param name="_Runique"></param>
        /// <param name="_LstTemple"></param>
        public void TourAvantFinal(int _PositionFinal, SortedList<int, string> _Runique, List<CaseJeu> _LstTemple)
        {
            int Debut = AVisiter.IndexOf(_PositionFinal);
            if(Debut == -1)
            {
                Debut = Indice;
            }
            int TourComplet = 0;
            for (int i = Debut; i <= AVisiter.Count; i++)
            {
                if (i == AVisiter.Count)
                {
                    i = 0;
                }
                else if (TourComplet == AVisiter.Count)
                {
                    break;
                }
                else
                {
                    VisiterHutte();
                    TourComplet += 1;
                }
            }
            if (!TourFinal)
            {
                LeTourFinal(_PositionFinal, _Runique, _LstTemple);
            }
        }
        /// <summary>
        /// Le druide se déplace pour le tour final
        /// </summary>
        /// <param name="_Position"></param>
        /// <param name="_Runique"></param>
        /// <param name="_Lst"></param>
        private void LeTourFinal(int _Position, SortedList<int, string> _Runique, List<CaseJeu> _Lst)
        {
            TourFinal = true;
            int[] Calcul = new int[3];
            for (int i = 0; i < _Lst.Count; i++)
            {
                if (_Lst.ElementAt(i).CouleurAssocier == LstJoueurs.ElementAt(0).Couleur)
                {
                    LstJoueurs.ElementAt(0).AjusterPoints(_Lst.ElementAt(i).Taille);
                }
                else if(_Lst.ElementAt(i).CouleurAssocier == LstJoueurs.ElementAt(1).Couleur)
                {
                    LstJoueurs.ElementAt(1).AjusterPoints(_Lst.ElementAt(i).Taille);
                }
                else
                {
                    LstJoueurs.ElementAt(2).AjusterPoints(_Lst.ElementAt(i).Taille);
                }
            }

            for (int i = 0; i < _Runique.Count; i++)
            {
                if (_Runique.ElementAt(i).Value == LstJoueurs.ElementAt(0).Nom)
                {
                    Calcul[0] += 1;
                }
                else if (_Runique.ElementAt(i).Value == LstJoueurs.ElementAt(1).Nom)
                {
                    Calcul[1] += 1;
                }
                else if (_Runique.ElementAt(i).Value == LstJoueurs.ElementAt(2).Nom)
                {
                    Calcul[2] += 1;
                }
            }
            LstJoueurs.ElementAt(0).AjusterPoints(DecompteRunique(Calcul[0]));
            LstJoueurs.ElementAt(1).AjusterPoints(DecompteRunique(Calcul[1]));
            LstJoueurs.ElementAt(2).AjusterPoints(DecompteRunique(Calcul[2]));
            MessageBox.Show("Attention! Tour Finale");
            TourAvantFinal(_Position, _Runique, _Lst);
        }
        /// <summary>
        /// Calcul des ruines
        /// </summary>
        /// <param name="_Total"></param>
        /// <returns></returns>
        private int DecompteRunique(int _Total)
        {
            if(_Total != 0)
            {
                int Reponse = 0;
                for (int i = 1; i <= _Total; i++)
                {
                    Reponse += i;
                }
                return Reponse;
            }
            else { return 0; }
        }
    }
}
