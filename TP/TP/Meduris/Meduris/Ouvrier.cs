using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Meduris
{
    public enum Couleur
    {
        Rouge,
        Vert,
        Jaune,
        Bleu,
        Violet,
        Turquoise
    };

    class Ouvrier
    {
        private Couleur CouleurOuvrier;
        private bool Mouvement; //not needed maybe
        private int nbOuvrier;
        private int IndiceActuel; //valeur du split position jeu 0
        private int LaPosition; //1e valeur du split nb de ressource cultiver 1
        private string RessourceRecueilli; // 2e valeur du split 2
        private int Precedente; //pour enlever l'ouvrier

        public Ouvrier(Couleur _Couleur)
        {
            CouleurOuvrier = _Couleur;
            nbOuvrier = 2;
        }

        public int Indice
        {
            get { return IndiceActuel; }
            set { IndiceActuel = value; }
        }

        public int Position
        {
            get { return LaPosition; }
            set { LaPosition = value; }
        }

        public string Produit
        {
            get { return RessourceRecueilli; }
            set { RessourceRecueilli = value; }
        }

        public int PositionAvant
        {
            get { return Precedente; }
            set { Precedente = value; }
        }

        public Couleur Couleur
        {
            get { return CouleurOuvrier; }
            set { CouleurOuvrier = value; }
        }

        public int Disponible()
        {
            return nbOuvrier;
        }

        public void AjusterOuvrier()
        {
            nbOuvrier -= 1;
        }

        public void PrendOuvrier()
        {
            nbOuvrier += 1;
        }
        /// <summary>
        /// Place l'ouvrier au bon endroit
        /// </summary>
        /// <param name="_endroit"></param>
        /// <param name="_Lst"></param>
        public void Placer(int _endroit, List<CaseJeu> _Lst)
        {
            switch (this.Couleur)
            {
                case Couleur.Rouge:
                    _Lst.ElementAt(_endroit).CaseAssocier().BackgroundImage =
                        Meduris.Properties.Resources.meeple_rouge;
                    RendreVisible(_endroit, _Lst, true);
                    break;
                case Couleur.Bleu:
                    //RendreVisible(_endroit, _Lst);
                    _Lst.ElementAt(_endroit).CaseAssocier().BackgroundImage =
                            Meduris.Properties.Resources.meeple_bleu;
                    RendreVisible(_endroit, _Lst, true);
                    break;
                case Couleur.Jaune:
                    //RendreVisible(_endroit, _Lst);
                    _Lst.ElementAt(_endroit).CaseAssocier().BackgroundImage =
                        Meduris.Properties.Resources.meeple_jaune;
                    RendreVisible(_endroit, _Lst, true);
                    break;
                case Couleur.Vert:
                    //RendreVisible(_endroit, _Lst);
                    _Lst.ElementAt(_endroit).CaseAssocier().BackgroundImage =
                        Meduris.Properties.Resources.meeple_vert;
                    RendreVisible(_endroit, _Lst, true);
                    break;
                case Couleur.Violet:
                    _Lst.ElementAt(_endroit).CaseAssocier().BackgroundImage =
                        Meduris.Properties.Resources.meeple_violet;
                    RendreVisible(_endroit, _Lst, true);
                    break;
                case Couleur.Turquoise:
                   // _Lst.ElementAt(_endroit).CouleurAssocier = Couleur.Vert;
                    _Lst.ElementAt(_endroit).CaseAssocier().BackgroundImage =
                        Meduris.Properties.Resources.meeple_turquoise;
                    RendreVisible(_endroit, _Lst, true);
                    break;
            }
        }

        private void RendreVisible(int _endroit, List<CaseJeu> _Lst, bool _placer)
        {
            if (_placer)
            {
                _Lst.ElementAt(_endroit).CouleurAssocier = CouleurOuvrier;
            }
            _Lst.ElementAt(_endroit).Actif = true;
            _Lst.ElementAt(_endroit).CaseAssocier().Cursor = Cursors.Hand;
        }
        /// <summary>
        /// Verifie la position de la case d'en haut et du bas
        /// </summary>
        /// <param name="_endroit"></param>
        /// <param name="_Lst"></param>
        public void VerifierOccupation(int _endroit, List<CaseJeu> _Lst)
        {
            //0-3-6-9 si un ou deux
            if (_endroit == 0 || _endroit == 3 || _endroit == 6 || _endroit == 9)
            {
                VerifierHaut(_endroit, _Lst);
            } else if (_endroit == 1 || _endroit == 4 || _endroit == 7 || _endroit == 10)
            {
                if(EstOccuper(_endroit + 1, _Lst))
                {
                    TranslationBas(_endroit + 1, _Lst, true);
                }
                else
                {
                    DesactiverCaseOuvrier(_endroit, _Lst);
                }
            }
            else
            {
                DesactiverCaseOuvrier(_endroit, _Lst);
            }
        }
        /// <summary>
        /// Verifie la position de la case d'en haut 
        /// </summary>
        /// <param name="_position"></param>
        /// <param name="_Lst"></param>
        private void VerifierHaut(int _position, List<CaseJeu> _Lst)
        {
            if (_position < 10 && EstOccuper(_position + 2, _Lst))
            {
                TranslationBas(_position + 1, _Lst, false);
                TranslationBas(_position + 2, _Lst, true);
                
            }
            else if (EstOccuper(_position + 1, _Lst))
            {
                TranslationBas(_position + 1, _Lst, true);
            }
            else
            {
                DesactiverCaseOuvrier(_position, _Lst);
            }
        }
        /// <summary>
        /// dit si occuper ou non
        /// </summary>
        /// <param name="_position"></param>
        /// <param name="_Lst"></param>
        /// <returns></returns>
        private bool EstOccuper(int _position, List<CaseJeu> _Lst)
        {
            return _Lst.ElementAt(_position).Actif;
        }
        /// <summary>
        /// Desactivce l'option de la main du curseur
        /// </summary>
        /// <param name="_endroit"></param>
        /// <param name="_Lst"></param>
        private void DesactiverCaseOuvrier(int _endroit, List<CaseJeu> _Lst)
        {
            _Lst.ElementAt(_endroit).Actif = false;
            _Lst.ElementAt(_endroit).CaseAssocier().Cursor = Cursors.Arrow;
            _Lst.ElementAt(_endroit).CaseAssocier().BackgroundImage = null;
        }
        /// <summary>
        /// Deplace les ouvriers vers le bas
        /// </summary>
        /// <param name="_position"></param>
        /// <param name="_Lst"></param>
        /// <param name="_verification"></param>
        private void TranslationBas(int _position, List<CaseJeu> _Lst, bool _verification)
        {
            if (_verification)
            {
                DesactiverCaseOuvrier(_position, _Lst);
            }
            
            switch (_Lst.ElementAt(_position).CouleurAssocier)
            {
                case Couleur.Rouge:
                    _Lst.ElementAt(_position - 1).CouleurAssocier = Couleur.Rouge;
                    _Lst.ElementAt(_position - 1).CaseAssocier().BackgroundImage =
                        Meduris.Properties.Resources.meeple_rouge;
                    RendreVisible(_position - 1, _Lst, false);
                    break;
                case Couleur.Bleu: 
                    _Lst.ElementAt(_position - 1).CouleurAssocier = Couleur.Bleu;
                    _Lst.ElementAt(_position - 1).CaseAssocier().BackgroundImage =
                            Meduris.Properties.Resources.meeple_bleu;
                    RendreVisible(_position - 1, _Lst, false);
                    break;
                case Couleur.Jaune:
                   
                    _Lst.ElementAt(_position - 1).CouleurAssocier = Couleur.Jaune;
                    _Lst.ElementAt(_position - 1).CaseAssocier().BackgroundImage =
                        Meduris.Properties.Resources.meeple_jaune;
                    RendreVisible(_position - 1, _Lst, false);
                    break;
                case Couleur.Vert:
                    _Lst.ElementAt(_position - 1).CouleurAssocier = Couleur.Vert;
                    _Lst.ElementAt(_position - 1).CaseAssocier().BackgroundImage =
                        Meduris.Properties.Resources.meeple_vert;
                    RendreVisible(_position - 1, _Lst, false);
                    break;
                case Couleur.Violet:
                    _Lst.ElementAt(_position - 1).CouleurAssocier = Couleur.Vert;
                    _Lst.ElementAt(_position - 1).CaseAssocier().BackgroundImage =
                        Meduris.Properties.Resources.meeple_violet;
                    RendreVisible(_position - 1, _Lst, false);
                    break;
                case Couleur.Turquoise:
                    _Lst.ElementAt(_position - 1).CouleurAssocier = Couleur.Vert;
                    _Lst.ElementAt(_position - 1).CaseAssocier().BackgroundImage =
                        Meduris.Properties.Resources.meeple_turquoise;
                    RendreVisible(_position - 1, _Lst, false);
                    break;
            }
        }
    }
}
