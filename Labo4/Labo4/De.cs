using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Labo4
{
    
    public partial class De : UserControl
    {
        public enum Valeur
        {
            UN,
            DEUX,
            TROIS
        };

        private int Resultat;

        private Random Aleatoire;
        public De()
        {
            InitializeComponent();
        }

        private void De_Paint(object sender, PaintEventArgs e)
        {
            SolidBrush Remplir = new SolidBrush(Color.White);
            CreateGraphics().DrawRectangle(Pens.Black, 0, 0, 95, 95);
            CreateGraphics().FillRectangle(Remplir, new Rectangle(1, 1, 94, 94));
            Remplir = new SolidBrush(Color.Black);
            CreateGraphics().FillEllipse(Remplir, new Rectangle(38, 38, 20, 20));
        }

        public void Activer()
        {
            Aleatoire = new Random();  
        }

        public void Rouler()
        {
            Activer();
            Resultat = Aleatoire.Next(0, 3);
            Dessiner();
        }

        private void Dessiner()
        {
            switch (Resultat)
            {
                case 1:
                    RemplirDeux();
                    break;
                case 2:
                    RemplirTrois();
                    break;
                default:
                    RemplirUn();
                    break;
            }
        }

        private void RemplirUn()
        {
            CreateGraphics().Clear(Color.White);
            CreateGraphics().DrawRectangle(Pens.Black, 0, 0, 95, 95);
            SolidBrush Remplir = new SolidBrush(Color.Black);
            CreateGraphics().FillEllipse(Remplir, new Rectangle(38, 38, 20, 20));
            this.Update();
        }

        private void RemplirDeux()
        {
            CreateGraphics().Clear(Color.White);
            CreateGraphics().DrawRectangle(Pens.Black, 0, 0, 95, 95);
            SolidBrush Remplir = new SolidBrush(Color.Black);
            CreateGraphics().FillEllipse(Remplir, new Rectangle(23, 23, 20, 20));
            CreateGraphics().FillEllipse(Remplir, new Rectangle(53, 53, 20, 20));
            this.Update();
        }

        private void RemplirTrois()
        {
            CreateGraphics().Clear(Color.White);
            CreateGraphics().DrawRectangle(Pens.Black, 0, 0, 95, 95);
            SolidBrush Remplir = new SolidBrush(Color.Black);
            CreateGraphics().FillEllipse(Remplir, new Rectangle(10, 10, 20, 20));
            CreateGraphics().FillEllipse(Remplir, new Rectangle(38, 38, 20, 20));
            CreateGraphics().FillEllipse(Remplir, new Rectangle(65, 65, 20, 20));
            
            this.Update();
        }
         public int LeResultat
        {
            get { return Resultat; }
            set { Resultat = value; }
        }
    }
}
