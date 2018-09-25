namespace Meduris
{
    partial class Construction
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
            this.ChkBxHutte = new System.Windows.Forms.CheckBox();
            this.ChkBxTemple = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // ChkBxHutte
            // 
            this.ChkBxHutte.Appearance = System.Windows.Forms.Appearance.Button;
            this.ChkBxHutte.BackColor = System.Drawing.Color.Transparent;
            this.ChkBxHutte.BackgroundImage = global::Meduris.Properties.Resources.hutte_bleu;
            this.ChkBxHutte.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ChkBxHutte.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ChkBxHutte.Location = new System.Drawing.Point(3, 3);
            this.ChkBxHutte.Name = "ChkBxHutte";
            this.ChkBxHutte.Size = new System.Drawing.Size(43, 34);
            this.ChkBxHutte.TabIndex = 0;
            this.ChkBxHutte.UseVisualStyleBackColor = false;
            this.ChkBxHutte.CheckedChanged += new System.EventHandler(this.ChkBxHutte_CheckedChanged);
            // 
            // ChkBxTemple
            // 
            this.ChkBxTemple.Appearance = System.Windows.Forms.Appearance.Button;
            this.ChkBxTemple.BackColor = System.Drawing.Color.Transparent;
            this.ChkBxTemple.BackgroundImage = global::Meduris.Properties.Resources.temple_turquoise;
            this.ChkBxTemple.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ChkBxTemple.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ChkBxTemple.Location = new System.Drawing.Point(50, 3);
            this.ChkBxTemple.Name = "ChkBxTemple";
            this.ChkBxTemple.Size = new System.Drawing.Size(43, 34);
            this.ChkBxTemple.TabIndex = 1;
            this.ChkBxTemple.UseVisualStyleBackColor = false;
            this.ChkBxTemple.CheckedChanged += new System.EventHandler(this.ChkBxTemple_CheckedChanged);
            // 
            // Construction
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Cyan;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(97, 39);
            this.Controls.Add(this.ChkBxTemple);
            this.Controls.Add(this.ChkBxHutte);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MinimumSize = new System.Drawing.Size(20, 20);
            this.Name = "Construction";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Construction";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.CheckBox ChkBxTemple;
        private System.Windows.Forms.CheckBox ChkBxHutte;
    }
}