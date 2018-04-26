using AniDeskimated.Classes;
using System.Drawing;

namespace AniDeskimated.Forms
{
    partial class ShowView
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
            this.CheckChange = new System.Windows.Forms.Timer(this.components);
            this.ViewPart = new System.Windows.Forms.WebBrowser();
            this.SuspendLayout();
            // 
            // CheckChange
            // 
            this.CheckChange.Interval = 10000;
            this.CheckChange.Tick += new System.EventHandler(this.CheckChange_Tick);
            // 
            // ViewPart
            // 
            this.ViewPart.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ViewPart.IsWebBrowserContextMenuEnabled = false;
            this.ViewPart.Location = new System.Drawing.Point(0, 0);
            this.ViewPart.MinimumSize = new System.Drawing.Size(20, 20);
            this.ViewPart.Name = "ViewPart";
            this.ViewPart.ScriptErrorsSuppressed = true;
            this.ViewPart.ScrollBarsEnabled = false;
            this.ViewPart.Size = new System.Drawing.Size(284, 261);
            this.ViewPart.TabIndex = 0;
            this.ViewPart.WebBrowserShortcutsEnabled = false;
            this.ViewPart.Navigated += new System.Windows.Forms.WebBrowserNavigatedEventHandler(this.ViewPart_Navigated);
            // 
            // ShowView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.ViewPart);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ShowView";
            this.Text = "ShowView";
            this.Load += new System.EventHandler(this.ShowView_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.ShowView_Paint);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Timer CheckChange;
        private System.Windows.Forms.WebBrowser ViewPart;
    }
}