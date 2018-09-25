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
    public partial class Ordi : UserControl
    {
        private Maison LaMaison;

        public Ordi(Maison _m)
        {
            LaMaison = _m;
            InitializeComponent();
            if (LaMaison.Acces.LeJoueur.Disponible.AucunPlant())
            {
                BntVendre.Enabled = false;
            }
            //////////if (LaMaison.PasserCommande)
            //////////{
            //////////    BntAcheter.Enabled = false;
            //////////}
            if (LaMaison.Acces.LeJoueur.Disponible.Solde == 0)
            {
                BntAcheter.Enabled = false;
            }

        }
        /// <summary>
        /// /Methode qui gere la creation de l'ecran achat
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BntAcheter_CheckedChanged(object sender, EventArgs e)
        {
            ActionsOrdi Upay = new ActionsOrdi(LaMaison, false);
            Upay.Location = new Point(100, 220);
            LaMaison.Acces.Controls.Add(Upay);
            Dispose();
        }
        /// <summary>
        ///  Methode qui gere la creation de l'ecran vente
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BntVendre_CheckedChanged(object sender, EventArgs e)
        {
            ActionsOrdi Upay = new ActionsOrdi(LaMaison, true);
            Upay.Location = new Point(100, 220);
            LaMaison.Acces.Controls.Add(Upay);
            Dispose();
        }
        /// <summary>
        ///  Methode qui gere l'annuler
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BntAnnuler_CheckedChanged(object sender, EventArgs e)
        {
            LaMaison.Acces.FinPause();
            this.Dispose();
        }
    }
}
