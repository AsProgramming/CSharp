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
    public partial class Selection : Form
    {
        private LaRessource[] Choix;
        private Druide LeDruide;

        public Selection(Druide _druide)
        {
            LeDruide = _druide;
            Choix = new LaRessource[2];
            InitializeComponent();
        }
        /// <summary>
        /// Verifie si le button 1 est cliquer
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnUne_Click(object sender, EventArgs e)
        {
            LeDruide.ReponseRessource(Choix[0]);
            Visible = false;
        }
        /// <summary>
        /// Verifie si le button 2 est cliquer
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnDeux_Click(object sender, EventArgs e)
        {
            LeDruide.ReponseRessource(Choix[1]);
            Visible = false;
        }
        /// <summary>
        /// Obtien le bon cout a afficher
        /// </summary>
        /// <param name="_case"></param>
        public void ObtenirCout(LaRessource[] _case)
        {
            Choix = _case;
        }
        /// <summary>
        /// Charge la bonne image dans le forme
        /// </summary>
        private void InitImage()
        {
            switch (Choix[0])
            {
                case LaRessource.Bois:
                    BtnUne.Image = Meduris.Properties.Resources.RessBois;
                    PicRess1.BackgroundImage = Meduris.Properties.Resources.RessBois;
                    break;
                case LaRessource.Cuivre:
                    BtnUne.Image = Meduris.Properties.Resources.RessCuivre;
                    PicRess1.BackgroundImage = Meduris.Properties.Resources.RessCuivre;
                    break;
                case LaRessource.Laine:
                    BtnUne.Image = Meduris.Properties.Resources.RessLaine;
                    PicRess1.BackgroundImage = Meduris.Properties.Resources.RessLaine;
                    break;
                case LaRessource.Roche:
                    BtnUne.Image = Meduris.Properties.Resources.RessRoche;
                    PicRess1.BackgroundImage = Meduris.Properties.Resources.RessRoche;
                    break;
            }
            switch (Choix[1])
            {
                case LaRessource.Bois:
                    BtnDeux.Image = Meduris.Properties.Resources.RessBois;
                    PicRess2.BackgroundImage = Meduris.Properties.Resources.RessBois;
                    break;
                case LaRessource.Cuivre:
                    BtnDeux.Image = Meduris.Properties.Resources.RessCuivre;
                    PicRess2.BackgroundImage = Meduris.Properties.Resources.RessCuivre;
                    break;
                case LaRessource.Laine:
                    BtnDeux.Image = Meduris.Properties.Resources.RessLaine;
                    PicRess2.BackgroundImage = Meduris.Properties.Resources.RessLaine;
                    break;
                case LaRessource.Roche:
                    BtnDeux.Image = Meduris.Properties.Resources.RessRoche;
                    PicRess2.BackgroundImage = Meduris.Properties.Resources.RessRoche;
                    break;
            }
        }
        /// <summary>
        /// Accede a la bonne ressource
        /// </summary>
        /// <param name="_ress1"></param>
        /// <param name="_ress2"></param>
        public void LeCout(LaRessource _ress1, LaRessource _ress2)
        {
            Choix[0] = _ress1;
            Choix[1] = _ress2;
            InitImage();
        }
        /// <summary>
        /// Envoi de l'information du bon joueur
        /// </summary>
        /// <param name="_Nom"></param>
        /// <param name="_Ress"></param>
        /// <param name="_Ress2"></param>
        public void Information(string _Nom, string _Ress, string _Ress2)
        {
            TxtRessource.Text = _Ress;
            TxtRessource2.Text = _Ress2;
            LblNom.Text = _Nom;
        }
    }
}
