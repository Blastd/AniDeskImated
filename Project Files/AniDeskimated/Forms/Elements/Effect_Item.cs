using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;

namespace AniDeskimated.Forms.Elements
{
    public partial class Effect_Item : UserControl
    {
        public Effect_Item() => InitializeComponent();

        public int PropS()
        {
            return (this.Height * 90) / 100;
        }

        private void Effect_Item_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            GraphicsPath Dp = new GraphicsPath();
            Dp.AddArc(new Rectangle(new Point(this.Width-PropS(),this.Height-PropS()),
                new Size(PropS(), PropS())), 0,90);
            Dp.AddArc(new Rectangle(new Point(0, this.Height - PropS()),
                new Size(PropS(),PropS())), 90,90);
            Dp.AddArc(new Rectangle(new Point(0,0),
                new Size(PropS(), PropS())), 180, 90);
            Dp.AddArc(new Rectangle(new Point(this.Width-PropS(),0),
                new Size(PropS(), PropS())), 270, 90);
            Dp.CloseFigure();
            e.Graphics.FillPath(new SolidBrush(Color.FromArgb(255, 28, 28, 28)),Dp);
        }

        private void Effect_Item_SizeChanged(object sender, EventArgs e)
        {
            this.CreateGraphics().Dispose();
        }

        private void EFF_Value_ValueChanged(object sender, EventArgs e)
        {
            EFF_Val_Label.Text = EFF_Value.Value.ToString();
        }
    }
}
