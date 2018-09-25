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
    public partial class Menu : UserControl
    {
        private Maison LaMaison;

        public Menu(Maison _m)
        {
            LaMaison = _m;
            InitializeComponent();
            if (LaMaison.LeJour)
            {
                BtnDormir.Enabled = false;
            }
        }
        /// <summary>
        ///  Methode qui creer l'ecran d'ordi
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnOrdi_CheckedChanged(object sender, EventArgs e)
        {
            Ordi o = new Ordi(LaMaison);
            o.Location = new Point(100, 220);
            LaMaison.Acces.Controls.Add(o);
            this.Dispose();
        }
        /// <summary>
        ///  Methode qui gere l'action de dormir
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnDormir_CheckedChanged(object sender, EventArgs e)
        {
            LaMaison.Acces.Dormir();
            if (LaMaison.Heures >= 19 && LaMaison.Heures <= 23)
            {
                if(LaMaison.ADormi == 48)
                {
                    LaMaison.ADormi += 24;
                    LaMaison.CoucherTot = true;
                }
                else
                {
                    LaMaison.ADormi += 48;
                    LaMaison.CoucherTot = false;
                }
            }
            else if (LaMaison.Heures <= 6)
            {
                if (LaMaison.ADormi == 48)
                {
                    LaMaison.ADormi += 24;
                }
                else
                {
                    LaMaison.ADormi += 48;
                }
                LaMaison.CoucherTot = false;
            }
            
            LaMaison.Acces.Refresh();

            LaMaison.FinPause();
            this.Dispose();
        }
        /// <summary>
        /// Methode qui gere l'annuler
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnAnnuler_CheckedChanged(object sender, EventArgs e)
        {
            LaMaison.Acces.FinPause();
            this.Dispose();
        }
    }
}
