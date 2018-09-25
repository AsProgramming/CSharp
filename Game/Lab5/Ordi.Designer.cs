namespace Lab5
{
    partial class Ordi
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.BntAnnuler = new System.Windows.Forms.CheckBox();
            this.BntVendre = new System.Windows.Forms.CheckBox();
            this.BntAcheter = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pictureBox1.Location = new System.Drawing.Point(220, 176);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 103);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // BntAnnuler
            // 
            this.BntAnnuler.Appearance = System.Windows.Forms.Appearance.Button;
            this.BntAnnuler.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BntAnnuler.Location = new System.Drawing.Point(224, 246);
            this.BntAnnuler.Name = "BntAnnuler";
            this.BntAnnuler.Size = new System.Drawing.Size(93, 26);
            this.BntAnnuler.TabIndex = 4;
            this.BntAnnuler.Text = "Annuler";
            this.BntAnnuler.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.BntAnnuler.UseVisualStyleBackColor = true;
            this.BntAnnuler.CheckedChanged += new System.EventHandler(this.BntAnnuler_CheckedChanged);
            // 
            // BntVendre
            // 
            this.BntVendre.Appearance = System.Windows.Forms.Appearance.Button;
            this.BntVendre.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BntVendre.Location = new System.Drawing.Point(224, 214);
            this.BntVendre.Name = "BntVendre";
            this.BntVendre.Size = new System.Drawing.Size(93, 26);
            this.BntVendre.TabIndex = 5;
            this.BntVendre.Text = "Vendre";
            this.BntVendre.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.BntVendre.UseVisualStyleBackColor = true;
            this.BntVendre.CheckedChanged += new System.EventHandler(this.BntVendre_CheckedChanged);
            // 
            // BntAcheter
            // 
            this.BntAcheter.Appearance = System.Windows.Forms.Appearance.Button;
            this.BntAcheter.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BntAcheter.Location = new System.Drawing.Point(224, 182);
            this.BntAcheter.Name = "BntAcheter";
            this.BntAcheter.Size = new System.Drawing.Size(93, 26);
            this.BntAcheter.TabIndex = 6;
            this.BntAcheter.Text = "Acheter";
            this.BntAcheter.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.BntAcheter.UseVisualStyleBackColor = true;
            this.BntAcheter.CheckedChanged += new System.EventHandler(this.BntAcheter_CheckedChanged);
            // 
            // Ordi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Lab5.Properties.Resources.ordi2;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Controls.Add(this.BntAcheter);
            this.Controls.Add(this.BntVendre);
            this.Controls.Add(this.BntAnnuler);
            this.Controls.Add(this.pictureBox1);
            this.DoubleBuffered = true;
            this.Name = "Ordi";
            this.Size = new System.Drawing.Size(586, 460);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.CheckBox BntAnnuler;
        private System.Windows.Forms.CheckBox BntVendre;
        private System.Windows.Forms.CheckBox BntAcheter;
    }
}
