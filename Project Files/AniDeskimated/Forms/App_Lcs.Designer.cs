using System.Windows.Forms;

namespace AniDeskimated.Forms
{
    partial class App_Lcs
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
            this.tab_m = new System.Windows.Forms.TabControl();
            this.tab_about = new System.Windows.Forms.TabPage();
            this.lcs_b0 = new System.Windows.Forms.RichTextBox();
            this.lcs1 = new System.Windows.Forms.TabPage();
            this.lcs_b1 = new System.Windows.Forms.RichTextBox();
            this.lcs2 = new System.Windows.Forms.TabPage();
            this.lcs_b2 = new System.Windows.Forms.RichTextBox();
            this.lcs3 = new System.Windows.Forms.TabPage();
            this.lcs_b3 = new System.Windows.Forms.RichTextBox();
            this.tab_m.SuspendLayout();
            this.tab_about.SuspendLayout();
            this.lcs1.SuspendLayout();
            this.lcs2.SuspendLayout();
            this.lcs3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tab_m
            // 
            this.tab_m.Controls.Add(this.tab_about);
            this.tab_m.Controls.Add(this.lcs1);
            this.tab_m.Controls.Add(this.lcs2);
            this.tab_m.Controls.Add(this.lcs3);
            this.tab_m.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tab_m.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.tab_m.Location = new System.Drawing.Point(0, 0);
            this.tab_m.Name = "tab_m";
            this.tab_m.Padding = new System.Drawing.Point(0, 0);
            this.tab_m.SelectedIndex = 0;
            this.tab_m.Size = new System.Drawing.Size(703, 481);
            this.tab_m.TabIndex = 0;
            // 
            // tab_about
            // 
            this.tab_about.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(16)))), ((int)(((byte)(16)))));
            this.tab_about.Controls.Add(this.lcs_b0);
            this.tab_about.Location = new System.Drawing.Point(4, 22);
            this.tab_about.Name = "tab_about";
            this.tab_about.Padding = new System.Windows.Forms.Padding(3);
            this.tab_about.Size = new System.Drawing.Size(695, 455);
            this.tab_about.TabIndex = 3;
            this.tab_about.Text = "About";
            // 
            // lcs_b0
            // 
            this.lcs_b0.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(16)))), ((int)(((byte)(16)))));
            this.lcs_b0.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lcs_b0.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lcs_b0.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.lcs_b0.Location = new System.Drawing.Point(3, 3);
            this.lcs_b0.Name = "lcs_b0";
            this.lcs_b0.ReadOnly = true;
            this.lcs_b0.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.lcs_b0.Size = new System.Drawing.Size(689, 449);
            this.lcs_b0.TabIndex = 1;
            this.lcs_b0.Text = "";
            // 
            // lcs1
            // 
            this.lcs1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(16)))), ((int)(((byte)(16)))));
            this.lcs1.Controls.Add(this.lcs_b1);
            this.lcs1.Location = new System.Drawing.Point(4, 22);
            this.lcs1.Name = "lcs1";
            this.lcs1.Padding = new System.Windows.Forms.Padding(3);
            this.lcs1.Size = new System.Drawing.Size(695, 455);
            this.lcs1.TabIndex = 0;
            this.lcs1.Text = "LGPL 3.0";
            // 
            // lcs_b1
            // 
            this.lcs_b1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(16)))), ((int)(((byte)(16)))));
            this.lcs_b1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lcs_b1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lcs_b1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.lcs_b1.Location = new System.Drawing.Point(3, 3);
            this.lcs_b1.Name = "lcs_b1";
            this.lcs_b1.ReadOnly = true;
            this.lcs_b1.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.lcs_b1.Size = new System.Drawing.Size(689, 449);
            this.lcs_b1.TabIndex = 0;
            this.lcs_b1.Text = "";
            // 
            // lcs2
            // 
            this.lcs2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(16)))), ((int)(((byte)(16)))));
            this.lcs2.Controls.Add(this.lcs_b2);
            this.lcs2.Location = new System.Drawing.Point(4, 22);
            this.lcs2.Name = "lcs2";
            this.lcs2.Padding = new System.Windows.Forms.Padding(3);
            this.lcs2.Size = new System.Drawing.Size(695, 455);
            this.lcs2.TabIndex = 1;
            this.lcs2.Text = "Gnu GPL 3.0";
            // 
            // lcs_b2
            // 
            this.lcs_b2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(16)))), ((int)(((byte)(16)))));
            this.lcs_b2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lcs_b2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lcs_b2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.lcs_b2.Location = new System.Drawing.Point(3, 3);
            this.lcs_b2.Name = "lcs_b2";
            this.lcs_b2.ReadOnly = true;
            this.lcs_b2.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.lcs_b2.Size = new System.Drawing.Size(689, 449);
            this.lcs_b2.TabIndex = 1;
            this.lcs_b2.Text = "";
            // 
            // lcs3
            // 
            this.lcs3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(16)))), ((int)(((byte)(16)))));
            this.lcs3.Controls.Add(this.lcs_b3);
            this.lcs3.Location = new System.Drawing.Point(4, 22);
            this.lcs3.Name = "lcs3";
            this.lcs3.Padding = new System.Windows.Forms.Padding(3);
            this.lcs3.Size = new System.Drawing.Size(695, 455);
            this.lcs3.TabIndex = 2;
            this.lcs3.Text = "CPOL";
            // 
            // lcs_b3
            // 
            this.lcs_b3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(16)))), ((int)(((byte)(16)))));
            this.lcs_b3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lcs_b3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lcs_b3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.lcs_b3.Location = new System.Drawing.Point(3, 3);
            this.lcs_b3.Name = "lcs_b3";
            this.lcs_b3.ReadOnly = true;
            this.lcs_b3.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.lcs_b3.Size = new System.Drawing.Size(689, 449);
            this.lcs_b3.TabIndex = 1;
            this.lcs_b3.Text = "";
            // 
            // App_Lcs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(16)))), ((int)(((byte)(16)))));
            this.ClientSize = new System.Drawing.Size(703, 481);
            this.Controls.Add(this.tab_m);
            this.MinimizeBox = false;
            this.Name = "App_Lcs";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "AniDeskImated - License";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.Form_License_Load);
            this.tab_m.ResumeLayout(false);
            this.tab_about.ResumeLayout(false);
            this.lcs1.ResumeLayout(false);
            this.lcs2.ResumeLayout(false);
            this.lcs3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private TabControl tab_m;
        private TabPage lcs1;
        private TabPage lcs2;
        private TabPage lcs3;
        private RichTextBox lcs_b1;
        private RichTextBox lcs_b2;
        private RichTextBox lcs_b3;
        private TabPage tab_about;
        private RichTextBox lcs_b0;
    }
}