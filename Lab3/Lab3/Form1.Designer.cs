namespace Lab3
{
    partial class FrmPokemon
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPokemon));
            this.PicLogo = new System.Windows.Forms.PictureBox();
            this.LblNom = new System.Windows.Forms.Label();
            this.LblCode = new System.Windows.Forms.Label();
            this.LblGenre = new System.Windows.Forms.Label();
            this.TxtNom = new System.Windows.Forms.TextBox();
            this.OptMale = new System.Windows.Forms.RadioButton();
            this.OptFemelle = new System.Windows.Forms.RadioButton();
            this.LblGen = new System.Windows.Forms.Label();
            this.CboNumero = new System.Windows.Forms.NumericUpDown();
            this.LstGen = new System.Windows.Forms.ListBox();
            this.LblType = new System.Windows.Forms.Label();
            this.LstType = new System.Windows.Forms.ListBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.MnuFichier = new System.Windows.Forms.ToolStripMenuItem();
            this.MnuNouveau = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.MnuQuitter = new System.Windows.Forms.ToolStripMenuItem();
            this.MnuAPropos = new System.Windows.Forms.ToolStripMenuItem();
            this.MnuAide = new System.Windows.Forms.ToolStripMenuItem();
            this.LblCapturer = new System.Windows.Forms.Label();
            this.OptOui = new System.Windows.Forms.RadioButton();
            this.OptNon = new System.Windows.Forms.RadioButton();
            this.LblProprietaire = new System.Windows.Forms.Label();
            this.TxtProprietaire = new System.Windows.Forms.TextBox();
            this.BtnOk = new System.Windows.Forms.Button();
            this.PnlMaleFemelle = new System.Windows.Forms.Panel();
            this.PnlMain = new System.Windows.Forms.Panel();
            this.PnlCapturer = new System.Windows.Forms.Panel();
            this.ErrGestion = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.PicLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CboNumero)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.PnlMaleFemelle.SuspendLayout();
            this.PnlMain.SuspendLayout();
            this.PnlCapturer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ErrGestion)).BeginInit();
            this.SuspendLayout();
            // 
            // PicLogo
            // 
            this.PicLogo.Image = global::Lab3.Properties.Resources.pokemonLog;
            this.PicLogo.Location = new System.Drawing.Point(113, 24);
            this.PicLogo.Name = "PicLogo";
            this.PicLogo.Size = new System.Drawing.Size(225, 84);
            this.PicLogo.TabIndex = 0;
            this.PicLogo.TabStop = false;
            // 
            // LblNom
            // 
            this.LblNom.AutoSize = true;
            this.LblNom.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.LblNom.Location = new System.Drawing.Point(93, 118);
            this.LblNom.Name = "LblNom";
            this.LblNom.Size = new System.Drawing.Size(35, 13);
            this.LblNom.TabIndex = 6;
            this.LblNom.Text = "Nom :";
            // 
            // LblCode
            // 
            this.LblCode.AutoSize = true;
            this.LblCode.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.LblCode.Location = new System.Drawing.Point(78, 150);
            this.LblCode.Name = "LblCode";
            this.LblCode.Size = new System.Drawing.Size(50, 13);
            this.LblCode.TabIndex = 2;
            this.LblCode.Text = "Numero :";
            // 
            // LblGenre
            // 
            this.LblGenre.AutoSize = true;
            this.LblGenre.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.LblGenre.Location = new System.Drawing.Point(86, 181);
            this.LblGenre.Name = "LblGenre";
            this.LblGenre.Size = new System.Drawing.Size(42, 13);
            this.LblGenre.TabIndex = 3;
            this.LblGenre.Text = "Genre :";
            // 
            // TxtNom
            // 
            this.TxtNom.Location = new System.Drawing.Point(3, 16);
            this.TxtNom.MaxLength = 32;
            this.TxtNom.Name = "TxtNom";
            this.TxtNom.Size = new System.Drawing.Size(152, 20);
            this.TxtNom.TabIndex = 1;
            this.TxtNom.TextChanged += new System.EventHandler(this.TxtNom_TextChanged);
            this.TxtNom.Leave += new System.EventHandler(this.TxtNom_Leave);
            // 
            // OptMale
            // 
            this.OptMale.AutoSize = true;
            this.OptMale.BackColor = System.Drawing.Color.Transparent;
            this.OptMale.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OptMale.Location = new System.Drawing.Point(18, 3);
            this.OptMale.Name = "OptMale";
            this.OptMale.Size = new System.Drawing.Size(52, 17);
            this.OptMale.TabIndex = 0;
            this.OptMale.Text = "Male";
            this.OptMale.UseVisualStyleBackColor = false;
            this.OptMale.CheckedChanged += new System.EventHandler(this.OptMale_CheckedChanged);
            // 
            // OptFemelle
            // 
            this.OptFemelle.AutoSize = true;
            this.OptFemelle.BackColor = System.Drawing.Color.Transparent;
            this.OptFemelle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OptFemelle.Location = new System.Drawing.Point(76, 3);
            this.OptFemelle.Name = "OptFemelle";
            this.OptFemelle.Size = new System.Drawing.Size(68, 17);
            this.OptFemelle.TabIndex = 1;
            this.OptFemelle.Text = "Femelle";
            this.OptFemelle.UseVisualStyleBackColor = false;
            this.OptFemelle.CheckedChanged += new System.EventHandler(this.OptFemelle_CheckedChanged);
            // 
            // LblGen
            // 
            this.LblGen.AutoSize = true;
            this.LblGen.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.LblGen.Location = new System.Drawing.Point(63, 219);
            this.LblGen.Name = "LblGen";
            this.LblGen.Size = new System.Drawing.Size(65, 13);
            this.LblGen.TabIndex = 8;
            this.LblGen.Text = "Generation :";
            // 
            // CboNumero
            // 
            this.CboNumero.Location = new System.Drawing.Point(3, 52);
            this.CboNumero.Maximum = new decimal(new int[] {
            802,
            0,
            0,
            0});
            this.CboNumero.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.CboNumero.Name = "CboNumero";
            this.CboNumero.Size = new System.Drawing.Size(152, 20);
            this.CboNumero.TabIndex = 2;
            this.CboNumero.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.CboNumero.UpDownAlign = System.Windows.Forms.LeftRightAlignment.Left;
            this.CboNumero.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // LstGen
            // 
            this.LstGen.FormattingEnabled = true;
            this.LstGen.Items.AddRange(new object[] {
            "\t1",
            "\t2",
            "\t3",
            "\t4",
            "\t5",
            "\t6",
            "\t7"});
            this.LstGen.Location = new System.Drawing.Point(13, 121);
            this.LstGen.Name = "LstGen";
            this.LstGen.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.LstGen.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.LstGen.Size = new System.Drawing.Size(120, 95);
            this.LstGen.TabIndex = 4;
            this.LstGen.SelectedIndexChanged += new System.EventHandler(this.LstGen_SelectedIndexChanged);
            // 
            // LblType
            // 
            this.LblType.AutoSize = true;
            this.LblType.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.LblType.Location = new System.Drawing.Point(91, 326);
            this.LblType.Name = "LblType";
            this.LblType.Size = new System.Drawing.Size(37, 13);
            this.LblType.TabIndex = 11;
            this.LblType.Text = "Type :";
            // 
            // LstType
            // 
            this.LstType.FormattingEnabled = true;
            this.LstType.Items.AddRange(new object[] {
            "Normal",
            "Eau",
            "Feu",
            "Plante",
            "Electrik",
            "Glace",
            "Combat",
            "Poison",
            "Sol",
            "Psy",
            "Insecte",
            "Roche"});
            this.LstType.Location = new System.Drawing.Point(13, 228);
            this.LstType.Name = "LstType";
            this.LstType.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.LstType.Size = new System.Drawing.Size(120, 95);
            this.LstType.TabIndex = 5;
            this.LstType.SelectedValueChanged += new System.EventHandler(this.LstType_SelectedValueChanged);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MnuFichier,
            this.MnuAPropos});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(408, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // MnuFichier
            // 
            this.MnuFichier.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MnuNouveau,
            this.toolStripSeparator1,
            this.MnuQuitter});
            this.MnuFichier.Name = "MnuFichier";
            this.MnuFichier.Size = new System.Drawing.Size(54, 20);
            this.MnuFichier.Text = "&Fichier";
            // 
            // MnuNouveau
            // 
            this.MnuNouveau.Name = "MnuNouveau";
            this.MnuNouveau.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.MnuNouveau.Size = new System.Drawing.Size(165, 22);
            this.MnuNouveau.Text = "Nouveau";
            this.MnuNouveau.Click += new System.EventHandler(this.MnuNouveau_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(162, 6);
            // 
            // MnuQuitter
            // 
            this.MnuQuitter.Name = "MnuQuitter";
            this.MnuQuitter.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Q)));
            this.MnuQuitter.Size = new System.Drawing.Size(165, 22);
            this.MnuQuitter.Text = "Quitter";
            this.MnuQuitter.Click += new System.EventHandler(this.MnuQuitter_Click);
            // 
            // MnuAPropos
            // 
            this.MnuAPropos.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MnuAide});
            this.MnuAPropos.Name = "MnuAPropos";
            this.MnuAPropos.Size = new System.Drawing.Size(67, 20);
            this.MnuAPropos.Text = "A Propos";
            // 
            // MnuAide
            // 
            this.MnuAide.Name = "MnuAide";
            this.MnuAide.Size = new System.Drawing.Size(98, 22);
            this.MnuAide.Text = "Aide";
            this.MnuAide.Click += new System.EventHandler(this.MnuAide_Click);
            // 
            // LblCapturer
            // 
            this.LblCapturer.AutoSize = true;
            this.LblCapturer.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.LblCapturer.Location = new System.Drawing.Point(75, 438);
            this.LblCapturer.Name = "LblCapturer";
            this.LblCapturer.Size = new System.Drawing.Size(53, 13);
            this.LblCapturer.TabIndex = 13;
            this.LblCapturer.Text = "Capturer :";
            // 
            // OptOui
            // 
            this.OptOui.AutoSize = true;
            this.OptOui.BackColor = System.Drawing.Color.Transparent;
            this.OptOui.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OptOui.Location = new System.Drawing.Point(17, 11);
            this.OptOui.Name = "OptOui";
            this.OptOui.Size = new System.Drawing.Size(44, 17);
            this.OptOui.TabIndex = 0;
            this.OptOui.TabStop = true;
            this.OptOui.Text = "Oui";
            this.OptOui.UseVisualStyleBackColor = false;
            this.OptOui.CheckedChanged += new System.EventHandler(this.OptOui_CheckedChanged);
            // 
            // OptNon
            // 
            this.OptNon.AutoSize = true;
            this.OptNon.BackColor = System.Drawing.Color.Transparent;
            this.OptNon.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OptNon.Location = new System.Drawing.Point(75, 11);
            this.OptNon.Name = "OptNon";
            this.OptNon.Size = new System.Drawing.Size(48, 17);
            this.OptNon.TabIndex = 1;
            this.OptNon.TabStop = true;
            this.OptNon.Text = "Non";
            this.OptNon.UseVisualStyleBackColor = false;
            this.OptNon.CheckedChanged += new System.EventHandler(this.OptNon_CheckedChanged);
            // 
            // LblProprietaire
            // 
            this.LblProprietaire.AutoSize = true;
            this.LblProprietaire.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.LblProprietaire.Location = new System.Drawing.Point(62, 473);
            this.LblProprietaire.Name = "LblProprietaire";
            this.LblProprietaire.Size = new System.Drawing.Size(66, 13);
            this.LblProprietaire.TabIndex = 16;
            this.LblProprietaire.Text = "Proprietaire :";
            this.LblProprietaire.Visible = false;
            // 
            // TxtProprietaire
            // 
            this.TxtProprietaire.Location = new System.Drawing.Point(3, 372);
            this.TxtProprietaire.Name = "TxtProprietaire";
            this.TxtProprietaire.Size = new System.Drawing.Size(152, 20);
            this.TxtProprietaire.TabIndex = 5;
            this.TxtProprietaire.Visible = false;
            this.TxtProprietaire.TextChanged += new System.EventHandler(this.TxtProprietaire_TextChanged);
            // 
            // BtnOk
            // 
            this.BtnOk.BackColor = System.Drawing.Color.White;
            this.BtnOk.BackgroundImage = global::Lab3.Properties.Resources.pokeball;
            this.BtnOk.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BtnOk.Location = new System.Drawing.Point(310, 489);
            this.BtnOk.Name = "BtnOk";
            this.BtnOk.Size = new System.Drawing.Size(43, 39);
            this.BtnOk.TabIndex = 2;
            this.BtnOk.UseVisualStyleBackColor = false;
            this.BtnOk.Click += new System.EventHandler(this.BtnOk_Click);
            // 
            // PnlMaleFemelle
            // 
            this.PnlMaleFemelle.BackColor = System.Drawing.Color.Transparent;
            this.PnlMaleFemelle.Controls.Add(this.OptFemelle);
            this.PnlMaleFemelle.Controls.Add(this.OptMale);
            this.PnlMaleFemelle.Location = new System.Drawing.Point(3, 78);
            this.PnlMaleFemelle.Name = "PnlMaleFemelle";
            this.PnlMaleFemelle.Size = new System.Drawing.Size(152, 30);
            this.PnlMaleFemelle.TabIndex = 3;
            // 
            // PnlMain
            // 
            this.PnlMain.BackColor = System.Drawing.Color.Transparent;
            this.PnlMain.Controls.Add(this.TxtNom);
            this.PnlMain.Controls.Add(this.TxtProprietaire);
            this.PnlMain.Controls.Add(this.PnlMaleFemelle);
            this.PnlMain.Controls.Add(this.CboNumero);
            this.PnlMain.Controls.Add(this.LstGen);
            this.PnlMain.Controls.Add(this.LstType);
            this.PnlMain.Location = new System.Drawing.Point(134, 98);
            this.PnlMain.Name = "PnlMain";
            this.PnlMain.Size = new System.Drawing.Size(170, 407);
            this.PnlMain.TabIndex = 0;
            // 
            // PnlCapturer
            // 
            this.PnlCapturer.BackColor = System.Drawing.Color.Transparent;
            this.PnlCapturer.Controls.Add(this.OptNon);
            this.PnlCapturer.Controls.Add(this.OptOui);
            this.PnlCapturer.Location = new System.Drawing.Point(138, 427);
            this.PnlCapturer.Name = "PnlCapturer";
            this.PnlCapturer.Size = new System.Drawing.Size(163, 31);
            this.PnlCapturer.TabIndex = 1;
            // 
            // ErrGestion
            // 
            this.ErrGestion.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.ErrGestion.ContainerControl = this;
            // 
            // FrmPokemon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackgroundImage = global::Lab3.Properties.Resources.BackEdit;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(408, 549);
            this.Controls.Add(this.PnlCapturer);
            this.Controls.Add(this.PnlMain);
            this.Controls.Add(this.BtnOk);
            this.Controls.Add(this.LblProprietaire);
            this.Controls.Add(this.LblCapturer);
            this.Controls.Add(this.LblType);
            this.Controls.Add(this.LblGen);
            this.Controls.Add(this.LblGenre);
            this.Controls.Add(this.LblCode);
            this.Controls.Add(this.LblNom);
            this.Controls.Add(this.PicLogo);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FrmPokemon";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pokemon";
            ((System.ComponentModel.ISupportInitialize)(this.PicLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CboNumero)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.PnlMaleFemelle.ResumeLayout(false);
            this.PnlMaleFemelle.PerformLayout();
            this.PnlMain.ResumeLayout(false);
            this.PnlMain.PerformLayout();
            this.PnlCapturer.ResumeLayout(false);
            this.PnlCapturer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ErrGestion)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox PicLogo;
        private System.Windows.Forms.Label LblNom;
        private System.Windows.Forms.Label LblCode;
        private System.Windows.Forms.Label LblGenre;
        private System.Windows.Forms.TextBox TxtNom;
        private System.Windows.Forms.RadioButton OptMale;
        private System.Windows.Forms.RadioButton OptFemelle;
        private System.Windows.Forms.Label LblGen;
        private System.Windows.Forms.NumericUpDown CboNumero;
        private System.Windows.Forms.ListBox LstGen;
        private System.Windows.Forms.Label LblType;
        private System.Windows.Forms.ListBox LstType;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem MnuFichier;
        private System.Windows.Forms.ToolStripMenuItem MnuNouveau;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem MnuQuitter;
        private System.Windows.Forms.ToolStripMenuItem MnuAPropos;
        private System.Windows.Forms.ToolStripMenuItem MnuAide;
        private System.Windows.Forms.Label LblCapturer;
        private System.Windows.Forms.RadioButton OptOui;
        private System.Windows.Forms.RadioButton OptNon;
        private System.Windows.Forms.Label LblProprietaire;
        private System.Windows.Forms.TextBox TxtProprietaire;
        private System.Windows.Forms.Button BtnOk;
        private System.Windows.Forms.Panel PnlMaleFemelle;
        private System.Windows.Forms.Panel PnlMain;
        private System.Windows.Forms.Panel PnlCapturer;
        private System.Windows.Forms.ErrorProvider ErrGestion;
    }
}

