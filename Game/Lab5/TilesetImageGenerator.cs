using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5
{
    // Attention au namespace ici haut. Mettre le même que le reste de votre projet

    class TilesetImageGenerator
    {
        // Différentes tailles concernant les images dans le fichier de tuiles de jeu
        public const int IMAGE_WIDTH = 32, IMAGE_HEIGHT = 32;
        private const int TILE_LEFT = 0, TILE_TOP = 0;
        private const int SEPARATEUR_TILE = 0;

        // La valeur entière correspond "par hasard" à la position de l'image dans la List<TileCoord>
        public const int TERRE= 0;
        public const int CLOTURE= 1;
        public const int BUISSON= 2;
        public const int ROCHE= 3;


        private static List<TileCoord> listeCoord = new List<TileCoord>();
        private static List<Bitmap> listeBitmap = new List<Bitmap>();
        private static Image imageSource;

        /// <summary>
        /// Constructeur statique
        /// </summary>
        static TilesetImageGenerator()
        {
            // Mettre l'image dans les ressources du projet. S'assurer que le nom est identique, sinon modifier "farm_tileset" :
            imageSource = Properties.Resources.farm_tileset2; 

            listeCoord.Add(new TileCoord() { Ligne = 0, Colonne = 6 }); // TERRE
            listeCoord.Add(new TileCoord() { Ligne = 0, Colonne = 9 }); // CLOTURE
            listeCoord.Add(new TileCoord() { Ligne = 0, Colonne = 10 }); // BUISSON
            listeCoord.Add(new TileCoord() { Ligne = 0, Colonne = 11 }); // ROCH

            listeCoord.Add(new TileCoord() { Ligne = 6, Colonne = 0 }); // PLANT CARROT
            listeCoord.Add(new TileCoord() { Ligne = 6, Colonne = 1 }); // PLANT CARROT
            listeCoord.Add(new TileCoord() { Ligne = 6, Colonne = 2 }); // PLANT CARROT

            // PLANT CARROTARROSER
            listeCoord.Add(new TileCoord() { Ligne = 7, Colonne = 0 }); // PLANT CARROT
            listeCoord.Add(new TileCoord() { Ligne = 7, Colonne = 1 }); // PLANT CARROT
            listeCoord.Add(new TileCoord() { Ligne = 7, Colonne = 2 }); // PLANT CARROT

            listeCoord.Add(new TileCoord() { Ligne = 6, Colonne = 3 }); // PLANT TULIPE
            listeCoord.Add(new TileCoord() { Ligne = 6, Colonne = 4 }); // PLANT TULIPE
            listeCoord.Add(new TileCoord() { Ligne = 6, Colonne = 5 }); // PLANT TULIPE

            listeCoord.Add(new TileCoord() { Ligne = 7, Colonne = 3 }); // PLANT TUIPARROSER
            listeCoord.Add(new TileCoord() { Ligne = 7, Colonne = 4 });
            listeCoord.Add(new TileCoord() { Ligne = 7, Colonne = 5 });

            listeCoord.Add(new TileCoord() { Ligne = 4, Colonne = 6 }); // PLANT OIGNON
            listeCoord.Add(new TileCoord() { Ligne = 4, Colonne = 7 }); // PLANT OIGNON
            listeCoord.Add(new TileCoord() { Ligne = 4, Colonne = 8 }); // PLANT OIGNON

            listeCoord.Add(new TileCoord() { Ligne = 5, Colonne = 6 }); // PLANT OIGARROSER
            listeCoord.Add(new TileCoord() { Ligne = 5, Colonne = 7 });
            listeCoord.Add(new TileCoord() { Ligne = 5, Colonne = 8 });

            listeCoord.Add(new TileCoord() { Ligne = 4, Colonne = 9 }); // PLANT TOMATE
            listeCoord.Add(new TileCoord() { Ligne = 4, Colonne = 10 }); // PLANT TOM
            listeCoord.Add(new TileCoord() { Ligne = 4, Colonne = 11 }); // PLANT TOM

            listeCoord.Add(new TileCoord() { Ligne = 5, Colonne = 9 }); // PLANT TOMATEARROSER
            listeCoord.Add(new TileCoord() { Ligne = 5, Colonne = 10 }); // PLANT TOM
            listeCoord.Add(new TileCoord() { Ligne = 5, Colonne = 11 }); // PLANT TOM

            listeCoord.Add(new TileCoord() { Ligne = 6, Colonne = 9 }); // PLANT BLE
            listeCoord.Add(new TileCoord() { Ligne = 6, Colonne = 10 });
            listeCoord.Add(new TileCoord() { Ligne = 6, Colonne = 11 }); 

            listeCoord.Add(new TileCoord() { Ligne = 7, Colonne = 9 }); // PLANT BLEARROSER
            listeCoord.Add(new TileCoord() { Ligne = 7, Colonne = 10 });
            listeCoord.Add(new TileCoord() { Ligne = 7, Colonne = 11 }); 

            listeCoord.Add(new TileCoord() { Ligne = 0, Colonne = 7 }); // HERO
            listeCoord.Add(new TileCoord() { Ligne = 0, Colonne = 8 }); // HERO2

            listeCoord.Add(new TileCoord() { Ligne = 1, Colonne = 9 }); // puit
            listeCoord.Add(new TileCoord() { Ligne = 1, Colonne = 10 }); // puit
            listeCoord.Add(new TileCoord() { Ligne = 2, Colonne = 9 }); // puit
            listeCoord.Add(new TileCoord() { Ligne = 2, Colonne = 10 }); // puit

            listeCoord.Add(new TileCoord() { Ligne = 0, Colonne = 4 }); // CHICO
            listeCoord.Add(new TileCoord() { Ligne = 0, Colonne = 5 }); // 

            listeCoord.Add(new TileCoord() { Ligne = 7, Colonne = 13 }); //CHEMINER
            listeCoord.Add(new TileCoord() { Ligne = 1, Colonne = 3 }); //MAISON

            listeBitmap.Add(LoadTile((int)Sorte.TERRE, 0)); 
            listeBitmap.Add(LoadTile((int)Sorte.CLOTURE, 0)); 
            listeBitmap.Add(LoadTile((int)Sorte.BUISSON, 0)); 
            listeBitmap.Add(LoadTile((int)Sorte.ROCHE, 0));

            listeBitmap.Add(LoadTile((int)Sorte.CARROTGERME, 0)); 
            listeBitmap.Add(LoadTile((int)Sorte.CARROTIGE, 0)); 
            listeBitmap.Add(LoadTile((int)Sorte.CARROT, 0)); 

            listeBitmap.Add(LoadTile((int)Sorte.CARROTGERMEAU, 0)); 
            listeBitmap.Add(LoadTile((int)Sorte.CARROTIGEAU, 0)); 
            listeBitmap.Add(LoadTile((int)Sorte.CARROTEAU, 0)); 

            listeBitmap.Add(LoadTile((int)Sorte.TULIPGERME, 0));
            listeBitmap.Add(LoadTile((int)Sorte.TULIPETIGE, 0)); 
            listeBitmap.Add(LoadTile((int)Sorte.TULIPE, 0)); 

            listeBitmap.Add(LoadTile((int)Sorte.TULIPGERMEAU, 0));
            listeBitmap.Add(LoadTile((int)Sorte.TULIPETIGEAU, 0)); 
            listeBitmap.Add(LoadTile((int)Sorte.TULIPEAU, 0)); //

            listeBitmap.Add(LoadTile((int)Sorte.OIGNONGERME, 0)); // 
            listeBitmap.Add(LoadTile((int)Sorte.OIGNONTIGE, 0)); // 
            listeBitmap.Add(LoadTile((int)Sorte.OIGNON, 0)); // 

            listeBitmap.Add(LoadTile((int)Sorte.OIGNONGERMEAU, 0)); // 
            listeBitmap.Add(LoadTile((int)Sorte.OIGNONTIGEAU, 0)); // 
            listeBitmap.Add(LoadTile((int)Sorte.OIGNONEAU, 0)); 

            listeBitmap.Add(LoadTile((int)Sorte.TOMATEGERME, 0)); 
            listeBitmap.Add(LoadTile((int)Sorte.TOMATETIGE, 0)); 
            listeBitmap.Add(LoadTile((int)Sorte.TOMATE, 0)); 

            listeBitmap.Add(LoadTile((int)Sorte.TOMATEGERMEAU, 0)); 
            listeBitmap.Add(LoadTile((int)Sorte.TOMATETIGEAU, 0)); 
            listeBitmap.Add(LoadTile((int)Sorte.TOMATEAU, 0));

            listeBitmap.Add(LoadTile((int)Sorte.BLEGERME, 0));
            listeBitmap.Add(LoadTile((int)Sorte.BLETIGE, 0));
            listeBitmap.Add(LoadTile((int)Sorte.BLE, 0));

            listeBitmap.Add(LoadTile((int)Sorte.BLEGERMEAU, 0));
            listeBitmap.Add(LoadTile((int)Sorte.BLETIGEAU, 0));
            listeBitmap.Add(LoadTile((int)Sorte.BLEAU, 0));

            listeBitmap.Add(LoadTile((int)Sorte.HERO, 0)); // HERO
            listeBitmap.Add(LoadTile((int)Sorte.HERO2, 0)); // HERO

            listeBitmap.Add(LoadTile((int)Sorte.PUIT, 0)); // 
            listeBitmap.Add(LoadTile((int)Sorte.PUIT2, 0)); 
            listeBitmap.Add(LoadTile((int)Sorte.PUIT3, 0)); 
            listeBitmap.Add(LoadTile((int)Sorte.PUIT4, 0)); 

            listeBitmap.Add(LoadTile((int)Sorte.CHIEN, 0)); 
            listeBitmap.Add(LoadTile((int)Sorte.CHIEN2, 0)); 

            listeBitmap.Add(LoadTile((int)Sorte.CHEMINER, 1));
            listeBitmap.Add(LoadTile((int)Sorte.MAISON, 4));
        }

        private static Bitmap LoadTile(int posListe, int indice)
        {
            TileCoord coord = listeCoord[posListe];
            Rectangle crop;
            if (indice == 0)
            {
                crop = new Rectangle(TILE_LEFT + (coord.Colonne * (IMAGE_WIDTH + SEPARATEUR_TILE)), TILE_TOP + coord.Ligne * (IMAGE_HEIGHT + SEPARATEUR_TILE), IMAGE_WIDTH, IMAGE_HEIGHT);
            }
            else if (indice == 1)
            {
                crop = new Rectangle(TILE_LEFT + (coord.Colonne * (IMAGE_WIDTH + SEPARATEUR_TILE)), TILE_TOP + coord.Ligne * (IMAGE_WIDTH / 2 + SEPARATEUR_TILE), IMAGE_WIDTH, IMAGE_HEIGHT / 2);
            }
            else
            {
                crop = new Rectangle(TILE_LEFT + (coord.Colonne * (IMAGE_WIDTH * 4 + SEPARATEUR_TILE)), TILE_TOP + coord.Ligne * (IMAGE_HEIGHT * 4 + SEPARATEUR_TILE), IMAGE_WIDTH * 4, IMAGE_HEIGHT * 5);
            }

            var bmp = new Bitmap(crop.Width, crop.Height);
            using (var gr = Graphics.FromImage(bmp))
            {
                gr.DrawImage(imageSource, new Rectangle(0, 0, bmp.Width, bmp.Height), crop, GraphicsUnit.Pixel);
            }
            return bmp;
        }

        public static Bitmap GetTile(int posListe)
        {
            return listeBitmap[posListe];
        }

    }

    public class TileCoord
    {
        public int Ligne { get; set; }
        public int Colonne { get; set; }
    };
}

