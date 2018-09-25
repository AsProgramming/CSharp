using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Meduris
{
    class De
    {
        private Button leDe;
        private Label TexteJeu;
        private int Valeur;
        private Random Aleatoire;
        private string[] RessourceAleatoire;
        public De(Button _De, Label _texte)
        {
            RessourceAleatoire = new string[4] { "Bois", "Cuivre", "Laine", "Roche" };
            leDe = _De;
            TexteJeu = _texte;
        }

        public int ValeurDe
        {
            get { return Valeur; }
            set { Valeur = value; }
        }
        /// <summary>
        /// Obtien le nombre aléatoire
        /// </summary>
        public void Rouler()
        {
            leDe.BackgroundImage = null;
            Aleatoire = new Random();
            Valeur = Aleatoire.Next(1, 7);
            AjusterImage();
        }
        /// <summary>
        /// Ajuste l'image pour la valeur aléatoire obtenue
        /// </summary>
        private void AjusterImage()
        {
            switch (Valeur)
            {
                case 2:
                    leDe.BackgroundImage = Meduris.Properties.Resources.De3_Laine;
                    break;
                case 3:
                    leDe.BackgroundImage = Meduris.Properties.Resources.De3_Cuivre;
                    break;
                case 4:
                    leDe.BackgroundImage = Meduris.Properties.Resources.De3_Roch;
                    break;
                case 5:
                    
                    leDe.BackgroundImage = Meduris.Properties.Resources.De_Mn;
                    ChoisirRessource();
                    break;
                case 6:
                    leDe.BackgroundImage = Meduris.Properties.Resources.De_Pl;
                    ChoisirRessource();
                    break;
                default:
                    leDe.BackgroundImage = Meduris.Properties.Resources.De3_Bois;
                    break;
            }

        }
        /// <summary>
        /// Fait clignoter l'image du de
        /// </summary>
        /// <param name="_Indice"></param>
        public void EnAttente(int _Indice)
        {
            if (TexteJeu.Visible)
            {
                TexteJeu.Visible = false;
            }
            if (_Indice % 2 == 0)
            {
                leDe.BackgroundImage = null;
            }
            else
            {
                leDe.BackgroundImage = Meduris.Properties.Resources.questions;
            }

        }
        /// <summary>
        /// Choisi la ressource au hasard
        /// </summary>
        private void ChoisirRessource()
        {
            int DetValeur = Aleatoire.Next(4);
            switch (DetValeur)
            {
                case 1:
                    TexteJeu.Text = RessourceAleatoire[DetValeur];
                    TexteJeu.ForeColor = System.Drawing.Color.Orange;
                    TexteJeu.Visible = true;
                    break;
                case 2:
                    TexteJeu.Text = RessourceAleatoire[DetValeur];
                    TexteJeu.ForeColor = System.Drawing.Color.Linen;
                    TexteJeu.Visible = true;
                    break;
                case 3:
                    TexteJeu.Text = RessourceAleatoire[DetValeur];
                    TexteJeu.ForeColor = System.Drawing.Color.Silver;
                    TexteJeu.Visible = true;
                    break;
                default:
                    TexteJeu.Text = RessourceAleatoire[DetValeur];
                    TexteJeu.ForeColor = System.Drawing.Color.MediumSeaGreen;
                    TexteJeu.Visible = true;
                    break;
            }
        }
    }
}

