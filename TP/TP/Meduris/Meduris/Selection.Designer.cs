namespace Meduris
{
    partial class Selection
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
            this.BtnDeux = new System.Windows.Forms.CheckBox();
            this.BtnUne = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.GrRessources = new System.Windows.Forms.GroupBox();
            this.PicRess1 = new System.Windows.Forms.PictureBox();
            this.PicRess2 = new System.Windows.Forms.PictureBox();
            this.LblNom = new System.Windows.Forms.Label();
            this.TxtRessource = new System.Windows.Forms.TextBox();
            this.TxtRessource2 = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.GrRessources.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PicRess1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicRess2)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnDeux
            // 
            this.BtnDeux.Appearance = System.Windows.Forms.Appearance.Button;
            this.BtnDeux.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BtnDeux.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnDeux.Location = new System.Drawing.Point(75, 22);
            this.BtnDeux.Name = "BtnDeux";
            this.BtnDeux.Size = new System.Drawing.Size(52, 38);
            this.BtnDeux.TabIndex = 1;
            this.BtnDeux.UseVisualStyleBackColor = true;
            this.BtnDeux.Click += new System.EventHandler(this.BtnDeux_Click);
            // 
            // BtnUne
            // 
            this.BtnUne.Appearance = System.Windows.Forms.Appearance.Button;
            this.BtnUne.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BtnUne.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnUne.Location = new System.Drawing.Point(17, 22);
            this.BtnUne.Name = "BtnUne";
            this.BtnUne.Size = new System.Drawing.Size(52, 38);
            this.BtnUne.TabIndex = 0;
            this.BtnUne.UseVisualStyleBackColor = true;
            this.BtnUne.Click += new System.EventHandler(this.BtnUne_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.BtnUne);
            this.groupBox1.Controls.Add(this.BtnDeux);
            this.groupBox1.Font = new System.Drawing.Font("Constantia", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBox1.Location = new System.Drawing.Point(6, 162);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(139, 76);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Choix";
            // 
            // GrRessources
            // 
            this.GrRessources.BackColor = System.Drawing.Color.Transparent;
            this.GrRessources.Controls.Add(this.TxtRessource2);
            this.GrRessources.Controls.Add(this.TxtRessource);
            this.GrRessources.Controls.Add(this.LblNom);
            this.GrRessources.Controls.Add(this.PicRess2);
            this.GrRessources.Controls.Add(this.PicRess1);
            this.GrRessources.Font = new System.Drawing.Font("Constantia", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GrRessources.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.GrRessources.Location = new System.Drawing.Point(6, 12);
            this.GrRessources.Name = "GrRessources";
            this.GrRessources.Size = new System.Drawing.Size(139, 144);
            this.GrRessources.TabIndex = 3;
            this.GrRessources.TabStop = false;
            this.GrRessources.Text = "Disponible";
            // 
            // PicRess1
            // 
            this.PicRess1.Location = new System.Drawing.Point(17, 44);
            this.PicRess1.Name = "PicRess1";
            this.PicRess1.Size = new System.Drawing.Size(52, 42);
            this.PicRess1.TabIndex = 0;
            this.PicRess1.TabStop = false;
            // 
            // PicRess2
            // 
            this.PicRess2.Location = new System.Drawing.Point(17, 92);
            this.PicRess2.Name = "PicRess2";
            this.PicRess2.Size = new System.Drawing.Size(52, 42);
            this.PicRess2.TabIndex = 1;
            this.PicRess2.TabStop = false;
            // 
            // LblNom
            // 
            this.LblNom.AutoSize = true;
            this.LblNom.Location = new System.Drawing.Point(52, 21);
            this.LblNom.Name = "LblNom";
            this.LblNom.Size = new System.Drawing.Size(42, 15);
            this.LblNom.TabIndex = 2;
            this.LblNom.Text = "label1";
            // 
            // TxtRessource
            // 
            this.TxtRessource.Location = new System.Drawing.Point(84, 52);
            this.TxtRessource.Name = "TxtRessource";
            this.TxtRessource.ReadOnly = true;
            this.TxtRessource.Size = new System.Drawing.Size(32, 23);
            this.TxtRessource.TabIndex = 3;
            // 
            // TxtRessource2
            // 
            this.TxtRessource2.Location = new System.Drawing.Point(84, 99);
            this.TxtRessource2.Name = "TxtRessource2";
            this.TxtRessource2.ReadOnly = true;
            this.TxtRessource2.Size = new System.Drawing.Size(32, 23);
            this.TxtRessource2.TabIndex = 4;
            // 
            // Selection
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Meduris.Properties.Resources.Construction;
            this.ClientSize = new System.Drawing.Size(157, 257);
            this.Controls.Add(this.GrRessources);
            this.Controls.Add(this.groupBox1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Selection";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Choix";
            this.groupBox1.ResumeLayout(false);
            this.GrRessources.ResumeLayout(false);
            this.GrRessources.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PicRess1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicRess2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.CheckBox BtnUne;
        private System.Windows.Forms.CheckBox BtnDeux;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox GrRessources;
        private System.Windows.Forms.TextBox TxtRessource2;
        private System.Windows.Forms.TextBox TxtRessource;
        private System.Windows.Forms.Label LblNom;
        private System.Windows.Forms.PictureBox PicRess2;
        private System.Windows.Forms.PictureBox PicRess1;
    }
}