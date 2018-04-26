namespace AniDeskimated
{
    partial class DeskSettings
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

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.TaskBar_Notify_Icon = new System.Windows.Forms.NotifyIcon(this.components);
            this.ContextMenu_IconBar = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.IconButton_Browse = new System.Windows.Forms.ToolStripMenuItem();
            this.IconButton_Quit = new System.Windows.Forms.ToolStripMenuItem();
            this.Button_Browse = new System.Windows.Forms.Button();
            this.GetMediaFile = new System.Windows.Forms.OpenFileDialog();
            this.BackMenuChoose = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.BackMenu_Locale = new System.Windows.Forms.ToolStripMenuItem();
            this.BackMenu_WebComponent = new System.Windows.Forms.ToolStripMenuItem();
            this.Online_Store = new System.Windows.Forms.ToolStripMenuItem();
            this.Button_Color_Choose = new System.Windows.Forms.Button();
            this.ColorPickMenuChoose = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.ColorPick_Screen = new System.Windows.Forms.ToolStripMenuItem();
            this.ColorPick_Menù = new System.Windows.Forms.ToolStripMenuItem();
            this.App_About = new System.Windows.Forms.Button();
            this.Resize_MediaFile = new System.Windows.Forms.Button();
            this.Viewpreview = new System.Windows.Forms.PictureBox();
            this.Menu_Color = new System.Windows.Forms.ColorDialog();
            this.ContextMenu_IconBar.SuspendLayout();
            this.BackMenuChoose.SuspendLayout();
            this.ColorPickMenuChoose.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Viewpreview)).BeginInit();
            this.SuspendLayout();
            // 
            // TaskBar_Notify_Icon
            // 
            this.TaskBar_Notify_Icon.ContextMenuStrip = this.ContextMenu_IconBar;
            this.TaskBar_Notify_Icon.Icon = global::AniDeskimated.Properties.Resources.NIcon;
            this.TaskBar_Notify_Icon.Text = "AniDeskimated";
            this.TaskBar_Notify_Icon.Visible = true;
            this.TaskBar_Notify_Icon.DoubleClick += new System.EventHandler(this.TaskBar_Notify_Icon_DoubleClick);
            // 
            // ContextMenu_IconBar
            // 
            this.ContextMenu_IconBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(16)))), ((int)(((byte)(16)))));
            this.ContextMenu_IconBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.IconButton_Browse,
            this.IconButton_Quit});
            this.ContextMenu_IconBar.Name = "icon_bar";
            this.ContextMenu_IconBar.ShowImageMargin = false;
            this.ContextMenu_IconBar.Size = new System.Drawing.Size(191, 56);
            // 
            // IconButton_Browse
            // 
            this.IconButton_Browse.Font = new System.Drawing.Font("Segoe UI Light", 12F);
            this.IconButton_Browse.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.IconButton_Browse.Name = "IconButton_Browse";
            this.IconButton_Browse.Size = new System.Drawing.Size(190, 26);
            this.IconButton_Browse.Text = "Change Background";
            this.IconButton_Browse.Click += new System.EventHandler(this.IconButton_Browse_Click);
            // 
            // IconButton_Quit
            // 
            this.IconButton_Quit.Font = new System.Drawing.Font("Segoe UI Light", 12F);
            this.IconButton_Quit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.IconButton_Quit.Name = "IconButton_Quit";
            this.IconButton_Quit.Size = new System.Drawing.Size(190, 26);
            this.IconButton_Quit.Text = "Quit";
            this.IconButton_Quit.Click += new System.EventHandler(this.IconButton_Quit_Click);
            // 
            // Button_Browse
            // 
            this.Button_Browse.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.Button_Browse.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(8)))), ((int)(((byte)(8)))));
            this.Button_Browse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button_Browse.Font = new System.Drawing.Font("Segoe UI Black", 12F);
            this.Button_Browse.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Button_Browse.Location = new System.Drawing.Point(102, 270);
            this.Button_Browse.Name = "Button_Browse";
            this.Button_Browse.Size = new System.Drawing.Size(300, 40);
            this.Button_Browse.TabIndex = 4;
            this.Button_Browse.Text = "New Idea";
            this.Button_Browse.UseVisualStyleBackColor = false;
            this.Button_Browse.Click += new System.EventHandler(this.Browse_Button_Click);
            // 
            // GetMediaFile
            // 
            this.GetMediaFile.Filter = "Supported Files|*.gif;*.jpg;*.jpeg;*.bmp*;.wmf;*.png;*.mp4";
            this.GetMediaFile.InitialDirectory = "%USERPROFILE%\\Pictures";
            this.GetMediaFile.Title = "Select a Media File";
            this.GetMediaFile.FileOk += new System.ComponentModel.CancelEventHandler(this.GetMediaFile_FileOk);
            // 
            // BackMenuChoose
            // 
            this.BackMenuChoose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.BackMenuChoose.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.BackMenu_Locale,
            this.BackMenu_WebComponent,
            this.Online_Store});
            this.BackMenuChoose.Name = "BackMenuChoose";
            this.BackMenuChoose.ShowImageMargin = false;
            this.BackMenuChoose.Size = new System.Drawing.Size(178, 70);
            this.BackMenuChoose.Text = "Choose background type";
            // 
            // BackMenu_Locale
            // 
            this.BackMenu_Locale.Font = new System.Drawing.Font("Segoe UI Black", 9F);
            this.BackMenu_Locale.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.BackMenu_Locale.Name = "BackMenu_Locale";
            this.BackMenu_Locale.Size = new System.Drawing.Size(177, 22);
            this.BackMenu_Locale.Text = "Files on my computer";
            this.BackMenu_Locale.Click += new System.EventHandler(this.BackMenu_Gif_Click);
            // 
            // BackMenu_WebComponent
            // 
            this.BackMenu_WebComponent.Font = new System.Drawing.Font("Segoe UI Black", 9F);
            this.BackMenu_WebComponent.ForeColor = System.Drawing.Color.Gray;
            this.BackMenu_WebComponent.Name = "BackMenu_WebComponent";
            this.BackMenu_WebComponent.Size = new System.Drawing.Size(177, 22);
            this.BackMenu_WebComponent.Text = "Not Implemented";
            // 
            // Online_Store
            // 
            this.Online_Store.Font = new System.Drawing.Font("Segoe UI Black", 9F);
            this.Online_Store.ForeColor = System.Drawing.Color.Gray;
            this.Online_Store.Name = "Online_Store";
            this.Online_Store.Size = new System.Drawing.Size(177, 22);
            this.Online_Store.Text = "Not Implemented";
            // 
            // Button_Color_Choose
            // 
            this.Button_Color_Choose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(16)))), ((int)(((byte)(16)))));
            this.Button_Color_Choose.FlatAppearance.BorderSize = 0;
            this.Button_Color_Choose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button_Color_Choose.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.Button_Color_Choose.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.Button_Color_Choose.Location = new System.Drawing.Point(416, 75);
            this.Button_Color_Choose.Name = "Button_Color_Choose";
            this.Button_Color_Choose.Size = new System.Drawing.Size(50, 50);
            this.Button_Color_Choose.TabIndex = 6;
            this.Button_Color_Choose.Text = "C";
            this.Button_Color_Choose.UseVisualStyleBackColor = false;
            this.Button_Color_Choose.Click += new System.EventHandler(this.Choose_Color_Click);
            this.Button_Color_Choose.Paint += new System.Windows.Forms.PaintEventHandler(this.Choose_Color_Paint);
            // 
            // ColorPickMenuChoose
            // 
            this.ColorPickMenuChoose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.ColorPickMenuChoose.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ColorPick_Screen,
            this.ColorPick_Menù});
            this.ColorPickMenuChoose.Name = "BackMenuChoose";
            this.ColorPickMenuChoose.ShowImageMargin = false;
            this.ColorPickMenuChoose.Size = new System.Drawing.Size(172, 48);
            this.ColorPickMenuChoose.Text = "Choose background type";
            // 
            // ColorPick_Screen
            // 
            this.ColorPick_Screen.Font = new System.Drawing.Font("Segoe UI Black", 9F);
            this.ColorPick_Screen.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.ColorPick_Screen.Name = "ColorPick_Screen";
            this.ColorPick_Screen.Size = new System.Drawing.Size(171, 22);
            this.ColorPick_Screen.Text = "Pick from Media File";
            this.ColorPick_Screen.Click += new System.EventHandler(this.ColorPick_Screen_Click);
            // 
            // ColorPick_Menù
            // 
            this.ColorPick_Menù.Font = new System.Drawing.Font("Segoe UI Black", 9F);
            this.ColorPick_Menù.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.ColorPick_Menù.Name = "ColorPick_Menù";
            this.ColorPick_Menù.Size = new System.Drawing.Size(171, 22);
            this.ColorPick_Menù.Text = "Color menù";
            this.ColorPick_Menù.Click += new System.EventHandler(this.ColorPick_Menù_Click);
            // 
            // App_About
            // 
            this.App_About.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(16)))), ((int)(((byte)(16)))));
            this.App_About.FlatAppearance.BorderSize = 0;
            this.App_About.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.App_About.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.App_About.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.App_About.Location = new System.Drawing.Point(9, 307);
            this.App_About.Name = "App_About";
            this.App_About.Size = new System.Drawing.Size(26, 26);
            this.App_About.TabIndex = 7;
            this.App_About.Text = "i";
            this.App_About.UseVisualStyleBackColor = false;
            this.App_About.Click += new System.EventHandler(this.App_About_Click);
            this.App_About.Paint += new System.Windows.Forms.PaintEventHandler(this.App_About_Paint);
            // 
            // Resize_MediaFile
            // 
            this.Resize_MediaFile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(16)))), ((int)(((byte)(16)))));
            this.Resize_MediaFile.FlatAppearance.BorderSize = 0;
            this.Resize_MediaFile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Resize_MediaFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.Resize_MediaFile.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.Resize_MediaFile.Location = new System.Drawing.Point(37, 75);
            this.Resize_MediaFile.Name = "Resize_MediaFile";
            this.Resize_MediaFile.Size = new System.Drawing.Size(50, 50);
            this.Resize_MediaFile.TabIndex = 8;
            this.Resize_MediaFile.Text = "C";
            this.Resize_MediaFile.UseVisualStyleBackColor = false;
            this.Resize_MediaFile.Visible = false;
            // 
            // Viewpreview
            // 
            this.Viewpreview.BackColor = System.Drawing.Color.Transparent;
            this.Viewpreview.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Viewpreview.ErrorImage = null;
            this.Viewpreview.Location = new System.Drawing.Point(127, 20);
            this.Viewpreview.Name = "Viewpreview";
            this.Viewpreview.Size = new System.Drawing.Size(250, 164);
            this.Viewpreview.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Viewpreview.TabIndex = 3;
            this.Viewpreview.TabStop = false;
            // 
            // Menu_Color
            // 
            this.Menu_Color.AnyColor = true;
            // 
            // DeskSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(16)))), ((int)(((byte)(16)))));
            this.ClientSize = new System.Drawing.Size(504, 341);
            this.Controls.Add(this.Resize_MediaFile);
            this.Controls.Add(this.App_About);
            this.Controls.Add(this.Button_Color_Choose);
            this.Controls.Add(this.Button_Browse);
            this.Controls.Add(this.Viewpreview);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = global::AniDeskimated.Properties.Resources.NIcon;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "DeskSettings";
            this.ShowIcon = false;
            this.Text = "Settings";
            this.TopMost = true;
            this.WindowState = System.Windows.Forms.FormWindowState.Minimized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.DeskSettings_FormClosing);
            this.Load += new System.EventHandler(this.DeskSettings_Load);
            this.ContextMenu_IconBar.ResumeLayout(false);
            this.BackMenuChoose.ResumeLayout(false);
            this.ColorPickMenuChoose.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Viewpreview)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.NotifyIcon TaskBar_Notify_Icon;
        private System.Windows.Forms.ContextMenuStrip ContextMenu_IconBar;
        private System.Windows.Forms.ToolStripMenuItem IconButton_Browse;
        private System.Windows.Forms.ToolStripMenuItem IconButton_Quit;
        private System.Windows.Forms.PictureBox Viewpreview;
        private System.Windows.Forms.Button Button_Browse;
        private System.Windows.Forms.OpenFileDialog GetMediaFile;
        private System.Windows.Forms.ContextMenuStrip BackMenuChoose;
        private System.Windows.Forms.ToolStripMenuItem BackMenu_Locale;
        private System.Windows.Forms.ToolStripMenuItem BackMenu_WebComponent;
        private System.Windows.Forms.Button Button_Color_Choose;
        private System.Windows.Forms.ContextMenuStrip ColorPickMenuChoose;
        private System.Windows.Forms.ToolStripMenuItem ColorPick_Screen;
        private System.Windows.Forms.ToolStripMenuItem ColorPick_Menù;
        private System.Windows.Forms.Button App_About;
        private System.Windows.Forms.Button Resize_MediaFile;
        private System.Windows.Forms.ToolStripMenuItem Online_Store;
        private System.Windows.Forms.ColorDialog Menu_Color;
    }
}

