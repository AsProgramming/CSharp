namespace Lab5
{
    partial class ActionFleur
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.BtnArroser = new System.Windows.Forms.CheckBox();
            this.BtnCeuillir = new System.Windows.Forms.CheckBox();
            this.BtnAnnuler = new System.Windows.Forms.CheckBox();
            this.ChkDeplanter = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // BtnArroser
            // 
            this.BtnArroser.Appearance = System.Windows.Forms.Appearance.Button;
            this.BtnArroser.BackColor = System.Drawing.Color.LightSkyBlue;
            this.BtnArroser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnArroser.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnArroser.Location = new System.Drawing.Point(6, 3);
            this.BtnArroser.Name = "BtnArroser";
            this.BtnArroser.Size = new System.Drawing.Size(78, 24);
            this.BtnArroser.TabIndex = 0;
            this.BtnArroser.Text = "Arroser";
            this.BtnArroser.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.BtnArroser.UseVisualStyleBackColor = false;
            this.BtnArroser.Click += new System.EventHandler(this.BtnArroser_Click);
            // 
            // BtnCeuillir
            // 
            this.BtnCeuillir.Appearance = System.Windows.Forms.Appearance.Button;
            this.BtnCeuillir.BackColor = System.Drawing.Color.Tan;
            this.BtnCeuillir.Enabled = false;
            this.BtnCeuillir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCeuillir.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCeuillir.Location = new System.Drawing.Point(6, 33);
            this.BtnCeuillir.Name = "BtnCeuillir";
            this.BtnCeuillir.Size = new System.Drawing.Size(78, 24);
            this.BtnCeuillir.TabIndex = 1;
            this.BtnCeuillir.Text = "Ceuillir";
            this.BtnCeuillir.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.BtnCeuillir.UseVisualStyleBackColor = false;
            this.BtnCeuillir.Click += new System.EventHandler(this.BtnCeuillir_Click);
            // 
            // BtnAnnuler
            // 
            this.BtnAnnuler.Appearance = System.Windows.Forms.Appearance.Button;
            this.BtnAnnuler.BackColor = System.Drawing.Color.LightGray;
            this.BtnAnnuler.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAnnuler.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAnnuler.Location = new System.Drawing.Point(6, 94);
            this.BtnAnnuler.Name = "BtnAnnuler";
            this.BtnAnnuler.Size = new System.Drawing.Size(78, 24);
            this.BtnAnnuler.TabIndex = 2;
            this.BtnAnnuler.Text = "Annuler";
            this.BtnAnnuler.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.BtnAnnuler.UseVisualStyleBackColor = false;
            this.BtnAnnuler.Click += new System.EventHandler(this.BtnAnnuler_Click);
            // 
            // ChkDeplanter
            // 
            this.ChkDeplanter.Appearance = System.Windows.Forms.Appearance.Button;
            this.ChkDeplanter.BackColor = System.Drawing.Color.SaddleBrown;
            this.ChkDeplanter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ChkDeplanter.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ChkDeplanter.Location = new System.Drawing.Point(6, 63);
            this.ChkDeplanter.Name = "ChkDeplanter";
            this.ChkDeplanter.Size = new System.Drawing.Size(78, 24);
            this.ChkDeplanter.TabIndex = 3;
            this.ChkDeplanter.Text = "Enlever";
            this.ChkDeplanter.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.ChkDeplanter.UseVisualStyleBackColor = false;
            this.ChkDeplanter.CheckedChanged += new System.EventHandler(this.ChkDeplanter_CheckedChanged);
            // 
            // ActionFleur
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.Controls.Add(this.ChkDeplanter);
            this.Controls.Add(this.BtnAnnuler);
            this.Controls.Add(this.BtnCeuillir);
            this.Controls.Add(this.BtnArroser);
            this.Name = "ActionFleur";
            this.Size = new System.Drawing.Size(90, 121);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.CheckBox BtnArroser;
        private System.Windows.Forms.CheckBox BtnCeuillir;
        private System.Windows.Forms.CheckBox BtnAnnuler;
        private System.Windows.Forms.CheckBox ChkDeplanter;
    }
}
