using System;
using System.Drawing;
using System.Windows.Forms;
using AniDeskimated.Classes;

namespace AniDeskimated.Forms.Media_Settings
{
    public partial class Control_Scale : UserControl
    {
        public Control_Scale(){InitializeComponent();}
        #region Events
        private void Scale_Tracker_Scroll(object sender, EventArgs e) { Label_StatusPercentage.Text = Scale_Tracker.Value.ToString() + '%'; ScaleView.Invalidate(); }
        private void ScaleView_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.FillRectangle(new SolidBrush(Color.White), new Rectangle(
                new Point((ScaleView.Width - ((Scale_Tracker.Value * ScaleView.Width) / 100)) / 2, 0),
                new Size((Scale_Tracker.Value * ScaleView.Width) / 100, Scale_Tracker.Value % ScaleView.Height)));
            if (Scale_Tracker.Value >= 100) { e.Graphics.FillRectangle(new SolidBrush(Color.White), new Rectangle(new Point(0, 0), ScaleView.Size)); }
        }
        private void Button_Done_Click(object sender, EventArgs e) { MainFunctions.ChangeScale(Scale_Tracker.Value); this.Visible = false; }
        private void Scale_Tracker_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Shift)
                Scale_Tracker.SmallChange = 5;
        }
        private void Scale_Tracker_KeyUp(object sender, KeyEventArgs e) { Scale_Tracker.SmallChange = 1; }
        #region Form
        private void Control_Scale_Load(object sender, EventArgs e)
        {
            Button_Done.Button_Part.Text = "Done"; Scale_Tracker.Value = Convert.ToInt32(MainFunctions.ReadKey("viewScale"));
            Label_StatusPercentage.Text = MainFunctions.ReadKey("viewScale") + '%'; ScaleView.Invalidate();
        }
        #endregion

        #endregion
    }
}
