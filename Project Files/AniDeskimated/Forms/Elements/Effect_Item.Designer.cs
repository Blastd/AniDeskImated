namespace AniDeskimated.Forms.Elements
{
    partial class Effect_Item
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
            this.EFF_Value = new System.Windows.Forms.TrackBar();
            this.Eff_Label = new System.Windows.Forms.Label();
            this.ValueContainer2 = new System.Windows.Forms.FlowLayoutPanel();
            this.EFF_Val_Label = new System.Windows.Forms.Label();
            this.Arg_Extension = new System.Windows.Forms.Label();
            this.Value_Container1 = new System.Windows.Forms.TableLayoutPanel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this.EFF_Value)).BeginInit();
            this.ValueContainer2.SuspendLayout();
            this.Value_Container1.SuspendLayout();
            this.SuspendLayout();
            // 
            // EFF_Value
            // 
            this.EFF_Value.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.EFF_Value.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.EFF_Value.Location = new System.Drawing.Point(0, 64);
            this.EFF_Value.Name = "EFF_Value";
            this.EFF_Value.Size = new System.Drawing.Size(360, 45);
            this.EFF_Value.TabIndex = 0;
            this.EFF_Value.TickStyle = System.Windows.Forms.TickStyle.None;
            this.EFF_Value.ValueChanged += new System.EventHandler(this.EFF_Value_ValueChanged);
            // 
            // Eff_Label
            // 
            this.Eff_Label.Dock = System.Windows.Forms.DockStyle.Top;
            this.Eff_Label.Font = new System.Drawing.Font("Segoe UI Black", 9F);
            this.Eff_Label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Eff_Label.Location = new System.Drawing.Point(0, 0);
            this.Eff_Label.Name = "Eff_Label";
            this.Eff_Label.Size = new System.Drawing.Size(360, 23);
            this.Eff_Label.TabIndex = 1;
            this.Eff_Label.Text = "label1";
            this.Eff_Label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ValueContainer2
            // 
            this.ValueContainer2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.ValueContainer2.AutoSize = true;
            this.ValueContainer2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ValueContainer2.Controls.Add(this.EFF_Val_Label);
            this.ValueContainer2.Controls.Add(this.Arg_Extension);
            this.ValueContainer2.Location = new System.Drawing.Point(126, 6);
            this.ValueContainer2.Name = "ValueContainer2";
            this.ValueContainer2.Size = new System.Drawing.Size(107, 28);
            this.ValueContainer2.TabIndex = 2;
            this.ValueContainer2.WrapContents = false;
            // 
            // EFF_Val_Label
            // 
            this.EFF_Val_Label.AutoSize = true;
            this.EFF_Val_Label.Font = new System.Drawing.Font("Segoe UI Black", 15F);
            this.EFF_Val_Label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.EFF_Val_Label.Location = new System.Drawing.Point(0, 0);
            this.EFF_Val_Label.Margin = new System.Windows.Forms.Padding(0);
            this.EFF_Val_Label.Name = "EFF_Val_Label";
            this.EFF_Val_Label.Size = new System.Drawing.Size(58, 28);
            this.EFF_Val_Label.TabIndex = 0;
            this.EFF_Val_Label.Text = "1000";
            // 
            // Arg_Extension
            // 
            this.Arg_Extension.AutoSize = true;
            this.Arg_Extension.Font = new System.Drawing.Font("Segoe UI Black", 15F);
            this.Arg_Extension.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Arg_Extension.Location = new System.Drawing.Point(58, 0);
            this.Arg_Extension.Margin = new System.Windows.Forms.Padding(0);
            this.Arg_Extension.Name = "Arg_Extension";
            this.Arg_Extension.Size = new System.Drawing.Size(49, 28);
            this.Arg_Extension.TabIndex = 1;
            this.Arg_Extension.Text = "deg";
            this.Arg_Extension.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Value_Container1
            // 
            this.Value_Container1.ColumnCount = 3;
            this.Value_Container1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.Value_Container1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.Value_Container1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.Value_Container1.Controls.Add(this.ValueContainer2, 1, 0);
            this.Value_Container1.Controls.Add(this.flowLayoutPanel1, 2, 0);
            this.Value_Container1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Value_Container1.Location = new System.Drawing.Point(0, 23);
            this.Value_Container1.Name = "Value_Container1";
            this.Value_Container1.RowCount = 1;
            this.Value_Container1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.Value_Container1.Size = new System.Drawing.Size(360, 41);
            this.Value_Container1.TabIndex = 2;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(239, 3);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(118, 35);
            this.flowLayoutPanel1.TabIndex = 3;
            // 
            // Effect_Item
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.Value_Container1);
            this.Controls.Add(this.Eff_Label);
            this.Controls.Add(this.EFF_Value);
            this.DoubleBuffered = true;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "Effect_Item";
            this.Size = new System.Drawing.Size(360, 109);
            this.SizeChanged += new System.EventHandler(this.Effect_Item_SizeChanged);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Effect_Item_Paint);
            ((System.ComponentModel.ISupportInitialize)(this.EFF_Value)).EndInit();
            this.ValueContainer2.ResumeLayout(false);
            this.ValueContainer2.PerformLayout();
            this.Value_Container1.ResumeLayout(false);
            this.Value_Container1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.TrackBar EFF_Value;
        public System.Windows.Forms.Label Eff_Label;
        public System.Windows.Forms.FlowLayoutPanel ValueContainer2;
        public System.Windows.Forms.Label EFF_Val_Label;
        public System.Windows.Forms.Label Arg_Extension;
        public System.Windows.Forms.TableLayoutPanel Value_Container1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
    }
}
