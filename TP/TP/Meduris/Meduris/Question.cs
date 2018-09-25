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
    public partial class Question : Form
    {
        private int LaReponse;
        private LaRessource[] LaCase;
        private Druide LeDruide;

        public Question(string _nom, Druide _druide)
        {
            LaCase = new LaRessource[2];
            InitializeComponent();
            LblNom.Text = _nom;
            LeDruide = _druide;
        }
        /// <summary>
        /// Donne acces au bon clique de l'utilisateur
        /// </summary>
        /// <returns></returns>
        public int Reponse()
        {
            return LaReponse;
        }
        /// <summary>
        /// Donne acces a la bonne ressource a retirer
        /// </summary>
        /// <returns></returns>
        public LaRessource RetirerRessource()
        {
            return LaCase[LaReponse];
        }
        /// <summary>
        /// Verifie si le button  est cliquer
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnAucune_Click(object sender, EventArgs e)
        {
            LaReponse = 0;
            Visible = false;
        }
        /// <summary>
        /// Verifie si le button 1 est cliquer
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnUne_Click(object sender, EventArgs e)
        {
            LeDruide.ReponsePopUp(1);
            Visible = false;
        }
        /// <summary>
        /// Verifie si le button 2 est cliquer
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnDeux_Click(object sender, EventArgs e)
        {
            Visible = false;
            LeDruide.ReponsePopUp(2);
        }
        /// <summary>
        /// Accede a la bonne ressource
        /// </summary>
        /// <param name="_ress1"></param>
        /// <param name="_ress2"></param>
        public void LeCout(LaRessource _ress1, LaRessource _ress2)
        {
            LaCase[0] = _ress1;
            LaCase[1] = _ress2;
        }
    }
}
