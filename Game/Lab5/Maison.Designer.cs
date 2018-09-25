namespace Lab5
{
    partial class Maison
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
            this.components = new System.ComponentModel.Container();
            this.TmrJour = new System.Windows.Forms.Timer(this.components);
            this.LblJours = new System.Windows.Forms.Label();
            this.LblHrs = new System.Windows.Forms.Label();
            this.TmrHr = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // TmrJour
            // 
            this.TmrJour.Enabled = true;
            this.TmrJour.Interval = 180;
            this.TmrJour.Tick += new System.EventHandler(this.TmrJour_Tick);
            // 
            // LblJours
            // 
            this.LblJours.AutoSize = true;
            this.LblJours.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblJours.Location = new System.Drawing.Point(691, 10);
            this.LblJours.Name = "LblJours";
            this.LblJours.Size = new System.Drawing.Size(59, 20);
            this.LblJours.TabIndex = 0;
            this.LblJours.Text = "Jour 1";
            // 
            // LblHrs
            // 
            this.LblHrs.AutoSize = true;
            this.LblHrs.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblHrs.Location = new System.Drawing.Point(706, 32);
            this.LblHrs.Name = "LblHrs";
            this.LblHrs.Size = new System.Drawing.Size(36, 16);
            this.LblHrs.TabIndex = 1;
            this.LblHrs.Text = "7:00";
            // 
            // TmrHr
            // 
            this.TmrHr.Enabled = true;
            this.TmrHr.Interval = 1900;
            this.TmrHr.Tick += new System.EventHandler(this.TmrHr_Tick);
            // 
            // Maison
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DodgerBlue;
            this.Controls.Add(this.LblHrs);
            this.Controls.Add(this.LblJours);
            this.DoubleBuffered = true;
            this.Name = "Maison";
            this.Size = new System.Drawing.Size(770, 255);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Maison_Paint);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Maison_KeyDown);
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Maison_MouseClick);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer TmrJour;
        private System.Windows.Forms.Label LblJours;
        private System.Windows.Forms.Label LblHrs;
        private System.Windows.Forms.Timer TmrHr;
    }
}
