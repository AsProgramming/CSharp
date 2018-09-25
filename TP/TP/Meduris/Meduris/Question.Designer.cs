namespace Meduris
{
    partial class Question
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
            this.BtnUne = new System.Windows.Forms.Button();
            this.LblNom = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.BtnDeux = new System.Windows.Forms.Button();
            this.BtnAucune = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BtnUne
            // 
            this.BtnUne.Location = new System.Drawing.Point(16, 51);
            this.BtnUne.Name = "BtnUne";
            this.BtnUne.Size = new System.Drawing.Size(48, 31);
            this.BtnUne.TabIndex = 0;
            this.BtnUne.Text = "1/2";
            this.BtnUne.UseVisualStyleBackColor = true;
            this.BtnUne.Click += new System.EventHandler(this.BtnUne_Click);
            // 
            // LblNom
            // 
            this.LblNom.AutoSize = true;
            this.LblNom.Location = new System.Drawing.Point(81, 9);
            this.LblNom.Name = "LblNom";
            this.LblNom.Size = new System.Drawing.Size(29, 13);
            this.LblNom.TabIndex = 1;
            this.LblNom.Text = "Nom";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(157, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Voulez-vous faire une offrande?";
            // 
            // BtnDeux
            // 
            this.BtnDeux.Location = new System.Drawing.Point(69, 51);
            this.BtnDeux.Name = "BtnDeux";
            this.BtnDeux.Size = new System.Drawing.Size(48, 31);
            this.BtnDeux.TabIndex = 4;
            this.BtnDeux.Text = "2";
            this.BtnDeux.UseVisualStyleBackColor = true;
            this.BtnDeux.Click += new System.EventHandler(this.BtnDeux_Click);
            // 
            // BtnAucune
            // 
            this.BtnAucune.Location = new System.Drawing.Point(122, 51);
            this.BtnAucune.Name = "BtnAucune";
            this.BtnAucune.Size = new System.Drawing.Size(48, 31);
            this.BtnAucune.TabIndex = 5;
            this.BtnAucune.Text = "0";
            this.BtnAucune.UseVisualStyleBackColor = true;
            this.BtnAucune.Click += new System.EventHandler(this.BtnAucune_Click);
            // 
            // Question
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(184, 93);
            this.Controls.Add(this.BtnAucune);
            this.Controls.Add(this.BtnDeux);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.LblNom);
            this.Controls.Add(this.BtnUne);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Question";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Offrande";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnUne;
        private System.Windows.Forms.Label LblNom;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button BtnDeux;
        private System.Windows.Forms.Button BtnAucune;
    }
}