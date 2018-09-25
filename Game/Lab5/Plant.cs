 using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5
{
    public enum Sorte
    {
        TERRE = 0,
        CLOTURE,
        BUISSON,
        ROCHE,
        CARROTGERME,
        CARROTIGE,
        CARROT,
        CARROTGERMEAU,
        CARROTIGEAU,
        CARROTEAU,
        TULIPGERME,
        TULIPETIGE,
        TULIPE,
        TULIPGERMEAU,
        TULIPETIGEAU,
        TULIPEAU,
        OIGNONGERME,
        OIGNONTIGE,
        OIGNON,
        OIGNONGERMEAU,
        OIGNONTIGEAU,
        OIGNONEAU,
        TOMATEGERME,
        TOMATETIGE,
        TOMATE,
        TOMATEGERMEAU,
        TOMATETIGEAU,
        TOMATEAU,
        BLEGERME,
        BLETIGE,
        BLE,
        BLEGERMEAU,
        BLETIGEAU,
        BLEAU,
        HERO,
        HERO2,
        PUIT,
        PUIT2,
        PUIT3,
        PUIT4,
        CHIEN,
        CHIEN2,
        CHEMINER,
        MAISON,
        PLANTE
    }
    public class Plant
    {
        private int Jour;
        private int Planter;
        private bool Nourri;
        private Sorte LaPlante;
        private int[] Cout;
        private bool Manger;

        public Plant(Sorte _Type)
        {
            Manger = false;
            Cout = new int[2];
            Preparer(_Type);
        }

        public bool Pourri
        {
            get { return Manger; }
            set { Manger = value; }
        }
        /// <summary>
        /// Mthode qui se charge de construire les plante
        /// </summary>
        /// <param name="_Type"></param>
        private void Preparer(Sorte _Type)
        {
            switch(_Type)
            {
                case Sorte.TULIPE:
                    LaPlante = Sorte.TULIPE;
                    Cout[0] = 20;
                    Cout[1] = 50;
                    Jour = 4;
                    break;
                case Sorte.OIGNON:
                    LaPlante = Sorte.OIGNON;
                    Cout[0] = 80;
                    Cout[1] = 200;
                    Jour = 7;
                    break;
                case Sorte.TOMATE:
                    LaPlante = Sorte.TOMATE;
                    Cout[0] = 50;
                    Cout[1] = 250;
                    Jour = 11;
                    break;
                case Sorte.BLE:
                    LaPlante = Sorte.BLE;
                    Cout[0] = 10;
                    Cout[1] = 25;
                    Jour = 4;
                    break;
                case Sorte.CARROT:
                    LaPlante = Sorte.CARROT;
                    Cout[0] = 10;
                    Cout[1] = 20;
                    Jour = 3; //Original
                    break;
            }
            Nourri = false;
            Planter = 0;
        }

        public bool Mature
        {
            get { return Jour - Planter == 0; }
        }

        public bool Arroser
        {
            get { return Nourri; }
            set { Nourri = value; }
        }

        public int Duree
        {
            get { return Planter; }
        }

        public int Rendu
        {
            get {return BonNombre();}
        }

        public int PrixAchat
        {
            get { return Cout[0]; }
        }

        public int PrixVente
        {
            get { return Cout[1]; }
        }

        public Sorte LeType
        {
            get { return LaPlante; }
        }

        public void Grandir()
        {
            Planter += 1;
        }
        /// <summary>
        /// Mthode qui se charge de calculer le bon nb de jours
        /// </summary>
        /// <returns></returns>
        private int BonNombre()
        {
            switch(LaPlante)
            {
                case Sorte.TULIPE:
                    return CalculerJours(4);
                case Sorte.OIGNON:
                    return CalculerJours(2);
                case Sorte.TOMATE:
                    return CalculerJours(1);
                case Sorte.BLE:
                    return CalculerJours(4);
                case Sorte.CARROT:
                    return CalculerJours(3);
            }
            return -1;
        }
        /// <summary>
        /// Mthode qui se charge de calculer le nombre jour pour ajuster l'image de grandissement
        /// </summary>
        /// <param name="_i"></param>
        /// <returns></returns>
        private int CalculerJours(int _i)
        {
            if (Planter == 0)
            {
                return 0;
            }
            else if (_i == 1 & Planter >= 1 && Planter < 4)
            {
                return 0;
            }
            else if (_i == 1 && Planter >= 4 && Planter < 8)
            {
                return 1;
            }
            else if (_i == 1 && Planter >= 8 && Planter < 12)
            {
                return 2;
            }
            else if (_i == 2 && Planter >= 1 && Planter < 3)
            {
                return 0;
            }
            else if (_i == 2 && Planter >= 3 && Planter < 6)
            {
                return 1;
            }
            else if (_i == 2 && Planter >= 6 && Planter < 8)
            {
                return 2;
            }
            else if (_i == 3 && Planter == 1 )
            {
                return 1;
            }
            else if (_i == 3 && Planter == 2)
            {
                return 1;
            }
            else if (_i == 3 && Planter == 3)
            {
                return 2;
            }
            else if (_i == 4 && Planter >= 1 && Planter <= 3)
            {
                return 1;
            }
            else if (_i == 4 && Planter == 4)
            {
                return 2;
            }
            return 1;
        }
    }
}
