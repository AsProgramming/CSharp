namespace Lab5
{
    partial class Fin
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.LblTextTotal = new System.Windows.Forms.Label();
            this.LblArgent = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Restart = new System.Windows.Forms.CheckBox();
            this.Quit = new System.Windows.Forms.CheckBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.LblTextTotal);
            this.groupBox1.Controls.Add(this.LblArgent);
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(49, 88);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(351, 152);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Fin de la Partie";
            // 
            // LblTextTotal
            // 
            this.LblTextTotal.AutoSize = true;
            this.LblTextTotal.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.LblTextTotal.Location = new System.Drawing.Point(215, 40);
            this.LblTextTotal.Name = "LblTextTotal";
            this.LblTextTotal.Size = new System.Drawing.Size(62, 24);
            this.LblTextTotal.TabIndex = 2;
            this.LblTextTotal.Text = "Total:";
            // 
            // LblArgent
            // 
            this.LblArgent.AutoSize = true;
            this.LblArgent.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblArgent.ForeColor = System.Drawing.Color.Green;
            this.LblArgent.Location = new System.Drawing.Point(212, 73);
            this.LblArgent.Name = "LblArgent";
            this.LblArgent.Size = new System.Drawing.Size(65, 25);
            this.LblArgent.TabIndex = 1;
            this.LblArgent.Text = "Total";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::Lab5.Properties.Resources.cartoon_money;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(70, 13);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(126, 124);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // Restart
            // 
            this.Restart.Appearance = System.Windows.Forms.Appearance.Button;
            this.Restart.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Restart.Location = new System.Drawing.Point(268, 320);
            this.Restart.Name = "Restart";
            this.Restart.Size = new System.Drawing.Size(71, 24);
            this.Restart.TabIndex = 3;
            this.Restart.Text = "Restart";
            this.Restart.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Restart.UseVisualStyleBackColor = true;
            this.Restart.CheckedChanged += new System.EventHandler(this.Restart_CheckedChanged);
            // 
            // Quit
            // 
            this.Quit.Appearance = System.Windows.Forms.Appearance.Button;
            this.Quit.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Quit.Location = new System.Drawing.Point(345, 320);
            this.Quit.Name = "Quit";
            this.Quit.Size = new System.Drawing.Size(65, 24);
            this.Quit.TabIndex = 4;
            this.Quit.Text = "Quitter";
            this.Quit.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Quit.UseVisualStyleBackColor = true;
            this.Quit.CheckedChanged += new System.EventHandler(this.Quit_CheckedChanged);
            // 
            // Fin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Lab5.Properties.Resources.UpayPage;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Controls.Add(this.Quit);
            this.Controls.Add(this.Restart);
            this.Controls.Add(this.groupBox1);
            this.DoubleBuffered = true;
            this.Name = "Fin";
            this.Size = new System.Drawing.Size(457, 404);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label LblTextTotal;
        private System.Windows.Forms.Label LblArgent;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.CheckBox Restart;
        private System.Windows.Forms.CheckBox Quit;
    }
}
