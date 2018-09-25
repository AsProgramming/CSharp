using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5
{
    class Chien
    {
        private Cases[,] Map;
        private Point Indice;
        private Random Alea;
        private bool Endormi;

        public Chien(Cases[,] _Map)
        {
            Map = _Map;
            Debut();
        }
        /// <summary>
        /// Methode qui gere de mettre le chien a coter de la porte 
        /// </summary>
        private void Debut()
        {
            Indice = new Point(0, 11);
            Map[Indice.X, Indice.Y].Photo = TilesetImageGenerator.GetTile((int)Sorte.CHIEN);
            Map[Indice.X, Indice.Y].Contient = Sorte.CHIEN;
            Alea = new Random();
            Endormi = false;
        }

        public Point Position
        {
            get { return Indice; }
            set { Indice = value; }
        }

        public bool Coucher
        {
            get { return Endormi; }
            set { Endormi = value; }
        }
        /// <summary>
        /// Methode qui gere le movement du chien
        /// </summary>
        /// <param name="_i"></param>
        public void Avancer(int _i)
        {
            int Numero = Piger();
            switch (Numero)
            {
                case 0:
                    Deplacer(Indice.X + 1, Indice.Y, _i);
                    break;
                case 1:
                    Deplacer(Indice.X, Indice.Y - 1, _i);
                    break;
                case 2:
                    Deplacer(Indice.X, Indice.Y + 1, _i);
                    break;
                case 3:
                    Deplacer(Indice.X - 1, Indice.Y, _i);
                    break;
            }
        }
        /// <summary>
        /// Methode qui gere de mettre la terre au bon endroit
        /// </summary>
        /// <param name="_x"></param>
        /// <param name="_y"></param>
        private void MettreTerre(int _x, int _y)
        {
            Map[_x, _y].Photo = TilesetImageGenerator.GetTile(TilesetImageGenerator.TERRE);
            Map[_x, _y].Destructible = false;
            Map[_x, _y].Contient = Sorte.TERRE;
        }
        /// <summary>
        /// Methode qui gere si la case et vide ou non
        /// </summary>
        /// <param name="_x"></param>
        /// <param name="_y"></param>
        /// <param name="_i"></param>
        private void Deplacer(int _x, int _y, int _i)
        {
            if (PositionValide(_x, _y) && !Map[_x, _y].Destructible)
            {
                AjusterImage(_x, _y, _i);
            }
            else
            {
                Avancer(_i);
            }
        }
        /// <summary>
        /// Methode qui gere de mettre la bonne photo
        /// </summary>
        /// <param name="_x"></param>
        /// <param name="_y"></param>
        /// <param name="_i"></param>
        private void AjusterImage(int _x, int _y, int _i)
        {
            MettreTerre(Indice.X, Indice.Y);
            Indice.X = _x;
            Indice.Y = _y;
            if(_i == 0)
            {
                Map[_x, _y].Photo = TilesetImageGenerator.GetTile((int)Sorte.CHIEN);
            }
            else
            {
                Map[_x, _y].Photo = TilesetImageGenerator.GetTile((int)Sorte.CHIEN2);
            }
            
            Map[_x, _y].Contient = Sorte.CHIEN;
        }
        /// <summary>
        /// Methode permet de voir si la case peut etre marcher dessus
        /// </summary>
        /// <param name="_x"></param>
        /// <param name="_y"></param>
        /// <returns></returns>
        private bool PositionValide(int _x, int _y)
        {
            return _x <= Map.GetUpperBound(0) && _y <= Map.GetUpperBound(1) && _x >= 0 && _y >= 0
                && !Map[_x, _y].Contient.Equals(Sorte.HERO) && !Map[_x, _y].Contient.Equals(Sorte.PUIT) && !Map[_x, _y].Contient.Equals(Sorte.PLANTE);
        }

        private int Piger()
        {
            return Alea.Next(4);
        }
        /// <summary>
        /// Methode qui gere de faire dormir le chien
        /// </summary>
        public void Dormir()
        {
            Endormi = true;
            MettreTerre(Indice.X, Indice.Y);
        }
        /// <summary>
        /// Methode qui gere le reveille du chien
        /// </summary>
        public void Reveiller()
        {
            if (Coucher)
            {
                Debut();
            }
        }

    }
}
