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
        [Description("Largeur du dessin"),DefaultValue(24)]
        public int Largeur
        {
            get;
            set;
        }
        private Random Alea;

        public Jardin() : this(24 , 16)
        {
        }

        public Jardin(int LaLargeur, int LaHauteur)
        {
            Alea = new Random();
            Hauteur = LaHauteur;
            Largeur = LaLargeur;

            InitializeComponent();
        }

        private void Jardin_Paint(object sender, PaintEventArgs e)
        {
            GenererTuile(e);
        }

        private void GenererTuile(PaintEventArgs e)
        {
            int Entree = (Largeur - 4) / 2;
            int PosX = 0;
            int PosY = 0;
            for (int i = 0; i < Hauteur; i++)
            {
                for (int j = 0; j < Largeur; j++)
                {
                    if (GenererCloture(i, j, Entree))
                    {
                        e.Graphics.DrawImage(TilesetImageGenerator.GetTile(1), new Point(PosX, PosY));
                    }
                    else if (Piger(Hauteur) == i && j != Entree + 1 && j != Entree + 2)
                    {
                        e.Graphics.DrawImage(TilesetImageGenerator.GetTile(2), new Point(PosX, PosY));
                    }
                    else if (Piger(Largeur) == j && j != Entree + 1 && j != Entree + 2)
                    {
                        e.Graphics.DrawImage(TilesetImageGenerator.GetTile(3), new Point(PosX, PosY));
                    }
                    else
                    {
                        e.Graphics.DrawImage(TilesetImageGenerator.GetTile(0), new Point(PosX, PosY));
                    }
                    PosX += 32;
                }
                PosX = 0;
                PosY += 32;
            }


        }

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

        private int Piger(int _indice)
        {
            return Alea.Next(0, _indice);
        }
    }
}
