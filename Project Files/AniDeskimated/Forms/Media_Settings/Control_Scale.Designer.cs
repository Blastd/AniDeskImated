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
            this.Controls_Group = new System.Windows.Forms.FlowLayoutPanel();
            this.Controls_LayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.Button_Done = new AniDeskimated.Forms.Elements.Round_Button();
            this.Button_Undo = new AniDeskimated.Forms.Elements.Round_Button();
            ((System.ComponentModel.ISupportInitialize)(this.Scale_Tracker)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ScaleView)).BeginInit();
            this.Controls_Group.SuspendLayout();
            this.Controls_LayoutPanel.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Label_StatusPercentage
            // 
            this.Label_StatusPercentage.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.Label_StatusPercentage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.Label_StatusPercentage.Font = new System.Drawing.Font("Segoe UI Black", 12F);
            this.Label_StatusPercentage.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.Label_StatusPercentage.Location = new System.Drawing.Point(3, 0);
            this.Label_StatusPercentage.Name = "Label_StatusPercentage";
            this.Label_StatusPercentage.Size = new System.Drawing.Size(52, 21);
            this.Label_StatusPercentage.TabIndex = 4;
            this.Label_StatusPercentage.Text = "100%";
            this.Label_StatusPercentage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Scale_Tracker
            // 
            this.Scale_Tracker.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.Scale_Tracker.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.Scale_Tracker.LargeChange = 10;
            this.Scale_Tracker.Location = new System.Drawing.Point(0, 158);
            this.Scale_Tracker.Maximum = 200;
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
            // Controls_Group
            // 
            this.Controls_Group.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.Controls_Group.AutoSize = true;
            this.Controls_Group.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Controls_Group.Controls.Add(this.Label_StatusPercentage);
            this.Controls_Group.Location = new System.Drawing.Point(171, 3);
            this.Controls_Group.Name = "Controls_Group";
            this.Controls_Group.Size = new System.Drawing.Size(58, 37);
            this.Controls_Group.TabIndex = 14;
            // 
            // Controls_LayoutPanel
            // 
            this.Controls_LayoutPanel.ColumnCount = 1;
            this.Controls_LayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.Controls_LayoutPanel.Controls.Add(this.flowLayoutPanel1, 0, 1);
            this.Controls_LayoutPanel.Controls.Add(this.Controls_Group, 0, 0);
            this.Controls_LayoutPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Controls_LayoutPanel.Location = new System.Drawing.Point(0, 192);
            this.Controls_LayoutPanel.Name = "Controls_LayoutPanel";
            this.Controls_LayoutPanel.RowCount = 2;
            this.Controls_LayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 35.46099F));
            this.Controls_LayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 64.53901F));
            this.Controls_LayoutPanel.Size = new System.Drawing.Size(400, 123);
            this.Controls_LayoutPanel.TabIndex = 15;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.flowLayoutPanel1.AutoSize = true;
            this.flowLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flowLayoutPanel1.Controls.Add(this.Button_Done);
            this.flowLayoutPanel1.Controls.Add(this.Button_Undo);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(135, 43);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(130, 80);
            this.flowLayoutPanel1.TabIndex = 16;
            // 
            // Button_Done
            // 
            this.Button_Done.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.Button_Done.BackColor = System.Drawing.Color.Transparent;
            this.Button_Done.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.Button_Done.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(56)))), ((int)(((byte)(145)))));
            this.Button_Done.Location = new System.Drawing.Point(10, 10);
            this.Button_Done.Margin = new System.Windows.Forms.Padding(10);
            this.Button_Done.MinimumSize = new System.Drawing.Size(30, 30);
            this.Button_Done.Name = "Button_Done";
            this.Button_Done.Size = new System.Drawing.Size(45, 30);
            this.Button_Done.TabIndex = 7;
            this.Button_Done.Click += new System.EventHandler(this.Button_Done_Click);
            // 
            // Button_Undo
            // 
            this.Button_Undo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.Button_Undo.BackColor = System.Drawing.Color.Transparent;
            this.Button_Undo.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.Button_Undo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(56)))), ((int)(((byte)(145)))));
            this.Button_Undo.Location = new System.Drawing.Point(75, 10);
            this.Button_Undo.Margin = new System.Windows.Forms.Padding(10);
            this.Button_Undo.MinimumSize = new System.Drawing.Size(30, 30);
            this.Button_Undo.Name = "Button_Undo";
            this.Button_Undo.Size = new System.Drawing.Size(45, 30);
            this.Button_Undo.TabIndex = 8;
            this.Button_Undo.Click += new System.EventHandler(this.Button_Undo_Load);
            // 
            // Control_Scale
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.Controls.Add(this.Controls_LayoutPanel);
            this.Controls.Add(this.ScaleView);
            this.Controls.Add(this.Scale_Tracker);
            this.DoubleBuffered = true;
            this.Name = "Control_Scale";
            this.Size = new System.Drawing.Size(400, 315);
            this.Load += new System.EventHandler(this.Control_Scale_Load);
            this.VisibleChanged += new System.EventHandler(this.Control_Scale_VisibleChanged);
            ((System.ComponentModel.ISupportInitialize)(this.Scale_Tracker)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ScaleView)).EndInit();
            this.Controls_Group.ResumeLayout(false);
            this.Controls_LayoutPanel.ResumeLayout(false);
            this.Controls_LayoutPanel.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label Label_StatusPercentage;
        private System.Windows.Forms.TrackBar Scale_Tracker;
        private System.Windows.Forms.PictureBox ScaleView;
        private Elements.Round_Button Button_Done;
        private System.Windows.Forms.FlowLayoutPanel Controls_Group;
        private System.Windows.Forms.TableLayoutPanel Controls_LayoutPanel;
        private Elements.Round_Button Button_Undo;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
    }
}
