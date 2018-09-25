using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            MessageBox.Show("Pour vous deplacer utiliser les control A-W-S-D");
            InitializeComponent();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {

        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {

        }

        private void Form1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {

        }

        private void recommencerToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.jardin2.EnPause();
            jardin2.Recommencer();
        }

        private void aProposToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Programmeur: Edwin Andino");
        }

        private void quitterToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            this.jardin2.EnPause();
            Fin Fin = new Fin(jardin2, false);
            Fin.Location = new Point(180, 280);
            jardin2.Controls.Add(Fin);
        }
    }
}
