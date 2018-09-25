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
    public partial class Jardin : UserControl

    {
        [Description("Hauteur du dessin"), DefaultValue(16)]
        public int Hauteur
        {
            get;
            set;
        }
        [Description("Largeur du dessin"), DefaultValue(24)]
        public int Largeur
        {
            get;
            set;
        }

        private Random Alea;
        private Cases LaCase;
        private Cases[,] Map;
        private Joueur Hero;
        private Maison LaMaison;
        private bool PremiereFois;
        private bool Attendre;
        private int Indice;


        public Jardin() : this(24, 16)
        {
        }

        public Jardin(int LaLargeur, int LaHauteur)
        {
            DoubleBuffered = true;
            
            Hauteur = LaHauteur;
            Largeur = LaLargeur;
            PremiereFois = true;
            Alea = new Random();

            Map = new Cases[LaHauteur, LaLargeur];
            InitializeComponent();
            LaMaison = new Maison();
            LaMaison.Location = new Point(0, 0);
            LaMaison.Acces = this;
            this.Controls.Add(LaMaison);
        }

        public bool Arret
        {
            get { return Attendre; }
            set { Attendre = value; }
        }

        public Joueur LeJoueur
        {
            get { return Hero; }
        }
        /// <summary>
        /// Mthode qui se charge de retourner vrai si le joueur et devant la porte ou boite au lettre
        /// </summary>
        /// <returns></returns>
        public bool DevantMaison()
        {
            return Hero.Position.X == 0 && Hero.Position.Y == 12 || Hero.Position.X == 0 && Hero.Position.Y == 14;
        }
        /// <summary>
        /// Mthode qui se charge de mettre l'ecran en pause
        /// </summary>
        public void EnPause()
        {
            Attendre = true;
            Redessiner.Stop();
            LaMaison.Pause();
        }
        /// <summary>
        /// Mthode qui se charge de remttre en foction l'ecran
        /// </summary>
        public void FinPause()
        {
            Attendre = false;
            Redessiner.Start();
            LaMaison.FinPause();
        }
        /// <summary>
        /// Mthode qui se charge d'avancer le temps
        /// </summary>
        public void AvancerTemps()
        {
            Hero.PasserJourne();
            this.Refresh();
        }
        /// <summary>
        /// livre le paquet
        /// </summary>
        /// <param name="_p"></param>
        public void Livraison(Paquet _p)
        {
            _p.Livrer();
        }
        /// <summary>
        /// Mthode qui se charge de dessiner les cases
        /// </summary>
        /// <param name="e"></param>
        private void Tableau2d(PaintEventArgs e)
        {
            int Entree = (Largeur - 4) / 2;
            int PosX = 0;
            int PosY = 255;
            for (int i = 0; i < Hauteur; i++)
            {
                for (int j = 0; j < Largeur; j++)
                {
                    if (GenererCloture(i, j, Entree))
                    {
                        LaCase = new Cases(TilesetImageGenerator.GetTile(TilesetImageGenerator.CLOTURE), new Point(PosX, PosY), true);
                        Map[i, j] = LaCase;
                        Map[i, j].Indice[0] = i;
                        Map[i, j].Indice[1] = j;
                        Map[i, j].Contient = Sorte.CLOTURE;
                    }
                    else if(estEntree(i, j))
                    {
                        LaCase = new Cases(TilesetImageGenerator.GetTile(TilesetImageGenerator.TERRE), new Point(PosX, PosY), false);
                        Map[i, j] = LaCase;
                        Map[i, j].Indice[0] = i;
                        Map[i, j].Indice[1] = j;
                        Map[i, j].Contient = Sorte.TERRE;
                        Map[i, j].Entree = true;
                    }
                    else if (Puit(i, j))
                    {
                        LaCase = new Cases(BonneImage(i, j), new Point(PosX, PosY), false);
                        Map[i, j] = LaCase;
                        Map[i, j].Indice[0] = i;
                        Map[i, j].Indice[1] = j;
                        Map[i, j].Contient = Sorte.PUIT;
                    }
                    else if (Piger(Hauteur) == i && j != Entree + 1 && j != Entree + 2)
                    {
                        LaCase = new Cases(TilesetImageGenerator.GetTile(TilesetImageGenerator.BUISSON), new Point(PosX, PosY), true);
                        Map[i, j] = LaCase;
                        Map[i, j].Indice[0] = i;
                        Map[i, j].Indice[1] = j;
                        Map[i, j].Contient = Sorte.BUISSON;
                    }
                    else if (Piger(Largeur) == j && j != Entree + 1 && j != Entree + 2)
                    {
                        LaCase = new Cases(TilesetImageGenerator.GetTile(TilesetImageGenerator.ROCHE), new Point(PosX, PosY), true);
                        Map[i, j] = LaCase;
                        Map[i, j].Indice[0] = i;
                        Map[i, j].Indice[1] = j;
                        Map[i, j].Contient = Sorte.ROCHE;
                    }
                    else
                    {
                        LaCase = new Cases(TilesetImageGenerator.GetTile(TilesetImageGenerator.TERRE), new Point(PosX, PosY), false);
                        Map[i, j] = LaCase;
                        Map[i, j].Indice[0] = i;
                        Map[i, j].Indice[1] = j;
                        Map[i, j].Contient = Sorte.TERRE;
                    }
                    PosX += 32;
                }
                PosX = 0;
                PosY += 32;
            }

            GenererTuile(e);
        }
        /// <summary>
        /// Mthode qui se charge Paint le jardine pour la premiere fois ou non
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Jardin_Paint(object sender, PaintEventArgs e)
        {
            if (PremiereFois)
            {
                Tableau2d(e);
            }
            else
            {
                GenererTuile(e);
            }
        }
        private bool estEntree(int _x, int _y)
        {
            return (_x == 0 && _y == 12) || (_x == 0 && _y == 11) || (_x == 0 && _y == 14);
        }
        /// <summary>
        /// Mthode qui se charge de generer les cases aleatoire
        /// </summary>
        /// <param name="e"></param>
        private void GenererTuile(PaintEventArgs e)
        {
            if (PremiereFois)
            {
                Hero = new Joueur(Map);
                PremiereFois = false;
            }
            for (int i = 0; i < Hauteur; i++)
            {
                for (int j = 0; j < Largeur; j++)
                {
                    e.Graphics.DrawImage(Map[i, j].Photo, Map[i, j].Cardinalite);
                }
            }
        }
        /// <summary>
        /// Mthode qui se charge de verifier si la cloture doit etre
        /// </summary>
        /// <param name="i"></param>
        /// <param name="j"></param>
        /// <param name="Entree"></param>
        /// <returns></returns>
        private bool GenererCloture(int i, int j, int Entree)
        {
            
            if (i == 1 && j > 0 && j < Largeur - 1)
            {
                return (j != Entree + 1 && j != Entree + 2);
            }
            else if (i == Hauteur - 2 && j > 0 && j < Largeur - 1)
            {
                return true;
            }
            else if (i > 1 && i < Hauteur - 2 && (j == 1 || j == Largeur - 2))
            {
                return true;
            }
            return false;
        }
        /// <summary>
        /// Mthode qui se charge de voir le puit au bon endroit
        /// </summary>
        /// <param name="i"></param>
        /// <param name="j"></param>
        /// <returns></returns>
        private bool Puit(int i, int j)
        {
            return ((i == 2 || i == 3) && j > Largeur - 5 && j < Largeur - 2);
        }
        /// <summary>
        /// Mthode qui se charge de mettre la bonne image
        /// </summary>
        /// <param name="i"></param>
        /// <param name="j"></param>
        /// <returns></returns>
        private Bitmap BonneImage(int i, int j)
        {
            if (i == 2 && j == Largeur - 3)
            {
                return TilesetImageGenerator.GetTile((int)Sorte.PUIT2);
            }
            else if(i == 3 && j == Largeur - 4)
            {
                return TilesetImageGenerator.GetTile((int)Sorte.PUIT3);
            }
            else if(i == 3 && j == Largeur - 3)
            {
                return TilesetImageGenerator.GetTile((int)Sorte.PUIT4);
            }
            return TilesetImageGenerator.GetTile((int)Sorte.PUIT);
        }
        /// <summary>
        /// Mthode qui se charge de retourner un random number
        /// </summary>
        /// <param name="_indice"></param>
        /// <returns></returns>
        private int Piger(int _indice)
        {
            return Alea.Next(0, _indice);
        }
        /// <summary>
        /// Mthode qui se charge de mettre l'ecran a la bonne position
        /// </summary>
        /// <param name="_p"></param>
        /// <param name="_planter"></param>
        public void MontrerEcran(Point _p, bool _planter)
        {
            EnPause();
            if (_planter)
            {
                EcranPlanter Ecran = new EcranPlanter(this);
                Ecran.Location = new Point(340, 380);
                this.Controls.Add(Ecran);
            }
            else
            {
                ActionFleur Ecran = new ActionFleur(Hero, this);
                Ecran.Location = new Point(340, 400);
                this.Controls.Add(Ecran);
            }
        }
        /// <summary>
        /// Mthode qui se charge d'ajuster l'ecran pour qu'il soit visible
        /// </summary>
        /// <param name="_p"></param>
        /// <param name="planter"></param>
        /// <returns></returns>
        private Point BonEndroit(Point _p, bool planter)
        {
            if(_p.Y >= 300 && _p.Y < 430 && planter){
                _p.Y += 50;
            }
            else if (_p.X >= 700 && _p.Y >= 300 && _p.Y < 305)
            {
                _p.Y -= 200;
                _p.X -= 200;
                
            }else if(_p.X >= 700)
            {
                _p.X -= 150;
            }
            else if(_p.Y >= 300 && planter)
            {
                _p.Y -= 180;
            }
            else if (_p.Y >= 650 && !planter)
            {
                _p.Y -= 80;
            }
            return _p;
        }
        /// <summary>
        /// Mthode qui se charge de gerer les click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void Jardin_MouseClick(object sender, MouseEventArgs e)
        {
            if (!Attendre)
            {
                int Evaluer = Hero.VerifierClique(e.Location);
                if (Evaluer == 2)
                {

                    MontrerEcran(e.Location, true);
                }
                else if (Evaluer == 3)
                {
                    MontrerEcran(e.Location, false);
                }
                Refresh();
            }
        }
        /// <summary>
        /// Mthode qui se charge des keys pressed
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void Jardin_KeyDown(object sender, KeyEventArgs e)
        {
            if (!Attendre)
            {
                if (e.KeyData == Keys.W)
                {
                    Hero.Detecter(1);
                }
                if (e.KeyData == Keys.S)
                {
                    Hero.Detecter(2);
                }
                if (e.KeyData == Keys.A)
                {
                    Hero.Detecter(3);
                }
                if (e.KeyData == Keys.D)
                {
                    Hero.Detecter(4);
                }
                Refresh();
            }
        }
        /// <summary>
        /// Mthode qui se charge de faire bouger les images
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Redessiner_Tick(object sender, EventArgs e)
        {
            Indice += 1;
            if (Indice == 1)
            { 
                Map[Hero.Position.X, Hero.Position.Y].Photo = TilesetImageGenerator.GetTile((int)Sorte.HERO2);
            }
            else
            {
                Indice = 0;
                Map[Hero.Position.X, Hero.Position.Y].Photo = TilesetImageGenerator.GetTile((int)Sorte.HERO);
            }
            if (!Attendre)
            {
                Hero.AvancerChien(Indice);
            }
            Refresh();
        }
        /// <summary>
        /// Mthode qui se charge defaire dormir 
        /// </summary>
        public void Dormir()
        {
            Attendre = true;
            Redessiner.Stop();
            Hero.Dormir();
        }
        /// <summary>
        /// Mthode qui se charge de reveiller le hero
        /// </summary>
        public void Reveille()
        {
            if (Attendre)
            {
                Attendre = false;
                Redessiner.Start();
                Hero.Reveiller();
            }
        }
        /// <summary>
        /// Mthode qui se charge de finir la partie
        /// </summary>
        public void Fin(bool Afficher)
        {
            EnPause();
            if (Afficher)
            {
                Hero.Dormir();

                Fin Fini = new Fin(this, Afficher);
                Fini.Location = new Point(160,270);
                this.Controls.Add(Fini);
            }
            else
            {
                Fin Fini = new Fin(this, Afficher);
                Fini.Location = new Point(160, 270);
                this.Controls.Add(Fini);
            }
           // Application.Exit();
        }

        public void Recommencer()
        {
            PremiereFois = true;
            Alea = new Random();
            Attendre = false;
            Map = new Cases[Hauteur, Largeur];
            
            LaMaison.Recommencer();
            Refresh();
            Redessiner.Start();
            
        }
    }
}
