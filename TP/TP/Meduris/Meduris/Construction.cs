using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Meduris
{
    public partial class Construction : Form
    {
        private Jeu Jeu;
        public Construction(Jeu J)
        {
            InitializeComponent();
            Jeu = J;
            ChargerImage();
        }
        /// <summary>
        /// Postionne la fenetre
        /// </summary>
        /// <param name="X"></param>
        /// <param name="Y"></param>
        public void Positioner(int X, int Y)
        {
            this.Location = new System.Drawing.Point(X, Y);
            if(Jeu.Courant().NbRessource(LaRessource.Hutte) == 0)
            {
                ChkBxHutte.Enabled = false;
            }else if(Jeu.Courant().NbRessource(LaRessource.Temple) == 0)
            {
                ChkBxTemple.Enabled = false;
            }
        }
        /// <summary>
        /// Ferme la fenetre
        /// </summary>
        public void Desactiver()
        {
            this.Visible = false;
        }
        /// <summary>
        /// Verifie si la hutte est la selection
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ChkBxHutte_CheckedChanged(object sender, EventArgs e)
        {
            Jeu.SelectionConstruire(0);
            Desactiver();
        }
        /// <summary>
        /// Verifie si le temple est la selection
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ChkBxTemple_CheckedChanged(object sender, EventArgs e)
        {
            Jeu.SelectionConstruire(1);
            Desactiver();
        }
        /// <summary>
        /// Charge les bonnes images 
        /// </summary>
        private void ChargerImage()
        {
            switch (Jeu.VerifierLaCouleur())
            {
                case Couleur.Rouge:
                    this.BackColor = Color.Maroon;
                    ChkBxHutte.BackgroundImage = Meduris.Properties.Resources.hutte_rouge;
                    ChkBxTemple.BackgroundImage = Meduris.Properties.Resources.temple_rouge;
                    break;
                case Couleur.Bleu:
                    this.BackColor = Color.DodgerBlue;
                    ChkBxHutte.BackgroundImage = Meduris.Properties.Resources.hutte_bleu;
                    ChkBxTemple.BackgroundImage = Meduris.Properties.Resources.temple_bleu;
                    break;
                case Couleur.Jaune:
                    this.BackColor = Color.Gold;
                    ChkBxHutte.BackgroundImage = Meduris.Properties.Resources.hutte_jaune;
                    ChkBxTemple.BackgroundImage = Meduris.Properties.Resources.temple_jaune;
                    break;
                case Couleur.Vert:
                    this.BackColor = Color.ForestGreen;
                    ChkBxHutte.BackgroundImage = Meduris.Properties.Resources.hutte_vert;
                    ChkBxTemple.BackgroundImage = Meduris.Properties.Resources.temple_vert;
                    break;
                case Couleur.Violet:
                    this.BackColor = Color.DarkOrchid;
                    ChkBxHutte.BackgroundImage = Meduris.Properties.Resources.hutte_violet;
                    ChkBxTemple.BackgroundImage = Meduris.Properties.Resources.temple_violet;
                    break;
                case Couleur.Turquoise:
                    this.BackColor = Color.Cyan;
                    ChkBxHutte.BackgroundImage = Meduris.Properties.Resources.hutte_turquoise;
                    ChkBxTemple.BackgroundImage = Meduris.Properties.Resources.temple_turquoise;
                    break;
            }
        }
    }
}
