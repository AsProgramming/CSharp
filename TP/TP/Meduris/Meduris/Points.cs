using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Meduris
{
    public class Points
    {
        private int Valeur;
        private int LaPosition;
        private PictureBox LaCase;

        public Points()
        {
            Valeur = 5;
        }
        /// <summary>
        /// Associe la case du jeu au point
        /// </summary>
        /// <param name="_position"></param>
        /// <param name="_associer"></param>
        public Points(int _position, PictureBox _associer)
        {
            LaPosition = _position;
            LaCase = _associer;
            Valeur = 5;
        }
        /// <summary>
        /// Le nombre de point
        /// </summary>
        public int NbPoints
        {
            get { return Valeur; }
            set { Valeur = value; }
        }
        /// <summary>
        /// La position de la case sur l'ecran
        /// </summary>
        public int Position
        {
            get { return LaPosition; }
            set { LaPosition = value; }
        }
        /// <summary>
        /// la case sur l'ecran
        /// </summary>
        public PictureBox CaseAssocier
        {
            get { return LaCase; }
            set { LaCase = value; }
        }
        /// <summary>
        /// Ajuste le nombre de points
        /// </summary>
        /// <param name="_valeur"></param>
        public void Ajuster(int _valeur)
        {
            if(NbPoints + _valeur >= 0)
            {
                Valeur += _valeur;
            }
        }
    }
}
