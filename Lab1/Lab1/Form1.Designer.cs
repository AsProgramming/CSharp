namespace Lab1
{
    partial class FrmWtMenu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.ImgWtDonald = new System.Windows.Forms.PictureBox();
            this.BtnTheme = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.MnuFichier = new System.Windows.Forms.ToolStripMenuItem();
            this.MnuReinitialiser = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.MnuQuitter = new System.Windows.Forms.ToolStripMenuItem();
            this.MnuAide = new System.Windows.Forms.ToolStripMenuItem();
            this.MnuApropos = new System.Windows.Forms.ToolStripMenuItem();
            this.DialogCouleurs = new System.Windows.Forms.ColorDialog();
            this.GbSaisie = new System.Windows.Forms.GroupBox();
            this.LblBreuvage = new System.Windows.Forms.Label();
            this.LblAccompagnement = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.CboBreuvage = new System.Windows.Forms.ComboBox();
            this.BtnBreuvage = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.LstAccompagnement = new System.Windows.Forms.ListBox();
            this.BtnAccompagnement = new System.Windows.Forms.Button();
            this.LblModification = new System.Windows.Forms.Label();
            this.PnlBigWac = new System.Windows.Forms.Panel();
            this.BtnAjoutModifier = new System.Windows.Forms.Button();
            this.TxtBas = new System.Windows.Forms.TextBox();
            this.TxtBasMillieu = new System.Windows.Forms.TextBox();
            this.TxtHautMilieu = new System.Windows.Forms.TextBox();
            this.TxtHaut = new System.Windows.Forms.TextBox();
            this.GbConfirmer = new System.Windows.Forms.GroupBox();
            this.BtnSupprimer = new System.Windows.Forms.Button();
            this.LsChkCommander = new System.Windows.Forms.CheckedListBox();
            this.ImgBigWac = new System.Windows.Forms.PictureBox();
            this.BtnCommander = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ImgWtDonald)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.GbSaisie.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.PnlBigWac.SuspendLayout();
            this.GbConfirmer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ImgBigWac)).BeginInit();
            this.SuspendLayout();
            // 
            // ImgWtDonald
            // 
            this.ImgWtDonald.Image = global::Lab1.Properties.Resources.logo_small;
            this.ImgWtDonald.Location = new System.Drawing.Point(293, 50);
            this.ImgWtDonald.Name = "ImgWtDonald";
            this.ImgWtDonald.Size = new System.Drawing.Size(100, 94);
            this.ImgWtDonald.TabIndex = 0;
            this.ImgWtDonald.TabStop = false;
            // 
            // BtnTheme
            // 
            this.BtnTheme.Location = new System.Drawing.Point(610, 50);
            this.BtnTheme.Name = "BtnTheme";
            this.BtnTheme.Size = new System.Drawing.Size(75, 70);
            this.BtnTheme.TabIndex = 10;
            this.BtnTheme.Text = "Changer le theme";
            this.BtnTheme.UseVisualStyleBackColor = true;
            this.BtnTheme.Click += new System.EventHandler(this.BtnTheme_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MnuFichier,
            this.MnuAide});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(698, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // MnuFichier
            // 
            this.MnuFichier.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MnuReinitialiser,
            this.toolStripSeparator1,
            this.MnuQuitter});
            this.MnuFichier.Name = "MnuFichier";
            this.MnuFichier.Size = new System.Drawing.Size(54, 20);
            this.MnuFichier.Text = "&Fichier";
            // 
            // MnuReinitialiser
            // 
            this.MnuReinitialiser.Name = "MnuReinitialiser";
            this.MnuReinitialiser.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.R)));
            this.MnuReinitialiser.Size = new System.Drawing.Size(175, 22);
            this.MnuReinitialiser.Text = "Reinitialiser";
            this.MnuReinitialiser.Click += new System.EventHandler(this.MnuReinitialiser_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(172, 6);
            // 
            // MnuQuitter
            // 
            this.MnuQuitter.Name = "MnuQuitter";
            this.MnuQuitter.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Q)));
            this.MnuQuitter.Size = new System.Drawing.Size(175, 22);
            this.MnuQuitter.Text = "Quitter";
            this.MnuQuitter.Click += new System.EventHandler(this.quitterToolStripMenuItem_Click);
            // 
            // MnuAide
            // 
            this.MnuAide.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MnuApropos});
            this.MnuAide.Name = "MnuAide";
            this.MnuAide.Size = new System.Drawing.Size(43, 20);
            this.MnuAide.Text = "&Aide";
            // 
            // MnuApropos
            // 
            this.MnuApropos.Name = "MnuApropos";
            this.MnuApropos.Size = new System.Drawing.Size(122, 22);
            this.MnuApropos.Text = "A Propos";
            this.MnuApropos.Click += new System.EventHandler(this.aProposToolStripMenuItem_Click);
            // 
            // DialogCouleurs
            // 
            this.DialogCouleurs.AnyColor = true;
            // 
            // GbSaisie
            // 
            this.GbSaisie.Controls.Add(this.LblBreuvage);
            this.GbSaisie.Controls.Add(this.LblAccompagnement);
            this.GbSaisie.Controls.Add(this.panel3);
            this.GbSaisie.Controls.Add(this.panel2);
            this.GbSaisie.Controls.Add(this.LblModification);
            this.GbSaisie.Controls.Add(this.PnlBigWac);
            this.GbSaisie.Location = new System.Drawing.Point(12, 162);
            this.GbSaisie.Name = "GbSaisie";
            this.GbSaisie.Size = new System.Drawing.Size(673, 261);
            this.GbSaisie.TabIndex = 3;
            this.GbSaisie.TabStop = false;
            this.GbSaisie.Text = "Saisir votre commande :";
            // 
            // LblBreuvage
            // 
            this.LblBreuvage.AutoSize = true;
            this.LblBreuvage.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblBreuvage.Location = new System.Drawing.Point(519, 28);
            this.LblBreuvage.Name = "LblBreuvage";
            this.LblBreuvage.Size = new System.Drawing.Size(69, 13);
            this.LblBreuvage.TabIndex = 5;
            this.LblBreuvage.Text = "Breuvage :";
            // 
            // LblAccompagnement
            // 
            this.LblAccompagnement.AutoSize = true;
            this.LblAccompagnement.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblAccompagnement.Location = new System.Drawing.Point(289, 31);
            this.LblAccompagnement.Name = "LblAccompagnement";
            this.LblAccompagnement.Size = new System.Drawing.Size(121, 13);
            this.LblAccompagnement.TabIndex = 4;
            this.LblAccompagnement.Text = "Accompagnements :";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel3.Controls.Add(this.CboBreuvage);
            this.panel3.Controls.Add(this.BtnBreuvage);
            this.panel3.Location = new System.Drawing.Point(459, 47);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(197, 199);
            this.panel3.TabIndex = 3;
            // 
            // CboBreuvage
            // 
            this.CboBreuvage.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CboBreuvage.FormattingEnabled = true;
            this.CboBreuvage.Items.AddRange(new object[] {
            "7Up",
            "Coca-Cola",
            "Coke Zero",
            "Fruitopia",
            "Orange Crush",
            "Barq\'s",
            "Eau"});
            this.CboBreuvage.Location = new System.Drawing.Point(20, 13);
            this.CboBreuvage.MaxDropDownItems = 7;
            this.CboBreuvage.Name = "CboBreuvage";
            this.CboBreuvage.Size = new System.Drawing.Size(164, 21);
            this.CboBreuvage.TabIndex = 5;
            this.CboBreuvage.Tag = "";
            // 
            // BtnBreuvage
            // 
            this.BtnBreuvage.Location = new System.Drawing.Point(94, 159);
            this.BtnBreuvage.Name = "BtnBreuvage";
            this.BtnBreuvage.Size = new System.Drawing.Size(90, 23);
            this.BtnBreuvage.TabIndex = 6;
            this.BtnBreuvage.Text = "Ajouter";
            this.BtnBreuvage.UseVisualStyleBackColor = true;
            this.BtnBreuvage.Click += new System.EventHandler(this.BtnBreuvage_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel2.Controls.Add(this.LstAccompagnement);
            this.panel2.Controls.Add(this.BtnAccompagnement);
            this.panel2.Location = new System.Drawing.Point(233, 47);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(220, 199);
            this.panel2.TabIndex = 2;
            // 
            // LstAccompagnement
            // 
            this.LstAccompagnement.FormattingEnabled = true;
            this.LstAccompagnement.Items.AddRange(new object[] {
            "Frites",
            "Grosse Frite",
            "Poutine",
            "Petite salade",
            "Salade"});
            this.LstAccompagnement.Location = new System.Drawing.Point(20, 13);
            this.LstAccompagnement.Name = "LstAccompagnement";
            this.LstAccompagnement.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.LstAccompagnement.Size = new System.Drawing.Size(180, 134);
            this.LstAccompagnement.TabIndex = 5;
            // 
            // BtnAccompagnement
            // 
            this.BtnAccompagnement.Location = new System.Drawing.Point(107, 159);
            this.BtnAccompagnement.Name = "BtnAccompagnement";
            this.BtnAccompagnement.Size = new System.Drawing.Size(93, 23);
            this.BtnAccompagnement.TabIndex = 6;
            this.BtnAccompagnement.Text = "Ajouter";
            this.BtnAccompagnement.UseVisualStyleBackColor = true;
            this.BtnAccompagnement.Click += new System.EventHandler(this.BtnAccompagnement_Click);
            // 
            // LblModification
            // 
            this.LblModification.AutoSize = true;
            this.LblModification.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblModification.Location = new System.Drawing.Point(43, 31);
            this.LblModification.Name = "LblModification";
            this.LblModification.Size = new System.Drawing.Size(160, 13);
            this.LblModification.TabIndex = 1;
            this.LblModification.Text = "Modifications au Big Wac :";
            // 
            // PnlBigWac
            // 
            this.PnlBigWac.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.PnlBigWac.Controls.Add(this.BtnAjoutModifier);
            this.PnlBigWac.Controls.Add(this.TxtBas);
            this.PnlBigWac.Controls.Add(this.TxtBasMillieu);
            this.PnlBigWac.Controls.Add(this.TxtHautMilieu);
            this.PnlBigWac.Controls.Add(this.TxtHaut);
            this.PnlBigWac.Location = new System.Drawing.Point(18, 47);
            this.PnlBigWac.Name = "PnlBigWac";
            this.PnlBigWac.Size = new System.Drawing.Size(209, 199);
            this.PnlBigWac.TabIndex = 0;
            // 
            // BtnAjoutModifier
            // 
            this.BtnAjoutModifier.Location = new System.Drawing.Point(97, 159);
            this.BtnAjoutModifier.Name = "BtnAjoutModifier";
            this.BtnAjoutModifier.Size = new System.Drawing.Size(96, 23);
            this.BtnAjoutModifier.TabIndex = 5;
            this.BtnAjoutModifier.Text = "Ajouter";
            this.BtnAjoutModifier.UseVisualStyleBackColor = true;
            this.BtnAjoutModifier.Click += new System.EventHandler(this.BtnAjoutModifier_Click);
            // 
            // TxtBas
            // 
            this.TxtBas.Location = new System.Drawing.Point(14, 122);
            this.TxtBas.Name = "TxtBas";
            this.TxtBas.Size = new System.Drawing.Size(179, 20);
            this.TxtBas.TabIndex = 4;
            // 
            // TxtBasMillieu
            // 
            this.TxtBasMillieu.Location = new System.Drawing.Point(14, 87);
            this.TxtBasMillieu.Name = "TxtBasMillieu";
            this.TxtBasMillieu.Size = new System.Drawing.Size(179, 20);
            this.TxtBasMillieu.TabIndex = 3;
            // 
            // TxtHautMilieu
            // 
            this.TxtHautMilieu.Location = new System.Drawing.Point(14, 52);
            this.TxtHautMilieu.Name = "TxtHautMilieu";
            this.TxtHautMilieu.Size = new System.Drawing.Size(179, 20);
            this.TxtHautMilieu.TabIndex = 2;
            // 
            // TxtHaut
            // 
            this.TxtHaut.Location = new System.Drawing.Point(14, 13);
            this.TxtHaut.Name = "TxtHaut";
            this.TxtHaut.Size = new System.Drawing.Size(179, 20);
            this.TxtHaut.TabIndex = 0;
            // 
            // GbConfirmer
            // 
            this.GbConfirmer.Controls.Add(this.BtnSupprimer);
            this.GbConfirmer.Controls.Add(this.LsChkCommander);
            this.GbConfirmer.Controls.Add(this.ImgBigWac);
            this.GbConfirmer.Location = new System.Drawing.Point(12, 443);
            this.GbConfirmer.Name = "GbConfirmer";
            this.GbConfirmer.Size = new System.Drawing.Size(673, 210);
            this.GbConfirmer.TabIndex = 4;
            this.GbConfirmer.TabStop = false;
            this.GbConfirmer.Text = "Confirmer votre commande :";
            // 
            // BtnSupprimer
            // 
            this.BtnSupprimer.Enabled = false;
            this.BtnSupprimer.Location = new System.Drawing.Point(530, 179);
            this.BtnSupprimer.Name = "BtnSupprimer";
            this.BtnSupprimer.Size = new System.Drawing.Size(126, 23);
            this.BtnSupprimer.TabIndex = 2;
            this.BtnSupprimer.Text = "Supprimer si coche(s)";
            this.BtnSupprimer.UseVisualStyleBackColor = true;
            this.BtnSupprimer.Click += new System.EventHandler(this.BtnSupprimer_Click);
            // 
            // LsChkCommander
            // 
            this.LsChkCommander.FormattingEnabled = true;
            this.LsChkCommander.Location = new System.Drawing.Point(233, 19);
            this.LsChkCommander.Name = "LsChkCommander";
            this.LsChkCommander.Size = new System.Drawing.Size(423, 154);
            this.LsChkCommander.Sorted = true;
            this.LsChkCommander.TabIndex = 1;
            // 
            // ImgBigWac
            // 
            this.ImgBigWac.Image = global::Lab1.Properties.Resources.bigwac;
            this.ImgBigWac.Location = new System.Drawing.Point(18, 31);
            this.ImgBigWac.Name = "ImgBigWac";
            this.ImgBigWac.Size = new System.Drawing.Size(193, 133);
            this.ImgBigWac.TabIndex = 0;
            this.ImgBigWac.TabStop = false;
            // 
            // BtnCommander
            // 
            this.BtnCommander.BackColor = System.Drawing.Color.LightGreen;
            this.BtnCommander.Location = new System.Drawing.Point(542, 658);
            this.BtnCommander.Name = "BtnCommander";
            this.BtnCommander.Size = new System.Drawing.Size(126, 23);
            this.BtnCommander.TabIndex = 5;
            this.BtnCommander.Text = "Commander";
            this.BtnCommander.UseVisualStyleBackColor = false;
            this.BtnCommander.Click += new System.EventHandler(this.BtnCommander_Click);
            // 
            // FrmWtMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(698, 693);
            this.Controls.Add(this.BtnCommander);
            this.Controls.Add(this.GbConfirmer);
            this.Controls.Add(this.GbSaisie);
            this.Controls.Add(this.BtnTheme);
            this.Controls.Add(this.ImgWtDonald);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FrmWtMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bienvenue chez WtDonald !";
            ((System.ComponentModel.ISupportInitialize)(this.ImgWtDonald)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.GbSaisie.ResumeLayout(false);
            this.GbSaisie.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.PnlBigWac.ResumeLayout(false);
            this.PnlBigWac.PerformLayout();
            this.GbConfirmer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ImgBigWac)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox ImgWtDonald;
        private System.Windows.Forms.Button BtnTheme;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem MnuFichier;
        private System.Windows.Forms.ToolStripMenuItem MnuReinitialiser;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem MnuQuitter;
        private System.Windows.Forms.ToolStripMenuItem MnuAide;
        private System.Windows.Forms.ToolStripMenuItem MnuApropos;
        public System.Windows.Forms.ColorDialog DialogCouleurs;
        private System.Windows.Forms.GroupBox GbSaisie;
        private System.Windows.Forms.Label LblModification;
        private System.Windows.Forms.Panel PnlBigWac;
        private System.Windows.Forms.Button BtnAjoutModifier;
        private System.Windows.Forms.TextBox TxtBas;
        private System.Windows.Forms.TextBox TxtBasMillieu;
        private System.Windows.Forms.TextBox TxtHautMilieu;
        private System.Windows.Forms.TextBox TxtHaut;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button BtnBreuvage;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button BtnAccompagnement;
        private System.Windows.Forms.ListBox LstAccompagnement;
        private System.Windows.Forms.Label LblBreuvage;
        private System.Windows.Forms.Label LblAccompagnement;
        private System.Windows.Forms.ComboBox CboBreuvage;
        private System.Windows.Forms.GroupBox GbConfirmer;
        private System.Windows.Forms.CheckedListBox LsChkCommander;
        private System.Windows.Forms.PictureBox ImgBigWac;
        private System.Windows.Forms.Button BtnSupprimer;
        private System.Windows.Forms.Button BtnCommander;
    }
}

