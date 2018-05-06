using System.Windows.Forms;

namespace AniDeskimated.Forms
{
    partial class Form_License
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
            this.License_Body = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // License_Body
            // 
            this.License_Body.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(16)))), ((int)(((byte)(16)))));
            this.License_Body.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.License_Body.Dock = System.Windows.Forms.DockStyle.Fill;
            this.License_Body.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.License_Body.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.License_Body.ImeMode = System.Windows.Forms.ImeMode.On;
            this.License_Body.Location = new System.Drawing.Point(10, 0);
            this.License_Body.Name = "License_Body";
            this.License_Body.ReadOnly = true;
            this.License_Body.Size = new System.Drawing.Size(693, 481);
            this.License_Body.TabIndex = 0;
            this.License_Body.Text = "";
            // 
            // Form_License
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(16)))), ((int)(((byte)(16)))));
            this.ClientSize = new System.Drawing.Size(703, 481);
            this.Controls.Add(this.License_Body);
            this.MinimizeBox = false;
            this.Name = "Form_License";
            this.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "AniDeskImated - License";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.Form_License_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private RichTextBox License_Body;
    }
}