﻿using AniDeskimated.Forms;

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
            this.Menu_Color = new System.Windows.Forms.ColorDialog();
            this.Button_Exit = new System.Windows.Forms.Button();
            this.Button_Magnifier = new System.Windows.Forms.Button();
            this.Button_VideoVolume = new System.Windows.Forms.Button();
            this.Check_WindowsStartup = new System.Windows.Forms.CheckBox();
            this.Button_ADT_Settings = new System.Windows.Forms.Button();
            this.Tip_Scale = new System.Windows.Forms.ToolTip(this.components);
            this.Tip_Volume = new System.Windows.Forms.ToolTip(this.components);
            this.Tip_ADT_Settings = new System.Windows.Forms.ToolTip(this.components);
            this.F_type = new System.Windows.Forms.Label();
            this.BVolume_Control = new AniDeskimated.Forms.Media_Settings.Control_Volume();
            this.Acontrol_Scale = new AniDeskimated.Forms.Media_Settings.Control_Scale();
            this.Button_NewMedia = new AniDeskimated.Forms.Elements.Round_Button();
            this.ContextMenu_IconBar.SuspendLayout();
            this.BackMenuChoose.SuspendLayout();
            this.ColorPickMenuChoose.SuspendLayout();
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
            this.ContextMenu_IconBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.ContextMenu_IconBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.IconButton_Browse,
            this.IconButton_Quit});
            this.ContextMenu_IconBar.Name = "icon_bar";
            this.ContextMenu_IconBar.ShowImageMargin = false;
            this.ContextMenu_IconBar.Size = new System.Drawing.Size(171, 48);
            // 
            // IconButton_Browse
            // 
            this.IconButton_Browse.Font = new System.Drawing.Font("Segoe UI Black", 9F);
            this.IconButton_Browse.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.IconButton_Browse.Name = "IconButton_Browse";
            this.IconButton_Browse.Size = new System.Drawing.Size(170, 22);
            this.IconButton_Browse.Text = "Change Background";
            this.IconButton_Browse.Click += new System.EventHandler(this.IconButton_Browse_Click);
            // 
            // IconButton_Quit
            // 
            this.IconButton_Quit.Font = new System.Drawing.Font("Segoe UI Black", 9F);
            this.IconButton_Quit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.IconButton_Quit.Name = "IconButton_Quit";
            this.IconButton_Quit.Size = new System.Drawing.Size(170, 22);
            this.IconButton_Quit.Text = "Quit";
            this.IconButton_Quit.Click += new System.EventHandler(this.IconButton_Quit_Click);
            // 
            // GetMediaFile
            // 
            this.GetMediaFile.Filter = "Supported Files|*.gif;*.jpg;*.jpeg;*.bmp*;.wmf;*.png;*.mp4;*.dll|ADT Files|*.dll|" +
    "Image files|*.gif;*.jpg;*.jpeg;*.bmp*;.wmf;*.png|Video files|*.mp4;*.webm";
            this.GetMediaFile.InitialDirectory = "%USERPROFILE%\\Pictures";
            this.GetMediaFile.Title = "Select a Media File";
            this.GetMediaFile.FileOk += new System.ComponentModel.CancelEventHandler(this.GetMediaFile_FileOk);
            this.GetMediaFile.HelpRequest += new System.EventHandler(this.GetMediaFile_HelpRequest);
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
            this.BackMenu_WebComponent.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.BackMenu_WebComponent.Name = "BackMenu_WebComponent";
            this.BackMenu_WebComponent.Size = new System.Drawing.Size(177, 22);
            this.BackMenu_WebComponent.Text = "Online";
            this.BackMenu_WebComponent.Click += new System.EventHandler(this.BackMenu_WebComponent_Click);
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
            this.Button_Color_Choose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.Button_Color_Choose.FlatAppearance.BorderSize = 0;
            this.Button_Color_Choose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button_Color_Choose.Font = new System.Drawing.Font("Segoe MDL2 Assets", 12F);
            this.Button_Color_Choose.ForeColor = System.Drawing.Color.White;
            this.Button_Color_Choose.Location = new System.Drawing.Point(375, 310);
            this.Button_Color_Choose.Name = "Button_Color_Choose";
            this.Button_Color_Choose.Size = new System.Drawing.Size(32, 32);
            this.Button_Color_Choose.TabIndex = 6;
            this.Button_Color_Choose.Text = "";
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
            this.App_About.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.App_About.FlatAppearance.BorderSize = 0;
            this.App_About.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.App_About.Font = new System.Drawing.Font("Segoe MDL2 Assets", 15F);
            this.App_About.ForeColor = System.Drawing.Color.White;
            this.App_About.Location = new System.Drawing.Point(36, 312);
            this.App_About.Name = "App_About";
            this.App_About.Size = new System.Drawing.Size(32, 30);
            this.App_About.TabIndex = 7;
            this.App_About.Text = "";
            this.App_About.UseVisualStyleBackColor = false;
            this.App_About.Click += new System.EventHandler(this.App_About_Click);
            this.App_About.Paint += new System.Windows.Forms.PaintEventHandler(this.App_About_Paint);
            // 
            // Menu_Color
            // 
            this.Menu_Color.AnyColor = true;
            // 
            // Button_Exit
            // 
            this.Button_Exit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(255)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Button_Exit.FlatAppearance.BorderSize = 0;
            this.Button_Exit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(205)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Button_Exit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(235)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Button_Exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button_Exit.Font = new System.Drawing.Font("Segoe MDL2 Assets", 10F);
            this.Button_Exit.ForeColor = System.Drawing.Color.White;
            this.Button_Exit.Location = new System.Drawing.Point(408, 0);
            this.Button_Exit.Margin = new System.Windows.Forms.Padding(0);
            this.Button_Exit.Name = "Button_Exit";
            this.Button_Exit.Size = new System.Drawing.Size(32, 25);
            this.Button_Exit.TabIndex = 12;
            this.Button_Exit.Text = "";
            this.Button_Exit.UseVisualStyleBackColor = false;
            this.Button_Exit.Click += new System.EventHandler(this.Button_Exit_Click);
            // 
            // Button_Magnifier
            // 
            this.Button_Magnifier.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.Button_Magnifier.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Button_Magnifier.FlatAppearance.BorderSize = 0;
            this.Button_Magnifier.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.Button_Magnifier.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.Button_Magnifier.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button_Magnifier.Font = new System.Drawing.Font("Segoe MDL2 Assets", 14.5F);
            this.Button_Magnifier.ForeColor = System.Drawing.Color.White;
            this.Button_Magnifier.Location = new System.Drawing.Point(1, 65);
            this.Button_Magnifier.Margin = new System.Windows.Forms.Padding(0);
            this.Button_Magnifier.Name = "Button_Magnifier";
            this.Button_Magnifier.Size = new System.Drawing.Size(32, 32);
            this.Button_Magnifier.TabIndex = 16;
            this.Button_Magnifier.TabStop = false;
            this.Button_Magnifier.Text = "";
            this.Tip_Scale.SetToolTip(this.Button_Magnifier, "Scale your image/video");
            this.Button_Magnifier.UseVisualStyleBackColor = false;
            this.Button_Magnifier.Click += new System.EventHandler(this.Button_Magnifier_Click);
            // 
            // Button_VideoVolume
            // 
            this.Button_VideoVolume.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.Button_VideoVolume.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Button_VideoVolume.FlatAppearance.BorderSize = 0;
            this.Button_VideoVolume.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.Button_VideoVolume.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.Button_VideoVolume.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button_VideoVolume.Font = new System.Drawing.Font("Segoe MDL2 Assets", 14.5F);
            this.Button_VideoVolume.ForeColor = System.Drawing.Color.White;
            this.Button_VideoVolume.Location = new System.Drawing.Point(1, 97);
            this.Button_VideoVolume.Margin = new System.Windows.Forms.Padding(0);
            this.Button_VideoVolume.Name = "Button_VideoVolume";
            this.Button_VideoVolume.Size = new System.Drawing.Size(32, 32);
            this.Button_VideoVolume.TabIndex = 17;
            this.Button_VideoVolume.TabStop = false;
            this.Button_VideoVolume.Text = "";
            this.Tip_Volume.SetToolTip(this.Button_VideoVolume, "Adapt video\'s volume");
            this.Button_VideoVolume.UseVisualStyleBackColor = false;
            this.Button_VideoVolume.Click += new System.EventHandler(this.Button_VideoVolume_Click);
            // 
            // Check_WindowsStartup
            // 
            this.Check_WindowsStartup.AutoSize = true;
            this.Check_WindowsStartup.Font = new System.Drawing.Font("Segoe UI Black", 8.25F);
            this.Check_WindowsStartup.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.Check_WindowsStartup.Location = new System.Drawing.Point(154, 8);
            this.Check_WindowsStartup.Name = "Check_WindowsStartup";
            this.Check_WindowsStartup.Size = new System.Drawing.Size(133, 17);
            this.Check_WindowsStartup.TabIndex = 18;
            this.Check_WindowsStartup.Text = "Start with Windows";
            this.Check_WindowsStartup.UseVisualStyleBackColor = true;
            this.Check_WindowsStartup.CheckedChanged += new System.EventHandler(this.Check_WindowsStartup_CheckedChanged);
            // 
            // Button_ADT_Settings
            // 
            this.Button_ADT_Settings.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.Button_ADT_Settings.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Button_ADT_Settings.FlatAppearance.BorderSize = 0;
            this.Button_ADT_Settings.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.Button_ADT_Settings.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.Button_ADT_Settings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button_ADT_Settings.Font = new System.Drawing.Font("Segoe MDL2 Assets", 14.5F);
            this.Button_ADT_Settings.ForeColor = System.Drawing.Color.White;
            this.Button_ADT_Settings.Location = new System.Drawing.Point(408, 65);
            this.Button_ADT_Settings.Margin = new System.Windows.Forms.Padding(0);
            this.Button_ADT_Settings.Name = "Button_ADT_Settings";
            this.Button_ADT_Settings.Size = new System.Drawing.Size(32, 64);
            this.Button_ADT_Settings.TabIndex = 19;
            this.Button_ADT_Settings.TabStop = false;
            this.Button_ADT_Settings.Text = "";
            this.Tip_ADT_Settings.SetToolTip(this.Button_ADT_Settings, "Change your selected custom theme\'s settings");
            this.Button_ADT_Settings.UseVisualStyleBackColor = false;
            this.Button_ADT_Settings.Click += new System.EventHandler(this.Button_ADT_Settings_Click);
            // 
            // Tip_Scale
            // 
            this.Tip_Scale.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.Tip_Scale.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.Tip_Scale.ToolTipTitle = "Scale";
            // 
            // Tip_Volume
            // 
            this.Tip_Volume.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.Tip_Volume.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.Tip_Volume.ToolTipTitle = "Volume";
            // 
            // Tip_ADT_Settings
            // 
            this.Tip_ADT_Settings.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.Tip_ADT_Settings.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.Tip_ADT_Settings.ToolTipTitle = "Custom theme settings";
            // 
            // F_type
            // 
            this.F_type.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.F_type.Font = new System.Drawing.Font("Segoe MDL2 Assets", 40F);
            this.F_type.ForeColor = System.Drawing.Color.White;
            this.F_type.Location = new System.Drawing.Point(35, 31);
            this.F_type.Name = "F_type";
            this.F_type.Size = new System.Drawing.Size(370, 268);
            this.F_type.TabIndex = 20;
            this.F_type.Text = "\\uF259";
            this.F_type.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // BVolume_Control
            // 
            this.BVolume_Control.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.BVolume_Control.Location = new System.Drawing.Point(0, 0);
            this.BVolume_Control.Name = "BVolume_Control";
            this.BVolume_Control.Size = new System.Drawing.Size(10, 350);
            this.BVolume_Control.TabIndex = 15;
            this.BVolume_Control.Visible = false;
            // 
            // Acontrol_Scale
            // 
            this.Acontrol_Scale.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.Acontrol_Scale.Location = new System.Drawing.Point(0, 0);
            this.Acontrol_Scale.Name = "Acontrol_Scale";
            this.Acontrol_Scale.Size = new System.Drawing.Size(10, 350);
            this.Acontrol_Scale.TabIndex = 16;
            this.Acontrol_Scale.Visible = false;
            // 
            // Button_NewMedia
            // 
            this.Button_NewMedia.BackColor = System.Drawing.Color.Transparent;
            this.Button_NewMedia.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(56)))), ((int)(((byte)(145)))));
            this.Button_NewMedia.Location = new System.Drawing.Point(70, 310);
            this.Button_NewMedia.Margin = new System.Windows.Forms.Padding(0);
            this.Button_NewMedia.MinimumSize = new System.Drawing.Size(30, 30);
            this.Button_NewMedia.Name = "Button_NewMedia";
            this.Button_NewMedia.Size = new System.Drawing.Size(302, 30);
            this.Button_NewMedia.TabIndex = 9;
            this.Button_NewMedia.Click += new System.EventHandler(this.Button_NewMedia_Click);
            // 
            // DeskSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.ClientSize = new System.Drawing.Size(440, 350);
            this.Controls.Add(this.BVolume_Control);
            this.Controls.Add(this.Acontrol_Scale);
            this.Controls.Add(this.Button_ADT_Settings);
            this.Controls.Add(this.Check_WindowsStartup);
            this.Controls.Add(this.Button_VideoVolume);
            this.Controls.Add(this.Button_Magnifier);
            this.Controls.Add(this.Button_Exit);
            this.Controls.Add(this.Button_NewMedia);
            this.Controls.Add(this.App_About);
            this.Controls.Add(this.Button_Color_Choose);
            this.Controls.Add(this.F_type);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = global::AniDeskimated.Properties.Resources.NIcon;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "DeskSettings";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Settings";
            this.TopMost = true;
            this.WindowState = System.Windows.Forms.FormWindowState.Minimized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.DeskSettings_FormClosing);
            this.Load += new System.EventHandler(this.DeskSettings_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.DeskSettings_Paint);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.DeskSettings_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.DeskSettings_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.DeskSettings_MouseUp);
            this.ContextMenu_IconBar.ResumeLayout(false);
            this.BackMenuChoose.ResumeLayout(false);
            this.ColorPickMenuChoose.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NotifyIcon TaskBar_Notify_Icon;
        private System.Windows.Forms.ContextMenuStrip ContextMenu_IconBar;
        private System.Windows.Forms.ToolStripMenuItem IconButton_Browse;
        private System.Windows.Forms.ToolStripMenuItem IconButton_Quit;
        private System.Windows.Forms.OpenFileDialog GetMediaFile;
        private System.Windows.Forms.ContextMenuStrip BackMenuChoose;
        private System.Windows.Forms.ToolStripMenuItem BackMenu_Locale;
        private System.Windows.Forms.ToolStripMenuItem BackMenu_WebComponent;
        private System.Windows.Forms.Button Button_Color_Choose;
        private System.Windows.Forms.ContextMenuStrip ColorPickMenuChoose;
        private System.Windows.Forms.ToolStripMenuItem ColorPick_Screen;
        private System.Windows.Forms.ToolStripMenuItem ColorPick_Menù;
        private System.Windows.Forms.Button App_About;
        private System.Windows.Forms.ToolStripMenuItem Online_Store;
        private System.Windows.Forms.ColorDialog Menu_Color;
        private Forms.Elements.Round_Button Button_NewMedia;
        private System.Windows.Forms.Button Button_Exit;
        private Forms.Media_Settings.Control_Volume BVolume_Control;
        private Forms.Media_Settings.Control_Scale Acontrol_Scale;
        private System.Windows.Forms.Button Button_Magnifier;
        private System.Windows.Forms.Button Button_VideoVolume;
        private System.Windows.Forms.CheckBox Check_WindowsStartup;
        private System.Windows.Forms.Button Button_ADT_Settings;
        private System.Windows.Forms.ToolTip Tip_Scale;
        private System.Windows.Forms.ToolTip Tip_Volume;
        private System.Windows.Forms.ToolTip Tip_ADT_Settings;
        private System.Windows.Forms.Label F_type;
    }
}

