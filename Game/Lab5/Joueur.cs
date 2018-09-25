using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab5
{
    public class Joueur
    {
        private Cases[,] Map;
        private List<Cases> LstAdjacent;
        private List<Cases> LstArroser;
        private Inventaire Stock;
        private List<Cases> LstPlante;
        private Point Precedent;
        private Point LeCase;
        private Chien Chico;
        private Plant LaPlante;
        private bool Endormi;

        public Joueur(Cases[,] _Map)
        {
            Map = _Map;
            Stock = new Inventaire();
            Chico = new Chien(Map);
            LstArroser = new List<Cases>();
            LstAdjacent = new List<Cases>();
            LstPlante = new List<Cases>();
            Debut();
        }

        public void AjouterCases(Cases c)
        {
            LstAdjacent.Add(c);
        }

        public List<Cases> PtAdjacent
        {
            get { return LstAdjacent; }
            set { LstAdjacent = value; }
        }

        public Point Position
        {
            get { return Precedent; }
            set { Precedent = value; }
        }

        public Point CaseChoisie
        {
            get { return LeCase; }
            set { LeCase = value; }
        }

        public Inventaire Disponible
        {
            get { return Stock; }
            set { Stock = value; }
        }

        public bool Dort
        {
            get { return Endormi; }
            set { Endormi = value; }
        }

        /// <summary>
        /// Mthode qui se charge de remttre le joueur au bon endroit au depart
        /// </summary>
        private void Debut()
        {
            Precedent = new Point(0, 12);
            Map[Precedent.X, Precedent.Y].Photo = TilesetImageGenerator.GetTile((int)Sorte.HERO);
            Map[Precedent.X, Precedent.Y].Contient = Sorte.HERO;
            AjusterPts(1, LstAdjacent);
            Endormi = false;
        }
        /// <summary>
        /// Mthode qui se charge de detecter ou est le click
        /// </summary>
        /// <param name="_indice"></param>
        public void Detecter(int _indice)
        {
            switch (_indice)
            {
                case 1:
                    Deplacer(Precedent.X - 1, Precedent.Y);
                    break;
                case 2:
                    Deplacer(Precedent.X + 1, Precedent.Y);
                    break;
                case 3:
                    Deplacer(Precedent.X, Precedent.Y - 1);
                    break;
                case 4:
                    Deplacer(Precedent.X, Precedent.Y + 1);
                    break;
            }
        }
        /// <summary>
        /// Mthode qui se charge de verifier si le joueur peu se depalcer
        /// </summary>
        /// <param name="_x"></param>
        /// <param name="_y"></param>
        private void Deplacer(int _x, int _y)
        {
            if (PositionValide(_x, _y) && !Map[_x, _y].Destructible)
            {
                AjusterImage(_x, _y);
            }
        }
        /// <summary>
        /// Mthode qui se charge de mettre la bonne photo
        /// </summary>
        /// <param name="_x"></param>
        /// <param name="_y"></param>
        private void AjusterImage(int _x, int _y)
        {
            if (LstAdjacent.Count != 0)
            {
                LstAdjacent.Clear();
                LstArroser.Clear();
            }
            MettreTerre(Precedent.X, Precedent.Y);
            Precedent.X = _x;
            Precedent.Y = _y;
            Map[_x, _y].Photo = TilesetImageGenerator.GetTile((int)Sorte.HERO);
            Map[_x, _y].Contient = Sorte.HERO;
            AjusterPts(1, LstAdjacent);
            AjusterPts(1, LstArroser);
            AjusterPts(2, LstArroser);
        }
        /// <summary>
        /// Mthode qui se charge de mettre la terre
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
        /// Mthode qui se charge de mettre les points dans la liste
        /// </summary>
        public void AjusterLstPts()
        {
            if (LstAdjacent.Count != 0)
            {
                LstAdjacent.Clear();
            }
            AjusterPts(1, LstAdjacent);
        }
        /// <summary>
        /// Mthode qui se charge d'ajuster les points de deplacement valide
        /// </summary>
        /// <param name="_indice"></param>
        /// <param name="_Lst"></param>
        private void AjusterPts(int _indice, List<Cases> _Lst)
        {
            if (PositionValide(Precedent.X + _indice, Precedent.Y)) //ENAVANT
            {
                _Lst.Add(Map[Precedent.X + _indice, Precedent.Y]);
            }
            if (PositionValide(Precedent.X + _indice, Precedent.Y + _indice))// AVDROITE
            {
                _Lst.Add(Map[Precedent.X + _indice, Precedent.Y + _indice]);
            }
            if (PositionValide(Precedent.X + _indice, Precedent.Y - _indice)) //AVGAUCH
            {
                _Lst.Add(Map[Precedent.X + _indice, Precedent.Y - _indice]);
            }
            if (PositionValide(Precedent.X, Precedent.Y - _indice))  //GAUCHE
            {
                _Lst.Add(Map[Precedent.X, Precedent.Y - _indice]);
            }
            if (PositionValide(Precedent.X, Precedent.Y + _indice)) //DROITE
            {
                _Lst.Add(Map[Precedent.X, Precedent.Y + _indice]);
            }
            if (PositionValide(Precedent.X - _indice, Precedent.Y)) //AR
            {
                _Lst.Add(Map[Precedent.X - _indice, Precedent.Y]);
            }
            if (PositionValide(Precedent.X - _indice, Precedent.Y - _indice)) //ARGAUC
            {
                _Lst.Add(Map[Precedent.X - _indice, Precedent.Y - _indice]);
            }
            if (PositionValide(Precedent.X - _indice, Precedent.Y + _indice)) //ARDR
            {
                _Lst.Add(Map[Precedent.X - _indice, Precedent.Y + _indice]);
            }

        }
        /// <summary>
        /// Mthode qui se charge de verifier si la case est bonne
        /// </summary>
        /// <param name="_x"></param>
        /// <param name="_y"></param>
        /// <returns></returns>
        private bool PositionValide(int _x, int _y)
        {
            return _x <= Map.GetUpperBound(0) && _y <= Map.GetUpperBound(1)
                && _x >= 0 && _y >= 0 && !Map[_x, _y].Contient.Equals(Sorte.CHIEN)
                && !Map[_x, _y].Contient.Equals(Sorte.PUIT);
        }
        /// <summary>
        /// Mthode qui se charge de verifier le clique est faire l'action disponible
        /// </summary>
        /// <param name="_p"></param>
        /// <returns></returns>
        public int VerifierClique(Point _p)
        {
            for (int i = 0; i < LstAdjacent.Count; i++)
            {
                if (Contient(_p, LstAdjacent.ElementAt(i)) && (LstAdjacent.ElementAt(i).Contient.Equals(Sorte.ROCHE)
                    || LstAdjacent.ElementAt(i).Contient.Equals(Sorte.CLOTURE) || LstAdjacent.ElementAt(i).Contient.Equals(Sorte.BUISSON)))
                {
                    MettreTerre(LstAdjacent.ElementAt(i).Indice[0], LstAdjacent.ElementAt(i).Indice[1]);
                    AjusterLstPts();
                }
                else if (Contient(_p, LstAdjacent.ElementAt(i)) && LstAdjacent.ElementAt(i).Contient.Equals(Sorte.TERRE) && !LstAdjacent.ElementAt(i).Entree)
                {
                    LeCase = new Point(LstAdjacent.ElementAt(i).Indice[0], LstAdjacent.ElementAt(i).Indice[1]);
                    return 2;
                }
                else if (Contient(_p, LstAdjacent.ElementAt(i)) && LstAdjacent.ElementAt(i).Contient.Equals(Sorte.PLANTE))
                {
                    LeCase = new Point(LstAdjacent.ElementAt(i).Indice[0], LstAdjacent.ElementAt(i).Indice[1]);
                    return 3;
                }
            }
            return 0;
        }
        /// <summary>
        /// Mthode qui se charge de verifier si contient dans la lsite
        /// </summary>
        /// <param name="_p"></param>
        /// <param name="_c"></param>
        /// <returns></returns>
        private bool Contient(Point _p, Cases _c)
        {
            return (_p.X >= _c.Cardinalite.X && _p.X <= _c.Cardinalite.X + 32
                && _p.Y >= _c.Cardinalite.Y && _p.Y <= _c.Cardinalite.Y + 32);
        }
        /// <summary>
        /// Mthode qui se charge de deplacer le chien
        /// </summary>
        /// <param name="_i"></param>
        public void AvancerChien(int _i)
        {
            Chico.Avancer(_i);
            AjusterLstPts();
        }
        /// <summary>
        /// Mthode qui se charge creer la pnate dans la case
        /// </summary>
        /// <param name="_i"></param>
        public void CreerPlante(int _i)
        {
            switch (_i)
            {
                case 1:
                    Map[LeCase.X, LeCase.Y].Photo = TilesetImageGenerator.GetTile((int)Sorte.BLEGERME);
                    Map[LeCase.X, LeCase.Y].Contient = Sorte.PLANTE;
                    Map[LeCase.X, LeCase.Y].Destructible = true;
                    LaPlante = new Plant(Sorte.BLE);
                    Map[LeCase.X, LeCase.Y].LaPlante = LaPlante;
                    break;
                case 2:
                    Map[LeCase.X, LeCase.Y].Photo = TilesetImageGenerator.GetTile((int)Sorte.CARROTGERME);
                    Map[LeCase.X, LeCase.Y].Contient = Sorte.PLANTE;
                    Map[LeCase.X, LeCase.Y].Destructible = true;
                    LaPlante = new Plant(Sorte.CARROT);
                    Map[LeCase.X, LeCase.Y].LaPlante = LaPlante;
                    break;
                case 3:
                    Map[LeCase.X, LeCase.Y].Photo = TilesetImageGenerator.GetTile((int)Sorte.OIGNONGERME);
                    Map[LeCase.X, LeCase.Y].Contient = Sorte.PLANTE;
                    Map[LeCase.X, LeCase.Y].Destructible = true;
                    LaPlante = new Plant(Sorte.OIGNON);
                    Map[LeCase.X, LeCase.Y].LaPlante = LaPlante;
                    break;
                case 4:
                    Map[LeCase.X, LeCase.Y].Photo = TilesetImageGenerator.GetTile((int)Sorte.TOMATEGERME);
                    Map[LeCase.X, LeCase.Y].Contient = Sorte.PLANTE;
                    Map[LeCase.X, LeCase.Y].Destructible = true;
                    LaPlante = new Plant(Sorte.TOMATE);
                    Map[LeCase.X, LeCase.Y].LaPlante = LaPlante;
                    break;
                case 5:
                    Map[LeCase.X, LeCase.Y].Photo = TilesetImageGenerator.GetTile((int)Sorte.TULIPGERME);
                    Map[LeCase.X, LeCase.Y].Contient = Sorte.PLANTE;
                    Map[LeCase.X, LeCase.Y].Destructible = true;
                    LaPlante = new Plant(Sorte.TULIPE);
                    Map[LeCase.X, LeCase.Y].LaPlante = LaPlante;
                    break;
                case 6:
                    Map[LeCase.X, LeCase.Y].Photo = TilesetImageGenerator.GetTile(TilesetImageGenerator.CLOTURE);
                    Map[LeCase.X, LeCase.Y].Contient = Sorte.CLOTURE;
                    Map[LeCase.X, LeCase.Y].Destructible = true;
                    break;
                case 7:
                    Deplanter();
                    MettreTerre(LeCase.X, LeCase.Y);
                    break;
                default:
                    CeuillirPlante();
                    break;
            }
            if (Map[LeCase.X, LeCase.Y].Contient != Sorte.TERRE
                && Map[LeCase.X, LeCase.Y].Contient != Sorte.CLOTURE)
            {
                LstPlante.Add(Map[LeCase.X, LeCase.Y]);
            }
        }

        private void Deplanter()
        {
            for (int i = 0; i < LstPlante.Count; i++)
            {
                if (LstPlante.ElementAt(i).Indice[0] == LeCase.X
                    && LstPlante.ElementAt(i).Indice[1] == LeCase.Y)
                {
                    LstPlante.RemoveAt(i);
                }
            }
        }

        /// <summary>
        /// Mthode qui se charge de mewttre la liste de plante ceuillia jour
        /// </summary>
        private void CeuillirPlante()
        {
            for (int i = 0; i < LstPlante.Count; i++)
            {
                if (LstPlante.ElementAt(i).Indice[0] == LeCase.X
                    && LstPlante.ElementAt(i).Indice[1] == LeCase.Y)
                {
                    Stock.CeuillirPlante(LstPlante.ElementAt(i).LaPlante.LeType);
                    LstPlante.RemoveAt(i);
                }
            }
            MettreTerre(LeCase.X, LeCase.Y);
        }
        /// <summary>
        /// Mthode qui se charge de mettre a jour les plantes pourrite
        /// </summary>
        private void EnleverPlante()//possible problem dans cueillir
        {
            for (int i = 0; i < LstPlante.Count; i++)
            {
                if (LstPlante.ElementAt(i).LaPlante.Pourri)
                {
                    LstPlante.RemoveAt(i);
                }
            }
        }
        /// <summary>
        /// Mthode qui se charge de voir si la plante est arroser
        /// </summary>
        /// <returns></returns>
        public bool PeutArroser()
        {
            return Map[LeCase.X, LeCase.Y].LaPlante.Arroser;
        }
        /// <summary>
        /// Mthode qui se charge de dire si la plante est mure
        /// </summary>
        /// <returns></returns>
        public bool PeutCeuillir()
        {
            return Map[LeCase.X, LeCase.Y].LaPlante.Mature;
        }
        /// <summary>
        /// Mthode qui se charge d'aroser la plante
        /// </summary>
        public void ArroserPlante()
        {
            BonneImage(false);
        }
        /// <summary>
        /// Mthode qui se charge de placer la bonne photo arroser
        /// </summary>
        /// <param name="Grandi"></param>
        private void BonneImage(bool Grandi)
        {
            if (Map[LeCase.X, LeCase.Y].LaPlante.LeType == Sorte.CARROT &&
                Map[LeCase.X, LeCase.Y].LaPlante.Rendu == 0)
            {
                if (Grandi) {
                    Map[LeCase.X, LeCase.Y].Photo = TilesetImageGenerator.GetTile((int)Sorte.CARROTGERME);
                    Map[LeCase.X, LeCase.Y].LaPlante.Arroser = false;
                }
                else
                {
                    Map[LeCase.X, LeCase.Y].Photo = TilesetImageGenerator.GetTile((int)Sorte.CARROTGERMEAU);
                    Map[LeCase.X, LeCase.Y].LaPlante.Arroser = true;
                }
            }
            else if (Map[LeCase.X, LeCase.Y].LaPlante.LeType == Sorte.CARROT && 
                Map[LeCase.X, LeCase.Y].LaPlante.Rendu == 1)
            {
                if (Grandi)
                {
                    Map[LeCase.X, LeCase.Y].Photo = TilesetImageGenerator.GetTile((int)Sorte.CARROTIGE);
                    Map[LeCase.X, LeCase.Y].LaPlante.Arroser = false;
                }
                else
                {
                    Map[LeCase.X, LeCase.Y].Photo = TilesetImageGenerator.GetTile((int)Sorte.CARROTIGEAU);
                    Map[LeCase.X, LeCase.Y].LaPlante.Arroser = true;
                }
            }
            else if (Map[LeCase.X, LeCase.Y].LaPlante.LeType == Sorte.CARROT && 
                Map[LeCase.X, LeCase.Y].LaPlante.Rendu == 2)
            {
                if (Grandi)
                {
                    Map[LeCase.X, LeCase.Y].Photo = TilesetImageGenerator.GetTile((int)Sorte.CARROT);
                    Map[LeCase.X, LeCase.Y].LaPlante.Arroser = false;
                }
                else
                {
                    Map[LeCase.X, LeCase.Y].Photo = TilesetImageGenerator.GetTile((int)Sorte.CARROTEAU);
                    Map[LeCase.X, LeCase.Y].LaPlante.Arroser = true;
                }
            }
            else if (Map[LeCase.X, LeCase.Y].LaPlante.LeType == Sorte.BLE &&
                Map[LeCase.X, LeCase.Y].LaPlante.Rendu == 0)
            {
                if (Grandi)
                {
                    Map[LeCase.X, LeCase.Y].Photo = TilesetImageGenerator.GetTile((int)Sorte.BLEGERME);
                    Map[LeCase.X, LeCase.Y].LaPlante.Arroser = false;
                }
                else
                {
                    Map[LeCase.X, LeCase.Y].Photo = TilesetImageGenerator.GetTile((int)Sorte.BLEGERMEAU);
                    Map[LeCase.X, LeCase.Y].LaPlante.Arroser = true;
                }
            }
            else if (Map[LeCase.X, LeCase.Y].LaPlante.LeType == Sorte.BLE &&
                Map[LeCase.X, LeCase.Y].LaPlante.Rendu == 1)
            {
                if (Grandi)
                {
                    Map[LeCase.X, LeCase.Y].Photo = TilesetImageGenerator.GetTile((int)Sorte.BLETIGE);
                    Map[LeCase.X, LeCase.Y].LaPlante.Arroser = false;
                }
                else
                {
                    Map[LeCase.X, LeCase.Y].Photo = TilesetImageGenerator.GetTile((int)Sorte.BLETIGEAU);
                    Map[LeCase.X, LeCase.Y].LaPlante.Arroser = true;
                }
                
            }
            else if (Map[LeCase.X, LeCase.Y].LaPlante.LeType == Sorte.BLE &&
                Map[LeCase.X, LeCase.Y].LaPlante.Rendu == 2)
            {
                if (Grandi)
                {
                    Map[LeCase.X, LeCase.Y].Photo = TilesetImageGenerator.GetTile((int)Sorte.BLE);
                    Map[LeCase.X, LeCase.Y].LaPlante.Arroser = false;
                }
                else
                {
                    Map[LeCase.X, LeCase.Y].Photo = TilesetImageGenerator.GetTile((int)Sorte.BLEAU);
                    Map[LeCase.X, LeCase.Y].LaPlante.Arroser = true;
                }
               
            }
            else if (Map[LeCase.X, LeCase.Y].LaPlante.LeType == Sorte.OIGNON &&
                Map[LeCase.X, LeCase.Y].LaPlante.Rendu == 0)
            {
                if (Grandi)
                {
                    Map[LeCase.X, LeCase.Y].Photo = TilesetImageGenerator.GetTile((int)Sorte.OIGNONGERME);
                    Map[LeCase.X, LeCase.Y].LaPlante.Arroser = false;
                }
                else
                {
                    Map[LeCase.X, LeCase.Y].Photo = TilesetImageGenerator.GetTile((int)Sorte.OIGNONGERMEAU);
                    Map[LeCase.X, LeCase.Y].LaPlante.Arroser = true;
                }   
            }
            else if (Map[LeCase.X, LeCase.Y].LaPlante.LeType == Sorte.OIGNON &&
                Map[LeCase.X, LeCase.Y].LaPlante.Rendu == 1)
            {
                if (Grandi)
                {
                    Map[LeCase.X, LeCase.Y].Photo = TilesetImageGenerator.GetTile((int)Sorte.OIGNONTIGE);
                    Map[LeCase.X, LeCase.Y].LaPlante.Arroser = false;
                }
                else
                {
                    Map[LeCase.X, LeCase.Y].Photo = TilesetImageGenerator.GetTile((int)Sorte.OIGNONTIGEAU);
                    Map[LeCase.X, LeCase.Y].LaPlante.Arroser = true;
                }  
            }
            else if (Map[LeCase.X, LeCase.Y].LaPlante.LeType == Sorte.OIGNON &&
                Map[LeCase.X, LeCase.Y].LaPlante.Rendu == 2)
            {
                if (Grandi)
                {
                    Map[LeCase.X, LeCase.Y].Photo = TilesetImageGenerator.GetTile((int)Sorte.OIGNON);
                    Map[LeCase.X, LeCase.Y].LaPlante.Arroser = false;
                }
                else
                {
                    Map[LeCase.X, LeCase.Y].Photo = TilesetImageGenerator.GetTile((int)Sorte.OIGNONEAU);
                    Map[LeCase.X, LeCase.Y].LaPlante.Arroser = true;
                }
                
            }
            else if (Map[LeCase.X, LeCase.Y].LaPlante.LeType == Sorte.TULIPE &&
                Map[LeCase.X, LeCase.Y].LaPlante.Rendu == 0)
            {
                if (Grandi)
                {
                    Map[LeCase.X, LeCase.Y].Photo = TilesetImageGenerator.GetTile((int)Sorte.TULIPGERME);
                    Map[LeCase.X, LeCase.Y].LaPlante.Arroser =false;
                }
                else
                {
                    Map[LeCase.X, LeCase.Y].Photo = TilesetImageGenerator.GetTile((int)Sorte.TULIPGERMEAU);
                    Map[LeCase.X, LeCase.Y].LaPlante.Arroser = true;
                }
                
            }
            else if (Map[LeCase.X, LeCase.Y].LaPlante.LeType == Sorte.TULIPE &&
                Map[LeCase.X, LeCase.Y].LaPlante.Rendu == 1)
            {
                if (Grandi)
                {
                    Map[LeCase.X, LeCase.Y].Photo = TilesetImageGenerator.GetTile((int)Sorte.TULIPETIGE);
                    Map[LeCase.X, LeCase.Y].LaPlante.Arroser = false;
                }
                else
                {
                    Map[LeCase.X, LeCase.Y].Photo = TilesetImageGenerator.GetTile((int)Sorte.TULIPETIGEAU);
                    Map[LeCase.X, LeCase.Y].LaPlante.Arroser = true;
                }
            }
            else if (Map[LeCase.X, LeCase.Y].LaPlante.LeType == Sorte.TULIPE &&
                Map[LeCase.X, LeCase.Y].LaPlante.Rendu == 2)
            {
                if (Grandi)
                {
                    Map[LeCase.X, LeCase.Y].Photo = TilesetImageGenerator.GetTile((int)Sorte.TULIPE);
                    Map[LeCase.X, LeCase.Y].LaPlante.Arroser = false;
                }
                else
                {
                    Map[LeCase.X, LeCase.Y].Photo = TilesetImageGenerator.GetTile((int)Sorte.TULIPEAU);
                    Map[LeCase.X, LeCase.Y].LaPlante.Arroser = true;
                }
                
            }
            else if (Map[LeCase.X, LeCase.Y].LaPlante.LeType == Sorte.TOMATE &&
                Map[LeCase.X, LeCase.Y].LaPlante.Rendu == 0)
            {
                if (Grandi)
                {
                    Map[LeCase.X, LeCase.Y].Photo = TilesetImageGenerator.GetTile((int)Sorte.TOMATEGERME);
                    Map[LeCase.X, LeCase.Y].LaPlante.Arroser = false;
                }
                else
                {
                    Map[LeCase.X, LeCase.Y].Photo = TilesetImageGenerator.GetTile((int)Sorte.TOMATEGERMEAU);
                    Map[LeCase.X, LeCase.Y].LaPlante.Arroser = true;
                }

            }
            else if (Map[LeCase.X, LeCase.Y].LaPlante.LeType == Sorte.TOMATE &&
                Map[LeCase.X, LeCase.Y].LaPlante.Rendu == 1)
            {
                if (Grandi)
                {
                    Map[LeCase.X, LeCase.Y].Photo = TilesetImageGenerator.GetTile((int)Sorte.TOMATETIGE);
                    Map[LeCase.X, LeCase.Y].LaPlante.Arroser = false;
                }
                else
                {
                    Map[LeCase.X, LeCase.Y].Photo = TilesetImageGenerator.GetTile((int)Sorte.TOMATETIGEAU);
                    Map[LeCase.X, LeCase.Y].LaPlante.Arroser = true;
                }
                
            }
            else if (Map[LeCase.X, LeCase.Y].LaPlante.LeType == Sorte.TOMATE &&
                Map[LeCase.X, LeCase.Y].LaPlante.Rendu == 2)
            {
                if (Grandi)
                {
                    Map[LeCase.X, LeCase.Y].Photo = TilesetImageGenerator.GetTile((int)Sorte.TOMATE);
                    Map[LeCase.X, LeCase.Y].LaPlante.Arroser = false;
                }
                else
                {
                    Map[LeCase.X, LeCase.Y].Photo = TilesetImageGenerator.GetTile((int)Sorte.TOMATEAU);
                    Map[LeCase.X, LeCase.Y].LaPlante.Arroser = true;
                }

            }
        }

        /// <summary>
        /// Mthode qui se charge de passer la journer
        /// </summary>
        public void PasserJourne()
        {
            for (int i = 0; i < LstPlante.Count; i++)
            {
                LeCase = new Point(LstPlante.ElementAt(i).Indice[0], LstPlante.ElementAt(i).Indice[1]);
                if (LstPlante.ElementAt(i).LaPlante.Arroser)
                {
                    LstPlante.ElementAt(i).LaPlante.Grandir();
                    BonneImage(true);
                }
                else
                {
                    LstPlante.ElementAt(i).LaPlante.Pourri = true;
                    MettreTerre(LstPlante.ElementAt(i).Indice[0], LstPlante.ElementAt(i).Indice[1]);
                }
            }
            EnleverPlante();
        }
        /// <summary>
        /// Mthode qui se charge de faire dormir le joueur
        /// </summary>
        public void Dormir()
        {
            Endormi = true;
            LstAdjacent.Clear();
            Chico.Dormir();
            MettreTerre(Precedent.X, Precedent.Y);
        }
        /// <summary>
        /// Mthode qui se charge de reveiller le joueur
        /// </summary>
        public void Reveiller()
        {
            if (Endormi)
            {
                Endormi = false;
                Debut();
                Chico.Reveiller();
            }
        }
    }
}
