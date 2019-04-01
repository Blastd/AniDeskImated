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
            this.Button_Done = new AniDeskimated.Forms.Elements.Round_Button();
            this.Controls_Group = new System.Windows.Forms.FlowLayoutPanel();
            this.Button_Undo = new AniDeskimated.Forms.Elements.Round_Button();
            this.Controls_LayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.Vol_Icon = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this.Volume_Tracker)).BeginInit();
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
            this.Label_StatusPercentage.Text = "10%";
            this.Label_StatusPercentage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Volume_Tracker
            // 
            this.Volume_Tracker.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.Volume_Tracker.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.Volume_Tracker.LargeChange = 10;
            this.Volume_Tracker.Location = new System.Drawing.Point(0, 167);
            this.Volume_Tracker.Maximum = 100;
            this.Volume_Tracker.Name = "Volume_Tracker";
            this.Volume_Tracker.Size = new System.Drawing.Size(400, 45);
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
            this.Button_Done.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(56)))), ((int)(((byte)(145)))));
            this.Button_Done.Location = new System.Drawing.Point(10, 10);
            this.Button_Done.Margin = new System.Windows.Forms.Padding(10);
            this.Button_Done.MinimumSize = new System.Drawing.Size(30, 30);
            this.Button_Done.Name = "Button_Done";
            this.Button_Done.Size = new System.Drawing.Size(45, 30);
            this.Button_Done.TabIndex = 5;
            this.Button_Done.Click += new System.EventHandler(this.Button_Done_Click);
            // 
            // Controls_Group
            // 
            this.Controls_Group.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.Controls_Group.AutoSize = true;
            this.Controls_Group.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Controls_Group.Controls.Add(this.Label_StatusPercentage);
            this.Controls_Group.Location = new System.Drawing.Point(171, 3);
            this.Controls_Group.Name = "Controls_Group";
            this.Controls_Group.Size = new System.Drawing.Size(58, 35);
            this.Controls_Group.TabIndex = 15;
            // 
            // Button_Undo
            // 
            this.Button_Undo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.Button_Undo.BackColor = System.Drawing.Color.Transparent;
            this.Button_Undo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(56)))), ((int)(((byte)(145)))));
            this.Button_Undo.Location = new System.Drawing.Point(75, 10);
            this.Button_Undo.Margin = new System.Windows.Forms.Padding(10);
            this.Button_Undo.MinimumSize = new System.Drawing.Size(30, 30);
            this.Button_Undo.Name = "Button_Undo";
            this.Button_Undo.Size = new System.Drawing.Size(45, 30);
            this.Button_Undo.TabIndex = 9;
            this.Button_Undo.Click += new System.EventHandler(this.Button_Undo_Load);
            // 
            // Controls_LayoutPanel
            // 
            this.Controls_LayoutPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Controls_LayoutPanel.ColumnCount = 1;
            this.Controls_LayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.Controls_LayoutPanel.Controls.Add(this.Controls_Group, 0, 0);
            this.Controls_LayoutPanel.Controls.Add(this.flowLayoutPanel1, 0, 1);
            this.Controls_LayoutPanel.Location = new System.Drawing.Point(0, 225);
            this.Controls_LayoutPanel.Name = "Controls_LayoutPanel";
            this.Controls_LayoutPanel.RowCount = 2;
            this.Controls_LayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.Controls_LayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 66.66666F));
            this.Controls_LayoutPanel.Size = new System.Drawing.Size(400, 125);
            this.Controls_LayoutPanel.TabIndex = 16;
            // 
            // Vol_Icon
            // 
            this.Vol_Icon.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.Vol_Icon.Font = new System.Drawing.Font("Segoe MDL2 Assets", 50F);
            this.Vol_Icon.ForeColor = System.Drawing.Color.White;
            this.Vol_Icon.Location = new System.Drawing.Point(3, 25);
            this.Vol_Icon.Name = "Vol_Icon";
            this.Vol_Icon.Size = new System.Drawing.Size(397, 102);
            this.Vol_Icon.TabIndex = 17;
            this.Vol_Icon.Text = "A";
            this.Vol_Icon.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.flowLayoutPanel1.AutoSize = true;
            this.flowLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flowLayoutPanel1.Controls.Add(this.Button_Done);
            this.flowLayoutPanel1.Controls.Add(this.Button_Undo);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(135, 44);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(130, 78);
            this.flowLayoutPanel1.TabIndex = 16;
            // 
            // Control_Volume
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.Controls.Add(this.Vol_Icon);
            this.Controls.Add(this.Controls_LayoutPanel);
            this.Controls.Add(this.Volume_Tracker);
            this.Name = "Control_Volume";
            this.Size = new System.Drawing.Size(400, 350);
            this.Load += new System.EventHandler(this.Control_Volume_Load);
            this.VisibleChanged += new System.EventHandler(this.Control_Volume_VisibleChanged);
            ((System.ComponentModel.ISupportInitialize)(this.Volume_Tracker)).EndInit();
            this.Controls_Group.ResumeLayout(false);
            this.Controls_LayoutPanel.ResumeLayout(false);
            this.Controls_LayoutPanel.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label Label_StatusPercentage;
        private System.Windows.Forms.TrackBar Volume_Tracker;
        private Elements.Round_Button Button_Done;
        private System.Windows.Forms.FlowLayoutPanel Controls_Group;
        private System.Windows.Forms.TableLayoutPanel Controls_LayoutPanel;
        private System.Windows.Forms.Label Vol_Icon;
        private Elements.Round_Button Button_Undo;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
    }
}
