namespace AniDeskimated.Forms.Media_Settings
{
    partial class Control_EffectsDesigner
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
            this.eff_Container = new System.Windows.Forms.FlowLayoutPanel();
            this.Top_container = new System.Windows.Forms.FlowLayoutPanel();
            this.button1 = new System.Windows.Forms.Button();
            this.Button_Container = new System.Windows.Forms.FlowLayoutPanel();
            this.Bottom_Container = new System.Windows.Forms.TableLayoutPanel();
            this.btt_Submit = new AniDeskimated.Forms.Elements.Round_Button();
            this.eff_Container.SuspendLayout();
            this.Top_container.SuspendLayout();
            this.Button_Container.SuspendLayout();
            this.Bottom_Container.SuspendLayout();
            this.SuspendLayout();
            // 
            // eff_Container
            // 
            this.eff_Container.Controls.Add(this.Top_container);
            this.eff_Container.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.eff_Container.Location = new System.Drawing.Point(0, 0);
            this.eff_Container.Margin = new System.Windows.Forms.Padding(0);
            this.eff_Container.Name = "eff_Container";
            this.eff_Container.Size = new System.Drawing.Size(434, 414);
            this.eff_Container.TabIndex = 18;
            this.eff_Container.WrapContents = false;
            // 
            // Top_container
            // 
            this.Top_container.AutoSize = true;
            this.Top_container.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Top_container.Controls.Add(this.button1);
            this.Top_container.Dock = System.Windows.Forms.DockStyle.Top;
            this.Top_container.Location = new System.Drawing.Point(3, 3);
            this.Top_container.Name = "Top_container";
            this.Top_container.Size = new System.Drawing.Size(428, 31);
            this.Top_container.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Segoe UI Black", 10F);
            this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.button1.Location = new System.Drawing.Point(3, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(422, 25);
            this.button1.TabIndex = 0;
            this.button1.Text = "+ Add";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // Button_Container
            // 
            this.Button_Container.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Button_Container.AutoScroll = true;
            this.Button_Container.AutoSize = true;
            this.Button_Container.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Button_Container.Controls.Add(this.btt_Submit);
            this.Button_Container.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.Button_Container.Location = new System.Drawing.Point(168, 2);
            this.Button_Container.Margin = new System.Windows.Forms.Padding(0);
            this.Button_Container.Name = "Button_Container";
            this.Button_Container.Size = new System.Drawing.Size(97, 40);
            this.Button_Container.TabIndex = 19;
            // 
            // Bottom_Container
            // 
            this.Bottom_Container.ColumnCount = 3;
            this.Bottom_Container.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.Bottom_Container.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.Bottom_Container.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.Bottom_Container.Controls.Add(this.Button_Container, 1, 0);
            this.Bottom_Container.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Bottom_Container.Location = new System.Drawing.Point(0, 417);
            this.Bottom_Container.Name = "Bottom_Container";
            this.Bottom_Container.RowCount = 1;
            this.Bottom_Container.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.Bottom_Container.Size = new System.Drawing.Size(434, 44);
            this.Bottom_Container.TabIndex = 20;
            // 
            // btt_Submit
            // 
            this.btt_Submit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btt_Submit.BackColor = System.Drawing.Color.Transparent;
            this.btt_Submit.Font = new System.Drawing.Font("Segoe MDL2 Assets", 8.25F);
            this.btt_Submit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(56)))), ((int)(((byte)(145)))));
            this.btt_Submit.Location = new System.Drawing.Point(5, 5);
            this.btt_Submit.Margin = new System.Windows.Forms.Padding(5);
            this.btt_Submit.MinimumSize = new System.Drawing.Size(30, 30);
            this.btt_Submit.Name = "btt_Submit";
            this.btt_Submit.Size = new System.Drawing.Size(87, 30);
            this.btt_Submit.TabIndex = 9;
            // 
            // Control_EffectsDesigner
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.ClientSize = new System.Drawing.Size(434, 461);
            this.Controls.Add(this.Bottom_Container);
            this.Controls.Add(this.eff_Container);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Control_EffectsDesigner";
            this.ShowIcon = false;
            this.TopMost = true;
            this.Load += new System.EventHandler(this.Control_EffectsDesigner_Load);
            this.eff_Container.ResumeLayout(false);
            this.eff_Container.PerformLayout();
            this.Top_container.ResumeLayout(false);
            this.Button_Container.ResumeLayout(false);
            this.Bottom_Container.ResumeLayout(false);
            this.Bottom_Container.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.FlowLayoutPanel eff_Container;
        private System.Windows.Forms.FlowLayoutPanel Button_Container;
        private Elements.Round_Button btt_Submit;
        private System.Windows.Forms.TableLayoutPanel Bottom_Container;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.FlowLayoutPanel Top_container;
    }
}