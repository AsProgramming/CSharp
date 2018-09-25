using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Meduris
{
    public class CaseJeu
    {
        private int LaPosition;
        private Couleur LaCouleur;
        private LaRessource[] CoutConstruction;
        private PictureBox LaCase;
        private bool estActif;
        private bool EstTemple;
        private int TailleColonie;

        public CaseJeu(int _position, PictureBox _associer)
        {
            CoutConstruction = new LaRessource[2];
            LaCase = _associer;
            LaPosition = _position;
            TailleColonie = 0;
        }

        public int Position
        {
            get { return LaPosition; }
            set { LaPosition = value; }
        }

        public bool Actif
        {
            get { return estActif; }
            set { estActif = value; }
        }

        public bool Temple
        {
            get { return EstTemple; }
            set { EstTemple = value; }
        }

        public int Taille
        {
            get { return TailleColonie; }
            set { TailleColonie = value; }
        }

        public PictureBox CaseAssocier()
        {
            return LaCase;
        }
        public LaRessource Cout
        {
            get { return CoutConstruction[0]; }
            set { CoutConstruction[0] = value; }
        }
        public LaRessource Cout2
        {
            get { return CoutConstruction[1]; }
            set { CoutConstruction[1] = value; }
        }

        public Couleur CouleurAssocier
        {
            get { return LaCouleur; }
            set { LaCouleur = value; }
        }
    }
}
