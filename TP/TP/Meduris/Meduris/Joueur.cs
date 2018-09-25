using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Meduris
{
    public class Joueur
    {
        private string NomJoueur;
        private Couleur CouleurJoueur;
        private Points PointsJoueur;
        private Ouvrier LesOuvriers;
        private LesRessources LstRess;
        private bool AConstruit;
        private bool Interdit;
        private int Ajustement = -1;
        private List<CaseJeu> CaseOuvrier;
        private bool Insuffisant;

        public Joueur(string _nom, Couleur _Couleur, Points _point)
        {
            NomJoueur = _nom;
            CouleurJoueur = _Couleur;
            PointsJoueur = _point;
            LstRess = new LesRessources();
            LesOuvriers = new Ouvrier(_Couleur);
            AConstruit = false;
            CaseOuvrier = new List<CaseJeu>();
        }

        public string Nom
        {
            get { return NomJoueur; }
            set { NomJoueur = value; }
        }

        public Couleur Couleur
        {
            get { return CouleurJoueur; }
            set { CouleurJoueur = value; }
        }

        public Points Points
        {
            get { return PointsJoueur; }
            set { PointsJoueur = value; }
        }

        public bool Construit
        {
            get { return AConstruit; }
            set { AConstruit = value; }
        }
        public bool PasAssez
        {
            get { return Insuffisant; }
            set { Insuffisant = value; }
        }
        /// <summary>
        /// Ajuste les ressources du joueurs
        /// </summary>
        /// <param name="Actualiser"></param>
        /// <param name="Ajout"></param>
        /// <returns></returns>
        public bool AjusterRessource(LaRessource Actualiser, int Ajout)
        {
            if(NbRessource(Actualiser) + Ajout >= 0)
            {
                LstRess.AjusterSpecific(Actualiser, Ajout);
                return true;
            }else
            {
                return false;
            }
            
        }
        /// <summary>
        /// Retourne la ressources voulu
        /// </summary>
        /// <param name="valeur"></param>
        /// <returns></returns>
        public int NbRessource(LaRessource valeur)
        {

            return valeur.Equals(LaRessource.Ouvrier) ? LesOuvriers.Disponible() : LstRess.Quantite(valeur);
        }
        /// <summary>
        /// Ajuste les points du joueur
        /// </summary>
        /// <param name="_ajout"></param>
        public void AjusterPoints(int _ajout)
        {
            PointsJoueur.Ajuster(_ajout);
        }
        /// <summary>
        /// Affiche l'ouvrier a l'ecran
        /// </summary>
        /// <param name="_indice"></param>
        /// <param name="_Lst"></param>
        public void AfficherOuvrier(string _indice, List<CaseJeu> _Lst)
        {
            CaseOuvrier = _Lst;
            Positionner(_indice);
        }
        /// <summary>
        /// Met l'ouvrier au bon endroit
        /// </summary>
        /// <param name="_indice"></param>
        private void MettreOuvrier(int _indice)
        {
            if(LesOuvriers.Disponible() > 0 && !Interdit)
            {
                LesOuvriers.AjusterOuvrier();
                LesOuvriers.Placer(_indice, CaseOuvrier);
            }
        }
        /// <summary>
        /// Prend l'ouvrier pour le déplacer
        /// </summary>
        /// <param name="_indice"></param>
        /// <param name="_Lst"></param>
        public void PrendreOuvrier(int _indice, List<CaseJeu> _Lst)
        {
            LesOuvriers.PrendOuvrier();
            LesOuvriers.VerifierOccupation(_indice, CaseOuvrier);
            CaseOuvrier = _Lst;
        }
        /// <summary>
        /// Affiche la construction selectionner
        /// </summary>
        /// <param name="_indice"></param>
        /// <param name="_Lst"></param>
        /// <param name="_hutte"></param>
        public void Construire(int _indice, List<CaseJeu> _Lst, bool _hutte)
        {
            if(LstRess.Quantite(LaRessource.Hutte) > 0 
                && _hutte && PeutPayer(_indice, _Lst))
            {
                LstRess.AjusterSpecific(LaRessource.Hutte, -1);
                LstRess.AjusterSpecific(_Lst.ElementAt(_indice).Cout, Ajustement);
                LstRess.AjusterSpecific(_Lst.ElementAt(_indice).Cout2, Ajustement);
                BatirHutte(_indice, _Lst);
                Ajustement = -1;
                AConstruit = true;
            }
            else if(LstRess.Quantite(LaRessource.Temple) > 0 
                && !_hutte && PeutPayer(_indice, _Lst))
            {
                LstRess.AjusterSpecific(LaRessource.Temple, -1);
                LstRess.AjusterSpecific(_Lst.ElementAt(_indice).Cout, -1);
                LstRess.AjusterSpecific(_Lst.ElementAt(_indice).Cout2, -1);
                BatirTemple(_indice, _Lst);
                AConstruit = true;
            }else if(!PeutPayer(_indice, _Lst))
            {
                AConstruit = false;
                Insuffisant = true;
                MessageBox.Show("Vouz n'avez pas assez de ressources");
            }
            if (AConstruit && _hutte)//hutte
            {
                //areviser pour ajuster si ajout hutte au bout gauche ou dtroie
                int Ajuster = VerifierVoisin(_indice, _Lst);
                if(_indice - 1 > -1 && _Lst.ElementAt(_indice - 1).Temple )
                {
                    _Lst.ElementAt(_indice - 1).Taille = TailleTemple(_indice - 1, _Lst);
                }
                else if(_indice + 1 < 32 && _Lst.ElementAt(_indice + 1).Temple)
                {
                    _Lst.ElementAt(_indice + 1).Taille = TailleTemple(_indice + 1, _Lst);
                }
            }
            else if (!_hutte)
            {
                _Lst.ElementAt(_indice).Taille = TailleTemple(_indice, _Lst);
            }
        }
        /// <summary>
        /// Ajuste si le joueur construit une hutte
        /// </summary>
        /// <param name="_indice"></param>
        /// <param name="_Lst"></param>
        private void BatirHutte(int _indice, List<CaseJeu> _Lst)
        {
            switch (CouleurJoueur)
            {
                case Couleur.Rouge:
                    _Lst.ElementAt(_indice).CaseAssocier().BackgroundImage =
                        Meduris.Properties.Resources.hutte_rouge;
                    _Lst.ElementAt(_indice).CouleurAssocier = Couleur.Rouge;
                    _Lst.ElementAt(_indice).Actif = true;
                    _Lst.ElementAt(_indice).Taille = VerifierVoisin(_indice, _Lst);
                    break;
                case Couleur.Bleu:
                    _Lst.ElementAt(_indice).CaseAssocier().BackgroundImage =
                            Meduris.Properties.Resources.hutte_bleu;
                    _Lst.ElementAt(_indice).CouleurAssocier = Couleur.Bleu;
                    _Lst.ElementAt(_indice).Actif = true;
                    _Lst.ElementAt(_indice).Taille = VerifierVoisin(_indice, _Lst);
                    break;
                case Couleur.Jaune:
                    _Lst.ElementAt(_indice).CaseAssocier().BackgroundImage =
                        Meduris.Properties.Resources.hutte_jaune;
                    _Lst.ElementAt(_indice).CouleurAssocier = Couleur.Jaune;
                    _Lst.ElementAt(_indice).Actif = true;
                    _Lst.ElementAt(_indice).Taille = VerifierVoisin(_indice, _Lst);
                    break;
                case Couleur.Vert:
                    _Lst.ElementAt(_indice).CaseAssocier().BackgroundImage =
                        Meduris.Properties.Resources.hutte_vert;
                    _Lst.ElementAt(_indice).CouleurAssocier = Couleur.Vert;
                    _Lst.ElementAt(_indice).Actif = true;
                    _Lst.ElementAt(_indice).Taille = VerifierVoisin(_indice, _Lst);
                    break;
                case Couleur.Violet:
                    _Lst.ElementAt(_indice).CaseAssocier().BackgroundImage =
                        Meduris.Properties.Resources.hutte_violet;
                    _Lst.ElementAt(_indice).CouleurAssocier = Couleur.Violet;
                    _Lst.ElementAt(_indice).Actif = true;
                    _Lst.ElementAt(_indice).Taille = VerifierVoisin(_indice, _Lst);
                    break;
                case Couleur.Turquoise:
                    _Lst.ElementAt(_indice).CaseAssocier().BackgroundImage =
                        Meduris.Properties.Resources.hutte_turquoise;
                    _Lst.ElementAt(_indice).CouleurAssocier = Couleur.Turquoise;
                    _Lst.ElementAt(_indice).Actif = true;
                    _Lst.ElementAt(_indice).Taille = VerifierVoisin(_indice, _Lst);
                    break;
            }
        }
        /// <summary>
        ///  Ajuste si le joueur construit un temple
        /// </summary>
        /// <param name="_indice"></param>
        /// <param name="_Lst"></param>
        private void BatirTemple(int _indice, List<CaseJeu> _Lst)
        {
            switch (CouleurJoueur)
            {
                case Couleur.Rouge:
                    _Lst.ElementAt(_indice).CaseAssocier().BackgroundImage =
                        Meduris.Properties.Resources.temple_rouge;
                    _Lst.ElementAt(_indice).CouleurAssocier = Couleur.Rouge;
                    _Lst.ElementAt(_indice).Temple = true;
                    break;
                case Couleur.Bleu:
                    _Lst.ElementAt(_indice).CaseAssocier().BackgroundImage =
                            Meduris.Properties.Resources.temple_bleu;
                    _Lst.ElementAt(_indice).CouleurAssocier = Couleur.Bleu;
                    _Lst.ElementAt(_indice).Temple = true;
                    break;
                case Couleur.Jaune:
                    _Lst.ElementAt(_indice).CaseAssocier().BackgroundImage =
                        Meduris.Properties.Resources.temple_jaune;
                    _Lst.ElementAt(_indice).CouleurAssocier = Couleur.Jaune;
                    _Lst.ElementAt(_indice).Temple = true;
                    break;
                case Couleur.Vert:
                    _Lst.ElementAt(_indice).CaseAssocier().BackgroundImage =
                        Meduris.Properties.Resources.temple_vert;
                    _Lst.ElementAt(_indice).CouleurAssocier = Couleur.Vert;
                    _Lst.ElementAt(_indice).Temple = true;
                    break;
                case Couleur.Turquoise:
                    _Lst.ElementAt(_indice).CaseAssocier().BackgroundImage =
                        Meduris.Properties.Resources.temple_turquoise;
                    _Lst.ElementAt(_indice).CouleurAssocier = Couleur.Turquoise;
                    _Lst.ElementAt(_indice).Temple = true;
                    break;
                case Couleur.Violet:
                    _Lst.ElementAt(_indice).CaseAssocier().BackgroundImage =
                        Meduris.Properties.Resources.temple_violet;
                    _Lst.ElementAt(_indice).CouleurAssocier = Couleur.Violet;
                    _Lst.ElementAt(_indice).Temple = true;
                    break;
            }
        }
        /// <summary>
        /// Verifie si le joueur peut construire la ou pas
        /// </summary>
        /// <param name="_indice"></param>
        /// <param name="_Lst"></param>
        /// <returns></returns>
        private bool PeutPayer(int _indice, List<CaseJeu> _Lst)
        {
             int Valeur = VerifierVoisin(_indice, _Lst);

            return (LstRess.Quantite(_Lst.ElementAt(_indice).Cout) >= Valeur
                && LstRess.Quantite(_Lst.ElementAt(_indice).Cout2) >= Valeur);
        }
        /// <summary>
        /// Modifie les voisin si disponible
        /// </summary>
        /// <param name="_indice"></param>
        /// <param name="_Lst"></param>
        /// <returns></returns>
        private int VerifierVoisin(int _indice, List<CaseJeu> _Lst)
        {
            int Valeur = 0;
            if (_indice == 0 && _Lst.ElementAt(_indice + 1).Actif)
            {
                ///////////////
                ////////////////
                ///////////////FIXED
                Valeur = VerifierDroite(Valeur , _indice + 1, _Lst) + 1;
                if (AConstruit)
                {
                    ajusterVoisin(Valeur, _indice, _Lst);
                }
            }
            else if (_indice > 0 && _indice < 31 && _Lst.ElementAt(_indice - 1).Actif && !_Lst.ElementAt(_indice + 1).Actif)
            {
                Valeur = VerifierGauche(Valeur, _indice - 1, _Lst) + 1;
                if(Valeur == 2 && AConstruit)
                {
                    _indice = _indice - 1;
                    ajusterVoisin(Valeur, _indice, _Lst);
                }
                
            }
            else if (_indice > 0 && _indice < 31 && !_Lst.ElementAt(_indice - 1).Actif && _Lst.ElementAt(_indice + 1).Actif)
            {
                Valeur = VerifierDroite(Valeur, _indice + 1, _Lst) + 1;
            }
            else if (_indice > 0 && _indice < 31 && _Lst.ElementAt(_indice - 1).Actif && _Lst.ElementAt(_indice + 1).Actif)
            {
                int nbDroite = VerifierDroite(Valeur, _indice + 1, _Lst);
                int nbGauche = VerifierGauche(Valeur, _indice - 1, _Lst);
                Valeur = nbDroite + nbGauche;
                if(AConstruit && nbGauche < nbDroite)
                {
                    ajusterVoisin(Valeur, nbGauche, _Lst);
                }
                else if (AConstruit && nbGauche > nbDroite)
                {
                    ajusterVoisin(Valeur, nbDroite, _Lst);
                }
            }
            else if (_indice == 31 && _Lst.ElementAt(_indice - 1).Actif)
            {//////////ATESTER
                Valeur = VerifierGauche(Valeur, _indice - 1, _Lst) + 1;
            }else if(Valeur == 0)
            {
                Valeur += 1;
            }

            Ajustement *= Valeur;
            return Valeur;
        }
        /// <summary>
        /// Verifie les voisin de Droite
        /// </summary>
        /// <param name="_Valeur"></param>
        /// <param name="_Indice"></param>
        /// <param name="_Lst"></param>
        /// <returns></returns>
        private int VerifierDroite(int _Valeur, int _Indice, List<CaseJeu> _Lst)
        {
            for (int i = _Indice; i < _Lst.Count; i++)
            {
                int Verifier = i + 1;
                if (_Lst.ElementAt(i).Actif && i < Verifier)
                {
                    _Valeur += 1;
                    //_Lst.ElementAt(i).Colonie = true;
                }
                else
                {
                    break;
                }
            }
            if (_Valeur > 1)
            {
                if (AConstruit)
                {
                    _Valeur += 1;
                }
                int Debut = (_Indice + _Valeur) - 1;
                if(Debut == 32)
                {
                    Debut = 31;
                }
                for (int i = Debut; i >= _Indice; i--)
                {
                    _Lst.ElementAt(i).Taille = _Valeur;
                }

            }
            return _Valeur;
        }
        /// <summary>
        /// Verifie les voisin de Gauche
        /// </summary>
        /// <param name="_Valeur"></param>
        /// <param name="_Indice"></param>
        /// <param name="_Lst"></param>
        /// <returns></returns>
        private int VerifierGauche(int _Valeur, int _Indice, List<CaseJeu> _Lst)
        {
            for (int i = _Indice; i >= 0; i--)
            {
                int Verifier = i;
                if (i > 0)
                {
                    Verifier = i - 1;
                }
                if (_Lst.ElementAt(i).Actif && i >= Verifier)
                {
                    _Valeur += 1;
                   // _Lst.ElementAt(i).Colonie = true;
                }
                else
                {
                    break;
                }

            }
            if (_Valeur > 1)
            {
                if (AConstruit)
                {
                    _Valeur += 1;
                }
                /////////////
                ////Donne -1 a hutte add au zer0
                int Debut = _Indice - _Valeur + 1;
                ///////////////////////
                ///////////////////
                //////////////
                if(Debut < 0)
                {
                    Debut = 0;
                }
                ///////////////
                ////////////////
                ///////////////FIXED
                for (int i = Debut; i <= _Indice; i++)
                {
                    _Lst.ElementAt(i).Taille = _Valeur;
                }

            }
            return _Valeur;
        }
        /// <summary>
        /// Regarde la bonne postion dans la liste
        /// </summary>
        /// <param name="_debut"></param>
        /// <param name="_fin"></param>
        /// <returns></returns>
        private int CaseExacte(int _debut, int _fin)
        {
            int indice = _debut;
            for (int i = _debut; i <= _fin; i++)
            {
                if (CaseOuvrier.ElementAt(i).Actif)
                {
                    indice += 1;
                }
                else { break; }
            }if (indice > _fin)
            {
                Interdit = true;
            }
            else
            {
                Interdit = false;
            }
            return indice;
        }
        /// <summary>
        /// Positionne L'ouvrier au bon endroit
        /// </summary>
        /// <param name="_position"></param>
        private void Positionner(string _position)
        {
            switch (_position)
            {
                case "2"://3-5
                    MettreOuvrier(CaseExacte(3, 5));
                    break;
                case "3"://6-8
                    MettreOuvrier(CaseExacte(6, 8));
                    break;
                case "4"://9-11
                    MettreOuvrier(CaseExacte(9, 11));
                    break;
                default: //0-2
                    MettreOuvrier(CaseExacte(0, 2));
                    break;
            }
        }
        /// <summary>
        /// Met la taille dans la case des voisins
        /// </summary>
        /// <param name="_ajuster"></param>
        /// <param name="_indice"></param>
        /// <param name="_Lst"></param>
        private void ajusterVoisin(int _ajuster, int _indice, List<CaseJeu> _Lst)
        {
            int remplacer = _ajuster;
            if (_indice == 0 && _ajuster == 2)
            {
                _ajuster = 1;
            }
            for (int i = _indice; i <= _ajuster; i++)
            {
                if (_indice == 0 && _ajuster == 1)
                {
                 //   _Lst.ElementAt(i).Colonie = true;
                    _Lst.ElementAt(i).Taille = remplacer;
                }
                else
                {
                  //  _Lst.ElementAt(i).Colonie = true;
                    _Lst.ElementAt(i).Taille = _ajuster;
                }
            }
        }
        /// <summary>
        /// Regarde si c'est la fin
        /// </summary>
        /// <returns></returns>
        public bool ConstructionFinal()
        {
            return NbRessource(LaRessource.Hutte) + NbRessource(LaRessource.Temple) == 0;
        }
        /// <summary>
        /// Met la taille de la colonie dans le temple
        /// </summary>
        /// <param name="_indice"></param>
        /// <param name="_Lst"></param>
        /// <returns></returns>
        private int TailleTemple(int _indice, List<CaseJeu> _Lst)
        {
            if (_indice == 0)
            {
                return _Lst.ElementAt(_indice + 1).Taille;
            }
            else if (_indice >= 1 && _indice < 31)
            {
                return _Lst.ElementAt(_indice - 1).Taille + _Lst.ElementAt(_indice + 1).Taille;
            }
            else if (_indice == 31)
            {
                return _Lst.ElementAt(_indice - 1).Taille;
            }
            else { return 0; }
        }

    }

}
