using System;

namespace AniDeskimated.Forms
{
    partial class App_Init
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
            this.components = new System.ComponentModel.Container();
            this.GetMediaFile = new System.Windows.Forms.OpenFileDialog();
            this.BackMenuChoose = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.BackMenu_Gif = new System.Windows.Forms.ToolStripMenuItem();
            this.BackMenu_WebComponent = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.ColorPicker_MenuPicker = new System.Windows.Forms.ColorDialog();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.Button_Informations = new AniDeskimated.Forms.Elements.Round_Button();
            this.Button_NewFile = new AniDeskimated.Forms.Elements.Round_Button();
            this.Button_Refuse = new AniDeskimated.Forms.Elements.Round_Button();
            this.ViewFrame = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.BackMenuChoose.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ViewFrame)).BeginInit();
            this.SuspendLayout();
            // 
            // GetMediaFile
            // 
            this.GetMediaFile.Filter = "Supported Files|*.gif;*.jpg;*.jpeg;*.bmp*;.wmf;*.png;*.mp4";
            this.GetMediaFile.InitialDirectory = "%USERPROFILE%\\Pictures";
            this.GetMediaFile.FileOk += new System.ComponentModel.CancelEventHandler(this.GetMediaFile_FileOk);
            // 
            // BackMenuChoose
            // 
            this.BackMenuChoose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.BackMenuChoose.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.BackMenu_Gif,
            this.BackMenu_WebComponent,
            this.toolStripMenuItem1});
            this.BackMenuChoose.Name = "BackMenuChoose";
            this.BackMenuChoose.ShowImageMargin = false;
            this.BackMenuChoose.Size = new System.Drawing.Size(178, 70);
            this.BackMenuChoose.Text = "Choose background type";
            // 
            // BackMenu_Gif
            // 
            this.BackMenu_Gif.Font = new System.Drawing.Font("Segoe UI Black", 9F);
            this.BackMenu_Gif.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.BackMenu_Gif.Name = "BackMenu_Gif";
            this.BackMenu_Gif.Size = new System.Drawing.Size(177, 22);
            this.BackMenu_Gif.Text = "Files on my computer";
            this.BackMenu_Gif.Click += new System.EventHandler(this.BackMenu_Gif_Click);
            // 
            // BackMenu_WebComponent
            // 
            this.BackMenu_WebComponent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.BackMenu_WebComponent.Font = new System.Drawing.Font("Segoe UI Black", 9F);
            this.BackMenu_WebComponent.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.BackMenu_WebComponent.Name = "BackMenu_WebComponent";
            this.BackMenu_WebComponent.Size = new System.Drawing.Size(177, 22);
            this.BackMenu_WebComponent.Text = "Online";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Font = new System.Drawing.Font("Segoe UI Black", 9F);
            this.toolStripMenuItem1.ForeColor = System.Drawing.Color.Gray;
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(177, 22);
            this.toolStripMenuItem1.Text = "Not Implemented";
            // 
            // ColorPicker_MenuPicker
            // 
            this.ColorPicker_MenuPicker.AnyColor = true;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.Button_Informations);
            this.flowLayoutPanel1.Controls.Add(this.Button_NewFile);
            this.flowLayoutPanel1.Controls.Add(this.Button_Refuse);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 351);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(590, 40);
            this.flowLayoutPanel1.TabIndex = 2;
            // 
            // Button_Informations
            // 
            this.Button_Informations.BackColor = System.Drawing.Color.Transparent;
            this.Button_Informations.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(145)))), ((int)(((byte)(145)))));
            this.Button_Informations.Location = new System.Drawing.Point(0, 0);
            this.Button_Informations.Margin = new System.Windows.Forms.Padding(0);
            this.Button_Informations.MinimumSize = new System.Drawing.Size(30, 30);
            this.Button_Informations.Name = "Button_Informations";
            this.Button_Informations.Size = new System.Drawing.Size(135, 40);
            this.Button_Informations.TabIndex = 5;
            this.Button_Informations.Click += new System.EventHandler(this.Button_Informations_Click);
            // 
            // Button_NewFile
            // 
            this.Button_NewFile.BackColor = System.Drawing.Color.Transparent;
            this.Button_NewFile.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(145)))), ((int)(((byte)(145)))));
            this.Button_NewFile.Location = new System.Drawing.Point(135, 0);
            this.Button_NewFile.Margin = new System.Windows.Forms.Padding(0);
            this.Button_NewFile.MinimumSize = new System.Drawing.Size(30, 30);
            this.Button_NewFile.Name = "Button_NewFile";
            this.Button_NewFile.Size = new System.Drawing.Size(320, 40);
            this.Button_NewFile.TabIndex = 4;
            this.Button_NewFile.Click += new System.EventHandler(this.Button_NewFile_Click);
            // 
            // Button_Refuse
            // 
            this.Button_Refuse.BackColor = System.Drawing.Color.Transparent;
            this.Button_Refuse.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(145)))), ((int)(((byte)(145)))));
            this.Button_Refuse.Location = new System.Drawing.Point(455, 0);
            this.Button_Refuse.Margin = new System.Windows.Forms.Padding(0);
            this.Button_Refuse.MinimumSize = new System.Drawing.Size(30, 30);
            this.Button_Refuse.Name = "Button_Refuse";
            this.Button_Refuse.Size = new System.Drawing.Size(135, 40);
            this.Button_Refuse.TabIndex = 6;
            this.Button_Refuse.Click += new System.EventHandler(this.Button_Refuse_Click);
            // 
            // ViewFrame
            // 
            this.ViewFrame.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.ViewFrame.Location = new System.Drawing.Point(120, 49);
            this.ViewFrame.Name = "ViewFrame";
            this.ViewFrame.Size = new System.Drawing.Size(350, 264);
            this.ViewFrame.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ViewFrame.TabIndex = 1;
            this.ViewFrame.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Black", 12F);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.label1.Location = new System.Drawing.Point(173, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(245, 21);
            this.label1.TabIndex = 3;
            this.label1.Text = "Make your screen come to life";
            // 
            // FirstStart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(590, 391);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.ViewFrame);
            this.Controls.Add(this.label1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.HelpButton = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(600, 400);
            this.Name = "FirstStart";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " Hello";
            this.HelpButtonClicked += new System.ComponentModel.CancelEventHandler(this.FirstStart_HelpButtonClicked);
            this.Load += new System.EventHandler(this.StartBackground_Load);
            this.BackMenuChoose.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ViewFrame)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox ViewFrame;
        private System.Windows.Forms.OpenFileDialog GetMediaFile;
        private System.Windows.Forms.ContextMenuStrip BackMenuChoose;
        private System.Windows.Forms.ToolStripMenuItem BackMenu_Gif;
        private System.Windows.Forms.ToolStripMenuItem BackMenu_WebComponent;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ColorDialog ColorPicker_MenuPicker;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private Elements.Round_Button Button_NewFile;
        private Elements.Round_Button Button_Informations;
        private Elements.Round_Button Button_Refuse;
    }
}