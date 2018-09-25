namespace Lab5
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
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.recommencerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.recommencerToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.quitterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aProposToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.jardin2 = new Lab5.Jardin();
            this.menuStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip2
            // 
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.recommencerToolStripMenuItem,
            this.aProposToolStripMenuItem});
            this.menuStrip2.Location = new System.Drawing.Point(0, 0);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Size = new System.Drawing.Size(773, 24);
            this.menuStrip2.TabIndex = 2;
            this.menuStrip2.Text = "menuStrip2";
            // 
            // recommencerToolStripMenuItem
            // 
            this.recommencerToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.recommencerToolStripMenuItem1,
            this.quitterToolStripMenuItem});
            this.recommencerToolStripMenuItem.Name = "recommencerToolStripMenuItem";
            this.recommencerToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.recommencerToolStripMenuItem.Text = "Menu";
            // 
            // recommencerToolStripMenuItem1
            // 
            this.recommencerToolStripMenuItem1.Name = "recommencerToolStripMenuItem1";
            this.recommencerToolStripMenuItem1.Size = new System.Drawing.Size(152, 22);
            this.recommencerToolStripMenuItem1.Text = "Recommencer";
            this.recommencerToolStripMenuItem1.Click += new System.EventHandler(this.recommencerToolStripMenuItem1_Click);
            // 
            // quitterToolStripMenuItem
            // 
            this.quitterToolStripMenuItem.Name = "quitterToolStripMenuItem";
            this.quitterToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.quitterToolStripMenuItem.Text = "Quitter";
            this.quitterToolStripMenuItem.Click += new System.EventHandler(this.quitterToolStripMenuItem_Click_1);
            // 
            // aProposToolStripMenuItem
            // 
            this.aProposToolStripMenuItem.Name = "aProposToolStripMenuItem";
            this.aProposToolStripMenuItem.Size = new System.Drawing.Size(76, 20);
            this.aProposToolStripMenuItem.Text = "A Propos...";
            this.aProposToolStripMenuItem.Click += new System.EventHandler(this.aProposToolStripMenuItem_Click);
            // 
            // jardin2
            // 
            this.jardin2.Arret = false;
            this.jardin2.Location = new System.Drawing.Point(5, 21);
            this.jardin2.Name = "jardin2";
            this.jardin2.Size = new System.Drawing.Size(765, 767);
            this.jardin2.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(773, 792);
            this.Controls.Add(this.jardin2);
            this.Controls.Add(this.menuStrip2);
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MonJardin";
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Jardin jardin1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.ToolStripMenuItem recommencerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem recommencerToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem quitterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aProposToolStripMenuItem;
        private Jardin jardin2;
    }
}

