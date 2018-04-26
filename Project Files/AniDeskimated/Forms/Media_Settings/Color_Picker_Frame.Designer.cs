namespace AniDeskimated.Forms.Interfaces
{
    partial class Color_Picker_Frame
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
            this.Picture_Container = new System.Windows.Forms.FlowLayoutPanel();
            this.image_display = new System.Windows.Forms.PictureBox();
            this.Picture_Container.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.image_display)).BeginInit();
            this.SuspendLayout();
            // 
            // Picture_Container
            // 
            this.Picture_Container.AutoScroll = true;
            this.Picture_Container.Controls.Add(this.image_display);
            this.Picture_Container.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Picture_Container.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.Picture_Container.Location = new System.Drawing.Point(0, 0);
            this.Picture_Container.Name = "Picture_Container";
            this.Picture_Container.Size = new System.Drawing.Size(584, 361);
            this.Picture_Container.TabIndex = 0;
            this.Picture_Container.MouseWheel += new System.Windows.Forms.MouseEventHandler(this.Picture_Container_Scroll);
            // 
            // image_display
            // 
            this.image_display.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.image_display.Location = new System.Drawing.Point(3, 3);
            this.image_display.Name = "image_display";
            this.image_display.Size = new System.Drawing.Size(581, 358);
            this.image_display.TabIndex = 0;
            this.image_display.TabStop = false;
            this.image_display.MouseClick += new System.Windows.Forms.MouseEventHandler(this.image_display_MouseClick);
            // 
            // Color_Picker_Frame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(584, 361);
            this.ControlBox = false;
            this.Controls.Add(this.Picture_Container);
            this.Font = new System.Drawing.Font("Segoe UI Light", 8.25F);
            this.Name = "Color_Picker_Frame";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pick a Color";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Color_Picker_Frame_FormClosing);
            this.Load += new System.EventHandler(this.Color_Picker_Frame_Load);
            this.Picture_Container.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.image_display)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel Picture_Container;
        private System.Windows.Forms.PictureBox image_display;
    }
}