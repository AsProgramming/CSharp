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
    public partial class ActionsOrdi : UserControl
    {
        private Maison LaMaison;
        private bool Vente;
        private int Total;
        private int[] Indices;
        private Paquet Commande;
        private List<int> TotalPlantes;

        public ActionsOrdi(Maison _m, bool V)
        {
            Indices = new int[6];
            Vente = V;
            LaMaison = _m;
            InitializeComponent();
            LesImages();
        }
        /// <summary>
        /// Methode qui ajuste les photos 
        /// </summary>
        private void LesImages()
        {
            PicPlante1.BackgroundImage = TilesetImageGenerator.GetTile((int)Sorte.BLE);
            PicPlante2.BackgroundImage = TilesetImageGenerator.GetTile((int)Sorte.CARROT);
            PicPlante3.BackgroundImage = TilesetImageGenerator.GetTile((int)Sorte.TULIPE);
            PicPlante4.BackgroundImage = TilesetImageGenerator.GetTile((int)Sorte.TOMATE);
            PicPlante5.BackgroundImage = TilesetImageGenerator.GetTile((int)Sorte.OIGNON);
            AjusterText();
        }
        /// <summary>
        /// Methode qui ajuste les labels selon si c'est une vente ou non
        /// </summary>
        private void AjusterText()
        {
            LblArgent.Text = LaMaison.Acces.LeJoueur.Disponible.Solde.ToString();
            if (Vente)
            {
                PicPlante1.BackgroundImage = TilesetImageGenerator.GetTile((int)Sorte.CARROT);
                PicPlante2.BackgroundImage = TilesetImageGenerator.GetTile((int)Sorte.BLE);
                PicPlante4.BackgroundImage = TilesetImageGenerator.GetTile((int)Sorte.OIGNON);
                PicPlante5.BackgroundImage = TilesetImageGenerator.GetTile((int)Sorte.TOMATE);
                LblPlante1.Text = "20$ /Un";
                LblPlante2.Text = "25$ /Un";
                LblPlante3.Text = "50$ /Un";
                LblPlante4.Text = "200$ /Un";
                LblPlante5.Text = "250$ /Un";
                GrSelection.Text = "Vente";
                GrBCommande.Text = "Vente";
                GrArgent.Text = "Profit";
                LblArgent.Text = "0";
                BtnAcheter.Text = "Vendre";
                AjusterCbo();
              //Ajuster le nbdevente au nb de cueillette dispo
            }
        }
        /// <summary>
        /// Methode qui gere de placer au bon endroit la selection des plante
        /// </summary>
        private void AjusterCbo()
        {
            CboPlante1.Enabled = Activer(Sorte.CARROT);
            CboPlante2.Enabled = Activer(Sorte.BLE);
            CboPlante3.Enabled = Activer(Sorte.TULIPE);
            CboPlante4.Enabled = Activer(Sorte.OIGNON);
            CboPlante5.Enabled = Activer(Sorte.TOMATE);
            CboPlante1.Items.Clear();
            CboPlante2.Items.Clear();
            CboPlante3.Items.Clear();
            CboPlante4.Items.Clear();
            CboPlante5.Items.Clear();
            AjouterCorrectTabs(CboPlante1, Sorte.CARROT);
            AjouterCorrectTabs(CboPlante2, Sorte.BLE);
            AjouterCorrectTabs(CboPlante3, Sorte.TULIPE);
            AjouterCorrectTabs(CboPlante4, Sorte.OIGNON);
            AjouterCorrectTabs(CboPlante5, Sorte.TOMATE);
            TotalPlantes = new List<int>();
            
        }
        /// <summary>
        /// Methode qui gere l'action d'activer l'option ou non
        /// </summary>
        /// <param name="_Type"></param>
        /// <returns></returns>
        private bool Activer(Sorte _Type)
        {
            return LaMaison.Acces.LeJoueur.Disponible.Total(_Type, true) != 0;
        }
        /// <summary>
        /// Methode qui gere d'ajuster le solde du joueur depandament de l'option choisi
        /// </summary>
        private void AjusterSoldeAchat()
        {
            if (!Vente)
            {
                AjustementDirect(Indices.Length, false);
            }
            else
            {
                AjustementDirect(Indices.Length + 1, true);
            }
        }
        /// <summary>
        /// Methode qui gere d'ajuster le solde du joueur directement dans l'inventaire
        /// </summary>
        /// <param name="_long"></param>
        /// <param name="_vente"></param>
        private void AjustementDirect(int _long, bool _vente)
        {
            bool modifier = false;
            for (int i = 1; i < _long; i++)
            {
                if(!Vente && Indices[i-1] > 0)
                {
                    LaMaison.Acces.LeJoueur.Disponible.AjusterSolde(i, Indices[i - 1 ], true);
                    modifier = true;
                }else if (Vente && Indices[i - 1] > 0)
                {
                    LaMaison.Acces.LeJoueur.Disponible.AjusterSolde(i, Indices[i - 1], false);
                }
            }
            if (modifier)
            {
                FaireCommande();
            }
        }
        /// <summary>
        /// Methode qui gere l'action de creer la commande si disponible
        /// </summary>
        private void FaireCommande()
        {
            Commande = new Paquet(LaMaison, Indices);
            LaMaison.PasserCommande = true;
            if (!LaMaison.LeJour)
            {
                Commande.EnAttente = 2;
            }
            else
            {
                Commande.EnAttente = 1;
            }
            LaMaison.AjouterCommande(Commande);
        }


        /// <summary>
        /// Methode qui gere l'action d'acheter
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnAcheter_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(TxtBxTotal.Text))
            {
                Total = Int32.Parse(TxtBxTotal.Text);
            }
            if (!Vente && Total > LaMaison.Acces.LeJoueur.Disponible.Solde)
            {
                ErrTotal.SetError(LblArgent, "Vous n'avez pas les fonds pour cet achat");
                ErrTotal.SetError(TxtBxTotal, "Ajuster le nombre commander");
            }
            else if (!Vente && Total <= LaMaison.Acces.LeJoueur.Disponible.Solde)
            {
                ErrTotal.SetError(LblArgent, "");
                ErrTotal.SetError(TxtBxTotal, "");
                AjusterSoldeAchat();
                Fin();
            }
            else if (Vente)
            {
                AjusterSoldeAchat();
                Fin();
            }
        }
        /// <summary>
        /// Methode qui gere l'action d'annuler
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnAnnuler_Click(object sender, EventArgs e)
        {
            Fin();
        }
        /// <summary>
        /// Methode qui gere de remettre en action le jeu et fermer l'ecran
        /// </summary>
        private void Fin()
        {
            LaMaison.Acces.FinPause();
            this.Dispose();
        }
        /// <summary>
        /// Methode qui gere l'ajstement du total de l'ecran
        /// </summary>
        /// <param name="_indice"></param>
        private void AjusterTotal(int _indice)
        {
            for (int i = 0; i < Indices.Length; i++)
            {
                Total += Indices[i];
            }
            TxtBxTotal.Text = Total.ToString();
            AjusterArgent(_indice);
        }
        /// <summary>
        /// Methode qui dit si le component a ete modifier
        /// </summary>
        /// <param name="c"></param>
        /// <param name="_indice"></param>
        /// <returns></returns>
        private bool Changer(ComboBox c, int _indice)
        {
             return c.Items.Count > 4 && _indice == 0;
        }
        /// <summary>
        /// Methode qui gere l'action de verser ou de retirer l'argent
        /// </summary>
        /// <param name="_indice"></param>
        private void AjusterArgent(int _indice)
        {
            int tmp = 0;
            if (!Vente)
            {
                tmp = LaMaison.Acces.LeJoueur.Disponible.Solde;
                if (Total > tmp)
                {
                    LblArgent.ForeColor = Color.Red;
                }else if(_indice == 0)
                {
                    tmp += Total;
                    ErrTotal.SetError(LblArgent, "");
                    ErrTotal.SetError(TxtBxTotal, "");
                    if(tmp <= LaMaison.Acces.LeJoueur.Disponible.Solde)
                    {
                        LblArgent.ForeColor = Color.Black;
                    }
                }
                else
                {
                    ErrTotal.SetError(LblArgent, "");
                    ErrTotal.SetError(TxtBxTotal, "");
                    LblArgent.ForeColor = Color.Black;
                }
                    tmp -= Total;
            }
            else
            {
                tmp += Total;
                LblArgent.ForeColor = Color.Green;
            }
            LblArgent.Text = tmp.ToString();
            Total = 0;
        }
        /// <summary>
        /// Methode qui gere l'action d'ajuster le bon indice du tableau
        /// </summary>
        /// <param name="_i"></param>
        /// <param name="_p"></param>
        /// <param name="Total"></param>
        private void AjusterBon(int _i, int _p, int Total)
        {
            Total *= _p;
            Indices[_i] = Total;
        }
        /// <summary>
        /// Methode qui gere l'action d'obtenir la bonne quantites de plantes disponible
        /// </summary>
        private void PlantesDisponibles()
        {
            TotalPlantes.Add(LaMaison.Acces.LeJoueur.Disponible.Total(Sorte.CARROT, true));
            TotalPlantes.Add(LaMaison.Acces.LeJoueur.Disponible.Total(Sorte.BLE, true));
            TotalPlantes.Add(LaMaison.Acces.LeJoueur.Disponible.Total(Sorte.TULIPE, true));
            TotalPlantes.Add(LaMaison.Acces.LeJoueur.Disponible.Total(Sorte.OIGNON, true));
            TotalPlantes.Add(LaMaison.Acces.LeJoueur.Disponible.Total(Sorte.TOMATE, true));

        }
        /// <summary>
        /// Methode qui gere si le combobox a tete modifier 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CboPlante1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            int Total = CboPlante1.SelectedIndex;
            if (Vente)
            {
                AjusterBon(0, 20, Total);
            }
            else
            {
                if (Changer(CboPlante1, Total))
                {
                Indices[0] -= Indices[0];
                }
                if (Pasjouter(CboPlante1))
                {
                CboPlante1.Items.Insert(0, "0");
                Total += 1;
                }
                else if (!Pasjouter(CboPlante1) && Total == 0)
                {
                    AjusterTotal(0);
                }
                AjusterBon(0, 10, Total);
            }
            AjusterTotal(2);
        }
        /// <summary>
        /// Methode qui ajuste bon combobox
        /// </summary>
        /// <param name="_c"></param>
        /// <param name="_Type"></param>
        private void AjouterCorrectTabs(ComboBox _c, Sorte _Type)
        {
            int Max = LaMaison.Acces.LeJoueur.Disponible.Total(_Type, true);
            for (int i = 0; i < Max + 1; i++)
            {
                _c.Items.Insert(i, i.ToString());
            }
        }
        /// <summary>
        /// Methode qui gere si le combobox a tete modifier 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CboPlante2_SelectedIndexChanged(object sender, EventArgs e)
        {
            //CAR
            int Total = CboPlante2.SelectedIndex;
            if (Changer(CboPlante4, Total))
            {
                Indices[1] -= Indices[1];
            }
            if (Pasjouter(CboPlante2))
            {
                CboPlante2.Items.Insert(0, "0");
                Total += 1;
            }else if (!Pasjouter(CboPlante2) && Total == 0)//si click sur acheter et err pro can still click on same or other and ajsuts the balance
            {
                AjusterBon(1, 10, Total);
            }
            if (Vente)
            {
                AjusterBon(1, 25, Total);
            }
            else
            {
                AjusterBon(1, 10, Total);
            }
            AjusterTotal(2);
        }
        /// <summary>
        /// Methode qui gere si le combobox a tete modifier 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CboPlante3_SelectedIndexChanged(object sender, EventArgs e)
        {
            int Total = CboPlante3.SelectedIndex;
            if (Changer(CboPlante3, Total))
            {
                Indices[2] -= Indices[2];
            }
            if (Pasjouter(CboPlante3))
            {
                CboPlante3.Items.Insert(0, "0");
                Total += 1;
            }
            else if (!Pasjouter(CboPlante3) && Total == 0)
            {
                AjusterTotal(0);
            }
            if (Vente)
            {
                AjusterBon(2, 50, Total);
            }
            else
            {
                AjusterBon(2, 20, Total);
            }

            AjusterTotal(2);
        }
        /// <summary>
        /// Methode qui gere si le combobox a tete modifier 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CboPlante4_SelectedIndexChanged(object sender, EventArgs e)
        {

            int Total = CboPlante4.SelectedIndex;
            if(Changer(CboPlante4, Total))
            {
                Indices[3] -= Indices[3];
            }
            if (Pasjouter(CboPlante4))
            {
                CboPlante4.Items.Insert(0, "0");
                Total += 1;
            }
            else if (!Pasjouter(CboPlante4) && Total == 0)
            {
                AjusterTotal(0);
            }
            if (Vente)
            {
                AjusterBon(3, 200, Total);
            }
            else
            {
                AjusterBon(3, 50, Total);
            }
            
            AjusterTotal(2);
        }
        /// <summary>
        /// Methode qui gere si le combobox a tete modifier 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CboPlante5_SelectedIndexChanged(object sender, EventArgs e)
        {
            int Total = CboPlante5.SelectedIndex;
            if (Changer(CboPlante5, Total))
            {
                Indices[4] -= Indices[4];
            }
            if (Pasjouter(CboPlante5))
            {
                CboPlante5.Items.Insert(0, "0");
                Total += 1;
            }
            else if (!Pasjouter(CboPlante5) && Total == 0)
            {
                AjusterTotal(0);
            }

            if (Vente)
            {
                AjusterBon(4, 250, Total);
            }
            else
            {
                AjusterBon(4, 80, Total);
            }
            AjusterTotal(2);
        }
        /// <summary>
        /// Methode qui gere si le combobox a ete remit a zero ou autre
        /// </summary>
        /// <param name="c"></param>
        /// <returns></returns>
        private bool Pasjouter(ComboBox c)
        {
            return c.Items.Count == 5;
        }
    }
}
