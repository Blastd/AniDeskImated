/*AniDeskImated - By Blasted Mind
 * Draw Behind Desktop feature (Win32.cs and highlighted parts of DeskSettings.cs) are 3rd party derivates that are protected by the Code Project Open Licence (http://www.codeproject.com/info/cpol10.aspx).
 * This Program is released under the GNU LGPL v3.0 License
 */
using System;
using System.Drawing;
using System.Windows.Forms;
using AniDeskimated.Classes;

namespace AniDeskimated.Forms.Elements
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
