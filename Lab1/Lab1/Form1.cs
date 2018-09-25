using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab1
{
    public partial class FrmWtMenu : Form
    {
        public FrmWtMenu()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Permet de change la couleur de l'arriere-plan de l'appli
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnTheme_Click(object sender, EventArgs e)
        {
            if (DialogCouleurs.ShowDialog() == DialogResult.OK)
            {
                BackColor = DialogCouleurs.Color;
            }
        }
        /// <summary>
        /// Quitter le programme avec le menu quitter
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void quitterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }
        /// <summary>
        /// Montre un message de qui a realiser l'apppli et la date de remise
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void aProposToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Programmeur: Edwin Andino\nLabo1 31-Jan-2018");
        }
        /// <summary>
        /// Affiche un message lorsque la commande est completer
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnCommander_Click(object sender, EventArgs e)
        {
            if (LsChkCommander.Items.Count != 0)
            {
                MessageBox.Show("Votre commande sera traitée. Merci et Bonne journée !");
                reInitialise();
            }else
            {
                MessageBox.Show("Il n'y aucun item de choisi.", "Erreur",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        /// <summary>
        /// Ajoute le brevage choisi a la commande
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnBreuvage_Click(object sender, EventArgs e)
        {
            if (CboBreuvage.SelectedItem != null)
            {
                String Choix = CboBreuvage.SelectedItem.ToString();
                if(!LsChkCommander.Items.Contains(Choix))
                {
                    LsChkCommander.Items.Add(Choix);
                    BtnSupprimer.Enabled = true;
                }
                CboBreuvage.SelectedItem = null;
            }
        }
        /// <summary>
        /// Ajoute les accompagnements choisis a la commande
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnAccompagnement_Click(object sender, EventArgs e)
        {
            foreach (string s in LstAccompagnement.SelectedItems)
            {
                if (!LsChkCommander.Items.Contains(s))
                {
                    LsChkCommander.Items.Add(s);
                    BtnSupprimer.Enabled = true;
                }
            }
            LstAccompagnement.ClearSelected();
        }
        /// <summary>
        /// Ajoute les modifications voulus par le client au BigWac
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnAjoutModifier_Click(object sender, EventArgs e)
        {

                foreach(var control in PnlBigWac.Controls)
                {
                    if(control is TextBox)
                    {
                        var Saisie = (TextBox)control;
                        if (!String.IsNullOrEmpty(Saisie.Text) &&
                        !LsChkCommander.Items.Contains(Saisie.Text))
                        {
                            LsChkCommander.Items.Add(Saisie.Text);
                            BtnSupprimer.Enabled = true;
                        }
                    Saisie.Clear();
                    }
                }   
        }
        /// <summary>
        /// Supprime l'item choisi dans la liste de commande
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnSupprimer_Click(object sender, EventArgs e)
        {
            int Dernier = LsChkCommander.Items.Count - 1;
            for (int i = Dernier; i>=0; i--)
            {
                if (LsChkCommander.GetItemCheckState(i) == CheckState.Checked)
                {
                    LsChkCommander.Items.RemoveAt(i);
                }
            }
            if (LsChkCommander.Items.Count == 0)
            {
                BtnSupprimer.Enabled = false;
            }
        }
        /// <summary>
        /// Remet le formulaire a neuf
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MnuReinitialiser_Click(object sender, EventArgs e)
        {
            reInitialise();
        }
        /// <summary>
        /// Methode qui s'occupe de vider les items lorsque la commande est passer
        /// </summary>
        private void reInitialise()
        {
            foreach (Control control in PnlBigWac.Controls)
            {
                if (control is TextBox)
                {
                    TextBox Suprimer = (TextBox)control;
                    Suprimer.Clear();
                }
            }
            CboBreuvage.SelectedItem = null;
            LsChkCommander.Items.Clear();
            LstAccompagnement.ClearSelected();
            BtnSupprimer.Enabled = false;
        }
        
    }
}
