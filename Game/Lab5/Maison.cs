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
    public partial class Maison : UserControl
    {
        private Point Dessiner;
        private Jardin LeJardin;
        private bool Jour;
        private bool DormiTot;
        private int NbJours;
        private int Heure;
        private int NbDormi;
        private List<Paquet> LesCommandes;
        private bool Commander;

        public Maison()
        {
            this.DoubleBuffered = true;
            LesCommandes = new List<Paquet>();
            NbDormi = 48;
            NbJours = 1;
            Heure = 7;
            Jour = true;
            Dessiner = new Point(-60, 200);
            InitializeComponent();
            LblHrs.ForeColor = Color.White;
            LblJours.ForeColor = Color.White;
            
        }

        public Jardin Acces
        {
            get { return LeJardin; }
            set { LeJardin = value; }
        }

        public int ADormi
        {
            get { return NbDormi; }
            set { NbDormi = value; }
        }

        public int Heures
        {
            get { return Heure; }
            set { Heure = value; }
        }

        public bool PasserCommande
        {
            get { return Commander; }
            set { Commander = value; }
        }

        public bool LeJour
        {
            get { return Jour; }
            set { Jour = value; }
        }

        public int NbEcouler
        {
            get { return NbJours; }
            set { NbJours = value; }
        }

        public bool CoucherTot
        {
            get { return DormiTot; }
            set { DormiTot = value; }
        }

        public bool PlusieursCommande()
        {
            return LesCommandes.Count > 1;
        }
        

        public void Pause()
        {
            TmrJour.Stop();
            TmrHr.Stop();
        }

        public void FinPause()
        {
            TmrJour.Start();
            TmrHr.Start();
        }

        public void AjouterCommande(Paquet _c)
        {
            LesCommandes.Add(_c);
        }

        /// <summary>
        ///  Methode qui dessine le haut du programme
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Maison_Paint(object sender, PaintEventArgs e)
        {
            if (Jour)
            {
                e.Graphics.DrawImage(Properties.Resources.soleil, Dessiner);
            }
            else
            {
                e.Graphics.DrawImage(Properties.Resources.lune, Dessiner);
            }

            e.Graphics.DrawImage(TilesetImageGenerator.GetTile((int)Sorte.CHEMINER), 352, 80);
            e.Graphics.DrawImage(TilesetImageGenerator.GetTile((int)Sorte.MAISON), 320, 95);
            e.Graphics.DrawImage(Lab5.Properties.Resources.boitelettres, 448, 188);
        }
        /// <summary>
        ///  Methode qui se charge de gerer le mouse click de la maison ou de la boite au lettre 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Maison_MouseClick(object sender, MouseEventArgs e)
        {
            if (!LeJardin.Arret)
            {
                if (LeJardin.DevantMaison() && e.X >= 387 && e.X <= 415 && e.Y >= 207 && e.Y <= 251)
                {
                    //maison
                    LeJardin.EnPause();
                    Menu m = new Menu(this);
                    m.Location = new Point(155, 300);
                    LeJardin.Controls.Add(m);
                }
                else if (LeJardin.DevantMaison() && e.X >= 452 && e.X <= 468 && e.Y >= 192 && e.Y <= 218)
                {
                    if (Commander) // not nuit avec heures
                    {
                        LivrerBonPaquet();
                    }else if (!Commander)
                    {
                        MessageBox.Show("Vous n'avez pas fait de commande");
                    }
                }
                else
                {
                    LeJardin.Jardin_MouseClick(this, e);
                }
            }
        }

        private void LivrerBonPaquet()
        {
            bool modifier = false;
            int NbModifier = LesCommandes.Count;
            for (int i = 0; i < LesCommandes.Count; i++)
            {
                if(LesCommandes.ElementAt(i).EnAttente <= 0)
                {
                    LesCommandes.ElementAt(i).Livrer();
                    modifier = true;
                }
            }
            EnleverBonneCommande(modifier, NbModifier);
        }

        private void EnleverBonneCommande(bool enlever, int TotalDebut)
        {
            if (enlever)
            {
                bool modifier = false;
                for (int i = 0; i < TotalDebut; i++)
                {
                    if (modifier)
                    {
                        i = 0;
                    }
                    if (!LesCommandes.ElementAt(i).EnTransit)
                    {
                        modifier = true;
                        LesCommandes.RemoveAt(0);
                    }
                    else
                    {
                        break;
                    }
                }
                if (enlever && LesCommandes.Count > 0)
                {
                    MessageBox.Show("Votre commande a ete livrer, mais les autres seront livrer le prochain jour");
                }
                else
                {
                    MessageBox.Show("Votre commande a ete livrer");
                }
            }
            else
            {
                MessageBox.Show("Votre commande est en route");
            }
        }

        private void AjusterCount(int i, List<Paquet> lesCommandes)
        {
            if(i == 0)
            {
                
            }
            else
            {
                LesCommandes.RemoveAt(i - 1);
            }
        }

        /// <summary>
        ///  Methode qui se charge de faire avancer le soleil/lune
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TmrJour_Tick(object sender, EventArgs e)
        {
                Dessiner.X += 5;
                if (Dessiner.X <= 140)
                {
                    Dessiner.Y -= 5;
                }
                else if (Dessiner.X > 140 && Dessiner.X <= 475)
                {
                if (!Jour)
                {
                    Dessiner.X += 5;
                }
                    Dessiner.X += 2;

                }
                else if (Dessiner.X > 550)
                {
                    Dessiner.Y += 5;
                FaireTransition();
                
                if (Dessiner.Y >= 250)
                    {
                        Dessiner.X = -60;
                        Dessiner.Y = 200;
                        if (Jour)
                        {
                            BackColor = Color.Black;
                        
                        Jour = false;
                        }
                        else
                        {
                            NbJours += 1;
                        NbDormi -= 24;
                        LblJours.Text = "Jour "+NbJours.ToString();
                        LivraisonArriver();
                            BackColor = Color.DodgerBlue;
                            LeJardin.AvancerTemps();
                            Jour = true;
                            if (PasDomir())
                            {
                           // Pause();
                            LeJardin.Fin(true);
                            }
                        }
                    TmrJour.Interval = 180;
                    TmrHr.Interval = 1900;
                }
                }
                Refresh();

        }

        private void LivraisonArriver()
        {
            if (Commander)
            {
                for (int i = 0; i < LesCommandes.Count; i++)
                {
                    LesCommandes.ElementAt(i).EnAttente -= 1;
                }
            }
        }

        /// <summary>
        /// Methode qui se charge de fair la transition entre le jour/nuit
        /// </summary>
        private void FaireTransition()
        {
            if(Dessiner.Y >= 100)
            {
                if (!Jour)
                {
                    TmrJour.Interval = 75;
                    TmrHr.Interval = 2100;
                }
                else
                {
                    TmrJour.Interval = 90;
                    
                } 
            }
            
            if (Dessiner.Y >= 180 && Dessiner.Y < 190)
            {
                if (Jour)
                {
                    BackColor = Color.CornflowerBlue;
                }
                else
                {
                    BackColor = Color.MidnightBlue;
                }
            }
            else if (Dessiner.Y >= 190 && Dessiner.Y < 200)
            {
                if (Jour)
                {
                    BackColor = Color.RoyalBlue;
                }
                else
                {
                    BackColor = Color.Navy;
                }
                
            }
            else if (Dessiner.Y >= 200 && Dessiner.Y < 210)
            {
                if (Jour)
                {
                    BackColor = Color.MediumBlue;
                }
                else
                {
                    BackColor = Color.DarkBlue;
                }
                
            }
            else if (Dessiner.Y >= 210 && Dessiner.Y < 220)
            {
                if (Jour)
                {
                    BackColor = Color.DarkBlue;
                }
                else
                {
                    BackColor = Color.MediumBlue;
                }
                
            }
            else if ( Dessiner.Y >= 220 && Dessiner.Y < 230)
            {
                if (Jour)
                {
                    BackColor = Color.Navy;
                }
                else
                {
                    BackColor = Color.RoyalBlue;
                }
                
            }
            else if (Dessiner.Y >= 230 && Dessiner.Y < 240)
            {
                if (Jour)
                {
                    BackColor = Color.MidnightBlue;
                }
                else
                {
                    BackColor = Color.CornflowerBlue;
                }
                
            }
           
        }

        private void Maison_KeyDown(object sender, KeyEventArgs e)
        {
            LeJardin.Jardin_KeyDown(this, e);
        }

        private bool PasDomir()
        {
           return NbDormi == 0;
        }

        public bool PeutDormir()
        {
            return NbDormi == 24;
        }
        /// <summary>
        ///  Methode qui se charge de fair avancer l'heure
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TmrHr_Tick(object sender, EventArgs e)
        {
            Heure += 1;
            if (Heure == 24)
            {
                Heure = 0;
                LblHrs.Text = Heure.ToString()+":00";
                LblHrs.ForeColor = Color.White;
            }
            else
            {
                LblHrs.Text = Heure.ToString() + ":00";
            }
            if(DormiTot && Heure == 7)
            {
                LeJardin.Reveille();
            }
            else if(Heure == 12)
            {
                LeJardin.Reveille();
            }
        }

        public void Recommencer()
        {
            NbDormi = 48;
            NbJours = 1;
            Heure = 7;
            Jour = true;
            Dessiner = new Point(-60, 200);
            LesCommandes.Clear();
            FinPause();
            DormiTot = false;
            NbDormi = 0;
            Commander = false;
            LblJours.Text = "Jour " + NbJours.ToString();
            LblHrs.Text = Heure.ToString() + ":00";
        }
    }
}
