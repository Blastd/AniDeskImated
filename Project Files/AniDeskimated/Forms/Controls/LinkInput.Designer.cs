namespace AniDeskimated.Forms.Controls
{
    partial class LinkInput
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
            this.Link_Try = new AniDeskimated.Forms.Controls.Round_Button();
            this.input_box = new System.Windows.Forms.TextBox();
            this.message_label = new System.Windows.Forms.Label();
            this.loading_Animation1 = new AniDeskimated.Forms.Controls.Loading_Animation();
            this.SuspendLayout();
            // 
            // Link_Try
            // 
            this.Link_Try.BackColor = System.Drawing.Color.Transparent;
            this.Link_Try.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(145)))), ((int)(((byte)(145)))));
            this.Link_Try.Location = new System.Drawing.Point(366, 79);
            this.Link_Try.Margin = new System.Windows.Forms.Padding(0);
            this.Link_Try.MinimumSize = new System.Drawing.Size(30, 30);
            this.Link_Try.Name = "Link_Try";
            this.Link_Try.Size = new System.Drawing.Size(32, 32);
            this.Link_Try.TabIndex = 0;
            this.Link_Try.Click += new System.EventHandler(this.Link_Try_Click);
            // 
            // input_box
            // 
            this.input_box.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(16)))), ((int)(((byte)(16)))));
            this.input_box.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.input_box.Font = new System.Drawing.Font("Segoe UI Black", 17.5F);
            this.input_box.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.input_box.Location = new System.Drawing.Point(46, 79);
            this.input_box.Name = "input_box";
            this.input_box.Size = new System.Drawing.Size(310, 32);
            this.input_box.TabIndex = 1;
            this.input_box.KeyDown += new System.Windows.Forms.KeyEventHandler(this.input_box_KeyDown);
            // 
            // message_label
            // 
            this.message_label.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.message_label.Font = new System.Drawing.Font("Segoe UI Black", 10F);
            this.message_label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.message_label.Location = new System.Drawing.Point(0, 34);
            this.message_label.Name = "message_label";
            this.message_label.Size = new System.Drawing.Size(440, 19);
            this.message_label.TabIndex = 2;
            this.message_label.Text = "Enter a valid address that links to your chosen file";
            this.message_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // loading_Animation1
            // 
            this.loading_Animation1.BackColor = System.Drawing.Color.Transparent;
            this.loading_Animation1.Location = new System.Drawing.Point(366, 79);
            this.loading_Animation1.MinimumSize = new System.Drawing.Size(32, 32);
            this.loading_Animation1.Name = "loading_Animation1";
            this.loading_Animation1.Size = new System.Drawing.Size(32, 32);
            this.loading_Animation1.TabIndex = 3;
            // 
            // LinkInput
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.ClientSize = new System.Drawing.Size(440, 150);
            this.Controls.Add(this.Link_Try);
            this.Controls.Add(this.message_label);
            this.Controls.Add(this.input_box);
            this.Controls.Add(this.loading_Animation1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "LinkInput";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "LinkInput";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.LinkInput_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Round_Button Link_Try;
        private System.Windows.Forms.TextBox input_box;
        private System.Windows.Forms.Label message_label;
        private Loading_Animation loading_Animation1;
    }
}