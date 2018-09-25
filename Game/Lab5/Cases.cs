using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5
{
    public class Cases
    {
        private Bitmap Image;
        private Point Coord;
        private int[] IndiceTab;
        private bool PeutBouger;
        private bool Devant;
        private Sorte Contenu;
        private Plant Semance;

        public Cases(Bitmap img, Point p, bool modifiable)
        {
            IndiceTab = new int[2];
            Image = img;
            PeutBouger = modifiable;
            Coord = p;
        }

        public Cases(Point p, bool modifiable)
        {
            IndiceTab = new int[2];
            PeutBouger = modifiable;
            Coord = p;
        }

        public Cases()
        {
            IndiceTab = new int[2];
        }

        public Point Cardinalite
        {
            get { return Coord; }
            set { Coord = value; }
        }
        public int[] Indice
        {
            get { return IndiceTab; }
            set { IndiceTab = value; }
        }

        public bool Entree
        {
            get { return Devant; }
            set { Devant = value; }
        }

        public bool Destructible
        {
            get { return PeutBouger; }
            set { PeutBouger = value; }
        }

        public Sorte Contient
        {
            get { return Contenu; }
            set { Contenu = value; }
        }

        public Bitmap Photo
        {
            set { Image = value; }
            get { return Image; }
        }

        public Plant LaPlante
        {
            get { return Semance; }
            set { Semance = value; }
        }
    }
}
