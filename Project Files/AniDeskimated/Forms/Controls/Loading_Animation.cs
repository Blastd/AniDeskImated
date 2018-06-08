using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AniDeskimated.Classes;

namespace AniDeskimated.Forms.Controls
{
    public partial class Loading_Animation : UserControl
    {
        public Loading_Animation()=>InitializeComponent();
        #region Global Variables
        int startAngle = -90;
        #endregion
        #region Events
        private void Draw_Clock_Tick(object sender, EventArgs e)
        {
            startAngle += 6;
            this.Invalidate();
        }
        #region Form
        private void Loading_Animation_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            e.Graphics.DrawArc(new Pen(MainFunctions.Color_Check(), 3), 2, 2, this.Width - 4, this.Height - 4, startAngle, (float)MainFunctions.Proportion(32, 90, (this.Height + this.Width) / 2));
        }
        #endregion
        #endregion

    }
}
