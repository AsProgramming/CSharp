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
    public partial class Portefeuille : UserControl
    {
        private Jardin LeJardin;
        public Portefeuille(Jardin _j)
        {
            LeJardin = _j;
            InitializeComponent();
            ArrangerImage();
        }
        /// <summary>
        /// Methode qui gere la creation des images
        /// </summary>
        private void ArrangerImage()
        {
            PicPlante1.BackgroundImage = TilesetImageGenerator.GetTile((int)Sorte.CARROT);
            PicPlante2.BackgroundImage = TilesetImageGenerator.GetTile((int)Sorte.BLE);
            PicPlante3.BackgroundImage = TilesetImageGenerator.GetTile((int)Sorte.OIGNON);
            PicPlante4.BackgroundImage = TilesetImageGenerator.GetTile((int)Sorte.TOMATE);
            PicPlante5.BackgroundImage = TilesetImageGenerator.GetTile((int)Sorte.TULIPE);
            PicPlante6.BackgroundImage = TilesetImageGenerator.GetTile((int)Sorte.CARROT);
            PicPlante7.BackgroundImage = TilesetImageGenerator.GetTile((int)Sorte.BLE);
            PicPlante8.BackgroundImage = TilesetImageGenerator.GetTile((int)Sorte.OIGNON);
            PicPlante9.BackgroundImage = TilesetImageGenerator.GetTile((int)Sorte.TOMATE);
            PicPlante10.BackgroundImage = TilesetImageGenerator.GetTile((int)Sorte.TULIPE);
            AjusterQts();
        }
        /// <summary>
        /// Methode qui gere la creation des quantites
        /// </summary>
        private void AjusterQts()
        {
            LblArgent.Text = LeJardin.LeJoueur.Disponible.Solde.ToString();
            TxtBxPlante1.Text = LeJardin.LeJoueur.Disponible.Total(Sorte.CARROT, false).ToString();
            TxtBxPlante2.Text = LeJardin.LeJoueur.Disponible.Total(Sorte.BLE, false).ToString();
            TxtBxPlante3.Text = LeJardin.LeJoueur.Disponible.Total(Sorte.OIGNON, false).ToString();
            TxtBxPlante4.Text = LeJardin.LeJoueur.Disponible.Total(Sorte.TOMATE, false).ToString();
            TxtBxPlante5.Text = LeJardin.LeJoueur.Disponible.Total(Sorte.TULIPE, false).ToString();
            TxtBxPlante6.Text = LeJardin.LeJoueur.Disponible.Total(Sorte.CARROT, true).ToString();
            TxtBxPlante7.Text = LeJardin.LeJoueur.Disponible.Total(Sorte.BLE, true).ToString();
            TxtBxPlante8.Text = LeJardin.LeJoueur.Disponible.Total(Sorte.OIGNON, true).ToString();
            TxtBxPlante9.Text = LeJardin.LeJoueur.Disponible.Total(Sorte.TOMATE, true).ToString();
            TxtBxPlante10.Text = LeJardin.LeJoueur.Disponible.Total(Sorte.TULIPE, true).ToString();
        }
        /// <summary>
        /// Methode qui gere le button annuler
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnOK_CheckedChanged(object sender, EventArgs e)
        {
            LeJardin.FinPause();
            Dispose();
        }
    }
}
