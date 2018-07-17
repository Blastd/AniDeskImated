namespace AniDeskimated.Forms.Media_Settings
{
    partial class Control_Volume
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
            this.Label_StatusPercentage = new System.Windows.Forms.Label();
            this.Volume_Tracker = new System.Windows.Forms.TrackBar();
            this.Button_Done = new AniDeskimated.Forms.Controls.Round_Button();
            this.Button_Exit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Volume_Tracker)).BeginInit();
            this.SuspendLayout();
            // 
            // Label_StatusPercentage
            // 
            this.Label_StatusPercentage.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.Label_StatusPercentage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.Label_StatusPercentage.Font = new System.Drawing.Font("Segoe UI Black", 12F);
            this.Label_StatusPercentage.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.Label_StatusPercentage.Location = new System.Drawing.Point(-4, 126);
            this.Label_StatusPercentage.Name = "Label_StatusPercentage";
            this.Label_StatusPercentage.Size = new System.Drawing.Size(370, 28);
            this.Label_StatusPercentage.TabIndex = 4;
            this.Label_StatusPercentage.Text = "10%";
            this.Label_StatusPercentage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Volume_Tracker
            // 
            this.Volume_Tracker.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Volume_Tracker.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.Volume_Tracker.LargeChange = 10;
            this.Volume_Tracker.Location = new System.Drawing.Point(8, 93);
            this.Volume_Tracker.Maximum = 100;
            this.Volume_Tracker.Name = "Volume_Tracker";
            this.Volume_Tracker.Size = new System.Drawing.Size(354, 45);
            this.Volume_Tracker.SmallChange = 10;
            this.Volume_Tracker.TabIndex = 3;
            this.Volume_Tracker.TickFrequency = 10;
            this.Volume_Tracker.TickStyle = System.Windows.Forms.TickStyle.TopLeft;
            this.Volume_Tracker.Value = 10;
            this.Volume_Tracker.Scroll += new System.EventHandler(this.Volume_Tracker_Scroll);
            this.Volume_Tracker.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Volume_Tracker_KeyDown);
            this.Volume_Tracker.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Volume_Tracker_KeyUp);
            // 
            // Button_Done
            // 
            this.Button_Done.BackColor = System.Drawing.Color.Transparent;
            this.Button_Done.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(145)))), ((int)(((byte)(145)))));
            this.Button_Done.Location = new System.Drawing.Point(206, 126);
            this.Button_Done.Margin = new System.Windows.Forms.Padding(0);
            this.Button_Done.MinimumSize = new System.Drawing.Size(30, 30);
            this.Button_Done.Name = "Button_Done";
            this.Button_Done.Size = new System.Drawing.Size(30, 30);
            this.Button_Done.TabIndex = 5;
            this.Button_Done.Click += new System.EventHandler(this.Button_Done_Click);
            // 
            // Button_Exit
            // 
            this.Button_Exit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Button_Exit.FlatAppearance.BorderSize = 0;
            this.Button_Exit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(205)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Button_Exit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(235)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Button_Exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button_Exit.Font = new System.Drawing.Font("Segoe MDL2 Assets", 10F);
            this.Button_Exit.ForeColor = System.Drawing.Color.White;
            this.Button_Exit.Location = new System.Drawing.Point(345, 0);
            this.Button_Exit.Margin = new System.Windows.Forms.Padding(0);
            this.Button_Exit.Name = "Button_Exit";
            this.Button_Exit.Size = new System.Drawing.Size(25, 25);
            this.Button_Exit.TabIndex = 14;
            this.Button_Exit.Text = "";
            this.Button_Exit.UseVisualStyleBackColor = false;
            this.Button_Exit.Click += new System.EventHandler(this.Button_Exit_Click);
            // 
            // Control_Volume
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.Controls.Add(this.Button_Exit);
            this.Controls.Add(this.Button_Done);
            this.Controls.Add(this.Label_StatusPercentage);
            this.Controls.Add(this.Volume_Tracker);
            this.Name = "Control_Volume";
            this.Size = new System.Drawing.Size(370, 247);
            this.Load += new System.EventHandler(this.Control_Volume_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Volume_Tracker)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label Label_StatusPercentage;
        private System.Windows.Forms.TrackBar Volume_Tracker;
        private Controls.Round_Button Button_Done;
        private System.Windows.Forms.Button Button_Exit;
    }
}
