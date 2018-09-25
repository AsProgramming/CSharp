namespace Lab5
{
    partial class Menu
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
            this.BtnDormir = new System.Windows.Forms.CheckBox();
            this.BtnOrdi = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.BtnAnnuler = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // BtnDormir
            // 
            this.BtnDormir.Appearance = System.Windows.Forms.Appearance.Button;
            this.BtnDormir.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnDormir.Location = new System.Drawing.Point(177, 111);
            this.BtnDormir.Name = "BtnDormir";
            this.BtnDormir.Size = new System.Drawing.Size(104, 24);
            this.BtnDormir.TabIndex = 0;
            this.BtnDormir.Text = "Dormir";
            this.BtnDormir.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.BtnDormir.UseVisualStyleBackColor = true;
            this.BtnDormir.CheckedChanged += new System.EventHandler(this.BtnDormir_CheckedChanged);
            // 
            // BtnOrdi
            // 
            this.BtnOrdi.Appearance = System.Windows.Forms.Appearance.Button;
            this.BtnOrdi.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnOrdi.Location = new System.Drawing.Point(177, 81);
            this.BtnOrdi.Name = "BtnOrdi";
            this.BtnOrdi.Size = new System.Drawing.Size(104, 24);
            this.BtnOrdi.TabIndex = 1;
            this.BtnOrdi.Text = "Ordinateur";
            this.BtnOrdi.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.BtnOrdi.UseVisualStyleBackColor = true;
            this.BtnOrdi.CheckedChanged += new System.EventHandler(this.BtnOrdi_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(203, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Options";
            // 
            // BtnAnnuler
            // 
            this.BtnAnnuler.Appearance = System.Windows.Forms.Appearance.Button;
            this.BtnAnnuler.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAnnuler.Location = new System.Drawing.Point(177, 141);
            this.BtnAnnuler.Name = "BtnAnnuler";
            this.BtnAnnuler.Size = new System.Drawing.Size(104, 24);
            this.BtnAnnuler.TabIndex = 4;
            this.BtnAnnuler.Text = "Annuler";
            this.BtnAnnuler.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.BtnAnnuler.UseVisualStyleBackColor = true;
            this.BtnAnnuler.CheckedChanged += new System.EventHandler(this.BtnAnnuler_CheckedChanged);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImage = global::Lab5.Properties.Resources.ChaletImg;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Controls.Add(this.BtnAnnuler);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BtnOrdi);
            this.Controls.Add(this.BtnDormir);
            this.Name = "Menu";
            this.Size = new System.Drawing.Size(460, 254);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox BtnDormir;
        private System.Windows.Forms.CheckBox BtnOrdi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox BtnAnnuler;
    }
}
