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
    public partial class FrmNoms : Form
    {
        private string[] Noms;
        private string[] Indice;
        private int CptJoueur;
        private bool Cliquer;
        private Joueur LeJoueur;
        private List<Joueur> LstJoueur;
        private CheckBox Ouvrier;
        private List<CheckBox> LesCouleurs;
        private Points LesPoints;
        private Couleur LaCouleur;
        public FrmNoms()
        {
            CptJoueur = 0;
            InitializeComponent();
            Noms = new string[3];
            LstJoueur = new List<Joueur>();
            LesCouleurs = new List<CheckBox>();
            AjoutCases(this);
        }
        /// <summary>
        /// Fait la liste et la verification des joueurs et le passe au jeu
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonOk_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(TxtNom.Text) && Cliquer)
            {
                LesPoints = new Points();
                LeJoueur = new Joueur(TxtNom.Text, LaCouleur, LesPoints);
                LstJoueur.Add(LeJoueur);
                Noms[CptJoueur] = TxtNom.Text.ToString();
                RemettreVide();
            }
            else if(Cliquer && string.IsNullOrWhiteSpace(TxtNom.Text))
            {
                ErrNom.SetError(TxtNom, "Entrez un nom");
            }
            else if (!Cliquer && !string.IsNullOrWhiteSpace(TxtNom.Text))
            {
                ErrNom.SetError(PnlCouleur, "Choix de couleur obligatoire");
            }
            else
            {
                ErrNom.SetError(TxtNom, "Entrez votre nom");
                ErrNom.SetError(PnlCouleur, "Choix de couleur obligatoire");
            }

            if(CptJoueur == 3)
            {
                Jeu LeJeu = new Jeu(LstJoueur);
                this.Visible = false;
                LeJeu.Show();
            }
        }
        /// <summary>
        /// Verifie la couleur choisi
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ChkCouleurs_Click(object sender, EventArgs e)
        {
                CheckBox Photo = sender as CheckBox;
                string LeChoix = Photo.Tag.ToString();
                LaCouleur = TrouverCouleur(LeChoix);
                Cliquer = true;
        }
        /// <summary>
        /// Change le string en couleur
        /// </summary>
        /// <param name="_Indice"></param>
        /// <returns></returns>
        private Couleur TrouverCouleur(string _Indice)
        {
            switch (_Indice)
            {
                case "1":
                    return Couleur.Rouge;

                case "2":
                    return Couleur.Bleu;

                case "3":
                    return Couleur.Vert;

                case "4":
                    return Couleur.Jaune;

                case "5":
                    return Couleur.Violet;
                default:
                    return Couleur.Turquoise;
            }
        }
        /// <summary>
        /// Quand le button annuler et cliquer
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnAnnuler_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void AjoutCases(object sender)
        {
            Control[] Trouver;
            for (int i = 0; i <= 6; i++)
            {
                Trouver = this.Controls.Find("ChkCouleur" + i.ToString(), true);
                if (Trouver.Length > 0 && Trouver[0] is CheckBox)
                {
                    string ajout = Trouver[0].Tag.ToString();
                    LesCouleurs.Add((CheckBox)Trouver[0]);
                }
            }
        }
        /// <summary>
        /// Desactive la bonne couleur choisi
        /// </summary>
        private void Desactiver()
        {
            if(CptJoueur > 0)
            {
                foreach (CheckBox c in LesCouleurs)
                {
                    if (LstJoueur.Count == 1
                        && LstJoueur.ElementAt(0).Couleur == TrouverCouleur(c.Tag.ToString()))
                    {
                        c.Enabled = false;
                    }else if(LstJoueur.Count == 2 
                        && LstJoueur.ElementAt(1).Couleur == TrouverCouleur(c.Tag.ToString()))
                    {
                        c.Enabled = false;
                    }
                }
            }
        }
        /// <summary>
        /// Remet les options a vide pour nouvelle entrer
        /// </summary>
        private void RemettreVide()
        {
            CptJoueur += 1;
            TxtNom.Clear();
            Cliquer = false;
            Desactiver();
            CptJoueur += 1;
            GrNoms.Text = "Joueur " + CptJoueur;
            ErrNom.SetError(TxtNom, "");
            ErrNom.SetError(PnlCouleur, "");
            CptJoueur -= 1;
        }
    }
}
