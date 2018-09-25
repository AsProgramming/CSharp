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
            imageSource = Properties.Resources.farm_tileset; 

            listeCoord.Add(new TileCoord() { Ligne = 0, Colonne = 8 }); // TERRE
            listeCoord.Add(new TileCoord() { Ligne = 0, Colonne = 9 }); // CLOTURE
            listeCoord.Add(new TileCoord() { Ligne = 0, Colonne = 10 }); // BUISSON
            listeCoord.Add(new TileCoord() { Ligne = 0, Colonne = 11 }); // ROCHE

            listeBitmap.Add(LoadTile(TERRE)); // TERRE
            listeBitmap.Add(LoadTile(CLOTURE)); // CLOTURE
            listeBitmap.Add(LoadTile(BUISSON)); // BUISSON
            listeBitmap.Add(LoadTile(ROCHE)); // ROCHE
         
        }
        
        private static Bitmap LoadTile(int posListe)
        {
            TileCoord coord = listeCoord[posListe];
            Rectangle crop = new Rectangle(TILE_LEFT + (coord.Colonne * (IMAGE_WIDTH + SEPARATEUR_TILE)), TILE_TOP + coord.Ligne * (IMAGE_HEIGHT + SEPARATEUR_TILE), IMAGE_WIDTH, IMAGE_HEIGHT);

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

