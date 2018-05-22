using System;
using System.Windows.Forms;
using AniDeskimated.Classes;

namespace AniDeskimated.Forms.Media_Settings
{
    public partial class Control_Volume : UserControl
    {
        public Control_Volume(){InitializeComponent();}
        #region Events
        private void Volume_Tracker_Scroll(object sender, EventArgs e) { Label_StatusPercentage.Text = Volume_Tracker.Value.ToString() + '%'; }
        private void Button_Done_Click(object sender, EventArgs e) { MainFunctions.ChangeVolume(Volume_Tracker.Value); this.Visible = false; }
        private void Volume_Tracker_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Shift)
                Volume_Tracker.SmallChange = 5;
        }
        private void Volume_Tracker_KeyUp(object sender, KeyEventArgs e) { Volume_Tracker.SmallChange = 1; }

        #region Form
        private void Control_Volume_Load(object sender, EventArgs e)
        { Button_Done.Button_Part.Text = "Done"; Volume_Tracker.Value = Convert.ToInt32(MainFunctions.ReadKey("volumeValue")); Label_StatusPercentage.Text = MainFunctions.ReadKey("volumeValue") + '%'; }
        #endregion

        #endregion
    }
}
