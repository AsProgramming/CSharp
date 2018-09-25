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
    public partial class EcranPlanter : UserControl
    {
        private Jardin LeJardin;
        public EcranPlanter( Jardin _map)
        {
            LeJardin = _map;
            InitializeComponent();
            BonneImg();
        }
        /// <summary>
        /// Methode qui delegate au joueur la creation de plante
        /// </summary>
        /// <param name="_i"></param>
        public void Ajustement(int _i)
        {
            switch (_i)
            {
                case 1:
                    LeJardin.LeJoueur.CreerPlante(1);
                    break;
                case 2:
                    LeJardin.LeJoueur.CreerPlante(2);
                    break;
                case 3:
                    LeJardin.LeJoueur.CreerPlante(3);
                    break;
                case 4:
                    LeJardin.LeJoueur.CreerPlante(4);
                    break;
                case 5:
                    LeJardin.LeJoueur.CreerPlante(5);
                    break;
                default:
                    LeJardin.LeJoueur.CreerPlante(6);
                    break;
            }
            LeJardin.Refresh();
            LeJardin.FinPause();
            Dispose();
        }
        /// <summary>
        /// Methode qui dit au joueur de planter une cloture
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnCloture_CheckedChanged(object sender, EventArgs e)
        {
            Ajustement(6);
        }
        /// <summary>
        /// Methode qui ferme l'ecran
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnAnnuler_Click(object sender, EventArgs e)
        {
            LeJardin.FinPause();
            Dispose();
        }
        /// <summary>
        /// Methode qui dit au joueur de retirer la plante semer
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnPlante1_Click(object sender, EventArgs e)
        {
            LeJardin.LeJoueur.Disponible.AjusterPlante(Sorte.BLE, true);
            Ajustement(1);
        }
        /// <summary>
        /// Methode qui dit au joueur de retirer la plante semer
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnPlante2_Click(object sender, EventArgs e)
        {
            LeJardin.LeJoueur.Disponible.AjusterPlante(Sorte.CARROT, true);
            Ajustement(2);
        }
        /// <summary>
        /// Methode qui dit au joueur de retirer la plante semer
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnPlante3_Click(object sender, EventArgs e)
        {
            LeJardin.LeJoueur.Disponible.AjusterPlante(Sorte.OIGNON, true);
            Ajustement(3);
        }
        /// <summary>
        /// Methode qui dit au joueur de retirer la plante semer
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnPlante4_Click(object sender, EventArgs e)
        {
            LeJardin.LeJoueur.Disponible.AjusterPlante(Sorte.TOMATE, true);
            Ajustement(4);
        }
        /// <summary>
        /// Methode qui dit au joueur de retirer la plante semer
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnPlante5_Click(object sender, EventArgs e)
        {
            LeJardin.LeJoueur.Disponible.AjusterPlante(Sorte.TULIPE, true);
            Ajustement(5);
        }
        /// <summary>
        /// Methode qui gere de montrer l'inventaire au joueur 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnInventaire_CheckedChanged(object sender, EventArgs e)
        {
            Portefeuille p = new Portefeuille(LeJardin);
            p.Location = new Point(200, 300);
            LeJardin.Controls.Add(p);
            Dispose();
        }
        /// <summary>
        /// Methode qui gere la photo a montrer
        /// </summary>
        private void BonneImg()
        {
            BtnPlante1.BackgroundImage = TilesetImageGenerator.GetTile((int)Sorte.BLE);
            BtnPlante2.BackgroundImage = TilesetImageGenerator.GetTile((int)Sorte.CARROT);
            BtnPlante3.BackgroundImage = TilesetImageGenerator.GetTile((int)Sorte.OIGNON);
            BtnPlante4.BackgroundImage = TilesetImageGenerator.GetTile((int)Sorte.TOMATE);
            BtnPlante5.BackgroundImage = TilesetImageGenerator.GetTile((int)Sorte.TULIPE);
            BtnCloture.BackgroundImage = TilesetImageGenerator.GetTile(TilesetImageGenerator.CLOTURE);
            ActiverButton();
        }
        /// <summary>
        /// Methode qui gere d'activer les bon button selon les semance disponible
        /// </summary>
        private void ActiverButton()
        {
            BtnPlante1.Enabled = EstDisponible(Sorte.BLE);
            BtnPlante2.Enabled = EstDisponible(Sorte.CARROT);
            BtnPlante3.Enabled = EstDisponible(Sorte.OIGNON);
            BtnPlante4.Enabled = EstDisponible(Sorte.TOMATE);
            BtnPlante5.Enabled = EstDisponible(Sorte.TULIPE);
        }
        /// <summary>
        /// Methode qui verifi si la semance et disponible
        /// </summary>
        /// <param name="_Type"></param>
        /// <returns></returns>
        private bool EstDisponible(Sorte _Type)
        {
            return LeJardin.LeJoueur.Disponible.Total(_Type, false) != 0;
        }
    }
}
