using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab5
{
    public partial class ActionFleur : UserControl
    {
        private Jardin LeJardin;
        private Joueur LeJoueur;

        public ActionFleur(Joueur _j, Jardin _map)
        {
            LeJoueur = _j;
            LeJardin = _map;
            InitializeComponent();
            ActiverCeuillir();
        }
        /// <summary>
        /// Methode qui active les bons buttons
        /// </summary>
        private void ActiverCeuillir()
        {
            if (LeJoueur.PeutCeuillir())
            {
                BtnCeuillir.Enabled = true;
                BtnArroser.Enabled = false;
            }
            if (LeJoueur.PeutArroser())
            {
                BtnArroser.Enabled = false;
            }
        }
        /// <summary>
        /// Methode qui gere l'action d'arroser une plante
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnArroser_Click(object sender, EventArgs e)
        {
            LeJoueur.ArroserPlante();
            LeJardin.Refresh();
            LeJardin.FinPause();
            Dispose();
        }
        /// <summary>
        /// Methode qui gere l'action de ceuillir une plante
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnCeuillir_Click(object sender, EventArgs e)
        {
            LeJoueur.CreerPlante(8);
            LeJardin.Refresh();
            LeJardin.FinPause();
            Dispose();
        }
        /// <summary>
        /// Methode qui gere l'action d'annuler
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnAnnuler_Click(object sender, EventArgs e)
        {
            LeJardin.FinPause();
            Dispose();
        }

        private void ChkDeplanter_CheckedChanged(object sender, EventArgs e)
        {
            LeJoueur.CreerPlante(7);
            LeJardin.FinPause();
            Dispose();
        }
    }
}
