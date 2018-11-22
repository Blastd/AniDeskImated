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
            this.Button_Done = new AniDeskimated.Forms.Elements.Round_Button();
            this.Button_Exit = new System.Windows.Forms.Button();
            this.Controls_Group = new System.Windows.Forms.FlowLayoutPanel();
            this.Controls_LayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this.Scale_Tracker)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ScaleView)).BeginInit();
            this.Controls_Group.SuspendLayout();
            this.Controls_LayoutPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // Label_StatusPercentage
            // 
            this.Label_StatusPercentage.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.Label_StatusPercentage.AutoSize = true;
            this.Label_StatusPercentage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.Label_StatusPercentage.Font = new System.Drawing.Font("Segoe UI Black", 12F);
            this.Label_StatusPercentage.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.Label_StatusPercentage.Location = new System.Drawing.Point(3, 4);
            this.Label_StatusPercentage.Name = "Label_StatusPercentage";
            this.Label_StatusPercentage.Size = new System.Drawing.Size(42, 21);
            this.Label_StatusPercentage.TabIndex = 4;
            this.Label_StatusPercentage.Text = "10%";
            this.Label_StatusPercentage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Scale_Tracker
            // 
            this.Scale_Tracker.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.Scale_Tracker.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.Scale_Tracker.LargeChange = 10;
            this.Scale_Tracker.Location = new System.Drawing.Point(0, 176);
            this.Scale_Tracker.Maximum = 100;
            this.Scale_Tracker.Minimum = 1;
            this.Scale_Tracker.Name = "Scale_Tracker";
            this.Scale_Tracker.Size = new System.Drawing.Size(397, 45);
            this.Scale_Tracker.TabIndex = 3;
            this.Scale_Tracker.TickFrequency = 10;
            this.Scale_Tracker.TickStyle = System.Windows.Forms.TickStyle.TopLeft;
            this.Scale_Tracker.Value = 10;
            this.Scale_Tracker.Scroll += new System.EventHandler(this.Scale_Tracker_Scroll);
            this.Scale_Tracker.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Scale_Tracker_KeyDown);
            this.Scale_Tracker.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Scale_Tracker_KeyUp);
            // 
            // ScaleView
            // 
            this.ScaleView.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.ScaleView.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ScaleView.Location = new System.Drawing.Point(123, 19);
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
            this.Button_Done.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(56)))), ((int)(((byte)(145)))));
            this.Button_Done.Location = new System.Drawing.Point(48, 0);
            this.Button_Done.Margin = new System.Windows.Forms.Padding(0);
            this.Button_Done.MinimumSize = new System.Drawing.Size(30, 30);
            this.Button_Done.Name = "Button_Done";
            this.Button_Done.Size = new System.Drawing.Size(45, 30);
            this.Button_Done.TabIndex = 7;
            this.Button_Done.Click += new System.EventHandler(this.Button_Done_Click);
            // 
            // Button_Exit
            // 
            this.Button_Exit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Button_Exit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Button_Exit.FlatAppearance.BorderSize = 0;
            this.Button_Exit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(205)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Button_Exit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(235)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Button_Exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button_Exit.Font = new System.Drawing.Font("Segoe MDL2 Assets", 10F);
            this.Button_Exit.ForeColor = System.Drawing.Color.White;
            this.Button_Exit.Location = new System.Drawing.Point(368, 0);
            this.Button_Exit.Margin = new System.Windows.Forms.Padding(0);
            this.Button_Exit.Name = "Button_Exit";
            this.Button_Exit.Size = new System.Drawing.Size(32, 25);
            this.Button_Exit.TabIndex = 13;
            this.Button_Exit.Text = "";
            this.Button_Exit.UseVisualStyleBackColor = false;
            this.Button_Exit.Click += new System.EventHandler(this.Button_Exit_Click);
            // 
            // Controls_Group
            // 
            this.Controls_Group.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.Controls_Group.AutoSize = true;
            this.Controls_Group.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Controls_Group.Controls.Add(this.Label_StatusPercentage);
            this.Controls_Group.Controls.Add(this.Button_Done);
            this.Controls_Group.Location = new System.Drawing.Point(152, 3);
            this.Controls_Group.Name = "Controls_Group";
            this.Controls_Group.Size = new System.Drawing.Size(93, 34);
            this.Controls_Group.TabIndex = 14;
            // 
            // Controls_LayoutPanel
            // 
            this.Controls_LayoutPanel.ColumnCount = 1;
            this.Controls_LayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.Controls_LayoutPanel.Controls.Add(this.Controls_Group, 0, 0);
            this.Controls_LayoutPanel.Location = new System.Drawing.Point(0, 225);
            this.Controls_LayoutPanel.Name = "Controls_LayoutPanel";
            this.Controls_LayoutPanel.RowCount = 1;
            this.Controls_LayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.Controls_LayoutPanel.Size = new System.Drawing.Size(397, 40);
            this.Controls_LayoutPanel.TabIndex = 15;
            // 
            // Control_Scale
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.Controls.Add(this.Controls_LayoutPanel);
            this.Controls.Add(this.Button_Exit);
            this.Controls.Add(this.ScaleView);
            this.Controls.Add(this.Scale_Tracker);
            this.DoubleBuffered = true;
            this.Name = "Control_Scale";
            this.Size = new System.Drawing.Size(400, 350);
            this.Load += new System.EventHandler(this.Control_Scale_Load);
            this.VisibleChanged += new System.EventHandler(this.Control_Scale_VisibleChanged);
            ((System.ComponentModel.ISupportInitialize)(this.Scale_Tracker)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ScaleView)).EndInit();
            this.Controls_Group.ResumeLayout(false);
            this.Controls_Group.PerformLayout();
            this.Controls_LayoutPanel.ResumeLayout(false);
            this.Controls_LayoutPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label Label_StatusPercentage;
        private System.Windows.Forms.TrackBar Scale_Tracker;
        private System.Windows.Forms.PictureBox ScaleView;
        private Elements.Round_Button Button_Done;
        private System.Windows.Forms.Button Button_Exit;
        private System.Windows.Forms.FlowLayoutPanel Controls_Group;
        private System.Windows.Forms.TableLayoutPanel Controls_LayoutPanel;
    }
}
