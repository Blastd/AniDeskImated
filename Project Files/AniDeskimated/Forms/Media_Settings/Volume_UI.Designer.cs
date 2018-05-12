namespace AniDeskimated.Forms.Media_Settings
{
    partial class Volume_UI
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
            this.Volume_Traker = new System.Windows.Forms.TrackBar();
            this.Label_StatusPercentage = new System.Windows.Forms.Label();
            this.Button_Done = new AniDeskimated.Forms.Controls.Round_Button();
            ((System.ComponentModel.ISupportInitialize)(this.Volume_Traker)).BeginInit();
            this.SuspendLayout();
            // 
            // Volume_Traker
            // 
            this.Volume_Traker.LargeChange = 10;
            this.Volume_Traker.Location = new System.Drawing.Point(0, 14);
            this.Volume_Traker.Maximum = 100;
            this.Volume_Traker.Name = "Volume_Traker";
            this.Volume_Traker.Size = new System.Drawing.Size(354, 45);
            this.Volume_Traker.SmallChange = 10;
            this.Volume_Traker.TabIndex = 0;
            this.Volume_Traker.TickFrequency = 10;
            this.Volume_Traker.TickStyle = System.Windows.Forms.TickStyle.TopLeft;
            this.Volume_Traker.Value = 10;
            this.Volume_Traker.ValueChanged += new System.EventHandler(this.Volume_Traker_ValueChanged);
            // 
            // Label_StatusPercentage
            // 
            this.Label_StatusPercentage.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Label_StatusPercentage.AutoSize = true;
            this.Label_StatusPercentage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.Label_StatusPercentage.Font = new System.Drawing.Font("Segoe UI", 15F);
            this.Label_StatusPercentage.ForeColor = System.Drawing.Color.White;
            this.Label_StatusPercentage.Location = new System.Drawing.Point(152, 47);
            this.Label_StatusPercentage.Name = "Label_StatusPercentage";
            this.Label_StatusPercentage.Size = new System.Drawing.Size(50, 28);
            this.Label_StatusPercentage.TabIndex = 1;
            this.Label_StatusPercentage.Text = "10%";
            this.Label_StatusPercentage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Button_Done
            // 
            this.Button_Done.BackColor = System.Drawing.Color.Transparent;
            this.Button_Done.Location = new System.Drawing.Point(127, 88);
            this.Button_Done.Margin = new System.Windows.Forms.Padding(0);
            this.Button_Done.MinimumSize = new System.Drawing.Size(30, 30);
            this.Button_Done.Name = "Button_Done";
            this.Button_Done.Size = new System.Drawing.Size(100, 35);
            this.Button_Done.TabIndex = 2;
            this.Button_Done.Click += new System.EventHandler(this.Button_Done_Click);
            // 
            // Volume_UI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.ClientSize = new System.Drawing.Size(354, 132);
            this.ControlBox = false;
            this.Controls.Add(this.Button_Done);
            this.Controls.Add(this.Label_StatusPercentage);
            this.Controls.Add(this.Volume_Traker);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Volume_UI";
            this.Opacity = 0.7D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Set Volume";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.Volume_UI_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Volume_Traker)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TrackBar Volume_Traker;
        private System.Windows.Forms.Label Label_StatusPercentage;
        private Controls.Round_Button Button_Done;
    }
}