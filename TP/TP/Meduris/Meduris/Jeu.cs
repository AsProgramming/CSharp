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
    public partial class Jeu : Form
    {
        const string TrouverDruide = "PicDruide";
        
        const string TrouverOvrier = "PicOuvrier";

        const string TrouverHutte = "PicHutte";

        const string TrouverPts = "PicPoint";

        const string TrouverTemple = "PicTemple";

       // private Joueur test;

      //  private Points lesPoints;

       // private Joueur test1;

       // private Joueur test2;

        private Tour leJeu;

        private List<CaseJeu> CaseOuvrier;

        private List<CaseJeu> CaseJoueur;

        private List<CaseJeu> CaseDruide;

        private List<CaseJeu> CaseTemple;

        private List<CaseJeu> CaseEviter;

        private List<PictureBox> CasePoint;

        private SortedList<int, string> PierreRunique;

        private int Selection;

        private CaseJeu CaseRechercher;

        private Druide LeDruide;

        private De LeDe;

        private bool Bouger;

        private LaRessource[] RessourceOuvrier;

        private int[] PositionOuvrier;

        private int CptImage;

        private bool PremierTour;

        private int CptPremierTour;
        public Jeu(List<Joueur> _Lst)
        {
            InitializeComponent();
            PicTemple0.BackgroundImage = Meduris.Properties.Resources.druide_normal;



            //for (int i = 0; i < 3; i++)
            //{
            //    if (i == 0)
            //    {
            //        lesPoints = new Points();
            //        test = new Joueur("Jack", Couleur.Turquoise, lesPoints);
            //    }
            //    else if (i == 1)
            //    {
            //        lesPoints = new Points();
            //        test1 = new Joueur("Jackie", Couleur.Rouge, lesPoints);
            //    }
            //    else
            //    {
            //        lesPoints = new Points();
            //        test2 = new Joueur("Jacko", Couleur.Jaune, lesPoints);
            //    }

            //}
            //leJeu = new Tour(test, test1, test2);



            //////////////////
            leJeu = new Tour(_Lst);
            /////////////
            leJeu.Debut();
            MiseAJour(-1);

            LeDe = new De(BtnDe, LblChoix);
            //LaListeJoueurs.Show();


        }
        /// <summary>
        /// Ajoute les cases du Forme dans une liste 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="_ATrouver"></param>
        /// <param name="_fin"></param>
        /// <param name="_Lst"></param>
        private void AjoutCases(object sender, string _ATrouver, int _fin, List<CaseJeu> _Lst)
        {
            Control[] Trouver;
            for (int i = 0; i <= _fin; i++)
            {
                Trouver = this.Controls.Find(_ATrouver + i.ToString(), true);
                if (Trouver.Length > 0 && Trouver[0] is PictureBox && Trouver[0].Tag.ToString().Length > 2)
                {
                    string[] ajout = Trouver[0].Tag.ToString().Split(' ');
                    CaseRechercher = new CaseJeu(Int32.Parse(ajout[0]), (PictureBox)Trouver[0]);
                    CaseRechercher.Cout = Transformation(ajout[1]);
                    CaseRechercher.Cout2 = Transformation(ajout[2]);
                    _Lst.Add(CaseRechercher);
                }
                else if(Trouver.Length > 0 && Trouver[0] is PictureBox)
                {
                        CaseRechercher = new CaseJeu(i, (PictureBox)Trouver[0]);
                        _Lst.Add(CaseRechercher);
                }
            }
            
        }
        /// <summary>
        /// Verifie le choix de construction de hutte du joueur
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void VerificationHutte(object sender, EventArgs e)
        {
            int X = MousePosition.X;
            int Y = MousePosition.Y;

            Construction pop = new Construction(this);
            pop.Positioner(X, Y);
            pop.ShowDialog();

            PictureBox HutteJoueur = sender as PictureBox;
            string[] test = HutteJoueur.Tag.ToString().Split(' ');
            int Position = Int32.Parse(test[0]);

            if (CaseJoueur.ElementAt(Position).CaseAssocier().BackgroundImage == null
                && !leJeu.Courant().Construit)
            {
                if(Selection == 0)
                {
                    leJeu.Courant().Construire(Position, CaseJoueur, true);
                    MiseAJour(Position);
                }
                else
                {
                    leJeu.Courant().Construire(Position, CaseJoueur, false);
                    MiseAJour(-1);
                    ModifierPierre(Position);
                    CaseEviter.Add(CaseJoueur.ElementAt(Position));
                }
                if (!leJeu.Courant().Construit)
                {
                    leJeu.Courant().PasAssez = false;

                    BtnConstruire.Enabled = true;
                    Desactiver(CaseJoueur, false);
                    GrpExploiter.Visible = true;
                    GrpSuivant.Visible = false;
                }else
                {
                    BtnConstruire.Enabled = true;
                    Desactiver(CaseJoueur, true);
                    GrpExploiter.Visible = false;
                    GrpSuivant.Visible = true;
                }

            }

            if (LeDruide.NbConstruction < 3 && leJeu.Courant().Construit)
            {
                LeDruide.JoueurConstruit();
                LeDruide.DescendreTemple();
            }

            if (leJeu.Courant().ConstructionFinal())
            {
                LeDruide.AvantFinal = false;
                LeDruide.TourAvantFinal(Position, PierreRunique, CaseEviter);
                Desactiver(CaseOuvrier, true);
                Desactiver(CaseJoueur, true);
                GrActions.Visible = false;
                GrpSuivant.Visible = false;
                GrpExploiter.Visible = false;
                leJeu.FinPartie();
                quitterToolStripMenuItem_Click(this, null);
            }

        }

        /// <summary>
        /// Ferme L'application
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Jeu_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
        /// <summary>
        /// Allocation des ressources pour 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Jeu_Load(object sender, EventArgs e)
        {
            //Etait supposer de faire déplacer le jeton sur le tableau mais manque de temps
            //CasePoint = new List<PictureBox>();
            CaseOuvrier = new List<CaseJeu>();
            CaseDruide = new List<CaseJeu>();
            CaseTemple = new List<CaseJeu>();
            CaseJoueur = new List<CaseJeu>();
            AjoutCases(sender, TrouverOvrier, 11, CaseOuvrier);
            AjoutCases(sender, TrouverDruide, 31, CaseDruide);
            AjoutCases(sender, TrouverHutte, 31, CaseJoueur);
            AjoutCases(sender, TrouverTemple, 4, CaseTemple);
            LeDruide = new Druide(CaseTemple);
            LeDruide.CaseOffrande(CaseDruide);
            LeDruide.Correspondant(leJeu.LaListe());
            CaseEviter = new List<CaseJeu>();
            RessourceOuvrier = new LaRessource[2];
            PositionOuvrier = new int[2];
            PierreRunique = new SortedList<int, string>();
            for (int i = 1; i < 10; i++)
            {
                PierreRunique.Add(i, "");
            }

            PremierTour = true;
            Desactiver(CaseJoueur, true);

            MessageBox.Show("Pour commencez," + Environment.NewLine + 
                " Il faut placer à tour de rôle vos ouvriers au millieu dans la zone des ressources");
        }
        /// <summary>
        /// Timer pour changer l'image du de
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TmrImage_Tick(object sender, EventArgs e)
        {
            CptImage += 1;
                if(CptImage == 1)
                {
                LeDe.EnAttente(CptImage);
                }else if(CptImage == 2)
                {
                    LeDe.EnAttente(CptImage);
            }
            else if(CptImage == 3)
                {
                    LeDe.EnAttente(CptImage);
            }
            else if (CptImage == 4)
            {
                LeDe.EnAttente(CptImage);
            }
            else if (CptImage == 5)
            {
                LeDe.EnAttente(CptImage);
            }
            else
                {
                LeDe.Rouler();
                TmrImage.Stop();
                DistribuerRessource();
                CptImage = 0;
                }
        }

        /// <summary>
        /// Tranforme les tags en ressource
        /// </summary>
        /// <param name="_Verifier"></param>
        /// <returns></returns>
        public LaRessource Transformation(string _Verifier)
        {
            switch (_Verifier)
            {
                case "2":
                    return LaRessource.Laine;
                case "3":
                    return LaRessource.Cuivre;
                case "4":
                    return LaRessource.Roche;
                default:
                    return LaRessource.Bois;
            }
        }
        /// <summary>
        /// Verifier si le Joueur touche une des ressources 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void PnlJeu_Click(object sender, EventArgs e)
        {
            //diviser picbox par groupe de 3 dans la liste
            Panel CaseRessource = sender as Panel;
            if(CaseRessource.Tag != null)
            {
                string Positionner = CaseRessource.Tag.ToString();
                leJeu.Courant().AfficherOuvrier(Positionner, CaseOuvrier);
                if(PremierTour && leJeu.Courant().NbRessource(LaRessource.Ouvrier) == 0)
                {
                    GrpSuivant.Visible = true;
                }
                if(Bouger)
                {
                    TrouverOuvrier();
                    VerifierSequence();
                    Desactiver(CaseOuvrier, true);
                    GrpExploiter.Visible = false;
                    GrpSuivant.Visible = true;
                }
                MiseAJour(-1);
            }          
        }
        /// <summary>
        /// Classification des pierres lorsque le druide tra
        /// </summary>
        private void ClassifierPierre()
        {
            int[] nbPierre = new int[3];
            string[] Noms = new string[3];
            Noms = leJeu.LesNoms();


            for (int i = 0; i < PierreRunique.Count; i++)
            {
                if (PierreRunique.ElementAt(i).Value.Equals(Noms[0])){
                    nbPierre[0] += 1;
                }
                else if (PierreRunique.ElementAt(i).Value.Equals(Noms[1]))
                {
                    nbPierre[1] += 1;
                }
                else if (PierreRunique.ElementAt(i).Value.Equals(Noms[2]))
                {
                    nbPierre[2] += 1;
                }
            }
            for (int i = 0; i < 3; i++)
            {
                leJeu.DonnerLesPoints(i, nbPierre[i]);
            }

        }
        /// <summary>
        /// Veirifie si l'ouvrier clicker et le joueur sont les memes
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void PicOuvrier_Click(object sender, EventArgs e)
        {
            PictureBox Selection = sender as PictureBox;
            string[] Info = Selection.Tag.ToString().Split(' ');
            int Position = Int32.Parse(Info[0]);
            if(CaseOuvrier.ElementAt(Position).CaseAssocier().BackgroundImage != null
                && CaseOuvrier.ElementAt(Position).CouleurAssocier == leJeu.Courant().Couleur
                && CaseOuvrier.ElementAt(Position).Actif)
            {
                leJeu.Courant().PrendreOuvrier(Position, CaseOuvrier);
                Bouger = true;
            }

        }
        /// <summary>
        /// Desactive les panneau necessaire pour pas que le joueur continue a joueur
        /// </summary>
        /// <param name="_Lst"></param>
        /// <param name="_activer"></param>
        private void Desactiver(List<CaseJeu> _Lst, bool _activer)
        {
            for (int i = 0; i < _Lst.Count; i++)
            {
                if (_activer)
                {
                    _Lst.ElementAt(i).CaseAssocier().Enabled = false;
                }
                else
                {
                    _Lst.ElementAt(i).CaseAssocier().Enabled = true;
                }
            }
        }
        /// <summary>
        /// Mise a jour des informations du panel information du joueur
        /// </summary>
        /// <param name="_indice"></param>
        private void MiseAJour(int _indice)
        {
            if (_indice > -1)
            {
                LeDruide.AjouterHutte(_indice, CaseJoueur);
                ModifierPierre(_indice);
            }
            AjusterPnlHutte();
            LblNom.Text = leJeu.Courant().Nom;
            TxtQuantiteBois.Text = leJeu.Courant().NbRessource(LaRessource.Bois).ToString();
            TxtQuantiteCuivre.Text = leJeu.Courant().NbRessource(LaRessource.Cuivre).ToString();
            TxtQuantiteLaine.Text = leJeu.Courant().NbRessource(LaRessource.Laine).ToString();
            TxtQuantiteRoche.Text = leJeu.Courant().NbRessource(LaRessource.Roche).ToString();
            TxtQuantiteHutte.Text = leJeu.Courant().NbRessource(LaRessource.Hutte).ToString();
            TxtQuantiteTemple.Text = leJeu.Courant().NbRessource(LaRessource.Temple).ToString();
            TxtQuantiteOuvrier.Text = leJeu.Courant().NbRessource(LaRessource.Ouvrier).ToString();
            TxtQuantitePts.Text = leJeu.Courant().Points.NbPoints.ToString();
        }


        /// <summary>
        /// Modification dedes Pierres runique
        /// </summary>
        /// <param name="_indice"></param>
        private void ModifierPierre(int _indice)
        {
            if(_indice >= 0 && _indice < 5)
            {
                PierreRunique[1] = leJeu.Courant().Nom;
            }
            else if (_indice >= 5 && _indice < 8)
            {
                PierreRunique[2] = leJeu.Courant().Nom;
            }
            else if (_indice >= 8 && _indice < 12)
            {
                PierreRunique[3] = leJeu.Courant().Nom;
            }
            else if (_indice == 12 || _indice == 13)
            {
                PierreRunique[4] = leJeu.Courant().Nom;
            }
            else if (_indice >= 14 && _indice < 17)
            {
                PierreRunique[5] = leJeu.Courant().Nom;
            }
            else if (_indice >= 17 && _indice < 22)
            {
                PierreRunique[6] = leJeu.Courant().Nom;
            }
            else if (_indice >= 22 && _indice < 25)
            {
                PierreRunique[7] = leJeu.Courant().Nom;
            }
            else if (_indice >= 25 && _indice < 29)
            {
                PierreRunique[8] = leJeu.Courant().Nom;
            }
            else if (_indice >= 29 && _indice < 32)
            {
                PierreRunique[9] = leJeu.Courant().Nom;
            }
        }
        /// <summary>
        /// Verifie si les ouvrier sont dans le meme panel
        /// </summary>
        private void VerifierSequence()
        {
            if(RessourceOuvrier[0] == RessourceOuvrier[1])
            {
                VerifierPosition(PositionOuvrier[0]);
            }else
            {
                VerifierPosition(PositionOuvrier[0]);
                VerifierPosition(PositionOuvrier[1]);
            }
        }
        /// <summary>
        /// Verifie la position des ouvriers regarde l'ouvrier en position 0
        /// </summary>
        /// <param name="_indice"></param>
        private void VerifierPosition(int _indice) {
            int Valeur = 1;
            if (_indice  == 1 || _indice == 4 
                || _indice == 7 || _indice == 10)
            {
                _indice -= 1;

            }
            else if (_indice == 2 || _indice == 5 
                || _indice == 8 || _indice == 11)
            {
                _indice -= 2;
            }
            for (int i = _indice; i <= _indice + 2; i++)
            {
                if (CaseOuvrier.ElementAt(i).Actif)
                {
                    leJeu.CollecterRessource(CaseOuvrier.ElementAt(i).
                        CouleurAssocier, Valeur, CaseOuvrier.ElementAt(i).Cout2);
                }
                Valeur += 1;
            }
            MiseAJour(-1);
        }
        /// <summary>
        /// La selection que le joueur fait dans le popup 
        /// </summary>
        /// <param name="_indice"></param>
        public void SelectionConstruire(int _indice)
        {
            Selection = _indice;
        }

        public Couleur VerifierLaCouleur()
        {
            return leJeu.Courant().Couleur;
        }
        /// <summary>
        /// Trouve les ouvrier placer dans les ressources
        /// </summary>
        private void TrouverOuvrier()
        {
            int nbPosition = 0;
            foreach (CaseJeu c in CaseOuvrier)
            {
                if (c.Actif && c.CouleurAssocier == leJeu.Courant().Couleur)
                {
                    nbPosition += 1;
                    if (nbPosition == 1)
                    {
                        RessourceOuvrier[0] = c.Cout2; 
                        PositionOuvrier[0] = c.Position;
                    }
                    else
                    {

                        RessourceOuvrier[1] = c.Cout2;
                        PositionOuvrier[1] = c.Position;
                    }

                }
            }
        }
        /// <summary>
        /// Verifier ou les ressource doivent etre donner
        /// </summary>
        private void DistribuerRessource()
        {
            if(!string.IsNullOrWhiteSpace(LblChoix.Text))
            {
                switch (LblChoix.Text.ToString())
                {
                    case "Cuivre"://getnb on pannels
                        //6-8
                        DistruberPrecis(LaRessource.Cuivre, LeDe.ValeurDe, 6, 8);
                        break;
                    case "Roche":
                        //9-11
                        DistruberPrecis(LaRessource.Roche, LeDe.ValeurDe, 9, 11);
                        break;
                    case "Laine":
                        //3-5
                        DistruberPrecis(LaRessource.Laine, LeDe.ValeurDe, 3, 5);
                        break;
                    default:
                        //0-2
                        DistruberPrecis(LaRessource.Bois, LeDe.ValeurDe, 0, 2);
                        break;

                }
            }else
            {
                switch (LeDe.ValeurDe)
                {
                    case 2:
                        DistruberPrecis(LaRessource.Laine, 2, 3, 5);
                        break;
                    case 3:
                        DistruberPrecis(LaRessource.Cuivre, 3, 6, 8);
                        break;
                    case 4:
                        DistruberPrecis(LaRessource.Roche, 4, 9, 11);
                        break;
                    default:
                        DistruberPrecis(LaRessource.Bois, 1, 0, 2);
                        break;
                }
            }
        }
        /// <summary>
        /// Distribue les ressources on bon joueur
        /// </summary>
        /// <param name="_Ressource"></param>
        /// <param name="_Precision"></param>
        /// <param name="_Debut"></param>
        /// <param name="_Fin"></param>
        private void DistruberPrecis(LaRessource _Ressource, int _Precision, int _Debut, int _Fin)
        {
            int Endroit = 1;
            for (int i = _Debut; i <= _Fin; i++)
            {
                if (_Precision == 5 && CaseOuvrier.ElementAt(i).Actif)
                {
                    leJeu.CollecterRessource(CaseOuvrier.ElementAt(i).CouleurAssocier, -1, _Ressource);
                }
                else if(_Precision == 6 && CaseOuvrier.ElementAt(i).Actif)
                {
                    leJeu.CollecterRessource(CaseOuvrier.ElementAt(i).CouleurAssocier, 1, _Ressource);
                }else if (_Precision < 5 && CaseOuvrier.ElementAt(i).Actif)
                {
                    leJeu.CollecterRessource(CaseOuvrier.ElementAt(i).CouleurAssocier, Endroit, _Ressource);
                    Endroit += 1;
                }else
                {
                    break;
                }
            }

        }
        /// <summary>
        /// Quand on click sur le de
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnDe_Click(object sender, EventArgs e)
        {
            TmrImage.Start();
            GrpExploiter.Visible = true;
            MiseAJour(-1);
        }
        /// <summary>
        /// Quand on click le button Suivant
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnFin_Click(object sender, EventArgs e)
        {
            LblChoix.Text = "";
            if(CptPremierTour < 3)
            {
                CptPremierTour += 1;

            }

            if (!PremierTour)
            {
                LeDruide.VisiterHutte();
                GrActions.Visible = true;
                Desactiver(CaseJoueur, true);
                Desactiver(CaseOuvrier, true);
            }
            if (CptPremierTour == 3)
            {
                CptPremierTour = 4;
                PremierTour = false;
                GrActions.Visible = true;
            }

            if (LeDruide.TourComplet)
            {
                ClassifierPierre();
            }

            GrpSuivant.Visible = false;
            BtnExploiter.Enabled = true;
            BtnConstruire.Enabled = true;
            Bouger = false;
            leJeu.Courant().Construit = false;
            leJeu.Prochain();
            MiseAJour(-1);

        }
        /// <summary>
        /// Quand on click le button Exploiter
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnExploiter_Click(object sender, EventArgs e)
        {
            BtnConstruire.Enabled = false;
            Desactiver(CaseJoueur, true);
            Desactiver(CaseOuvrier, false);

            if (Bouger)
            {
                GrpSuivant.Visible = true;
            }

        }
        /// <summary>
        /// Quand on click le button Construire
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnConstruire_Click(object sender, EventArgs e)
        {
            BtnExploiter.Enabled = false;
            Desactiver(CaseOuvrier, true);
            Desactiver(CaseJoueur, false);
        }
        /// <summary>
        /// Affichage du programmeur
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void aProposToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Programmeur: Edwin Andino");
        }
        /// <summary>
        /// Quitte le Programme
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void quitterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        /// <summary>
        /// Ajuste les panneau pour chaque joueur quand on pese next
        /// </summary>
        private void AjusterPnlHutte()
        {
            switch (leJeu.Courant().Couleur)
            {
                case Couleur.Bleu:
                    PicHutteStatic.BackgroundImage = Meduris.Properties.Resources.hutte_bleu;
                    PicTempleStatic.BackgroundImage = Meduris.Properties.Resources.temple_bleu;
                    PicOuvrierStatic.BackgroundImage = Meduris.Properties.Resources.meeple_bleu;
                    break;
                case Couleur.Jaune:
                    PicHutteStatic.BackgroundImage = Meduris.Properties.Resources.hutte_jaune;
                    PicTempleStatic.BackgroundImage = Meduris.Properties.Resources.temple_jaune;
                    PicOuvrierStatic.BackgroundImage = Meduris.Properties.Resources.meeple_jaune;
                    break;
                case Couleur.Rouge:
                    PicHutteStatic.BackgroundImage = Meduris.Properties.Resources.hutte_rouge;
                    PicTempleStatic.BackgroundImage = Meduris.Properties.Resources.temple_rouge;
                    PicOuvrierStatic.BackgroundImage = Meduris.Properties.Resources.meeple_rouge;
                    break;
                case Couleur.Turquoise:
                    PicHutteStatic.BackgroundImage = Meduris.Properties.Resources.hutte_turquoise;
                    PicTempleStatic.BackgroundImage = Meduris.Properties.Resources.temple_turquoise;
                    PicOuvrierStatic.BackgroundImage = Meduris.Properties.Resources.meeple_turquoise;
                    break;
                case Couleur.Vert:
                    PicHutteStatic.BackgroundImage = Meduris.Properties.Resources.hutte_vert;
                    PicTempleStatic.BackgroundImage = Meduris.Properties.Resources.hutte_vert;
                    PicOuvrierStatic.BackgroundImage = Meduris.Properties.Resources.meeple_vert;
                    break;
                case Couleur.Violet:
                    PicHutteStatic.BackgroundImage = Meduris.Properties.Resources.hutte_violet;
                    PicTempleStatic.BackgroundImage = Meduris.Properties.Resources.temple_violet;
                    PicOuvrierStatic.BackgroundImage = Meduris.Properties.Resources.meeple_violet;
                    break;
            }

            BtnDe.BackgroundImage = Properties.Resources.questions;
        }
        /// <summary>
        /// Retroune le Joueur Courant pour desactiver les ressources
        /// </summary>
        /// <returns></returns>
        public Joueur Courant()
        {
            return leJeu.Courant();
        }
    }
    
}
