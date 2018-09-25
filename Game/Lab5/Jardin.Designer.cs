namespace Lab5
{
    partial class Jardin
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
            this.Redessiner = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // Redessiner
            // 
            this.Redessiner.Enabled = true;
            this.Redessiner.Interval = 500;
            this.Redessiner.Tick += new System.EventHandler(this.Redessiner_Tick);
            // 
            // Jardin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.DoubleBuffered = true;
            this.Name = "Jardin";
            this.Size = new System.Drawing.Size(765, 767);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Jardin_Paint);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Jardin_KeyDown);
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Jardin_MouseClick);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer Redessiner;
    }
}
