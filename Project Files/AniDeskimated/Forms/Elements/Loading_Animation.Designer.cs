namespace AniDeskimated.Forms.Elements
{
    partial class Loading_Animation
    {
        /// <summary> 
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione componenti

        /// <summary> 
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare 
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.Draw_Clock = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // Draw_Clock
            // 
            this.Draw_Clock.Enabled = true;
            this.Draw_Clock.Interval = 32;
            this.Draw_Clock.Tick += new System.EventHandler(this.Draw_Clock_Tick);
            // 
            // Loading_Animation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.DoubleBuffered = true;
            this.MinimumSize = new System.Drawing.Size(32, 32);
            this.Name = "Loading_Animation";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Loading_Animation_Paint);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer Draw_Clock;
    }
}
