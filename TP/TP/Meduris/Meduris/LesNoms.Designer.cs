namespace Meduris
{
    partial class FrmNoms
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.BtnOK = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.TxtNom = new System.Windows.Forms.TextBox();
            this.GrNoms = new System.Windows.Forms.GroupBox();
            this.PnlCouleur = new System.Windows.Forms.GroupBox();
            this.ChkCouleur2 = new System.Windows.Forms.CheckBox();
            this.ChkCouleur5 = new System.Windows.Forms.CheckBox();
            this.ChkCouleur4 = new System.Windows.Forms.CheckBox();
            this.ChkCouleur3 = new System.Windows.Forms.CheckBox();
            this.ChkCouleur1 = new System.Windows.Forms.CheckBox();
            this.ChkCouleur0 = new System.Windows.Forms.CheckBox();
            this.BtnAnnuler = new System.Windows.Forms.Button();
            this.ErrNom = new System.Windows.Forms.ErrorProvider(this.components);
            this.GrNoms.SuspendLayout();
            this.PnlCouleur.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ErrNom)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnOK
            // 
            this.BtnOK.Location = new System.Drawing.Point(196, 267);
            this.BtnOK.Name = "BtnOK";
            this.BtnOK.Size = new System.Drawing.Size(52, 26);
            this.BtnOK.TabIndex = 0;
            this.BtnOK.Text = "OK";
            this.BtnOK.UseVisualStyleBackColor = true;
            this.BtnOK.Click += new System.EventHandler(this.ButtonOk_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nom :";
            // 
            // TxtNom
            // 
            this.TxtNom.Location = new System.Drawing.Point(67, 27);
            this.TxtNom.Name = "TxtNom";
            this.TxtNom.Size = new System.Drawing.Size(163, 23);
            this.TxtNom.TabIndex = 2;
            // 
            // GrNoms
            // 
            this.GrNoms.BackColor = System.Drawing.Color.Transparent;
            this.GrNoms.Controls.Add(this.label1);
            this.GrNoms.Controls.Add(this.TxtNom);
            this.GrNoms.Font = new System.Drawing.Font("Constantia", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GrNoms.Location = new System.Drawing.Point(62, 12);
            this.GrNoms.Name = "GrNoms";
            this.GrNoms.Size = new System.Drawing.Size(257, 80);
            this.GrNoms.TabIndex = 3;
            this.GrNoms.TabStop = false;
            this.GrNoms.Text = "Joueur 1";
            // 
            // PnlCouleur
            // 
            this.PnlCouleur.BackColor = System.Drawing.Color.Transparent;
            this.PnlCouleur.Controls.Add(this.ChkCouleur2);
            this.PnlCouleur.Controls.Add(this.ChkCouleur5);
            this.PnlCouleur.Controls.Add(this.ChkCouleur4);
            this.PnlCouleur.Controls.Add(this.ChkCouleur3);
            this.PnlCouleur.Controls.Add(this.ChkCouleur1);
            this.PnlCouleur.Controls.Add(this.ChkCouleur0);
            this.PnlCouleur.Font = new System.Drawing.Font("Constantia", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PnlCouleur.Location = new System.Drawing.Point(62, 98);
            this.PnlCouleur.Name = "PnlCouleur";
            this.PnlCouleur.Size = new System.Drawing.Size(257, 151);
            this.PnlCouleur.TabIndex = 4;
            this.PnlCouleur.TabStop = false;
            this.PnlCouleur.Text = "Couleur";
            // 
            // ChkCouleur2
            // 
            this.ChkCouleur2.Appearance = System.Windows.Forms.Appearance.Button;
            this.ChkCouleur2.BackColor = System.Drawing.Color.ForestGreen;
            this.ChkCouleur2.BackgroundImage = global::Meduris.Properties.Resources.meeple_vert;
            this.ChkCouleur2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ChkCouleur2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ChkCouleur2.Location = new System.Drawing.Point(180, 22);
            this.ChkCouleur2.Name = "ChkCouleur2";
            this.ChkCouleur2.Size = new System.Drawing.Size(50, 42);
            this.ChkCouleur2.TabIndex = 3;
            this.ChkCouleur2.Tag = "3";
            this.ChkCouleur2.UseVisualStyleBackColor = false;
            this.ChkCouleur2.Click += new System.EventHandler(this.ChkCouleurs_Click);
            // 
            // ChkCouleur5
            // 
            this.ChkCouleur5.Appearance = System.Windows.Forms.Appearance.Button;
            this.ChkCouleur5.BackColor = System.Drawing.Color.Cyan;
            this.ChkCouleur5.BackgroundImage = global::Meduris.Properties.Resources.meeple_turquoise;
            this.ChkCouleur5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ChkCouleur5.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ChkCouleur5.Location = new System.Drawing.Point(180, 79);
            this.ChkCouleur5.Name = "ChkCouleur5";
            this.ChkCouleur5.Size = new System.Drawing.Size(50, 42);
            this.ChkCouleur5.TabIndex = 5;
            this.ChkCouleur5.Tag = "6";
            this.ChkCouleur5.UseVisualStyleBackColor = false;
            this.ChkCouleur5.Click += new System.EventHandler(this.ChkCouleurs_Click);
            // 
            // ChkCouleur4
            // 
            this.ChkCouleur4.Appearance = System.Windows.Forms.Appearance.Button;
            this.ChkCouleur4.BackColor = System.Drawing.Color.BlueViolet;
            this.ChkCouleur4.BackgroundImage = global::Meduris.Properties.Resources.meeple_violet;
            this.ChkCouleur4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ChkCouleur4.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ChkCouleur4.Location = new System.Drawing.Point(107, 79);
            this.ChkCouleur4.Name = "ChkCouleur4";
            this.ChkCouleur4.Size = new System.Drawing.Size(50, 42);
            this.ChkCouleur4.TabIndex = 5;
            this.ChkCouleur4.Tag = "5";
            this.ChkCouleur4.UseVisualStyleBackColor = false;
            this.ChkCouleur4.Click += new System.EventHandler(this.ChkCouleurs_Click);
            // 
            // ChkCouleur3
            // 
            this.ChkCouleur3.Appearance = System.Windows.Forms.Appearance.Button;
            this.ChkCouleur3.BackColor = System.Drawing.Color.Gold;
            this.ChkCouleur3.BackgroundImage = global::Meduris.Properties.Resources.meeple_jaune;
            this.ChkCouleur3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ChkCouleur3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ChkCouleur3.Location = new System.Drawing.Point(30, 79);
            this.ChkCouleur3.Name = "ChkCouleur3";
            this.ChkCouleur3.Size = new System.Drawing.Size(50, 42);
            this.ChkCouleur3.TabIndex = 2;
            this.ChkCouleur3.Tag = "4";
            this.ChkCouleur3.UseVisualStyleBackColor = false;
            this.ChkCouleur3.Click += new System.EventHandler(this.ChkCouleurs_Click);
            // 
            // ChkCouleur1
            // 
            this.ChkCouleur1.Appearance = System.Windows.Forms.Appearance.Button;
            this.ChkCouleur1.BackColor = System.Drawing.Color.RoyalBlue;
            this.ChkCouleur1.BackgroundImage = global::Meduris.Properties.Resources.meeple_bleu;
            this.ChkCouleur1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ChkCouleur1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ChkCouleur1.Location = new System.Drawing.Point(107, 22);
            this.ChkCouleur1.Name = "ChkCouleur1";
            this.ChkCouleur1.Size = new System.Drawing.Size(50, 42);
            this.ChkCouleur1.TabIndex = 1;
            this.ChkCouleur1.Tag = "2";
            this.ChkCouleur1.Text = "1";
            this.ChkCouleur1.UseVisualStyleBackColor = false;
            this.ChkCouleur1.Click += new System.EventHandler(this.ChkCouleurs_Click);
            // 
            // ChkCouleur0
            // 
            this.ChkCouleur0.Appearance = System.Windows.Forms.Appearance.Button;
            this.ChkCouleur0.BackColor = System.Drawing.Color.Maroon;
            this.ChkCouleur0.BackgroundImage = global::Meduris.Properties.Resources.meeple_rouge;
            this.ChkCouleur0.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ChkCouleur0.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ChkCouleur0.Location = new System.Drawing.Point(30, 22);
            this.ChkCouleur0.Name = "ChkCouleur0";
            this.ChkCouleur0.Size = new System.Drawing.Size(50, 42);
            this.ChkCouleur0.TabIndex = 0;
            this.ChkCouleur0.Tag = "1";
            this.ChkCouleur0.UseVisualStyleBackColor = false;
            this.ChkCouleur0.Click += new System.EventHandler(this.ChkCouleurs_Click);
            // 
            // BtnAnnuler
            // 
            this.BtnAnnuler.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.BtnAnnuler.Location = new System.Drawing.Point(254, 267);
            this.BtnAnnuler.Name = "BtnAnnuler";
            this.BtnAnnuler.Size = new System.Drawing.Size(65, 26);
            this.BtnAnnuler.TabIndex = 5;
            this.BtnAnnuler.Text = "Annuler";
            this.BtnAnnuler.UseVisualStyleBackColor = true;
            this.BtnAnnuler.Click += new System.EventHandler(this.BtnAnnuler_Click);
            // 
            // ErrNom
            // 
            this.ErrNom.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.ErrNom.ContainerControl = this;
            // 
            // FrmNoms
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.BurlyWood;
            this.BackgroundImage = global::Meduris.Properties.Resources.SasieNom1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.CancelButton = this.BtnAnnuler;
            this.ClientSize = new System.Drawing.Size(377, 331);
            this.Controls.Add(this.BtnAnnuler);
            this.Controls.Add(this.PnlCouleur);
            this.Controls.Add(this.GrNoms);
            this.Controls.Add(this.BtnOK);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.Name = "FrmNoms";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Meduris";
            this.GrNoms.ResumeLayout(false);
            this.GrNoms.PerformLayout();
            this.PnlCouleur.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ErrNom)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtnOK;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtNom;
        private System.Windows.Forms.GroupBox GrNoms;
        private System.Windows.Forms.GroupBox PnlCouleur;
        private System.Windows.Forms.CheckBox ChkCouleur3;
        private System.Windows.Forms.CheckBox ChkCouleur1;
        private System.Windows.Forms.CheckBox ChkCouleur0;
        private System.Windows.Forms.CheckBox ChkCouleur2;
        private System.Windows.Forms.CheckBox ChkCouleur4;
        private System.Windows.Forms.CheckBox ChkCouleur5;
        private System.Windows.Forms.Button BtnAnnuler;
        private System.Windows.Forms.ErrorProvider ErrNom;
    }
}

