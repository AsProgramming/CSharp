namespace Labo4
{
    partial class Form1
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
            this.BtnRouler = new System.Windows.Forms.Button();
            this.CustDe3 = new Labo4.De();
            this.CustDe2 = new Labo4.De();
            this.CustDe = new Labo4.De();
            this.SuspendLayout();
            // 
            // BtnRouler
            // 
            this.BtnRouler.Location = new System.Drawing.Point(149, 147);
            this.BtnRouler.Name = "BtnRouler";
            this.BtnRouler.Size = new System.Drawing.Size(116, 34);
            this.BtnRouler.TabIndex = 3;
            this.BtnRouler.Text = "Rouler";
            this.BtnRouler.UseVisualStyleBackColor = true;
            this.BtnRouler.Click += new System.EventHandler(this.BtnRouler_Click);
            // 
            // CustDe3
            // 
            this.CustDe3.Location = new System.Drawing.Point(287, 25);
            this.CustDe3.Name = "CustDe3";
            this.CustDe3.Size = new System.Drawing.Size(98, 96);
            this.CustDe3.TabIndex = 2;
            this.CustDe3.Click += new System.EventHandler(this.CustDe3_Click);
            // 
            // CustDe2
            // 
            this.CustDe2.Location = new System.Drawing.Point(158, 25);
            this.CustDe2.Name = "CustDe2";
            this.CustDe2.Size = new System.Drawing.Size(96, 96);
            this.CustDe2.TabIndex = 1;
            this.CustDe2.Click += new System.EventHandler(this.CustDe2_Click);
            // 
            // CustDe
            // 
            this.CustDe.Location = new System.Drawing.Point(34, 25);
            this.CustDe.Name = "CustDe";
            this.CustDe.Size = new System.Drawing.Size(96, 96);
            this.CustDe.TabIndex = 0;
            this.CustDe.Click += new System.EventHandler(this.de1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(411, 197);
            this.Controls.Add(this.BtnRouler);
            this.Controls.Add(this.CustDe3);
            this.Controls.Add(this.CustDe2);
            this.Controls.Add(this.CustDe);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "LesDes";
            this.ResumeLayout(false);

        }

        #endregion

        private De CustDe;
        private De CustDe2;
        private De CustDe3;
        private System.Windows.Forms.Button BtnRouler;
    }
}

