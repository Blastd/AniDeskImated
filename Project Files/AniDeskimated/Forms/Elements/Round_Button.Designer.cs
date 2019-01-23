namespace AniDeskimated.Forms.Elements
{
    partial class Round_Button
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
            this.Button_Part = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Button_Part
            // 
            this.Button_Part.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Button_Part.FlatAppearance.BorderSize = 0;
            this.Button_Part.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.Button_Part.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.Button_Part.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button_Part.Font = new System.Drawing.Font("Segoe UI Black", 14F);
            this.Button_Part.Location = new System.Drawing.Point(0, 0);
            this.Button_Part.Margin = new System.Windows.Forms.Padding(0);
            this.Button_Part.Name = "Button_Part";
            this.Button_Part.Size = new System.Drawing.Size(100, 40);
            this.Button_Part.TabIndex = 0;
            this.Button_Part.TabStop = false;
            this.Button_Part.Text = "Text";
            this.Button_Part.UseVisualStyleBackColor = true;
            this.Button_Part.Click += new System.EventHandler(this.Button_Part_Click);
            this.Button_Part.Paint += new System.Windows.Forms.PaintEventHandler(this.Button_Part_Paint);
            this.Button_Part.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Button_Part_MouseDown);
            this.Button_Part.MouseLeave += new System.EventHandler(this.Button_Part_MouseLeave);
            this.Button_Part.MouseHover += new System.EventHandler(this.Button_Part_MouseHover);
            this.Button_Part.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Button_Part_MouseUp);
            // 
            // Round_Button
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.Button_Part);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.MinimumSize = new System.Drawing.Size(30, 30);
            this.Name = "Round_Button";
            this.Size = new System.Drawing.Size(100, 40);
            this.Load += new System.EventHandler(this.Round_Button_Load);
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Button Button_Part;
    }
}
