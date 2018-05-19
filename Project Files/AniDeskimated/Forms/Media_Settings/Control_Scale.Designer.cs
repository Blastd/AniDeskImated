namespace AniDeskimated.Forms.Media_Settings
{
    partial class Control_Scale
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
            this.Scale_Tracker = new System.Windows.Forms.TrackBar();
            this.ScaleView = new System.Windows.Forms.PictureBox();
            this.Button_Done = new AniDeskimated.Forms.Controls.Round_Button();
            ((System.ComponentModel.ISupportInitialize)(this.Scale_Tracker)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ScaleView)).BeginInit();
            this.SuspendLayout();
            // 
            // Label_StatusPercentage
            // 
            this.Label_StatusPercentage.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.Label_StatusPercentage.AutoSize = true;
            this.Label_StatusPercentage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.Label_StatusPercentage.Font = new System.Drawing.Font("Segoe UI", 15F);
            this.Label_StatusPercentage.ForeColor = System.Drawing.Color.White;
            this.Label_StatusPercentage.Location = new System.Drawing.Point(160, 168);
            this.Label_StatusPercentage.Name = "Label_StatusPercentage";
            this.Label_StatusPercentage.Size = new System.Drawing.Size(50, 28);
            this.Label_StatusPercentage.TabIndex = 4;
            this.Label_StatusPercentage.Text = "10%";
            this.Label_StatusPercentage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Scale_Tracker
            // 
            this.Scale_Tracker.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.Scale_Tracker.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.Scale_Tracker.LargeChange = 10;
            this.Scale_Tracker.Location = new System.Drawing.Point(8, 135);
            this.Scale_Tracker.Maximum = 100;
            this.Scale_Tracker.Name = "Scale_Tracker";
            this.Scale_Tracker.Size = new System.Drawing.Size(354, 45);
            this.Scale_Tracker.SmallChange = 10;
            this.Scale_Tracker.TabIndex = 3;
            this.Scale_Tracker.TickFrequency = 10;
            this.Scale_Tracker.TickStyle = System.Windows.Forms.TickStyle.TopLeft;
            this.Scale_Tracker.Value = 10;
            this.Scale_Tracker.Scroll += new System.EventHandler(this.Scale_Tracker_Scroll);
            // 
            // ScaleView
            // 
            this.ScaleView.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.ScaleView.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ScaleView.Location = new System.Drawing.Point(108, 19);
            this.ScaleView.Name = "ScaleView";
            this.ScaleView.Size = new System.Drawing.Size(155, 100);
            this.ScaleView.TabIndex = 6;
            this.ScaleView.TabStop = false;
            this.ScaleView.Paint += new System.Windows.Forms.PaintEventHandler(this.ScaleView_Paint);
            // 
            // Button_Done
            // 
            this.Button_Done.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.Button_Done.BackColor = System.Drawing.Color.Transparent;
            this.Button_Done.Location = new System.Drawing.Point(135, 200);
            this.Button_Done.Margin = new System.Windows.Forms.Padding(0);
            this.Button_Done.MinimumSize = new System.Drawing.Size(30, 30);
            this.Button_Done.Name = "Button_Done";
            this.Button_Done.Size = new System.Drawing.Size(100, 36);
            this.Button_Done.TabIndex = 5;
            this.Button_Done.Click += new System.EventHandler(this.Button_Done_Click);
            // 
            // Control_Scale
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.Controls.Add(this.ScaleView);
            this.Controls.Add(this.Button_Done);
            this.Controls.Add(this.Label_StatusPercentage);
            this.Controls.Add(this.Scale_Tracker);
            this.DoubleBuffered = true;
            this.Name = "Control_Scale";
            this.Size = new System.Drawing.Size(370, 247);
            this.Load += new System.EventHandler(this.Control_Scale_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Scale_Tracker)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ScaleView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Controls.Round_Button Button_Done;
        private System.Windows.Forms.Label Label_StatusPercentage;
        private System.Windows.Forms.TrackBar Scale_Tracker;
        private System.Windows.Forms.PictureBox ScaleView;
    }
}
