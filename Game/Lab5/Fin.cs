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
    public partial class Fin : UserControl
    {
        private Jardin LeJardin;
        public Fin(Jardin LeJeu, bool _DortPas)
        {
            LeJardin = LeJeu;
            InitializeComponent();
            this.LblArgent.Text = LeJeu.LeJoueur.Disponible.Solde.ToString() +" $";
            if (_DortPas)
            {
                this.LblTextTotal.ForeColor = Color.Black;
                this.BackgroundImage = Lab5.Properties.Resources.grave;
            }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Quit_CheckedChanged(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Restart_CheckedChanged(object sender, EventArgs e)
        {
            LeJardin.Recommencer();
            Dispose();
        }
    }
}
