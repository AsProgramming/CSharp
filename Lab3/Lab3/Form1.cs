using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab3
{
    public partial class FrmPokemon : Form
    {
        public FrmPokemon()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Methode qui presente le programmeur
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MnuAide_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Programmeur: Edwin Andino");
        }
        /// <summary>
        /// Methode qui quitte le programme
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MnuQuitter_Click(object sender, EventArgs e)
        {
            Close();
        }
        /// <summary>
        /// Methode qui enleve lerreur de lecran si oui est appuyez
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OptOui_CheckedChanged(object sender, EventArgs e)
        {
            ErrGestion.SetError(PnlCapturer, "");
            LblProprietaire.Visible = true;
            TxtProprietaire.Visible = true;
        }
        /// <summary>
        /// Methode qui enleve lerreur de lecran si le non est appuyez
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OptNon_CheckedChanged(object sender, EventArgs e)
        {
            ErrGestion.SetError(PnlCapturer, "");
            if (TxtProprietaire.Visible == true)
            {
                LblProprietaire.Visible = false;
                TxtProprietaire.ResetText();
                TxtProprietaire.Visible = false;
            }
        }
        /// <summary>
        /// Methode qui met/enleve lerreur de lecran au niveau de la liste type
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void LstType_SelectedValueChanged(object sender, EventArgs e)
        {
            if (LstType.SelectedItems.Count > 2)
            {
                ErrGestion.SetError(LstType, "Min: 1 selection, Max: 2");
            }else
            {
                ErrGestion.SetError(LstType, "");
            }
        }
        /// <summary>
        /// Methode qui met/enleve lerreur de lecran lorsqu'on valide la form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnOk_Click(object sender, EventArgs e)
        {
            if (!Valider())
            {
                ReInitialiser();
                MessageBox.Show("Vous avez ajouter votre Pokemon!");
            }
        }
        /// <summary>
        /// Methode qui met le form a zero, a nouveau
        /// </summary>
        private void ReInitialiser()
        {
            LstGen.SelectedItems.Clear();
            LstType.SelectedItems.Clear();
            TxtNom.Clear();
            OptFemelle.Checked = false;
            OptMale.Checked = false;
            OptOui.Checked = false;
            OptNon.Checked = false;
            TxtProprietaire.Clear();
            TxtProprietaire.Visible = false;
            LblProprietaire.Visible = false;
            CboNumero.Value = 1;
            ErrGestion.Clear();
        }
        /// <summary>
        /// Methode qui met/enleve lerreur de lecran si on appuye sur le pokeball pour valider
        /// </summary>
        /// <returns></returns>
        private bool Valider()
        {
            bool Verifier = false;
            if(OptMale.Checked != true 
                && OptFemelle.Checked != true)
            {
                ErrGestion.SetError(PnlMaleFemelle, "Veuillez choisir le genre");
                Verifier = true;
            }
            if(TxtNom.Text.Length == 0)
            {
                ErrGestion.SetError(TxtNom, "Veuillez entrez un nom");
                Verifier = true;
            }
            if(LstGen.SelectedItems.Count == 0)
            {
                ErrGestion.SetError(LstGen, "Veuillez choisir la Generation");
                Verifier = true;
            }
            if(LstType.SelectedItems.Count == 0)
            {
                ErrGestion.SetError(LstType, "Veuillez choisir le type");
                Verifier = true;
            }
            if(OptOui.Checked != true
                && OptNon.Checked != true)
            {
                ErrGestion.SetError(PnlCapturer, "Veuillez choisir Oui/Non");
                Verifier = true;
            }
            if(OptOui.Checked == true 
                && TxtProprietaire.Text.Length == 0)
            {
                ErrGestion.SetError(TxtProprietaire, "Veuillez entrez " +
                    "le nom du proprietaire");
                Verifier = true;
            }
            return Verifier;
        }
        /// <summary>
        /// Methode qui met/enleve lerreur de lecran au niveau du nom saisie
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TxtNom_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(TxtNom.Text))
            {
                ErrGestion.SetError(TxtNom, "Le nom ne peut etre vide");
            }
            else
            {
                ErrGestion.SetError(TxtNom, "");
            }
        }
        /// <summary>
        /// Methode qui met/enleve lerreur de lecran si l'on passe par dessus le textbox nom 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TxtNom_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(TxtNom.Text))
            {
                ErrGestion.SetError(TxtNom, "Le nom ne peut etre vide");
            }
        }
        /// <summary>
        /// Methode qui met/enleve lerreur de lecran si le proprietaire es vide
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TxtProprietaire_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(TxtProprietaire.Text))
            {
                ErrGestion.SetError(TxtProprietaire, "Le nom du proprietaire ne peut etre vide");
            }
            else
            {
                ErrGestion.SetError(TxtProprietaire, "");
            }
        }
        /// <summary>
        /// Methode qui met/enleve lerreur de lecran au niveau du genre du pokemon
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OptFemelle_CheckedChanged(object sender, EventArgs e)
        {
            ErrGestion.SetError(PnlMaleFemelle, "");
        }
        /// <summary>
        /// Methode qui met/enleve lerreur de lecran au niveau du genre du pokemon
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OptMale_CheckedChanged(object sender, EventArgs e)
        {
            ErrGestion.SetError(PnlMaleFemelle, "");
        }
        /// <summary>
        /// Methode qui enleve lerreur de lecran au niveau de la generation du pokemon
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void LstGen_SelectedIndexChanged(object sender, EventArgs e)
        {
            ErrGestion.SetError(LstGen, "");
        }
        /// <summary>
        /// Methode qui remet l'ecran a zero/sans valeur comme au debut
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MnuNouveau_Click(object sender, EventArgs e)
        {
            ReInitialiser();
        }
    }
}
