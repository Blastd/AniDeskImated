/*AniDeskImated - By Blasted Mind
 * Draw Behind Desktop feature (Win32.cs and highlighted parts of DeskSettings.cs) are 3rd party derivates that are protected by the Code Project Open Licence (http://www.codeproject.com/info/cpol10.aspx).
 * This Program is released under the GNU LGPL v3.0 License
 */
using System;
using System.Windows.Forms;
using System.Drawing;
using AniDeskimated.Classes;

namespace AniDeskimated.Forms.Media_Settings
{
    public partial class Control_Volume : UserControl
    {
        public Control_Volume()=>InitializeComponent();
        #region Events
        private void Button_Exit_Click(object sender, EventArgs e) { this.Visible = false; }
        private void Volume_Tracker_Scroll(object sender, EventArgs e)
        {
            Label_StatusPercentage.Text = Volume_Tracker.Value.ToString() + '%';
            Vol_icon();
        }
        private void Vol_icon()
        {
            if (Volume_Tracker.Value == 0)
            {
                Vol_Icon.Text = "\uE74F";
            }
            else if (Volume_Tracker.Value <= 25)
            {
                Vol_Icon.Text = "\uE992";
            }
            else if (Volume_Tracker.Value <= 50)
            {
                Vol_Icon.Text = "\uE993";
            }
            else if (Volume_Tracker.Value <= 75)
            {
                Vol_Icon.Text = "\uE994";
            }
            else if (Volume_Tracker.Value <= 100)
            {
                Vol_Icon.Text = "\uE995";
            }
        }
        private void Button_Done_Click(object sender, EventArgs e) { MainFunctions.ChangeVolume(Volume_Tracker.Value); this.Visible = false; }
        private void Volume_Tracker_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Shift)
                Volume_Tracker.SmallChange = 5;
        }
        private void Volume_Tracker_KeyUp(object sender, KeyEventArgs e) => Volume_Tracker.SmallChange = 1;
        #region Form
        private void Control_Volume_Load(object sender, EventArgs e){
        #region Button Properties
        Button_Done.Button_Part.Text = "";
        Button_Done.Button_Part.Font = new Font("Segoe MDL2 Assets", Button_Done.Button_Part.Font.Size, FontStyle.Bold);
        #endregion
        Volume_Tracker.Value = Convert.ToInt32(MainFunctions.ReadKey("volumeValue"));
        Label_StatusPercentage.Text = MainFunctions.ReadKey("volumeValue") + '%';
        }
        #endregion

        #endregion

        private void Control_Volume_VisibleChanged(object sender, EventArgs e)
        { Vol_icon(); Label_StatusPercentage.Text = Volume_Tracker.Value.ToString() + '%'; }
    }
}
