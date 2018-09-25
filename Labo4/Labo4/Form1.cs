using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Labo4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            CustDe.Activer();
            Verifier();
        }

        private void de1_Click(object sender, EventArgs e)
        {
            CustDe.Rouler();
        }

        private void de2_Load(object sender, EventArgs e)
        {
            CustDe2.Rouler();
        }

        private void de3_Load(object sender, EventArgs e)
        {
            CustDe3.Activer();
            CustDe3.Rouler();
        }

        private void BtnRouler_Click(object sender, EventArgs e)
        {
            CustDe2.Activer();
            CustDe.Rouler();
            CustDe2.Rouler();
            CustDe3.Rouler();
        }

        private void CustDe2_Click(object sender, EventArgs e)
        {
            CustDe2.Rouler();
        }

        private void CustDe3_Click(object sender, EventArgs e)
        {
            CustDe3.Rouler();
        }

        private void Verifier()
        {
            if(CustDe.LeResultat == CustDe2.LeResultat 
                && CustDe.LeResultat == CustDe3.LeResultat)
            {
                CustDe.LeResultat = 2;
            }
        }
    }
}
